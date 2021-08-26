using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DSJogoV2.Models;

namespace DSJogoV2.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Funcionario()
        {
            var funcionario = new Funcionario();
            return View(funcionario);
        }
        [HttpPost]
        public ActionResult Funcionario(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                return View("FuncionarioResultado", funcionario);
            }
            return View(funcionario);
        }
    }
}