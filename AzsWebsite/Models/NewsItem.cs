using System.ComponentModel.DataAnnotations;

namespace AzsWebsite.Models
{
    public class NewsItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Заголовок обязателен")]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        public DateTime PublishDate { get; set; } = DateTime.Now;
    }
}
