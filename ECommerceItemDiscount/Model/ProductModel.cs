using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceItemDiscount.Model
{
    [Table("tb_Products",Schema ="dbo")]
    public class ProductModel
    {
        public int Id { get; set; }
        public Int16 CategoryId { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public bool isDiscountActive { get; set; }
    }
}
