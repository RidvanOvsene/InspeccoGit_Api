using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RolPermissionDto
    {
        [Key]
        public int RolPermissionId { get; set; }
        public int? PermissionId { get; set; }
        public string PermissionName { get; set; }
        public int? RolId { get; set; }
        public string RolName { get; set; }
        public int? MenuId { get; set; }
        public string MenuName { get; set; }
    }
}
