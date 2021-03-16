using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Buisness.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarNameInvalid = "Araba bulunamadı.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Arabalar listelendi";

        public static string CarUpdated = "Araba Güncellendi";
        public static string CarDeleted = "Araba Silindi";

        public static string RentalAdded = "Araba Kiralandı";

        public static string ThisIsCarRenred = "Bu araba kiralandı";

        public static string CarCountOfBrandError = "15 üründen fazla kategori olamaz";

        public static string PlaqueAlreadyExists = "Plaka zaten var";

        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Kullanıcı Oluşturuldu";

        public static string UserNotFound = "kullanıcı bulunamadı";
        public static string PasswordError = "şifre hatası";
        public static string SuccessfulLogin = "giriş başarılı";
        public static string UserAlreadyExists = "kullanıcı mevcut";
        public static string AccessTokenCreated = "token başarıyla oluşturuldu";

        public static string Added = "eklendi";
        public static string Deleted = "silindi";
        public static string Listed = "listelendi";
        public static string CarsDetailsListed = "araba ayrıntıları listelendi";
    }
}
 