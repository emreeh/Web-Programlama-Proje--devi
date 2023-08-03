using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PakHos.Entities
{
   public class Muayane:IEntity
    {
        public int Id { get; set; }
        public DateTime ServiseGelisTarihi { get; set; } = DateTime.Now;
        public string HastaSorunu { get; set; }
       // public decimal MuayaneUcreti { get; set; }
        public DateTime? MuayaneCikisTarihi { get; set; }= DateTime.Now;
        public string YapilanIslemler { get; set; }
        public bool SosyalGuvencesiVarMi{ get; set; }
        public string HastaTC { get; set; }
        [StringLength(50)]
        public string Poliklinik { get; set; }
  
        public string Notlar { get; set; }
    }
}
