using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSandbox.Models
{
    public class User
    {

        public string UserName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime LastActivityDate { get; set; }

    }
}