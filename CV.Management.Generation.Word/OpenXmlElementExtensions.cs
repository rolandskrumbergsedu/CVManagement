using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;

namespace CV.Management.Generation.Word
{
    public static class OpenXmlElementExtensions
    {
        public static void Append(this OpenXmlElement element, OpenXmlElement elementToAppend)
        {
            element.Append(new List<OpenXmlElement> { elementToAppend });
        }
    }
}
