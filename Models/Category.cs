using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ResourceAggregator.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Resource> Resources { get; set; }
    }
}
