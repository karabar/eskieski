using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eskisehirNET.Data.Model
{
    public class Seanslar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SeansID { get; set; }

        public int FilmID { get; set; }
        public virtual Filmler Filmler { get; set; }

        public int MekanID { get; set; }
        public virtual Mekan Mekanlar { get; set; }

        public string Seans { get; set; }

    }
}
