using KeepRunning.Models.DTOs;
using KeepRunning.Models.DTOs.Requests;
using KeepRunning.Models.Entities;
using System.Threading.Tasks;

namespace KeepRunning.Services.Interfaces
{
    public interface IRunnerService
    {
        Task<bool> CreateAsync(Runner newRunner);
        Task<ResponseMessageDto> SingInAsync(SignInRegisterRequestDto signinRequest);
        Task<Runner> GetRunnerByEmail(string email);
    }
}
