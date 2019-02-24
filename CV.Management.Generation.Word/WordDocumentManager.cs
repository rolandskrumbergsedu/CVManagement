using System;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using Wp = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using A = DocumentFormat.OpenXml.Drawing;
using Pic = DocumentFormat.OpenXml.Drawing.Pictures;
using A14 = DocumentFormat.OpenXml.Office2010.Drawing;
using Wp14 = DocumentFormat.OpenXml.Office2010.Word.Drawing;
using CV.Management.Generation.Word.Helpers;
using System.IO;

namespace CV.Management.Generation.Word
{
    public class WordDocumentManager
    {
        public void SaveDocument(GenerationData data, string filePath, string fileName)
        {
            using (var mem = new MemoryStream())
            {
                using (var package =
                    WordprocessingDocument.Create(mem, WordprocessingDocumentType.Document, true))
                {
                    CreateParts(package, data);
                }

                mem.Position = 0;

                using (var file = new FileStream($"{filePath}\\{fileName}", FileMode.CreateNew, FileAccess.Write))
                {
                    mem.CopyTo(file);
                }
            }
        }

        public byte[] GetDocument(GenerationData data)
        {
            using (var mem = new MemoryStream())
            {
                using (var package =
                    WordprocessingDocument.Create(mem, WordprocessingDocumentType.Document, true))
                {
                    CreateParts(package, data);
                }

                return mem.ToArray();
            }
        }
        private static void CreateParts(WordprocessingDocument document, GenerationData data)
        {
            //ExtendedFilePropertiesPart extendedFilePropertiesPart1 = document.AddNewPart<ExtendedFilePropertiesPart>("rId3");
            //ExtendedFilePropertiesPartHelper.GenerateExtendedFilePropertiesPart1Content(extendedFilePropertiesPart1);

            var mainDocumentPart1 = document.AddMainDocumentPart();
            MainDocumentPartHelper.GenerateMainDocumentPart1Content(mainDocumentPart1, data);

            var endnotesPart1 = mainDocumentPart1.AddNewPart<EndnotesPart>("rId8");
            EndnotesPartHelper.GenerateEndnotesPart1Content(endnotesPart1);

            var footerPart1 = mainDocumentPart1.AddNewPart<FooterPart>("rId13");
            FooterPartHelper.GenerateFooterPart1Content(footerPart1);

            var customXmlPart1 = mainDocumentPart1.AddNewPart<CustomXmlPart>("application/xml", "rId3");
            CustomXmlPartHelper.GenerateCustomXmlPart1Content(customXmlPart1);

            var customXmlPropertiesPart1 = customXmlPart1.AddNewPart<CustomXmlPropertiesPart>("rId1");
            CustomXmlPartHelper.GenerateCustomXmlPropertiesPart1Content(customXmlPropertiesPart1);

            var footnotesPart1 = mainDocumentPart1.AddNewPart<FootnotesPart>("rId7");
            FootnotesPartHelper.GenerateFootnotesPart1Content(footnotesPart1);

            var headerPart1 = mainDocumentPart1.AddNewPart<HeaderPart>("rId12");
            HeaderPartHelper.GenerateHeaderPart1Content(headerPart1, data);

            var customXmlPart2 = mainDocumentPart1.AddNewPart<CustomXmlPart>("application/xml", "rId2");
            CustomXmlPartHelper.GenerateCustomXmlPart2Content(customXmlPart2);

            var customXmlPropertiesPart2 = customXmlPart2.AddNewPart<CustomXmlPropertiesPart>("rId1");
            CustomXmlPartHelper.GenerateCustomXmlPropertiesPart2Content(customXmlPropertiesPart2);

            var numberingDefinitionsPart1 = mainDocumentPart1.AddNewPart<NumberingDefinitionsPart>("rId20");
            NumberingDefinitionsPartHelper.GenerateNumberingDefinitionsPart1Content(numberingDefinitionsPart1);

            var themePart1 = mainDocumentPart1.AddNewPart<ThemePart>("rId16");
            ThemePartHelper.GenerateThemePart1Content(themePart1);

            var customXmlPart3 = mainDocumentPart1.AddNewPart<CustomXmlPart>("application/xml", "rId1");
            CustomXmlPartHelper.GenerateCustomXmlPart3Content(customXmlPart3);

            var customXmlPropertiesPart3 = customXmlPart3.AddNewPart<CustomXmlPropertiesPart>("rId1");
            CustomXmlPartHelper.GenerateCustomXmlPropertiesPart3Content(customXmlPropertiesPart3);

            var webSettingsPart1 = mainDocumentPart1.AddNewPart<WebSettingsPart>("rId6");
            WebSettingsPartHelper.GenerateWebSettingsPart1Content(webSettingsPart1);

            var imagePart1 = mainDocumentPart1.AddNewPart<ImagePart>("image/png", "rId11");
            ImagePartHelper.GenerateImagePart1Content(imagePart1);

            var documentSettingsPart1 = mainDocumentPart1.AddNewPart<DocumentSettingsPart>("rId5");
            DocumentSettingsPartHelper.GenerateDocumentSettingsPart1Content(documentSettingsPart1);

            var fontTablePart1 = mainDocumentPart1.AddNewPart<FontTablePart>("rId15");
            FontTablePartHelper.GenerateFontTablePart1Content(fontTablePart1);

            var imagePart2 = mainDocumentPart1.AddNewPart<ImagePart>("image/png", "rId10");
            ImagePartHelper.GenerateImagePart2Content(imagePart2);

            var styleDefinitionsPart1 = mainDocumentPart1.AddNewPart<StyleDefinitionsPart>("rId4");
            StyleDefinitionsPartHelper.GenerateStyleDefinitionsPart1Content(styleDefinitionsPart1);

            var imagePart3 = mainDocumentPart1.AddNewPart<ImagePart>("image/jpeg", "rId9");
            ImagePartHelper.GenerateImagePart3Content(imagePart3);

            var headerPart2 = mainDocumentPart1.AddNewPart<HeaderPart>("rId14");
            HeaderPartHelper.GenerateHeaderPart2Content(headerPart2);

            var customFilePropertiesPart1 = document.AddNewPart<CustomFilePropertiesPart>("rId4");
            CustomFilePropertiesPartHelper.GenerateCustomFilePropertiesPart1Content(customFilePropertiesPart1);

            SetPackageProperties(document, data);
        }

        private static void SetPackageProperties(OpenXmlPackage document, GenerationData data)
        {
            document.PackageProperties.Creator = data.DocumentProperties.Creator;
            document.PackageProperties.Title = data.DocumentProperties.Title;
            document.PackageProperties.Subject = data.DocumentProperties.Subject;
            document.PackageProperties.Category = data.DocumentProperties.Category;
            document.PackageProperties.Keywords = data.DocumentProperties.Keywords;
            document.PackageProperties.Description = data.DocumentProperties.Description;
            document.PackageProperties.Revision = "1";
            document.PackageProperties.Created = DateTime.Now;
            document.PackageProperties.Modified = DateTime.Now;
            document.PackageProperties.LastModifiedBy = data.DocumentProperties.Creator;
        }
    }
}
