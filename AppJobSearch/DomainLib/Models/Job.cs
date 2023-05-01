using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainLib.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(DomainLib.Utility.Lenguage.Message), ErrorMessageResourceName = "MSG_E001")]
        public string Company { get; set; }
        [Required(ErrorMessageResourceType = typeof(DomainLib.Utility.Lenguage.Message), ErrorMessageResourceName = "MSG_E001")]
        public string JobTitle { get; set; }
        [Required(ErrorMessageResourceType = typeof(DomainLib.Utility.Lenguage.Message), ErrorMessageResourceName = "MSG_E001")]
        public string CityState { get; set; }
        [Required(ErrorMessageResourceType = typeof(DomainLib.Utility.Lenguage.Message), ErrorMessageResourceName = "MSG_E001")]
        public double Salary { get; set; }
        [Required(ErrorMessageResourceType = typeof(DomainLib.Utility.Lenguage.Message), ErrorMessageResourceName = "MSG_E001")]
        public string ContractType { get; set; }
        [Required(ErrorMessageResourceType = typeof(DomainLib.Utility.Lenguage.Message), ErrorMessageResourceName = "MSG_E001")]
        public string TecnologyTools { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessageResourceType = typeof(DomainLib.Utility.Lenguage.Message), ErrorMessageResourceName = "MSG_E001")]
        public string JobDescription { get; set; }
        public string Benefits { get; set; }
        [Required(ErrorMessageResourceType = typeof(DomainLib.Utility.Lenguage.Message), ErrorMessageResourceName = "MSG_E001")]
        [EmailAddress(ErrorMessageResourceType = typeof(DomainLib.Utility.Lenguage.Message), ErrorMessageResourceName = "MSG_E002")]
        public string InterestedEmail { get; set; }
        public DateTime PubDate { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
