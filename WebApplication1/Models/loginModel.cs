using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace WebApplication1.Controllers
{
     public class loginModel
    {
         [Required]
         public string Username { get; set; }
         [Required]
         public string Password { get; set; }
    }
}
