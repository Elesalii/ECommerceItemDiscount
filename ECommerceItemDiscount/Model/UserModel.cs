using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceItemDiscount.Model
{
    [Table("tb_User", Schema = "dbo")]
    public class UserModel
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }

    }
}