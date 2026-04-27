using HospitalLite.Core.Common;
using HospitalLite.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalLite.Core.Entities
{
    public class AppUser : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public UserEnum Role { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenEndDate { get; set; }
    }
}
