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
    public string Index()
    {
      return "Hello World";
    }

    public string Welcome(string name, int num, int id = 34)
    {
      return $"{name}, {num}, {id}";
    }
  }
}
