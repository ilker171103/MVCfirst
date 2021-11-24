using Microsoft.AspNetCore.Mvc;
using MVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC1.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult ById(string name)
        {
            var viewModel = new DataViewModel();
            viewModel.ParameterValue = name;
            this.ViewBag.Name = "Asen";
            return this.View(viewModel);
        }
    }
}
