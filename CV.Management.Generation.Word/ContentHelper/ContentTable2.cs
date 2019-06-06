using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;

namespace CV.Management.Generation.Word.ContentHelper
{
    public static class ContentTable2
    {
        // Creates an Table instance and adds its children.
        public static Table GenerateTable(GenerationData data)
        {
            Table table1 = new Table();

            TableProperties tableProperties1 = new TableProperties();
            TableWidth tableWidth1 = new TableWidth() { Width = "0", Type = TableWidthUnitValues.Auto };
            TableIndentation tableIndentation1 = new TableIndentation() { Width = 10, Type = TableWidthUnitValues.Dxa };

            TableBorders tableBorders1 = new TableBorders();
            TopBorder topBorder1 = new TopBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)10U, Space = (UInt32Value)0U };
            LeftBorder leftBorder1 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)10U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder1 = new BottomBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)10U, Space = (UInt32Value)0U };
            RightBorder rightBorder1 = new RightBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)10U, Space = (UInt32Value)0U };
            InsideHorizontalBorder insideHorizontalBorder1 = new InsideHorizontalBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)10U, Space = (UInt32Value)0U };
            InsideVerticalBorder insideVerticalBorder1 = new InsideVerticalBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)10U, Space = (UInt32Value)0U };

            tableBorders1.Append(topBorder1);
            tableBorders1.Append(leftBorder1);
            tableBorders1.Append(bottomBorder1);
            tableBorders1.Append(rightBorder1);
            tableBorders1.Append(insideHorizontalBorder1);
            tableBorders1.Append(insideVerticalBorder1);

            TableCellMarginDefault tableCellMarginDefault1 = new TableCellMarginDefault();
            TableCellLeftMargin tableCellLeftMargin1 = new TableCellLeftMargin() { Width = 10, Type = TableWidthValues.Dxa };
            TableCellRightMargin tableCellRightMargin1 = new TableCellRightMargin() { Width = 10, Type = TableWidthValues.Dxa };

            tableCellMarginDefault1.Append(tableCellLeftMargin1);
            tableCellMarginDefault1.Append(tableCellRightMargin1);
            TableLook tableLook1 = new TableLook() { Val = "0000", FirstRow = false, LastRow = false, FirstColumn = false, LastColumn = false, NoHorizontalBand = false, NoVerticalBand = false };

            tableProperties1.Append(tableWidth1);
            tableProperties1.Append(tableIndentation1);
            tableProperties1.Append(tableBorders1);
            tableProperties1.Append(tableCellMarginDefault1);
            tableProperties1.Append(tableLook1);

            TableGrid tableGrid1 = new TableGrid();
            GridColumn gridColumn1 = new GridColumn() { Width = "8980" };

            tableGrid1.Append(gridColumn1);

            TableRow tableRow1 = new TableRow() { RsidTableRowAddition = "009B2C1D", ParagraphId = "34C34FBB", TextId = "77777777" };

            TableCell tableCell1 = new TableCell();

            TableCellProperties tableCellProperties1 = new TableCellProperties();
            TableCellWidth tableCellWidth1 = new TableCellWidth() { Width = "15000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders1 = new TableCellBorders();
            TopBorder topBorder2 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder2 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder2 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder2 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders1.Append(topBorder2);
            tableCellBorders1.Append(leftBorder2);
            tableCellBorders1.Append(bottomBorder2);
            tableCellBorders1.Append(rightBorder2);

            tableCellProperties1.Append(tableCellWidth1);
            tableCellProperties1.Append(tableCellBorders1);

            Paragraph paragraph1 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "6C4075DB", TextId = "77777777" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines() { Before = "1000" };
            Justification justification1 = new Justification() { Val = JustificationValues.Center };

            paragraphProperties1.Append(spacingBetweenLines1);
            paragraphProperties1.Append(justification1);

            paragraph1.Append(paragraphProperties1);
            Paragraph paragraph2 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "7FF63C21", TextId = "77777777" };

            Paragraph paragraph3 = new Paragraph() { RsidParagraphMarkRevision = "00BE3F16", RsidParagraphAddition = "009E39C2", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "0007641E", ParagraphId = "0937AE70", TextId = "42846C98" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines2 = new SpacingBetweenLines() { Before = "1000" };
            Justification justification2 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties1 = new ParagraphMarkRunProperties();
            Bold bold1 = new Bold();
            FontSize fontSize1 = new FontSize() { Val = "28" };

            paragraphMarkRunProperties1.Append(bold1);
            paragraphMarkRunProperties1.Append(fontSize1);

            paragraphProperties2.Append(spacingBetweenLines2);
            paragraphProperties2.Append(justification2);
            paragraphProperties2.Append(paragraphMarkRunProperties1);

            Run run1 = new Run();

            RunProperties runProperties1 = new RunProperties();
            Bold bold2 = new Bold();
            FontSize fontSize2 = new FontSize() { Val = "28" };

            runProperties1.Append(bold2);
            runProperties1.Append(fontSize2);
            Text text1 = new Text();
            text1.Text = data.TitleArea.Project;

            run1.Append(runProperties1);
            run1.Append(text1);

            paragraph3.Append(paragraphProperties2);
            paragraph3.Append(run1);

            Paragraph paragraph4 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "01FC911A", TextId = "77777777" };

            Run run3 = new Run();

            RunProperties runProperties3 = new RunProperties();
            FontSize fontSize4 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript() { Val = "22" };

            runProperties3.Append(fontSize4);
            runProperties3.Append(fontSizeComplexScript1);
            Text text3 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text3.Text = " ";

            run3.Append(runProperties3);
            run3.Append(text3);

            paragraph4.Append(run3);

            Paragraph paragraph5 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "51573CC7", TextId = "77777777" };

            Run run4 = new Run();

            RunProperties runProperties4 = new RunProperties();
            FontSize fontSize5 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript2 = new FontSizeComplexScript() { Val = "22" };

            runProperties4.Append(fontSize5);
            runProperties4.Append(fontSizeComplexScript2);
            Text text4 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text4.Text = " ";

            run4.Append(runProperties4);
            run4.Append(text4);

            paragraph5.Append(run4);

            Paragraph paragraph6 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "1AC39030", TextId = "77777777" };

            Run run5 = new Run();

            RunProperties runProperties5 = new RunProperties();
            FontSize fontSize6 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript3 = new FontSizeComplexScript() { Val = "22" };

            runProperties5.Append(fontSize6);
            runProperties5.Append(fontSizeComplexScript3);
            Text text5 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text5.Text = " ";

            run5.Append(runProperties5);
            run5.Append(text5);

            paragraph6.Append(run5);

            Paragraph paragraph7 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "5B7F4F83", TextId = "77777777" };

            Run run6 = new Run();

            RunProperties runProperties6 = new RunProperties();
            FontSize fontSize7 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript4 = new FontSizeComplexScript() { Val = "22" };

            runProperties6.Append(fontSize7);
            runProperties6.Append(fontSizeComplexScript4);
            Text text6 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text6.Text = " ";

            run6.Append(runProperties6);
            run6.Append(text6);

            paragraph7.Append(run6);

            Paragraph paragraph8 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "3E1A38C5", TextId = "77777777" };

            ParagraphProperties paragraphProperties3 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines3 = new SpacingBetweenLines() { After = "195", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            paragraphProperties3.Append(spacingBetweenLines3);

            Run run7 = new Run();

            RunProperties runProperties7 = new RunProperties();
            FontSize fontSize8 = new FontSize() { Val = "15" };
            FontSizeComplexScript fontSizeComplexScript5 = new FontSizeComplexScript() { Val = "15" };

            runProperties7.Append(fontSize8);
            runProperties7.Append(fontSizeComplexScript5);
            Text text7 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text7.Text = DocumentMetadataTexts.GetText(MetadataTexts.CV_NOTICE_FIRST, data.Language);

            run7.Append(runProperties7);
            run7.Append(text7);
            
            paragraph8.Append(paragraphProperties3);
            paragraph8.Append(run7);

            Paragraph paragraph9 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "0F00B1CA", TextId = "77777777" };

            ParagraphProperties paragraphProperties4 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines4 = new SpacingBetweenLines() { After = "195", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            paragraphProperties4.Append(spacingBetweenLines4);

            Run run10 = new Run();

            RunProperties runProperties10 = new RunProperties();
            FontSize fontSize11 = new FontSize() { Val = "15" };
            FontSizeComplexScript fontSizeComplexScript8 = new FontSizeComplexScript() { Val = "15" };

            runProperties10.Append(fontSize11);
            runProperties10.Append(fontSizeComplexScript8);
            Text text10 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text10.Text = DocumentMetadataTexts.GetText(MetadataTexts.CV_NOTICE_SECOND, data.Language);

            run10.Append(runProperties10);
            run10.Append(text10);

            paragraph9.Append(paragraphProperties4);
            paragraph9.Append(run10);

            Paragraph paragraph10 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "28B14C27", TextId = "77777777" };

            ParagraphProperties paragraphProperties5 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines5 = new SpacingBetweenLines() { After = "195", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            paragraphProperties5.Append(spacingBetweenLines5);

            Run run19 = new Run();

            RunProperties runProperties19 = new RunProperties();
            FontSize fontSize20 = new FontSize() { Val = "15" };
            FontSizeComplexScript fontSizeComplexScript17 = new FontSizeComplexScript() { Val = "15" };

            runProperties19.Append(fontSize20);
            runProperties19.Append(fontSizeComplexScript17);
            Text text19 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text19.Text = DocumentMetadataTexts.GetText(MetadataTexts.CV_NOTICE_THIRD, data.Language);

            run19.Append(runProperties19);
            run19.Append(text19);

            paragraph10.Append(paragraphProperties5);
            paragraph10.Append(run19);

            tableCell1.Append(tableCellProperties1);
            tableCell1.Append(paragraph1);
            tableCell1.Append(paragraph2);
            tableCell1.Append(paragraph3);
            tableCell1.Append(paragraph4);
            tableCell1.Append(paragraph5);
            tableCell1.Append(paragraph6);
            tableCell1.Append(paragraph7);
            tableCell1.Append(paragraph8);
            tableCell1.Append(paragraph9);
            tableCell1.Append(paragraph10);

            tableRow1.Append(tableCell1);

            table1.Append(tableProperties1);
            table1.Append(tableGrid1);
            table1.Append(tableRow1);
            return table1;
        }
    }
}
