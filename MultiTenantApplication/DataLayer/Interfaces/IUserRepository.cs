using Library.DataLayer.Interfaces;
using NexusBenefit.DomainLayer;

namespace MultiTenantApplication.DataLayer.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
    }
}