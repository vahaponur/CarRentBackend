using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    internal static class Messages
    {
        public const string SuccessfullyAdded = "Öğe başarı ile eklendi";
        public const string SuccessfullyDeleted = "Öğe başarı ile silindi";
        public const string SuccessfullyUpdated = "Öğe başarı ile güncellendi";
        public const string UserNotFound="Kullanıcı bulunamadı";
        public const string PasswordError="Şifre Hatalı";
        public const string UserAlreadyExist="Kullanıcı zaten var.";
        public const string UserRegistered = "Kullanıcı başarıyla kaydedildi.";
        public const string AccessTokenCreated = "Token oluşturuldu.";
        public const string AuthorizationDenied="Doğrulama reddedildi.";
    }
}
