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
        public JsonResult Index()
        {
            return Json("Exemplo de requisição: http://localhost:port/NumberDivisors?number=90", JsonRequestBehavior.AllowGet);
        }
    }
}