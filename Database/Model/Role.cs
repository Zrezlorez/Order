﻿namespace Order.Database.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual List<User> Users { get; set; } = new List<User>();
    }
}