using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class UserOperationClaim : IEntity
    {
        public int Id { get; set; }
        public int Kullanici_ID { get; set; }
        public int OperationClaimId { get; set; }
    }
}
