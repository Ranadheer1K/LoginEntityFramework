using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginEntityFramework.Models
{
    public class Customer
    {
        [Key]
        public string username { get; set; }

        public string passowrd { get; set; }
    }
}