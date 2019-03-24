using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;
using System.IO;
using Sepa.DAL;
using Sepa.Models;

namespace Sepa.Controllers
{
    public class InvoiceUpdateController : Controller
    {
        private SepaContext db = new SepaContext();
        // GET: InvoiceUpdate
        public ActionResult Index()
        {

            var inv = db.Invoices.Include(w => w.Invoice_ID).Where(w => w.Invoice_ID > 1);

            // Create an instance of System.Xml.Serialization.XmlSerializer
            XmlSerializer serializer = new XmlSerializer(inv.GetType());
  
            // Create an instance of System.IO.TextWriter 
            // to save the serialized object to disk
            TextWriter textWriter = new StreamWriter("C:\\Projects\\invoice.xml");

            // Serialize the employee object
            serializer.Serialize(textWriter, inv);

            // Close the TextWriter
            textWriter.Close();



            return View();
        }
    }
}

