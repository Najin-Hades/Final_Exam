﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class DTO_Account {
        public string UserName {  get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string Role {  get; set; }
        public string Email { get; set; }   
        public string NumberPhone { get; set; }
        public string Name { get; set; }

        public DTO_Account(string userName, string password, DateTime dateCreated, DateTime lastLoginDate, string role, string email, string numberPhone, string name) {
            UserName = userName;
            Password = password;
            DateCreated = dateCreated;
            LastLoginDate = lastLoginDate;
            Role = role;
            Email = email;
            NumberPhone = numberPhone;
            Name = name;
        }

    }
}
