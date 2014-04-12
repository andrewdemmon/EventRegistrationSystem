//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventRegistrationSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Registration
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Email Address")]
        [EmailAddress]
        [StringLength(255)]
        public string EmailAddress { get; set; }

        [Required]
        [DisplayName("First Name")]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string Country { get; set; }

        [Required]
        [DisplayName("Event")]
        public int EventId { get; set; }

        [Required]
        [DisplayName("Arrival Date")]
        [DataType(DataType.Date)]
        public System.DateTime ArrivalDate { get; set; }

        [Required]
        [DisplayName("Arrival Time")]
        [DataType(DataType.Time)]
        public System.TimeSpan ArrivalTime { get; set; }

        [Required]
        [DisplayName("Registration Date")]
        [DataType(DataType.DateTime)]
        public System.DateTime RegistrationDate { get; set; }
    }
}
