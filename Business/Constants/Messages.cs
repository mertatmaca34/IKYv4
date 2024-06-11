using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static readonly string PersonelAdded = "Personel bilgileri başarıyla oluşturuldu";
        public static readonly string PersonelUpdated = "Personel bilgileri başarıyla güncellendi";
        public static readonly string PersonelDeleted = "Personel bilgileri başarıyla silindi";

        public static readonly string KullaniciAdded = "Kullanici bilgileri başarıyla oluşturuldu";
        public static readonly string KullaniciUpdated = "Kullanici bilgileri başarıyla güncellendi";
        public static readonly string KullaniciDeleted = "Kullanici bilgileri başarıyla silindi";

        public static readonly string MudurlukAdded = "Mudurluk bilgileri başarıyla oluşturuldu";
        public static readonly string MudurlukUpdated = "Mudurluk bilgileri başarıyla güncellendi";
        public static readonly string MudurlukDeleted = "Mudurluk bilgileri başarıyla silindi";

        public static readonly string SeflikAdded = "Seflik bilgileri başarıyla oluşturuldu";
        public static readonly string SeflikUpdated = "Seflik bilgileri başarıyla güncellendi";
        public static readonly string SeflikDeleted = "Seflik bilgileri başarıyla silindi";

        public static readonly string TesisAdded = "Tesis bilgileri başarıyla oluşturuldu";
        public static readonly string TesisUpdated = "Tesis bilgileri başarıyla güncellendi";
        public static readonly string TesisDeleted = "Tesis bilgileri başarıyla silindi";

        public static readonly string IzinAdded = "Izin bilgileri başarıyla oluşturuldu";
        public static readonly string IzinUpdated = "Izin bilgileri başarıyla güncellendi";
        public static readonly string IzinDeleted = "Izin bilgileri başarıyla silindi";

        public static readonly string UnvanAdded = "Unvan bilgileri başarıyla oluşturuldu";
        public static readonly string UnvanUpdated = "Unvan bilgileri başarıyla güncellendi";
        public static readonly string UnvanDeleted = "Unvan bilgileri başarıyla silindi";

        public static readonly string UnvanGrubuAdded = "UnvanGrubu bilgileri başarıyla oluşturuldu";
        public static readonly string UnvanGrubuUpdated = "UnvanGrubu bilgileri başarıyla güncellendi";
        public static readonly string UnvanGrubuDeleted = "UnvanGrubu bilgileri başarıyla silindi";

        public static readonly string IncompleteInfo = "Lütfen bilgileri tam şekilde girin";
        public static readonly string ItsAlreadyExist = "Bu bilgiler zaten sisteme tanımlanmış";
        public static readonly string InvalidDateTimes = "Seçilen tarih aralıkları geçersiz";
        public static readonly string InvalidDelete = "Silinecek veri veritabanında kayıtlı değil";
        public static readonly string DataNotFound = "Veri Yok";
        public static readonly string AuthorizationDenied = "Lütfen sayfayı görüntüleyebilmek için giriş yapın";
        public static readonly string UserNotFound = "Kullanıcı bulunamadı";
        public static readonly string UserWrongPassword = "Kullanıcı adı veya şifre yanlış";
        public static readonly string UserAdded = "Kullanıcı başarıyla sisteme eklendi";
        public static readonly string UserSuccessfullyLogin = "Giriş başarılı";
        public static readonly string UserAlreadyExist = "Kullanıcı sistemde zaten mevcut";
    }
}
