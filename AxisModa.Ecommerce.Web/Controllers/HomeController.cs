using System.Diagnostics;
using AxisModa.Ecommerce.Data;
using AxisModa.Ecommerce.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AxisModa.Ecommerce.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var produtosBanco = await _context.Produtos.AsNoTracking().ToListAsync();

            var vitrineVM = produtosBanco.Select(p => new ProdutoVitrineViewModel
            {
                Id = p.Id,
                Nome = p.Nome,
                Descricao = p.Descricao,
                Preco = p.Preco,
                ImagemUrl = p.ImagemUrl
            }).ToList();

            return View(vitrineVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
