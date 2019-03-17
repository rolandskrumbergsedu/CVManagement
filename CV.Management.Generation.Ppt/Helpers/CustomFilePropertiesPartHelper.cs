using DocumentFormat.OpenXml.Packaging;
using Vt = DocumentFormat.OpenXml.VariantTypes;
using Op = DocumentFormat.OpenXml.CustomProperties;

namespace CV.Management.Generation.Ppt.Helpers
{
    public static class CustomFilePropertiesPartHelper
    {
        public static void GenerateCustomFilePropertiesPart1Content(CustomFilePropertiesPart customFilePropertiesPart1)
        {
            Op.Properties properties2 = new Op.Properties();
            properties2.AddNamespaceDeclaration("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");

            Op.CustomDocumentProperty customDocumentProperty1 = new Op.CustomDocumentProperty() { FormatId = "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}", PropertyId = 2, Name = "ContentTypeId" };
            Vt.VTLPWSTR vTLPWSTR1 = new Vt.VTLPWSTR();
            vTLPWSTR1.Text = "0x0101004B3CC135CC07AD41A19C6A3D7A557156";

            customDocumentProperty1.Append(vTLPWSTR1);

            Op.CustomDocumentProperty customDocumentProperty2 = new Op.CustomDocumentProperty() { FormatId = "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}", PropertyId = 3, Name = "Order" };
            Vt.VTDouble vTDouble1 = new Vt.VTDouble();
            vTDouble1.Text = "3254000";

            customDocumentProperty2.Append(vTDouble1);

            properties2.Append(customDocumentProperty1);
            properties2.Append(customDocumentProperty2);

            customFilePropertiesPart1.Properties = properties2;
        }
    }
}
