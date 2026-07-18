using System;

namespace TekServis.Models
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
    }
}