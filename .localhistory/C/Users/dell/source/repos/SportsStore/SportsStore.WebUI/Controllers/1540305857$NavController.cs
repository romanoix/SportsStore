﻿using SportsStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IProductRepository repository;
        public NavController(IProductRepository repo)
        {
            repository = repo;
        }

        public string Menu()
        {
            return "dededed";
            //IEnumerable<string> categories = repository.Products.Select(x => x.Category).Distinct().OrderBy(x => x);
            //return PartialView(categories);

        }
        
       
        
        
        // GET: Nav
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}