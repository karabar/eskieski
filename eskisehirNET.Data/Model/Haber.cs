using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eskisehirNET.Data.Model
{
    public class Haber
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HaberID { get; set; }

        public int HaberKategoriID { get; set; }
        public virtual HaberKategori HaberKategorisi { get; set; }

        public int HaberTipID { get; set; }
        public virtual HaberTip HaberTipi { get; set; }

        public string KullaniciId { get; set; }
        public virtual Kullanici User { get; set; }

        [Required(ErrorMessage ="Haber Başlık Alanı Boş Geçilemez")]
        public string HaberBaslik { get; set; }

        [Required(ErrorMessage = "Önsöz Alanı Boş Geçilemez")]
        public string OnSoz { get; set; }

        [Required(ErrorMessage = "İçerik Alanı Boş Geçilemez")]
        public string Icerik { get; set; }

        [Required(ErrorMessage = "Aciklama Alanı Boş Geçilemez")]
        public string Aciklama { get; set; }
        
        public string HaberResim { get; set; }

        [DefaultValue("1")]
        public int Okuma { get; set; }

        public bool Anasayfa { get; set; } //Anasayfa da çıksın mı?

        public bool Yayinda { get; set; }

        [Required(ErrorMessage ="Etiket Alanı Boş Bırakılamaz")]
        public string Etiket { get; set; }


    }
}
