using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace eskisehirNET.Data.Model
{
    public class Video
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VideoID { get; set; }
        public string Baslik { get; set; }
        public string VideoLink { get; set; }
        public DateTime Tarih { get; set; }
        public int Okunma { get; set; }
    }
}
