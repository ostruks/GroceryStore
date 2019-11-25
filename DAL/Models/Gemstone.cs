namespace DAL.Models
{
    public class Gemstone
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public int? ProductId { get; set; }
        public Product Product { get; set; }
    }
}