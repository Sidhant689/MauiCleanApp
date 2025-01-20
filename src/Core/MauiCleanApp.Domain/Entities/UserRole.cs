using MauiCleanApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCleanApp.Domain.Entities
{
    public class UserRole : AuditableEntity
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}
