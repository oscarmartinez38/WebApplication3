using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ParameterViewModel parameterListViewModel = new ParameterViewModel();
            ParameterBusinessLayer parmBal = new ParameterBusinessLayer();
            List<Parameter> parameters = parmBal.GetParameters();
            List<ParameterViewModel> parmViewModels = new List<ParameterViewModel>();

            foreach (Parameter parm in parameters)
            {
                ParameterViewModel parmViewModel = new ParameterViewModel();
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}