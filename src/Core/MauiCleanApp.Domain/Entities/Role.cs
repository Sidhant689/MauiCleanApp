using MauiCleanApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCleanApp.Domain.Entities
{
    public class Role : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
