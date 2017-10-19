using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}
