using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eskisehirNET.Data.Model
{
    public class MekanResim
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MekanResimID { get; set; }

        public int MekanID { get; set; }
        public virtual Mekan Mekan { get; set; }

        public string Resim { get; set; }

    }
}
