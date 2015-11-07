using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace eskisehirNET.Data.Model
{ 
    public class YasamKategori
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int YasamKategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public int? AnaKategoriNo { get; set; }
        public virtual YasamKategori AnaKategori { get; set; }

        public virtual ICollection<Yasam> Yasam { get; set; }

    }
}
