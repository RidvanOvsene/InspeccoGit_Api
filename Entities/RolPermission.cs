using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RolPermission
    {
        [Key]
        public int RolPermissionId { get; set; }
        public int? PermissionId { get; set; }
        public int? RolId { get; set; }
        public int? MenuId { get; set; }
    }
}
