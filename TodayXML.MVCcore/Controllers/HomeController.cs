using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using RottenTomatoes.Movie;
using RottenTomatoes.Movie.Model;
using TodayXML.MVCcore.Models;
using TodayXML.MVCcore.Extensions;

namespace TodayXML.MVCcore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IObjectManager<Rootobject> _objectManager { get; set; }
        private Rootobject rootobject;
        private Movie movie;
        public HomeController(ILogger<HomeController> logger, IObjectManager<Rootobject> objectManager)
        {
            _logger = logger;
            _objectManager = objectManager;
            
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
     
        public async Task<IActionResult> Movies(string param = "",int page=1)
        {
            ViewBag.Param = param;
            ViewBag.Page = page;
            var result = await _objectManager.GetAll(param,page);

           
            return View(result);
        }
       
        [HttpGet]
        public async Task<IActionResult> MovieDetail(int id, string param = "", int page = 1)
        {
           
            var result = await _objectManager.GetAll(param, page);
            foreach (var item in result.movies)
            {
                if (item.id == id.ToString())
                {
                    movie = new Movie();
                    movie = item;
                    break;
                }
            }
            return View(movie);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
