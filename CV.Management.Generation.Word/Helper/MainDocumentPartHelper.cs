using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;
using CV.Management.Generation.Word.ContentHelper;

namespace CV.Management.Generation.Word.Helpers
{
    public static class MainDocumentPartHelper
    {
        public static void GenerateMainDocumentPart1Content(MainDocumentPart mainDocumentPart1, GenerationData data)
        {
            Document document1 = ContentDocument.CreateDocument();

            Body body1 = new Body();

            SectionProperties sectionProperties1 = ContentSectionProperties.CreateProperties();

            body1.Append(ContentTable1.GenerateTable(data));
            body1.Append(ContentParagraph1.GenerateParagraph());
            body1.Append(ContentTable2.GenerateTable(data));
            body1.Append(ContentParagraph2.GenerateParagraph());
            body1.Append(ContentTable3.GenerateTable(data));
            body1.Append(ContentParagraph3.GenerateParagraph());
            body1.Append(ContentParagraph4.GenerateParagraph());
            body1.Append(ContentTable4.GenerateTable(data));
            body1.Append(ContentParagraph5.GenerateParagraph());
            body1.Append(ContentTable5.GenerateTable(data));
            body1.Append(ContentParagraph6.GenerateParagraph());
            body1.Append(ContentParagraph7.GenerateParagraph());
            body1.Append(ContentParagraph8.GenerateParagraph());
            body1.Append(ContentTable6.GenerateTable(data));
            body1.Append(ContentParagraph9.GenerateParagraph());
            body1.Append(ContentParagraph10.GenerateParagraph());
            body1.Append(ContentParagraph11.GenerateParagraph());
            body1.Append(ContentTable7.GenerateTable(data)); // Career summary
            body1.Append(ContentParagraph12.GenerateParagraph());
            body1.Append(ContentTable8.GenerateTable(data)); // Memberships
            body1.Append(ContentParagraph13.GenerateParagraph());
            body1.Append(ContentTable9.GenerateTable(data)); // Compensation
            body1.Append(ContentParagraph14.GenerateParagraph());
            body1.Append(ContentTable10.GenerateTable(data)); // Transition time
            body1.Append(ContentParagraph15.GenerateParagraph());
            body1.Append(ContentTable11.GenerateTable(data)); // Additional comments
            body1.Append(ContentParagraph16.GenerateParagraph());
            body1.Append(ContentParagraph17.GenerateParagraph());
            body1.Append(sectionProperties1);

            document1.Append(body1);

            mainDocumentPart1.Document = document1;
        }
    }
}
