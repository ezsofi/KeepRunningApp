using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepRunning.Models.DTOs.Requests
{
    public class PlanCreateRequestDto
    {
        public string PlanName { get; set; }
        public string Email { get; set; }
    }
}
