﻿using System;

namespace KeepRunning.Models.DTOs.Requests
{
    public class PlanCreateRequestDto
    {
        public string PlanName { get; set; }
        public DateTime StartDate { get; set; }
        public string Email { get; set; }

    }
}
