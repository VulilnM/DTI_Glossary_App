using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DTI_Glossary_App.Models
{
    public class Glossary
    {
        [Key]
        public int GlossaryId { get; set; }

        [Required]
        [DisplayName("Glossary term")]
        public string Term { get; set; }

        [Required]
        [DisplayName("Glossary definition")]
        public string Definition { get; set; }
    }
}
