using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SentimentSuite.AnalyzerWeb.Models;
using SentimentSuite_TrainerUI;
using static SentimentSuite_TrainerUI.SentimentMLModel;

namespace SentimentSuite.AnalyzerWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ModelInput input)
        {
            ModelInput sampleData = new ModelInput()
            {
                SentimentText = input.SentimentText,
            };

            var result = SentimentMLModel.Predict(sampleData);

            // Store result into ViewBag
            ViewBag.Result = result;
            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
