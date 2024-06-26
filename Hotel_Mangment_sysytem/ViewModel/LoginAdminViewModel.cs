﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotalSystem.ViewModel
{
    public class LoginAdminViewModel
    {
        [Required ,EmailAddress]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public string Massage { get; set; }
    }
}