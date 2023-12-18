﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Service.Entity
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string manufacturer { get; set; }

    }
}
