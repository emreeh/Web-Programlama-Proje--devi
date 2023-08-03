using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PakHos.Entities
{
   public class Hasta :IEntity
    {
        public int Id { get; set; }
        public int DoktorId { get; set; }
        [StringLength(50)]
        public string? Adi { get; set; }
        [StringLength(50)]
        public string   Soyadi { get; set; }
        [StringLength(11)]
        public string? TcNo { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string? Adres { get; set; }
        [StringLength(13)]
        public string? Telefon { get; set; }
        public string? Notlar { get; set; }
        public virtual Doktor Doktor { get; set; }
    }
}
