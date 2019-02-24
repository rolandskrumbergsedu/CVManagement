using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace CV.Management.Generation.Word.Helpers
{
    public static class HeaderPartHelper
    {
        public static void GenerateHeaderPart1Content(HeaderPart headerPart1, GenerationData data)
        {
            var header1 = new Header { MCAttributes = new MarkupCompatibilityAttributes { Ignorable = "w14 w15 w16se w16cid wp14" } };
            header1.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            header1.AddNamespaceDeclaration("cx", "http://schemas.microsoft.com/office/drawing/2014/chartex");
            header1.AddNamespaceDeclaration("cx1", "http://schemas.microsoft.com/office/drawing/2015/9/8/chartex");
            header1.AddNamespaceDeclaration("cx2", "http://schemas.microsoft.com/office/drawing/2015/10/21/chartex");
            header1.AddNamespaceDeclaration("cx3", "http://schemas.microsoft.com/office/drawing/2016/5/9/chartex");
            header1.AddNamespaceDeclaration("cx4", "http://schemas.microsoft.com/office/drawing/2016/5/10/chartex");
            header1.AddNamespaceDeclaration("cx5", "http://schemas.microsoft.com/office/drawing/2016/5/11/chartex");
            header1.AddNamespaceDeclaration("cx6", "http://schemas.microsoft.com/office/drawing/2016/5/12/chartex");
            header1.AddNamespaceDeclaration("cx7", "http://schemas.microsoft.com/office/drawing/2016/5/13/chartex");
            header1.AddNamespaceDeclaration("cx8", "http://schemas.microsoft.com/office/drawing/2016/5/14/chartex");
            header1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            header1.AddNamespaceDeclaration("aink", "http://schemas.microsoft.com/office/drawing/2016/ink");
            header1.AddNamespaceDeclaration("am3d", "http://schemas.microsoft.com/office/drawing/2017/model3d");
            header1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            header1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            header1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            header1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            header1.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            header1.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            header1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            header1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            header1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            header1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");
            header1.AddNamespaceDeclaration("w16cid", "http://schemas.microsoft.com/office/word/2016/wordml/cid");
            header1.AddNamespaceDeclaration("w16se", "http://schemas.microsoft.com/office/word/2015/wordml/symex");
            header1.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            header1.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            header1.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            header1.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            var table12 = new Table();

            var tableProperties12 = new TableProperties();
            var tableWidth12 = new TableWidth { Width = "0", Type = TableWidthUnitValues.Auto };
            var tableIndentation12 = new TableIndentation { Width = 10, Type = TableWidthUnitValues.Dxa };

            var tableCellMarginDefault12 = new TableCellMarginDefault();
            var tableCellLeftMargin12 = new TableCellLeftMargin { Width = 10, Type = TableWidthValues.Dxa };
            var tableCellRightMargin12 = new TableCellRightMargin { Width = 10, Type = TableWidthValues.Dxa };

            tableCellMarginDefault12.Append(tableCellLeftMargin12);
            tableCellMarginDefault12.Append(tableCellRightMargin12);
            var tableLook12 = new TableLook { Val = "0000" };

            tableProperties12.Append(tableWidth12);
            tableProperties12.Append(tableIndentation12);
            tableProperties12.Append(tableCellMarginDefault12);
            tableProperties12.Append(tableLook12);

            var tableGrid12 = new TableGrid();
            var gridColumn39 = new GridColumn { Width = "8980" };

            tableGrid12.Append(gridColumn39);

            var tableRow79 = new TableRow { RsidTableRowAddition = "009B2C1D", ParagraphId = "07A74B1D", TextId = "77777777" };

            var tableCell180 = new TableCell();

            var tableCellProperties180 = new TableCellProperties();
            var tableCellWidth180 = new TableCellWidth { Width = "9000", Type = TableWidthUnitValues.Dxa };
            var shading8 = new Shading { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "1C75BC" };

            tableCellProperties180.Append(tableCellWidth180);
            tableCellProperties180.Append(shading8);

            var paragraph276 = new Paragraph { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "0007641E", ParagraphId = "7EE08DA7", TextId = "2A892E24" };

            var paragraphProperties179 = new ParagraphProperties();
            var spacingBetweenLines175 = new SpacingBetweenLines { Before = "10", After = "10" };
            var justification13 = new Justification { Val = JustificationValues.Center };

            paragraphProperties179.Append(spacingBetweenLines175);
            paragraphProperties179.Append(justification13);

            var run405 = new Run();

            var runProperties395 = new RunProperties();
            var bold57 = new Bold();
            var caps1 = new Caps();
            var color12 = new Color { Val = "FFFFFF" };
            var fontSize370 = new FontSize { Val = "21" };
            var fontSizeComplexScript367 = new FontSizeComplexScript { Val = "21" };

            runProperties395.Append(bold57);
            runProperties395.Append(caps1);
            runProperties395.Append(color12);
            runProperties395.Append(fontSize370);
            runProperties395.Append(fontSizeComplexScript367);
            var text368 = new Text {Text = data.TitleArea.Name};

            run405.Append(runProperties395);
            run405.Append(text368);

            paragraph276.Append(paragraphProperties179);
            paragraph276.Append(run405);

            tableCell180.Append(tableCellProperties180);
            tableCell180.Append(paragraph276);

            tableRow79.Append(tableCell180);

            table12.Append(tableProperties12);
            table12.Append(tableGrid12);
            table12.Append(tableRow79);

            header1.Append(table12);

            headerPart1.Header = header1;
        }

        public static void GenerateHeaderPart2Content(HeaderPart headerPart2)
        {
            Header header2 = new Header() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "w14 w15 w16se w16cid wp14" } };
            header2.AddNamespaceDeclaration("wpc", "http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas");
            header2.AddNamespaceDeclaration("cx", "http://schemas.microsoft.com/office/drawing/2014/chartex");
            header2.AddNamespaceDeclaration("cx1", "http://schemas.microsoft.com/office/drawing/2015/9/8/chartex");
            header2.AddNamespaceDeclaration("cx2", "http://schemas.microsoft.com/office/drawing/2015/10/21/chartex");
            header2.AddNamespaceDeclaration("cx3", "http://schemas.microsoft.com/office/drawing/2016/5/9/chartex");
            header2.AddNamespaceDeclaration("cx4", "http://schemas.microsoft.com/office/drawing/2016/5/10/chartex");
            header2.AddNamespaceDeclaration("cx5", "http://schemas.microsoft.com/office/drawing/2016/5/11/chartex");
            header2.AddNamespaceDeclaration("cx6", "http://schemas.microsoft.com/office/drawing/2016/5/12/chartex");
            header2.AddNamespaceDeclaration("cx7", "http://schemas.microsoft.com/office/drawing/2016/5/13/chartex");
            header2.AddNamespaceDeclaration("cx8", "http://schemas.microsoft.com/office/drawing/2016/5/14/chartex");
            header2.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            header2.AddNamespaceDeclaration("aink", "http://schemas.microsoft.com/office/drawing/2016/ink");
            header2.AddNamespaceDeclaration("am3d", "http://schemas.microsoft.com/office/drawing/2017/model3d");
            header2.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            header2.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            header2.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            header2.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            header2.AddNamespaceDeclaration("wp14", "http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing");
            header2.AddNamespaceDeclaration("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
            header2.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            header2.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            header2.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            header2.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");
            header2.AddNamespaceDeclaration("w16cid", "http://schemas.microsoft.com/office/word/2016/wordml/cid");
            header2.AddNamespaceDeclaration("w16se", "http://schemas.microsoft.com/office/word/2015/wordml/symex");
            header2.AddNamespaceDeclaration("wpg", "http://schemas.microsoft.com/office/word/2010/wordprocessingGroup");
            header2.AddNamespaceDeclaration("wpi", "http://schemas.microsoft.com/office/word/2010/wordprocessingInk");
            header2.AddNamespaceDeclaration("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
            header2.AddNamespaceDeclaration("wps", "http://schemas.microsoft.com/office/word/2010/wordprocessingShape");

            Paragraph paragraph277 = new Paragraph() { RsidParagraphAddition = "00F225EA", RsidRunAdditionDefault = "009E39C2", ParagraphId = "637CAE62", TextId = "77777777" };

            Run run406 = new Run();
            CarriageReturn carriageReturn1 = new CarriageReturn();

            run406.Append(carriageReturn1);

            paragraph277.Append(run406);

            header2.Append(paragraph277);

            headerPart2.Header = header2;
        }
    }
}
