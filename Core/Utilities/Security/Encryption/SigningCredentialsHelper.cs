using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper //token servislerinin oluşturulabilmesi için 
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {//yönetmek için anahtar,kullanacağın yöntem
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
