using Library.DataLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MultiTenantApplication.DataLayer.Interfaces;
using NexusBenefit.DataLayer;
using NexusBenefit.DomainLayer;
using System;

namespace MultiTenantApplication.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public JsonResult GetById(int id)
        {
            return Json(_userRepository.GetByID(id));
        }

        [HttpPost]
        public void Add(string lastName, string firstName, Company c, string f, Login log, Role role, Benefit b)
        {
            var user = new User
            {
                LastName = lastName,
                FirstName = firstName,
                Company = c,
                Function = f,
                Role = role,
                Login = log,
                Benefit = b
            };
            try
            {
                _userRepository.Insert(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [HttpPut]
        public void Update(User user)
        {
            try
            {
                _userRepository.Update(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [HttpDelete]
        public void DeleteById(int id)
        {
            try
            {
                _userRepository.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            return Json(_userRepository.Get());
        }
    }
}