﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Legajo { get; set; }
        public DateTime BirthDate { get; set; }
        public int IDPlan { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string State { get; set; } // Active, Inactive, etc.
    }
}
