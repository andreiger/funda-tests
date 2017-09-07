using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public class UITools
    {
        internal static string GetEnumDescription(Enum en)
        {
            var type = en.GetType();
            var memInfo = type.GetMember(en.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {
                var attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), true).ToList();
                if (attrs != null && attrs.Count > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            return en.ToString();
        }

        public static void SendKeys(By element, string keys)
        {
            var input = Driver.Instance.FindElement(element);
            input.Click();
            input.SendKeys(keys);
        }

        public static void ClickFirstElement(By element = null, ReadOnlyCollection<IWebElement> elementCollection = null)
        {
            ReadOnlyCollection<IWebElement> clickElement = null;
            clickElement = elementCollection ?? Driver.Instance.FindElements(element);
            clickElement[0].Click();
        }

        public static void SelectFromDropdown(IWebElement button, string value)
        {
            var dropdown = new SelectElement(button);
            dropdown.SelectByText(value);
        }
    }
}
