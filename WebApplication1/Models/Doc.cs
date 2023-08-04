using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Doc
    {
        public string? id { get; set; }
        public string? journal { get; set; }
        public string? eissn { get; set; }
        public DateTime publication_date { get; set; }
        public string? article_type { get; set; }

        [NotMapped]
        public List<string>? author_display { get; set; }

        [NotMapped]
        public List<string>? @abstract { get; set; }
        public string? title_display { get; set; }
        public double score { get; set; }
    }
}
