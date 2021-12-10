using Library.DataLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MultiTenantApplication.DataLayer.Interfaces;

namespace MultiTenantApplication.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
    }
}