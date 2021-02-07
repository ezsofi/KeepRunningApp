using KeepRunning.Models.DTOs.Requests;
using KeepRunning.Models.ViewModels;
using KeepRunning.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KeepRunning.Controllers
{
    public class TrainingplanController : Controller
    {
        private readonly ITrainingPlanService trainingPlanService;

        public TrainingplanController(ITrainingPlanService trainingPlanService)
        {
            this.trainingPlanService = trainingPlanService;
        }

        [HttpGet("createplan")]
        public IActionResult CreatePlan()
        {
            return View("Index", new TrainingPlanViewModel());
        }

        [HttpPost("createplan")]
        public async Task<IActionResult> CreatePlan(TrainingPlanViewModel vm)
        {
            var planCreated = await trainingPlanService.CreateAsync(new PlanCreateRequestDto { PlanName = vm.PlanName, StartDate = vm.StartDate, Email = vm.Email});
            return RedirectToAction();
        }
    }
}
