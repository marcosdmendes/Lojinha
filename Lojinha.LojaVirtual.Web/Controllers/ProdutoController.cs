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
        private ProdutosRepositorio _repositorio;
        // GET: Produto
        public ActionResult Index()
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos.Take(10);

            var teste = CriarMetodo();

            return View(produtos);
        }

        private object CriarMetodo()
        {
            throw new NotImplementedException();
        }
    }
}