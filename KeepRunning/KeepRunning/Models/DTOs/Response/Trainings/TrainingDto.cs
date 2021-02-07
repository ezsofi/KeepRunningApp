using System;

namespace KeepRunning.Models.DTOs.Response
{
    public class TrainingDto
    {
        public int Id { get; set; }
        public DateTime DatePlanned { get; set; }
        public DateTime DateActual { get; set; }
        public string DayOfWeekPlanned { get; set; }
        public string Code { get; set; }
        public string TrainingType { get; set; }
        public string Description { get; set; }
    }
}
