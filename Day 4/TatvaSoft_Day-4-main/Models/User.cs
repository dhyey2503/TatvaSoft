﻿namespace BookProject.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
