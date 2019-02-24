using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using Wp = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using A = DocumentFormat.OpenXml.Drawing;
using Pic = DocumentFormat.OpenXml.Drawing.Pictures;
using A14 = DocumentFormat.OpenXml.Office2010.Drawing;

namespace CV.Management.Generation.Word.ContentHelper
{
    public static class ContentTable6
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
            GridColumn gridColumn1 = new GridColumn() { Width = "1263" };
            GridColumn gridColumn2 = new GridColumn() { Width = "771" };
            GridColumn gridColumn3 = new GridColumn() { Width = "771" };
            GridColumn gridColumn4 = new GridColumn() { Width = "771" };
            GridColumn gridColumn5 = new GridColumn() { Width = "772" };
            GridColumn gridColumn6 = new GridColumn() { Width = "772" };
            GridColumn gridColumn7 = new GridColumn() { Width = "772" };
            GridColumn gridColumn8 = new GridColumn() { Width = "772" };
            GridColumn gridColumn9 = new GridColumn() { Width = "772" };
            GridColumn gridColumn10 = new GridColumn() { Width = "772" };
            GridColumn gridColumn11 = new GridColumn() { Width = "772" };

            tableGrid1.Append(gridColumn1);
            tableGrid1.Append(gridColumn2);
            tableGrid1.Append(gridColumn3);
            tableGrid1.Append(gridColumn4);
            tableGrid1.Append(gridColumn5);
            tableGrid1.Append(gridColumn6);
            tableGrid1.Append(gridColumn7);
            tableGrid1.Append(gridColumn8);
            tableGrid1.Append(gridColumn9);
            tableGrid1.Append(gridColumn10);
            tableGrid1.Append(gridColumn11);

            //

            TableRow tableRow3 = new TableRow() { RsidTableRowAddition = "009B2C1D", ParagraphId = "37671891", TextId = "77777777" };

            TableCell tableCell5 = GenerateLanguageHeadlineCell("Latvian");

            // Level 1
            TableCell tableCell6 = data.LanguageProficiency.Spoken.Latvian >= 1 ? GenerateFilledCell(true, false) : GenerateNotFilledCell(true, false);

            // Level 2
            TableCell tableCell7 = data.LanguageProficiency.Spoken.Latvian >= 2 ? GenerateFilledCell(false, false) : GenerateNotFilledCell(false, false);

            // Level 3
            TableCell tableCell8 = data.LanguageProficiency.Spoken.Latvian >= 3 ? GenerateFilledCell(false, false) : GenerateNotFilledCell(false, false);

            // Level 4
            TableCell tableCell9 = data.LanguageProficiency.Spoken.Latvian >= 4 ? GenerateFilledCell(false, false) : GenerateNotFilledCell(false, false);

            // Level 5
            TableCell tableCell10 = data.LanguageProficiency.Spoken.Latvian >= 5 ? GenerateFilledCell(false, true) : GenerateNotFilledCell(false, true);

            // Level 1
            TableCell tableCell11 = data.LanguageProficiency.Written.Latvian >= 1 ? GenerateFilledCell(true, false) : GenerateNotFilledCell(true, false);

            // Level 2
            TableCell tableCell12 = data.LanguageProficiency.Written.Latvian >= 2 ? GenerateFilledCell(false, false) : GenerateNotFilledCell(false, false);

            // Level 3
            TableCell tableCell13 = data.LanguageProficiency.Written.Latvian >= 3 ? GenerateFilledCell(false, false) : GenerateNotFilledCell(false, false);

            // Level 4
            TableCell tableCell14 = data.LanguageProficiency.Written.Latvian >= 4 ? GenerateFilledCell(false, false) : GenerateNotFilledCell(false, false);

            // Level 5
            TableCell tableCell15 = data.LanguageProficiency.Written.Latvian >= 5 ? GenerateFilledCell(false, true) : GenerateNotFilledCell(false, true);

            tableRow3.Append(tableCell5);
            tableRow3.Append(tableCell6);
            tableRow3.Append(tableCell7);
            tableRow3.Append(tableCell8);
            tableRow3.Append(tableCell9);
            tableRow3.Append(tableCell10);
            tableRow3.Append(tableCell11);
            tableRow3.Append(tableCell12);
            tableRow3.Append(tableCell13);
            tableRow3.Append(tableCell14);
            tableRow3.Append(tableCell15);

            TableRow tableRow4 = new TableRow() { RsidTableRowAddition = "009B2C1D", ParagraphId = "3F5DBF51", TextId = "77777777" };

            TableCell tableCell16 = GenerateLanguageHeadlineCell("Russian");

            // Level 1
            TableCell tableCell17 = data.LanguageProficiency.Spoken.Russian >= 1 ? GenerateFilledCell(true, false) : GenerateNotFilledCell(true, false);

            // Level 2
            TableCell tableCell18 = data.LanguageProficiency.Spoken.Russian >= 2 ? GenerateFilledCell(false, false) : GenerateNotFilledCell(false, false);

            // Level 3 
            TableCell tableCell19 = data.LanguageProficiency.Spoken.Russian >= 3 ? GenerateFilledCell(false, false) : GenerateNotFilledCell(false, false);

