using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.Dados.DataSource;

namespace Projeto.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private  EfDbContext pr;
        // GET: Produto
        public ActionResult Index()
        {
            pr = new EfDbContext();
            var produtos = pr.Produto.Take(2);
            return View(produtos);
        }
    }
}