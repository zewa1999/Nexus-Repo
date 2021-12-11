using Library.DataLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MultiTenantApplication.DataLayer.Interfaces;
using NexusBenefit.DataLayer;
using NexusBenefit.DomainLayer;
using System;
using System.Net;

namespace MultiTenantApplication.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        [HttpGet]
        public JsonResult GetById(int id)
        {
            return Json(_companyRepository.GetByID(id));
        }

        [HttpPost]
        public void Add(string name, string cui, string address, int discount)
        {
            var company = new Company
            {
                Name = name,
                CUI = cui,
                Address = address,
                Discount = discount
            };
            try
            {
                _companyRepository.Insert(company);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [HttpPut]
        public void Update(Company benefit)
        {
            try
            {
                _companyRepository.Update(benefit);
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
                _companyRepository.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            return Json(_companyRepository.Get());
        }
    }
}