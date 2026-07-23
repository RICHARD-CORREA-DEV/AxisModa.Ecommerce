using AxisModa.Ecommerce.Data;
using AxisModa.Ecommerce.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AxisModa.Ecommerce.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public ProdutosController(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public async Task<IActionResult> Index()
        {
            var produtos = await _context.Produtos.ToListAsync();
            return View(produtos);
        }

        public IActionResult Criar() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(Produto produto, IFormFile foto)
        {
            if (foto != null && foto.Length > 0)
            {
                var nomeArquivo = Guid.NewGuid().ToString() + Path.GetExtension(foto.FileName);
                var caminhoSalvar = Path.Combine(_environment.WebRootPath, "uploads", "produtos", nomeArquivo);

                using (var stream = new FileStream(caminhoSalvar, FileMode.Create))
                {
                    await foto.CopyToAsync(stream);
                }

                produto.DefinirImagem($"/uploads/produtos/{nomeArquivo}");
            }

            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
