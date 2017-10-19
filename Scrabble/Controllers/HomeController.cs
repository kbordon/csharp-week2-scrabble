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

      [HttpPost("/Result")]
      public ActionResult Score()
      {
        Game newGame = new Game();
        if (newGame.ValidateInput(Request.Form["user-word"]))
        {
          newGame.SetScore(Request.Form["user-word"]);
        }
        return View("Score", newGame);
      }
    }
}
