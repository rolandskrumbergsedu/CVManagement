using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace CV.Management.Generation.Word.Helpers
{
    public static class FootnotesPartHelper
    {
        public static void GenerateFootnotesPart1Content(FootnotesPart footnotesPart1)
        {
            var footnotes1 = new Footnotes { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 w15 w16se w16cid wp14" } };
            footnotes1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            footnotes1.AddNamespaceDeclaration("cx", "http://schemas.microsoft.com/office/drawing/2014/chartex");
            footnotes1.AddNamespaceDeclaration("cx1", "http://schemas.microsoft.com/office/drawing/2015/9/8/chartex");
            footnotes1.AddNamespaceDeclaration("cx2", "http://schemas.microsoft.com/office/drawing/2015/10/21/chartex");
            footnotes1.AddNamespaceDeclaration("cx3", "http://schemas.microsoft.com/office/drawing/2016/5/9/chartex");
            footnotes1.AddNamespaceDeclaration("cx4", "http://schemas.microsoft.com/office/drawing/2016/5/10/chartex");
            footnotes1.AddNamespaceDeclaration("cx5", "http://schemas.microsoft.com/office/drawing/2016/5/11/chartex");
            footnotes1.AddNamespaceDeclaration("cx6", "http://schemas.microsoft.com/office/drawing/2016/5/12/chartex");
            footnotes1.AddNamespaceDeclaration("cx7", "http://schemas.microsoft.com/office/drawing/2016/5/13/chartex");
            footnotes1.AddNamespaceDeclaration("cx8", "http://schemas.microsoft.com/office/drawing/2016/5/14/chartex");
            footnotes1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            footnotes1.AddNamespaceDeclaration("aink", "http://schemas.microsoft.com/office/drawing/2016/ink");
            footnotes1.AddNamespaceDeclaration("am3d", "http://schemas.microsoft.com/office/drawing/2017/model3d");
            footnotes1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            footnotes1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            footnotes1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            footnotes1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            footnotes1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            footnotes1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            footnotes1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            footnotes1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            footnotes1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            footnotes1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");
            footnotes1.AddNamespaceDeclaration("w16cid", "http://schemas.microsoft.com/office/word/2016/wordml/cid");
            footnotes1.AddNamespaceDeclaration("w16se", "http://schemas.microsoft.com/office/word/2015/wordml/symex");
            footnotes1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            footnotes1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            footnotes1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            footnotes1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            var footnote1 = new Footnote { Type = FootnoteEndnoteValues.Separator, Id = -1 };

            var paragraph274 = new Paragraph { RsidParagraphAddition = "003C529E", RsidRunAdditionDefault = "003C529E", ParagraphId = "46435F23", TextId = "77777777" };

            var paragraphProperties177 = new ParagraphProperties();
            var spacingBetweenLines173 = new SpacingBetweenLines { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            paragraphProperties177.Append(spacingBetweenLines173);

            var run403 = new Run();
            var separatorMark2 = new SeparatorMark();

            run403.Append(separatorMark2);

            paragraph274.Append(paragraphProperties177);
            paragraph274.Append(run403);

            footnote1.Append(paragraph274);

            var footnote2 = new Footnote { Type = FootnoteEndnoteValues.ContinuationSeparator, Id = 0 };

            var paragraph275 = new Paragraph { RsidParagraphAddition = "003C529E", RsidRunAdditionDefault = "003C529E", ParagraphId = "69C342F4", TextId = "77777777" };

            var paragraphProperties178 = new ParagraphProperties();
            var spacingBetweenLines174 = new SpacingBetweenLines { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            paragraphProperties178.Append(spacingBetweenLines174);

            var run404 = new Run();
            var continuationSeparatorMark2 = new ContinuationSeparatorMark();

            run404.Append(continuationSeparatorMark2);

            paragraph275.Append(paragraphProperties178);
            paragraph275.Append(run404);

            footnote2.Append(paragraph275);

            footnotes1.Append(footnote1);
            footnotes1.Append(footnote2);

            footnotesPart1.Footnotes = footnotes1;
        }
    }
}
