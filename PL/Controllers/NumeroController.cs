using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class NumeroController : Controller
    {
        // GET: Numero
        public ActionResult GetAll()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Form(ML.Numero numero)
        {
            ML.Result result = new ML.Result();

            result = BL.Numero.NumeroMayorMenor(numero);

            if (result.Correct)
            {
                return View("Modal");
            }
            return View();
        }
    }
}