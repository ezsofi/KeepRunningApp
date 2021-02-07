using System;
using System.Collections.Generic;

namespace KeepRunning.Models.Entities
{
    public class Runner
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegisteredAt { get; set; }
        public List<TrainingPlan>? TrainingPlans { get; set; }
        public Runner()
        {

        }
        public Runner(string email, string password)
        {
            Email = email;
            Password = password;
            RegisteredAt = DateTime.Now;
        }
    }
}
