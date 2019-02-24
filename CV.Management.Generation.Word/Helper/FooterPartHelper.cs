using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace CV.Management.Generation.Word.Helpers
{
    public static class FooterPartHelper
    {
        public static void GenerateFooterPart1Content(FooterPart footerPart1)
        {
            var footer1 = new Footer { MCAttributes = new MarkupCompatibilityAttributes { Ignorable = "w14 w15 w16se w16cid wp14" } };
            footer1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            footer1.AddNamespaceDeclaration("cx", "http://schemas.microsoft.com/office/drawing/2014/chartex");
            footer1.AddNamespaceDeclaration("cx1", "http://schemas.microsoft.com/office/drawing/2015/9/8/chartex");
            footer1.AddNamespaceDeclaration("cx2", "http://schemas.microsoft.com/office/drawing/2015/10/21/chartex");
            footer1.AddNamespaceDeclaration("cx3", "http://schemas.microsoft.com/office/drawing/2016/5/9/chartex");
            footer1.AddNamespaceDeclaration("cx4", "http://schemas.microsoft.com/office/drawing/2016/5/10/chartex");
            footer1.AddNamespaceDeclaration("cx5", "http://schemas.microsoft.com/office/drawing/2016/5/11/chartex");
            footer1.AddNamespaceDeclaration("cx6", "http://schemas.microsoft.com/office/drawing/2016/5/12/chartex");
            footer1.AddNamespaceDeclaration("cx7", "http://schemas.microsoft.com/office/drawing/2016/5/13/chartex");
            footer1.AddNamespaceDeclaration("cx8", "http://schemas.microsoft.com/office/drawing/2016/5/14/chartex");
            footer1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            footer1.AddNamespaceDeclaration("aink", "http://schemas.microsoft.com/office/drawing/2016/ink");
            footer1.AddNamespaceDeclaration("am3d", "http://schemas.microsoft.com/office/drawing/2017/model3d");
            footer1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            footer1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            footer1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            footer1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            footer1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            footer1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            footer1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            footer1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            footer1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            footer1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");
            footer1.AddNamespaceDeclaration("w16cid", "http://schemas.microsoft.com/office/word/2016/wordml/cid");
            footer1.AddNamespaceDeclaration("w16se", "http://schemas.microsoft.com/office/word/2015/wordml/symex");
            footer1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            footer1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            footer1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            footer1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            var paragraph273 = new Paragraph { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "71F3416E", TextId = "77777777" };

            var paragraphProperties176 = new ParagraphProperties();
            var paragraphStyleId1 = new ParagraphStyleId { Val = "leftRight" };

            paragraphProperties176.Append(paragraphStyleId1);

            var run396 = new Run();
            var text366 = new Text {Text = "Confidential Candidate CV"};

            run396.Append(text366);

            var run397 = new Run();
            var tabChar1 = new TabChar();

            run397.Append(tabChar1);

            var run398 = new Run();
            var fieldChar1 = new FieldChar { FieldCharType = FieldCharValues.Begin };

            run398.Append(fieldChar1);

            var run399 = new Run();
            var fieldCode1 = new FieldCode {Text = "PAGE"};

            run399.Append(fieldCode1);

            var run400 = new Run();
            var fieldChar2 = new FieldChar { FieldCharType = FieldCharValues.Separate };

            run400.Append(fieldChar2);

            var run401 = new Run();

            var runProperties394 = new RunProperties();
            var noProof30 = new NoProof();

            runProperties394.Append(noProof30);
            var text367 = new Text {Text = "2"};

            run401.Append(runProperties394);
            run401.Append(text367);

            var run402 = new Run();
            var fieldChar3 = new FieldChar { FieldCharType = FieldCharValues.End };

            run402.Append(fieldChar3);

            paragraph273.Append(paragraphProperties176);
            paragraph273.Append(run396);
            paragraph273.Append(run397);
            paragraph273.Append(run398);
            paragraph273.Append(run399);
            paragraph273.Append(run400);
            paragraph273.Append(run401);
            paragraph273.Append(run402);

            footer1.Append(paragraph273);

            footerPart1.Footer = footer1;
        }
    }
}
