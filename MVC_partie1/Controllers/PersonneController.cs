using MVC_partie1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_partie1.Controllers
{
    public class PersonneController : Controller
    {
        // GET: Personne
        public ActionResult Personne()
        {
            
            Personne obj = new Personne();
            
            //obj.age = 0;
            //obj.nom = " ";
            //obj.prenom = " ";
            
                obj.age = Convert.ToInt32(Request.Form["age"]);
               
            if (obj.nom!=null)   
                obj.nom = Request.Form["nom"].ToString();

            if (obj.prenom != null)
                obj.prenom = Request.Form["prenom"].ToString();

            return View(obj);
        }
        public ActionResult Index()
        {
           
            return View();
        }
    }
}