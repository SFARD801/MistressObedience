using System.ComponentModel.DataAnnotations;

namespace MistressObedience.Models
{
    public class ServantModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "You must provide your name, servant.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Your age is required.")]
        [Range(18, 60, ErrorMessage = "Only obedient servants between 18 and 60 are allowed.")]
        public int Age { get; set; }

        [Required(ErrorMessage ="Declare your devotion level.")]
        [Range(1, 10, ErrorMessage ="Your devotion level must be between 1 and 10.")]
        public int DevotionLevel { get; set; }
    }
}
