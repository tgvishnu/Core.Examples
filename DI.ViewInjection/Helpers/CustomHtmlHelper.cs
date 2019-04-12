using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.ViewInjection.HtmlHelpers
{
    public class CustomHtmlHelper
    {
        public CustomHtmlHelper()
        {
            Value = "Hello from CustomHtmlHelper";
        }
        public string Value { get; set; }
    }
}
