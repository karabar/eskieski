using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eskisehirNET.Data.Model
{
    public class Yasam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int YasamID { get; set; }

        public int YasamKategoriID { get; set; }
        public virtual YasamKategori YasamKategori { get; set; }

        public string KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }

        public string Baslik { get; set; }
        public string Onsoz { get; set; }
        public string Icerik { get; set; }
        public string Resim { get; set; }
        public int Okuma { get; set; }
        public string Aciklama { get; set; }
        public string Etiket { get; set; }
        public DateTime Tarih { get; set; }
        public bool Yayinda { get; set; }
    }
}
