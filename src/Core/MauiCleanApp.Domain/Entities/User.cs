using MauiCleanApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCleanApp.Domain.Entities
{
    public class User : AuditableEntity
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
