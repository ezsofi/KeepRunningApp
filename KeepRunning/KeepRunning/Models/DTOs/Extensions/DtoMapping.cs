using KeepRunning.Models.DTOs.Requests;
using KeepRunning.Models.DTOs.Response;
using KeepRunning.Models.Entities;
using System.Linq;

namespace KeepRunning.Models.DTOs.Extensions
{
    public static class DtoMapping
    {
        public static Runner NewRunner(this SignInRegisterRequestDto registerDto)
        {
            return new(registerDto.Email, registerDto.Password);
        }

        public static TrainingPlanDto ToTrainingPlanDto(this TrainingPlan trainingPlan)
        {
            return new()
            {
                Id = trainingPlan.Id,
                Name = trainingPlan.Name,
                StaretedAt = trainingPlan.StartedAt,
                FinishedAtPlanned = trainingPlan.FinishedAtPlanned,
                FinishedAtActual = trainingPlan.FinishedAtActual,
                Trainings = new TrainingsDto {Trainings = trainingPlan.Trainings.Select(training => training.ToTrainingDto())}
            };
        }

        public static TrainingDto ToTrainingDto(this Training training)
        {
            return new()
            {
                Id = training.Id,
                DatePlanned = training.DatePlanned,
                DateActual = training.DateActual,
                DayOfWeekPlanned = training.DayOfWeekPlanned,
                Code = training.Code,
                TrainingType = training.TrainingType,
                Description = training.Description
            };
        }
    }
}
