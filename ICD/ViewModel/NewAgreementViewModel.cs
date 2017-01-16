using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ICD.Models;

namespace ICD.ViewModel
{
    public class NewAgreementViewModel
    {
        public IEnumerable<AgreementType> AgreementType { get; set; }
        public Agreement Agreement { get; set; }
    }
}