using KeepRunning.Models.DTOs.Extensions;
using KeepRunning.Models.DTOs.Requests;
using KeepRunning.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KeepRunning.Controllers
{
    [Route("plans")]
    public class TrainingPlanController : ControllerBase
    {
        private readonly ITrainingPlanService trainingPlanService;

        public TrainingPlanController(ITrainingPlanService trainingPlanService)
        {
            this.trainingPlanService = trainingPlanService;
        }

        [HttpPost("")]
        public async Task<ActionResult> CreatePlan([FromBody] PlanCreateRequestDto newPlan)
        {
            var planCreated = await trainingPlanService.CreateAsync(newPlan);
            if (!planCreated.Message.Equals($"New training plan({ newPlan.PlanName}) successfully created!"))
            {
                return BadRequest(planCreated.Message);
            }
            return Ok(planCreated.Message);
        }
    }
}
