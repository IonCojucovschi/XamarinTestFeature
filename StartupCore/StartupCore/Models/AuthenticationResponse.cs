using System;
namespace StartupCore.Models
{
    public class AuthenticationResponse
    {
        public bool IsAuthenticated { get; set; }
        public User profile { get; set; }
    }

    public class UserData
    {
        public AuthenticationResponse data { get; set; }

    }
}
