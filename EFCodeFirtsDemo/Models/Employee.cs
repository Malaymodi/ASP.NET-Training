using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace EFCodeFirtsDemo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public int Age { get; set; }
    }
}