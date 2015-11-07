using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eskisehirNET.Data.Model
{
    public class HaberKategori
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HaberKategoriID { get; set; }
        [Required(ErrorMessage ="{0} Boş Geçilemez")]
        [DisplayName("Kategori Adı")]
        public string KategoriAdi { get; set; }
        [Required(ErrorMessage = "{0} Boş Geçilemez")]
        [DisplayName("Kategori Rengi")]
        public string KategoriRenk { get; set; }

        public virtual ICollection<Haber> Haberler { get; set; }
    }
}
