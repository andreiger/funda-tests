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
        public void GoToKoopAndSearchForAmsterdam()
        {
            PageActions.GoTo(PageActions.Pages.koop);
            Search.Plaats("Amsterdam");
            Search.Zoek();
        }

        // Test to search in the "Koop" page for Amsterdam & min values in dropdown filters
        [TestMethod]
        public void GoToKoopAndSearchForAmsterdamMinValuesDropdowns()
        {
            PageActions.GoTo(PageActions.Pages.koop);
            Search.Plaats("Amsterdam");
            Search.SelectRange("1");
            Search.KoopSelectVan("50000");
            Search.KoopSelectTot("50000");
            Search.Zoek();        
        }

        // Test to search in the "Koop" page for Amsterdam & max values in dropdown filters
        [TestMethod]
        public void GoToKoopAndSearchForAmsterdamMaxValuesDropdowns()
        {
            PageActions.GoTo(PageActions.Pages.koop);
            Search.Plaats("Amsterdam");
            Search.SelectRange("15");
            Search.KoopSelectVan("2000000");
            Search.KoopSelectTot("2000000");
            Search.Zoek();
        }

        // Test to search in the "Koop" page for Amsterdam & mid values in dropdown filters
        [TestMethod]
        public void GoToKoopAndSearchForAmsterdamMidValuesDropdowns()
        {
            PageActions.GoTo(PageActions.Pages.koop);
            Search.Plaats("Amsterdam");
            Search.SelectRange("5");
            Search.KoopSelectVan("500000");
            Search.KoopSelectTot("500000");
            Search.Zoek();
        }

        // Test to search in the "Koop" page for Amsterdam & mid/max values in dropdown filters
        [TestMethod]
        public void GoToKoopAndSearchForAmsterdamMidMaxValuesDropdowns()
        {
            PageActions.GoTo(PageActions.Pages.koop);
            Search.Plaats("Amsterdam");
            Search.SelectRange("10");
            Search.KoopSelectVan("50000");
            Search.KoopSelectTot("2000000");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Amsterdam", Search.Kms.km10, Search.KoopprijsVan.Eur50000, Search.KoopprijsTot.Eur2000000));
        }

        // Test to search in the "Koop" page for Tilburg
        [TestMethod]
        public void GoToKoopAndSearchForTilburg()
        {
            PageActions.GoTo(PageActions.Pages.koop);
            Search.Plaats("Tilburg");
            Search.Zoek();  
        }
    }
}
