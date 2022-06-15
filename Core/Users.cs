using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Concrete
{
    public class Users
    {
        [Key]
        public int Kullanici_ID { get; set; }
        public byte[] Password { get; set; }

        [MaxLength(20)]
        public string KullaniciAdi { get; set; }
        [MaxLength(20)]
        public string Sifre { get; set; }
        [MaxLength(50)]
        public string Ad { get; set; }
        [MaxLength(50)]
        public string Soyad { get; set; }
    }
}