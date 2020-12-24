using Prova_Localiza.Models;
using Prova_Localiza.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prova_Localiza.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "funciona";
        }

         public JsonResult GetNumberDivisors(int number)
        {
            return Json(NumberDecompositionService.GetNumberDivisors(number),JsonRequestBehavior.AllowGet);
        }
    }
}