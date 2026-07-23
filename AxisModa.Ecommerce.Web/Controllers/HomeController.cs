using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AxisModa.Ecommerce.Web.Models;

namespace AxisModa.Ecommerce.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var produtosMock = new List<ProdutoVitrineViewModel>
            {
                new ProdutoVitrineViewModel
                {
                    Id = Guid.NewGuid(),
                    Nome = "Camiseta Minimalist Black",
                    Descricao = "Camiseta 100% algodao egipcio com caimento oversized premium.",
                    Preco = 129.90m,
                    ImagemUrl = "https://unsplash.com"
                },
                new ProdutoVitrineViewModel
                {
                    Id = Guid.NewGuid(),
                    Nome = "Jaqueta Couro Classic",
                    Descricao = "Jaqueta de couro legitimo com costuras reforcadas e ziper robusto.",
                    Preco = 459.00m,
                    ImagemUrl = "https://unsplash.com"
                },
                new ProdutoVitrineViewModel
                {
                    Id = Guid.NewGuid(),
                    Nome = "Tenis Street Urban v2",
                    Descricao = "Sneaker casual com palmilha ortopedica e solado emborrachado vulcanizado.",
                    Preco = 299.90m,
                    ImagemUrl = "https://unsplash.com"
                },
                new ProdutoVitrineViewModel
                {
                    Id = Guid.NewGuid(),
                    Nome = "Vestido Midi Linen",
                    Descricao = "Vestido casual confeccionado em puro linho texturizado para o verao.",
                    Preco = 249.90m,
                    ImagemUrl = "https://unsplash.com"
                }
            };

            return View(produtosMock);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
