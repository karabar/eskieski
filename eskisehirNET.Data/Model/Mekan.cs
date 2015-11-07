using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eskisehirNET.Data.Model
{
    public class Mekan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MekanID { get; set; }

        public int MekanKategoriID { get; set; }
        public virtual MekanKategori MekanKategori { get; set; }

        public string KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }

        public string MekanAdi { get; set; }
        public string Mekanicerik { get; set; }
        public string MekanResim { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Web { get; set; }
        public string Enlem { get; set; }
        public string Boylam { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Foursquer { get; set; }
        public int Okunma { get; set; }

        public virtual ICollection<MekanResim> MekanResimleri { get; set; }
        public virtual ICollection<MekanReklam> MekanReklamlari { get; set; }
        public virtual ICollection<Seanslar> Seanslar { get; set; }
    }
}
