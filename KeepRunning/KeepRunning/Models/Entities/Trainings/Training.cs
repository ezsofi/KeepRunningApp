using System;

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
        public double? Distance { get; set; }
        public double DurationSeconds { get; set; }
        public double AveragePace { get; set; }

        protected Training()
        {

        }
        public Training(TrainingPlan trainingPlan)
        {
            TrainingPlan = trainingPlan;
            DayOfWeekPlanned = DatePlanned.ToString("dddd");
        }
    }
}
