using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MockResponseAPI.Models
{
    public class odata
    {
        [Key]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
    }
}