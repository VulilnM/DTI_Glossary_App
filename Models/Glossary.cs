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
        // Definition can not be longer than 200 chars, and shorter than 10 chars
        [StringLength(200, MinimumLength = 10)]
        public string Definition { get; set; }
    }
}
