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

        public static string UserNotFound = "";
        public static string PasswordError = "";
        public static string SuccessfulLogin = "";
        public static string UserAlreadyExists = "";
        public static string AccessTokenCreated = "";
    }
}
 