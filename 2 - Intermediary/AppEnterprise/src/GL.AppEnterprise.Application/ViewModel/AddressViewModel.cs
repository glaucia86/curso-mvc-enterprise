using System;
using System.ComponentModel.DataAnnotations;
using GL.AppEnterprise.Domain.Properties;

namespace GL.AppEnterprise.Application.ViewModel
{
    public class AddressViewModel
    {
        public AddressViewModel()
        {
            AddressId = Guid.NewGuid();
        }

        [Key]
        public Guid AddressId { get; set; }

        [Required(ErrorMessage = "Fill the field: Public Place")]
        [MaxLength(100, ErrorMessage = "Max {0} characters")]
        [MinLength(2, ErrorMessage = "Min {0} characters")]
        [Display(ResourceType = typeof(Resources), Name = "Address_PublicPlace")]
        public string PublicPlace { get; set; }

        [Required(ErrorMessage = "Fill the field: Number")]
        [MaxLength(100, ErrorMessage = "Max {0} characters")]
        [MinLength(2, ErrorMessage = "Min {0} characters")]
        [Display(ResourceType = typeof(Resources), Name = "Address_Number")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Fill the field: Complement")]
        [MaxLength(150, ErrorMessage = "Max {0} characters")]
        [MinLength(2, ErrorMessage = "Min {0} characters")]
        [Display(ResourceType = typeof(Resources), Name = "Address_Complement")]
        public string AddressComplement { get; set; }

        [Required(ErrorMessage = "Fill the field: CEP")]
        [MaxLength(8, ErrorMessage = "Max {0} characters")]
        [MinLength(8, ErrorMessage = "Min {0} characters")]
        [Display(ResourceType = typeof(Resources), Name = "Address_CEP")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Fill the field: State")]
        [MaxLength(100, ErrorMessage = "Max {0} characters")]
        [MinLength(2, ErrorMessage = "Min {0} characters")]
        [Display(ResourceType = typeof(Resources), Name = "Address_State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Fill the field: City")]
        [MaxLength(100, ErrorMessage = "Max {0} characters")]
        [MinLength(2, ErrorMessage = "Min {0} characters")]
        [Display(ResourceType = typeof(Resources), Name = "Address_City")]
        public string City { get; set; }

        [ScaffoldColumn(false)]
        public Guid ClientId { get; set; }
    }
}