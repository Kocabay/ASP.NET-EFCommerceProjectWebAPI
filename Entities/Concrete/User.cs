﻿using Entities.Concrete.BaseEntities;

namespace Entities.Concrete
{
    public class User : AuditableEntity
    {

        public int? Id { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Password { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

    }
}
