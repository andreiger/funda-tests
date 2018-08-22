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
    public class KoopTests : BaseTests
    {
        // Test to search in the "Koop" page for Amsterdam
        [TestMethod]
        public void GoToKoopAndSearchFor_Amsterdam()
        {
            PageActions.GoTo(PageActions.Pages.koop);
            Search.Plaats("Amsterdam");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Amsterdam"));
        }

        // Test to search in the "Koop" page for Amsterdam & min values in dropdown filters
        [TestMethod]
        public void GoToKoopAndSearchFor_AmsterdamMinValuesDropdowns()
        {
            PageActions.GoTo(PageActions.Pages.koop);
            Search.Plaats("Amsterdam");
            Search.SelectRange("1");
            Search.KoopSelectVan("50000");
            Search.KoopSelectTot("50000");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Amsterdam"));
        }

        // Test to search in the "Koop" page for Amsterdam & max values in dropdown filters
        [TestMethod]
        public void GoToKoopAndSearchFor_AmsterdamMaxValuesDropdowns()
        {
            PageActions.GoTo(PageActions.Pages.koop);
            Search.Plaats("Amsterdam");
            Search.SelectRange("15");
            Search.KoopSelectVan("2000000");
            Search.KoopSelectTot("2000000");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Amsterdam"));
        }

        // Test to search in the "Koop" page for Amsterdam & mid values in dropdown filters
        [TestMethod]
        public void GoToKoopAndSearchFor_Amsterdam_MidValuesDropdowns()
        {
            PageActions.GoTo(PageActions.Pages.koop);
            Search.Plaats("Amsterdam");
            Search.SelectRange("5");
            Search.KoopSelectVan("500000");
            Search.KoopSelectTot("500000");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Amsterdam"));
        }

        // Test to search in the "Koop" page for Amsterdam & mid/max values in dropdown filters
        [TestMethod]
        public void GoToKoopAndSearchFor_Amsterdam_MidMaxValuesDropdowns()
        {
            PageActions.GoTo(PageActions.Pages.koop);
            Search.Plaats("Amsterdam");
            Search.SelectRange("10");
            Search.KoopSelectVan("50000");
            Search.KoopSelectTot("2000000");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Amsterdam"));
        }

        // Test to search in the "Koop" page for Tilburg
        [TestMethod]
        public void GoToKoopAndSearchFor_Tilburg()
        {
            PageActions.GoTo(PageActions.Pages.koop);
            Search.Plaats("Tilburg");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Tilburg"));
        }
    }
}
