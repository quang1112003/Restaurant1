using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RestaurantWebsite.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Tên danh mục")]
        public string? type_name { get; set; }
        [DisplayName("Mô tả")]
        public string? description { get; set; }
    }
}
