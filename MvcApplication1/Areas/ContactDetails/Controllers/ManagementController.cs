﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Areas.ContactDetails.Controllers
{
    public class ManagementController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }        

        [HttpPost]
        public ActionResult Index(ContactDetails.Models.ContactDetails details)
        {
            return View(details);
        }        
    }
}
