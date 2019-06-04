using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sepa.Controllers;
using Sepa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepa.Controllers.Tests
{
    [TestClass()]
    public class InvControllerTests
    {
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