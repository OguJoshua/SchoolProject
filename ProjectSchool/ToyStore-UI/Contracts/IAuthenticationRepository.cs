using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Providers.Entities;
using ToyStore_UI.Models;

namespace ToyStore_UI.Contracts
{
    public interface IAuthenticationRepository
    {
        public Task<bool>Register(RegistrationModel User);

        public Task<bool> Login(LoginModel user);

        public Task Logout();

    }
}
