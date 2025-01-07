using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace yeniBingöl.Models
{
    public class Foto
    {
        public int Id { get; set; }        // Tablodaki 'Id' sütununa karşılık gelir
        public string Baslik { get; set; } // Tablodaki 'baslik' sütununa karşılık gelir
        public string Url { get; set; }    // Tablodaki 'url' sütununa karşılık gelir
    }
}
