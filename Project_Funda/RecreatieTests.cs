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
    public class RecreatieTests : BaseTests
    {
        // Test to search in the "Recreatie" page for Den Haag and range 1
        [TestMethod]
        public void GoToRecreatieAndSearchForDenHaagAndRangeOne()
        {
            PageActions.GoTo(PageActions.Pages.recreatie);
            Search.Plaats("Den Haag");
            Search.SelectRange("1");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Den Haag"));
        }

        // Test to search in the "Recreatie" page for Den Haag and range 2
        [TestMethod]
        public void GoToRecreatieAndSearchForDenHaagAndRangeTwo()
        {
            PageActions.GoTo(PageActions.Pages.recreatie);
            Search.Plaats("Den Haag");
            Search.SelectRange("2");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Den Haag"));
        }

        // Test to search in the "Recreatie" page for Den Haag and range 5
        [TestMethod]
        public void GoToRecreatieAndSearchForDenHaagAndRangeFive()
        {
            PageActions.GoTo(PageActions.Pages.recreatie);
            Search.Plaats("Den Haag");
            Search.SelectRange("5");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Den Haag"));
        }

        // Test to search in the "Recreatie" page for Den Haag and range 10
        [TestMethod]
        public void GoToRecreatieAndSearchForDenHaagAndRangeTen()
        {
            PageActions.GoTo(PageActions.Pages.recreatie);
            Search.Plaats("Den Haag");
            Search.SelectRange("10");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Den Haag"));
        }

        // Test to search in the "Recreatie" page for Den Haag and range 15
        [TestMethod]
        public void GoToRecreatieAndSearchForDenHaagAndRangeFifteen()
        {
            PageActions.GoTo(PageActions.Pages.recreatie);
            Search.Plaats("Den Haag");
            Search.SelectRange("15");
            Search.Zoek();
            Assert.IsTrue(Search.HasFound("Den Haag"));
        }
    }
}
