using ProjectDNCommon.Defines.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectDNCommon.Models
{
    public class UserRole
    {
        public long UserId { get; set; }
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }
        public Role Role { get; set; }
        public User User { get; set; }
    }
}
