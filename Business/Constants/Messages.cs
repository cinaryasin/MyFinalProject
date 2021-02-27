using Core.Entities.Concrete;
using Entities.ConCrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "ürünler listelendi";
        public static string MaintenanceTime = "Sistem bakımda ";
        public static string ProductCountOfCategoryError = "kategoride En fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu ürün isminden zaten 1 tane daha var";
        public static string CategoryLimitExceded = "Kategory limiti aşıldığı için yeni ürün eklenemez ";
        public static string AuthorizationDenied = "Yetkin Yok";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}
