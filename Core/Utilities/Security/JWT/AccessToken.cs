using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public string Token { get; set; } //Json web token>kullanıcı ve parala karşılığı 
        public DateTime Expiration { get; set; } //bitiş zamanı
    }
}
