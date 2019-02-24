using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;

namespace CV.Management.Generation.Word.ContentHelper
{
    public static class ContentTable7
    {
        // Creates an Table instance and adds its children.
        public static Table GenerateTable()
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
            GridColumn gridColumn1 = new GridColumn() { Width = "2550" };
            GridColumn gridColumn2 = new GridColumn() { Width = "6000" };
            GridColumn gridColumn3 = new GridColumn() { Width = "360" };

            tableGrid1.Append(gridColumn1);
            tableGrid1.Append(gridColumn2);
            tableGrid1.Append(gridColumn3);

            TableRow tableRow1 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "292E8487", TextId = "77777777" };

            TableCell tableCell1 = new TableCell();

            TableCellProperties tableCellProperties1 = new TableCellProperties();
            TableCellWidth tableCellWidth1 = new TableCellWidth() { Width = "8910", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan1 = new GridSpan() { Val = 3 };

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
            tableCellProperties1.Append(gridSpan1);
            tableCellProperties1.Append(tableCellBorders1);

            Paragraph paragraph1 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "1A8987E1", TextId = "77777777" };

            Run run1 = new Run();

            RunProperties runProperties1 = new RunProperties();
            Bold bold1 = new Bold();
            FontSize fontSize1 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript() { Val = "22" };

            runProperties1.Append(bold1);
            runProperties1.Append(fontSize1);
            runProperties1.Append(fontSizeComplexScript1);
            Text text1 = new Text();
            text1.Text = "CAREER SUMMARY";

            run1.Append(runProperties1);
            run1.Append(text1);

            Run run2 = new Run();

            RunProperties runProperties2 = new RunProperties();
            FontSize fontSize2 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript2 = new FontSizeComplexScript() { Val = "22" };

            runProperties2.Append(fontSize2);
            runProperties2.Append(fontSizeComplexScript2);
            Text text2 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text2.Text = "   ";

            run2.Append(runProperties2);
            run2.Append(text2);

            paragraph1.Append(run1);
            paragraph1.Append(run2);

            tableCell1.Append(tableCellProperties1);
            tableCell1.Append(paragraph1);

            tableRow1.Append(tableCell1);

