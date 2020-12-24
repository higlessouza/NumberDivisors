using Prova_Localiza.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prova_Localiza.Controllers
{
    public class NumberDivisorsController : Controller
    {
        /// <summary>
        /// Controller principal para realizar as requisições dos divisores dos numeros
        /// </summary>
        /// <param name="number">Numero a ser buscado os divisores</param>
        /// <returns></returns>
        public JsonResult Index(int number)
        {
            return Json(NumberDecompositionService.GetNumberDivisors(number), JsonRequestBehavior.AllowGet);
        }
    }
}