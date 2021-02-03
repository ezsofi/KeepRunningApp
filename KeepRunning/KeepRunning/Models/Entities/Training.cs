using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeepRunning.Models.Entities
{
    public class Training
    {
        public int Id { get; set; }
        public DateTime DatePlanned { get; set; }
        public DateTime DateActual { get; set; }
        public string DayOfWeekPlanned { get; set; }
        public string Code { get; set; }
        public string TrainingType { get; set; }
        public TrainingPlan TrainingPlan { get; set; }
        public string Description { get; set; }
        public int TotalTimeMinutes { get; set; }
    }
}
