using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductsListed="Ürünler listelendi.";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists="Bu isimde bir ürün bulunmaktadır";
        public static string CategoryLimitExceded="Kategory sayısı limite ulaşmıştır";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt oldunuz.";
        public static string UserNotFound;
        public static string PasswordError="Parola hatalı.";
        public static string SuccessfulLogin="Başarılı giriş.";
        public static string UserAlreadyExists="Kullanıcı mevcut.";
        public static string AccessTokenCreated="Token oluşturuldu.";
    }
}
