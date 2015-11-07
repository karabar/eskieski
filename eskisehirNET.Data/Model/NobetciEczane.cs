using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eskisehirNET.Data.Model
{
    public class NobetciEczane
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NobetciID { get; set; }

        public int EczaneID { get; set; }
        public virtual Eczane Eczaneler { get; set; }

        public DateTime Tarih { get; set; }
    }
}
