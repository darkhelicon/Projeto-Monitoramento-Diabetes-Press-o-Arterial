﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool HasG { get; set; }
        public bool HasH { get; set; }
        public DateTime Date { get; set; }
    }
}
