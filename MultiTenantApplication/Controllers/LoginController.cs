using Library.DataLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MultiTenantApplication.DataLayer.Interfaces;
using NexusBenefit.DataLayer;
using NexusBenefit.DomainLayer;
using System;

namespace MultiTenantApplication.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginRepository _loginRepository;

        public LoginController(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        [HttpGet]
        public JsonResult GetById(int id)
        {
            return Json(_loginRepository.GetByID(id));
        }

        [HttpPost]
        public void Add(string email, string password)
        {
            var login = new Login
            {
                Email = email,
                Password = password
            };
            try
            {
                _loginRepository.Insert(login);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [HttpPut]
        public void Update(Login login)
        {
            try
            {
                _loginRepository.Update(login);
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
                _loginRepository.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            return Json(_loginRepository.Get());
        }
    }
}