using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ICD.Models;
using System.Data.Entity;
using ICD.ViewModel;

namespace ICD.Controllers
{
    public class AgreementController : Controller
    {
        private ApplicationDbContext _context;

        // Create context during construction
        public AgreementController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        
        // GET: Agreement
        public ViewResult Agreements()
        {
            var Agreement = _context.Agreement.Include(c => c.AgreementType).ToList();
            // var Customer = _context.Customers.SingleOrDefault(c => c.Id == id);
   
            return View(Agreement);
        }

        public ActionResult AddAgreements()
        {
            var AgreementTypes = _context.AgreementTypes.ToList();
            var NewAgreementView = new NewAgreementViewModel()
            {
                AgreementType = AgreementTypes
            };
            return View(NewAgreementView);
        }

        [HttpPost]
        public ActionResult Create(Agreement Agreement)
        {
            Agreement.Author = "Priyanka";
            Agreement.Status = "Draft";
            Agreement.LastModifiedDate = DateTime.Now.ToString();
            _context.Agreement.Add(Agreement);
            _context.SaveChanges();
            return RedirectToAction("Agreements", "Agreement");
        }
        public IEnumerable<Agreement> GetAgreements()
        {
            return new List<Agreement>
            {
                 new Agreement {Id = 1, Name = "Client1", Status="Released",Author="Mustermann", LastModifiedDate= DateTime.Now.AddDays(-10).ToShortDateString() },
                new Agreement {Id = 2, Name = "Client2", Status="Draft" ,Author="Thomas", LastModifiedDate= DateTime.Now.AddDays(-4).ToShortDateString() }
            };

        }
    }


    
}