using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserMenuDto
    {
        [Key]
        public int UserMenuId { get; set; }
        public int? MenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuUrl { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string NameSurname { get; set; }
    }
}
