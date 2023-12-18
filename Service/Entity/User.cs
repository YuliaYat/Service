﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Service.Entity
{
    public class User
    {
       [Key]
        public int id { get; set; }

        public string login { get; set; }
        public string password { get; set; }

        public string numbers { get; set; }
    }
}
