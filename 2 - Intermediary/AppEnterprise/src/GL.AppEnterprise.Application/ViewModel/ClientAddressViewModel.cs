﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using GL.AppEnterprise.Domain.Properties;

namespace GL.AppEnterprise.Application.ViewModel
{
    public class ClientAddressViewModel
    {
        public ClientAddressViewModel()
        {
            ClientId = Guid.NewGuid();
            AddressId = Guid.NewGuid();
        }

        #region " ClientViewModel Information "

        [Key]
        public Guid ClientId { get; set; }

        [Required(ErrorMessage = "Fill the field: Name")]
        [MaxLength(150, ErrorMessage = "Max {0} characters")]
        [MinLength(2, ErrorMessage = "Min {0} characters")]
        [Display(ResourceType = typeof(Resources), Name = "Client_Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Fill the field: E-mail")]
        [MaxLength(100, ErrorMessage = "Max {0} characters")]
        [EmailAddress(ErrorMessage = "Invalid E-mail")]
        [Display(ResourceType = typeof(Resources), Name = "Client_Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Fill the field: CPF")]
        [MaxLength(11, ErrorMessage = "Max {0} characters")]
        [DisplayName("CPF")]
        [Display(ResourceType = typeof(Resources), Name = "Client_CPF")]
        public string Cpf { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Invalid Date Format")]
        [Display(ResourceType = typeof(Resources), Name = "Client_BirthDate")]
        public DateTime BirthDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }

        [ScaffoldColumn(false)]
        public bool Active { get; set; }

        [ScaffoldColumn(false)]
        //public DomainValidation.Validation.ValidationResult ValidationResult { get; set; }

        #endregion

        #region " AddressViewModel Information "

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

        #endregion
    }
}