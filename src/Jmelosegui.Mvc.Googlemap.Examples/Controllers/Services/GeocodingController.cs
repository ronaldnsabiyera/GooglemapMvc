﻿using System.Web.Mvc;

namespace Jmelosegui.Mvc.Googlemap.Examples.Controllers
{
    public partial class ServicesController
    {
        public ActionResult Geocoding(string address)
        {
            return View((object)(address ?? "Madrid, Spain"));
        }
    }
}