using System;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Constants
{
	public static class Messages
	{
		public static string CarUpdated = "Araba Güncellendi";
        public static string CarNameInValid="Araba İsmi Geçersiz";
        public static string CarDeleted="Araba Silindi";
        public static string GetByCarId="İstenilen Araba Listelendi";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string CarListed="Arabalar Listelendi";
        public static string GetCarsByBrandId="Arabalar MarkaLara Göre Listelendi";
        public static string GetCarsByColorId="Arabalar Renklere Göre Listelendi";
        internal static string CarNameAlReadyExtists="Araba İsmi Boş Olamaz";

        public static string ColorAdded="Renk Eklendi";
        public static string ColorDeleted="Renk Silindi";
        public static string ColorListed="Renkler Listelendi";
        public static string GetByColorId="İstenilen Renk Listelendi";
        public static string ColorUpdated="Renk Güncellendi";
        public static string BrandAdded="Marka Eklendi";
        public static string BrandDeleted="Marka Silindi";
        public static string BrandListeded="Markalar Listelendi";
        public static string GetByBrandId="İstenilen Marka Listelendi";
        public static string BrandUpdate="Marka Güncellendi";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Günccelendi";
        public static string CustomerListed = "Müşteriler Listelendi";
        public static string GetByCustomerId = "İstenilen Müşteriler Listelendi";
        public static string UserAdded = "Kullancı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserListed = "Kullanıcılar Listelendi";
        public static string GetByUserId = "İstenilen Kullancı Listelendi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string RentalAdded = "Kiralama Eklendi";
        public static string ReturnDate = "Araba Teslim Tarihi Girilmemiş";
        public static string RentalDelete = "Kiralama Silindi";
        public static string RentalListed = "Kiralamalar Listelendi";
        public static string GetByRentalId = "İstenilen Kiralamalar Listlendi";
        public static string RentalUpdated = "Kiralama Güncellendi";

        public static string GetCustomerDetail = "İstenilen Müşteri Bilgileri Listelendi";

        public static string CarAdded = "Araba Eklendi";

        public static string GetRentalDetails = "İstenilen Kiralama Bilgileri Listelendi";

        public static string AuthorizationDenied = "Yetkiniz Yok";
        public static string UserRegistered = "Kayıt Olundu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatalı";
        public static string UserAlreadyExists = "Böyle Bir Kullanıcı var zaten";
        public static string AccessTokenCreated = "Token Oluşturludu";
        public static string SuccessfulLogin = "Giriş Başarılı";
    }
}

