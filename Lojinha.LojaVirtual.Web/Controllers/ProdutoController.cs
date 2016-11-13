using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lojinha.LojaVirtual.Dominio.Repositorio;

namespace Lojinha.LojaVirtual.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutosRepositorio _reposirorio;
        // GET: Produto
        public ActionResult Index()
        {
            _reposirorio = new ProdutosRepositorio();
            var produtos = _reposirorio.Produtos.Take(10);

            return View(produtos);
        }
    }
}