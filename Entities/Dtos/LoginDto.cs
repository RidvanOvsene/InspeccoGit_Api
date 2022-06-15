using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class LoginDto
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string NameSurname { get; set; }
        public int? RolId { get; set; }
        public string Token { get; set; }
        public DateTime? Expiration { get; set; }
    }
}
