using System.Collections.Generic;

namespace DAL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int TypeId { get; set; }
        public Type Type { get; set; }
        public int GemstonesId { get; set; }
        public ICollection<Gemstone> Gemstones { get; set; }
    }
}
