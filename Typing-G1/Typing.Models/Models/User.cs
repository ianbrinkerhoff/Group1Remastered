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
        public  string UserName { get; set; }

        public  string HashedPassword { get; set; }

        public  string UserSalt { get; set; }

        public  int Score { get; set; }
    }
}
