using ProjectDNCommon.Defines.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectDNCommon.Models
{
    public class User
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserId { get; set; }

        [Required]
        public AuthType Type { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Email { get; set; }

        [MaxLength(12)]
        [Required]
        public string Username { get; set; }

        [MaxLength(256)]
        public string Portrait { get; set; }

        [MaxLength(200)]
        public string Biograph { get; set; }

        [Required]
        [MaxLength(128)]
        public string Password { get; set; }

        [Required]
        [MaxLength(128)]
        public string PasswordSalt { get; set; }

        public List<UserRole> Roles { get; set; }
    }
}
