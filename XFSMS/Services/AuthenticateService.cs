using System;
namespace XFSMS.Services
{
    public class AuthenticateService:IAuthenticateService
    {
        public AuthenticateService()
        {
        }


		public bool AuthenticateUser(string un, string pw)
		{
            return true;
		}

        public bool ResetPasswordWithToken(string Password, string Token)
        {
            return true;
        }

        public bool SendPasswordResetToken(string UserName, string Email)
        {
            return true;
        }

        public bool SignUpUser(string UserName, string Password, string Email)
        {
            return true;
        }
    }
}
