using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(Users user, List<OperationClaim> operationClaims);
    }
}
