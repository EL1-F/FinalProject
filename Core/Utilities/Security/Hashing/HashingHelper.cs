using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{ //hash işlemi için bir araç olduğu için çıplak kalabilir
    //hash oluşturmak için oluşturduk
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password,out byte[] passwordHash
            , out byte[] passwordSalt)
            //ona verilen password un hash i ve salt ı nı verecek
        {
            using(var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }


        //tekrar girmeye çalışıyor
        public static bool VerifyPasswordHash(string password,byte[] passwordHash
            ,byte[] passwordSalt) //passwordhash ı doğrula
            //bu kullanıcının şifresini hashleseydin aynı şifre çıkar mıydı 
            //karşılaştırıyoruz 
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))//doğrulama olacağı için
            {
                var computedHash= hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash != passwordHash) 
                        //girilen password ile tekrar hashlediğimiz password u karşılaştırıyoruz
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
