using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{ 
    public class Response
    {
        public int numFound { get; set; }
        public int start { get; set; }
        public double maxScore { get; set; }
        [NotMapped]
        public List<Doc>? docs { get; set; }
    }
    
}
