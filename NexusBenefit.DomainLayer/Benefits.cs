using System;
using System.Collections.Generic;
using System.Text;

namespace NexusBenefit.DomainLayer
{
    public class Benefits
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
    }
}