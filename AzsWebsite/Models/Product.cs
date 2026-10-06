using System.ComponentModel.DataAnnotations;

namespace AzsWebsite.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Category { get; set; } = string.Empty; // ПО, Оборудование, Сервис

        public string Description { get; set; } = string.Empty;
    }
}
