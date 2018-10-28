using IvantiTest2.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace IvantiTest2.Controllers
{
    public class HomeController : Controller
    {
        public DateTime RelevantYear = new DateTime(2017, 1, 1);

        public IActionResult Index()
        {
            DeploymentParameters calculatedParameters = DeploymentParametersCalculator.GetAllParameters(GetAllDeployments(), RelevantYear);

            var model = new IndexViewModel()
            {
                SuccessfulDeploymentFrequency = calculatedParameters.DeploymentFrequency,
                RelevantYear = RelevantYear.Year,
                ChangeFailureRate = calculatedParameters.ChangeFailureRate
            };
            return View(model);
        }

        private AllDeployments GetAllDeployments()
        {
            var file = System.IO.File.ReadAllText(@"wwwroot\ReleaseData.json");
            return AllDeployments.FromJson(file);
        }
    }
}
