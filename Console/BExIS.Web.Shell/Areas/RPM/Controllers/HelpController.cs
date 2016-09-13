﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using BExIS.Xml.Helpers;
using BExIS.Web.Shell.Areas.RPM.Models;
using System.Windows;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Vaiona.Utils.Cfg;
using System.IO;
using BExIS.IO.Transform.Input;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using Vaiona.Web.Mvc.Models;
using Vaiona.Web.Extensions;

namespace BExIS.Web.Shell.Areas.RPM.Controllers
{
    public class HelpController : Controller
    {
        //
        // GET: /DDM/Help/

        public ActionResult Index()
        {
            ViewBag.Title = PresentationModel.GetViewTitleForTenant("Data Planning Manual", this.Session.GetTenant());
            return View();

        }
    }
}
