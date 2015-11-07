using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eskisehirNET.Data.Model
{
    public class MekanKategori
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MekanKatgoriID { get; set; }
        public string KategoriAdi { get; set; }
        public int? AnaKategoriNo { get; set; }
        public virtual MekanKategori AnaKategori { get; set; }

        public virtual ICollection<Mekan> Mekan { get; set; }
    }
}
