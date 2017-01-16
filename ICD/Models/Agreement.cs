using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ICD.Models
{
    public class Agreement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AgreementType AgreementType { get; set; }

        [Display(Name = "Agreement Type")]
        public int AgreementTypeId { get; set; }
        public string Status { get; set; }
        public string Author { get; set; }
        public string LastModifiedDate { get; set; } 

    }
}