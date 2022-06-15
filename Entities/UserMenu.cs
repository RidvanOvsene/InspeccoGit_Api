using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserMenu
    {
        [Key]
        public int UserMenuId { get; set; }
        public int? MenuId { get; set; }
        public int? UserId { get; set; }
    }
}
