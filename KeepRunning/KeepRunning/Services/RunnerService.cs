using KeepRunning.Database;
using KeepRunning.Models.DTOs;
using KeepRunning.Models.DTOs.Requests;
using KeepRunning.Models.Entities;
using KeepRunning.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace KeepRunning.Services
{
    public class RunnerService :IRunnerService
    {
        private readonly ApplicationDbContext dbContext;
        public RunnerService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<bool> CreateAsync(Runner newRunner)
        {
            await dbContext.Runners.AddAsync(newRunner);
            var created = await dbContext.SaveChangesAsync();
            return created > 0;
        }

        public async Task<ResponseMessageDto> SingInAsync(SignInRegisterRequestDto signinRequest)
        {
            var runner = await GetRunnerByEmail(signinRequest.Email);
            if (runner is null)
            {
                return new ResponseMessageDto { Message = "Runner not found! Please try again." };
            }
            if(signinRequest.Password != runner.Password)
            {
                return new ResponseMessageDto { Message = "Password is not correct! Please try again." };
            }
            return new ResponseMessageDto { Message = "Successfully signed in!" };
        }

        public async Task<Runner> GetRunnerByEmail(string email)
        {
            return await dbContext.Runners.SingleOrDefaultAsync(runner => runner.Email == email);
        } 
    }
}
