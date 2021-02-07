using System.Collections.Generic;

namespace KeepRunning.Models.DTOs.Response.TrainingPlans
{
    public class TrainingPlansDto
    {
        public IEnumerable<TrainingPlanDto> Trainings { get; set; }
    }
}
