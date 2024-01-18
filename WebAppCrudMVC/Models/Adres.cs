using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppCrudMVC.Models
{
    [Table("Adresler")]
    public class Adres
    {
        public int Id { get; set; }

        [Display(Name = "Şehir")]
        [Required(ErrorMessage = "{0} Alanı Boş Bırakılamaz!"), StringLength(15)]
        public string Sehir { get; set; }

        [Display(Name = "İlçe")]
        [Required(ErrorMessage = "{0} Alanı Boş Bırakılamaz!"), StringLength(15)]
        public string Ilce { get; set; }

        [Display(Name = "Açık Adres")]
        [Required(ErrorMessage = "{0} Alanı Boş Bırakılamaz!"), StringLength(70)]
        public string AcikAdres { get; set; }

        [Display(Name = "Posta Kodu")]
        [MinLength(5, ErrorMessage = "{0} 5 Karakter Olmalıdır!")]
        [MaxLength(5, ErrorMessage = "{0} 5 Karakter Olmalıdır!")]

        public string PostaKodu { get; set; }
    }
}