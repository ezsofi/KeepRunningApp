using KeepRunning.Database;
using KeepRunning.Models.DTOs;
using KeepRunning.Models.DTOs.Requests;
using KeepRunning.Models.Entities;
using KeepRunning.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeepRunning.Services
{
    public class TrainingPlanService :ITrainingPlanService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IRunnerService runnerService;
        public TrainingPlanService(ApplicationDbContext dbContext, IRunnerService runnerService)
        {
            this.dbContext = dbContext;
            this.runnerService = runnerService;
        }
        public async Task<ResponseMessageDto> CreateAsync(PlanCreateRequestDto newPlan)
        {
            var message = string.Empty;
            var runner = await runnerService.GetRunnerByEmail(newPlan.Email);
            if(runner is null)
            {
                message = "Runner was not found";
            }
            var newPlanCreated = new TrainingPlan(newPlan.PlanName, newPlan.StartDate, runner);
            await dbContext.TrainingPlans.AddAsync(newPlanCreated);
            var created = await dbContext.SaveChangesAsync();
            if(created == 0)
            {
                message = "Plan not created! Try again!";
            }
            message = "Ok";
            return new ResponseMessageDto { Message = message };
        }

        public async Task<List<TrainingPlan>?> ReadAllAsync()
        {
            return await dbContext.TrainingPlans.ToListAsync();
        }
    }
}
