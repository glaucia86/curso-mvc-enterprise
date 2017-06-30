using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GL.AppEnterprise.Application.ViewModel
{
    public class ClientViewModel
    {
        public ClientViewModel()
        {
            ClientId = Guid.NewGuid();
            //Addresses = new List<AddressViewModel>();
        }

        [Key]
        public Guid ClientId { get; set; }

        [Required(ErrorMessage = "Fill the field: Name")]
        [MaxLength(150, ErrorMessage = "Max {0} characters")]
        [MinLength(2, ErrorMessage = "Min {0} characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Fill the field: E-mail")]
        [MaxLength(100, ErrorMessage = "Max {0} characters")]
        [EmailAddress(ErrorMessage = "Invalid E-mail")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Fill the field: CPF")]
        [MaxLength(11, ErrorMessage = "Max {0} characters")]
        [DisplayName("CPF")]
        public string Cpf { get; set; }

        [Display(Name = "Birth of Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Invalid Date Format")]
        public DateTime BirthDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }

        [ScaffoldColumn(false)]
        public bool Active { get; set; }
    }
}