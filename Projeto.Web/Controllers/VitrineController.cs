using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.Dados.DataSource;

namespace Projeto.Web.Controllers
{
    public class VitrineController : Controller
    {
        private EfDbContext pr;
        public int ProdutoPorPagina = 2;
        // GET: Vitrine
        public ActionResult ListaProdutos(int pagina = 1)
        {
            pr = new EfDbContext();
            var produtos = pr.Produto.OrderBy(p => p.DescricaoProduto)
                .Skip((pagina - 1) * ProdutoPorPagina)
                .Take(ProdutoPorPagina);

            return View(produtos);
        }
    }
}