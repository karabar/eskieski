using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eskisehirNET.Data.Model
{
    public class Filmler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FilmID { get; set; }
        public string FilmAdi { get; set; }
        public string Aciklama { get; set; }
        public string resim { get; set; }
        public string Fragman { get; set; }
        public bool Aktif { get; set; }

        public virtual ICollection<Seanslar> Seanslar { get; set; }
    }
}
