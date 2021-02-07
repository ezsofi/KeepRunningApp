using KeepRunning.Models.DTOs.Requests;
using KeepRunning.Models.ViewModels;
using KeepRunning.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KeepRunning.Controllers
{
    [Route("")]
    public class AuthenticationController : Controller
    {
        private readonly IRunnerService runnerService;

        public AuthenticationController(IRunnerService runnerService)
        {
            this.runnerService = runnerService;
        }

        [HttpGet("signin")]
        public IActionResult Index()
        {
            return View(new SignInViewModel());
        }

        [HttpPost("signin")]
        public async Task<IActionResult> SignIn(SignInViewModel vm)
        {
            var result = await runnerService.SingInAsync(new SignInRegisterRequestDto {Email = vm.Email, Password = vm.Password});
            return RedirectToAction("CreatePlan", "Trainingplan");
        }
    }
}
