﻿using System;
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

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public string Hash { get; set; }

        public string  Salt { get; set; }

        public string Score { get; set; }

    }
}
