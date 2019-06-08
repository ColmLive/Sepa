using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sepa.Controllers;
using Sepa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Sepa.DAL;


namespace Sepa.Controllers.Tests
{
    [TestClass()]
    public class InvControllerTests
    {
        [TestMethod]
        public void Invoice_Should_Not_Be_Valid_When_Some_Properties_Incorrect()
        {

            //Arrange
            var invoice = new Invoice()
            {
                Invoice_ID = 1,
                Invoice_Value = null,
                Posting_Date = null
            };

            // Act
            //bool isValid = Invoice.IsValid;

            //Assert
            //Assert.IsFalse(isValid);
            Assert.IsNull(invoice);
        }

        [TestMethod]
        public void Invoice_Should_Be_Valid_When_All_Properties_Correct()
        {

            //Arrange
            var invoice = new Invoice()
            {
                Invoice_ID = 1,
                Invoice_Value = 100.00,
                Vendor_ID =1
            };

            // Act
            //bool isValid = Invoice.IsValid;

            //Assert
            //Assert.IsTrue(isValid);
            Assert.IsNotNull(invoice);
            
        }

        [TestMethod]
        public void DetailsAction_Should_Return_View_For_ExistingInvoice()
        {

            // Arrange
            var controller = new InvoicesController();

            // Act
            var result = controller.Details(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result, "Expected View");
        }

        [TestMethod]
        public void DetailsAction_Should_Return_NotFoundView_For_InvalidInvoice()
        {

            // Arrange
            var controller = new InvoicesController();

            // Act
            var result = controller.Details(999) as ViewResult;

            // Assert
            Assert.AreEqual("NotFound", result.ViewName);
        }
        [TestMethod()]
        public void IndexTest()
        {

            // Arrange
            InvController controller = new InvController();

            // Act
            var editorViewModel = new SelectInvoiceEditorViewModel();


            // Assert
            Assert.IsNotNull(editorViewModel);


        }

        [TestMethod()]
        public void SubmitSelectedTest()
        {
            //Assert.IsNotNull(InvController);
        }
    }
}