using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppCrudMVC.Models
{
    [Table("Kategoriler")]
    public class Kategori
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} Alanı Boş Bırakılamaz!")]
        [StringLength(30, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        [Display(Name = "Kategori Adı")]
        public string KategoriAd { get; set; }
        [Required(ErrorMessage = "{0} Alanı Boş Bırakılamaz!")]
        [StringLength(50, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        [Display(Name = "Kategori Açıklaması")]
        public string KategoriAciklama { get; set; }
        [Required(ErrorMessage = "{0} Alanı Boş Bırakılamaz!")]
        [StringLength(30, ErrorMessage = "{0} alanı en fazla {1} karakter olmalıdır.")]
        [Display(Name = "Ürün Adı")]

        public string UrunAd { get; set; }
        [Required(ErrorMessage = "{0} Alanı Boş Bırakılamaz!")]
        [RegularExpression(@"^\d+(\,\d{1,2})?$", ErrorMessage = "{0} alanı geçerli bir sayısal değer içermelidir.")]
        public string Fiyat { get; set; }
        [Required(ErrorMessage = "{0} Alanı Boş Bırakılamaz!")]


        [RegularExpression("^[0-9]{1,15}$", ErrorMessage = "{0} alanı sadece sayısal değer içermelidir.")]
        public string Stok { get; set; }


    }
}