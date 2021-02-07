using System;

namespace KeepRunning.Models.DTOs.Response
{
    public class TrainingPlanDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StaretedAt { get; set; }
        public DateTime? FinishedAtPlanned { get; set; }
        public DateTime? FinishedAtActual { get; set; }
        public TrainingsDto? Trainings { get; set; }
    }
}
