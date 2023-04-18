using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists="Bu isimde bir ürün zaten kullanılmaktadır.";
        public static string CategoryLimitExceded="Kategori limiti aşılmıştır.";
        public static string AuthorizationDenied = "Yetkilendirme yok.";
        public static string UserRegistered="kayıt oldu";
        public static string UserNotFound="Kullanıcı Bulunamadı";
        public static string PasswordError="Parola hatalı";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated="Token oluşturuldu";
    }
}
