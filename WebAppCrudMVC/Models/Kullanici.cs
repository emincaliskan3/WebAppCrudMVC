using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppCrudMVC.Models
{
    [Table("Kullanicilar")]
    public class Kullanici
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad Alanı Boş Bırakılamaz!"), StringLength(15)]
        public string Ad { get; set; }
        [Required(ErrorMessage = "{0} Alanı Boş Bırakılamaz!"), StringLength(15)]
        public string Soyad { get; set; }
        [EmailAddress(ErrorMessage = "Geçersiz Mail Girdiniz!"), StringLength(50)]
        public string Email { get; set; }
        [Phone(ErrorMessage = "Geçersiz Telefon Formatı!"), StringLength(15)]
        public string Telefon { get; set; }
        [Display(Name = "TC Kimlik Numarası")]
        [MinLength(11, ErrorMessage = "{0} 11 Karakter Olmalıdır!")]
        [MaxLength(11, ErrorMessage = "{0} 11 Karakter Olmalıdır!")]
        public string TcKimlikNo { get; set; }
        [Display(Name = "Doğum Tarihi")]
        public DateTime DogumTarihi { get; set; }
        [Display(Name = "Kullanıcı Adı"), StringLength(50)]
        public string KullaniciAdi { get; set; }
        [Display(Name = "Şifre")]
        [StringLength(50, ErrorMessage = "{0} {2} Karakterden Az Olamaz", MinimumLength = 3)]
        [Required(ErrorMessage = "{0} Alanı Boş Bırakılamaz!")]
        public string Sifre { get; set; }
        [Display(Name = "Şifre Tekrar")]
        [StringLength(50, ErrorMessage = "{0} {2} Karakterden Az Olamaz", MinimumLength = 3)]
        [Compare("Sifre")]
        public string SifreTekrar { get; set; }
    }

}