using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Entities
{
    public class UserInfo
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public User User { get; set; }
    }
}
