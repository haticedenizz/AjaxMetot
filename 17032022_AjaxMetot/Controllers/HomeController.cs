﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _17032022_AjaxMetot.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Session["veriler"] = liste;
            return View();
        }
           List<string> liste = new List<string>()
             { "laptop","mouse","klavye","hoparlör"};
        public PartialViewResult VeriGetir()
        {
                                System.Threading.Thread.Sleep(3000);

            return PartialView("_VerilerPartialView",liste);
        }
        
        public MvcHtmlString DataSil(int id)
        {
            List<string> liste =(List<string>) Session["veriler"];
            liste.RemoveAt(id);
            Session["veriler"] = liste;

            System.Threading.Thread.Sleep(3000);
   
            return MvcHtmlString.Empty;
        }
    }
}