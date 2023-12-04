using System.ComponentModel.DataAnnotations;

namespace DTI_Glossary_App.Models
{
    public class Glossary
    {
        [Key]
        public int GlossaryId { get; set; }

        [Required]
        public string Term { get; set; }

        [Required]
        public string Definition { get; set; }
    }
}
