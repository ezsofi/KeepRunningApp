using System.Collections.Generic;

namespace KeepRunning.Models.DTOs.Response
{
    public class TrainingsDto
    {
        public IEnumerable<TrainingDto> Trainings { get; set; }
    }
}
