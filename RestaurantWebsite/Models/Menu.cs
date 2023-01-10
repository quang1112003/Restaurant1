using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RestaurantWebsite.Models
{
    public class Menu
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Tên món ăn")]
        public string? menu_name { get; set; }
        public decimal price { get; set; }
        public string? menu_image { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
        [DisplayName("Thành phần")]
        public string? ingredients { get; set; }
        [DisplayName("Trạng thái")]
        public int menu_status { get; set; }
        [ForeignKey("Category")]
        [DisplayName("Danh mục")]
        public int CategoryID { get; set; }
        public virtual Category? Category { get; set; }
    }
}
