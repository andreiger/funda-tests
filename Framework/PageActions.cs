using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Framework
{
    public class PageActions
    {
        public enum Pages
        {
            [System.ComponentModel.Description("koop/")]
            koop = 0,
            [System.ComponentModel.Description("huur/")]
            huur = 1,
            [System.ComponentModel.Description("nieuwbouw/")]
            nieuwbouw = 2,
            [System.ComponentModel.Description("recreatie/")]
            recreatie = 3,
            [System.ComponentModel.Description("europe/")]
            europe = 4
        }

        public static void GoTo(Pages pageName)
        {
            switch (pageName)
            {
                case Pages.koop:
                    var extension = UITools.GetEnumDescription(Pages.koop);
                    Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress + extension);
                    //Assert.IsTrue(Driver.Instance.Navigate().Equals((Driver.BaseAddress + extension)));
                    break;
                case Pages.huur:
                    extension = UITools.GetEnumDescription(Pages.huur);
                    Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress + extension);
                    break;
                case Pages.nieuwbouw:
                    extension = UITools.GetEnumDescription(Pages.nieuwbouw);
                    Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress + extension);
                    break;
                case Pages.recreatie:
                    extension = UITools.GetEnumDescription(Pages.recreatie);
                    Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress + extension);
                    break;
                case Pages.europe:
                    extension = UITools.GetEnumDescription(Pages.europe);
                    Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress + extension);
                    break;
            }
        }
    }
}
