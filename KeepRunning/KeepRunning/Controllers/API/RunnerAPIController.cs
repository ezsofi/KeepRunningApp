using KeepRunning.Models.DTOs.Extensions;
using KeepRunning.Models.DTOs.Requests;
using KeepRunning.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KeepRunning.Controllers
{
    public class RunnerAPIController : ControllerBase
    {
        private readonly IRunnerService runnerService;

        public RunnerAPIController(IRunnerService runnerService)
        {
            this.runnerService = runnerService;
        }

        [HttpPost("/register")]
        public async Task<ActionResult> Register([FromBody] SignInRegisterRequestDto newRunner)
        {
            var runnerCreated = await runnerService.CreateAsync(newRunner.NewRunner());
            if (!runnerCreated)
            {
                return BadRequest($"Runner could't be created. Please try again!");
            }
            return Ok($"Successful registration: new runner - {newRunner.Email}");
        }

        [HttpPost("/signinapi")]
        public async Task<ActionResult> SingIn([FromBody] SignInRegisterRequestDto signinRequest)
        {
            var response = await runnerService.SingInAsync(signinRequest);
            if(!response.Message.Equals("Successfully signed in!"))
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        // TODO SignOut Action

    }
}
