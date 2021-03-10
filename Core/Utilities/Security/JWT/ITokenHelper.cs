using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{ //normalde json web ile yapılıyor ama burada test amaçlı
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
        //kullanıcı adı ve şifresi doğruysa veritabanından bilgileri doğrulacak 
        //token üretecek içerisinde bu bilgiler olan
        //sonrasında buraya döndürecek
        
    }
}
