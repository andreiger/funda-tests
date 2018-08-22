using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;

namespace Tests
{
    [TestClass]
    public class EuropaTests : BaseTests
    {
        // Test to search in the "Europa" page for België and range 1
        [TestMethod]
        public void GoToRecreatieAndSearchForDenHaagAndRangeOne()
        {
            PageActions.GoTo(PageActions.Pages.europe);
            Search.KiesEenLand("belgie");
            Search.SelectRange("1");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("belgie"));
        }
    }
}
