﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.WPF.Model.Models.ModelDTO
{
    public class LoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
