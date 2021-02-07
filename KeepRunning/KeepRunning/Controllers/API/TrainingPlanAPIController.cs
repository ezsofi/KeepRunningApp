using KeepRunning.Models.DTOs.Extensions;
using KeepRunning.Models.DTOs.Requests;
using KeepRunning.Models.DTOs.Response.TrainingPlans;
using KeepRunning.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace KeepRunning.Controllers
{
    [Route("plans")]
    public class TrainingPlanAPIController : ControllerBase
    {
        private readonly ITrainingPlanService trainingPlanService;

        public TrainingPlanAPIController(ITrainingPlanService trainingPlanService)
        {
            this.trainingPlanService = trainingPlanService;
        }

        [HttpPost("")]
        public async Task<ActionResult> CreatePlan([FromBody] PlanCreateRequestDto newPlan)
        {
            var planCreated = await trainingPlanService.CreateAsync(newPlan);
            if (!planCreated.Message.Equals("Ok"))
            {
                return BadRequest(planCreated.Message);
            }
            return Ok(planCreated.Message);
        }

        [HttpGet("")]
        public async Task<ActionResult> ReadAll()
        {
            var trainingPlans = await trainingPlanService.ReadAllAsync();
            if (!trainingPlans.Any())
            {
                return NoContent();
            }
            return Ok(new TrainingPlansDto { Trainings = trainingPlans.Select(plan => plan.ToTrainingPlanDto()) });
        }
    }
}
