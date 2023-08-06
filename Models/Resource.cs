using System.ComponentModel.DataAnnotations;

namespace ResourceAggregator.Models
{
    public class Resource
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        [Url]
        public string Url { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
