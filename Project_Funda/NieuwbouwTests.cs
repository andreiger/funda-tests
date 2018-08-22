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
    public class NieuwbouwTests : BaseTests
    {
        // Test to search in the "Nieuwbouw" page for Amsterdam
        [TestMethod]
        public void GoToNieuwbouwAndSearchFor_Amsterdam()
        {
            PageActions.GoTo(PageActions.Pages.nieuwbouw);
            Search.Plaats("Amsterdam");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Amsterdam"));
        }

        // Test to search in the "Nieuwbouw" page for Amsterdam and range 1
        [TestMethod]
        public void GoToNieuwbouwAndSearchFor_AmsterdamAndRangeOne()
        {
            PageActions.GoTo(PageActions.Pages.nieuwbouw);
            Search.Plaats("Amsterdam");
            Search.SelectRange("1");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Amsterdam"));
        }

        // Test to search in the "Nieuwbouw" page for Amsterdam and range 2
        [TestMethod]
        public void GoToNieuwbouwAndSearchFor_AmsterdamAndRangeTwo()
        {
            PageActions.GoTo(PageActions.Pages.nieuwbouw);
            Search.Plaats("Amsterdam");
            Search.SelectRange("2");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Amsterdam"));
        }

        // Test to search in the "Nieuwbouw" page for Amsterdam and range 5
        [TestMethod]
        public void GoToNieuwbouwAndSearchFor_AmsterdamAndRangeFive()
        {
            PageActions.GoTo(PageActions.Pages.nieuwbouw);
            Search.Plaats("Amsterdam");
            Search.SelectRange("5");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Amsterdam"));
        }

        // Test to search in the "Nieuwbouw" page for Den Haag and range 10
        [TestMethod]
        public void GoToNieuwbouwAndSearchFor_DenHaagAndRangeTen()
        {
            PageActions.GoTo(PageActions.Pages.nieuwbouw);
            Search.Plaats("Den Haag");
            Search.SelectRange("10");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Den Haag"));
        }

        // Test to search in the "Nieuwbouw" page for Den Haag and range 10
        [TestMethod]
        public void GoToNieuwbouwAndSearchFor_DenHaagAndRangeFifteen()
        {
            PageActions.GoTo(PageActions.Pages.nieuwbouw);
            Search.Plaats("Den Haag");
            Search.SelectRange("15");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Den Haag"));
        }
    }
}
