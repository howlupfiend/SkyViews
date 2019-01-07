using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkyViews.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public int TelephoneNo { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
    }
}
