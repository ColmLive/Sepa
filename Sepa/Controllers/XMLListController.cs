using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using Sepa.DAL;
using Sepa.Models;
using System.Xml.Serialization;
using System.IO;

namespace Sepa.Controllers
{
    public class XMLListController : Controller
    {
        public SepaContext db = new SepaContext();
        // GET: InvoiceUpdate
        public ActionResult Index()
        {

            var data = from b in db.Invoices
                       where b.StatusCode == Status.SEPA
                       group b by b.Vendor_ID into g
                       select new Group<string, Invoice> { Key = g.Key.ToString(), Values = g };

            return View(data.ToList());
        }

        }
}

