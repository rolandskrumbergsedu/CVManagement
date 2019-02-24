using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;

namespace CV.Management.Generation.Word.ContentHelper
{
    public static class ContentSectionProperties
    {
        public static SectionProperties CreateProperties()
        {
            SectionProperties sectionProperties1 = new SectionProperties() { RsidR = "009B2C1D" };
            HeaderReference headerReference1 = new HeaderReference() { Type = HeaderFooterValues.Default, Id = "rId12" };
            FooterReference footerReference1 = new FooterReference() { Type = HeaderFooterValues.Default, Id = "rId13" };
            HeaderReference headerReference2 = new HeaderReference() { Type = HeaderFooterValues.First, Id = "rId14" };
            PageSize pageSize1 = new PageSize() { Width = (UInt32Value)11870U, Height = (UInt32Value)16787U };
            PageMargin pageMargin1 = new PageMargin() { Top = 1440, Right = (UInt32Value)1440U, Bottom = 1440, Left = (UInt32Value)1440U, Header = (UInt32Value)720U, Footer = (UInt32Value)720U, Gutter = (UInt32Value)0U };
            Columns columns1 = new Columns() { Space = "720" };
            TitlePage titlePage1 = new TitlePage();

            sectionProperties1.Append(headerReference1);
            sectionProperties1.Append(footerReference1);
            sectionProperties1.Append(headerReference2);
            sectionProperties1.Append(pageSize1);
            sectionProperties1.Append(pageMargin1);
            sectionProperties1.Append(columns1);
            sectionProperties1.Append(titlePage1);

            return sectionProperties1;
        }
    }
}
