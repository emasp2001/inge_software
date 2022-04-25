using Microsoft.AspNetCore.Mvc;
using lab03.Models;
using System;
using System.Collections.Generic;

namespace lab03.Controllers
{
  public class MusicController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
