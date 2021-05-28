using ALDesignPatternMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALDesignPatternMVC.Controllers
{
    public class MotDePasseController : Controller
    {
        // GET: MotDePasse
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Nouveau()
        {
            MotDePasseModel nouveauMotDePasse = new MotDePasseModel();
            nouveauMotDePasse.Login = "daniel.paul";
            return View(nouveauMotDePasse);
        }
    }
}