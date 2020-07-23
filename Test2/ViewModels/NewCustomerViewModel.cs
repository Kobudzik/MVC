using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Test2.Models;

namespace Test2.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}