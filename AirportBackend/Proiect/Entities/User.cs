﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Entities
{
    public class User : IdentityUser
    {
        public UserInfo UserInfo { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
