using MultiTenantApplication.DataLayer.Interfaces;
using NexusBenefit.DomainLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace NexusBenefit.DataLayer
{
    public class LoginRepository : BaseRepository<Login>, ILoginRepository
    {
    }
}