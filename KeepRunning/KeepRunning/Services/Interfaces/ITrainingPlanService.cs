using KeepRunning.Models.DTOs;
using KeepRunning.Models.DTOs.Requests;
using KeepRunning.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KeepRunning.Services.Interfaces
{
    public interface ITrainingPlanService
    {
        Task<ResponseMessageDto> CreateAsync(PlanCreateRequestDto newPlan);
        Task<List<TrainingPlan>?> ReadAllAsync();
    }
}
