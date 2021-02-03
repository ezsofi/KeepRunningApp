using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeepRunning.Model.Entities
{
    public class TrainingPlan
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime FinishedAtPlanned { get; set; }
        public DateTime? FinishedAtActual { get; set; }
        public Runner Runner { get; set; }
        public List<Training> Trainings { get; set; }
    }
}
