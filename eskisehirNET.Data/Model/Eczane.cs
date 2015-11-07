using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eskisehirNET.Data.Model
{
    public class Eczane
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EczaneID { get; set; }
        [Required(ErrorMessage ="Eczane Adı Boş Geçilemez")]
        public string EczaneAdi { get; set; }

        //[DataType(DataType.PhoneNumber)]
        //[RegularExpression("^[0-9]{8}$")]
        //[StringLength(32)]
        [Required(ErrorMessage ="Eczane Telefonu Giriniz")]
        public string EczaneTelefon { get; set; }

        [Required(ErrorMessage ="Eczane Adresi Giriniz")]
        public string EczaneAdres { get; set; }

        public string Enlem { get; set; }
        public string Boylam { get; set; }


    }
}
