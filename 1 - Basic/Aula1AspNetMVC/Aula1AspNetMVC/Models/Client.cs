using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;
using System.Web.Mvc.Html;
using Aula1AspNetMVC.Properties;

namespace Aula1AspNetMVC.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Display(ResourceType = typeof(Resources), Name = "Client_Name")]
        [MaxLength(150, ErrorMessage = "Exceeds the number of characters!")]
        [MinLength(2, ErrorMessage = "You need to put at least 2 characters!")]        
        [Required(ErrorMessage = "Required Field")]
        public string Name { get; set; }

        [Display(ResourceType = typeof(Resources), Name = "Client_Surname")]
        [MaxLength(150, ErrorMessage = "Exceeds the number of characters!")]
        [MinLength(2, ErrorMessage = "You need to put at least 2 characters!")]
        [Required(ErrorMessage = "Required Field")]
        public string Surname { get; set; }

        [Display(ResourceType = typeof(Resources), Name = "Client_CreatedDate")]
        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }

        [Display(ResourceType = typeof(Resources), Name = "Client_Email")]
        [MaxLength(150, ErrorMessage = "Exceeds the number of characters!")]
        [MinLength(2, ErrorMessage = "You need to put at least 2 characters!")]
        [Required(ErrorMessage = "Required Field")]
        [EmailAddress(ErrorMessage = "Invalid E-Mail")]
        public string Email { get; set; }
    }
}