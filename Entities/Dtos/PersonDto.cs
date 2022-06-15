using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class PersonDto
    {
        [Key]
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonSurname { get; set; }
        public string Contact { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
    }
}
