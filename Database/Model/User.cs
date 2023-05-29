﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Order.Database.Model
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Login { get; set; } = "";
        public string Password { get; set; } = "";
        public int RoleId { get; set; }     
        public virtual Role? Role { get; set; }   
        public int StorageId { get; set; }
        public virtual Storage? Storage { get; set; }
    }
}