            // Level 4 
            TableCell tableCell20 = data.LanguageProficiency.Spoken.Russian >= 4 ? GenerateFilledCell(false, false) : GenerateNotFilledCell(false, false);

            // Level 5
            TableCell tableCell21 = data.LanguageProficiency.Spoken.Russian >= 5 ? GenerateFilledCell(false, true) : GenerateNotFilledCell(false, true);

            // Level 1
            TableCell tableCell22 = data.LanguageProficiency.Written.Russian >= 1 ? GenerateFilledCell(true, false) : GenerateNotFilledCell(true, false);

            // Level 2
            TableCell tableCell23 = data.LanguageProficiency.Written.Russian >= 2 ? GenerateFilledCell(false, false) : GenerateNotFilledCell(false, false);

            // Level 3
            TableCell tableCell24 = data.LanguageProficiency.Written.Russian >= 3 ? GenerateFilledCell(false, false) : GenerateNotFilledCell(false, false);

            // Level 4
            TableCell tableCell25 = data.LanguageProficiency.Written.Russian >= 4 ? GenerateFilledCell(false, false) : GenerateNotFilledCell(false, false);

            // Level 5
            TableCell tableCell26 = data.LanguageProficiency.Written.Russian >= 5 ? GenerateNotFilledCell(true, false) : GenerateNotFilledCell(false, true);

            tableRow4.Append(tableCell16);
            tableRow4.Append(tableCell17);
            tableRow4.Append(tableCell18);
            tableRow4.Append(tableCell19);
            tableRow4.Append(tableCell20);
            tableRow4.Append(tableCell21);
            tableRow4.Append(tableCell22);
            tableRow4.Append(tableCell23);
            tableRow4.Append(tableCell24);
            tableRow4.Append(tableCell25);
            tableRow4.Append(tableCell26);

            TableRow tableRow5 = new TableRow() { RsidTableRowAddition = "009B2C1D", ParagraphId = "576AEFBD", TextId = "77777777" };

            TableCell tableCell27 = GenerateLanguageHeadlineCell("English");

            // Level 1
            TableCell tableCell28 = data.LanguageProficiency.Spoken.English >= 1 ? GenerateFilledCell(true, false) : GenerateNotFilledCell(true, false);

            // Level 2
            TableCell tableCell29 = data.LanguageProficiency.Spoken.English >= 2 ? GenerateFilledCell(false, false) : GenerateNotFilledCell(false, false);

            // Level 3
            TableCell tableCell30 = data.LanguageProficiency.Spoken.English >= 3 ? GenerateFilledCell(false, false) : GenerateNotFilledCell(false, false);

            // Level 4
            TableCell tableCell31 = data.LanguageProficiency.Spoken.English >= 4 ? GenerateFilledCell(false, false) : GenerateNotFilledCell(false, false);

            // Level 5
            TableCell tableCell32 = data.LanguageProficiency.Spoken.English >= 5 ? GenerateNotFilledCell(true, false) : GenerateNotFilledCell(false, true);

            // Level 1
            TableCell tableCell33 = data.LanguageProficiency.Written.English >= 1 ? GenerateFilledCell(true, false) : GenerateNotFilledCell(true, false);

            // Level 2
            TableCell tableCell34 = data.LanguageProficiency.Written.English >= 2 ? GenerateFilledCell(false, false) : GenerateNotFilledCell(false, false);

            // Level 3
            TableCell tableCell35 = data.LanguageProficiency.Written.English >= 3 ? GenerateFilledCell(false, false) : GenerateNotFilledCell(false, false);

            // Level 4
            TableCell tableCell36 = data.LanguageProficiency.Written.English >= 4 ? GenerateFilledCell(false, false) : GenerateNotFilledCell(false, false);

            // Level 5
            TableCell tableCell37 = data.LanguageProficiency.Written.English >= 5 ? GenerateNotFilledCell(true, false) : GenerateNotFilledCell(false, true);

            tableRow5.Append(tableCell27);
            tableRow5.Append(tableCell28);
            tableRow5.Append(tableCell29);
            tableRow5.Append(tableCell30);
            tableRow5.Append(tableCell31);
            tableRow5.Append(tableCell32);
            tableRow5.Append(tableCell33);
            tableRow5.Append(tableCell34);
            tableRow5.Append(tableCell35);
            tableRow5.Append(tableCell36);
            tableRow5.Append(tableCell37);

            table1.Append(tableProperties1);
            table1.Append(tableGrid1);

            table1.Append(GenerateHeadlineRow());
            table1.Append(GenerateSubheadlineRow());

            table1.Append(tableRow3);
            table1.Append(tableRow4);
            table1.Append(tableRow5);

            table1.Append(GenerateProficiencyLevelRow());


