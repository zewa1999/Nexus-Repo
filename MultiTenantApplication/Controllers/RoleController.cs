using Library.DataLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MultiTenantApplication.DataLayer.Interfaces;
using NexusBenefit.DataLayer;
using NexusBenefit.DomainLayer;
using System;

namespace MultiTenantApplication.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleRepository _roleRepository;

        public RoleController(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        [HttpGet]
        public JsonResult GetById(int id)
        {
            return Json(_roleRepository.GetByID(id));
        }

        [HttpPost]
        public void Add(string name)
        {
            var role = new Role
            {
                Name = name,
            };
            try
            {
                _roleRepository.Insert(role);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [HttpPut]
        public void Update(Role role)
        {
            try
            {
                _roleRepository.Update(role);
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
                _roleRepository.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            return Json(_roleRepository.Get());
        }
    }
}