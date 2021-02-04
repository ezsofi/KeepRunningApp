using KeepRunning.Models.DTOs;
using KeepRunning.Models.DTOs.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeepRunning.Services.Interfaces
{
    public interface ITrainingPlanService
    {
        Task<ResponseMessageDto> CreateAsync(PlanCreateRequestDto newPlan);
    }
}
