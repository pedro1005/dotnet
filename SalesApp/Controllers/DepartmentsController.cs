using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SalesApp.Models.ViewModels;
using System.Collections.Generic;
using SalesApp.Models;
using System.Reflection.Metadata.Ecma335;
using SalesApp.Models;

namespace SalesApp.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department {Id = 1, Name = "Eletronics"});
            list.Add(new Department {Id = 2, Name = "Fashion"});

            return View(list);
        }
    }
}