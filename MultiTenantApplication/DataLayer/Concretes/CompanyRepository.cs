using Library.DataLayer.Interfaces;
using NexusBenefit.DomainLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace NexusBenefit.DataLayer
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
    }
}