using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakHos.Entities
{
   public class Kullanici:IEntity
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Adi { get; set; }
        [StringLength(50)]
        public string Soyadi { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(13)]
        public string Telefon { get; set; }
        [StringLength(50)]
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public bool AktifMi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public int RolId { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
