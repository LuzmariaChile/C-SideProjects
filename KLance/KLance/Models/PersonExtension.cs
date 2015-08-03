using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KLance.Models
{
    [MetadataType(typeof(PersonMetadata))]
    public partial class Person
    {
        public SelectList StateList { get; set; }
    }
    public class PersonMetadata
    {
        [Required]
        [Key]
        public int SSN;

        [Phone]
        public string Phone;

        [Required]
        [EmailAddress]
        public string Email;
    }
}