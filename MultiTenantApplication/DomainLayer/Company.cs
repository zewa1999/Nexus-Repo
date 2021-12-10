using System;
using System.Collections.Generic;
using System.Text;

namespace NexusBenefit.DomainLayer
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CUI { get; set; }
        public string Address { get; set; }
        public int Discount { get; set; }
    }
}