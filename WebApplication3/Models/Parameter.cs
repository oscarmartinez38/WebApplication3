using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Parameter
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}