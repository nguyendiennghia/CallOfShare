using System.ComponentModel.DataAnnotations;

namespace CallOfShare.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}