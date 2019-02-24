using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;

namespace CV.Management.Generation.Word.ContentHelper
{
    public static class ContentParagraph8
    {
        // Creates an Paragraph instance and adds its children.
        public static Paragraph GenerateParagraph()
        {
            Paragraph paragraph1 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "75A31351", TextId = "77777777" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties();
            PageBreakBefore pageBreakBefore1 = new PageBreakBefore();
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            paragraphProperties1.Append(pageBreakBefore1);
            paragraphProperties1.Append(spacingBetweenLines1);

            Run run1 = new Run();

            RunProperties runProperties1 = new RunProperties();
            FontSize fontSize1 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript() { Val = "22" };

            runProperties1.Append(fontSize1);
            runProperties1.Append(fontSizeComplexScript1);
            LastRenderedPageBreak lastRenderedPageBreak1 = new LastRenderedPageBreak();
            Text text1 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text1.Text = " ";

            run1.Append(runProperties1);
            run1.Append(lastRenderedPageBreak1);
            run1.Append(text1);

            paragraph1.Append(paragraphProperties1);
            paragraph1.Append(run1);
            return paragraph1;
        }


    }
}
