using System;
using System.Collections.Generic;

namespace KeepRunning.Model.Entities
{
    public class Runner
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RegisteredAt {get; set;}
        public List<TrainingPlan>? TrainingPlans { get; set; }
    }
}
