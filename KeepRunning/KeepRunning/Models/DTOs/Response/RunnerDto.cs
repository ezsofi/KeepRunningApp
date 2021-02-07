using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepRunning.Models.DTOs.Response
{
    public class RunnerDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime RegisteredAt { get; set; }
        public TrainingPlanDto TrainingPlans { get; set; }
    }
}
