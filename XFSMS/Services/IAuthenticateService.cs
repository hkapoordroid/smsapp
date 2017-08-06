using System;
namespace XFSMS.Services
{
    public interface IAuthenticateService
    {
          bool ResetPasswordWithToken( string Password, string Token);

          bool AuthenticateUser(string UserName, string Password);

          bool SendPasswordResetToken(string UserName, string Email);

          bool SignUpUser(string UserName, string Password, string Email);

          
    }
}
