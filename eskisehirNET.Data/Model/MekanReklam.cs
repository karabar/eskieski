using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eskisehirNET.Data.Model
{
    public class MekanReklam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MekanReklamID { get; set; }

        public int MekanID { get; set; }
        public virtual Mekan Mekan { get; set; }

        public bool Benzer { get; set; }
        public DateTime BenzerTarihi { get; set; }

        public bool Anasayfa { get; set; }
        public DateTime AnasayfaTarihi { get; set; }

        public bool Kategori { get; set; }
        public DateTime KategoriTarihi { get; set; }
    }
}
