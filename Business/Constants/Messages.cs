﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {

        //Captions
        public static string Warning = "Uyarı";
        public static string Info = "Bilgi";
        public static string Error = "Hata";
        public static string Succes = "Başarılı";

        public static readonly string PersonelAdded = "Personel bilgileri başarıyla oluşturuldu";
        public static readonly string PersonelUpdated = "Personel bilgileri başarıyla güncellendi";
        public static readonly string PersonelDeleted = "Personel bilgileri başarıyla silindi";

        public static readonly string KadroDurumlariAdded   = "Kadro Durumları bilgileri başarıyla oluşturuldu";
        public static readonly string KadroDurumlariUpdated = "Kadro Durumları bilgileri başarıyla güncellendi";
        public static readonly string KadroDurumlariDeleted = "Kadro Durumları bilgileri başarıyla silindi";
        
        public static readonly string DeleteCocuk = "Seçili çocuk bilgilerini silmek istediğinize emin misiniz?";

        public static readonly string CalismaSaatleriAdded = "Personel bilgileri başarıyla oluşturuldu";
        public static readonly string CalismaSaatleriUpdated = "Personel bilgileri başarıyla güncellendi";
        public static readonly string CalismaSaatleriDeleted = "Personel bilgileri başarıyla silindi";

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

        public static readonly string NufusAdded   = "Nüfus bilgileri başarıyla oluşturuldu";
        public static readonly string NufusUpdated = "Nüfus bilgileri başarıyla güncellendi";
        public static readonly string NufusDeleted = "Nüfus bilgileri başarıyla silindi";

        public static readonly string CocukAdded   = "Çocuk bilgileri başarıyla oluşturuldu";
        public static readonly string CocukUpdated = "Çocuk bilgileri başarıyla güncellendi";
        public static readonly string CocukDeleted = "Çocuk bilgileri başarıyla silindi";

        public static readonly string TahsilAdded   = "Tahsil bilgileri başarıyla oluşturuldu";
        public static readonly string TahsilUpdated = "Tahsil bilgileri başarıyla güncellendi";
        public static readonly string TahsilDeleted = "Tahsil bilgileri başarıyla silindi";
        public static readonly string DeleteTahsil = "Seçili tahsil bilgilerini silmek istediğinize emin misiniz?";

        public static readonly string NakilAdded   = "Nakil bilgileri başarıyla oluşturuldu";
        public static readonly string NakilUpdated = "Nakil bilgileri başarıyla güncellendi";
        public static readonly string NakilDeleted = "Nakil bilgileri başarıyla silindi";
        public static readonly string DeleteNakil = "Seçili nakil bilgilerini silmek istediğinize emin misiniz?";

        public static readonly string SertifikaAdded   = "Sertifika bilgileri başarıyla oluşturuldu";
        public static readonly string SertifikaUpdated = "Sertifika bilgileri başarıyla güncellendi";
        public static readonly string SertifikaDeleted = "Sertifika bilgileri başarıyla silindi";
        public static readonly string DeleteSertifika = "Seçili sertifika bilgilerini silmek istediğinize emin misiniz?";

        public static readonly string UnvanAdded = "Unvan bilgileri başarıyla oluşturuldu";
        public static readonly string UnvanUpdated = "Unvan bilgileri başarıyla güncellendi";
        public static readonly string UnvanDeleted = "Unvan bilgileri başarıyla silindi";

        public static readonly string UnvanGrubuAdded = "UnvanGrubu bilgileri başarıyla oluşturuldu";
        public static readonly string UnvanGrubuUpdated = "UnvanGrubu bilgileri başarıyla güncellendi";
        public static readonly string UnvanGrubuDeleted = "UnvanGrubu bilgileri başarıyla silindi";

        public static readonly string PuantajAdded   = "Puantaj bilgileri başarıyla oluşturuldu";
        public static readonly string PuantajUpdated = "Puantaj bilgileri başarıyla güncellendi";
        public static readonly string PuantajDeleted = "Puantaj bilgileri başarıyla silindi";

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
