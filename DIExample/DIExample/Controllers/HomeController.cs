using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace DIExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View(new InMemoryProductRepository().Products);
    }
}