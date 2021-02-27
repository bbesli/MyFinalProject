using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    //static olursa new lemek zorunda kalmayız.
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string MaintananceTime = "Bakım zamanı.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu ada sahip ürün zaten mevcut.";
        public static string CategoryLimitExceded = "Kategori limitine ulaşıldığı için ürün eklenemedi.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        internal static string UserRegistered="Kullanıcı kayıt oldu.";
        internal static string UserNotFound = "Kullanıcı bulunamadı.";
        internal static string PasswordError = "Hatalı şifre.";
        internal static string SuccessfulLogin = "Giriş başarılı.";
        internal static string UserAlreadyExists = "Kullanıcı zaten mevcut.";
        internal static string AccessTokenCreated = "Erişim tokenı oluşturuldu.";
    }
}
