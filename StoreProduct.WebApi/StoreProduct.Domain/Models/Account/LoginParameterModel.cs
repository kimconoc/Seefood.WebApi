﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProduct.Domain.Models.Account
{
    public class LoginParameterModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Captcha { get; set; }
        public bool Validate()
        {
            if (string.IsNullOrEmpty(this.Username) || string.IsNullOrEmpty(this.Password))
            {
                return false;
            }
            return true;
        }
    }
}
