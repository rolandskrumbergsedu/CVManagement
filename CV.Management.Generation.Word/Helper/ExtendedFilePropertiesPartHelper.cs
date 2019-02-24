using DocumentFormat.OpenXml.Packaging;

namespace CV.Management.Generation.Word.Helpers
{
    public static class ExtendedFilePropertiesPartHelper
    {
        public static void GenerateExtendedFilePropertiesPart1Content(ExtendedFilePropertiesPart extendedFilePropertiesPart1)
        {
            var properties1 = new DocumentFormat.OpenXml.ExtendedProperties.Properties();
            properties1.AddNamespaceDeclaration("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");
            var template1 =
                new DocumentFormat.OpenXml.ExtendedProperties.Template {Text = "Normal"};
            var totalTime1 =
                new DocumentFormat.OpenXml.ExtendedProperties.TotalTime {Text = "5"};
            //var pages1 = new DocumentFormat.OpenXml.ExtendedProperties.Pages {Text = "7"};
            //var words1 = new DocumentFormat.OpenXml.ExtendedProperties.Words {Text = "1216"};
            //var characters1 = new DocumentFormat.OpenXml.ExtendedProperties.Characters {Text = "6936"};
            var application1 =
                new DocumentFormat.OpenXml.ExtendedProperties.Application {Text = "Microsoft Office Word"};
            var documentSecurity1 = new DocumentFormat.OpenXml.ExtendedProperties.DocumentSecurity {Text = "0"};
            //var lines1 = new DocumentFormat.OpenXml.ExtendedProperties.Lines {Text = "57"};
            //var paragraphs1 =
                new DocumentFormat.OpenXml.ExtendedProperties.Paragraphs {Text = "16"};
            var scaleCrop1 = new DocumentFormat.OpenXml.ExtendedProperties.ScaleCrop {Text = "false"};

            var headingPairs1 = new DocumentFormat.OpenXml.ExtendedProperties.HeadingPairs();

            var vTVector1 = new DocumentFormat.OpenXml.VariantTypes.VTVector { BaseType = DocumentFormat.OpenXml.VariantTypes.VectorBaseValues.Variant, Size = 2U };

            var variant1 = new DocumentFormat.OpenXml.VariantTypes.Variant();
            var vTLPSTR1 = new DocumentFormat.OpenXml.VariantTypes.VTLPSTR {Text = "Title"};

            variant1.Append(vTLPSTR1);

            var variant2 = new DocumentFormat.OpenXml.VariantTypes.Variant();
            var vTInt321 = new DocumentFormat.OpenXml.VariantTypes.VTInt32 {Text = "1"};

            variant2.Append(vTInt321);

            vTVector1.Append(variant1);
            vTVector1.Append(variant2);

            headingPairs1.Append(vTVector1);

            var titlesOfParts1 = new DocumentFormat.OpenXml.ExtendedProperties.TitlesOfParts();

            var vTVector2 = new DocumentFormat.OpenXml.VariantTypes.VTVector { BaseType = DocumentFormat.OpenXml.VariantTypes.VectorBaseValues.Lpstr, Size = 1U };
            var vTLPSTR2 =
                new DocumentFormat.OpenXml.VariantTypes.VTLPSTR {Text = ""};

            vTVector2.Append(vTLPSTR2);

            titlesOfParts1.Append(vTVector2);
            var manager1 = new DocumentFormat.OpenXml.ExtendedProperties.Manager {Text = ""};
            var company1 = new DocumentFormat.OpenXml.ExtendedProperties.Company {Text = ""};
            var linksUpToDate1 = new DocumentFormat.OpenXml.ExtendedProperties.LinksUpToDate {Text = "false"};
            var charactersWithSpaces1 =
                new DocumentFormat.OpenXml.ExtendedProperties.CharactersWithSpaces {Text = "8136"};
            var sharedDocument1 = new DocumentFormat.OpenXml.ExtendedProperties.SharedDocument {Text = "false"};
            var hyperlinksChanged1 = new DocumentFormat.OpenXml.ExtendedProperties.HyperlinksChanged {Text = "false"};
            var applicationVersion1 =
                new DocumentFormat.OpenXml.ExtendedProperties.ApplicationVersion {Text = "16.0000"};

            properties1.Append(template1);
            properties1.Append(totalTime1);
            //properties1.Append(pages1);
            //properties1.Append(words1);
            //properties1.Append(characters1);
            properties1.Append(application1);
            properties1.Append(documentSecurity1);
            //properties1.Append(lines1);
            //properties1.Append(paragraphs1);
            properties1.Append(scaleCrop1);
            properties1.Append(headingPairs1);
            properties1.Append(titlesOfParts1);
            properties1.Append(manager1);
            properties1.Append(company1);
            properties1.Append(linksUpToDate1);
            properties1.Append(charactersWithSpaces1);
            properties1.Append(sharedDocument1);
            properties1.Append(hyperlinksChanged1);
            properties1.Append(applicationVersion1);

            extendedFilePropertiesPart1.Properties = properties1;
        }
    }
}
