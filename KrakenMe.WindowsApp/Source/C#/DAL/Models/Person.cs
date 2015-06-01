using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Models
{
    public class Person
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public Login login { get; set; }
    }
}
