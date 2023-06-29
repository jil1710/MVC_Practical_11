using System.ComponentModel.DataAnnotations;

namespace MVC_Practical_11_Partial_View.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "Only Date Is Required"), DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public string DOB { get; set; }

        public string Address { get; set; }
    }

}