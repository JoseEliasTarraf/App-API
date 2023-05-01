using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainLib.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "")]
        [Required(ErrorMessageResourceType = typeof(DomainLib.Utility.Lenguage.Message),ErrorMessageResourceName ="MSG_E001")]
        public string Name { get; set; }
        [Required(ErrorMessageResourceType = typeof(DomainLib.Utility.Lenguage.Message), ErrorMessageResourceName = "MSG_E001")]
        [EmailAddress(ErrorMessageResourceType = typeof(DomainLib.Utility.Lenguage.Message), ErrorMessageResourceName = "MSG_E003")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(DomainLib.Utility.Lenguage.Message), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(8 , ErrorMessageResourceType = typeof(DomainLib.Utility.Lenguage.Message), ErrorMessageResourceName = "MSG_E003")]
        public string Password { get; set; }
    }
}
