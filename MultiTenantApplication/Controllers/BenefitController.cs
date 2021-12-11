using Microsoft.AspNetCore.Mvc;
using MultiTenantApplication.DataLayer.Interfaces;
using NexusBenefit.DomainLayer;
using System;

namespace MultiTenantApplication.Controllers
{
    public class BenefitController : Controller
    {
        private readonly IBenefitRepository _benefitRepository;

        public BenefitController(IBenefitRepository benefitRepository)
        {
            _benefitRepository = benefitRepository;
        }

        [HttpGet]
        public JsonResult GetById(int id)
        {
            return Json(_benefitRepository.GetByID(id));
        }

        [HttpPost]
        public void Add(string name, string description, double cost)
        {
            var benefit = new Benefit
            {
                Name = name,
                Description = description,
                Cost = cost
            };
            try
            {
                _benefitRepository.Insert(benefit);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [HttpPut]
        public void Update(Benefit benefit)
        {
            try
            {
                _benefitRepository.Update(benefit);
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
                _benefitRepository.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            return Json(_benefitRepository.Get());
        }
    }
}