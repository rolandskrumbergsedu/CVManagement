using DocumentFormat.OpenXml.Packaging;

namespace CV.Management.Generation.Word.Helpers
{
    public static class CustomFilePropertiesPartHelper
    {
        public static void GenerateCustomFilePropertiesPart1Content(CustomFilePropertiesPart customFilePropertiesPart1)
        {
            var properties2 = new DocumentFormat.OpenXml.CustomProperties.Properties();
            properties2.AddNamespaceDeclaration("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");

            var customDocumentProperty1 = new DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty() { FormatId = "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}", PropertyId = 2, Name = "ContentTypeId" };
            var vTLPWSTR1 =
                new DocumentFormat.OpenXml.VariantTypes.VTLPWSTR {Text = "0x0101004B3CC135CC07AD41A19C6A3D7A557156"};

            customDocumentProperty1.Append(vTLPWSTR1);

            properties2.Append(customDocumentProperty1);

            customFilePropertiesPart1.Properties = properties2;
        }
    }
}
