using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace CV.Management.Generation.Word.Helpers
{
    public static class EndnotesPartHelper
    {
        public static void GenerateEndnotesPart1Content(EndnotesPart endnotesPart1)
        {
            var endnotes1 = new Endnotes
            {
                MCAttributes = new MarkupCompatibilityAttributes {Ignorable = "w14 w15 w16se w16cid wp14"}
            };
            endnotes1.AddNamespaceDeclaration("wpc",
                "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            endnotes1.AddNamespaceDeclaration("cx", "http://schemas.microsoft.com/office/drawing/2014/chartex");
            endnotes1.AddNamespaceDeclaration("cx1", "http://schemas.microsoft.com/office/drawing/2015/9/8/chartex");
            endnotes1.AddNamespaceDeclaration("cx2", "http://schemas.microsoft.com/office/drawing/2015/10/21/chartex");
            endnotes1.AddNamespaceDeclaration("cx3", "http://schemas.microsoft.com/office/drawing/2016/5/9/chartex");
            endnotes1.AddNamespaceDeclaration("cx4", "http://schemas.microsoft.com/office/drawing/2016/5/10/chartex");
            endnotes1.AddNamespaceDeclaration("cx5", "http://schemas.microsoft.com/office/drawing/2016/5/11/chartex");
            endnotes1.AddNamespaceDeclaration("cx6", "http://schemas.microsoft.com/office/drawing/2016/5/12/chartex");
            endnotes1.AddNamespaceDeclaration("cx7", "http://schemas.microsoft.com/office/drawing/2016/5/13/chartex");
            endnotes1.AddNamespaceDeclaration("cx8", "http://schemas.microsoft.com/office/drawing/2016/5/14/chartex");
            endnotes1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            endnotes1.AddNamespaceDeclaration("aink", "http://schemas.microsoft.com/office/drawing/2016/ink");
            endnotes1.AddNamespaceDeclaration("am3d", "http://schemas.microsoft.com/office/drawing/2017/model3d");
            endnotes1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            endnotes1.AddNamespaceDeclaration("r",
                "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            endnotes1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            endnotes1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            endnotes1.AddNamespaceDeclaration("wp14",
                "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            endnotes1.AddNamespaceDeclaration("wp",
                "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            endnotes1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            endnotes1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            endnotes1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            endnotes1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");
            endnotes1.AddNamespaceDeclaration("w16cid", "http://schemas.microsoft.com/office/word/2016/wordml/cid");
            endnotes1.AddNamespaceDeclaration("w16se", "http://schemas.microsoft.com/office/word/2015/wordml/symex");
            endnotes1.AddNamespaceDeclaration("wpg",
                "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            endnotes1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            endnotes1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            endnotes1.AddNamespaceDeclaration("wps",
                "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            var endnote1 = new Endnote {Type = FootnoteEndnoteValues.Separator, Id = -1};

            var paragraph271 = new Paragraph
            {
                RsidParagraphAddition = "003C529E",
                RsidRunAdditionDefault = "003C529E",
                ParagraphId = "45330DB0",
                TextId = "77777777"
            };

            var paragraphProperties174 = new ParagraphProperties();
            var spacingBetweenLines171 =
                new SpacingBetweenLines {After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto};

            paragraphProperties174.Append(spacingBetweenLines171);

            var run394 = new Run();
            var separatorMark1 = new SeparatorMark();

            run394.Append(separatorMark1);

            paragraph271.Append(paragraphProperties174);
            paragraph271.Append(run394);

            endnote1.Append(paragraph271);

            var endnote2 = new Endnote {Type = FootnoteEndnoteValues.ContinuationSeparator, Id = 0};

            var paragraph272 = new Paragraph
            {
                RsidParagraphAddition = "003C529E",
                RsidRunAdditionDefault = "003C529E",
                ParagraphId = "02CE0DA3",
                TextId = "77777777"
            };

            var paragraphProperties175 = new ParagraphProperties();
            var spacingBetweenLines172 =
                new SpacingBetweenLines {After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto};

            paragraphProperties175.Append(spacingBetweenLines172);

            var run395 = new Run();
            var continuationSeparatorMark1 = new ContinuationSeparatorMark();

            run395.Append(continuationSeparatorMark1);

            paragraph272.Append(paragraphProperties175);
            paragraph272.Append(run395);

            endnote2.Append(paragraph272);

            endnotes1.Append(endnote1);
            endnotes1.Append(endnote2);

            endnotesPart1.Endnotes = endnotes1;
        }
    }
}

