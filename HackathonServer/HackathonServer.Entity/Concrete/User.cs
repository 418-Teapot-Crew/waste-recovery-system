﻿using HackathonServer.Core.Entities.Common;
using System.Text.Json.Serialization;

namespace HackathonServer.Entity.Concrete
{
    public enum UserType
    {
        Citizen = 1,
        Admin,
        Company
    }

    public class User : BaseEntity
    {
        public UserType TypeId { get; set; }
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public double Score { get; set; }
        /// <summary>
        /// Shit code
        /// </summary>
        [JsonIgnore]
        public string Password { get; set; }
    }
}
