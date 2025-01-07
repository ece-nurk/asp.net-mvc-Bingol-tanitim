using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace yeniBingöl.Models
{
    public class Ilceler
    {
        public int Id { get; set; } // İlçe ID

        [Required(ErrorMessage = "İlçe adı zorunludur.")]
        [StringLength(100, ErrorMessage = "İlçe adı en fazla 100 karakter olabilir.")]
        [RegularExpression("^[a-zA-ZğüşıöçĞÜŞİÖÇ ]*$", ErrorMessage = "İlçe adı sayı ve sembol içeremez.")]
        public string IlceAd { get; set; } // İlçe Adı
    }
}
