﻿using HackathonServer.Core.Entities.Common;

namespace HackathonServer.Entity.Concrete
{
    public class Category : BaseEntity
    {
        public double Coefficient { get; set; }
        public string Name { get; set; }
    }
}
