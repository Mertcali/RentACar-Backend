using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarsAdded = "Araç eklendi";    
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Araçlar listelendi";
        public static string CarsUpdated = "Araçlar güncellendi";

        public static string BrandsAdded = "Marka eklendi";
        public static string BrandsDeleted = "Marka silindi";
        public static string BrandsListed = "Marka listelendi";
        public static string BrandsUpdated = "Marka güncellendi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";

        public static string ColorsAdded = "Renk eklendi";
        public static string ColorsDeleted = "Renk silindi";
        public static string ColorsListed = "Renk listelendi";
        public static string ColorsUpdated = "Renk güncellendi";
        public static string ColorNameInvalid = "Renk ismi geçersiz";

        public static string UsersAdded = "Kullanıcı eklendi";
        public static string UsersDeleted = "Kullanıcı silindi";
        public static string UsersListed = "Kullanıcı listelendi";
        public static string UsersUpdated = "Kullanıcı güncellendi";
        public static string UserNameInvalid = "Kullanıcı ismi geçersiz";

        public static string CustomersAdded = "Müşteri eklendi";
        public static string CustomersDeleted = "Müşteri silindi";
        public static string CustomersListed = "Müşteri listelendi";
        public static string CustomersUpdated = "Müşteri güncellendi";
        public static string CustomerInvalid = "Müşteri ismi geçersiz";

        public static string RentalsAdded = "Rental eklendi";
        public static string RentalsDeleted = "Rental silindi";
        public static string RentalsListed = "Rental listelendi";
        public static string RentalsUpdated = "Rental güncellendi";
        public static string RentalReturnDateInvalid = "Rental teslim tarihi geçersiz";
        public static string CarImageLimitExceeded = "Bir araç için resim sınırı aşıldı(5)";

        public static string AuthorizationDenied = "Yetkiniz reddedildi";
        public static string UserRegistered = "Kayıt olundu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError="Şifre hatalı";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists="Kullanıcı zaten mevcut";
        public static string AccessTokenCreated="Token oluşturuldu";
        public static string UserRegister="Kayıt olundu";


        //refactor yapılacak kendini tekrar ettin

    }
}
