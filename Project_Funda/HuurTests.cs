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
    public class HuurTests : BaseTests
    {
        // Test to search in the "Huur" page for Amsterdam
        [TestMethod]
        public void GoToHuurAndSearchFor_Amsterdam()
        {
            PageActions.GoTo(PageActions.Pages.huur);
            Search.Plaats("Amsterdam");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Amsterdam"));
        }

        // Test to search in the "Huur" page for Amsterdam & min values in dropdown filters
        [TestMethod]
        public void GoToHuurAndSearchFor_AmsterdamMinValuesDropdowns()
        {
            PageActions.GoTo(PageActions.Pages.huur);
            Search.Plaats("Amsterdam");
            Search.SelectRange("1");
            Search.HuurSelectVan("50000");
            Search.HuurSelectTot("50000");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Amsterdam"));
        }

        // Test to search in the "Huur" page for Amsterdam & max values in dropdown filters
        [TestMethod]
        public void GoToHuurAndSearchFor_AmsterdamMaxValuesDropdowns()
        {
            PageActions.GoTo(PageActions.Pages.huur);
            Search.Plaats("Amsterdam");
            Search.SelectRange("15");
            Search.HuurSelectVan("2000000");
            Search.HuurSelectTot("2000000");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Amsterdam"));
        }

        // Test to search in the "Huur" page for Amsterdam & mid values in dropdown filters
        [TestMethod]
        public void GoToHuurAndSearchFor_AmsterdamMidValuesDropdowns()
        {
            PageActions.GoTo(PageActions.Pages.huur);
            Search.Plaats("Amsterdam");
            Search.SelectRange("5");
            Search.HuurSelectVan("100");
            Search.HuurSelectTot("500");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Amsterdam"));
        }

        // Test to search in the "Huur" page for Amsterdam & combination of values in dropdown filters
        [TestMethod]
        public void GoToHuurAndSearchFor_AmsterdamMinMaxValuesDropdowns()
        {
            PageActions.GoTo(PageActions.Pages.huur);
            Search.Plaats("Amsterdam");
            Search.SelectRange("10");
            Search.HuurSelectVan("500");
            Search.HuurSelectTot("1000");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Amsterdam"));
        }

        // Test to search in the "Huur" page for Tilburg
        [TestMethod]
        public void GoToHuurAndSearchFor_Tilburg()
        {
            PageActions.GoTo(PageActions.Pages.huur);
            Search.Plaats("Tilburg");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Tilburg"));
        }
    }
}
