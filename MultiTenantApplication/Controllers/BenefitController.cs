using Microsoft.AspNetCore.Mvc;
using MultiTenantApplication.DataLayer.Interfaces;

namespace MultiTenantApplication.Controllers
{
    public class BenefitController : Controller
    {
        private readonly IBenefitRepository _benefitRepository;

        public BenefitController(IBenefitRepository benefitRepository)
        {
            _benefitRepository = benefitRepository;
        }
    }
}