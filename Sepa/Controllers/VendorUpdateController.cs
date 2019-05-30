using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Sepa.DAL;
using System.Data;
using System.Data.SqlClient;
using Sepa.Models;



namespace Sepa.Controllers
{
    public class VendorUpdateController : Controller
    {
        private SepaContext db = new SepaContext();
        // GET: VendorUpdate
        public ActionResult Index()
        {

            using (var conn = new SqlConnection(db.Database.Connection.ConnectionString))
            {
                //SqlConnection conn = new SqlConnection());
                //SqlConnection("Server=(SQLEXPRESS);DataBase=SEPA;Integrated Security=SSPI");
                //SqlConnection("Server=(localdb);DataBase=SEPA;Integrated Security=SSPI");

                conn.Open();

                SqlCommand cmd = new SqlCommand("PopulateVendors", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("PopulateInvoices", conn);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = new SqlCommand("AnonymiseData", conn);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.ExecuteNonQuery();

             }

            return View();

        }
    }
}

