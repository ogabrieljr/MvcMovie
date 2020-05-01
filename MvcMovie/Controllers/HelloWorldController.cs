using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
  public class HelloWorld : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Welcome(string name, int num = 1)
    {
      ViewData["Message"] = name;
      ViewData["Num"] = num;
      return View();
    }
  }
}
