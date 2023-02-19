using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceItemDiscount.Model
{
    [Table("tb_Discount", Schema = "dbo")]
    public class DiscountModel
    {
        public int Id { get; set; }
        public byte CategoryId { get; set; }
        public string? Name { get; set; }
        public double Rate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool isActive { get; set; }
    }
}
