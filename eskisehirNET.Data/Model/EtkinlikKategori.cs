using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eskisehirNET.Data.Model
{
    public class EtkinlikKategori
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EtkinlikKategoriID { get; set; }
        [Required(ErrorMessage = "Kategori Adı Alanı Boş Geçilemez")]
        public string KategoriAdi { get; set; }

        public virtual ICollection<Etkinlik> Etkinlik { get; set; }
    }
}
