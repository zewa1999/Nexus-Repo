using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MultiTenantApplication.DataLayer.Interfaces;
using NexusBenefit.DataLayer;
using NexusBenefit.DomainLayer;

namespace MultiTenantApplication.Pages.Login
{
    public class LoginModel : PageModel
    {
        private readonly IUserRepository _repo;
        private NexusBenefitsContext _ctx;
        private List<User> _users;

        public LoginModel(IUserRepository repo)
        {
            _repo = repo;
            _ctx = new();
        }

        public void OnGet()
        {
            CreateUser();
            var query = from users in _ctx.User
                        select users;
            _users = query.ToList();
        }

        public void ConnectUser()
        {
            //var q = from users in _ctx.User
            //        where users.Login.Email ==
        }

        public void CreateUser()
        {
            var benefits = new List<Benefit>();
            var benefit = new Benefit
            {
                Name = "gsdg",
                Description = "Altceasgasdva",
                Cost = 100
            };
            benefits.Add(benefit);
            var user = new NexusBenefit.DomainLayer.User
            {
                LastName = "Garcgsdgfdsggaea",
                FirstName = "GigagADasdasgl",
                Company = new NexusBenefit.DomainLayer.Company
                {
                    Name = "CompaadfgasdgnyName",
                    CUI = "1241aasdfassga24",
                    Address = "O adsafasfragesa",
                    Discount = 10
                },
                Login = new NexusBenefit.DomainLayer.Login
                {
                    Email = "emailgarcea@asfdasfemail.com",
                    Password = "nueokparolaasfsafsadsaaparaaici"
                },
                Role = new NexusBenefit.DomainLayer.Role
                {
                    Name = "Programfqfsdator"
                },
                Benefits = benefits
            };

            _ctx.User.Add(user);
            _ctx.SaveChanges();
        }
    }
}