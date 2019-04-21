using System.ComponentModel.DataAnnotations;

namespace AppPruebaAspCore.API.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Persona {0} is required.")]
        [DataType(DataType.Text)]
        [StringLength(250, MinimumLength=3,ErrorMessage="The Name length is not correct.")]
        public string Nombre { get; set; }
        [Required]
        [Range(1,99,ErrorMessage="Edad betweetn 3 and 99.")]
        public int Edad { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
    }
}