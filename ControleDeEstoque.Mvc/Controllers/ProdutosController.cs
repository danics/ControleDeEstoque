using System.Linq;
using System.Threading.Tasks;
using ControleDeEstoque.Application.AppServices;
using ControleDeEstoque.Infra.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleDeEstoque.Mvc.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutosAppServices _produtosAppServices;
        public ProdutosController(IProdutosAppServices produtosAppServices)
        {
            _produtosAppServices = produtosAppServices;
        }
        public async Task<IActionResult> Index()
        {
           return View(await _produtosAppServices.GetAll());
        }
    }
}