            TableRow tableRow2 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "69B55967", TextId = "77777777" };

            TableRowProperties tableRowProperties1 = new TableRowProperties();
            GridAfter gridAfter1 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow1 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties1.Append(gridAfter1);
            tableRowProperties1.Append(widthAfterTableRow1);

            TableCell tableCell2 = new TableCell();

            TableCellProperties tableCellProperties2 = new TableCellProperties();
            TableCellWidth tableCellWidth2 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders2 = new TableCellBorders();
            TopBorder topBorder3 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder3 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder3 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder3 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders2.Append(topBorder3);
            tableCellBorders2.Append(leftBorder3);
            tableCellBorders2.Append(bottomBorder3);
            tableCellBorders2.Append(rightBorder3);

            tableCellProperties2.Append(tableCellWidth2);
            tableCellProperties2.Append(tableCellBorders2);

            Paragraph paragraph2 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "789EF4F3", TextId = "77777777" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines() { Before = "30", After = "10" };

            paragraphProperties1.Append(spacingBetweenLines1);

            Run run3 = new Run();

            RunProperties runProperties3 = new RunProperties();
            FontSize fontSize3 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript3 = new FontSizeComplexScript() { Val = "22" };

            runProperties3.Append(fontSize3);
            runProperties3.Append(fontSizeComplexScript3);
            Text text3 = new Text();
            text3.Text = "2018 - present";

            run3.Append(runProperties3);
            run3.Append(text3);

            paragraph2.Append(paragraphProperties1);
            paragraph2.Append(run3);

            tableCell2.Append(tableCellProperties2);
            tableCell2.Append(paragraph2);

            TableCell tableCell3 = new TableCell();

            TableCellProperties tableCellProperties3 = new TableCellProperties();
            TableCellWidth tableCellWidth3 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders3 = new TableCellBorders();
            TopBorder topBorder4 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder4 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder4 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder4 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders3.Append(topBorder4);
            tableCellBorders3.Append(leftBorder4);
            tableCellBorders3.Append(bottomBorder4);
            tableCellBorders3.Append(rightBorder4);
            Shading shading1 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "0069B4" };

            tableCellProperties3.Append(tableCellWidth3);
            tableCellProperties3.Append(tableCellBorders3);
            tableCellProperties3.Append(shading1);

            Paragraph paragraph3 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "0527FA2E", TextId = "6AA72ECF" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines2 = new SpacingBetweenLines() { Before = "30", After = "10", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation1 = new Indentation() { Left = "144" };

            paragraphProperties2.Append(spacingBetweenLines2);
            paragraphProperties2.Append(indentation1);

            Run run4 = new Run();

            RunProperties runProperties4 = new RunProperties();
            Bold bold2 = new Bold();
            Color color1 = new Color() { Val = "FFFFFF" };
            FontSize fontSize4 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript4 = new FontSizeComplexScript() { Val = "21" };

            runProperties4.Append(bold2);
            runProperties4.Append(color1);
            runProperties4.Append(fontSize4);
            runProperties4.Append(fontSizeComplexScript4);
            Text text4 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text4.Text = "SIA ";

            run4.Append(runProperties4);
            run4.Append(text4);

            Run run5 = new Run() { RsidRunAddition = "0007641E" };

            RunProperties runProperties5 = new RunProperties();
            Bold bold3 = new Bold();
            Color color2 = new Color() { Val = "FFFFFF" };
            FontSize fontSize5 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript5 = new FontSizeComplexScript() { Val = "21" };

            runProperties5.Append(bold3);
            runProperties5.Append(color2);
            runProperties5.Append(fontSize5);
            runProperties5.Append(fontSizeComplexScript5);
            Text text5 = new Text();
            text5.Text = "B";

            run5.Append(runProperties5);
            run5.Append(text5);

            paragraph3.Append(paragraphProperties2);
            paragraph3.Append(run4);
            paragraph3.Append(run5);

            tableCell3.Append(tableCellProperties3);
            tableCell3.Append(paragraph3);

            tableRow2.Append(tableRowProperties1);
            tableRow2.Append(tableCell2);
            tableRow2.Append(tableCell3);

            TableRow tableRow3 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "25CC8C24", TextId = "77777777" };

            TableRowProperties tableRowProperties2 = new TableRowProperties();
            GridAfter gridAfter2 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow2 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties2.Append(gridAfter2);
            tableRowProperties2.Append(widthAfterTableRow2);

            TableCell tableCell4 = new TableCell();

            TableCellProperties tableCellProperties4 = new TableCellProperties();
            TableCellWidth tableCellWidth4 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders4 = new TableCellBorders();
            TopBorder topBorder5 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder5 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder5 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder5 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders4.Append(topBorder5);
            tableCellBorders4.Append(leftBorder5);
            tableCellBorders4.Append(bottomBorder5);
            tableCellBorders4.Append(rightBorder5);

            tableCellProperties4.Append(tableCellWidth4);
            tableCellProperties4.Append(tableCellBorders4);
            Paragraph paragraph4 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "6D33A213", TextId = "77777777" };

            tableCell4.Append(tableCellProperties4);
            tableCell4.Append(paragraph4);

            TableCell tableCell5 = new TableCell();

            TableCellProperties tableCellProperties5 = new TableCellProperties();
            TableCellWidth tableCellWidth5 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders5 = new TableCellBorders();
            TopBorder topBorder6 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder6 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder6 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder6 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders5.Append(topBorder6);
            tableCellBorders5.Append(leftBorder6);
            tableCellBorders5.Append(bottomBorder6);
            tableCellBorders5.Append(rightBorder6);

            tableCellProperties5.Append(tableCellWidth5);
            tableCellProperties5.Append(tableCellBorders5);

            Paragraph paragraph5 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "70DDB50D", TextId = "77777777" };

            ParagraphProperties paragraphProperties3 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines3 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation2 = new Indentation() { Left = "144" };

            paragraphProperties3.Append(spacingBetweenLines3);
            paragraphProperties3.Append(indentation2);

            Run run6 = new Run();

            RunProperties runProperties6 = new RunProperties();
            Bold bold4 = new Bold();
            FontSize fontSize6 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript6 = new FontSizeComplexScript() { Val = "22" };

            runProperties6.Append(bold4);
            runProperties6.Append(fontSize6);
            runProperties6.Append(fontSizeComplexScript6);
            Text text6 = new Text();
            text6.Text = "Company information:";

            run6.Append(runProperties6);
            run6.Append(text6);

            paragraph5.Append(paragraphProperties3);
            paragraph5.Append(run6);

            Paragraph paragraph6 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "0477A132", TextId = "77777777" };

            ParagraphProperties paragraphProperties4 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines4 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation3 = new Indentation() { Left = "413", Hanging = "283" };

            paragraphProperties4.Append(spacingBetweenLines4);
            paragraphProperties4.Append(indentation3);

            //Run run7 = new Run();

            //RunProperties runProperties7 = new RunProperties();
            //RunFonts runFonts1 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            //FontSize fontSize7 = new FontSize() { Val = "14" };
            //FontSizeComplexScript fontSizeComplexScript7 = new FontSizeComplexScript() { Val = "14" };

            //runProperties7.Append(runFonts1);
            //runProperties7.Append(fontSize7);
            //runProperties7.Append(fontSizeComplexScript7);
            //Text text7 = new Text();
            //text7.Text = "l";

            //run7.Append(runProperties7);
            //run7.Append(text7);

            //Run run8 = new Run();

            //RunProperties runProperties8 = new RunProperties();
            //RunFonts runFonts2 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            //FontSize fontSize8 = new FontSize() { Val = "14" };
            //FontSizeComplexScript fontSizeComplexScript8 = new FontSizeComplexScript() { Val = "14" };

            //runProperties8.Append(runFonts2);
            //runProperties8.Append(fontSize8);
            //runProperties8.Append(fontSizeComplexScript8);
            //Text text8 = new Text();
            //text8.Text = " ";

            //run8.Append(runProperties8);
            //run8.Append(text8);

            Run run9 = new Run();

            RunProperties runProperties9 = new RunProperties();
            FontSize fontSize9 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript9 = new FontSizeComplexScript() { Val = "22" };

            runProperties9.Append(fontSize9);
            runProperties9.Append(fontSizeComplexScript9);
            Text text9 = new Text();
            text9.Text = "Industry: Natural Resources / Agriculture / Forestry / Oil & Gas";

            run9.Append(runProperties9);
            run9.Append(text9);

            NumberingProperties numberingProperties1 = new NumberingProperties();
            NumberingLevelReference numberingLevelReference1 = new NumberingLevelReference() { Val = 0 };
            NumberingId numberingId1 = new NumberingId() { Val = 1 };

            numberingProperties1.Append(numberingLevelReference1);
            numberingProperties1.Append(numberingId1);

            paragraph6.Append(numberingProperties1);

            paragraph6.Append(paragraphProperties4);
            //paragraph6.Append(run7);
            //paragraph6.Append(run8);
            paragraph6.Append(run9);

            Paragraph paragraph7 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "7C6FBD2C", TextId = "77777777" };

            ParagraphProperties paragraphProperties5 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines5 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation4 = new Indentation() { Left = "413", Hanging = "283" };

            paragraphProperties5.Append(spacingBetweenLines5);
            paragraphProperties5.Append(indentation4);

            Run run10 = new Run();

            RunProperties runProperties10 = new RunProperties();
            RunFonts runFonts3 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize10 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript10 = new FontSizeComplexScript() { Val = "14" };

            runProperties10.Append(runFonts3);
            runProperties10.Append(fontSize10);
            runProperties10.Append(fontSizeComplexScript10);
            Text text10 = new Text();
            text10.Text = "l";

            run10.Append(runProperties10);
            run10.Append(text10);

            Run run11 = new Run();

            RunProperties runProperties11 = new RunProperties();
            RunFonts runFonts4 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize11 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript11 = new FontSizeComplexScript() { Val = "14" };

            runProperties11.Append(runFonts4);
            runProperties11.Append(fontSize11);
            runProperties11.Append(fontSizeComplexScript11);
            Text text11 = new Text();
            text11.Text = " ";

            run11.Append(runProperties11);
            run11.Append(text11);

            Run run12 = new Run();

            RunProperties runProperties12 = new RunProperties();
            FontSize fontSize12 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript12 = new FontSizeComplexScript() { Val = "22" };

            runProperties12.Append(fontSize12);
            runProperties12.Append(fontSizeComplexScript12);
            Text text12 = new Text();
            text12.Text = "Services: Commodities export company";

            run12.Append(runProperties12);
            run12.Append(text12);

            paragraph7.Append(paragraphProperties5);
            paragraph7.Append(run10);
            paragraph7.Append(run11);
            paragraph7.Append(run12);

            Paragraph paragraph8 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "65B94229", TextId = "77777777" };

            ParagraphProperties paragraphProperties6 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines6 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation5 = new Indentation() { Left = "413", Hanging = "283" };

            paragraphProperties6.Append(spacingBetweenLines6);
            paragraphProperties6.Append(indentation5);

            Run run13 = new Run();

            RunProperties runProperties13 = new RunProperties();
            RunFonts runFonts5 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize13 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript13 = new FontSizeComplexScript() { Val = "14" };

            runProperties13.Append(runFonts5);
            runProperties13.Append(fontSize13);
            runProperties13.Append(fontSizeComplexScript13);
            Text text13 = new Text();
            text13.Text = "l";

            run13.Append(runProperties13);
            run13.Append(text13);

            Run run14 = new Run();

            RunProperties runProperties14 = new RunProperties();
            RunFonts runFonts6 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize14 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript14 = new FontSizeComplexScript() { Val = "14" };

            runProperties14.Append(runFonts6);
            runProperties14.Append(fontSize14);
            runProperties14.Append(fontSizeComplexScript14);
            Text text14 = new Text();
            text14.Text = " ";

            run14.Append(runProperties14);
            run14.Append(text14);

            Run run15 = new Run();

            RunProperties runProperties15 = new RunProperties();
            FontSize fontSize15 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript15 = new FontSizeComplexScript() { Val = "22" };

            runProperties15.Append(fontSize15);
            runProperties15.Append(fontSizeComplexScript15);
            Text text15 = new Text();
            text15.Text = "Turnover: Turnover 2018 (F) - EUR 2,2 M";

            run15.Append(runProperties15);
            run15.Append(text15);

            paragraph8.Append(paragraphProperties6);
            paragraph8.Append(run13);
            paragraph8.Append(run14);
            paragraph8.Append(run15);

            Paragraph paragraph9 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "0F2BFE6E", TextId = "77777777" };

            ParagraphProperties paragraphProperties7 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines7 = new SpacingBetweenLines() { After = "200" };
            Indentation indentation6 = new Indentation() { Left = "413", Hanging = "283" };

            paragraphProperties7.Append(spacingBetweenLines7);
            paragraphProperties7.Append(indentation6);

            Run run16 = new Run();

            RunProperties runProperties16 = new RunProperties();
            RunFonts runFonts7 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize16 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript16 = new FontSizeComplexScript() { Val = "14" };

            runProperties16.Append(runFonts7);
            runProperties16.Append(fontSize16);
            runProperties16.Append(fontSizeComplexScript16);
            Text text16 = new Text();
            text16.Text = "l";

            run16.Append(runProperties16);
            run16.Append(text16);

            Run run17 = new Run();

            RunProperties runProperties17 = new RunProperties();
            RunFonts runFonts8 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize17 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript17 = new FontSizeComplexScript() { Val = "14" };

            runProperties17.Append(runFonts8);
            runProperties17.Append(fontSize17);
            runProperties17.Append(fontSizeComplexScript17);
            Text text17 = new Text();
            text17.Text = " ";

            run17.Append(runProperties17);
            run17.Append(text17);

            Run run18 = new Run();

            RunProperties runProperties18 = new RunProperties();
            FontSize fontSize18 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript18 = new FontSizeComplexScript() { Val = "22" };

            runProperties18.Append(fontSize18);
            runProperties18.Append(fontSizeComplexScript18);
            Text text18 = new Text();
            text18.Text = "Number of employees: 2";

            run18.Append(runProperties18);
            run18.Append(text18);

            paragraph9.Append(paragraphProperties7);
            paragraph9.Append(run16);
            paragraph9.Append(run17);
            paragraph9.Append(run18);

            tableCell5.Append(tableCellProperties5);
            tableCell5.Append(paragraph5);
            tableCell5.Append(paragraph6);
            tableCell5.Append(paragraph7);
            tableCell5.Append(paragraph8);
            tableCell5.Append(paragraph9);

            tableRow3.Append(tableRowProperties2);
            tableRow3.Append(tableCell4);
            tableRow3.Append(tableCell5);

            TableRow tableRow4 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "418DF43A", TextId = "77777777" };

            TableRowProperties tableRowProperties3 = new TableRowProperties();
            GridAfter gridAfter3 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow3 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties3.Append(gridAfter3);
            tableRowProperties3.Append(widthAfterTableRow3);

            TableCell tableCell6 = new TableCell();

            TableCellProperties tableCellProperties6 = new TableCellProperties();
            TableCellWidth tableCellWidth6 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders6 = new TableCellBorders();
            TopBorder topBorder7 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder7 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder7 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder7 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders6.Append(topBorder7);
            tableCellBorders6.Append(leftBorder7);
            tableCellBorders6.Append(bottomBorder7);
            tableCellBorders6.Append(rightBorder7);

            tableCellProperties6.Append(tableCellWidth6);
            tableCellProperties6.Append(tableCellBorders6);
            Paragraph paragraph10 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "3329142D", TextId = "77777777" };

            tableCell6.Append(tableCellProperties6);
            tableCell6.Append(paragraph10);

            TableCell tableCell7 = new TableCell();

            TableCellProperties tableCellProperties7 = new TableCellProperties();
            TableCellWidth tableCellWidth7 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders7 = new TableCellBorders();
            TopBorder topBorder8 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder8 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder8 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder8 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders7.Append(topBorder8);
            tableCellBorders7.Append(leftBorder8);
            tableCellBorders7.Append(bottomBorder8);
            tableCellBorders7.Append(rightBorder8);

            tableCellProperties7.Append(tableCellWidth7);
            tableCellProperties7.Append(tableCellBorders7);

            Paragraph paragraph11 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "49F7C6AF", TextId = "77777777" };

            ParagraphProperties paragraphProperties8 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines8 = new SpacingBetweenLines() { After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation7 = new Indentation() { Left = "144" };

            paragraphProperties8.Append(spacingBetweenLines8);
            paragraphProperties8.Append(indentation7);

            Run run19 = new Run();

            RunProperties runProperties19 = new RunProperties();
            Bold bold5 = new Bold();
            FontSize fontSize19 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript19 = new FontSizeComplexScript() { Val = "21" };

            runProperties19.Append(bold5);
            runProperties19.Append(fontSize19);
            runProperties19.Append(fontSizeComplexScript19);
            Text text19 = new Text();
            text19.Text = "FINANCIAL ADVISER";

            run19.Append(runProperties19);
            run19.Append(text19);

            Run run20 = new Run();

            RunProperties runProperties20 = new RunProperties();
            FontSize fontSize20 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript20 = new FontSizeComplexScript() { Val = "21" };

            runProperties20.Append(fontSize20);
            runProperties20.Append(fontSizeComplexScript20);
            Text text20 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text20.Text = " (";

            run20.Append(runProperties20);
            run20.Append(text20);

            Run run21 = new Run();

            RunProperties runProperties21 = new RunProperties();
            Italic italic1 = new Italic();
            ItalicComplexScript italicComplexScript1 = new ItalicComplexScript();
            FontSize fontSize21 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript21 = new FontSizeComplexScript() { Val = "21" };

            runProperties21.Append(italic1);
            runProperties21.Append(italicComplexScript1);
            runProperties21.Append(fontSize21);
            runProperties21.Append(fontSizeComplexScript21);
            Text text21 = new Text();
            text21.Text = "2018 - present";

            run21.Append(runProperties21);
            run21.Append(text21);

            Run run22 = new Run();

            RunProperties runProperties22 = new RunProperties();
            FontSize fontSize22 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript22 = new FontSizeComplexScript() { Val = "21" };

            runProperties22.Append(fontSize22);
            runProperties22.Append(fontSizeComplexScript22);
            Text text22 = new Text();
            text22.Text = ")";

            run22.Append(runProperties22);
            run22.Append(text22);

            paragraph11.Append(paragraphProperties8);
            paragraph11.Append(run19);
            paragraph11.Append(run20);
            paragraph11.Append(run21);
            paragraph11.Append(run22);

            tableCell7.Append(tableCellProperties7);
            tableCell7.Append(paragraph11);

            tableRow4.Append(tableRowProperties3);
            tableRow4.Append(tableCell6);
            tableRow4.Append(tableCell7);

            TableRow tableRow5 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "7B3ACA60", TextId = "77777777" };

            TableRowProperties tableRowProperties4 = new TableRowProperties();
            GridAfter gridAfter4 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow4 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties4.Append(gridAfter4);
            tableRowProperties4.Append(widthAfterTableRow4);

            TableCell tableCell8 = new TableCell();

            TableCellProperties tableCellProperties8 = new TableCellProperties();
            TableCellWidth tableCellWidth8 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders8 = new TableCellBorders();
            TopBorder topBorder9 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder9 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder9 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder9 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders8.Append(topBorder9);
            tableCellBorders8.Append(leftBorder9);
            tableCellBorders8.Append(bottomBorder9);
            tableCellBorders8.Append(rightBorder9);

            tableCellProperties8.Append(tableCellWidth8);
            tableCellProperties8.Append(tableCellBorders8);
            Paragraph paragraph12 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "7DDF27F0", TextId = "77777777" };

            tableCell8.Append(tableCellProperties8);
            tableCell8.Append(paragraph12);

            TableCell tableCell9 = new TableCell();

            TableCellProperties tableCellProperties9 = new TableCellProperties();
            TableCellWidth tableCellWidth9 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders9 = new TableCellBorders();
            TopBorder topBorder10 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder10 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder10 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder10 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders9.Append(topBorder10);
            tableCellBorders9.Append(leftBorder10);
            tableCellBorders9.Append(bottomBorder10);
            tableCellBorders9.Append(rightBorder10);

            tableCellProperties9.Append(tableCellWidth9);
            tableCellProperties9.Append(tableCellBorders9);

            Paragraph paragraph13 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "750C1E57", TextId = "77777777" };

            ParagraphProperties paragraphProperties9 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines9 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation8 = new Indentation() { Left = "144" };

            paragraphProperties9.Append(spacingBetweenLines9);
            paragraphProperties9.Append(indentation8);

            Run run23 = new Run();

            RunProperties runProperties23 = new RunProperties();
            Bold bold6 = new Bold();
            FontSize fontSize23 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript23 = new FontSizeComplexScript() { Val = "22" };

            runProperties23.Append(bold6);
            runProperties23.Append(fontSize23);
            runProperties23.Append(fontSizeComplexScript23);
            Text text23 = new Text();
            text23.Text = "Task information:";

            run23.Append(runProperties23);
            run23.Append(text23);

            paragraph13.Append(paragraphProperties9);
            paragraph13.Append(run23);

            Paragraph paragraph14 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "6CF4EF0E", TextId = "77777777" };

            ParagraphProperties paragraphProperties10 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines10 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation9 = new Indentation() { Left = "144" };

            paragraphProperties10.Append(spacingBetweenLines10);
            paragraphProperties10.Append(indentation9);

            Run run24 = new Run();

            RunProperties runProperties24 = new RunProperties();
            RunFonts runFonts9 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize24 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript24 = new FontSizeComplexScript() { Val = "14" };

            runProperties24.Append(runFonts9);
            runProperties24.Append(fontSize24);
            runProperties24.Append(fontSizeComplexScript24);
            Text text24 = new Text();
            text24.Text = "l";

            run24.Append(runProperties24);
            run24.Append(text24);

            Run run25 = new Run();

            RunProperties runProperties25 = new RunProperties();
            RunFonts runFonts10 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize25 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript25 = new FontSizeComplexScript() { Val = "14" };

            runProperties25.Append(runFonts10);
            runProperties25.Append(fontSize25);
            runProperties25.Append(fontSizeComplexScript25);
            Text text25 = new Text();
            text25.Text = " ";

            run25.Append(runProperties25);
            run25.Append(text25);

            Run run26 = new Run();

            RunProperties runProperties26 = new RunProperties();
            FontSize fontSize26 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript26 = new FontSizeComplexScript() { Val = "22" };

            runProperties26.Append(fontSize26);
            runProperties26.Append(fontSizeComplexScript26);
            Text text26 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text26.Text = " Advisor on natural resource acquisition deals;";

            run26.Append(runProperties26);
            run26.Append(text26);

            paragraph14.Append(paragraphProperties10);
            paragraph14.Append(run24);
            paragraph14.Append(run25);
            paragraph14.Append(run26);

            Paragraph paragraph15 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "0B83EB3E", TextId = "77777777" };

            ParagraphProperties paragraphProperties11 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines11 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation10 = new Indentation() { Left = "144" };

            paragraphProperties11.Append(spacingBetweenLines11);
            paragraphProperties11.Append(indentation10);

            Run run27 = new Run();

            RunProperties runProperties27 = new RunProperties();
            RunFonts runFonts11 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize27 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript27 = new FontSizeComplexScript() { Val = "14" };

            runProperties27.Append(runFonts11);
            runProperties27.Append(fontSize27);
            runProperties27.Append(fontSizeComplexScript27);
            Text text27 = new Text();
            text27.Text = "l";

            run27.Append(runProperties27);
            run27.Append(text27);

            Run run28 = new Run();

            RunProperties runProperties28 = new RunProperties();
            RunFonts runFonts12 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize28 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript28 = new FontSizeComplexScript() { Val = "14" };

            runProperties28.Append(runFonts12);
            runProperties28.Append(fontSize28);
            runProperties28.Append(fontSizeComplexScript28);
            Text text28 = new Text();
            text28.Text = " ";

            run28.Append(runProperties28);
            run28.Append(text28);

            Run run29 = new Run();

            RunProperties runProperties29 = new RunProperties();
            FontSize fontSize29 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript29 = new FontSizeComplexScript() { Val = "22" };

            runProperties29.Append(fontSize29);
            runProperties29.Append(fontSizeComplexScript29);
            Text text29 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text29.Text = " Consulting on global commodity trends;";

            run29.Append(runProperties29);
            run29.Append(text29);

            paragraph15.Append(paragraphProperties11);
            paragraph15.Append(run27);
            paragraph15.Append(run28);
            paragraph15.Append(run29);

            Paragraph paragraph16 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "5EE46670", TextId = "77777777" };

            ParagraphProperties paragraphProperties12 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines12 = new SpacingBetweenLines() { After = "200" };
            Indentation indentation11 = new Indentation() { Left = "144" };

            paragraphProperties12.Append(spacingBetweenLines12);
            paragraphProperties12.Append(indentation11);

            Run run30 = new Run();

            RunProperties runProperties30 = new RunProperties();
            RunFonts runFonts13 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize30 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript30 = new FontSizeComplexScript() { Val = "14" };

            runProperties30.Append(runFonts13);
            runProperties30.Append(fontSize30);
            runProperties30.Append(fontSizeComplexScript30);
            Text text30 = new Text();
            text30.Text = "l";

            run30.Append(runProperties30);
            run30.Append(text30);

            Run run31 = new Run();

            RunProperties runProperties31 = new RunProperties();
            RunFonts runFonts14 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize31 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript31 = new FontSizeComplexScript() { Val = "14" };

            runProperties31.Append(runFonts14);
            runProperties31.Append(fontSize31);
            runProperties31.Append(fontSizeComplexScript31);
            Text text31 = new Text();
            text31.Text = " ";

            run31.Append(runProperties31);
            run31.Append(text31);

            Run run32 = new Run();

            RunProperties runProperties32 = new RunProperties();
            FontSize fontSize32 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript32 = new FontSizeComplexScript() { Val = "22" };

            runProperties32.Append(fontSize32);
            runProperties32.Append(fontSizeComplexScript32);
            Text text32 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text32.Text = " Forging relationships with foreign business partners.";

            run32.Append(runProperties32);
            run32.Append(text32);

            paragraph16.Append(paragraphProperties12);
            paragraph16.Append(run30);
            paragraph16.Append(run31);
            paragraph16.Append(run32);

            tableCell9.Append(tableCellProperties9);
            tableCell9.Append(paragraph13);
            tableCell9.Append(paragraph14);
            tableCell9.Append(paragraph15);
            tableCell9.Append(paragraph16);

            tableRow5.Append(tableRowProperties4);
            tableRow5.Append(tableCell8);
            tableRow5.Append(tableCell9);

            TableRow tableRow6 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "5D5C1C0F", TextId = "77777777" };

            TableRowProperties tableRowProperties5 = new TableRowProperties();
            GridAfter gridAfter5 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow5 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties5.Append(gridAfter5);
            tableRowProperties5.Append(widthAfterTableRow5);

            TableCell tableCell10 = new TableCell();

            TableCellProperties tableCellProperties10 = new TableCellProperties();
            TableCellWidth tableCellWidth10 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders10 = new TableCellBorders();
            TopBorder topBorder11 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder11 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder11 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder11 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders10.Append(topBorder11);
            tableCellBorders10.Append(leftBorder11);
            tableCellBorders10.Append(bottomBorder11);
            tableCellBorders10.Append(rightBorder11);

            tableCellProperties10.Append(tableCellWidth10);
            tableCellProperties10.Append(tableCellBorders10);
            Paragraph paragraph17 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "1972B01A", TextId = "77777777" };

            tableCell10.Append(tableCellProperties10);
            tableCell10.Append(paragraph17);

            TableCell tableCell11 = new TableCell();

            TableCellProperties tableCellProperties11 = new TableCellProperties();
            TableCellWidth tableCellWidth11 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders11 = new TableCellBorders();
            TopBorder topBorder12 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder12 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder12 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder12 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders11.Append(topBorder12);
            tableCellBorders11.Append(leftBorder12);
            tableCellBorders11.Append(bottomBorder12);
            tableCellBorders11.Append(rightBorder12);

            tableCellProperties11.Append(tableCellWidth11);
            tableCellProperties11.Append(tableCellBorders11);

            Paragraph paragraph18 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "5FDA8639", TextId = "2ABBA17A" };

            ParagraphProperties paragraphProperties13 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines13 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation12 = new Indentation() { Left = "144" };

            paragraphProperties13.Append(spacingBetweenLines13);
            paragraphProperties13.Append(indentation12);

            Run run33 = new Run();

            RunProperties runProperties33 = new RunProperties();
            Bold bold7 = new Bold();
            FontSize fontSize33 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript33 = new FontSizeComplexScript() { Val = "22" };

            runProperties33.Append(bold7);
            runProperties33.Append(fontSize33);
            runProperties33.Append(fontSizeComplexScript33);
            Text text33 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text33.Text = "Reporting to: ";

            run33.Append(runProperties33);
            run33.Append(text33);

            Run run34 = new Run();

            RunProperties runProperties34 = new RunProperties();
            FontSize fontSize34 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript34 = new FontSizeComplexScript() { Val = "22" };

            runProperties34.Append(fontSize34);
            runProperties34.Append(fontSizeComplexScript34);
            Text text34 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text34.Text = "Mr. ";

            run34.Append(runProperties34);
            run34.Append(text34);

            paragraph18.Append(paragraphProperties13);
            paragraph18.Append(run33);
            paragraph18.Append(run34);

            tableCell11.Append(tableCellProperties11);
            tableCell11.Append(paragraph18);

            tableRow6.Append(tableRowProperties5);
            tableRow6.Append(tableCell10);
            tableRow6.Append(tableCell11);

            TableRow tableRow7 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "13B6C217", TextId = "77777777" };

            TableRowProperties tableRowProperties6 = new TableRowProperties();
            GridAfter gridAfter6 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow6 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties6.Append(gridAfter6);
            tableRowProperties6.Append(widthAfterTableRow6);

            TableCell tableCell12 = new TableCell();

            TableCellProperties tableCellProperties12 = new TableCellProperties();
            TableCellWidth tableCellWidth12 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders12 = new TableCellBorders();
            TopBorder topBorder13 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder13 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder13 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder13 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders12.Append(topBorder13);
            tableCellBorders12.Append(leftBorder13);
            tableCellBorders12.Append(bottomBorder13);
            tableCellBorders12.Append(rightBorder13);

            tableCellProperties12.Append(tableCellWidth12);
            tableCellProperties12.Append(tableCellBorders12);
            Paragraph paragraph19 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "31AD661C", TextId = "77777777" };

            tableCell12.Append(tableCellProperties12);
            tableCell12.Append(paragraph19);

            TableCell tableCell13 = new TableCell();

            TableCellProperties tableCellProperties13 = new TableCellProperties();
            TableCellWidth tableCellWidth13 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders13 = new TableCellBorders();
            TopBorder topBorder14 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder14 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder14 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder14 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders13.Append(topBorder14);
            tableCellBorders13.Append(leftBorder14);
            tableCellBorders13.Append(bottomBorder14);
            tableCellBorders13.Append(rightBorder14);

            tableCellProperties13.Append(tableCellWidth13);
            tableCellProperties13.Append(tableCellBorders13);
            Paragraph paragraph20 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "643300E8", TextId = "77777777" };

            tableCell13.Append(tableCellProperties13);
            tableCell13.Append(paragraph20);

            tableRow7.Append(tableRowProperties6);
            tableRow7.Append(tableCell12);
            tableRow7.Append(tableCell13);

            TableRow tableRow8 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "5AE9EB88", TextId = "77777777" };

            TableRowProperties tableRowProperties7 = new TableRowProperties();
            GridAfter gridAfter7 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow7 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties7.Append(gridAfter7);
            tableRowProperties7.Append(widthAfterTableRow7);

            TableCell tableCell14 = new TableCell();

            TableCellProperties tableCellProperties14 = new TableCellProperties();
            TableCellWidth tableCellWidth14 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders14 = new TableCellBorders();
            TopBorder topBorder15 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder15 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder15 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder15 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders14.Append(topBorder15);
            tableCellBorders14.Append(leftBorder15);
            tableCellBorders14.Append(bottomBorder15);
            tableCellBorders14.Append(rightBorder15);

            tableCellProperties14.Append(tableCellWidth14);
            tableCellProperties14.Append(tableCellBorders14);

            Paragraph paragraph21 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "65409EDB", TextId = "77777777" };

            ParagraphProperties paragraphProperties14 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines14 = new SpacingBetweenLines() { Before = "30", After = "10" };

            paragraphProperties14.Append(spacingBetweenLines14);

            Run run35 = new Run();

            RunProperties runProperties35 = new RunProperties();
            FontSize fontSize35 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript35 = new FontSizeComplexScript() { Val = "22" };

            runProperties35.Append(fontSize35);
            runProperties35.Append(fontSizeComplexScript35);
            Text text35 = new Text();
            text35.Text = "2017 - present";

            run35.Append(runProperties35);
            run35.Append(text35);

            paragraph21.Append(paragraphProperties14);
            paragraph21.Append(run35);

            tableCell14.Append(tableCellProperties14);
            tableCell14.Append(paragraph21);

            TableCell tableCell15 = new TableCell();

            TableCellProperties tableCellProperties15 = new TableCellProperties();
            TableCellWidth tableCellWidth15 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders15 = new TableCellBorders();
            TopBorder topBorder16 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder16 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder16 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder16 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders15.Append(topBorder16);
            tableCellBorders15.Append(leftBorder16);
            tableCellBorders15.Append(bottomBorder16);
            tableCellBorders15.Append(rightBorder16);
            Shading shading2 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "0069B4" };

            tableCellProperties15.Append(tableCellWidth15);
            tableCellProperties15.Append(tableCellBorders15);
            tableCellProperties15.Append(shading2);

            Paragraph paragraph22 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "7B1B21BB", TextId = "46439D93" };

            ParagraphProperties paragraphProperties15 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines15 = new SpacingBetweenLines() { Before = "30", After = "10", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation13 = new Indentation() { Left = "144" };

            paragraphProperties15.Append(spacingBetweenLines15);
            paragraphProperties15.Append(indentation13);

            Run run36 = new Run();

            RunProperties runProperties36 = new RunProperties();
            Bold bold8 = new Bold();
            Color color3 = new Color() { Val = "FFFFFF" };
            FontSize fontSize36 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript36 = new FontSizeComplexScript() { Val = "21" };

            runProperties36.Append(bold8);
            runProperties36.Append(color3);
            runProperties36.Append(fontSize36);
            runProperties36.Append(fontSizeComplexScript36);
            Text text36 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text36.Text = "SIA ";

            run36.Append(runProperties36);
            run36.Append(text36);

            Run run37 = new Run() { RsidRunAddition = "0007641E" };

            RunProperties runProperties37 = new RunProperties();
            Bold bold9 = new Bold();
            Color color4 = new Color() { Val = "FFFFFF" };
            FontSize fontSize37 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript37 = new FontSizeComplexScript() { Val = "21" };

            runProperties37.Append(bold9);
            runProperties37.Append(color4);
            runProperties37.Append(fontSize37);
            runProperties37.Append(fontSizeComplexScript37);
            Text text37 = new Text();
            text37.Text = "V";

            run37.Append(runProperties37);
            run37.Append(text37);

            paragraph22.Append(paragraphProperties15);
            paragraph22.Append(run36);
            paragraph22.Append(run37);

            tableCell15.Append(tableCellProperties15);
            tableCell15.Append(paragraph22);

            tableRow8.Append(tableRowProperties7);
            tableRow8.Append(tableCell14);
            tableRow8.Append(tableCell15);

            TableRow tableRow9 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "41E05602", TextId = "77777777" };

            TableRowProperties tableRowProperties8 = new TableRowProperties();
            GridAfter gridAfter8 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow8 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties8.Append(gridAfter8);
            tableRowProperties8.Append(widthAfterTableRow8);

            TableCell tableCell16 = new TableCell();

            TableCellProperties tableCellProperties16 = new TableCellProperties();
            TableCellWidth tableCellWidth16 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders16 = new TableCellBorders();
            TopBorder topBorder17 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder17 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder17 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder17 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders16.Append(topBorder17);
            tableCellBorders16.Append(leftBorder17);
            tableCellBorders16.Append(bottomBorder17);
            tableCellBorders16.Append(rightBorder17);

            tableCellProperties16.Append(tableCellWidth16);
            tableCellProperties16.Append(tableCellBorders16);
            Paragraph paragraph23 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "5AFDB01F", TextId = "77777777" };

            tableCell16.Append(tableCellProperties16);
            tableCell16.Append(paragraph23);

            TableCell tableCell17 = new TableCell();

            TableCellProperties tableCellProperties17 = new TableCellProperties();
            TableCellWidth tableCellWidth17 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders17 = new TableCellBorders();
            TopBorder topBorder18 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder18 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder18 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder18 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders17.Append(topBorder18);
            tableCellBorders17.Append(leftBorder18);
            tableCellBorders17.Append(bottomBorder18);
            tableCellBorders17.Append(rightBorder18);

            tableCellProperties17.Append(tableCellWidth17);
            tableCellProperties17.Append(tableCellBorders17);

            Paragraph paragraph24 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "515A8ECB", TextId = "77777777" };

            ParagraphProperties paragraphProperties16 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines16 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation14 = new Indentation() { Left = "144" };

            paragraphProperties16.Append(spacingBetweenLines16);
            paragraphProperties16.Append(indentation14);

            Run run38 = new Run();

            RunProperties runProperties38 = new RunProperties();
            Bold bold10 = new Bold();
            FontSize fontSize38 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript38 = new FontSizeComplexScript() { Val = "22" };

            runProperties38.Append(bold10);
            runProperties38.Append(fontSize38);
            runProperties38.Append(fontSizeComplexScript38);
            Text text38 = new Text();
            text38.Text = "Company information:";

            run38.Append(runProperties38);
            run38.Append(text38);

            paragraph24.Append(paragraphProperties16);
            paragraph24.Append(run38);

            Paragraph paragraph25 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "1A24F36A", TextId = "77777777" };

            ParagraphProperties paragraphProperties17 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines17 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation15 = new Indentation() { Left = "144" };

            paragraphProperties17.Append(spacingBetweenLines17);
            paragraphProperties17.Append(indentation15);

            Run run39 = new Run();

            RunProperties runProperties39 = new RunProperties();
            RunFonts runFonts15 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize39 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript39 = new FontSizeComplexScript() { Val = "14" };

            runProperties39.Append(runFonts15);
            runProperties39.Append(fontSize39);
            runProperties39.Append(fontSizeComplexScript39);
            Text text39 = new Text();
            text39.Text = "l";

            run39.Append(runProperties39);
            run39.Append(text39);

            Run run40 = new Run();

            RunProperties runProperties40 = new RunProperties();
            RunFonts runFonts16 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize40 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript40 = new FontSizeComplexScript() { Val = "14" };

            runProperties40.Append(runFonts16);
            runProperties40.Append(fontSize40);
            runProperties40.Append(fontSizeComplexScript40);
            Text text40 = new Text();
            text40.Text = " ";

            run40.Append(runProperties40);
            run40.Append(text40);

            Run run41 = new Run();

            RunProperties runProperties41 = new RunProperties();
            FontSize fontSize41 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript41 = new FontSizeComplexScript() { Val = "22" };

            runProperties41.Append(fontSize41);
            runProperties41.Append(fontSizeComplexScript41);
            Text text41 = new Text();
            text41.Text = "Industry: Financial Services / Insurance";

            run41.Append(runProperties41);
            run41.Append(text41);

            paragraph25.Append(paragraphProperties17);
            paragraph25.Append(run39);
            paragraph25.Append(run40);
            paragraph25.Append(run41);

            Paragraph paragraph26 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "169AF20B", TextId = "77777777" };

            ParagraphProperties paragraphProperties18 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines18 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation16 = new Indentation() { Left = "144" };

            paragraphProperties18.Append(spacingBetweenLines18);
            paragraphProperties18.Append(indentation16);

            Run run42 = new Run();

            RunProperties runProperties42 = new RunProperties();
            RunFonts runFonts17 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize42 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript42 = new FontSizeComplexScript() { Val = "14" };

            runProperties42.Append(runFonts17);
            runProperties42.Append(fontSize42);
            runProperties42.Append(fontSizeComplexScript42);
            Text text42 = new Text();
            text42.Text = "l";

            run42.Append(runProperties42);
            run42.Append(text42);

            Run run43 = new Run();

            RunProperties runProperties43 = new RunProperties();
            RunFonts runFonts18 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize43 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript43 = new FontSizeComplexScript() { Val = "14" };

            runProperties43.Append(runFonts18);
            runProperties43.Append(fontSize43);
            runProperties43.Append(fontSizeComplexScript43);
            Text text43 = new Text();
            text43.Text = " ";

            run43.Append(runProperties43);
            run43.Append(text43);

            Run run44 = new Run();

            RunProperties runProperties44 = new RunProperties();
            FontSize fontSize44 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript44 = new FontSizeComplexScript() { Val = "22" };

            runProperties44.Append(fontSize44);
            runProperties44.Append(fontSizeComplexScript44);
            Text text44 = new Text();
            text44.Text = "Services: Investment management and advisory";

            run44.Append(runProperties44);
            run44.Append(text44);

            paragraph26.Append(paragraphProperties18);
            paragraph26.Append(run42);
            paragraph26.Append(run43);
            paragraph26.Append(run44);

            Paragraph paragraph27 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "51443CE1", TextId = "77777777" };

            ParagraphProperties paragraphProperties19 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines19 = new SpacingBetweenLines() { After = "200" };
            Indentation indentation17 = new Indentation() { Left = "144" };

            paragraphProperties19.Append(spacingBetweenLines19);
            paragraphProperties19.Append(indentation17);

            Run run45 = new Run();

            RunProperties runProperties45 = new RunProperties();
            RunFonts runFonts19 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize45 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript45 = new FontSizeComplexScript() { Val = "14" };

            runProperties45.Append(runFonts19);
            runProperties45.Append(fontSize45);
            runProperties45.Append(fontSizeComplexScript45);
            Text text45 = new Text();
            text45.Text = "l";

            run45.Append(runProperties45);
            run45.Append(text45);

            Run run46 = new Run();

            RunProperties runProperties46 = new RunProperties();
            RunFonts runFonts20 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize46 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript46 = new FontSizeComplexScript() { Val = "14" };

            runProperties46.Append(runFonts20);
            runProperties46.Append(fontSize46);
            runProperties46.Append(fontSizeComplexScript46);
            Text text46 = new Text();
            text46.Text = " ";

            run46.Append(runProperties46);
            run46.Append(text46);

            Run run47 = new Run();

            RunProperties runProperties47 = new RunProperties();
            FontSize fontSize47 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript47 = new FontSizeComplexScript() { Val = "22" };

            runProperties47.Append(fontSize47);
            runProperties47.Append(fontSizeComplexScript47);
            Text text47 = new Text();
            text47.Text = "Number of employees: 1";

            run47.Append(runProperties47);
            run47.Append(text47);

            paragraph27.Append(paragraphProperties19);
            paragraph27.Append(run45);
            paragraph27.Append(run46);
            paragraph27.Append(run47);

            tableCell17.Append(tableCellProperties17);
            tableCell17.Append(paragraph24);
            tableCell17.Append(paragraph25);
            tableCell17.Append(paragraph26);
            tableCell17.Append(paragraph27);

            tableRow9.Append(tableRowProperties8);
            tableRow9.Append(tableCell16);
            tableRow9.Append(tableCell17);

            TableRow tableRow10 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "2C8B0B03", TextId = "77777777" };

            TableRowProperties tableRowProperties9 = new TableRowProperties();
            GridAfter gridAfter9 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow9 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties9.Append(gridAfter9);
            tableRowProperties9.Append(widthAfterTableRow9);

            TableCell tableCell18 = new TableCell();

            TableCellProperties tableCellProperties18 = new TableCellProperties();
            TableCellWidth tableCellWidth18 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders18 = new TableCellBorders();
            TopBorder topBorder19 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder19 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder19 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder19 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders18.Append(topBorder19);
            tableCellBorders18.Append(leftBorder19);
            tableCellBorders18.Append(bottomBorder19);
            tableCellBorders18.Append(rightBorder19);

            tableCellProperties18.Append(tableCellWidth18);
            tableCellProperties18.Append(tableCellBorders18);
            Paragraph paragraph28 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "56507580", TextId = "77777777" };

            tableCell18.Append(tableCellProperties18);
            tableCell18.Append(paragraph28);

            TableCell tableCell19 = new TableCell();

            TableCellProperties tableCellProperties19 = new TableCellProperties();
            TableCellWidth tableCellWidth19 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders19 = new TableCellBorders();
            TopBorder topBorder20 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder20 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder20 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder20 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders19.Append(topBorder20);
            tableCellBorders19.Append(leftBorder20);
            tableCellBorders19.Append(bottomBorder20);
            tableCellBorders19.Append(rightBorder20);

            tableCellProperties19.Append(tableCellWidth19);
            tableCellProperties19.Append(tableCellBorders19);

            Paragraph paragraph29 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "67B8831E", TextId = "77777777" };

            ParagraphProperties paragraphProperties20 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines20 = new SpacingBetweenLines() { After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation18 = new Indentation() { Left = "144" };

            paragraphProperties20.Append(spacingBetweenLines20);
            paragraphProperties20.Append(indentation18);

            Run run48 = new Run();

            RunProperties runProperties48 = new RunProperties();
            Bold bold11 = new Bold();
            FontSize fontSize48 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript48 = new FontSizeComplexScript() { Val = "21" };

            runProperties48.Append(bold11);
            runProperties48.Append(fontSize48);
            runProperties48.Append(fontSizeComplexScript48);
            Text text48 = new Text();
            text48.Text = "INVESTMENT MANAGER";

            run48.Append(runProperties48);
            run48.Append(text48);

            Run run49 = new Run();

            RunProperties runProperties49 = new RunProperties();
            FontSize fontSize49 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript49 = new FontSizeComplexScript() { Val = "21" };

            runProperties49.Append(fontSize49);
            runProperties49.Append(fontSizeComplexScript49);
            Text text49 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text49.Text = " (";

            run49.Append(runProperties49);
            run49.Append(text49);

            Run run50 = new Run();

            RunProperties runProperties50 = new RunProperties();
            Italic italic2 = new Italic();
            ItalicComplexScript italicComplexScript2 = new ItalicComplexScript();
            FontSize fontSize50 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript50 = new FontSizeComplexScript() { Val = "21" };

            runProperties50.Append(italic2);
            runProperties50.Append(italicComplexScript2);
            runProperties50.Append(fontSize50);
            runProperties50.Append(fontSizeComplexScript50);
            Text text50 = new Text();
            text50.Text = "2017 - present";

            run50.Append(runProperties50);
            run50.Append(text50);

            Run run51 = new Run();

            RunProperties runProperties51 = new RunProperties();
            FontSize fontSize51 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript51 = new FontSizeComplexScript() { Val = "21" };

            runProperties51.Append(fontSize51);
            runProperties51.Append(fontSizeComplexScript51);
            Text text51 = new Text();
            text51.Text = ")";

            run51.Append(runProperties51);
            run51.Append(text51);

            paragraph29.Append(paragraphProperties20);
            paragraph29.Append(run48);
            paragraph29.Append(run49);
            paragraph29.Append(run50);
            paragraph29.Append(run51);

            tableCell19.Append(tableCellProperties19);
            tableCell19.Append(paragraph29);

            tableRow10.Append(tableRowProperties9);
            tableRow10.Append(tableCell18);
            tableRow10.Append(tableCell19);

            TableRow tableRow11 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "162C8A21", TextId = "77777777" };

            TableRowProperties tableRowProperties10 = new TableRowProperties();
            GridAfter gridAfter10 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow10 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties10.Append(gridAfter10);
            tableRowProperties10.Append(widthAfterTableRow10);

            TableCell tableCell20 = new TableCell();

            TableCellProperties tableCellProperties20 = new TableCellProperties();
            TableCellWidth tableCellWidth20 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders20 = new TableCellBorders();
            TopBorder topBorder21 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder21 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder21 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder21 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders20.Append(topBorder21);
            tableCellBorders20.Append(leftBorder21);
            tableCellBorders20.Append(bottomBorder21);
            tableCellBorders20.Append(rightBorder21);

            tableCellProperties20.Append(tableCellWidth20);
            tableCellProperties20.Append(tableCellBorders20);
            Paragraph paragraph30 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "6D324841", TextId = "77777777" };

            tableCell20.Append(tableCellProperties20);
            tableCell20.Append(paragraph30);

            TableCell tableCell21 = new TableCell();

            TableCellProperties tableCellProperties21 = new TableCellProperties();
            TableCellWidth tableCellWidth21 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders21 = new TableCellBorders();
            TopBorder topBorder22 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder22 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder22 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder22 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders21.Append(topBorder22);
            tableCellBorders21.Append(leftBorder22);
            tableCellBorders21.Append(bottomBorder22);
            tableCellBorders21.Append(rightBorder22);

            tableCellProperties21.Append(tableCellWidth21);
            tableCellProperties21.Append(tableCellBorders21);

            Paragraph paragraph31 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "3D0AE178", TextId = "77777777" };

            ParagraphProperties paragraphProperties21 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines21 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation19 = new Indentation() { Left = "144" };

            paragraphProperties21.Append(spacingBetweenLines21);
            paragraphProperties21.Append(indentation19);

            Run run52 = new Run();

            RunProperties runProperties52 = new RunProperties();
            Bold bold12 = new Bold();
            FontSize fontSize52 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript52 = new FontSizeComplexScript() { Val = "22" };

            runProperties52.Append(bold12);
            runProperties52.Append(fontSize52);
            runProperties52.Append(fontSizeComplexScript52);
            Text text52 = new Text();
            text52.Text = "Task information:";

            run52.Append(runProperties52);
            run52.Append(text52);

            paragraph31.Append(paragraphProperties21);
            paragraph31.Append(run52);

            Paragraph paragraph32 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "65789C2C", TextId = "77777777" };

            ParagraphProperties paragraphProperties22 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines22 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation20 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties22.Append(spacingBetweenLines22);
            paragraphProperties22.Append(indentation20);

            Run run53 = new Run();

            RunProperties runProperties53 = new RunProperties();
            RunFonts runFonts21 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize53 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript53 = new FontSizeComplexScript() { Val = "14" };

            runProperties53.Append(runFonts21);
            runProperties53.Append(fontSize53);
            runProperties53.Append(fontSizeComplexScript53);
            Text text53 = new Text();
            text53.Text = "l";

            run53.Append(runProperties53);
            run53.Append(text53);

            Run run54 = new Run();

            RunProperties runProperties54 = new RunProperties();
            RunFonts runFonts22 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize54 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript54 = new FontSizeComplexScript() { Val = "14" };

            runProperties54.Append(runFonts22);
            runProperties54.Append(fontSize54);
            runProperties54.Append(fontSizeComplexScript54);
            Text text54 = new Text();
            text54.Text = " ";

            run54.Append(runProperties54);
            run54.Append(text54);

            Run run55 = new Run();

            RunProperties runProperties55 = new RunProperties();
            FontSize fontSize55 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript55 = new FontSizeComplexScript() { Val = "22" };

            runProperties55.Append(fontSize55);
            runProperties55.Append(fontSizeComplexScript55);
            Text text55 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text55.Text = " Investment management and advisory (including public and direct real estate);";

            run55.Append(runProperties55);
            run55.Append(text55);

            paragraph32.Append(paragraphProperties22);
            paragraph32.Append(run53);
            paragraph32.Append(run54);
            paragraph32.Append(run55);

            Paragraph paragraph33 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "5F0C2D2F", TextId = "5D9DF506" };

            ParagraphProperties paragraphProperties23 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines23 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation21 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties23.Append(spacingBetweenLines23);
            paragraphProperties23.Append(indentation21);

            Run run56 = new Run();

            RunProperties runProperties56 = new RunProperties();
            RunFonts runFonts23 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize56 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript56 = new FontSizeComplexScript() { Val = "14" };

            runProperties56.Append(runFonts23);
            runProperties56.Append(fontSize56);
            runProperties56.Append(fontSizeComplexScript56);
            Text text56 = new Text();
            text56.Text = "l";

            run56.Append(runProperties56);
            run56.Append(text56);

            Run run57 = new Run();

            RunProperties runProperties57 = new RunProperties();
            RunFonts runFonts24 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize57 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript57 = new FontSizeComplexScript() { Val = "14" };

            runProperties57.Append(runFonts24);
            runProperties57.Append(fontSize57);
            runProperties57.Append(fontSizeComplexScript57);
            Text text57 = new Text();
            text57.Text = " ";

            run57.Append(runProperties57);
            run57.Append(text57);

            Run run58 = new Run();

            RunProperties runProperties58 = new RunProperties();
            FontSize fontSize58 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript58 = new FontSizeComplexScript() { Val = "22" };

            runProperties58.Append(fontSize58);
            runProperties58.Append(fontSizeComplexScript58);
            Text text58 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text58.Text = " ";

            run58.Append(runProperties58);
            run58.Append(text58);
            ProofError proofError1 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run59 = new Run();

            RunProperties runProperties59 = new RunProperties();
            FontSize fontSize59 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript59 = new FontSizeComplexScript() { Val = "22" };

            runProperties59.Append(fontSize59);
            runProperties59.Append(fontSizeComplexScript59);
            Text text59 = new Text();
            text59.Text = "Self owned";

            run59.Append(runProperties59);
            run59.Append(text59);
            ProofError proofError2 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run60 = new Run();

            RunProperties runProperties60 = new RunProperties();
            FontSize fontSize60 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript60 = new FontSizeComplexScript() { Val = "22" };

            runProperties60.Append(fontSize60);
            runProperties60.Append(fontSizeComplexScript60);
            Text text60 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text60.Text = " enterprise executing personal investment deals. Currently involved in 10 investment / finance projects. Approximate asset value at the end of 2018 EUR 1M; ";

            run60.Append(runProperties60);
            run60.Append(text60);

            paragraph33.Append(paragraphProperties23);
            paragraph33.Append(run56);
            paragraph33.Append(run57);
            paragraph33.Append(run58);
            paragraph33.Append(proofError1);
            paragraph33.Append(run59);
            paragraph33.Append(proofError2);
            paragraph33.Append(run60);

            Paragraph paragraph34 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "712E3ECF", TextId = "77777777" };

            ParagraphProperties paragraphProperties24 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines24 = new SpacingBetweenLines() { After = "200" };
            Indentation indentation22 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties24.Append(spacingBetweenLines24);
            paragraphProperties24.Append(indentation22);

            Run run61 = new Run();

            RunProperties runProperties61 = new RunProperties();
            RunFonts runFonts25 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize61 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript61 = new FontSizeComplexScript() { Val = "14" };

            runProperties61.Append(runFonts25);
            runProperties61.Append(fontSize61);
            runProperties61.Append(fontSizeComplexScript61);
            LastRenderedPageBreak lastRenderedPageBreak1 = new LastRenderedPageBreak();
            Text text61 = new Text();
            text61.Text = "l";

            run61.Append(runProperties61);
            run61.Append(lastRenderedPageBreak1);
            run61.Append(text61);

            Run run62 = new Run();

            RunProperties runProperties62 = new RunProperties();
            RunFonts runFonts26 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize62 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript62 = new FontSizeComplexScript() { Val = "14" };

            runProperties62.Append(runFonts26);
            runProperties62.Append(fontSize62);
            runProperties62.Append(fontSizeComplexScript62);
            Text text62 = new Text();
            text62.Text = " ";

            run62.Append(runProperties62);
            run62.Append(text62);

            Run run63 = new Run();

            RunProperties runProperties63 = new RunProperties();
            FontSize fontSize63 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript63 = new FontSizeComplexScript() { Val = "22" };

            runProperties63.Append(fontSize63);
            runProperties63.Append(fontSizeComplexScript63);
            Text text63 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text63.Text = " 2017: Servicing of EUR 300M sell side mandate from key participants in the Latvian pharmaceutical sector for a 100% exit to UK/Polish equity investment fund.";

            run63.Append(runProperties63);
            run63.Append(text63);

            paragraph34.Append(paragraphProperties24);
            paragraph34.Append(run61);
            paragraph34.Append(run62);
            paragraph34.Append(run63);

            tableCell21.Append(tableCellProperties21);
            tableCell21.Append(paragraph31);
            tableCell21.Append(paragraph32);
            tableCell21.Append(paragraph33);
            tableCell21.Append(paragraph34);

            tableRow11.Append(tableRowProperties10);
            tableRow11.Append(tableCell20);
            tableRow11.Append(tableCell21);

            TableRow tableRow12 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "7054ECF2", TextId = "77777777" };

            TableRowProperties tableRowProperties11 = new TableRowProperties();
            GridAfter gridAfter11 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow11 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties11.Append(gridAfter11);
            tableRowProperties11.Append(widthAfterTableRow11);

            TableCell tableCell22 = new TableCell();

            TableCellProperties tableCellProperties22 = new TableCellProperties();
            TableCellWidth tableCellWidth22 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders22 = new TableCellBorders();
            TopBorder topBorder23 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder23 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder23 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder23 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders22.Append(topBorder23);
            tableCellBorders22.Append(leftBorder23);
            tableCellBorders22.Append(bottomBorder23);
            tableCellBorders22.Append(rightBorder23);

            tableCellProperties22.Append(tableCellWidth22);
            tableCellProperties22.Append(tableCellBorders22);
            Paragraph paragraph35 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "45BBE270", TextId = "77777777" };

            tableCell22.Append(tableCellProperties22);
            tableCell22.Append(paragraph35);

            TableCell tableCell23 = new TableCell();

            TableCellProperties tableCellProperties23 = new TableCellProperties();
            TableCellWidth tableCellWidth23 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders23 = new TableCellBorders();
            TopBorder topBorder24 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder24 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder24 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder24 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders23.Append(topBorder24);
            tableCellBorders23.Append(leftBorder24);
            tableCellBorders23.Append(bottomBorder24);
            tableCellBorders23.Append(rightBorder24);

            tableCellProperties23.Append(tableCellWidth23);
            tableCellProperties23.Append(tableCellBorders23);

            Paragraph paragraph36 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "53EAC358", TextId = "439A4C5E" };

            ParagraphProperties paragraphProperties25 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines25 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation23 = new Indentation() { Left = "144" };

            paragraphProperties25.Append(spacingBetweenLines25);
            paragraphProperties25.Append(indentation23);

            Run run64 = new Run();

            RunProperties runProperties64 = new RunProperties();
            Bold bold13 = new Bold();
            FontSize fontSize64 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript64 = new FontSizeComplexScript() { Val = "22" };

            runProperties64.Append(bold13);
            runProperties64.Append(fontSize64);
            runProperties64.Append(fontSizeComplexScript64);
            Text text64 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text64.Text = "Reporting to: ";

            run64.Append(runProperties64);
            run64.Append(text64);
            ProofError proofError3 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run65 = new Run();

            RunProperties runProperties65 = new RunProperties();
            FontSize fontSize65 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript65 = new FontSizeComplexScript() { Val = "22" };

            runProperties65.Append(fontSize65);
            runProperties65.Append(fontSizeComplexScript65);
            Text text65 = new Text();
            text65.Text = "Mr";

            run65.Append(runProperties65);
            run65.Append(text65);
            ProofError proofError4 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            paragraph36.Append(paragraphProperties25);
            paragraph36.Append(run64);
            paragraph36.Append(proofError3);
            paragraph36.Append(run65);
            paragraph36.Append(proofError4);

            tableCell23.Append(tableCellProperties23);
            tableCell23.Append(paragraph36);

            tableRow12.Append(tableRowProperties11);
            tableRow12.Append(tableCell22);
            tableRow12.Append(tableCell23);

            TableRow tableRow13 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "6C5F187D", TextId = "77777777" };

            TableRowProperties tableRowProperties12 = new TableRowProperties();
            GridAfter gridAfter12 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow12 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties12.Append(gridAfter12);
            tableRowProperties12.Append(widthAfterTableRow12);

            TableCell tableCell24 = new TableCell();

            TableCellProperties tableCellProperties24 = new TableCellProperties();
            TableCellWidth tableCellWidth24 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders24 = new TableCellBorders();
            TopBorder topBorder25 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder25 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder25 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder25 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders24.Append(topBorder25);
            tableCellBorders24.Append(leftBorder25);
            tableCellBorders24.Append(bottomBorder25);
            tableCellBorders24.Append(rightBorder25);

            tableCellProperties24.Append(tableCellWidth24);
            tableCellProperties24.Append(tableCellBorders24);
            Paragraph paragraph37 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "0512E1ED", TextId = "77777777" };

            tableCell24.Append(tableCellProperties24);
            tableCell24.Append(paragraph37);

            TableCell tableCell25 = new TableCell();

            TableCellProperties tableCellProperties25 = new TableCellProperties();
            TableCellWidth tableCellWidth25 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders25 = new TableCellBorders();
            TopBorder topBorder26 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder26 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder26 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder26 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders25.Append(topBorder26);
            tableCellBorders25.Append(leftBorder26);
            tableCellBorders25.Append(bottomBorder26);
            tableCellBorders25.Append(rightBorder26);

            tableCellProperties25.Append(tableCellWidth25);
            tableCellProperties25.Append(tableCellBorders25);
            Paragraph paragraph38 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "4071E4B0", TextId = "77777777" };

            tableCell25.Append(tableCellProperties25);
            tableCell25.Append(paragraph38);

            tableRow13.Append(tableRowProperties12);
            tableRow13.Append(tableCell24);
            tableRow13.Append(tableCell25);

            TableRow tableRow14 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "3D74A55B", TextId = "77777777" };

            TableRowProperties tableRowProperties13 = new TableRowProperties();
            GridAfter gridAfter13 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow13 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties13.Append(gridAfter13);
            tableRowProperties13.Append(widthAfterTableRow13);

            TableCell tableCell26 = new TableCell();

            TableCellProperties tableCellProperties26 = new TableCellProperties();
            TableCellWidth tableCellWidth26 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders26 = new TableCellBorders();
            TopBorder topBorder27 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder27 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder27 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder27 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders26.Append(topBorder27);
            tableCellBorders26.Append(leftBorder27);
            tableCellBorders26.Append(bottomBorder27);
            tableCellBorders26.Append(rightBorder27);

            tableCellProperties26.Append(tableCellWidth26);
            tableCellProperties26.Append(tableCellBorders26);

            Paragraph paragraph39 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "173B6A79", TextId = "77777777" };

            ParagraphProperties paragraphProperties26 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines26 = new SpacingBetweenLines() { Before = "30", After = "10" };

            paragraphProperties26.Append(spacingBetweenLines26);

            Run run66 = new Run();

            RunProperties runProperties66 = new RunProperties();
            FontSize fontSize66 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript66 = new FontSizeComplexScript() { Val = "22" };

            runProperties66.Append(fontSize66);
            runProperties66.Append(fontSizeComplexScript66);
            Text text66 = new Text();
            text66.Text = "2012 - present";

            run66.Append(runProperties66);
            run66.Append(text66);

            paragraph39.Append(paragraphProperties26);
            paragraph39.Append(run66);

            tableCell26.Append(tableCellProperties26);
            tableCell26.Append(paragraph39);

            TableCell tableCell27 = new TableCell();

            TableCellProperties tableCellProperties27 = new TableCellProperties();
            TableCellWidth tableCellWidth27 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders27 = new TableCellBorders();
            TopBorder topBorder28 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder28 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder28 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder28 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders27.Append(topBorder28);
            tableCellBorders27.Append(leftBorder28);
            tableCellBorders27.Append(bottomBorder28);
            tableCellBorders27.Append(rightBorder28);
            Shading shading3 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "0069B4" };

            tableCellProperties27.Append(tableCellWidth27);
            tableCellProperties27.Append(tableCellBorders27);
            tableCellProperties27.Append(shading3);

            Paragraph paragraph40 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "5D706F8F", TextId = "5EFE88FC" };

            ParagraphProperties paragraphProperties27 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines27 = new SpacingBetweenLines() { Before = "30", After = "10", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation24 = new Indentation() { Left = "144" };

            paragraphProperties27.Append(spacingBetweenLines27);
            paragraphProperties27.Append(indentation24);

            Run run67 = new Run();

            RunProperties runProperties67 = new RunProperties();
            Bold bold14 = new Bold();
            Color color5 = new Color() { Val = "FFFFFF" };
            FontSize fontSize67 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript67 = new FontSizeComplexScript() { Val = "21" };

            runProperties67.Append(bold14);
            runProperties67.Append(color5);
            runProperties67.Append(fontSize67);
            runProperties67.Append(fontSizeComplexScript67);
            Text text67 = new Text();
            text67.Text = "SIA U";

            run67.Append(runProperties67);
            run67.Append(text67);

            paragraph40.Append(paragraphProperties27);
            paragraph40.Append(run67);

            tableCell27.Append(tableCellProperties27);
            tableCell27.Append(paragraph40);

            tableRow14.Append(tableRowProperties13);
            tableRow14.Append(tableCell26);
            tableRow14.Append(tableCell27);

            TableRow tableRow15 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "175A1BC1", TextId = "77777777" };

            TableRowProperties tableRowProperties14 = new TableRowProperties();
            GridAfter gridAfter14 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow14 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties14.Append(gridAfter14);
            tableRowProperties14.Append(widthAfterTableRow14);

            TableCell tableCell28 = new TableCell();

            TableCellProperties tableCellProperties28 = new TableCellProperties();
            TableCellWidth tableCellWidth28 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders28 = new TableCellBorders();
            TopBorder topBorder29 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder29 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder29 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder29 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders28.Append(topBorder29);
            tableCellBorders28.Append(leftBorder29);
            tableCellBorders28.Append(bottomBorder29);
            tableCellBorders28.Append(rightBorder29);

            tableCellProperties28.Append(tableCellWidth28);
            tableCellProperties28.Append(tableCellBorders28);
            Paragraph paragraph41 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "3EF856D2", TextId = "77777777" };

            tableCell28.Append(tableCellProperties28);
            tableCell28.Append(paragraph41);

            TableCell tableCell29 = new TableCell();

            TableCellProperties tableCellProperties29 = new TableCellProperties();
            TableCellWidth tableCellWidth29 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders29 = new TableCellBorders();
            TopBorder topBorder30 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder30 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder30 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder30 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders29.Append(topBorder30);
            tableCellBorders29.Append(leftBorder30);
            tableCellBorders29.Append(bottomBorder30);
            tableCellBorders29.Append(rightBorder30);

            tableCellProperties29.Append(tableCellWidth29);
            tableCellProperties29.Append(tableCellBorders29);

            Paragraph paragraph42 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "58278A0F", TextId = "77777777" };

            ParagraphProperties paragraphProperties28 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines28 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation25 = new Indentation() { Left = "144" };

            paragraphProperties28.Append(spacingBetweenLines28);
            paragraphProperties28.Append(indentation25);

            Run run68 = new Run();

            RunProperties runProperties68 = new RunProperties();
            Bold bold15 = new Bold();
            FontSize fontSize68 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript68 = new FontSizeComplexScript() { Val = "22" };

            runProperties68.Append(bold15);
            runProperties68.Append(fontSize68);
            runProperties68.Append(fontSizeComplexScript68);
            Text text68 = new Text();
            text68.Text = "Company information:";

            run68.Append(runProperties68);
            run68.Append(text68);

            paragraph42.Append(paragraphProperties28);
            paragraph42.Append(run68);

            Paragraph paragraph43 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "7FE83E22", TextId = "77777777" };

            ParagraphProperties paragraphProperties29 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines29 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation26 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties29.Append(spacingBetweenLines29);
            paragraphProperties29.Append(indentation26);

            Run run69 = new Run();

            RunProperties runProperties69 = new RunProperties();
            RunFonts runFonts27 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize69 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript69 = new FontSizeComplexScript() { Val = "14" };

            runProperties69.Append(runFonts27);
            runProperties69.Append(fontSize69);
            runProperties69.Append(fontSizeComplexScript69);
            Text text69 = new Text();
            text69.Text = "l";

            run69.Append(runProperties69);
            run69.Append(text69);

            Run run70 = new Run();

            RunProperties runProperties70 = new RunProperties();
            RunFonts runFonts28 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize70 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript70 = new FontSizeComplexScript() { Val = "14" };

            runProperties70.Append(runFonts28);
            runProperties70.Append(fontSize70);
            runProperties70.Append(fontSizeComplexScript70);
            Text text70 = new Text();
            text70.Text = " ";

            run70.Append(runProperties70);
            run70.Append(text70);

            Run run71 = new Run();

            RunProperties runProperties71 = new RunProperties();
            FontSize fontSize71 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript71 = new FontSizeComplexScript() { Val = "22" };

            runProperties71.Append(fontSize71);
            runProperties71.Append(fontSizeComplexScript71);
            Text text71 = new Text();
            text71.Text = "Industry: Natural Resources / Agriculture / Forestry / Oil & Gas";

            run71.Append(runProperties71);
            run71.Append(text71);

            paragraph43.Append(paragraphProperties29);
            paragraph43.Append(run69);
            paragraph43.Append(run70);
            paragraph43.Append(run71);

            Paragraph paragraph44 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "0BA492A5", TextId = "77777777" };

            ParagraphProperties paragraphProperties30 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines30 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation27 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties30.Append(spacingBetweenLines30);
            paragraphProperties30.Append(indentation27);

            Run run72 = new Run();

            RunProperties runProperties72 = new RunProperties();
            RunFonts runFonts29 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize72 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript72 = new FontSizeComplexScript() { Val = "14" };

            runProperties72.Append(runFonts29);
            runProperties72.Append(fontSize72);
            runProperties72.Append(fontSizeComplexScript72);
            Text text72 = new Text();
            text72.Text = "l";

            run72.Append(runProperties72);
            run72.Append(text72);

            Run run73 = new Run();

            RunProperties runProperties73 = new RunProperties();
            RunFonts runFonts30 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize73 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript73 = new FontSizeComplexScript() { Val = "14" };

            runProperties73.Append(runFonts30);
            runProperties73.Append(fontSize73);
            runProperties73.Append(fontSizeComplexScript73);
            Text text73 = new Text();
            text73.Text = " ";

            run73.Append(runProperties73);
            run73.Append(text73);

            Run run74 = new Run();

            RunProperties runProperties74 = new RunProperties();
            FontSize fontSize74 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript74 = new FontSizeComplexScript() { Val = "22" };

            runProperties74.Append(fontSize74);
            runProperties74.Append(fontSizeComplexScript74);
            Text text74 = new Text();
            text74.Text = "Services: Investment company";

            run74.Append(runProperties74);
            run74.Append(text74);

            paragraph44.Append(paragraphProperties30);
            paragraph44.Append(run72);
            paragraph44.Append(run73);
            paragraph44.Append(run74);

            Paragraph paragraph45 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "439A73D2", TextId = "77777777" };

            ParagraphProperties paragraphProperties31 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines31 = new SpacingBetweenLines() { After = "200" };
            Indentation indentation28 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties31.Append(spacingBetweenLines31);
            paragraphProperties31.Append(indentation28);

            Run run75 = new Run();

            RunProperties runProperties75 = new RunProperties();
            RunFonts runFonts31 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize75 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript75 = new FontSizeComplexScript() { Val = "14" };

            runProperties75.Append(runFonts31);
            runProperties75.Append(fontSize75);
            runProperties75.Append(fontSizeComplexScript75);
            Text text75 = new Text();
            text75.Text = "l";

            run75.Append(runProperties75);
            run75.Append(text75);

            Run run76 = new Run();

            RunProperties runProperties76 = new RunProperties();
            RunFonts runFonts32 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize76 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript76 = new FontSizeComplexScript() { Val = "14" };

            runProperties76.Append(runFonts32);
            runProperties76.Append(fontSize76);
            runProperties76.Append(fontSizeComplexScript76);
            Text text76 = new Text();
            text76.Text = " ";

            run76.Append(runProperties76);
            run76.Append(text76);

            Run run77 = new Run();

            RunProperties runProperties77 = new RunProperties();
            FontSize fontSize77 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript77 = new FontSizeComplexScript() { Val = "22" };

            runProperties77.Append(fontSize77);
            runProperties77.Append(fontSizeComplexScript77);
            Text text77 = new Text();
            text77.Text = "Number of employees: 2";

            run77.Append(runProperties77);
            run77.Append(text77);

            paragraph45.Append(paragraphProperties31);
            paragraph45.Append(run75);
            paragraph45.Append(run76);
            paragraph45.Append(run77);

            tableCell29.Append(tableCellProperties29);
            tableCell29.Append(paragraph42);
            tableCell29.Append(paragraph43);
            tableCell29.Append(paragraph44);
            tableCell29.Append(paragraph45);

            tableRow15.Append(tableRowProperties14);
            tableRow15.Append(tableCell28);
            tableRow15.Append(tableCell29);

            TableRow tableRow16 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "64337857", TextId = "77777777" };

            TableRowProperties tableRowProperties15 = new TableRowProperties();
            GridAfter gridAfter15 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow15 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties15.Append(gridAfter15);
            tableRowProperties15.Append(widthAfterTableRow15);

            TableCell tableCell30 = new TableCell();

            TableCellProperties tableCellProperties30 = new TableCellProperties();
            TableCellWidth tableCellWidth30 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders30 = new TableCellBorders();
            TopBorder topBorder31 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder31 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder31 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder31 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders30.Append(topBorder31);
            tableCellBorders30.Append(leftBorder31);
            tableCellBorders30.Append(bottomBorder31);
            tableCellBorders30.Append(rightBorder31);

            tableCellProperties30.Append(tableCellWidth30);
            tableCellProperties30.Append(tableCellBorders30);
            Paragraph paragraph46 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "76E77421", TextId = "77777777" };

            tableCell30.Append(tableCellProperties30);
            tableCell30.Append(paragraph46);

            TableCell tableCell31 = new TableCell();

            TableCellProperties tableCellProperties31 = new TableCellProperties();
            TableCellWidth tableCellWidth31 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders31 = new TableCellBorders();
            TopBorder topBorder32 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder32 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder32 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder32 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders31.Append(topBorder32);
            tableCellBorders31.Append(leftBorder32);
            tableCellBorders31.Append(bottomBorder32);
            tableCellBorders31.Append(rightBorder32);

            tableCellProperties31.Append(tableCellWidth31);
            tableCellProperties31.Append(tableCellBorders31);

            Paragraph paragraph47 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "285F1EF5", TextId = "77777777" };

            ParagraphProperties paragraphProperties32 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines32 = new SpacingBetweenLines() { After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation29 = new Indentation() { Left = "144" };

            paragraphProperties32.Append(spacingBetweenLines32);
            paragraphProperties32.Append(indentation29);

            Run run78 = new Run();

            RunProperties runProperties78 = new RunProperties();
            Bold bold16 = new Bold();
            FontSize fontSize78 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript78 = new FontSizeComplexScript() { Val = "21" };

            runProperties78.Append(bold16);
            runProperties78.Append(fontSize78);
            runProperties78.Append(fontSizeComplexScript78);
            Text text78 = new Text();
            text78.Text = "BOARD MEMBER";

            run78.Append(runProperties78);
            run78.Append(text78);

            Run run79 = new Run();

            RunProperties runProperties79 = new RunProperties();
            FontSize fontSize79 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript79 = new FontSizeComplexScript() { Val = "21" };

            runProperties79.Append(fontSize79);
            runProperties79.Append(fontSizeComplexScript79);
            Text text79 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text79.Text = " (";

            run79.Append(runProperties79);
            run79.Append(text79);

            Run run80 = new Run();

            RunProperties runProperties80 = new RunProperties();
            Italic italic3 = new Italic();
            ItalicComplexScript italicComplexScript3 = new ItalicComplexScript();
            FontSize fontSize80 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript80 = new FontSizeComplexScript() { Val = "21" };

            runProperties80.Append(italic3);
            runProperties80.Append(italicComplexScript3);
            runProperties80.Append(fontSize80);
            runProperties80.Append(fontSizeComplexScript80);
            Text text80 = new Text();
            text80.Text = "2012 - present";

            run80.Append(runProperties80);
            run80.Append(text80);

            Run run81 = new Run();

            RunProperties runProperties81 = new RunProperties();
            FontSize fontSize81 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript81 = new FontSizeComplexScript() { Val = "21" };

            runProperties81.Append(fontSize81);
            runProperties81.Append(fontSizeComplexScript81);
            Text text81 = new Text();
            text81.Text = ")";

            run81.Append(runProperties81);
            run81.Append(text81);

            paragraph47.Append(paragraphProperties32);
            paragraph47.Append(run78);
            paragraph47.Append(run79);
            paragraph47.Append(run80);
            paragraph47.Append(run81);

            tableCell31.Append(tableCellProperties31);
            tableCell31.Append(paragraph47);

            tableRow16.Append(tableRowProperties15);
            tableRow16.Append(tableCell30);
            tableRow16.Append(tableCell31);

            TableRow tableRow17 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "3314E091", TextId = "77777777" };

            TableRowProperties tableRowProperties16 = new TableRowProperties();
            GridAfter gridAfter16 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow16 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties16.Append(gridAfter16);
            tableRowProperties16.Append(widthAfterTableRow16);

            TableCell tableCell32 = new TableCell();

            TableCellProperties tableCellProperties32 = new TableCellProperties();
            TableCellWidth tableCellWidth32 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders32 = new TableCellBorders();
            TopBorder topBorder33 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder33 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder33 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder33 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders32.Append(topBorder33);
            tableCellBorders32.Append(leftBorder33);
            tableCellBorders32.Append(bottomBorder33);
            tableCellBorders32.Append(rightBorder33);

            tableCellProperties32.Append(tableCellWidth32);
            tableCellProperties32.Append(tableCellBorders32);
            Paragraph paragraph48 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "259C8B8E", TextId = "77777777" };

            tableCell32.Append(tableCellProperties32);
            tableCell32.Append(paragraph48);

            TableCell tableCell33 = new TableCell();

            TableCellProperties tableCellProperties33 = new TableCellProperties();
            TableCellWidth tableCellWidth33 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders33 = new TableCellBorders();
            TopBorder topBorder34 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder34 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder34 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder34 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders33.Append(topBorder34);
            tableCellBorders33.Append(leftBorder34);
            tableCellBorders33.Append(bottomBorder34);
            tableCellBorders33.Append(rightBorder34);

            tableCellProperties33.Append(tableCellWidth33);
            tableCellProperties33.Append(tableCellBorders33);

            Paragraph paragraph49 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "01A29A49", TextId = "77777777" };

            ParagraphProperties paragraphProperties33 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines33 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation30 = new Indentation() { Left = "144" };

            paragraphProperties33.Append(spacingBetweenLines33);
            paragraphProperties33.Append(indentation30);

            Run run82 = new Run();

            RunProperties runProperties82 = new RunProperties();
            Bold bold17 = new Bold();
            FontSize fontSize82 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript82 = new FontSizeComplexScript() { Val = "22" };

            runProperties82.Append(bold17);
            runProperties82.Append(fontSize82);
            runProperties82.Append(fontSizeComplexScript82);
            Text text82 = new Text();
            text82.Text = "Task information:";

            run82.Append(runProperties82);
            run82.Append(text82);

            paragraph49.Append(paragraphProperties33);
            paragraph49.Append(run82);

            Paragraph paragraph50 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "560591E0", TextId = "77777777" };

            ParagraphProperties paragraphProperties34 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines34 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation31 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties34.Append(spacingBetweenLines34);
            paragraphProperties34.Append(indentation31);

            Run run83 = new Run();

            RunProperties runProperties83 = new RunProperties();
            RunFonts runFonts33 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize83 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript83 = new FontSizeComplexScript() { Val = "14" };

            runProperties83.Append(runFonts33);
            runProperties83.Append(fontSize83);
            runProperties83.Append(fontSizeComplexScript83);
            Text text83 = new Text();
            text83.Text = "l";

            run83.Append(runProperties83);
            run83.Append(text83);

            Run run84 = new Run();

            RunProperties runProperties84 = new RunProperties();
            RunFonts runFonts34 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize84 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript84 = new FontSizeComplexScript() { Val = "14" };

            runProperties84.Append(runFonts34);
            runProperties84.Append(fontSize84);
            runProperties84.Append(fontSizeComplexScript84);
            Text text84 = new Text();
            text84.Text = " ";

            run84.Append(runProperties84);
            run84.Append(text84);

            Run run85 = new Run();

            RunProperties runProperties85 = new RunProperties();
            FontSize fontSize85 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript85 = new FontSizeComplexScript() { Val = "22" };

            runProperties85.Append(fontSize85);
            runProperties85.Append(fontSizeComplexScript85);
            Text text85 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text85.Text = " Investment management in Ukrainian agricultural sector. Company asset value of EUR 1.5M.";

            run85.Append(runProperties85);
            run85.Append(text85);

            paragraph50.Append(paragraphProperties34);
            paragraph50.Append(run83);
            paragraph50.Append(run84);
            paragraph50.Append(run85);

            Paragraph paragraph51 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "2EBA106D", TextId = "77777777" };

            ParagraphProperties paragraphProperties35 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines35 = new SpacingBetweenLines() { After = "200" };
            Indentation indentation32 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties35.Append(spacingBetweenLines35);
            paragraphProperties35.Append(indentation32);

            Run run86 = new Run();

            RunProperties runProperties86 = new RunProperties();
            RunFonts runFonts35 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize86 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript86 = new FontSizeComplexScript() { Val = "14" };

            runProperties86.Append(runFonts35);
            runProperties86.Append(fontSize86);
            runProperties86.Append(fontSizeComplexScript86);
            Text text86 = new Text();
            text86.Text = "l";

            run86.Append(runProperties86);
            run86.Append(text86);

            Run run87 = new Run();

            RunProperties runProperties87 = new RunProperties();
            RunFonts runFonts36 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize87 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript87 = new FontSizeComplexScript() { Val = "14" };

            runProperties87.Append(runFonts36);
            runProperties87.Append(fontSize87);
            runProperties87.Append(fontSizeComplexScript87);
            Text text87 = new Text();
            text87.Text = " ";

            run87.Append(runProperties87);
            run87.Append(text87);

            Run run88 = new Run();

            RunProperties runProperties88 = new RunProperties();
            FontSize fontSize88 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript88 = new FontSizeComplexScript() { Val = "22" };

            runProperties88.Append(fontSize88);
            runProperties88.Append(fontSizeComplexScript88);
            Text text88 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text88.Text = " Indirect shareholder, 33% (through Cyprus entities), of two Ukrainian ";

            run88.Append(runProperties88);
            run88.Append(text88);
            ProofError proofError5 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run89 = new Run();

            RunProperties runProperties89 = new RunProperties();
            FontSize fontSize89 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript89 = new FontSizeComplexScript() { Val = "22" };

            runProperties89.Append(fontSize89);
            runProperties89.Append(fontSizeComplexScript89);
            Text text89 = new Text();
            text89.Text = "agroholdings";

            run89.Append(runProperties89);
            run89.Append(text89);
            ProofError proofError6 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run90 = new Run();

            RunProperties runProperties90 = new RunProperties();
            FontSize fontSize90 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript90 = new FontSizeComplexScript() { Val = "22" };

            runProperties90.Append(fontSize90);
            runProperties90.Append(fontSizeComplexScript90);
            Text text90 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text90.Text = " ";

            run90.Append(runProperties90);
            run90.Append(text90);
            ProofError proofError7 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run91 = new Run();

            RunProperties runProperties91 = new RunProperties();
            FontSize fontSize91 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript91 = new FontSizeComplexScript() { Val = "22" };

            runProperties91.Append(fontSize91);
            runProperties91.Append(fontSizeComplexScript91);
            Text text91 = new Text();
            text91.Text = "BioAgro";

            run91.Append(runProperties91);
            run91.Append(text91);
            ProofError proofError8 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run92 = new Run();

            RunProperties runProperties92 = new RunProperties();
            FontSize fontSize92 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript92 = new FontSizeComplexScript() { Val = "22" };

            runProperties92.Append(fontSize92);
            runProperties92.Append(fontSizeComplexScript92);
            Text text92 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text92.Text = " and ";

            run92.Append(runProperties92);
            run92.Append(text92);
            ProofError proofError9 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run93 = new Run();

            RunProperties runProperties93 = new RunProperties();
            FontSize fontSize93 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript93 = new FontSizeComplexScript() { Val = "22" };

            runProperties93.Append(fontSize93);
            runProperties93.Append(fontSizeComplexScript93);
            Text text93 = new Text();
            text93.Text = "LatAgro";

            run93.Append(runProperties93);
            run93.Append(text93);
            ProofError proofError10 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run94 = new Run();

            RunProperties runProperties94 = new RunProperties();
            FontSize fontSize94 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript94 = new FontSizeComplexScript() { Val = "22" };

            runProperties94.Append(fontSize94);
            runProperties94.Append(fontSizeComplexScript94);
            Text text94 = new Text();
            text94.Text = ". At the end of 2018, expected consolidated asset value of both holdings companies is projected to be EUR 200M, consolidated sales value of EUR 100M. EBITD EUR 45M. Total number of daughter companies approx. 30.";

            run94.Append(runProperties94);
            run94.Append(text94);

            paragraph51.Append(paragraphProperties35);
            paragraph51.Append(run86);
            paragraph51.Append(run87);
            paragraph51.Append(run88);
            paragraph51.Append(proofError5);
            paragraph51.Append(run89);
            paragraph51.Append(proofError6);
            paragraph51.Append(run90);
            paragraph51.Append(proofError7);
            paragraph51.Append(run91);
            paragraph51.Append(proofError8);
            paragraph51.Append(run92);
            paragraph51.Append(proofError9);
            paragraph51.Append(run93);
            paragraph51.Append(proofError10);
            paragraph51.Append(run94);

            tableCell33.Append(tableCellProperties33);
            tableCell33.Append(paragraph49);
            tableCell33.Append(paragraph50);
            tableCell33.Append(paragraph51);

            tableRow17.Append(tableRowProperties16);
            tableRow17.Append(tableCell32);
            tableRow17.Append(tableCell33);

            TableRow tableRow18 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "37A4A540", TextId = "77777777" };

            TableRowProperties tableRowProperties17 = new TableRowProperties();
            GridAfter gridAfter17 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow17 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties17.Append(gridAfter17);
            tableRowProperties17.Append(widthAfterTableRow17);

            TableCell tableCell34 = new TableCell();

            TableCellProperties tableCellProperties34 = new TableCellProperties();
            TableCellWidth tableCellWidth34 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders34 = new TableCellBorders();
            TopBorder topBorder35 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder35 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder35 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder35 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders34.Append(topBorder35);
            tableCellBorders34.Append(leftBorder35);
            tableCellBorders34.Append(bottomBorder35);
            tableCellBorders34.Append(rightBorder35);

            tableCellProperties34.Append(tableCellWidth34);
            tableCellProperties34.Append(tableCellBorders34);
            Paragraph paragraph52 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "42F7F2A4", TextId = "77777777" };

            tableCell34.Append(tableCellProperties34);
            tableCell34.Append(paragraph52);

            TableCell tableCell35 = new TableCell();

            TableCellProperties tableCellProperties35 = new TableCellProperties();
            TableCellWidth tableCellWidth35 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders35 = new TableCellBorders();
            TopBorder topBorder36 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder36 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder36 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder36 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders35.Append(topBorder36);
            tableCellBorders35.Append(leftBorder36);
            tableCellBorders35.Append(bottomBorder36);
            tableCellBorders35.Append(rightBorder36);

            tableCellProperties35.Append(tableCellWidth35);
            tableCellProperties35.Append(tableCellBorders35);

            Paragraph paragraph53 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "3D2460DC", TextId = "65DA139F" };

            ParagraphProperties paragraphProperties36 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines36 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation33 = new Indentation() { Left = "144" };

            paragraphProperties36.Append(spacingBetweenLines36);
            paragraphProperties36.Append(indentation33);

            Run run95 = new Run();

            RunProperties runProperties95 = new RunProperties();
            Bold bold18 = new Bold();
            FontSize fontSize95 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript95 = new FontSizeComplexScript() { Val = "22" };

            runProperties95.Append(bold18);
            runProperties95.Append(fontSize95);
            runProperties95.Append(fontSizeComplexScript95);
            Text text95 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text95.Text = "Reporting to: ";

            run95.Append(runProperties95);
            run95.Append(text95);

            Run run96 = new Run();

            RunProperties runProperties96 = new RunProperties();
            FontSize fontSize96 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript96 = new FontSizeComplexScript() { Val = "22" };

            runProperties96.Append(fontSize96);
            runProperties96.Append(fontSizeComplexScript96);
            Text text96 = new Text();
            text96.Text = "Mr.";

            run96.Append(runProperties96);
            run96.Append(text96);

            paragraph53.Append(paragraphProperties36);
            paragraph53.Append(run95);
            paragraph53.Append(run96);

            tableCell35.Append(tableCellProperties35);
            tableCell35.Append(paragraph53);

            tableRow18.Append(tableRowProperties17);
            tableRow18.Append(tableCell34);
            tableRow18.Append(tableCell35);

            TableRow tableRow19 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "1835BA8D", TextId = "77777777" };

            TableRowProperties tableRowProperties18 = new TableRowProperties();
            GridAfter gridAfter18 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow18 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties18.Append(gridAfter18);
            tableRowProperties18.Append(widthAfterTableRow18);

            TableCell tableCell36 = new TableCell();

            TableCellProperties tableCellProperties36 = new TableCellProperties();
            TableCellWidth tableCellWidth36 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders36 = new TableCellBorders();
            TopBorder topBorder37 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder37 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder37 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder37 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders36.Append(topBorder37);
            tableCellBorders36.Append(leftBorder37);
            tableCellBorders36.Append(bottomBorder37);
            tableCellBorders36.Append(rightBorder37);

            tableCellProperties36.Append(tableCellWidth36);
            tableCellProperties36.Append(tableCellBorders36);
            Paragraph paragraph54 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "42644D1C", TextId = "77777777" };

            tableCell36.Append(tableCellProperties36);
            tableCell36.Append(paragraph54);

            TableCell tableCell37 = new TableCell();

            TableCellProperties tableCellProperties37 = new TableCellProperties();
            TableCellWidth tableCellWidth37 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders37 = new TableCellBorders();
            TopBorder topBorder38 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder38 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder38 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder38 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders37.Append(topBorder38);
            tableCellBorders37.Append(leftBorder38);
            tableCellBorders37.Append(bottomBorder38);
            tableCellBorders37.Append(rightBorder38);

            tableCellProperties37.Append(tableCellWidth37);
            tableCellProperties37.Append(tableCellBorders37);
            Paragraph paragraph55 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "1CEF023E", TextId = "77777777" };

            tableCell37.Append(tableCellProperties37);
            tableCell37.Append(paragraph55);

            tableRow19.Append(tableRowProperties18);
            tableRow19.Append(tableCell36);
            tableRow19.Append(tableCell37);

            TableRow tableRow20 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "5F1C7A7E", TextId = "77777777" };

            TableRowProperties tableRowProperties19 = new TableRowProperties();
            GridAfter gridAfter19 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow19 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties19.Append(gridAfter19);
            tableRowProperties19.Append(widthAfterTableRow19);

            TableCell tableCell38 = new TableCell();

            TableCellProperties tableCellProperties38 = new TableCellProperties();
            TableCellWidth tableCellWidth38 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders38 = new TableCellBorders();
            TopBorder topBorder39 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder39 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder39 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder39 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders38.Append(topBorder39);
            tableCellBorders38.Append(leftBorder39);
            tableCellBorders38.Append(bottomBorder39);
            tableCellBorders38.Append(rightBorder39);

            tableCellProperties38.Append(tableCellWidth38);
            tableCellProperties38.Append(tableCellBorders38);

            Paragraph paragraph56 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "60426546", TextId = "77777777" };

            ParagraphProperties paragraphProperties37 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines37 = new SpacingBetweenLines() { Before = "30", After = "10" };

            paragraphProperties37.Append(spacingBetweenLines37);

            Run run97 = new Run();

            RunProperties runProperties97 = new RunProperties();
            FontSize fontSize97 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript97 = new FontSizeComplexScript() { Val = "22" };

            runProperties97.Append(fontSize97);
            runProperties97.Append(fontSizeComplexScript97);
            Text text97 = new Text();
            text97.Text = "2013 - 2016";

            run97.Append(runProperties97);
            run97.Append(text97);

            paragraph56.Append(paragraphProperties37);
            paragraph56.Append(run97);

            tableCell38.Append(tableCellProperties38);
            tableCell38.Append(paragraph56);

            TableCell tableCell39 = new TableCell();

            TableCellProperties tableCellProperties39 = new TableCellProperties();
            TableCellWidth tableCellWidth39 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders39 = new TableCellBorders();
            TopBorder topBorder40 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder40 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder40 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder40 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders39.Append(topBorder40);
            tableCellBorders39.Append(leftBorder40);
            tableCellBorders39.Append(bottomBorder40);
            tableCellBorders39.Append(rightBorder40);
            Shading shading4 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "0069B4" };

            tableCellProperties39.Append(tableCellWidth39);
            tableCellProperties39.Append(tableCellBorders39);
            tableCellProperties39.Append(shading4);

            Paragraph paragraph57 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "0007641E", ParagraphId = "6E341527", TextId = "4F9FEC76" };

            ParagraphProperties paragraphProperties38 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines38 = new SpacingBetweenLines() { Before = "30", After = "10", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation34 = new Indentation() { Left = "144" };

            paragraphProperties38.Append(spacingBetweenLines38);
            paragraphProperties38.Append(indentation34);

            Run run98 = new Run();

            RunProperties runProperties98 = new RunProperties();
            Bold bold19 = new Bold();
            Color color6 = new Color() { Val = "FFFFFF" };
            FontSize fontSize98 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript98 = new FontSizeComplexScript() { Val = "21" };

            runProperties98.Append(bold19);
            runProperties98.Append(color6);
            runProperties98.Append(fontSize98);
            runProperties98.Append(fontSizeComplexScript98);
            Text text98 = new Text();
            text98.Text = "SIA F";

            run98.Append(runProperties98);
            run98.Append(text98);

            paragraph57.Append(paragraphProperties38);
            paragraph57.Append(run98);

            tableCell39.Append(tableCellProperties39);
            tableCell39.Append(paragraph57);

            tableRow20.Append(tableRowProperties19);
            tableRow20.Append(tableCell38);
            tableRow20.Append(tableCell39);

            TableRow tableRow21 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "2196DAA8", TextId = "77777777" };

            TableRowProperties tableRowProperties20 = new TableRowProperties();
            GridAfter gridAfter20 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow20 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties20.Append(gridAfter20);
            tableRowProperties20.Append(widthAfterTableRow20);

            TableCell tableCell40 = new TableCell();

            TableCellProperties tableCellProperties40 = new TableCellProperties();
            TableCellWidth tableCellWidth40 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders40 = new TableCellBorders();
            TopBorder topBorder41 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder41 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder41 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder41 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders40.Append(topBorder41);
            tableCellBorders40.Append(leftBorder41);
            tableCellBorders40.Append(bottomBorder41);
            tableCellBorders40.Append(rightBorder41);

            tableCellProperties40.Append(tableCellWidth40);
            tableCellProperties40.Append(tableCellBorders40);
            Paragraph paragraph58 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "62942164", TextId = "77777777" };

            tableCell40.Append(tableCellProperties40);
            tableCell40.Append(paragraph58);

            TableCell tableCell41 = new TableCell();

            TableCellProperties tableCellProperties41 = new TableCellProperties();
            TableCellWidth tableCellWidth41 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders41 = new TableCellBorders();
            TopBorder topBorder42 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder42 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder42 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder42 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders41.Append(topBorder42);
            tableCellBorders41.Append(leftBorder42);
            tableCellBorders41.Append(bottomBorder42);
            tableCellBorders41.Append(rightBorder42);

            tableCellProperties41.Append(tableCellWidth41);
            tableCellProperties41.Append(tableCellBorders41);

            Paragraph paragraph59 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "67D1EF90", TextId = "77777777" };

            ParagraphProperties paragraphProperties39 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines39 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation35 = new Indentation() { Left = "144" };

            paragraphProperties39.Append(spacingBetweenLines39);
            paragraphProperties39.Append(indentation35);

            Run run99 = new Run();

            RunProperties runProperties99 = new RunProperties();
            Bold bold20 = new Bold();
            FontSize fontSize99 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript99 = new FontSizeComplexScript() { Val = "22" };

            runProperties99.Append(bold20);
            runProperties99.Append(fontSize99);
            runProperties99.Append(fontSizeComplexScript99);
            Text text99 = new Text();
            text99.Text = "Company information:";

            run99.Append(runProperties99);
            run99.Append(text99);

            paragraph59.Append(paragraphProperties39);
            paragraph59.Append(run99);

            Paragraph paragraph60 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "7BE05946", TextId = "77777777" };

            ParagraphProperties paragraphProperties40 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines40 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation36 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties40.Append(spacingBetweenLines40);
            paragraphProperties40.Append(indentation36);

            Run run100 = new Run();

            RunProperties runProperties100 = new RunProperties();
            RunFonts runFonts37 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize100 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript100 = new FontSizeComplexScript() { Val = "14" };

            runProperties100.Append(runFonts37);
            runProperties100.Append(fontSize100);
            runProperties100.Append(fontSizeComplexScript100);
            Text text100 = new Text();
            text100.Text = "l";

            run100.Append(runProperties100);
            run100.Append(text100);

            Run run101 = new Run();

            RunProperties runProperties101 = new RunProperties();
            RunFonts runFonts38 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize101 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript101 = new FontSizeComplexScript() { Val = "14" };

            runProperties101.Append(runFonts38);
            runProperties101.Append(fontSize101);
            runProperties101.Append(fontSizeComplexScript101);
            Text text101 = new Text();
            text101.Text = " ";

            run101.Append(runProperties101);
            run101.Append(text101);

            Run run102 = new Run();

            RunProperties runProperties102 = new RunProperties();
            FontSize fontSize102 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript102 = new FontSizeComplexScript() { Val = "22" };

            runProperties102.Append(fontSize102);
            runProperties102.Append(fontSizeComplexScript102);
            Text text102 = new Text();
            text102.Text = "Industry: Financial Services / Insurance";

            run102.Append(runProperties102);
            run102.Append(text102);

            paragraph60.Append(paragraphProperties40);
            paragraph60.Append(run100);
            paragraph60.Append(run101);
            paragraph60.Append(run102);

            Paragraph paragraph61 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "68CDDD32", TextId = "77777777" };

            ParagraphProperties paragraphProperties41 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines41 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation37 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties41.Append(spacingBetweenLines41);
            paragraphProperties41.Append(indentation37);

            Run run103 = new Run();

            RunProperties runProperties103 = new RunProperties();
            RunFonts runFonts39 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize103 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript103 = new FontSizeComplexScript() { Val = "14" };

            runProperties103.Append(runFonts39);
            runProperties103.Append(fontSize103);
            runProperties103.Append(fontSizeComplexScript103);
            Text text103 = new Text();
            text103.Text = "l";

            run103.Append(runProperties103);
            run103.Append(text103);

            Run run104 = new Run();

            RunProperties runProperties104 = new RunProperties();
            RunFonts runFonts40 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize104 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript104 = new FontSizeComplexScript() { Val = "14" };

            runProperties104.Append(runFonts40);
            runProperties104.Append(fontSize104);
            runProperties104.Append(fontSizeComplexScript104);
            Text text104 = new Text();
            text104.Text = " ";

            run104.Append(runProperties104);
            run104.Append(text104);

            Run run105 = new Run();

            RunProperties runProperties105 = new RunProperties();
            FontSize fontSize105 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript105 = new FontSizeComplexScript() { Val = "22" };

            runProperties105.Append(fontSize105);
            runProperties105.Append(fontSizeComplexScript105);
            Text text105 = new Text();
            text105.Text = "Services: Global corporate finance advisory and alternative investment consulting";

            run105.Append(runProperties105);
            run105.Append(text105);

            paragraph61.Append(paragraphProperties41);
            paragraph61.Append(run103);
            paragraph61.Append(run104);
            paragraph61.Append(run105);

            Paragraph paragraph62 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "3CABB04A", TextId = "77777777" };

            ParagraphProperties paragraphProperties42 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines42 = new SpacingBetweenLines() { After = "200" };
            Indentation indentation38 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties42.Append(spacingBetweenLines42);
            paragraphProperties42.Append(indentation38);

            Run run106 = new Run();

            RunProperties runProperties106 = new RunProperties();
            RunFonts runFonts41 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize106 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript106 = new FontSizeComplexScript() { Val = "14" };

            runProperties106.Append(runFonts41);
            runProperties106.Append(fontSize106);
            runProperties106.Append(fontSizeComplexScript106);
            Text text106 = new Text();
            text106.Text = "l";

            run106.Append(runProperties106);
            run106.Append(text106);

            Run run107 = new Run();

            RunProperties runProperties107 = new RunProperties();
            RunFonts runFonts42 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize107 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript107 = new FontSizeComplexScript() { Val = "14" };

            runProperties107.Append(runFonts42);
            runProperties107.Append(fontSize107);
            runProperties107.Append(fontSizeComplexScript107);
            Text text107 = new Text();
            text107.Text = " ";

            run107.Append(runProperties107);
            run107.Append(text107);

            Run run108 = new Run();

            RunProperties runProperties108 = new RunProperties();
            FontSize fontSize108 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript108 = new FontSizeComplexScript() { Val = "22" };

            runProperties108.Append(fontSize108);
            runProperties108.Append(fontSizeComplexScript108);
            Text text108 = new Text();
            text108.Text = "Number of employees: 10";

            run108.Append(runProperties108);
            run108.Append(text108);

            paragraph62.Append(paragraphProperties42);
            paragraph62.Append(run106);
            paragraph62.Append(run107);
            paragraph62.Append(run108);

            tableCell41.Append(tableCellProperties41);
            tableCell41.Append(paragraph59);
            tableCell41.Append(paragraph60);
            tableCell41.Append(paragraph61);
            tableCell41.Append(paragraph62);

            tableRow21.Append(tableRowProperties20);
            tableRow21.Append(tableCell40);
            tableRow21.Append(tableCell41);

            TableRow tableRow22 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "3705C6CA", TextId = "77777777" };

            TableRowProperties tableRowProperties21 = new TableRowProperties();
            GridAfter gridAfter21 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow21 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties21.Append(gridAfter21);
            tableRowProperties21.Append(widthAfterTableRow21);

            TableCell tableCell42 = new TableCell();

            TableCellProperties tableCellProperties42 = new TableCellProperties();
            TableCellWidth tableCellWidth42 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders42 = new TableCellBorders();
            TopBorder topBorder43 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder43 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder43 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder43 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders42.Append(topBorder43);
            tableCellBorders42.Append(leftBorder43);
            tableCellBorders42.Append(bottomBorder43);
            tableCellBorders42.Append(rightBorder43);

            tableCellProperties42.Append(tableCellWidth42);
            tableCellProperties42.Append(tableCellBorders42);
            Paragraph paragraph63 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "334F155B", TextId = "77777777" };

            tableCell42.Append(tableCellProperties42);
            tableCell42.Append(paragraph63);

            TableCell tableCell43 = new TableCell();

            TableCellProperties tableCellProperties43 = new TableCellProperties();
            TableCellWidth tableCellWidth43 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders43 = new TableCellBorders();
            TopBorder topBorder44 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder44 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder44 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder44 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders43.Append(topBorder44);
            tableCellBorders43.Append(leftBorder44);
            tableCellBorders43.Append(bottomBorder44);
            tableCellBorders43.Append(rightBorder44);

            tableCellProperties43.Append(tableCellWidth43);
            tableCellProperties43.Append(tableCellBorders43);

            Paragraph paragraph64 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "7BF311FB", TextId = "77777777" };

            ParagraphProperties paragraphProperties43 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines43 = new SpacingBetweenLines() { After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation39 = new Indentation() { Left = "144" };

            paragraphProperties43.Append(spacingBetweenLines43);
            paragraphProperties43.Append(indentation39);

            Run run109 = new Run();

            RunProperties runProperties109 = new RunProperties();
            Bold bold21 = new Bold();
            FontSize fontSize109 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript109 = new FontSizeComplexScript() { Val = "21" };

            runProperties109.Append(bold21);
            runProperties109.Append(fontSize109);
            runProperties109.Append(fontSizeComplexScript109);
            Text text109 = new Text();
            text109.Text = "SENIOR ADVISER";

            run109.Append(runProperties109);
            run109.Append(text109);

            Run run110 = new Run();

            RunProperties runProperties110 = new RunProperties();
            FontSize fontSize110 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript110 = new FontSizeComplexScript() { Val = "21" };

            runProperties110.Append(fontSize110);
            runProperties110.Append(fontSizeComplexScript110);
            Text text110 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text110.Text = " (";

            run110.Append(runProperties110);
            run110.Append(text110);

            Run run111 = new Run();

            RunProperties runProperties111 = new RunProperties();
            Italic italic4 = new Italic();
            ItalicComplexScript italicComplexScript4 = new ItalicComplexScript();
            FontSize fontSize111 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript111 = new FontSizeComplexScript() { Val = "21" };

            runProperties111.Append(italic4);
            runProperties111.Append(italicComplexScript4);
            runProperties111.Append(fontSize111);
            runProperties111.Append(fontSizeComplexScript111);
            Text text111 = new Text();
            text111.Text = "2013 - 2016";

            run111.Append(runProperties111);
            run111.Append(text111);

            Run run112 = new Run();

            RunProperties runProperties112 = new RunProperties();
            FontSize fontSize112 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript112 = new FontSizeComplexScript() { Val = "21" };

            runProperties112.Append(fontSize112);
            runProperties112.Append(fontSizeComplexScript112);
            Text text112 = new Text();
            text112.Text = ")";

            run112.Append(runProperties112);
            run112.Append(text112);

            paragraph64.Append(paragraphProperties43);
            paragraph64.Append(run109);
            paragraph64.Append(run110);
            paragraph64.Append(run111);
            paragraph64.Append(run112);

            tableCell43.Append(tableCellProperties43);
            tableCell43.Append(paragraph64);

            tableRow22.Append(tableRowProperties21);
            tableRow22.Append(tableCell42);
            tableRow22.Append(tableCell43);

            TableRow tableRow23 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "665424AE", TextId = "77777777" };

            TableRowProperties tableRowProperties22 = new TableRowProperties();
            GridAfter gridAfter22 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow22 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties22.Append(gridAfter22);
            tableRowProperties22.Append(widthAfterTableRow22);

            TableCell tableCell44 = new TableCell();

            TableCellProperties tableCellProperties44 = new TableCellProperties();
            TableCellWidth tableCellWidth44 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders44 = new TableCellBorders();
            TopBorder topBorder45 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder45 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder45 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder45 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders44.Append(topBorder45);
            tableCellBorders44.Append(leftBorder45);
            tableCellBorders44.Append(bottomBorder45);
            tableCellBorders44.Append(rightBorder45);

            tableCellProperties44.Append(tableCellWidth44);
            tableCellProperties44.Append(tableCellBorders44);
            Paragraph paragraph65 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "73A80FEB", TextId = "77777777" };

            tableCell44.Append(tableCellProperties44);
            tableCell44.Append(paragraph65);

            TableCell tableCell45 = new TableCell();

            TableCellProperties tableCellProperties45 = new TableCellProperties();
            TableCellWidth tableCellWidth45 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders45 = new TableCellBorders();
            TopBorder topBorder46 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder46 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder46 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder46 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders45.Append(topBorder46);
            tableCellBorders45.Append(leftBorder46);
            tableCellBorders45.Append(bottomBorder46);
            tableCellBorders45.Append(rightBorder46);

            tableCellProperties45.Append(tableCellWidth45);
            tableCellProperties45.Append(tableCellBorders45);

            Paragraph paragraph66 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "117790BA", TextId = "77777777" };

            ParagraphProperties paragraphProperties44 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines44 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation40 = new Indentation() { Left = "144" };

            paragraphProperties44.Append(spacingBetweenLines44);
            paragraphProperties44.Append(indentation40);

            Run run113 = new Run();

            RunProperties runProperties113 = new RunProperties();
            Bold bold22 = new Bold();
            FontSize fontSize113 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript113 = new FontSizeComplexScript() { Val = "22" };

            runProperties113.Append(bold22);
            runProperties113.Append(fontSize113);
            runProperties113.Append(fontSizeComplexScript113);
            Text text113 = new Text();
            text113.Text = "Task information:";

            run113.Append(runProperties113);
            run113.Append(text113);

            paragraph66.Append(paragraphProperties44);
            paragraph66.Append(run113);

            Paragraph paragraph67 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "32F7E7D8", TextId = "77777777" };

            ParagraphProperties paragraphProperties45 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines45 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation41 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties45.Append(spacingBetweenLines45);
            paragraphProperties45.Append(indentation41);

            Run run114 = new Run();

            RunProperties runProperties114 = new RunProperties();
            RunFonts runFonts43 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize114 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript114 = new FontSizeComplexScript() { Val = "14" };

            runProperties114.Append(runFonts43);
            runProperties114.Append(fontSize114);
            runProperties114.Append(fontSizeComplexScript114);
            Text text114 = new Text();
            text114.Text = "l";

            run114.Append(runProperties114);
            run114.Append(text114);

            Run run115 = new Run();

            RunProperties runProperties115 = new RunProperties();
            RunFonts runFonts44 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize115 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript115 = new FontSizeComplexScript() { Val = "14" };

            runProperties115.Append(runFonts44);
            runProperties115.Append(fontSize115);
            runProperties115.Append(fontSizeComplexScript115);
            Text text115 = new Text();
            text115.Text = " ";

            run115.Append(runProperties115);
            run115.Append(text115);

            Run run116 = new Run();

            RunProperties runProperties116 = new RunProperties();
            FontSize fontSize116 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript116 = new FontSizeComplexScript() { Val = "22" };

            runProperties116.Append(fontSize116);
            runProperties116.Append(fontSizeComplexScript116);
            Text text116 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text116.Text = "Investment advisory on deal sourcing and structuring regarding opportunities in former Soviet Union countries, ";

            run116.Append(runProperties116);
            run116.Append(text116);
            ProofError proofError11 = new ProofError() { Type = ProofingErrorValues.GrammarStart };

            Run run117 = new Run();

            RunProperties runProperties117 = new RunProperties();
            FontSize fontSize117 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript117 = new FontSizeComplexScript() { Val = "22" };

            runProperties117.Append(fontSize117);
            runProperties117.Append(fontSizeComplexScript117);
            Text text117 = new Text();
            text117.Text = "particular focus";

            run117.Append(runProperties117);
            run117.Append(text117);
            ProofError proofError12 = new ProofError() { Type = ProofingErrorValues.GrammarEnd };

            Run run118 = new Run();

            RunProperties runProperties118 = new RunProperties();
            FontSize fontSize118 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript118 = new FontSizeComplexScript() { Val = "22" };

            runProperties118.Append(fontSize118);
            runProperties118.Append(fontSizeComplexScript118);
            Text text118 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text118.Text = " on real estate and private equity,";

            run118.Append(runProperties118);
            run118.Append(text118);

            paragraph67.Append(paragraphProperties45);
            paragraph67.Append(run114);
            paragraph67.Append(run115);
            paragraph67.Append(run116);
            paragraph67.Append(proofError11);
            paragraph67.Append(run117);
            paragraph67.Append(proofError12);
            paragraph67.Append(run118);

            Paragraph paragraph68 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "6B860CC1", TextId = "77777777" };

            ParagraphProperties paragraphProperties46 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines46 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation42 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties46.Append(spacingBetweenLines46);
            paragraphProperties46.Append(indentation42);

            Run run119 = new Run();

            RunProperties runProperties119 = new RunProperties();
            RunFonts runFonts45 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize119 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript119 = new FontSizeComplexScript() { Val = "14" };

            runProperties119.Append(runFonts45);
            runProperties119.Append(fontSize119);
            runProperties119.Append(fontSizeComplexScript119);
            Text text119 = new Text();
            text119.Text = "l";

            run119.Append(runProperties119);
            run119.Append(text119);

            Run run120 = new Run();

            RunProperties runProperties120 = new RunProperties();
            RunFonts runFonts46 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize120 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript120 = new FontSizeComplexScript() { Val = "14" };

            runProperties120.Append(runFonts46);
            runProperties120.Append(fontSize120);
            runProperties120.Append(fontSizeComplexScript120);
            Text text120 = new Text();
            text120.Text = " ";

            run120.Append(runProperties120);
            run120.Append(text120);

            Run run121 = new Run();

            RunProperties runProperties121 = new RunProperties();
            FontSize fontSize121 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript121 = new FontSizeComplexScript() { Val = "22" };

            runProperties121.Append(fontSize121);
            runProperties121.Append(fontSizeComplexScript121);
            Text text121 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text121.Text = "including: ";

            run121.Append(runProperties121);
            run121.Append(text121);

            paragraph68.Append(paragraphProperties46);
            paragraph68.Append(run119);
            paragraph68.Append(run120);
            paragraph68.Append(run121);

            Paragraph paragraph69 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "10A4264D", TextId = "77777777" };

            ParagraphProperties paragraphProperties47 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines47 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation43 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties47.Append(spacingBetweenLines47);
            paragraphProperties47.Append(indentation43);

            Run run122 = new Run();

            RunProperties runProperties122 = new RunProperties();
            RunFonts runFonts47 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize122 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript122 = new FontSizeComplexScript() { Val = "14" };

            runProperties122.Append(runFonts47);
            runProperties122.Append(fontSize122);
            runProperties122.Append(fontSizeComplexScript122);
            Text text122 = new Text();
            text122.Text = "l";

            run122.Append(runProperties122);
            run122.Append(text122);

            Run run123 = new Run();

            RunProperties runProperties123 = new RunProperties();
            RunFonts runFonts48 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize123 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript123 = new FontSizeComplexScript() { Val = "14" };

            runProperties123.Append(runFonts48);
            runProperties123.Append(fontSize123);
            runProperties123.Append(fontSizeComplexScript123);
            Text text123 = new Text();
            text123.Text = " ";

            run123.Append(runProperties123);
            run123.Append(text123);

            Run run124 = new Run();

            RunProperties runProperties124 = new RunProperties();
            FontSize fontSize124 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript124 = new FontSizeComplexScript() { Val = "22" };

            runProperties124.Append(fontSize124);
            runProperties124.Append(fontSizeComplexScript124);
            Text text124 = new Text();
            text124.Text = "Structuring a debt (EBRD USD 100M) and equity deal (USD 150M) for a Ukraine based premium foods company;";

            run124.Append(runProperties124);
            run124.Append(text124);

            paragraph69.Append(paragraphProperties47);
            paragraph69.Append(run122);
            paragraph69.Append(run123);
            paragraph69.Append(run124);

            Paragraph paragraph70 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "045E17E4", TextId = "77777777" };

            ParagraphProperties paragraphProperties48 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines48 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation44 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties48.Append(spacingBetweenLines48);
            paragraphProperties48.Append(indentation44);

            Run run125 = new Run();

            RunProperties runProperties125 = new RunProperties();
            RunFonts runFonts49 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize125 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript125 = new FontSizeComplexScript() { Val = "14" };

            runProperties125.Append(runFonts49);
            runProperties125.Append(fontSize125);
            runProperties125.Append(fontSizeComplexScript125);
            Text text125 = new Text();
            text125.Text = "l";

            run125.Append(runProperties125);
            run125.Append(text125);

            Run run126 = new Run();

            RunProperties runProperties126 = new RunProperties();
            RunFonts runFonts50 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize126 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript126 = new FontSizeComplexScript() { Val = "14" };

            runProperties126.Append(runFonts50);
            runProperties126.Append(fontSize126);
            runProperties126.Append(fontSizeComplexScript126);
            Text text126 = new Text();
            text126.Text = " ";

            run126.Append(runProperties126);
            run126.Append(text126);

            Run run127 = new Run();

            RunProperties runProperties127 = new RunProperties();
            FontSize fontSize127 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript127 = new FontSizeComplexScript() { Val = "22" };

            runProperties127.Append(fontSize127);
            runProperties127.Append(fontSizeComplexScript127);
            Text text127 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text127.Text = "Assisted in sourcing prospective investors from Eastern & Central Europe for the Fox Point/Keel ";

            run127.Append(runProperties127);
            run127.Append(text127);
            ProofError proofError13 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run128 = new Run();

            RunProperties runProperties128 = new RunProperties();
            FontSize fontSize128 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript128 = new FontSizeComplexScript() { Val = "22" };

            runProperties128.Append(fontSize128);
            runProperties128.Append(fontSizeComplexScript128);
            Text text128 = new Text();
            text128.Text = "Harbour";

            run128.Append(runProperties128);
            run128.Append(text128);
            ProofError proofError14 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run129 = new Run();

            RunProperties runProperties129 = new RunProperties();
            FontSize fontSize129 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript129 = new FontSizeComplexScript() { Val = "22" };

            runProperties129.Append(fontSize129);
            runProperties129.Append(fontSizeComplexScript129);
            Text text129 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text129.Text = " ";

            run129.Append(runProperties129);
            run129.Append(text129);

            Run run130 = new Run();

            RunProperties runProperties130 = new RunProperties();
            FontSize fontSize130 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript130 = new FontSizeComplexScript() { Val = "22" };

            runProperties130.Append(fontSize130);
            runProperties130.Append(fontSizeComplexScript130);
            LastRenderedPageBreak lastRenderedPageBreak2 = new LastRenderedPageBreak();
            Text text130 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text130.Text = "mandate with Round Hill Capital, a ";

            run130.Append(runProperties130);
            run130.Append(lastRenderedPageBreak2);
            run130.Append(text130);
            ProofError proofError15 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run131 = new Run();

            RunProperties runProperties131 = new RunProperties();
            FontSize fontSize131 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript131 = new FontSizeComplexScript() { Val = "22" };

            runProperties131.Append(fontSize131);
            runProperties131.Append(fontSizeComplexScript131);
            Text text131 = new Text();
            text131.Text = "panEuropean";

            run131.Append(runProperties131);
            run131.Append(text131);
            ProofError proofError16 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run132 = new Run();

            RunProperties runProperties132 = new RunProperties();
            FontSize fontSize132 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript132 = new FontSizeComplexScript() { Val = "22" };

            runProperties132.Append(fontSize132);
            runProperties132.Append(fontSizeComplexScript132);
            Text text132 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text132.Text = " real estate investor;";

            run132.Append(runProperties132);
            run132.Append(text132);

            paragraph70.Append(paragraphProperties48);
            paragraph70.Append(run125);
            paragraph70.Append(run126);
            paragraph70.Append(run127);
            paragraph70.Append(proofError13);
            paragraph70.Append(run128);
            paragraph70.Append(proofError14);
            paragraph70.Append(run129);
            paragraph70.Append(run130);
            paragraph70.Append(proofError15);
            paragraph70.Append(run131);
            paragraph70.Append(proofError16);
            paragraph70.Append(run132);

            Paragraph paragraph71 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "28C736FC", TextId = "77777777" };

            ParagraphProperties paragraphProperties49 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines49 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation45 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties49.Append(spacingBetweenLines49);
            paragraphProperties49.Append(indentation45);

            Run run133 = new Run();

            RunProperties runProperties133 = new RunProperties();
            RunFonts runFonts51 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize133 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript133 = new FontSizeComplexScript() { Val = "14" };

            runProperties133.Append(runFonts51);
            runProperties133.Append(fontSize133);
            runProperties133.Append(fontSizeComplexScript133);
            Text text133 = new Text();
            text133.Text = "l";

            run133.Append(runProperties133);
            run133.Append(text133);

            Run run134 = new Run();

            RunProperties runProperties134 = new RunProperties();
            RunFonts runFonts52 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize134 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript134 = new FontSizeComplexScript() { Val = "14" };

            runProperties134.Append(runFonts52);
            runProperties134.Append(fontSize134);
            runProperties134.Append(fontSizeComplexScript134);
            Text text134 = new Text();
            text134.Text = " ";

            run134.Append(runProperties134);
            run134.Append(text134);

            Run run135 = new Run();

            RunProperties runProperties135 = new RunProperties();
            FontSize fontSize135 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript135 = new FontSizeComplexScript() { Val = "22" };

            runProperties135.Append(fontSize135);
            runProperties135.Append(fontSizeComplexScript135);
            Text text135 = new Text();
            text135.Text = "USD 500M EV Azimuth tanker project (UK/India);";

            run135.Append(runProperties135);
            run135.Append(text135);

            paragraph71.Append(paragraphProperties49);
            paragraph71.Append(run133);
            paragraph71.Append(run134);
            paragraph71.Append(run135);

            Paragraph paragraph72 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "7D951B03", TextId = "658F0785" };

            ParagraphProperties paragraphProperties50 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines50 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation46 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties50.Append(spacingBetweenLines50);
            paragraphProperties50.Append(indentation46);

            Run run136 = new Run();

            RunProperties runProperties136 = new RunProperties();
            RunFonts runFonts53 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize136 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript136 = new FontSizeComplexScript() { Val = "14" };

            runProperties136.Append(runFonts53);
            runProperties136.Append(fontSize136);
            runProperties136.Append(fontSizeComplexScript136);
            Text text136 = new Text();
            text136.Text = "l";

            run136.Append(runProperties136);
            run136.Append(text136);

            Run run137 = new Run();

            RunProperties runProperties137 = new RunProperties();
            RunFonts runFonts54 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize137 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript137 = new FontSizeComplexScript() { Val = "14" };

            runProperties137.Append(runFonts54);
            runProperties137.Append(fontSize137);
            runProperties137.Append(fontSizeComplexScript137);
            Text text137 = new Text();
            text137.Text = " ";

            run137.Append(runProperties137);
            run137.Append(text137);

            Run run138 = new Run();

            RunProperties runProperties138 = new RunProperties();
            FontSize fontSize138 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript138 = new FontSizeComplexScript() { Val = "22" };

            runProperties138.Append(fontSize138);
            runProperties138.Append(fontSizeComplexScript138);
            Text text138 = new Text();
            text138.Text = "Advised Fox Point on an emerging market focused hedge fund in the valuation and prospective liquidation of their USD 75M side pocket, which included assets domiciled in the CIS;";

            run138.Append(runProperties138);
            run138.Append(text138);

            paragraph72.Append(paragraphProperties50);
            paragraph72.Append(run136);
            paragraph72.Append(run137);
            paragraph72.Append(run138);

            Paragraph paragraph73 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "5C3A4E81", TextId = "704D4100" };

            ParagraphProperties paragraphProperties51 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines51 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation47 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties51.Append(spacingBetweenLines51);
            paragraphProperties51.Append(indentation47);

            Run run139 = new Run();

            RunProperties runProperties139 = new RunProperties();
            RunFonts runFonts55 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize139 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript139 = new FontSizeComplexScript() { Val = "14" };

            runProperties139.Append(runFonts55);
            runProperties139.Append(fontSize139);
            runProperties139.Append(fontSizeComplexScript139);
            Text text139 = new Text();
            text139.Text = "l";

            run139.Append(runProperties139);
            run139.Append(text139);

            Run run140 = new Run();

            RunProperties runProperties140 = new RunProperties();
            RunFonts runFonts56 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize140 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript140 = new FontSizeComplexScript() { Val = "14" };

            runProperties140.Append(runFonts56);
            runProperties140.Append(fontSize140);
            runProperties140.Append(fontSizeComplexScript140);
            Text text140 = new Text();
            text140.Text = " ";

            run140.Append(runProperties140);
            run140.Append(text140);

            Run run141 = new Run();

            RunProperties runProperties141 = new RunProperties();
            FontSize fontSize141 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript141 = new FontSizeComplexScript() { Val = "22" };

            runProperties141.Append(fontSize141);
            runProperties141.Append(fontSizeComplexScript141);
            Text text141 = new Text();
            text141.Text = "Developed investment strategies for high profile pan European real estate investors;";

            run141.Append(runProperties141);
            run141.Append(text141);

            paragraph73.Append(paragraphProperties51);
            paragraph73.Append(run139);
            paragraph73.Append(run140);
            paragraph73.Append(run141);

            Paragraph paragraph74 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "43E293FD", TextId = "77777777" };

            ParagraphProperties paragraphProperties52 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines52 = new SpacingBetweenLines() { After = "200" };
            Indentation indentation48 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties52.Append(spacingBetweenLines52);
            paragraphProperties52.Append(indentation48);

            Run run142 = new Run();

            RunProperties runProperties142 = new RunProperties();
            RunFonts runFonts57 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize142 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript142 = new FontSizeComplexScript() { Val = "14" };

            runProperties142.Append(runFonts57);
            runProperties142.Append(fontSize142);
            runProperties142.Append(fontSizeComplexScript142);
            Text text142 = new Text();
            text142.Text = "l";

            run142.Append(runProperties142);
            run142.Append(text142);

            Run run143 = new Run();

            RunProperties runProperties143 = new RunProperties();
            RunFonts runFonts58 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize143 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript143 = new FontSizeComplexScript() { Val = "14" };

            runProperties143.Append(runFonts58);
            runProperties143.Append(fontSize143);
            runProperties143.Append(fontSizeComplexScript143);
            Text text143 = new Text();
            text143.Text = " ";

            run143.Append(runProperties143);
            run143.Append(text143);

            Run run144 = new Run();

            RunProperties runProperties144 = new RunProperties();
            FontSize fontSize144 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript144 = new FontSizeComplexScript() { Val = "22" };

            runProperties144.Append(fontSize144);
            runProperties144.Append(fontSizeComplexScript144);
            Text text144 = new Text();
            text144.Text = "Provided macrolevel guidance for Fox Point Capital clientele.";

            run144.Append(runProperties144);
            run144.Append(text144);

            paragraph74.Append(paragraphProperties52);
            paragraph74.Append(run142);
            paragraph74.Append(run143);
            paragraph74.Append(run144);

            tableCell45.Append(tableCellProperties45);
            tableCell45.Append(paragraph66);
            tableCell45.Append(paragraph67);
            tableCell45.Append(paragraph68);
            tableCell45.Append(paragraph69);
            tableCell45.Append(paragraph70);
            tableCell45.Append(paragraph71);
            tableCell45.Append(paragraph72);
            tableCell45.Append(paragraph73);
            tableCell45.Append(paragraph74);

            tableRow23.Append(tableRowProperties22);
            tableRow23.Append(tableCell44);
            tableRow23.Append(tableCell45);

            TableRow tableRow24 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "4852B0ED", TextId = "77777777" };

            TableRowProperties tableRowProperties23 = new TableRowProperties();
            GridAfter gridAfter23 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow23 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties23.Append(gridAfter23);
            tableRowProperties23.Append(widthAfterTableRow23);

            TableCell tableCell46 = new TableCell();

            TableCellProperties tableCellProperties46 = new TableCellProperties();
            TableCellWidth tableCellWidth46 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders46 = new TableCellBorders();
            TopBorder topBorder47 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder47 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder47 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder47 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders46.Append(topBorder47);
            tableCellBorders46.Append(leftBorder47);
            tableCellBorders46.Append(bottomBorder47);
            tableCellBorders46.Append(rightBorder47);

            tableCellProperties46.Append(tableCellWidth46);
            tableCellProperties46.Append(tableCellBorders46);
            Paragraph paragraph75 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "451003E6", TextId = "77777777" };

            tableCell46.Append(tableCellProperties46);
            tableCell46.Append(paragraph75);

            TableCell tableCell47 = new TableCell();

            TableCellProperties tableCellProperties47 = new TableCellProperties();
            TableCellWidth tableCellWidth47 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders47 = new TableCellBorders();
            TopBorder topBorder48 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder48 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder48 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder48 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders47.Append(topBorder48);
            tableCellBorders47.Append(leftBorder48);
            tableCellBorders47.Append(bottomBorder48);
            tableCellBorders47.Append(rightBorder48);

            tableCellProperties47.Append(tableCellWidth47);
            tableCellProperties47.Append(tableCellBorders47);

            Paragraph paragraph76 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "12725C7C", TextId = "453F5A49" };

            ParagraphProperties paragraphProperties53 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines53 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation49 = new Indentation() { Left = "144" };

            paragraphProperties53.Append(spacingBetweenLines53);
            paragraphProperties53.Append(indentation49);

            Run run145 = new Run();

            RunProperties runProperties145 = new RunProperties();
            Bold bold23 = new Bold();
            FontSize fontSize145 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript145 = new FontSizeComplexScript() { Val = "22" };

            runProperties145.Append(bold23);
            runProperties145.Append(fontSize145);
            runProperties145.Append(fontSizeComplexScript145);
            Text text145 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text145.Text = "Reporting to: ";

            run145.Append(runProperties145);
            run145.Append(text145);

            Run run146 = new Run();

            RunProperties runProperties146 = new RunProperties();
            FontSize fontSize146 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript146 = new FontSizeComplexScript() { Val = "22" };

            runProperties146.Append(fontSize146);
            runProperties146.Append(fontSizeComplexScript146);
            Text text146 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text146.Text = "Mr. ";

            run146.Append(runProperties146);
            run146.Append(text146);

            paragraph76.Append(paragraphProperties53);
            paragraph76.Append(run145);
            paragraph76.Append(run146);

            tableCell47.Append(tableCellProperties47);
            tableCell47.Append(paragraph76);

            tableRow24.Append(tableRowProperties23);
            tableRow24.Append(tableCell46);
            tableRow24.Append(tableCell47);

            TableRow tableRow25 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "18133863", TextId = "77777777" };

            TableRowProperties tableRowProperties24 = new TableRowProperties();
            GridAfter gridAfter24 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow24 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties24.Append(gridAfter24);
            tableRowProperties24.Append(widthAfterTableRow24);

            TableCell tableCell48 = new TableCell();

            TableCellProperties tableCellProperties48 = new TableCellProperties();
            TableCellWidth tableCellWidth48 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders48 = new TableCellBorders();
            TopBorder topBorder49 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder49 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder49 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder49 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders48.Append(topBorder49);
            tableCellBorders48.Append(leftBorder49);
            tableCellBorders48.Append(bottomBorder49);
            tableCellBorders48.Append(rightBorder49);

            tableCellProperties48.Append(tableCellWidth48);
            tableCellProperties48.Append(tableCellBorders48);
            Paragraph paragraph77 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "275A5090", TextId = "77777777" };

            tableCell48.Append(tableCellProperties48);
            tableCell48.Append(paragraph77);

            TableCell tableCell49 = new TableCell();

            TableCellProperties tableCellProperties49 = new TableCellProperties();
            TableCellWidth tableCellWidth49 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders49 = new TableCellBorders();
            TopBorder topBorder50 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder50 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder50 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder50 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders49.Append(topBorder50);
            tableCellBorders49.Append(leftBorder50);
            tableCellBorders49.Append(bottomBorder50);
            tableCellBorders49.Append(rightBorder50);

            tableCellProperties49.Append(tableCellWidth49);
            tableCellProperties49.Append(tableCellBorders49);

            Paragraph paragraph78 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "50F6687C", TextId = "0F3C5F31" };

            ParagraphProperties paragraphProperties54 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines54 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation50 = new Indentation() { Left = "144" };

            paragraphProperties54.Append(spacingBetweenLines54);
            paragraphProperties54.Append(indentation50);

            Run run147 = new Run();

            RunProperties runProperties147 = new RunProperties();
            Bold bold24 = new Bold();
            FontSize fontSize147 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript147 = new FontSizeComplexScript() { Val = "22" };

            runProperties147.Append(bold24);
            runProperties147.Append(fontSize147);
            runProperties147.Append(fontSizeComplexScript147);
            Text text147 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text147.Text = "Reason for leaving: ";

            run147.Append(runProperties147);
            run147.Append(text147);

            Run run148 = new Run();

            RunProperties runProperties148 = new RunProperties();
            FontSize fontSize148 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript148 = new FontSizeComplexScript() { Val = "22" };

            runProperties148.Append(fontSize148);
            runProperties148.Append(fontSizeComplexScript148);
            Text text148 = new Text();
            text148.Text = "Car accident (21/9/2016) in South India. Severe injuries, recovery and rehabilitation for several months.";

            run148.Append(runProperties148);
            run148.Append(text148);

            paragraph78.Append(paragraphProperties54);
            paragraph78.Append(run147);
            paragraph78.Append(run148);

            tableCell49.Append(tableCellProperties49);
            tableCell49.Append(paragraph78);

            tableRow25.Append(tableRowProperties24);
            tableRow25.Append(tableCell48);
            tableRow25.Append(tableCell49);

            TableRow tableRow26 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "747DEA16", TextId = "77777777" };

            TableRowProperties tableRowProperties25 = new TableRowProperties();
            GridAfter gridAfter25 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow25 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties25.Append(gridAfter25);
            tableRowProperties25.Append(widthAfterTableRow25);

            TableCell tableCell50 = new TableCell();

            TableCellProperties tableCellProperties50 = new TableCellProperties();
            TableCellWidth tableCellWidth50 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders50 = new TableCellBorders();
            TopBorder topBorder51 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder51 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder51 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder51 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders50.Append(topBorder51);
            tableCellBorders50.Append(leftBorder51);
            tableCellBorders50.Append(bottomBorder51);
            tableCellBorders50.Append(rightBorder51);

            tableCellProperties50.Append(tableCellWidth50);
            tableCellProperties50.Append(tableCellBorders50);
            Paragraph paragraph79 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "3466F18D", TextId = "77777777" };

            tableCell50.Append(tableCellProperties50);
            tableCell50.Append(paragraph79);

            TableCell tableCell51 = new TableCell();

            TableCellProperties tableCellProperties51 = new TableCellProperties();
            TableCellWidth tableCellWidth51 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders51 = new TableCellBorders();
            TopBorder topBorder52 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder52 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder52 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder52 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders51.Append(topBorder52);
            tableCellBorders51.Append(leftBorder52);
            tableCellBorders51.Append(bottomBorder52);
            tableCellBorders51.Append(rightBorder52);

            tableCellProperties51.Append(tableCellWidth51);
            tableCellProperties51.Append(tableCellBorders51);

            Paragraph paragraph80 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "6C4D81EA", TextId = "77777777" };
            BookmarkStart bookmarkStart1 = new BookmarkStart() { Name = "_GoBack", Id = "0" };
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd() { Id = "0" };

            paragraph80.Append(bookmarkStart1);
            paragraph80.Append(bookmarkEnd1);

            tableCell51.Append(tableCellProperties51);
            tableCell51.Append(paragraph80);

            tableRow26.Append(tableRowProperties25);
            tableRow26.Append(tableCell50);
            tableRow26.Append(tableCell51);

            TableRow tableRow27 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "27DCB760", TextId = "77777777" };

            TableRowProperties tableRowProperties26 = new TableRowProperties();
            GridAfter gridAfter26 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow26 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties26.Append(gridAfter26);
            tableRowProperties26.Append(widthAfterTableRow26);

            TableCell tableCell52 = new TableCell();

            TableCellProperties tableCellProperties52 = new TableCellProperties();
            TableCellWidth tableCellWidth52 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders52 = new TableCellBorders();
            TopBorder topBorder53 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder53 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder53 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder53 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders52.Append(topBorder53);
            tableCellBorders52.Append(leftBorder53);
            tableCellBorders52.Append(bottomBorder53);
            tableCellBorders52.Append(rightBorder53);

            tableCellProperties52.Append(tableCellWidth52);
            tableCellProperties52.Append(tableCellBorders52);

            Paragraph paragraph81 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "1D8A4668", TextId = "77777777" };

            ParagraphProperties paragraphProperties55 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines55 = new SpacingBetweenLines() { Before = "30", After = "10" };

            paragraphProperties55.Append(spacingBetweenLines55);

            Run run149 = new Run();

            RunProperties runProperties149 = new RunProperties();
            FontSize fontSize149 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript149 = new FontSizeComplexScript() { Val = "22" };

            runProperties149.Append(fontSize149);
            runProperties149.Append(fontSizeComplexScript149);
            Text text149 = new Text();
            text149.Text = "2007 - 2012";

            run149.Append(runProperties149);
            run149.Append(text149);

            paragraph81.Append(paragraphProperties55);
            paragraph81.Append(run149);

            tableCell52.Append(tableCellProperties52);
            tableCell52.Append(paragraph81);

            TableCell tableCell53 = new TableCell();

            TableCellProperties tableCellProperties53 = new TableCellProperties();
            TableCellWidth tableCellWidth53 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders53 = new TableCellBorders();
            TopBorder topBorder54 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder54 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder54 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder54 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders53.Append(topBorder54);
            tableCellBorders53.Append(leftBorder54);
            tableCellBorders53.Append(bottomBorder54);
            tableCellBorders53.Append(rightBorder54);
            Shading shading5 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "0069B4" };

            tableCellProperties53.Append(tableCellWidth53);
            tableCellProperties53.Append(tableCellBorders53);
            tableCellProperties53.Append(shading5);

            Paragraph paragraph82 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "0007641E", ParagraphId = "5CBBB35C", TextId = "3C37DA5A" };

            ParagraphProperties paragraphProperties56 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines56 = new SpacingBetweenLines() { Before = "30", After = "10", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation51 = new Indentation() { Left = "144" };

            paragraphProperties56.Append(spacingBetweenLines56);
            paragraphProperties56.Append(indentation51);

            Run run150 = new Run();

            RunProperties runProperties150 = new RunProperties();
            Bold bold25 = new Bold();
            Color color7 = new Color() { Val = "FFFFFF" };
            FontSize fontSize150 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript150 = new FontSizeComplexScript() { Val = "21" };

            runProperties150.Append(bold25);
            runProperties150.Append(color7);
            runProperties150.Append(fontSize150);
            runProperties150.Append(fontSizeComplexScript150);
            Text text150 = new Text();
            text150.Text = "SIA N";

            run150.Append(runProperties150);
            run150.Append(text150);

            paragraph82.Append(paragraphProperties56);
            paragraph82.Append(run150);

            tableCell53.Append(tableCellProperties53);
            tableCell53.Append(paragraph82);

            tableRow27.Append(tableRowProperties26);
            tableRow27.Append(tableCell52);
            tableRow27.Append(tableCell53);

            TableRow tableRow28 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "63CC0771", TextId = "77777777" };

            TableRowProperties tableRowProperties27 = new TableRowProperties();
            GridAfter gridAfter27 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow27 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties27.Append(gridAfter27);
            tableRowProperties27.Append(widthAfterTableRow27);

            TableCell tableCell54 = new TableCell();

            TableCellProperties tableCellProperties54 = new TableCellProperties();
            TableCellWidth tableCellWidth54 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders54 = new TableCellBorders();
            TopBorder topBorder55 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder55 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder55 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder55 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders54.Append(topBorder55);
            tableCellBorders54.Append(leftBorder55);
            tableCellBorders54.Append(bottomBorder55);
            tableCellBorders54.Append(rightBorder55);

            tableCellProperties54.Append(tableCellWidth54);
            tableCellProperties54.Append(tableCellBorders54);
            Paragraph paragraph83 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "5973A761", TextId = "77777777" };

            tableCell54.Append(tableCellProperties54);
            tableCell54.Append(paragraph83);

            TableCell tableCell55 = new TableCell();

            TableCellProperties tableCellProperties55 = new TableCellProperties();
            TableCellWidth tableCellWidth55 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders55 = new TableCellBorders();
            TopBorder topBorder56 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder56 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder56 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder56 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders55.Append(topBorder56);
            tableCellBorders55.Append(leftBorder56);
            tableCellBorders55.Append(bottomBorder56);
            tableCellBorders55.Append(rightBorder56);

            tableCellProperties55.Append(tableCellWidth55);
            tableCellProperties55.Append(tableCellBorders55);

            Paragraph paragraph84 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "44E91558", TextId = "77777777" };

            ParagraphProperties paragraphProperties57 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines57 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation52 = new Indentation() { Left = "144" };

            paragraphProperties57.Append(spacingBetweenLines57);
            paragraphProperties57.Append(indentation52);

            Run run151 = new Run();

            RunProperties runProperties151 = new RunProperties();
            Bold bold26 = new Bold();
            FontSize fontSize151 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript151 = new FontSizeComplexScript() { Val = "22" };

            runProperties151.Append(bold26);
            runProperties151.Append(fontSize151);
            runProperties151.Append(fontSizeComplexScript151);
            Text text151 = new Text();
            text151.Text = "Company information:";

            run151.Append(runProperties151);
            run151.Append(text151);

            paragraph84.Append(paragraphProperties57);
            paragraph84.Append(run151);

            Paragraph paragraph85 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "3CE4BA65", TextId = "77777777" };

            ParagraphProperties paragraphProperties58 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines58 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation53 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties58.Append(spacingBetweenLines58);
            paragraphProperties58.Append(indentation53);

            Run run152 = new Run();

            RunProperties runProperties152 = new RunProperties();
            RunFonts runFonts59 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize152 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript152 = new FontSizeComplexScript() { Val = "14" };

            runProperties152.Append(runFonts59);
            runProperties152.Append(fontSize152);
            runProperties152.Append(fontSizeComplexScript152);
            Text text152 = new Text();
            text152.Text = "l";

            run152.Append(runProperties152);
            run152.Append(text152);

            Run run153 = new Run();

            RunProperties runProperties153 = new RunProperties();
            RunFonts runFonts60 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize153 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript153 = new FontSizeComplexScript() { Val = "14" };

            runProperties153.Append(runFonts60);
            runProperties153.Append(fontSize153);
            runProperties153.Append(fontSizeComplexScript153);
            Text text153 = new Text();
            text153.Text = " ";

            run153.Append(runProperties153);
            run153.Append(text153);

            Run run154 = new Run();

            RunProperties runProperties154 = new RunProperties();
            FontSize fontSize154 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript154 = new FontSizeComplexScript() { Val = "22" };

            runProperties154.Append(fontSize154);
            runProperties154.Append(fontSizeComplexScript154);
            Text text154 = new Text();
            text154.Text = "Industry: Natural Resources / Agriculture / Forestry / Oil & Gas";

            run154.Append(runProperties154);
            run154.Append(text154);

            paragraph85.Append(paragraphProperties58);
            paragraph85.Append(run152);
            paragraph85.Append(run153);
            paragraph85.Append(run154);

            Paragraph paragraph86 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "2DCF7DF9", TextId = "77777777" };

            ParagraphProperties paragraphProperties59 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines59 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation54 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties59.Append(spacingBetweenLines59);
            paragraphProperties59.Append(indentation54);

            Run run155 = new Run();

            RunProperties runProperties155 = new RunProperties();
            RunFonts runFonts61 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize155 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript155 = new FontSizeComplexScript() { Val = "14" };

            runProperties155.Append(runFonts61);
            runProperties155.Append(fontSize155);
            runProperties155.Append(fontSizeComplexScript155);
            Text text155 = new Text();
            text155.Text = "l";

            run155.Append(runProperties155);
            run155.Append(text155);

            Run run156 = new Run();

            RunProperties runProperties156 = new RunProperties();
            RunFonts runFonts62 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize156 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript156 = new FontSizeComplexScript() { Val = "14" };

            runProperties156.Append(runFonts62);
            runProperties156.Append(fontSize156);
            runProperties156.Append(fontSizeComplexScript156);
            Text text156 = new Text();
            text156.Text = " ";

            run156.Append(runProperties156);
            run156.Append(text156);

            Run run157 = new Run();

            RunProperties runProperties157 = new RunProperties();
            FontSize fontSize157 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript157 = new FontSizeComplexScript() { Val = "22" };

            runProperties157.Append(fontSize157);
            runProperties157.Append(fontSizeComplexScript157);
            Text text157 = new Text();
            text157.Text = "Services: One of the world\'s largest agricultural business investment funds exceeding $1.2B assets under management and controlling over 600,000 ha of farmland";

            run157.Append(runProperties157);
            run157.Append(text157);

            paragraph86.Append(paragraphProperties59);
            paragraph86.Append(run155);
            paragraph86.Append(run156);
            paragraph86.Append(run157);

            Paragraph paragraph87 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "0C2085AA", TextId = "77777777" };

            ParagraphProperties paragraphProperties60 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines60 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation55 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties60.Append(spacingBetweenLines60);
            paragraphProperties60.Append(indentation55);

            Run run158 = new Run();

            RunProperties runProperties158 = new RunProperties();
            RunFonts runFonts63 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize158 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript158 = new FontSizeComplexScript() { Val = "14" };

            runProperties158.Append(runFonts63);
            runProperties158.Append(fontSize158);
            runProperties158.Append(fontSizeComplexScript158);
            Text text158 = new Text();
            text158.Text = "l";

            run158.Append(runProperties158);
            run158.Append(text158);

            Run run159 = new Run();

            RunProperties runProperties159 = new RunProperties();
            RunFonts runFonts64 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize159 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript159 = new FontSizeComplexScript() { Val = "14" };

            runProperties159.Append(runFonts64);
            runProperties159.Append(fontSize159);
            runProperties159.Append(fontSizeComplexScript159);
            Text text159 = new Text();
            text159.Text = " ";

            run159.Append(runProperties159);
            run159.Append(text159);

            Run run160 = new Run();

            RunProperties runProperties160 = new RunProperties();
            FontSize fontSize160 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript160 = new FontSizeComplexScript() { Val = "22" };

            runProperties160.Append(fontSize160);
            runProperties160.Append(fontSizeComplexScript160);
            Text text160 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text160.Text = "Turnover: Expected Net Profit for 2018: over USD 100M ";

            run160.Append(runProperties160);
            run160.Append(text160);

            paragraph87.Append(paragraphProperties60);
            paragraph87.Append(run158);
            paragraph87.Append(run159);
            paragraph87.Append(run160);

            Paragraph paragraph88 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "56B473D1", TextId = "77777777" };

            ParagraphProperties paragraphProperties61 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines61 = new SpacingBetweenLines() { After = "200" };
            Indentation indentation56 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties61.Append(spacingBetweenLines61);
            paragraphProperties61.Append(indentation56);

            Run run161 = new Run();

            RunProperties runProperties161 = new RunProperties();
            RunFonts runFonts65 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize161 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript161 = new FontSizeComplexScript() { Val = "14" };

            runProperties161.Append(runFonts65);
            runProperties161.Append(fontSize161);
            runProperties161.Append(fontSizeComplexScript161);
            Text text161 = new Text();
            text161.Text = "l";

            run161.Append(runProperties161);
            run161.Append(text161);

            Run run162 = new Run();

            RunProperties runProperties162 = new RunProperties();
            RunFonts runFonts66 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize162 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript162 = new FontSizeComplexScript() { Val = "14" };

            runProperties162.Append(runFonts66);
            runProperties162.Append(fontSize162);
            runProperties162.Append(fontSizeComplexScript162);
            Text text162 = new Text();
            text162.Text = " ";

            run162.Append(runProperties162);
            run162.Append(text162);

            Run run163 = new Run();

            RunProperties runProperties163 = new RunProperties();
            FontSize fontSize163 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript163 = new FontSizeComplexScript() { Val = "22" };

            runProperties163.Append(fontSize163);
            runProperties163.Append(fontSizeComplexScript163);
            Text text163 = new Text();
            text163.Text = "Number of employees: ~ 15";

            run163.Append(runProperties163);
            run163.Append(text163);

            paragraph88.Append(paragraphProperties61);
            paragraph88.Append(run161);
            paragraph88.Append(run162);
            paragraph88.Append(run163);

            tableCell55.Append(tableCellProperties55);
            tableCell55.Append(paragraph84);
            tableCell55.Append(paragraph85);
            tableCell55.Append(paragraph86);
            tableCell55.Append(paragraph87);
            tableCell55.Append(paragraph88);

            tableRow28.Append(tableRowProperties27);
            tableRow28.Append(tableCell54);
            tableRow28.Append(tableCell55);

            TableRow tableRow29 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "74A49164", TextId = "77777777" };

            TableRowProperties tableRowProperties28 = new TableRowProperties();
            GridAfter gridAfter28 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow28 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties28.Append(gridAfter28);
            tableRowProperties28.Append(widthAfterTableRow28);

            TableCell tableCell56 = new TableCell();

            TableCellProperties tableCellProperties56 = new TableCellProperties();
            TableCellWidth tableCellWidth56 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders56 = new TableCellBorders();
            TopBorder topBorder57 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder57 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder57 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder57 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders56.Append(topBorder57);
            tableCellBorders56.Append(leftBorder57);
            tableCellBorders56.Append(bottomBorder57);
            tableCellBorders56.Append(rightBorder57);

            tableCellProperties56.Append(tableCellWidth56);
            tableCellProperties56.Append(tableCellBorders56);
            Paragraph paragraph89 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "2546772F", TextId = "77777777" };

            tableCell56.Append(tableCellProperties56);
            tableCell56.Append(paragraph89);

            TableCell tableCell57 = new TableCell();

            TableCellProperties tableCellProperties57 = new TableCellProperties();
            TableCellWidth tableCellWidth57 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders57 = new TableCellBorders();
            TopBorder topBorder58 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder58 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder58 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder58 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders57.Append(topBorder58);
            tableCellBorders57.Append(leftBorder58);
            tableCellBorders57.Append(bottomBorder58);
            tableCellBorders57.Append(rightBorder58);

            tableCellProperties57.Append(tableCellWidth57);
            tableCellProperties57.Append(tableCellBorders57);

            Paragraph paragraph90 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "1B570697", TextId = "77777777" };

            ParagraphProperties paragraphProperties62 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines62 = new SpacingBetweenLines() { After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation57 = new Indentation() { Left = "144" };

            paragraphProperties62.Append(spacingBetweenLines62);
            paragraphProperties62.Append(indentation57);

            Run run164 = new Run();

            RunProperties runProperties164 = new RunProperties();
            Bold bold27 = new Bold();
            FontSize fontSize164 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript164 = new FontSizeComplexScript() { Val = "21" };

            runProperties164.Append(bold27);
            runProperties164.Append(fontSize164);
            runProperties164.Append(fontSizeComplexScript164);
            Text text164 = new Text();
            text164.Text = "INVESTMENT MANAGER";

            run164.Append(runProperties164);
            run164.Append(text164);

            Run run165 = new Run();

            RunProperties runProperties165 = new RunProperties();
            FontSize fontSize165 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript165 = new FontSizeComplexScript() { Val = "21" };

            runProperties165.Append(fontSize165);
            runProperties165.Append(fontSizeComplexScript165);
            Text text165 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text165.Text = " (";

            run165.Append(runProperties165);
            run165.Append(text165);

            Run run166 = new Run();

            RunProperties runProperties166 = new RunProperties();
            Italic italic5 = new Italic();
            ItalicComplexScript italicComplexScript5 = new ItalicComplexScript();
            FontSize fontSize166 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript166 = new FontSizeComplexScript() { Val = "21" };

            runProperties166.Append(italic5);
            runProperties166.Append(italicComplexScript5);
            runProperties166.Append(fontSize166);
            runProperties166.Append(fontSizeComplexScript166);
            Text text166 = new Text();
            text166.Text = "2007 - 2012";

            run166.Append(runProperties166);
            run166.Append(text166);

            Run run167 = new Run();

            RunProperties runProperties167 = new RunProperties();
            FontSize fontSize167 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript167 = new FontSizeComplexScript() { Val = "21" };

            runProperties167.Append(fontSize167);
            runProperties167.Append(fontSizeComplexScript167);
            Text text167 = new Text();
            text167.Text = ")";

            run167.Append(runProperties167);
            run167.Append(text167);

            paragraph90.Append(paragraphProperties62);
            paragraph90.Append(run164);
            paragraph90.Append(run165);
            paragraph90.Append(run166);
            paragraph90.Append(run167);

            tableCell57.Append(tableCellProperties57);
            tableCell57.Append(paragraph90);

            tableRow29.Append(tableRowProperties28);
            tableRow29.Append(tableCell56);
            tableRow29.Append(tableCell57);

            TableRow tableRow30 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "2EDC21D4", TextId = "77777777" };

            TableRowProperties tableRowProperties29 = new TableRowProperties();
            GridAfter gridAfter29 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow29 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties29.Append(gridAfter29);
            tableRowProperties29.Append(widthAfterTableRow29);

            TableCell tableCell58 = new TableCell();

            TableCellProperties tableCellProperties58 = new TableCellProperties();
            TableCellWidth tableCellWidth58 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders58 = new TableCellBorders();
            TopBorder topBorder59 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder59 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder59 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder59 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders58.Append(topBorder59);
            tableCellBorders58.Append(leftBorder59);
            tableCellBorders58.Append(bottomBorder59);
            tableCellBorders58.Append(rightBorder59);

            tableCellProperties58.Append(tableCellWidth58);
            tableCellProperties58.Append(tableCellBorders58);
            Paragraph paragraph91 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "686A8E8E", TextId = "77777777" };

            tableCell58.Append(tableCellProperties58);
            tableCell58.Append(paragraph91);

            TableCell tableCell59 = new TableCell();

            TableCellProperties tableCellProperties59 = new TableCellProperties();
            TableCellWidth tableCellWidth59 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders59 = new TableCellBorders();
            TopBorder topBorder60 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder60 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder60 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder60 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders59.Append(topBorder60);
            tableCellBorders59.Append(leftBorder60);
            tableCellBorders59.Append(bottomBorder60);
            tableCellBorders59.Append(rightBorder60);

            tableCellProperties59.Append(tableCellWidth59);
            tableCellProperties59.Append(tableCellBorders59);

            Paragraph paragraph92 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "5AEBC6B6", TextId = "77777777" };

            ParagraphProperties paragraphProperties63 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines63 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation58 = new Indentation() { Left = "144" };

            paragraphProperties63.Append(spacingBetweenLines63);
            paragraphProperties63.Append(indentation58);

            Run run168 = new Run();

            RunProperties runProperties168 = new RunProperties();
            Bold bold28 = new Bold();
            FontSize fontSize168 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript168 = new FontSizeComplexScript() { Val = "22" };

            runProperties168.Append(bold28);
            runProperties168.Append(fontSize168);
            runProperties168.Append(fontSizeComplexScript168);
            Text text168 = new Text();
            text168.Text = "Task information:";

            run168.Append(runProperties168);
            run168.Append(text168);

            paragraph92.Append(paragraphProperties63);
            paragraph92.Append(run168);

            Paragraph paragraph93 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "223307E4", TextId = "77777777" };

            ParagraphProperties paragraphProperties64 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines64 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation59 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties64.Append(spacingBetweenLines64);
            paragraphProperties64.Append(indentation59);

            Run run169 = new Run();

            RunProperties runProperties169 = new RunProperties();
            RunFonts runFonts67 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize169 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript169 = new FontSizeComplexScript() { Val = "14" };

            runProperties169.Append(runFonts67);
            runProperties169.Append(fontSize169);
            runProperties169.Append(fontSizeComplexScript169);
            Text text169 = new Text();
            text169.Text = "l";

            run169.Append(runProperties169);
            run169.Append(text169);

            Run run170 = new Run();

            RunProperties runProperties170 = new RunProperties();
            RunFonts runFonts68 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize170 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript170 = new FontSizeComplexScript() { Val = "14" };

            runProperties170.Append(runFonts68);
            runProperties170.Append(fontSize170);
            runProperties170.Append(fontSizeComplexScript170);
            Text text170 = new Text();
            text170.Text = " ";

            run170.Append(runProperties170);
            run170.Append(text170);

            Run run171 = new Run();

            RunProperties runProperties171 = new RunProperties();
            FontSize fontSize171 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript171 = new FontSizeComplexScript() { Val = "22" };

            runProperties171.Append(fontSize171);
            runProperties171.Append(fontSizeComplexScript171);
            Text text171 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text171.Text = " Development of investment strategies and policy for the development of agricultural investment holdings formation in Ukraine and Kazakhstan;";

            run171.Append(runProperties171);
            run171.Append(text171);

            paragraph93.Append(paragraphProperties64);
            paragraph93.Append(run169);
            paragraph93.Append(run170);
            paragraph93.Append(run171);

            Paragraph paragraph94 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "1AC26C27", TextId = "77777777" };

            ParagraphProperties paragraphProperties65 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines65 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation60 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties65.Append(spacingBetweenLines65);
            paragraphProperties65.Append(indentation60);

            Run run172 = new Run();

            RunProperties runProperties172 = new RunProperties();
            RunFonts runFonts69 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize172 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript172 = new FontSizeComplexScript() { Val = "14" };

            runProperties172.Append(runFonts69);
            runProperties172.Append(fontSize172);
            runProperties172.Append(fontSizeComplexScript172);
            Text text172 = new Text();
            text172.Text = "l";

            run172.Append(runProperties172);
            run172.Append(text172);

            Run run173 = new Run();

            RunProperties runProperties173 = new RunProperties();
            RunFonts runFonts70 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize173 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript173 = new FontSizeComplexScript() { Val = "14" };

            runProperties173.Append(runFonts70);
            runProperties173.Append(fontSize173);
            runProperties173.Append(fontSizeComplexScript173);
            Text text173 = new Text();
            text173.Text = " ";

            run173.Append(runProperties173);
            run173.Append(text173);

            Run run174 = new Run();

            RunProperties runProperties174 = new RunProperties();
            FontSize fontSize174 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript174 = new FontSizeComplexScript() { Val = "22" };

            runProperties174.Append(fontSize174);
            runProperties174.Append(fontSizeComplexScript174);
            Text text174 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text174.Text = " Investment and financial management planning, organization and implementation, selection and management of ";

            run174.Append(runProperties174);
            run174.Append(text174);
            ProofError proofError17 = new ProofError() { Type = ProofingErrorValues.GrammarStart };

            Run run175 = new Run();

            RunProperties runProperties175 = new RunProperties();
            FontSize fontSize175 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript175 = new FontSizeComplexScript() { Val = "22" };

            runProperties175.Append(fontSize175);
            runProperties175.Append(fontSizeComplexScript175);
            Text text175 = new Text();
            text175.Text = "top level";

            run175.Append(runProperties175);
            run175.Append(text175);
            ProofError proofError18 = new ProofError() { Type = ProofingErrorValues.GrammarEnd };

            Run run176 = new Run();

            RunProperties runProperties176 = new RunProperties();
            FontSize fontSize176 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript176 = new FontSizeComplexScript() { Val = "22" };

            runProperties176.Append(fontSize176);
            runProperties176.Append(fontSizeComplexScript176);
            Text text176 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text176.Text = " employees;";

            run176.Append(runProperties176);
            run176.Append(text176);

            paragraph94.Append(paragraphProperties65);
            paragraph94.Append(run172);
            paragraph94.Append(run173);
            paragraph94.Append(run174);
            paragraph94.Append(proofError17);
            paragraph94.Append(run175);
            paragraph94.Append(proofError18);
            paragraph94.Append(run176);

            Paragraph paragraph95 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "2FBBE218", TextId = "77777777" };

            ParagraphProperties paragraphProperties66 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines66 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation61 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties66.Append(spacingBetweenLines66);
            paragraphProperties66.Append(indentation61);

            Run run177 = new Run();

            RunProperties runProperties177 = new RunProperties();
            RunFonts runFonts71 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize177 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript177 = new FontSizeComplexScript() { Val = "14" };

            runProperties177.Append(runFonts71);
            runProperties177.Append(fontSize177);
            runProperties177.Append(fontSizeComplexScript177);
            Text text177 = new Text();
            text177.Text = "l";

            run177.Append(runProperties177);
            run177.Append(text177);

            Run run178 = new Run();

            RunProperties runProperties178 = new RunProperties();
            RunFonts runFonts72 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize178 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript178 = new FontSizeComplexScript() { Val = "14" };

            runProperties178.Append(runFonts72);
            runProperties178.Append(fontSize178);
            runProperties178.Append(fontSizeComplexScript178);
            Text text178 = new Text();
            text178.Text = " ";

            run178.Append(runProperties178);
            run178.Append(text178);

            Run run179 = new Run();

            RunProperties runProperties179 = new RunProperties();
            FontSize fontSize179 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript179 = new FontSizeComplexScript() { Val = "22" };

            runProperties179.Append(fontSize179);
            runProperties179.Append(fontSizeComplexScript179);
            Text text179 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text179.Text = " Acquisition and controlling of agribusiness assets; monitoring, controlling and consulting NCH venture partners in agricultural investment projects in Ukraine;";

            run179.Append(runProperties179);
            run179.Append(text179);

            paragraph95.Append(paragraphProperties66);
            paragraph95.Append(run177);
            paragraph95.Append(run178);
            paragraph95.Append(run179);

            Paragraph paragraph96 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "55DD88F6", TextId = "77777777" };

            ParagraphProperties paragraphProperties67 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines67 = new SpacingBetweenLines() { After = "200" };
            Indentation indentation62 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties67.Append(spacingBetweenLines67);
            paragraphProperties67.Append(indentation62);

            Run run180 = new Run();

            RunProperties runProperties180 = new RunProperties();
            RunFonts runFonts73 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize180 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript180 = new FontSizeComplexScript() { Val = "14" };

            runProperties180.Append(runFonts73);
            runProperties180.Append(fontSize180);
            runProperties180.Append(fontSizeComplexScript180);
            Text text180 = new Text();
            text180.Text = "l";

            run180.Append(runProperties180);
            run180.Append(text180);

            Run run181 = new Run();

            RunProperties runProperties181 = new RunProperties();
            RunFonts runFonts74 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize181 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript181 = new FontSizeComplexScript() { Val = "14" };

            runProperties181.Append(runFonts74);
            runProperties181.Append(fontSize181);
            runProperties181.Append(fontSizeComplexScript181);
            Text text181 = new Text();
            text181.Text = " ";

            run181.Append(runProperties181);
            run181.Append(text181);

            Run run182 = new Run();

            RunProperties runProperties182 = new RunProperties();
            FontSize fontSize182 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript182 = new FontSizeComplexScript() { Val = "22" };

            runProperties182.Append(fontSize182);
            runProperties182.Append(fontSizeComplexScript182);
            Text text182 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text182.Text = " Organizational management between NCH and fund venture partners in Ukraine. Total managed investment projects valued at approximately USD 450M.";

            run182.Append(runProperties182);
            run182.Append(text182);

            paragraph96.Append(paragraphProperties67);
            paragraph96.Append(run180);
            paragraph96.Append(run181);
            paragraph96.Append(run182);

            tableCell59.Append(tableCellProperties59);
            tableCell59.Append(paragraph92);
            tableCell59.Append(paragraph93);
            tableCell59.Append(paragraph94);
            tableCell59.Append(paragraph95);
            tableCell59.Append(paragraph96);

            tableRow30.Append(tableRowProperties29);
            tableRow30.Append(tableCell58);
            tableRow30.Append(tableCell59);

            TableRow tableRow31 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "60F936BB", TextId = "77777777" };

            TableRowProperties tableRowProperties30 = new TableRowProperties();
            GridAfter gridAfter30 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow30 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties30.Append(gridAfter30);
            tableRowProperties30.Append(widthAfterTableRow30);

            TableCell tableCell60 = new TableCell();

            TableCellProperties tableCellProperties60 = new TableCellProperties();
            TableCellWidth tableCellWidth60 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders60 = new TableCellBorders();
            TopBorder topBorder61 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder61 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder61 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder61 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders60.Append(topBorder61);
            tableCellBorders60.Append(leftBorder61);
            tableCellBorders60.Append(bottomBorder61);
            tableCellBorders60.Append(rightBorder61);

            tableCellProperties60.Append(tableCellWidth60);
            tableCellProperties60.Append(tableCellBorders60);
            Paragraph paragraph97 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "4E0AA166", TextId = "77777777" };

            tableCell60.Append(tableCellProperties60);
            tableCell60.Append(paragraph97);

            TableCell tableCell61 = new TableCell();

            TableCellProperties tableCellProperties61 = new TableCellProperties();
            TableCellWidth tableCellWidth61 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders61 = new TableCellBorders();
            TopBorder topBorder62 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder62 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder62 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder62 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders61.Append(topBorder62);
            tableCellBorders61.Append(leftBorder62);
            tableCellBorders61.Append(bottomBorder62);
            tableCellBorders61.Append(rightBorder62);

            tableCellProperties61.Append(tableCellWidth61);
            tableCellProperties61.Append(tableCellBorders61);

            Paragraph paragraph98 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "08DEA8AA", TextId = "45C07EDE" };

            ParagraphProperties paragraphProperties68 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines68 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation63 = new Indentation() { Left = "144" };

            paragraphProperties68.Append(spacingBetweenLines68);
            paragraphProperties68.Append(indentation63);

            Run run183 = new Run();

            RunProperties runProperties183 = new RunProperties();
            Bold bold29 = new Bold();
            FontSize fontSize183 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript183 = new FontSizeComplexScript() { Val = "22" };

            runProperties183.Append(bold29);
            runProperties183.Append(fontSize183);
            runProperties183.Append(fontSizeComplexScript183);
            Text text183 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text183.Text = "Reporting to: ";

            run183.Append(runProperties183);
            run183.Append(text183);

            Run run184 = new Run();

            RunProperties runProperties184 = new RunProperties();
            FontSize fontSize184 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript184 = new FontSizeComplexScript() { Val = "22" };

            runProperties184.Append(fontSize184);
            runProperties184.Append(fontSizeComplexScript184);
            Text text184 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text184.Text = "Mr. ";

            run184.Append(runProperties184);
            run184.Append(text184);

            paragraph98.Append(paragraphProperties68);
            paragraph98.Append(run183);
            paragraph98.Append(run184);

            tableCell61.Append(tableCellProperties61);
            tableCell61.Append(paragraph98);

            tableRow31.Append(tableRowProperties30);
            tableRow31.Append(tableCell60);
            tableRow31.Append(tableCell61);

            TableRow tableRow32 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "7A44BC0F", TextId = "77777777" };

            TableRowProperties tableRowProperties31 = new TableRowProperties();
            GridAfter gridAfter31 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow31 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties31.Append(gridAfter31);
            tableRowProperties31.Append(widthAfterTableRow31);

            TableCell tableCell62 = new TableCell();

            TableCellProperties tableCellProperties62 = new TableCellProperties();
            TableCellWidth tableCellWidth62 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders62 = new TableCellBorders();
            TopBorder topBorder63 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder63 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder63 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder63 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders62.Append(topBorder63);
            tableCellBorders62.Append(leftBorder63);
            tableCellBorders62.Append(bottomBorder63);
            tableCellBorders62.Append(rightBorder63);

            tableCellProperties62.Append(tableCellWidth62);
            tableCellProperties62.Append(tableCellBorders62);
            Paragraph paragraph99 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "53B58DE2", TextId = "77777777" };

            tableCell62.Append(tableCellProperties62);
            tableCell62.Append(paragraph99);

            TableCell tableCell63 = new TableCell();

            TableCellProperties tableCellProperties63 = new TableCellProperties();
            TableCellWidth tableCellWidth63 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders63 = new TableCellBorders();
            TopBorder topBorder64 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder64 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder64 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder64 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders63.Append(topBorder64);
            tableCellBorders63.Append(leftBorder64);
            tableCellBorders63.Append(bottomBorder64);
            tableCellBorders63.Append(rightBorder64);

            tableCellProperties63.Append(tableCellWidth63);
            tableCellProperties63.Append(tableCellBorders63);

            Paragraph paragraph100 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "5F0C69D3", TextId = "3008500D" };

            ParagraphProperties paragraphProperties69 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines69 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation64 = new Indentation() { Left = "144" };

            paragraphProperties69.Append(spacingBetweenLines69);
            paragraphProperties69.Append(indentation64);

            Run run185 = new Run();

            RunProperties runProperties185 = new RunProperties();
            Bold bold30 = new Bold();
            FontSize fontSize185 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript185 = new FontSizeComplexScript() { Val = "22" };

            runProperties185.Append(bold30);
            runProperties185.Append(fontSize185);
            runProperties185.Append(fontSizeComplexScript185);
            Text text185 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text185.Text = "Reason for leaving: ";

            run185.Append(runProperties185);
            run185.Append(text185);

            Run run186 = new Run();

            RunProperties runProperties186 = new RunProperties();
            FontSize fontSize186 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript186 = new FontSizeComplexScript() { Val = "22" };

            runProperties186.Append(fontSize186);
            runProperties186.Append(fontSizeComplexScript186);
            Text text186 = new Text();
            text186.Text = "Fund was fully invested, and no new funds would be opened.";

            run186.Append(runProperties186);
            run186.Append(text186);

            paragraph100.Append(paragraphProperties69);
            paragraph100.Append(run185);
            paragraph100.Append(run186);

            tableCell63.Append(tableCellProperties63);
            tableCell63.Append(paragraph100);

            tableRow32.Append(tableRowProperties31);
            tableRow32.Append(tableCell62);
            tableRow32.Append(tableCell63);

            TableRow tableRow33 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "4D46B74E", TextId = "77777777" };

            TableRowProperties tableRowProperties32 = new TableRowProperties();
            GridAfter gridAfter32 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow32 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties32.Append(gridAfter32);
            tableRowProperties32.Append(widthAfterTableRow32);

            TableCell tableCell64 = new TableCell();

            TableCellProperties tableCellProperties64 = new TableCellProperties();
            TableCellWidth tableCellWidth64 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders64 = new TableCellBorders();
            TopBorder topBorder65 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder65 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder65 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder65 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders64.Append(topBorder65);
            tableCellBorders64.Append(leftBorder65);
            tableCellBorders64.Append(bottomBorder65);
            tableCellBorders64.Append(rightBorder65);

            tableCellProperties64.Append(tableCellWidth64);
            tableCellProperties64.Append(tableCellBorders64);

            Paragraph paragraph101 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "395AA6E6", TextId = "77777777" };

            ParagraphProperties paragraphProperties70 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines70 = new SpacingBetweenLines() { Before = "30", After = "10" };

            paragraphProperties70.Append(spacingBetweenLines70);

            Run run187 = new Run();

            RunProperties runProperties187 = new RunProperties();
            FontSize fontSize187 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript187 = new FontSizeComplexScript() { Val = "22" };

            runProperties187.Append(fontSize187);
            runProperties187.Append(fontSizeComplexScript187);
            Text text187 = new Text();
            text187.Text = "1996 - 2012";

            run187.Append(runProperties187);
            run187.Append(text187);

            paragraph101.Append(paragraphProperties70);
            paragraph101.Append(run187);

            tableCell64.Append(tableCellProperties64);
            tableCell64.Append(paragraph101);

            TableCell tableCell65 = new TableCell();

            TableCellProperties tableCellProperties65 = new TableCellProperties();
            TableCellWidth tableCellWidth65 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders65 = new TableCellBorders();
            TopBorder topBorder66 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder66 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder66 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder66 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders65.Append(topBorder66);
            tableCellBorders65.Append(leftBorder66);
            tableCellBorders65.Append(bottomBorder66);
            tableCellBorders65.Append(rightBorder66);
            Shading shading6 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "0069B4" };

            tableCellProperties65.Append(tableCellWidth65);
            tableCellProperties65.Append(tableCellBorders65);
            tableCellProperties65.Append(shading6);

            Paragraph paragraph102 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "0007641E", ParagraphId = "65C18CE2", TextId = "0047D9B4" };

            ParagraphProperties paragraphProperties71 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines71 = new SpacingBetweenLines() { Before = "30", After = "10", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation65 = new Indentation() { Left = "144" };

            paragraphProperties71.Append(spacingBetweenLines71);
            paragraphProperties71.Append(indentation65);

            Run run188 = new Run();

            RunProperties runProperties188 = new RunProperties();
            Bold bold31 = new Bold();
            Color color8 = new Color() { Val = "FFFFFF" };
            FontSize fontSize188 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript188 = new FontSizeComplexScript() { Val = "21" };

            runProperties188.Append(bold31);
            runProperties188.Append(color8);
            runProperties188.Append(fontSize188);
            runProperties188.Append(fontSizeComplexScript188);
            Text text188 = new Text();
            text188.Text = "SIA M";

            run188.Append(runProperties188);
            run188.Append(text188);

            paragraph102.Append(paragraphProperties71);
            paragraph102.Append(run188);

            tableCell65.Append(tableCellProperties65);
            tableCell65.Append(paragraph102);

            tableRow33.Append(tableRowProperties32);
            tableRow33.Append(tableCell64);
            tableRow33.Append(tableCell65);

            TableRow tableRow34 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "6EC882F4", TextId = "77777777" };

            TableRowProperties tableRowProperties33 = new TableRowProperties();
            GridAfter gridAfter33 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow33 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties33.Append(gridAfter33);
            tableRowProperties33.Append(widthAfterTableRow33);

            TableCell tableCell66 = new TableCell();

            TableCellProperties tableCellProperties66 = new TableCellProperties();
            TableCellWidth tableCellWidth66 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders66 = new TableCellBorders();
            TopBorder topBorder67 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder67 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder67 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder67 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders66.Append(topBorder67);
            tableCellBorders66.Append(leftBorder67);
            tableCellBorders66.Append(bottomBorder67);
            tableCellBorders66.Append(rightBorder67);

            tableCellProperties66.Append(tableCellWidth66);
            tableCellProperties66.Append(tableCellBorders66);
            Paragraph paragraph103 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "2CF3192F", TextId = "77777777" };

            tableCell66.Append(tableCellProperties66);
            tableCell66.Append(paragraph103);

            TableCell tableCell67 = new TableCell();

            TableCellProperties tableCellProperties67 = new TableCellProperties();
            TableCellWidth tableCellWidth67 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders67 = new TableCellBorders();
            TopBorder topBorder68 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder68 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder68 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder68 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders67.Append(topBorder68);
            tableCellBorders67.Append(leftBorder68);
            tableCellBorders67.Append(bottomBorder68);
            tableCellBorders67.Append(rightBorder68);

            tableCellProperties67.Append(tableCellWidth67);
            tableCellProperties67.Append(tableCellBorders67);

            Paragraph paragraph104 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "0519DE7E", TextId = "77777777" };

            ParagraphProperties paragraphProperties72 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines72 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation66 = new Indentation() { Left = "144" };

            paragraphProperties72.Append(spacingBetweenLines72);
            paragraphProperties72.Append(indentation66);

            Run run189 = new Run();

            RunProperties runProperties189 = new RunProperties();
            Bold bold32 = new Bold();
            FontSize fontSize189 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript189 = new FontSizeComplexScript() { Val = "22" };

            runProperties189.Append(bold32);
            runProperties189.Append(fontSize189);
            runProperties189.Append(fontSizeComplexScript189);
            Text text189 = new Text();
            text189.Text = "Company information:";

            run189.Append(runProperties189);
            run189.Append(text189);

            paragraph104.Append(paragraphProperties72);
            paragraph104.Append(run189);

            Paragraph paragraph105 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "4C794703", TextId = "77777777" };

            ParagraphProperties paragraphProperties73 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines73 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation67 = new Indentation() { Left = "144" };

            paragraphProperties73.Append(spacingBetweenLines73);
            paragraphProperties73.Append(indentation67);

            Run run190 = new Run();

            RunProperties runProperties190 = new RunProperties();
            RunFonts runFonts75 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize190 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript190 = new FontSizeComplexScript() { Val = "14" };

            runProperties190.Append(runFonts75);
            runProperties190.Append(fontSize190);
            runProperties190.Append(fontSizeComplexScript190);
            Text text190 = new Text();
            text190.Text = "l";

            run190.Append(runProperties190);
            run190.Append(text190);

            Run run191 = new Run();

            RunProperties runProperties191 = new RunProperties();
            RunFonts runFonts76 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize191 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript191 = new FontSizeComplexScript() { Val = "14" };

            runProperties191.Append(runFonts76);
            runProperties191.Append(fontSize191);
            runProperties191.Append(fontSizeComplexScript191);
            Text text191 = new Text();
            text191.Text = " ";

            run191.Append(runProperties191);
            run191.Append(text191);

            Run run192 = new Run();

            RunProperties runProperties192 = new RunProperties();
            FontSize fontSize192 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript192 = new FontSizeComplexScript() { Val = "22" };

            runProperties192.Append(fontSize192);
            runProperties192.Append(fontSizeComplexScript192);
            Text text192 = new Text();
            text192.Text = "Parent company: NCH CAPITAL";

            run192.Append(runProperties192);
            run192.Append(text192);

            paragraph105.Append(paragraphProperties73);
            paragraph105.Append(run190);
            paragraph105.Append(run191);
            paragraph105.Append(run192);

            Paragraph paragraph106 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "63A6239E", TextId = "77777777" };

            ParagraphProperties paragraphProperties74 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines74 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation68 = new Indentation() { Left = "144" };

            paragraphProperties74.Append(spacingBetweenLines74);
            paragraphProperties74.Append(indentation68);

            Run run193 = new Run();

            RunProperties runProperties193 = new RunProperties();
            RunFonts runFonts77 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize193 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript193 = new FontSizeComplexScript() { Val = "14" };

            runProperties193.Append(runFonts77);
            runProperties193.Append(fontSize193);
            runProperties193.Append(fontSizeComplexScript193);
            Text text193 = new Text();
            text193.Text = "l";

            run193.Append(runProperties193);
            run193.Append(text193);

            Run run194 = new Run();

            RunProperties runProperties194 = new RunProperties();
            RunFonts runFonts78 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize194 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript194 = new FontSizeComplexScript() { Val = "14" };

            runProperties194.Append(runFonts78);
            runProperties194.Append(fontSize194);
            runProperties194.Append(fontSizeComplexScript194);
            Text text194 = new Text();
            text194.Text = " ";

            run194.Append(runProperties194);
            run194.Append(text194);

            Run run195 = new Run();

            RunProperties runProperties195 = new RunProperties();
            FontSize fontSize195 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript195 = new FontSizeComplexScript() { Val = "22" };

            runProperties195.Append(fontSize195);
            runProperties195.Append(fontSizeComplexScript195);
            Text text195 = new Text();
            text195.Text = "Industry: Financial Services / Insurance";

            run195.Append(runProperties195);
            run195.Append(text195);

            paragraph106.Append(paragraphProperties74);
            paragraph106.Append(run193);
            paragraph106.Append(run194);
            paragraph106.Append(run195);

            Paragraph paragraph107 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "77B142F4", TextId = "77777777" };

            ParagraphProperties paragraphProperties75 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines75 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation69 = new Indentation() { Left = "144" };

            paragraphProperties75.Append(spacingBetweenLines75);
            paragraphProperties75.Append(indentation69);

            Run run196 = new Run();

            RunProperties runProperties196 = new RunProperties();
            RunFonts runFonts79 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize196 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript196 = new FontSizeComplexScript() { Val = "14" };

            runProperties196.Append(runFonts79);
            runProperties196.Append(fontSize196);
            runProperties196.Append(fontSizeComplexScript196);
            Text text196 = new Text();
            text196.Text = "l";

            run196.Append(runProperties196);
            run196.Append(text196);

            Run run197 = new Run();

            RunProperties runProperties197 = new RunProperties();
            RunFonts runFonts80 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize197 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript197 = new FontSizeComplexScript() { Val = "14" };

            runProperties197.Append(runFonts80);
            runProperties197.Append(fontSize197);
            runProperties197.Append(fontSizeComplexScript197);
            Text text197 = new Text();
            text197.Text = " ";

            run197.Append(runProperties197);
            run197.Append(text197);

            Run run198 = new Run();

            RunProperties runProperties198 = new RunProperties();
            FontSize fontSize198 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript198 = new FontSizeComplexScript() { Val = "22" };

            runProperties198.Append(fontSize198);
            runProperties198.Append(fontSizeComplexScript198);
            Text text198 = new Text();
            text198.Text = "Services: Investment fund";

            run198.Append(runProperties198);
            run198.Append(text198);

            paragraph107.Append(paragraphProperties75);
            paragraph107.Append(run196);
            paragraph107.Append(run197);
            paragraph107.Append(run198);

            Paragraph paragraph108 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "666293AF", TextId = "77777777" };

            ParagraphProperties paragraphProperties76 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines76 = new SpacingBetweenLines() { After = "200" };
            Indentation indentation70 = new Indentation() { Left = "144" };

            paragraphProperties76.Append(spacingBetweenLines76);
            paragraphProperties76.Append(indentation70);

            Run run199 = new Run();

            RunProperties runProperties199 = new RunProperties();
            RunFonts runFonts81 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize199 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript199 = new FontSizeComplexScript() { Val = "14" };

            runProperties199.Append(runFonts81);
            runProperties199.Append(fontSize199);
            runProperties199.Append(fontSizeComplexScript199);
            Text text199 = new Text();
            text199.Text = "l";

            run199.Append(runProperties199);
            run199.Append(text199);

            Run run200 = new Run();

            RunProperties runProperties200 = new RunProperties();
            RunFonts runFonts82 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize200 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript200 = new FontSizeComplexScript() { Val = "14" };

            runProperties200.Append(runFonts82);
            runProperties200.Append(fontSize200);
            runProperties200.Append(fontSizeComplexScript200);
            Text text200 = new Text();
            text200.Text = " ";

            run200.Append(runProperties200);
            run200.Append(text200);

            Run run201 = new Run();

            RunProperties runProperties201 = new RunProperties();
            FontSize fontSize201 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript201 = new FontSizeComplexScript() { Val = "22" };

            runProperties201.Append(fontSize201);
            runProperties201.Append(fontSizeComplexScript201);
            Text text201 = new Text();
            text201.Text = "Number of employees: ~ 10";

            run201.Append(runProperties201);
            run201.Append(text201);

            paragraph108.Append(paragraphProperties76);
            paragraph108.Append(run199);
            paragraph108.Append(run200);
            paragraph108.Append(run201);

            tableCell67.Append(tableCellProperties67);
            tableCell67.Append(paragraph104);
            tableCell67.Append(paragraph105);
            tableCell67.Append(paragraph106);
            tableCell67.Append(paragraph107);
            tableCell67.Append(paragraph108);

            tableRow34.Append(tableRowProperties33);
            tableRow34.Append(tableCell66);
            tableRow34.Append(tableCell67);

            TableRow tableRow35 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "751426C8", TextId = "77777777" };

            TableRowProperties tableRowProperties34 = new TableRowProperties();
            GridAfter gridAfter34 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow34 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties34.Append(gridAfter34);
            tableRowProperties34.Append(widthAfterTableRow34);

            TableCell tableCell68 = new TableCell();

            TableCellProperties tableCellProperties68 = new TableCellProperties();
            TableCellWidth tableCellWidth68 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders68 = new TableCellBorders();
            TopBorder topBorder69 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder69 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder69 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder69 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders68.Append(topBorder69);
            tableCellBorders68.Append(leftBorder69);
            tableCellBorders68.Append(bottomBorder69);
            tableCellBorders68.Append(rightBorder69);

            tableCellProperties68.Append(tableCellWidth68);
            tableCellProperties68.Append(tableCellBorders68);
            Paragraph paragraph109 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "1D54B770", TextId = "77777777" };

            tableCell68.Append(tableCellProperties68);
            tableCell68.Append(paragraph109);

            TableCell tableCell69 = new TableCell();

            TableCellProperties tableCellProperties69 = new TableCellProperties();
            TableCellWidth tableCellWidth69 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders69 = new TableCellBorders();
            TopBorder topBorder70 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder70 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder70 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder70 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders69.Append(topBorder70);
            tableCellBorders69.Append(leftBorder70);
            tableCellBorders69.Append(bottomBorder70);
            tableCellBorders69.Append(rightBorder70);

            tableCellProperties69.Append(tableCellWidth69);
            tableCellProperties69.Append(tableCellBorders69);

            Paragraph paragraph110 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "560E13A3", TextId = "77777777" };

            ParagraphProperties paragraphProperties77 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines77 = new SpacingBetweenLines() { After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation71 = new Indentation() { Left = "144" };

            paragraphProperties77.Append(spacingBetweenLines77);
            paragraphProperties77.Append(indentation71);

            Run run202 = new Run();

            RunProperties runProperties202 = new RunProperties();
            Bold bold33 = new Bold();
            FontSize fontSize202 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript202 = new FontSizeComplexScript() { Val = "21" };

            runProperties202.Append(bold33);
            runProperties202.Append(fontSize202);
            runProperties202.Append(fontSizeComplexScript202);
            Text text202 = new Text();
            text202.Text = "INVESTMENT MANAGER/FINANCIER";

            run202.Append(runProperties202);
            run202.Append(text202);

            Run run203 = new Run();

            RunProperties runProperties203 = new RunProperties();
            FontSize fontSize203 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript203 = new FontSizeComplexScript() { Val = "21" };

            runProperties203.Append(fontSize203);
            runProperties203.Append(fontSizeComplexScript203);
            Text text203 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text203.Text = " (";

            run203.Append(runProperties203);
            run203.Append(text203);

            Run run204 = new Run();

            RunProperties runProperties204 = new RunProperties();
            Italic italic6 = new Italic();
            ItalicComplexScript italicComplexScript6 = new ItalicComplexScript();
            FontSize fontSize204 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript204 = new FontSizeComplexScript() { Val = "21" };

            runProperties204.Append(italic6);
            runProperties204.Append(italicComplexScript6);
            runProperties204.Append(fontSize204);
            runProperties204.Append(fontSizeComplexScript204);
            Text text204 = new Text();
            text204.Text = "1996 - 2012";

            run204.Append(runProperties204);
            run204.Append(text204);

            Run run205 = new Run();

            RunProperties runProperties205 = new RunProperties();
            FontSize fontSize205 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript205 = new FontSizeComplexScript() { Val = "21" };

            runProperties205.Append(fontSize205);
            runProperties205.Append(fontSizeComplexScript205);
            Text text205 = new Text();
            text205.Text = ")";

            run205.Append(runProperties205);
            run205.Append(text205);

            paragraph110.Append(paragraphProperties77);
            paragraph110.Append(run202);
            paragraph110.Append(run203);
            paragraph110.Append(run204);
            paragraph110.Append(run205);

            tableCell69.Append(tableCellProperties69);
            tableCell69.Append(paragraph110);

            tableRow35.Append(tableRowProperties34);
            tableRow35.Append(tableCell68);
            tableRow35.Append(tableCell69);

            TableRow tableRow36 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "32ECDD7E", TextId = "77777777" };

            TableRowProperties tableRowProperties35 = new TableRowProperties();
            GridAfter gridAfter35 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow35 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties35.Append(gridAfter35);
            tableRowProperties35.Append(widthAfterTableRow35);

            TableCell tableCell70 = new TableCell();

            TableCellProperties tableCellProperties70 = new TableCellProperties();
            TableCellWidth tableCellWidth70 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders70 = new TableCellBorders();
            TopBorder topBorder71 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder71 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder71 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder71 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders70.Append(topBorder71);
            tableCellBorders70.Append(leftBorder71);
            tableCellBorders70.Append(bottomBorder71);
            tableCellBorders70.Append(rightBorder71);

            tableCellProperties70.Append(tableCellWidth70);
            tableCellProperties70.Append(tableCellBorders70);
            Paragraph paragraph111 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "2120CD4E", TextId = "77777777" };

            tableCell70.Append(tableCellProperties70);
            tableCell70.Append(paragraph111);

            TableCell tableCell71 = new TableCell();

            TableCellProperties tableCellProperties71 = new TableCellProperties();
            TableCellWidth tableCellWidth71 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders71 = new TableCellBorders();
            TopBorder topBorder72 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder72 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder72 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder72 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders71.Append(topBorder72);
            tableCellBorders71.Append(leftBorder72);
            tableCellBorders71.Append(bottomBorder72);
            tableCellBorders71.Append(rightBorder72);

            tableCellProperties71.Append(tableCellWidth71);
            tableCellProperties71.Append(tableCellBorders71);

            Paragraph paragraph112 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "0270EC8D", TextId = "77777777" };

            ParagraphProperties paragraphProperties78 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines78 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation72 = new Indentation() { Left = "144" };

            paragraphProperties78.Append(spacingBetweenLines78);
            paragraphProperties78.Append(indentation72);

            Run run206 = new Run();

            RunProperties runProperties206 = new RunProperties();
            Bold bold34 = new Bold();
            FontSize fontSize206 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript206 = new FontSizeComplexScript() { Val = "22" };

            runProperties206.Append(bold34);
            runProperties206.Append(fontSize206);
            runProperties206.Append(fontSizeComplexScript206);
            Text text206 = new Text();
            text206.Text = "Task information:";

            run206.Append(runProperties206);
            run206.Append(text206);

            paragraph112.Append(paragraphProperties78);
            paragraph112.Append(run206);

            Paragraph paragraph113 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "412F8E13", TextId = "4FDEB76C" };

            ParagraphProperties paragraphProperties79 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines79 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation73 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties79.Append(spacingBetweenLines79);
            paragraphProperties79.Append(indentation73);

            Run run207 = new Run();

            RunProperties runProperties207 = new RunProperties();
            RunFonts runFonts83 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize207 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript207 = new FontSizeComplexScript() { Val = "14" };

            runProperties207.Append(runFonts83);
            runProperties207.Append(fontSize207);
            runProperties207.Append(fontSizeComplexScript207);
            Text text207 = new Text();
            text207.Text = "l";

            run207.Append(runProperties207);
            run207.Append(text207);

            Run run208 = new Run();

            RunProperties runProperties208 = new RunProperties();
            RunFonts runFonts84 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize208 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript208 = new FontSizeComplexScript() { Val = "14" };

            runProperties208.Append(runFonts84);
            runProperties208.Append(fontSize208);
            runProperties208.Append(fontSizeComplexScript208);
            Text text208 = new Text();
            text208.Text = " ";

            run208.Append(runProperties208);
            run208.Append(text208);

            Run run209 = new Run();

            RunProperties runProperties209 = new RunProperties();
            FontSize fontSize209 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript209 = new FontSizeComplexScript() { Val = "22" };

            runProperties209.Append(fontSize209);
            runProperties209.Append(fontSizeComplexScript209);
            Text text209 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text209.Text = " Investment distribution of more than USD 350M through the capital and real estate investments in the Baltic region for one of the largest and most experienced Western investors in the former Soviet Union a US based investment fund New Century Holdings (more than 20 sub funds) with over $5 billion assets under management;";

            run209.Append(runProperties209);
            run209.Append(text209);

            paragraph113.Append(paragraphProperties79);
            paragraph113.Append(run207);
            paragraph113.Append(run208);
            paragraph113.Append(run209);

            Paragraph paragraph114 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "586A593A", TextId = "77777777" };

            ParagraphProperties paragraphProperties80 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines80 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation74 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties80.Append(spacingBetweenLines80);
            paragraphProperties80.Append(indentation74);

            Run run210 = new Run();

            RunProperties runProperties210 = new RunProperties();
            RunFonts runFonts85 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize210 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript210 = new FontSizeComplexScript() { Val = "14" };

            runProperties210.Append(runFonts85);
            runProperties210.Append(fontSize210);
            runProperties210.Append(fontSizeComplexScript210);
            Text text210 = new Text();
            text210.Text = "l";

            run210.Append(runProperties210);
            run210.Append(text210);

            Run run211 = new Run();

            RunProperties runProperties211 = new RunProperties();
            RunFonts runFonts86 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize211 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript211 = new FontSizeComplexScript() { Val = "14" };

            runProperties211.Append(runFonts86);
            runProperties211.Append(fontSize211);
            runProperties211.Append(fontSizeComplexScript211);
            Text text211 = new Text();
            text211.Text = " ";

            run211.Append(runProperties211);
            run211.Append(text211);

            Run run212 = new Run();

            RunProperties runProperties212 = new RunProperties();
            FontSize fontSize212 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript212 = new FontSizeComplexScript() { Val = "22" };

            runProperties212.Append(fontSize212);
            runProperties212.Append(fontSizeComplexScript212);
            Text text212 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text212.Text = " Managed potential public, direct equity and real estate investment objects due diligence, managing of research projects, financial and investment risk analysis and related evaluation;";

            run212.Append(runProperties212);
            run212.Append(text212);

            paragraph114.Append(paragraphProperties80);
            paragraph114.Append(run210);
            paragraph114.Append(run211);
            paragraph114.Append(run212);

            Paragraph paragraph115 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "02EDED40", TextId = "77777777" };

            ParagraphProperties paragraphProperties81 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines81 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation75 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties81.Append(spacingBetweenLines81);
            paragraphProperties81.Append(indentation75);

            Run run213 = new Run();

            RunProperties runProperties213 = new RunProperties();
            RunFonts runFonts87 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize213 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript213 = new FontSizeComplexScript() { Val = "14" };

            runProperties213.Append(runFonts87);
            runProperties213.Append(fontSize213);
            runProperties213.Append(fontSizeComplexScript213);
            Text text213 = new Text();
            text213.Text = "l";

            run213.Append(runProperties213);
            run213.Append(text213);

            Run run214 = new Run();

            RunProperties runProperties214 = new RunProperties();
            RunFonts runFonts88 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize214 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript214 = new FontSizeComplexScript() { Val = "14" };

            runProperties214.Append(runFonts88);
            runProperties214.Append(fontSize214);
            runProperties214.Append(fontSizeComplexScript214);
            Text text214 = new Text();
            text214.Text = " ";

            run214.Append(runProperties214);
            run214.Append(text214);

            Run run215 = new Run();

            RunProperties runProperties215 = new RunProperties();
            FontSize fontSize215 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript215 = new FontSizeComplexScript() { Val = "22" };

            runProperties215.Append(fontSize215);
            runProperties215.Append(fontSizeComplexScript215);
            Text text215 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text215.Text = " Negotiated investment terms with selected companies; performed investments structuring, incl. business plans, financial and tax strategies; implementation of financial performance control, incl. budgeting, auditing, etc.;";

            run215.Append(runProperties215);
            run215.Append(text215);

            paragraph115.Append(paragraphProperties81);
            paragraph115.Append(run213);
            paragraph115.Append(run214);
            paragraph115.Append(run215);

            Paragraph paragraph116 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "7CB3684B", TextId = "77777777" };

            ParagraphProperties paragraphProperties82 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines82 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation76 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties82.Append(spacingBetweenLines82);
            paragraphProperties82.Append(indentation76);

            Run run216 = new Run();

            RunProperties runProperties216 = new RunProperties();
            RunFonts runFonts89 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize216 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript216 = new FontSizeComplexScript() { Val = "14" };

            runProperties216.Append(runFonts89);
            runProperties216.Append(fontSize216);
            runProperties216.Append(fontSizeComplexScript216);
            Text text216 = new Text();
            text216.Text = "l";

            run216.Append(runProperties216);
            run216.Append(text216);

            Run run217 = new Run();

            RunProperties runProperties217 = new RunProperties();
            RunFonts runFonts90 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize217 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript217 = new FontSizeComplexScript() { Val = "14" };

            runProperties217.Append(runFonts90);
            runProperties217.Append(fontSize217);
            runProperties217.Append(fontSizeComplexScript217);
            Text text217 = new Text();
            text217.Text = " ";

            run217.Append(runProperties217);
            run217.Append(text217);

            Run run218 = new Run();

            RunProperties runProperties218 = new RunProperties();
            FontSize fontSize218 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript218 = new FontSizeComplexScript() { Val = "22" };

            runProperties218.Append(fontSize218);
            runProperties218.Append(fontSizeComplexScript218);
            Text text218 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text218.Text = " Managed NCH equity investments in public markets (bonds; equity);";

            run218.Append(runProperties218);
            run218.Append(text218);

            paragraph116.Append(paragraphProperties82);
            paragraph116.Append(run216);
            paragraph116.Append(run217);
            paragraph116.Append(run218);

            Paragraph paragraph117 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "09B5005C", TextId = "7904D4E8" };

            ParagraphProperties paragraphProperties83 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines83 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation77 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties83.Append(spacingBetweenLines83);
            paragraphProperties83.Append(indentation77);

            Run run219 = new Run();

            RunProperties runProperties219 = new RunProperties();
            RunFonts runFonts91 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize219 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript219 = new FontSizeComplexScript() { Val = "14" };

            runProperties219.Append(runFonts91);
            runProperties219.Append(fontSize219);
            runProperties219.Append(fontSizeComplexScript219);
            Text text219 = new Text();
            text219.Text = "l";

            run219.Append(runProperties219);
            run219.Append(text219);

            Run run220 = new Run();

            RunProperties runProperties220 = new RunProperties();
            RunFonts runFonts92 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize220 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript220 = new FontSizeComplexScript() { Val = "14" };

            runProperties220.Append(runFonts92);
            runProperties220.Append(fontSize220);
            runProperties220.Append(fontSizeComplexScript220);
            Text text220 = new Text();
            text220.Text = " ";

            run220.Append(runProperties220);
            run220.Append(text220);

            Run run221 = new Run();

            RunProperties runProperties221 = new RunProperties();
            FontSize fontSize221 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript221 = new FontSizeComplexScript() { Val = "22" };

            runProperties221.Append(fontSize221);
            runProperties221.Append(fontSizeComplexScript221);
            Text text221 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text221.Text = " Managed and supervised investments made by NCH during the investment period, exit management of any type of investments;";

            run221.Append(runProperties221);
            run221.Append(text221);

            paragraph117.Append(paragraphProperties83);
            paragraph117.Append(run219);
            paragraph117.Append(run220);
            paragraph117.Append(run221);

            Paragraph paragraph118 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "7FDB7E3E", TextId = "77777777" };

            ParagraphProperties paragraphProperties84 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines84 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation78 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties84.Append(spacingBetweenLines84);
            paragraphProperties84.Append(indentation78);

            Run run222 = new Run();

            RunProperties runProperties222 = new RunProperties();
            RunFonts runFonts93 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize222 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript222 = new FontSizeComplexScript() { Val = "14" };

            runProperties222.Append(runFonts93);
            runProperties222.Append(fontSize222);
            runProperties222.Append(fontSizeComplexScript222);
            Text text222 = new Text();
            text222.Text = "l";

            run222.Append(runProperties222);
            run222.Append(text222);

            Run run223 = new Run();

            RunProperties runProperties223 = new RunProperties();
            RunFonts runFonts94 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize223 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript223 = new FontSizeComplexScript() { Val = "14" };

            runProperties223.Append(runFonts94);
            runProperties223.Append(fontSize223);
            runProperties223.Append(fontSizeComplexScript223);
            Text text223 = new Text();
            text223.Text = " ";

            run223.Append(runProperties223);
            run223.Append(text223);

            Run run224 = new Run();

            RunProperties runProperties224 = new RunProperties();
            FontSize fontSize224 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript224 = new FontSizeComplexScript() { Val = "22" };

            runProperties224.Append(fontSize224);
            runProperties224.Append(fontSizeComplexScript224);
            Text text224 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text224.Text = " Representing interests of NCH on boards, councils and shareholder meetings of several companies (incl. the banking and insurance sectors);";

            run224.Append(runProperties224);
            run224.Append(text224);

            paragraph118.Append(paragraphProperties84);
            paragraph118.Append(run222);
            paragraph118.Append(run223);
            paragraph118.Append(run224);

            Paragraph paragraph119 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "228712E7", TextId = "77777777" };

            ParagraphProperties paragraphProperties85 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines85 = new SpacingBetweenLines() { After = "200" };
            Indentation indentation79 = new Indentation() { Left = "413", Hanging = "269" };

            paragraphProperties85.Append(spacingBetweenLines85);
            paragraphProperties85.Append(indentation79);

            Run run225 = new Run();

            RunProperties runProperties225 = new RunProperties();
            RunFonts runFonts95 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize225 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript225 = new FontSizeComplexScript() { Val = "14" };

            runProperties225.Append(runFonts95);
            runProperties225.Append(fontSize225);
            runProperties225.Append(fontSizeComplexScript225);
            Text text225 = new Text();
            text225.Text = "l";

            run225.Append(runProperties225);
            run225.Append(text225);

            Run run226 = new Run();

            RunProperties runProperties226 = new RunProperties();
            RunFonts runFonts96 = new RunFonts() { Ascii = "Wingdings", HighAnsi = "Wingdings", EastAsia = "Wingdings", ComplexScript = "Wingdings" };
            FontSize fontSize226 = new FontSize() { Val = "14" };
            FontSizeComplexScript fontSizeComplexScript226 = new FontSizeComplexScript() { Val = "14" };

            runProperties226.Append(runFonts96);
            runProperties226.Append(fontSize226);
            runProperties226.Append(fontSizeComplexScript226);
            Text text226 = new Text();
            text226.Text = " ";

            run226.Append(runProperties226);
            run226.Append(text226);

            Run run227 = new Run();

            RunProperties runProperties227 = new RunProperties();
            FontSize fontSize227 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript227 = new FontSizeComplexScript() { Val = "22" };

            runProperties227.Append(fontSize227);
            runProperties227.Append(fontSizeComplexScript227);
            Text text227 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text227.Text = " Managed the preparation of investment reports and submitted them to the head NCH office in New York City. ";

            run227.Append(runProperties227);
            run227.Append(text227);

            paragraph119.Append(paragraphProperties85);
            paragraph119.Append(run225);
            paragraph119.Append(run226);
            paragraph119.Append(run227);

            tableCell71.Append(tableCellProperties71);
            tableCell71.Append(paragraph112);
            tableCell71.Append(paragraph113);
            tableCell71.Append(paragraph114);
            tableCell71.Append(paragraph115);
            tableCell71.Append(paragraph116);
            tableCell71.Append(paragraph117);
            tableCell71.Append(paragraph118);
            tableCell71.Append(paragraph119);

            tableRow36.Append(tableRowProperties35);
            tableRow36.Append(tableCell70);
            tableRow36.Append(tableCell71);

            TableRow tableRow37 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "4CCC3240", TextId = "77777777" };

            TableRowProperties tableRowProperties36 = new TableRowProperties();
            GridAfter gridAfter36 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow36 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties36.Append(gridAfter36);
            tableRowProperties36.Append(widthAfterTableRow36);

            TableCell tableCell72 = new TableCell();

            TableCellProperties tableCellProperties72 = new TableCellProperties();
            TableCellWidth tableCellWidth72 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders72 = new TableCellBorders();
            TopBorder topBorder73 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder73 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder73 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder73 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders72.Append(topBorder73);
            tableCellBorders72.Append(leftBorder73);
            tableCellBorders72.Append(bottomBorder73);
            tableCellBorders72.Append(rightBorder73);

            tableCellProperties72.Append(tableCellWidth72);
            tableCellProperties72.Append(tableCellBorders72);
            Paragraph paragraph120 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "43F9FFBE", TextId = "77777777" };

            tableCell72.Append(tableCellProperties72);
            tableCell72.Append(paragraph120);

            TableCell tableCell73 = new TableCell();

            TableCellProperties tableCellProperties73 = new TableCellProperties();
            TableCellWidth tableCellWidth73 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders73 = new TableCellBorders();
            TopBorder topBorder74 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder74 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder74 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder74 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders73.Append(topBorder74);
            tableCellBorders73.Append(leftBorder74);
            tableCellBorders73.Append(bottomBorder74);
            tableCellBorders73.Append(rightBorder74);

            tableCellProperties73.Append(tableCellWidth73);
            tableCellProperties73.Append(tableCellBorders73);

            Paragraph paragraph121 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "68D4F51C", TextId = "5F778490" };

            ParagraphProperties paragraphProperties86 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines86 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation80 = new Indentation() { Left = "144" };

            paragraphProperties86.Append(spacingBetweenLines86);
            paragraphProperties86.Append(indentation80);

            Run run228 = new Run();

            RunProperties runProperties228 = new RunProperties();
            Bold bold35 = new Bold();
            FontSize fontSize228 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript228 = new FontSizeComplexScript() { Val = "22" };

            runProperties228.Append(bold35);
            runProperties228.Append(fontSize228);
            runProperties228.Append(fontSizeComplexScript228);
            Text text228 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text228.Text = "Reporting to: ";

            run228.Append(runProperties228);
            run228.Append(text228);

            Run run229 = new Run();

            RunProperties runProperties229 = new RunProperties();
            FontSize fontSize229 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript229 = new FontSizeComplexScript() { Val = "22" };

            runProperties229.Append(fontSize229);
            runProperties229.Append(fontSizeComplexScript229);
            Text text229 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text229.Text = "Mr. ";

            run229.Append(runProperties229);
            run229.Append(text229);

            paragraph121.Append(paragraphProperties86);
            paragraph121.Append(run228);
            paragraph121.Append(run229);

            tableCell73.Append(tableCellProperties73);
            tableCell73.Append(paragraph121);

            tableRow37.Append(tableRowProperties36);
            tableRow37.Append(tableCell72);
            tableRow37.Append(tableCell73);

            TableRow tableRow38 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "3449418A", TextId = "77777777" };

            TableRowProperties tableRowProperties37 = new TableRowProperties();
            GridAfter gridAfter37 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow37 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties37.Append(gridAfter37);
            tableRowProperties37.Append(widthAfterTableRow37);

            TableCell tableCell74 = new TableCell();

            TableCellProperties tableCellProperties74 = new TableCellProperties();
            TableCellWidth tableCellWidth74 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders74 = new TableCellBorders();
            TopBorder topBorder75 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder75 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder75 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder75 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders74.Append(topBorder75);
            tableCellBorders74.Append(leftBorder75);
            tableCellBorders74.Append(bottomBorder75);
            tableCellBorders74.Append(rightBorder75);

            tableCellProperties74.Append(tableCellWidth74);
            tableCellProperties74.Append(tableCellBorders74);
            Paragraph paragraph122 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "50B09D7C", TextId = "77777777" };

            tableCell74.Append(tableCellProperties74);
            tableCell74.Append(paragraph122);

            TableCell tableCell75 = new TableCell();

            TableCellProperties tableCellProperties75 = new TableCellProperties();
            TableCellWidth tableCellWidth75 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders75 = new TableCellBorders();
            TopBorder topBorder76 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder76 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder76 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder76 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders75.Append(topBorder76);
            tableCellBorders75.Append(leftBorder76);
            tableCellBorders75.Append(bottomBorder76);
            tableCellBorders75.Append(rightBorder76);

            tableCellProperties75.Append(tableCellWidth75);
            tableCellProperties75.Append(tableCellBorders75);

            Paragraph paragraph123 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "04F48970", TextId = "0089615D" };

            ParagraphProperties paragraphProperties87 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines87 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation81 = new Indentation() { Left = "144" };

            paragraphProperties87.Append(spacingBetweenLines87);
            paragraphProperties87.Append(indentation81);

            Run run230 = new Run();

            RunProperties runProperties230 = new RunProperties();
            Bold bold36 = new Bold();
            FontSize fontSize230 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript230 = new FontSizeComplexScript() { Val = "22" };

            runProperties230.Append(bold36);
            runProperties230.Append(fontSize230);
            runProperties230.Append(fontSizeComplexScript230);
            Text text230 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text230.Text = "Reason for leaving: ";

            run230.Append(runProperties230);
            run230.Append(text230);

            Run run231 = new Run();

            RunProperties runProperties231 = new RunProperties();
            FontSize fontSize231 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript231 = new FontSizeComplexScript() { Val = "22" };

            runProperties231.Append(fontSize231);
            runProperties231.Append(fontSizeComplexScript231);
            Text text231 = new Text();
            text231.Text = "Fund was fully invested, and no new funds would be opened.";

            run231.Append(runProperties231);
            run231.Append(text231);

            paragraph123.Append(paragraphProperties87);
            paragraph123.Append(run230);
            paragraph123.Append(run231);

            tableCell75.Append(tableCellProperties75);
            tableCell75.Append(paragraph123);

            tableRow38.Append(tableRowProperties37);
            tableRow38.Append(tableCell74);
            tableRow38.Append(tableCell75);

            TableRow tableRow39 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "549FE295", TextId = "77777777" };

            TableRowProperties tableRowProperties38 = new TableRowProperties();
            GridAfter gridAfter38 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow38 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties38.Append(gridAfter38);
            tableRowProperties38.Append(widthAfterTableRow38);

            TableCell tableCell76 = new TableCell();

            TableCellProperties tableCellProperties76 = new TableCellProperties();
            TableCellWidth tableCellWidth76 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders76 = new TableCellBorders();
            TopBorder topBorder77 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder77 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder77 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder77 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders76.Append(topBorder77);
            tableCellBorders76.Append(leftBorder77);
            tableCellBorders76.Append(bottomBorder77);
            tableCellBorders76.Append(rightBorder77);

            tableCellProperties76.Append(tableCellWidth76);
            tableCellProperties76.Append(tableCellBorders76);
            Paragraph paragraph124 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "79641948", TextId = "77777777" };

            tableCell76.Append(tableCellProperties76);
            tableCell76.Append(paragraph124);

            TableCell tableCell77 = new TableCell();

            TableCellProperties tableCellProperties77 = new TableCellProperties();
            TableCellWidth tableCellWidth77 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders77 = new TableCellBorders();
            TopBorder topBorder78 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder78 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder78 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder78 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders77.Append(topBorder78);
            tableCellBorders77.Append(leftBorder78);
            tableCellBorders77.Append(bottomBorder78);
            tableCellBorders77.Append(rightBorder78);

            tableCellProperties77.Append(tableCellWidth77);
            tableCellProperties77.Append(tableCellBorders77);
            Paragraph paragraph125 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "03280296", TextId = "77777777" };
            Paragraph paragraph126 = new Paragraph() { RsidParagraphAddition = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "300F77D7", TextId = "77777777" };
            Paragraph paragraph127 = new Paragraph() { RsidParagraphAddition = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "19BFA0FA", TextId = "77777777" };
            Paragraph paragraph128 = new Paragraph() { RsidParagraphAddition = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "102ACA4F", TextId = "5C754407" };

            tableCell77.Append(tableCellProperties77);
            tableCell77.Append(paragraph125);
            tableCell77.Append(paragraph126);
            tableCell77.Append(paragraph127);
            tableCell77.Append(paragraph128);

            tableRow39.Append(tableRowProperties38);
            tableRow39.Append(tableCell76);
            tableRow39.Append(tableCell77);

            table1.Append(tableProperties1);
            table1.Append(tableGrid1);
            table1.Append(tableRow1);
            table1.Append(tableRow2);
            table1.Append(tableRow3);
            table1.Append(tableRow4);
            table1.Append(tableRow5);
            table1.Append(tableRow6);
            table1.Append(tableRow7);
            table1.Append(tableRow8);
            table1.Append(tableRow9);
            table1.Append(tableRow10);
            table1.Append(tableRow11);
            table1.Append(tableRow12);
            table1.Append(tableRow13);
            table1.Append(tableRow14);
            table1.Append(tableRow15);
            table1.Append(tableRow16);
            table1.Append(tableRow17);
            table1.Append(tableRow18);
            table1.Append(tableRow19);
            table1.Append(tableRow20);
            table1.Append(tableRow21);
            table1.Append(tableRow22);
            table1.Append(tableRow23);
            table1.Append(tableRow24);
            table1.Append(tableRow25);
            table1.Append(tableRow26);
            table1.Append(tableRow27);
            table1.Append(tableRow28);
            table1.Append(tableRow29);
            table1.Append(tableRow30);
            table1.Append(tableRow31);
            table1.Append(tableRow32);
            table1.Append(tableRow33);
            table1.Append(tableRow34);
            table1.Append(tableRow35);
            table1.Append(tableRow36);
            table1.Append(tableRow37);
            table1.Append(tableRow38);
            table1.Append(tableRow39);
            return table1;
        }


    }
}
