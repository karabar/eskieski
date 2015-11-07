using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eskisehirNET.Data.Model
{
    public class HaberTip
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HaberTipID { get; set; }

        [Required]
        public string HaberTipi { get; set; }

        public virtual ICollection<Haber> Haberler { get; set; }
    }
}