            return table1;
        }

        private static TableCell GenerateNotFilledCell(bool isStarting, bool isEnding)
        {
            TableCell tableCell21 = new TableCell();

            TableCellProperties tableCellProperties21 = new TableCellProperties();
            TableCellWidth tableCellWidth21 = new TableCellWidth() { Width = "450", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders21 = new TableCellBorders();
            TopBorder topBorder22 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder22 = new LeftBorder() { Val = BorderValues.Single, Color = isStarting ? "000000" : "FFFFFF", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder22 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder22 = new RightBorder() { Val = BorderValues.Single, Color = isEnding ? "000000" : "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders21.Append(topBorder22);
            tableCellBorders21.Append(leftBorder22);
            tableCellBorders21.Append(bottomBorder22);
            tableCellBorders21.Append(rightBorder22);

            tableCellProperties21.Append(tableCellWidth21);
            tableCellProperties21.Append(tableCellBorders21);

            Paragraph paragraph21 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "2B03645E", TextId = "77777777" };

            ParagraphProperties paragraphProperties21 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines21 = new SpacingBetweenLines() { After = "0" };

            paragraphProperties21.Append(spacingBetweenLines21);

            Run run22 = new Run();

            RunProperties runProperties22 = new RunProperties();
            FontSize fontSize8 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript8 = new FontSizeComplexScript() { Val = "22" };

            runProperties22.Append(fontSize8);
            runProperties22.Append(fontSizeComplexScript8);
            Text text8 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text8.Text = "  ";

            run22.Append(runProperties22);
            run22.Append(text8);

            paragraph21.Append(paragraphProperties21);
            paragraph21.Append(run22);

            tableCell21.Append(tableCellProperties21);
            tableCell21.Append(paragraph21);

            return tableCell21;
        }

        private static TableCell GenerateFilledCell(bool isStarting, bool isEnding)
        {
            TableCell tableCell6 = new TableCell();

            TableCellProperties tableCellProperties6 = new TableCellProperties();
            TableCellWidth tableCellWidth6 = new TableCellWidth() { Width = "450", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders6 = new TableCellBorders();
            TopBorder topBorder7 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder7 = new LeftBorder() { Val = BorderValues.Single, Color = isStarting ? "000000" : "FFFFFF", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder7 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder7 = new RightBorder() { Val = BorderValues.Single, Color = isEnding ? "000000" : "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders6.Append(topBorder7);
            tableCellBorders6.Append(leftBorder7);
            tableCellBorders6.Append(bottomBorder7);
            tableCellBorders6.Append(rightBorder7);

            tableCellProperties6.Append(tableCellWidth6);
            tableCellProperties6.Append(tableCellBorders6);

            Paragraph paragraph6 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "1B44D6DA", TextId = "64CDA475" };

            ParagraphProperties paragraphProperties6 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines6 = new SpacingBetweenLines() { After = "0" };

            paragraphProperties6.Append(spacingBetweenLines6);

            Run run7 = new Run();

            RunProperties runProperties7 = new RunProperties();
            NoProof noProof1 = new NoProof();

            runProperties7.Append(noProof1);

            Drawing drawing1 = new Drawing();

            Wp.Inline inline1 = new Wp.Inline() { DistanceFromTop = (UInt32Value)0U, DistanceFromBottom = (UInt32Value)0U, DistanceFromLeft = (UInt32Value)0U, DistanceFromRight = (UInt32Value)0U, AnchorId = "63217D86", EditId = "7360D4B9" };
            Wp.Extent extent1 = new Wp.Extent() { Cx = 476250L, Cy = 114300L };
            Wp.EffectExtent effectExtent1 = new Wp.EffectExtent() { LeftEdge = 0L, TopEdge = 0L, RightEdge = 0L, BottomEdge = 0L };
            Wp.DocProperties docProperties1 = new Wp.DocProperties() { Id = (UInt32Value)2U, Name = "Picture 2" };

            Wp.NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties1 = new Wp.NonVisualGraphicFrameDrawingProperties();

            A.GraphicFrameLocks graphicFrameLocks1 = new A.GraphicFrameLocks() { NoChangeAspect = true };
            graphicFrameLocks1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            nonVisualGraphicFrameDrawingProperties1.Append(graphicFrameLocks1);

            A.Graphic graphic1 = new A.Graphic();
            graphic1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.GraphicData graphicData1 = new A.GraphicData() { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" };

            Pic.Picture picture1 = new Pic.Picture();
            picture1.AddNamespaceDeclaration("pic", "http://schemas.openxmlformats.org/drawingml/2006/picture");

            Pic.NonVisualPictureProperties nonVisualPictureProperties1 = new Pic.NonVisualPictureProperties();
            Pic.NonVisualDrawingProperties nonVisualDrawingProperties1 = new Pic.NonVisualDrawingProperties() { Id = (UInt32Value)0U, Name = "Picture 2" };

            Pic.NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties1 = new Pic.NonVisualPictureDrawingProperties();
            A.PictureLocks pictureLocks1 = new A.PictureLocks() { NoChangeAspect = true, NoChangeArrowheads = true };

            nonVisualPictureDrawingProperties1.Append(pictureLocks1);

            nonVisualPictureProperties1.Append(nonVisualDrawingProperties1);
            nonVisualPictureProperties1.Append(nonVisualPictureDrawingProperties1);

            Pic.BlipFill blipFill1 = new Pic.BlipFill();

            A.Blip blip1 = new A.Blip() { Embed = "rId11" };

            A.BlipExtensionList blipExtensionList1 = new A.BlipExtensionList();

            A.BlipExtension blipExtension1 = new A.BlipExtension() { Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}" };

            A14.UseLocalDpi useLocalDpi1 = new A14.UseLocalDpi() { Val = false };
            useLocalDpi1.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            blipExtension1.Append(useLocalDpi1);

            blipExtensionList1.Append(blipExtension1);

            blip1.Append(blipExtensionList1);
            A.SourceRectangle sourceRectangle1 = new A.SourceRectangle();

            A.Stretch stretch1 = new A.Stretch();
            A.FillRectangle fillRectangle1 = new A.FillRectangle();

            stretch1.Append(fillRectangle1);

            blipFill1.Append(blip1);
            blipFill1.Append(sourceRectangle1);
            blipFill1.Append(stretch1);

            Pic.ShapeProperties shapeProperties1 = new Pic.ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D1 = new A.Transform2D();
            A.Offset offset1 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents1 = new A.Extents() { Cx = 476250L, Cy = 114300L };

            transform2D1.Append(offset1);
            transform2D1.Append(extents1);

            A.PresetGeometry presetGeometry1 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList1 = new A.AdjustValueList();

            presetGeometry1.Append(adjustValueList1);
            A.NoFill noFill1 = new A.NoFill();

            A.Outline outline1 = new A.Outline();
            A.NoFill noFill2 = new A.NoFill();

            outline1.Append(noFill2);

            shapeProperties1.Append(transform2D1);
            shapeProperties1.Append(presetGeometry1);
            shapeProperties1.Append(noFill1);
            shapeProperties1.Append(outline1);

            picture1.Append(nonVisualPictureProperties1);
            picture1.Append(blipFill1);
            picture1.Append(shapeProperties1);

            graphicData1.Append(picture1);

            graphic1.Append(graphicData1);

            inline1.Append(extent1);
            inline1.Append(effectExtent1);
            inline1.Append(docProperties1);
            inline1.Append(nonVisualGraphicFrameDrawingProperties1);
            inline1.Append(graphic1);

            drawing1.Append(inline1);

            run7.Append(runProperties7);
            run7.Append(drawing1);

            paragraph6.Append(paragraphProperties6);
            paragraph6.Append(run7);

            tableCell6.Append(tableCellProperties6);
            tableCell6.Append(paragraph6);

            return tableCell6;
        }

        private static TableCell GenerateLanguageHeadlineCell(string languageName)
        {
            TableCell tableCell5 = new TableCell();

            TableCellProperties tableCellProperties5 = new TableCellProperties();
            TableCellWidth tableCellWidth5 = new TableCellWidth() { Width = "800", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders5 = new TableCellBorders();
            TopBorder topBorder6 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder6 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder6 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder6 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders5.Append(topBorder6);
            tableCellBorders5.Append(leftBorder6);
            tableCellBorders5.Append(bottomBorder6);
            tableCellBorders5.Append(rightBorder6);

            tableCellProperties5.Append(tableCellWidth5);
            tableCellProperties5.Append(tableCellBorders5);

            Paragraph paragraph5 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "13EA36CB", TextId = "77777777" };

            ParagraphProperties paragraphProperties5 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines5 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            paragraphProperties5.Append(spacingBetweenLines5);

            Run run6 = new Run();

            RunProperties runProperties6 = new RunProperties();
            FontSize fontSize6 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript6 = new FontSizeComplexScript() { Val = "24" };

            runProperties6.Append(fontSize6);
            runProperties6.Append(fontSizeComplexScript6);
            Text text6 = new Text();
            text6.Text = languageName;

            run6.Append(runProperties6);
            run6.Append(text6);

            paragraph5.Append(paragraphProperties5);
            paragraph5.Append(run6);

            tableCell5.Append(tableCellProperties5);
            tableCell5.Append(paragraph5);

            return tableCell5;
        }

        private static TableRow GenerateSubheadlineRow()
        {
            TableRow tableRow2 = new TableRow() { RsidTableRowAddition = "009B2C1D", ParagraphId = "328E3093", TextId = "77777777" };

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

            Paragraph paragraph2 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "39F09D79", TextId = "77777777" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines2 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            paragraphProperties2.Append(spacingBetweenLines2);

            Run run3 = new Run();

            RunProperties runProperties3 = new RunProperties();
            FontSize fontSize3 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript3 = new FontSizeComplexScript() { Val = "24" };

            runProperties3.Append(fontSize3);
            runProperties3.Append(fontSizeComplexScript3);
            Text text3 = new Text();
            text3.Text = "Language";

            run3.Append(runProperties3);
            run3.Append(text3);

            paragraph2.Append(paragraphProperties2);
            paragraph2.Append(run3);

            tableCell2.Append(tableCellProperties2);
            tableCell2.Append(paragraph2);

            TableCell tableCell3 = new TableCell();

            TableCellProperties tableCellProperties3 = new TableCellProperties();
            TableCellWidth tableCellWidth3 = new TableCellWidth() { Width = "2250", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan2 = new GridSpan() { Val = 5 };

            TableCellBorders tableCellBorders3 = new TableCellBorders();
            TopBorder topBorder4 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder4 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder4 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder4 = new RightBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };

            tableCellBorders3.Append(topBorder4);
            tableCellBorders3.Append(leftBorder4);
            tableCellBorders3.Append(bottomBorder4);
            tableCellBorders3.Append(rightBorder4);

            tableCellProperties3.Append(tableCellWidth3);
            tableCellProperties3.Append(gridSpan2);
            tableCellProperties3.Append(tableCellBorders3);

            Paragraph paragraph3 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "5ED5FA28", TextId = "77777777" };

            ParagraphProperties paragraphProperties3 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines3 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification1 = new Justification() { Val = JustificationValues.Center };

            paragraphProperties3.Append(spacingBetweenLines3);
            paragraphProperties3.Append(justification1);

            Run run4 = new Run();

            RunProperties runProperties4 = new RunProperties();
            FontSize fontSize4 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript4 = new FontSizeComplexScript() { Val = "22" };

            runProperties4.Append(fontSize4);
            runProperties4.Append(fontSizeComplexScript4);
            Text text4 = new Text();
            text4.Text = "Spoken";

            run4.Append(runProperties4);
            run4.Append(text4);

            paragraph3.Append(paragraphProperties3);
            paragraph3.Append(run4);

            tableCell3.Append(tableCellProperties3);
            tableCell3.Append(paragraph3);

            TableCell tableCell4 = new TableCell();

            TableCellProperties tableCellProperties4 = new TableCellProperties();
            TableCellWidth tableCellWidth4 = new TableCellWidth() { Width = "2250", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan3 = new GridSpan() { Val = 5 };

            TableCellBorders tableCellBorders4 = new TableCellBorders();
            TopBorder topBorder5 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder5 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder5 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder5 = new RightBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };

            tableCellBorders4.Append(topBorder5);
            tableCellBorders4.Append(leftBorder5);
            tableCellBorders4.Append(bottomBorder5);
            tableCellBorders4.Append(rightBorder5);

            tableCellProperties4.Append(tableCellWidth4);
            tableCellProperties4.Append(gridSpan3);
            tableCellProperties4.Append(tableCellBorders4);

            Paragraph paragraph4 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "51EAAA25", TextId = "77777777" };

            ParagraphProperties paragraphProperties4 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines4 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification2 = new Justification() { Val = JustificationValues.Center };

            paragraphProperties4.Append(spacingBetweenLines4);
            paragraphProperties4.Append(justification2);

            Run run5 = new Run();

            RunProperties runProperties5 = new RunProperties();
            FontSize fontSize5 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript5 = new FontSizeComplexScript() { Val = "22" };

            runProperties5.Append(fontSize5);
            runProperties5.Append(fontSizeComplexScript5);
            Text text5 = new Text();
            text5.Text = "Written";

            run5.Append(runProperties5);
            run5.Append(text5);

            paragraph4.Append(paragraphProperties4);
            paragraph4.Append(run5);

            tableCell4.Append(tableCellProperties4);
            tableCell4.Append(paragraph4);

            tableRow2.Append(tableCell2);
            tableRow2.Append(tableCell3);
            tableRow2.Append(tableCell4);

            return tableRow2;
        }

        private static TableRow GenerateHeadlineRow()
        {
            TableRow tableRow1 = new TableRow() { RsidTableRowAddition = "009B2C1D", ParagraphId = "1ED7053C", TextId = "77777777" };

            TableRowProperties tableRowProperties1 = new TableRowProperties();
            GridAfter gridAfter1 = new GridAfter() { Val = 2 };
            WidthAfterTableRow widthAfterTableRow1 = new WidthAfterTableRow() { Width = "900", Type = TableWidthUnitValues.Dxa };

            tableRowProperties1.Append(gridAfter1);
            tableRowProperties1.Append(widthAfterTableRow1);

            TableCell tableCell1 = new TableCell();

            TableCellProperties tableCellProperties1 = new TableCellProperties();
            TableCellWidth tableCellWidth1 = new TableCellWidth() { Width = "800", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan1 = new GridSpan() { Val = 9 };

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

            Paragraph paragraph1 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "0C291353", TextId = "77777777" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines() { After = "0" };

            paragraphProperties1.Append(spacingBetweenLines1);

            Run run1 = new Run();

            RunProperties runProperties1 = new RunProperties();
            Bold bold1 = new Bold();
            FontSize fontSize1 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript() { Val = "22" };

            runProperties1.Append(bold1);
            runProperties1.Append(fontSize1);
            runProperties1.Append(fontSizeComplexScript1);
            Text text1 = new Text();
            text1.Text = "LANGUAGE PROFICIENCY";

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

            paragraph1.Append(paragraphProperties1);
            paragraph1.Append(run1);
            paragraph1.Append(run2);

            tableCell1.Append(tableCellProperties1);
            tableCell1.Append(paragraph1);

            tableRow1.Append(tableRowProperties1);
            tableRow1.Append(tableCell1);

            return tableRow1;
        }

        private static TableRow GenerateProficiencyLevelRow()
        {
            TableRow tableRow6 = new TableRow() { RsidTableRowAddition = "009B2C1D", ParagraphId = "74B05C77", TextId = "77777777" };

            TableCell tableCell38 = new TableCell();

            TableCellProperties tableCellProperties38 = new TableCellProperties();
            TableCellWidth tableCellWidth38 = new TableCellWidth() { Width = "800", Type = TableWidthUnitValues.Dxa };

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

            Paragraph paragraph38 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "3C7BFE60", TextId = "77777777" };

            ParagraphProperties paragraphProperties38 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines38 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            paragraphProperties38.Append(spacingBetweenLines38);

            Run run39 = new Run();

            RunProperties runProperties39 = new RunProperties();
            FontSize fontSize13 = new FontSize() { Val = "24" };
            FontSizeComplexScript fontSizeComplexScript13 = new FontSizeComplexScript() { Val = "24" };

            runProperties39.Append(fontSize13);
            runProperties39.Append(fontSizeComplexScript13);
            Text text13 = new Text();
            text13.Text = "Proficiency level";

            run39.Append(runProperties39);
            run39.Append(text13);

            paragraph38.Append(paragraphProperties38);
            paragraph38.Append(run39);

            tableCell38.Append(tableCellProperties38);
            tableCell38.Append(paragraph38);

            TableCell tableCell39 = new TableCell();

            TableCellProperties tableCellProperties39 = new TableCellProperties();
            TableCellWidth tableCellWidth39 = new TableCellWidth() { Width = "800", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders39 = new TableCellBorders();
            TopBorder topBorder40 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder40 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder40 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder40 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders39.Append(topBorder40);
            tableCellBorders39.Append(leftBorder40);
            tableCellBorders39.Append(bottomBorder40);
            tableCellBorders39.Append(rightBorder40);

            tableCellProperties39.Append(tableCellWidth39);
            tableCellProperties39.Append(tableCellBorders39);

            Paragraph paragraph39 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "7BDA851C", TextId = "77777777" };

            ParagraphProperties paragraphProperties39 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines39 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification3 = new Justification() { Val = JustificationValues.Center };

            paragraphProperties39.Append(spacingBetweenLines39);
            paragraphProperties39.Append(justification3);

            Run run40 = new Run();

            RunProperties runProperties40 = new RunProperties();
            FontSize fontSize14 = new FontSize() { Val = "13" };
            FontSizeComplexScript fontSizeComplexScript14 = new FontSizeComplexScript() { Val = "13" };

            runProperties40.Append(fontSize14);
            runProperties40.Append(fontSizeComplexScript14);
            Text text14 = new Text();
            text14.Text = "-basic";

            run40.Append(runProperties40);
            run40.Append(text14);

            paragraph39.Append(paragraphProperties39);
            paragraph39.Append(run40);

            tableCell39.Append(tableCellProperties39);
            tableCell39.Append(paragraph39);

            TableCell tableCell40 = new TableCell();

            TableCellProperties tableCellProperties40 = new TableCellProperties();
            TableCellWidth tableCellWidth40 = new TableCellWidth() { Width = "800", Type = TableWidthUnitValues.Dxa };

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

            Paragraph paragraph40 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "09317404", TextId = "77777777" };

            ParagraphProperties paragraphProperties40 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines40 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            paragraphProperties40.Append(spacingBetweenLines40);

            Run run41 = new Run();

            RunProperties runProperties41 = new RunProperties();
            FontSize fontSize15 = new FontSize() { Val = "13" };
            FontSizeComplexScript fontSizeComplexScript15 = new FontSizeComplexScript() { Val = "13" };

            runProperties41.Append(fontSize15);
            runProperties41.Append(fontSizeComplexScript15);
            Text text15 = new Text();
            text15.Text = "-satisfactory";

            run41.Append(runProperties41);
            run41.Append(text15);

            paragraph40.Append(paragraphProperties40);
            paragraph40.Append(run41);

            tableCell40.Append(tableCellProperties40);
            tableCell40.Append(paragraph40);

            TableCell tableCell41 = new TableCell();

            TableCellProperties tableCellProperties41 = new TableCellProperties();
            TableCellWidth tableCellWidth41 = new TableCellWidth() { Width = "800", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders41 = new TableCellBorders();
            TopBorder topBorder42 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder42 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder42 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder42 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders41.Append(topBorder42);
            tableCellBorders41.Append(leftBorder42);
            tableCellBorders41.Append(bottomBorder42);
            tableCellBorders41.Append(rightBorder42);

            tableCellProperties41.Append(tableCellWidth41);
            tableCellProperties41.Append(tableCellBorders41);

            Paragraph paragraph41 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "493C8635", TextId = "77777777" };

            ParagraphProperties paragraphProperties41 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines41 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification4 = new Justification() { Val = JustificationValues.Center };

            paragraphProperties41.Append(spacingBetweenLines41);
            paragraphProperties41.Append(justification4);

            Run run42 = new Run();

            RunProperties runProperties42 = new RunProperties();
            FontSize fontSize16 = new FontSize() { Val = "13" };
            FontSizeComplexScript fontSizeComplexScript16 = new FontSizeComplexScript() { Val = "13" };

            runProperties42.Append(fontSize16);
            runProperties42.Append(fontSizeComplexScript16);
            Text text16 = new Text();
            text16.Text = "-good";

            run42.Append(runProperties42);
            run42.Append(text16);

            paragraph41.Append(paragraphProperties41);
            paragraph41.Append(run42);

            tableCell41.Append(tableCellProperties41);
            tableCell41.Append(paragraph41);

            TableCell tableCell42 = new TableCell();

            TableCellProperties tableCellProperties42 = new TableCellProperties();
            TableCellWidth tableCellWidth42 = new TableCellWidth() { Width = "800", Type = TableWidthUnitValues.Dxa };

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

            Paragraph paragraph42 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "31F58768", TextId = "77777777" };

            ParagraphProperties paragraphProperties42 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines42 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification5 = new Justification() { Val = JustificationValues.Center };

            paragraphProperties42.Append(spacingBetweenLines42);
            paragraphProperties42.Append(justification5);

            Run run43 = new Run();

            RunProperties runProperties43 = new RunProperties();
            FontSize fontSize17 = new FontSize() { Val = "13" };
            FontSizeComplexScript fontSizeComplexScript17 = new FontSizeComplexScript() { Val = "13" };

            runProperties43.Append(fontSize17);
            runProperties43.Append(fontSizeComplexScript17);
            Text text17 = new Text();
            text17.Text = "-excellent";

            run43.Append(runProperties43);
            run43.Append(text17);

            paragraph42.Append(paragraphProperties42);
            paragraph42.Append(run43);

            tableCell42.Append(tableCellProperties42);
            tableCell42.Append(paragraph42);

            TableCell tableCell43 = new TableCell();

            TableCellProperties tableCellProperties43 = new TableCellProperties();
            TableCellWidth tableCellWidth43 = new TableCellWidth() { Width = "800", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders43 = new TableCellBorders();
            TopBorder topBorder44 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder44 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder44 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder44 = new RightBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };

            tableCellBorders43.Append(topBorder44);
            tableCellBorders43.Append(leftBorder44);
            tableCellBorders43.Append(bottomBorder44);
            tableCellBorders43.Append(rightBorder44);

            tableCellProperties43.Append(tableCellWidth43);
            tableCellProperties43.Append(tableCellBorders43);

            Paragraph paragraph43 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "335866B1", TextId = "77777777" };

            ParagraphProperties paragraphProperties43 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines43 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification6 = new Justification() { Val = JustificationValues.Center };

            paragraphProperties43.Append(spacingBetweenLines43);
            paragraphProperties43.Append(justification6);

            Run run44 = new Run();

            RunProperties runProperties44 = new RunProperties();
            FontSize fontSize18 = new FontSize() { Val = "13" };
            FontSizeComplexScript fontSizeComplexScript18 = new FontSizeComplexScript() { Val = "13" };

            runProperties44.Append(fontSize18);
            runProperties44.Append(fontSizeComplexScript18);
            Text text18 = new Text();
            text18.Text = "-native";

            run44.Append(runProperties44);
            run44.Append(text18);

            paragraph43.Append(paragraphProperties43);
            paragraph43.Append(run44);

            tableCell43.Append(tableCellProperties43);
            tableCell43.Append(paragraph43);

            TableCell tableCell44 = new TableCell();

            TableCellProperties tableCellProperties44 = new TableCellProperties();
            TableCellWidth tableCellWidth44 = new TableCellWidth() { Width = "800", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders44 = new TableCellBorders();
            TopBorder topBorder45 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder45 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder45 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder45 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders44.Append(topBorder45);
            tableCellBorders44.Append(leftBorder45);
            tableCellBorders44.Append(bottomBorder45);
            tableCellBorders44.Append(rightBorder45);

            tableCellProperties44.Append(tableCellWidth44);
            tableCellProperties44.Append(tableCellBorders44);

            Paragraph paragraph44 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "616859D5", TextId = "77777777" };

            ParagraphProperties paragraphProperties44 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines44 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification7 = new Justification() { Val = JustificationValues.Center };

            paragraphProperties44.Append(spacingBetweenLines44);
            paragraphProperties44.Append(justification7);

            Run run45 = new Run();

            RunProperties runProperties45 = new RunProperties();
            FontSize fontSize19 = new FontSize() { Val = "13" };
            FontSizeComplexScript fontSizeComplexScript19 = new FontSizeComplexScript() { Val = "13" };

            runProperties45.Append(fontSize19);
            runProperties45.Append(fontSizeComplexScript19);
            Text text19 = new Text();
            text19.Text = "-basic";

            run45.Append(runProperties45);
            run45.Append(text19);

            paragraph44.Append(paragraphProperties44);
            paragraph44.Append(run45);

            tableCell44.Append(tableCellProperties44);
            tableCell44.Append(paragraph44);

            TableCell tableCell45 = new TableCell();

            TableCellProperties tableCellProperties45 = new TableCellProperties();
            TableCellWidth tableCellWidth45 = new TableCellWidth() { Width = "800", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders45 = new TableCellBorders();
            TopBorder topBorder46 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder46 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder46 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder46 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders45.Append(topBorder46);
            tableCellBorders45.Append(leftBorder46);
            tableCellBorders45.Append(bottomBorder46);
            tableCellBorders45.Append(rightBorder46);

            tableCellProperties45.Append(tableCellWidth45);
            tableCellProperties45.Append(tableCellBorders45);

            Paragraph paragraph45 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "7B4B2FCB", TextId = "77777777" };

            ParagraphProperties paragraphProperties45 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines45 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };

            paragraphProperties45.Append(spacingBetweenLines45);

            Run run46 = new Run();

            RunProperties runProperties46 = new RunProperties();
            FontSize fontSize20 = new FontSize() { Val = "13" };
            FontSizeComplexScript fontSizeComplexScript20 = new FontSizeComplexScript() { Val = "13" };

            runProperties46.Append(fontSize20);
            runProperties46.Append(fontSizeComplexScript20);
            Text text20 = new Text();
            text20.Text = "-satisfactory";

            run46.Append(runProperties46);
            run46.Append(text20);

            paragraph45.Append(paragraphProperties45);
            paragraph45.Append(run46);

            tableCell45.Append(tableCellProperties45);
            tableCell45.Append(paragraph45);

            TableCell tableCell46 = new TableCell();

            TableCellProperties tableCellProperties46 = new TableCellProperties();
            TableCellWidth tableCellWidth46 = new TableCellWidth() { Width = "800", Type = TableWidthUnitValues.Dxa };

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

            Paragraph paragraph46 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "0E7582C6", TextId = "77777777" };

            ParagraphProperties paragraphProperties46 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines46 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification8 = new Justification() { Val = JustificationValues.Center };

            paragraphProperties46.Append(spacingBetweenLines46);
            paragraphProperties46.Append(justification8);

            Run run47 = new Run();

            RunProperties runProperties47 = new RunProperties();
            FontSize fontSize21 = new FontSize() { Val = "13" };
            FontSizeComplexScript fontSizeComplexScript21 = new FontSizeComplexScript() { Val = "13" };

            runProperties47.Append(fontSize21);
            runProperties47.Append(fontSizeComplexScript21);
            Text text21 = new Text();
            text21.Text = "-good";

            run47.Append(runProperties47);
            run47.Append(text21);

            paragraph46.Append(paragraphProperties46);
            paragraph46.Append(run47);

            tableCell46.Append(tableCellProperties46);
            tableCell46.Append(paragraph46);

            TableCell tableCell47 = new TableCell();

            TableCellProperties tableCellProperties47 = new TableCellProperties();
            TableCellWidth tableCellWidth47 = new TableCellWidth() { Width = "800", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders47 = new TableCellBorders();
            TopBorder topBorder48 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder48 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder48 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder48 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders47.Append(topBorder48);
            tableCellBorders47.Append(leftBorder48);
            tableCellBorders47.Append(bottomBorder48);
            tableCellBorders47.Append(rightBorder48);

            tableCellProperties47.Append(tableCellWidth47);
            tableCellProperties47.Append(tableCellBorders47);

            Paragraph paragraph47 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "4D269B81", TextId = "77777777" };

            ParagraphProperties paragraphProperties47 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines47 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification9 = new Justification() { Val = JustificationValues.Center };

            paragraphProperties47.Append(spacingBetweenLines47);
            paragraphProperties47.Append(justification9);

            Run run48 = new Run();

            RunProperties runProperties48 = new RunProperties();
            FontSize fontSize22 = new FontSize() { Val = "13" };
            FontSizeComplexScript fontSizeComplexScript22 = new FontSizeComplexScript() { Val = "13" };

            runProperties48.Append(fontSize22);
            runProperties48.Append(fontSizeComplexScript22);
            Text text22 = new Text();
            text22.Text = "-excellent";

            run48.Append(runProperties48);
            run48.Append(text22);

            paragraph47.Append(paragraphProperties47);
            paragraph47.Append(run48);

            tableCell47.Append(tableCellProperties47);
            tableCell47.Append(paragraph47);

            TableCell tableCell48 = new TableCell();

            TableCellProperties tableCellProperties48 = new TableCellProperties();
            TableCellWidth tableCellWidth48 = new TableCellWidth() { Width = "800", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders48 = new TableCellBorders();
            TopBorder topBorder49 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder49 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder49 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder49 = new RightBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };

            tableCellBorders48.Append(topBorder49);
            tableCellBorders48.Append(leftBorder49);
            tableCellBorders48.Append(bottomBorder49);
            tableCellBorders48.Append(rightBorder49);

            tableCellProperties48.Append(tableCellWidth48);
            tableCellProperties48.Append(tableCellBorders48);

            Paragraph paragraph48 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "5D2878D5", TextId = "77777777" };

            ParagraphProperties paragraphProperties48 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines48 = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Justification justification10 = new Justification() { Val = JustificationValues.Center };

            paragraphProperties48.Append(spacingBetweenLines48);
            paragraphProperties48.Append(justification10);

            Run run49 = new Run();

            RunProperties runProperties49 = new RunProperties();
            FontSize fontSize23 = new FontSize() { Val = "13" };
            FontSizeComplexScript fontSizeComplexScript23 = new FontSizeComplexScript() { Val = "13" };

            runProperties49.Append(fontSize23);
            runProperties49.Append(fontSizeComplexScript23);
            Text text23 = new Text();
            text23.Text = "-native";

            run49.Append(runProperties49);
            run49.Append(text23);

            paragraph48.Append(paragraphProperties48);
            paragraph48.Append(run49);

            tableCell48.Append(tableCellProperties48);
            tableCell48.Append(paragraph48);

            tableRow6.Append(tableCell38);
            tableRow6.Append(tableCell39);
            tableRow6.Append(tableCell40);
            tableRow6.Append(tableCell41);
            tableRow6.Append(tableCell42);
            tableRow6.Append(tableCell43);
            tableRow6.Append(tableCell44);
            tableRow6.Append(tableCell45);
            tableRow6.Append(tableCell46);
            tableRow6.Append(tableCell47);
            tableRow6.Append(tableCell48);

            return tableRow6;
        }
    }
}
