using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace Framework
{
    public class Search
    {
        public enum Kms
        {
            [System.ComponentModel.Description("+ 0 km")]
            km0 = 0,
            [System.ComponentModel.Description("+ 1 km")]
            km1 = 1,
            [System.ComponentModel.Description("+ 2 km")]
            km2 = 2,
            [System.ComponentModel.Description("+ 5 km")]
            km5 = 3,
            [System.ComponentModel.Description("+ 10 km")]
            km10 = 4,
            [System.ComponentModel.Description("+ 15 km")]
            km15 = 5
        }

        public enum KoopprijsVan
        {
            [System.ComponentModel.Description("€ 0")]
            Eur0 = 0,
            [System.ComponentModel.Description("€ 50.000")]
            Eur50000 = 1,
            [System.ComponentModel.Description("€ 75.0000")]
            Eur75000 = 2,
            [System.ComponentModel.Description("€ 2.000.000")]
            Eur2000000 = 3
        }

        public enum KoopprijsTot
        {
            [System.ComponentModel.Description("€ 50.000")]
            Eur50000 = 0,
            [System.ComponentModel.Description("€ 75.000")]
            Eur75000 = 1,
            [System.ComponentModel.Description("€ 100.000")]
            Eur100000 = 2,
            [System.ComponentModel.Description("€ 2.000.000")]
            Eur2000000 = 3
        }

        public static void InsertParameters(string plaats, Kms Kms, KoopprijsVan KoopprijsVan, KoopprijsTot KoopprijsTot)
        {
            UITools.SendKeys((By.Id("autocomplete-input")), plaats);
            var kms = UITools.GetEnumDescription(Kms);
            var koopprijsVan = UITools.GetEnumDescription(KoopprijsVan);
            var koopprijsTot = UITools.GetEnumDescription(KoopprijsTot);
            UITools.SelectFromDropdown(Driver.Instance.FindElement(By.Id("Straal")), kms);
            UITools.SelectFromDropdown(Driver.Instance.FindElement(By.Id("range-filter-selector-select-filter_koopprijsvan")), koopprijsVan);
            UITools.SelectFromDropdown(Driver.Instance.FindElement(By.Id("range-filter-selector-select-filter_koopprijstot")), koopprijsTot);
            UITools.ClickFirstElement((By.ClassName("button-primary-alternative")));
            Driver.Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
        }

        public static void Plaats(string plaats)
        {
            Driver.Wait(1);
            UITools.SendKeys((By.Id("autocomplete-input")), plaats);
            Actions builder = new Actions(Driver.Instance);
            builder.SendKeys(Keys.Enter);
        }

        // Generic method to open the Range dropdown and select an option on each page
        public static void SelectRange(string rangeOptions)
        {
            SelectElement oSelect = new SelectElement(Driver.Instance.FindElement(By.Id("Straal")));
            oSelect.SelectByValue(rangeOptions);
        }

        // Generic method to open the "Van" dropdown and select an option on the "Koop" page
        public static void KoopSelectVan(string vanKoopOptions)
        {
            SelectElement oSelect = new SelectElement(Driver.Instance.FindElement(By.Id("range-filter-selector-select-filter_koopprijsvan")));
            oSelect.SelectByValue(vanKoopOptions);
        }

        // Generic method to open the "Tot" dropdown and select an option on the "Koop" page
        public static void KoopSelectTot(string totKoopOptions)
        {
            SelectElement oSelect = new SelectElement(Driver.Instance.FindElement(By.Id("range-filter-selector-select-filter_koopprijstot")));
            oSelect.SelectByValue(totKoopOptions);
        }

        // Generic method to open the "Van" dropdown and select an option on the "Huur" page
        public static void HuurSelectVan(string vanHuurOptions)
        {
            SelectElement oSelect = new SelectElement(Driver.Instance.FindElement(By.Id("range-filter-selector-select-filter_huurprijsvan")));
            oSelect.SelectByValue(vanHuurOptions);
        }

        // Generic method to open the "Tot" dropdown and select an option on the "Koop" page
        public static void HuurSelectTot(string totHuurOptions)
        {
            SelectElement oSelect = new SelectElement(Driver.Instance.FindElement(By.Id("range-filter-selector-select-filter_huurprijstot")));
            oSelect.SelectByValue(totHuurOptions);
        }

        // Generic method to choose a country in the "Kies een land" dropdown on the Europa page
        public static void KiesEenLand(string chooseCountry)
        {
            SelectElement oSelect = new SelectElement(Driver.Instance.FindElement(By.XPath(".//*[@class='search-dropdown custom-select']")));
            oSelect.SelectByValue(chooseCountry);
        }

        // Generic method to click on "Zoek"
        public static void Zoek()
        {
            Driver.Wait(1);
            UITools.ClickFirstElement(By.ClassName("search-block__submit"));
        }

        // Generic method to assert parameters in URL
        public static bool HasFound(string plaats)
        {
            var url = Driver.Instance.Url;
            var plaats1 = plaats.ToLower();
            if (url.Contains(plaats1)) return true;
            else return false;
        }
    }
}