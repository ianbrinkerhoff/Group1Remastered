using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Typing.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Player")]
        public static string UserName { get; set; }

        public static string HashedPassword { get; set; }

        public static string UserSalt { get; set; }
    }
}
