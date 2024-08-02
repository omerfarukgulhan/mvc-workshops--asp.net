using System.ComponentModel.DataAnnotations;

namespace forms.Models
{
    public class Product
    {
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Product name required")]
        [StringLength(100)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Range(0, 100000)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [Display(Name = "Image")]
        public string Image { get; set; }
        public bool IsActive { get; set; }
        [Display(Name = "Category")]
        [Required]
        public int? CategoryId { get; set; }
    }
}
