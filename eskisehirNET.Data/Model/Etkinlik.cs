using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eskisehirNET.Data.Model
{
    public class Etkinlik
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EtkinlikID { get; set; }

        [Required]
        public int EtkinlikKategoriID { get; set; }
        public virtual EtkinlikKategori EtkinlikKategori { get; set; }

        public string KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }

        public int MekanID { get; set; }
        public virtual Mekan Mekan { get; set; }

        public string EtkinlikBaslik { get; set; }
        public string Etkinlikicerik { get; set; }
        public string EtkinlikResim { get; set; }
        public DateTime EtkinlikBaslangic { get; set; }
        public DateTime EtkinlikBitis { get; set; }
        public int Okunma { get; set; }
        public bool Yayinda { get; set; }
        public bool Slider { get; set; }
        public string SliderResim { get; set; } //Slider da çıkacak resmi
    }
}
