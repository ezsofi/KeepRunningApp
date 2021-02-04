using KeepRunning.Models.DTOs.Requests;
using KeepRunning.Models.Entities;

namespace KeepRunning.Models.DTOs.Extensions
{
    public static class DtoMapping
    {
        public static Runner NewRunner(this SignInRegisterRequestDto registerDto)
        {
            return new(registerDto.Email, registerDto.Password);
        }
    }
}
