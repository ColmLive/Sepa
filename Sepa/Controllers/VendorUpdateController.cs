﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Sepa.DAL;
using Sepa.Models;



namespace Sepa.Controllers
{
    public class VendorUpdateController : Controller
    {
        private SepaContext db = new SepaContext();
        // GET: VendorUpdate
        public ActionResult Index()
        {
       
            using (SepaContext dBEntities = new SepaContext())
            {
                dBEntities.Database.ExecuteSqlCommand("insert into Vendors values(999,'vendor test','Add6', 'New York', 'USA', 'USD/PL', 'v3@test.com', '0015552316666');");
                //                var query = dBEntities.Vendors.SqlQuery("select * from Vendors").ToList<Table1>();
                //                var query2 = dBEntities.Database.SqlQuery<Table1>("select * from Table1").ToList<Table1>();
                //               var query3 = dBEntities.Database.SqlQuery<tablevm>("select t1.id, t1.product, SUM(t1.price) as price from Table1 as t1 group by t1.id, t1.product").ToList<tablevm>();
         
            }

            return View();

        }
    }
}
 
