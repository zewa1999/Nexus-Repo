using System;
using System.Collections.Generic;
using System.Text;

namespace NexusBenefit.DomainLayer
{
    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Company Company { get; set; }
        public string Function { get; set; }
        public Login Login { get; set; }
        public Role Role { get; set; }
        public Benefit Benefit { get; set; }
    }
}