using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using Wp = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using A = DocumentFormat.OpenXml.Drawing;
using Pic = DocumentFormat.OpenXml.Drawing.Pictures;
using A14 = DocumentFormat.OpenXml.Office2010.Drawing;

namespace CV.Management.Generation.Word.ContentHelper
{
    public static class ContentTable1
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
            GridColumn gridColumn1 = new GridColumn() { Width = "2000" };
            GridColumn gridColumn2 = new GridColumn() { Width = "2550" };
            GridColumn gridColumn3 = new GridColumn() { Width = "3825" };

            tableGrid1.Append(gridColumn1);
            tableGrid1.Append(gridColumn2);
            tableGrid1.Append(gridColumn3);

            TableRow tableRow1 = new TableRow() { RsidTableRowAddition = "009B2C1D", ParagraphId = "080C4265", TextId = "77777777" };

            TableRowProperties tableRowProperties1 = new TableRowProperties();
            GridAfter gridAfter1 = new GridAfter() { Val = 2 };
            WidthAfterTableRow widthAfterTableRow1 = new WidthAfterTableRow() { Width = "6375", Type = TableWidthUnitValues.Dxa };

            tableRowProperties1.Append(gridAfter1);
            tableRowProperties1.Append(widthAfterTableRow1);

            TableCell tableCell1 = new TableCell();

            TableCellProperties tableCellProperties1 = new TableCellProperties();
            TableCellWidth tableCellWidth1 = new TableCellWidth() { Width = "800", Type = TableWidthUnitValues.Dxa };

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

            Paragraph paragraph1 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "3B996D8B", TextId = "0D88121C" };

            Run run1 = new Run();

            RunProperties runProperties1 = new RunProperties();
            NoProof noProof1 = new NoProof();

            runProperties1.Append(noProof1);

            Drawing drawing1 = new Drawing();

            Wp.Inline inline1 = new Wp.Inline() { DistanceFromTop = (UInt32Value)0U, DistanceFromBottom = (UInt32Value)0U, DistanceFromLeft = (UInt32Value)0U, DistanceFromRight = (UInt32Value)0U, AnchorId = "29B39BAA", EditId = "5481AAF3" };
            Wp.Extent extent1 = new Wp.Extent() { Cx = 1257300L, Cy = 1057275L };
            Wp.EffectExtent effectExtent1 = new Wp.EffectExtent() { LeftEdge = 0L, TopEdge = 0L, RightEdge = 0L, BottomEdge = 0L };
            Wp.DocProperties docProperties1 = new Wp.DocProperties() { Id = (UInt32Value)1U, Name = "Picture 1" };

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
            Pic.NonVisualDrawingProperties nonVisualDrawingProperties1 = new Pic.NonVisualDrawingProperties() { Id = (UInt32Value)0U, Name = "Picture 1" };

            Pic.NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties1 = new Pic.NonVisualPictureDrawingProperties();
            A.PictureLocks pictureLocks1 = new A.PictureLocks() { NoChangeAspect = true, NoChangeArrowheads = true };

            nonVisualPictureDrawingProperties1.Append(pictureLocks1);

            nonVisualPictureProperties1.Append(nonVisualDrawingProperties1);
            nonVisualPictureProperties1.Append(nonVisualPictureDrawingProperties1);

            Pic.BlipFill blipFill1 = new Pic.BlipFill();

            A.Blip blip1 = new A.Blip() { Embed = "rId9" };

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
            A.Extents extents1 = new A.Extents() { Cx = 1257300L, Cy = 1057275L };

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

            run1.Append(runProperties1);
            run1.Append(drawing1);

            paragraph1.Append(run1);

            tableCell1.Append(tableCellProperties1);
            tableCell1.Append(paragraph1);

            tableRow1.Append(tableRowProperties1);
            tableRow1.Append(tableCell1);

            TableRow tableRow2 = new TableRow() { RsidTableRowAddition = "009B2C1D", ParagraphId = "3125C09D", TextId = "77777777" };

            TableRowProperties tableRowProperties2 = new TableRowProperties();
            GridAfter gridAfter2 = new GridAfter() { Val = 2 };
            WidthAfterTableRow widthAfterTableRow2 = new WidthAfterTableRow() { Width = "6375", Type = TableWidthUnitValues.Dxa };

            tableRowProperties2.Append(gridAfter2);
            tableRowProperties2.Append(widthAfterTableRow2);

            TableCell tableCell2 = new TableCell();

            TableCellProperties tableCellProperties2 = new TableCellProperties();
            TableCellWidth tableCellWidth2 = new TableCellWidth() { Width = "800", Type = TableWidthUnitValues.Dxa };

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
            Paragraph paragraph2 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "595BC873", TextId = "77777777" };

            tableCell2.Append(tableCellProperties2);
            tableCell2.Append(paragraph2);

            tableRow2.Append(tableRowProperties2);
            tableRow2.Append(tableCell2);

            TableRow tableRow3 = new TableRow() { RsidTableRowAddition = "009B2C1D", ParagraphId = "13569F8F", TextId = "77777777" };

            TableRowProperties tableRowProperties3 = new TableRowProperties();
            GridAfter gridAfter3 = new GridAfter() { Val = 2 };
            WidthAfterTableRow widthAfterTableRow3 = new WidthAfterTableRow() { Width = "6375", Type = TableWidthUnitValues.Dxa };

            tableRowProperties3.Append(gridAfter3);
            tableRowProperties3.Append(widthAfterTableRow3);

            TableCell tableCell3 = new TableCell();

            TableCellProperties tableCellProperties3 = new TableCellProperties();
            TableCellWidth tableCellWidth3 = new TableCellWidth() { Width = "800", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders3 = new TableCellBorders();
            TopBorder topBorder4 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder4 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder4 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder4 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders3.Append(topBorder4);
            tableCellBorders3.Append(leftBorder4);
            tableCellBorders3.Append(bottomBorder4);
            tableCellBorders3.Append(rightBorder4);

            tableCellProperties3.Append(tableCellWidth3);
            tableCellProperties3.Append(tableCellBorders3);
            Paragraph paragraph3 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "105B22E7", TextId = "77777777" };

            tableCell3.Append(tableCellProperties3);
            tableCell3.Append(paragraph3);

            tableRow3.Append(tableRowProperties3);
            tableRow3.Append(tableCell3);

            TableRow tableRow4 = new TableRow() { RsidTableRowAddition = "009B2C1D", ParagraphId = "0E828CE9", TextId = "77777777" };

            TableCell tableCell4 = new TableCell();

            TableCellProperties tableCellProperties4 = new TableCellProperties();
            TableCellWidth tableCellWidth4 = new TableCellWidth() { Width = "800", Type = TableWidthUnitValues.Dxa };

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
            Paragraph paragraph4 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "7D33E7CB", TextId = "77777777" };

            tableCell4.Append(tableCellProperties4);
            tableCell4.Append(paragraph4);

            TableCell tableCell5 = new TableCell();

            TableCellProperties tableCellProperties5 = new TableCellProperties();
            TableCellWidth tableCellWidth5 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

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
            Paragraph paragraph5 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "4B505573", TextId = "77777777" };

            tableCell5.Append(tableCellProperties5);
            tableCell5.Append(paragraph5);

            TableCell tableCell6 = new TableCell();

            TableCellProperties tableCellProperties6 = new TableCellProperties();
            TableCellWidth tableCellWidth6 = new TableCellWidth() { Width = "3825", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders6 = new TableCellBorders();
            TopBorder topBorder7 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder7 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder7 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder7 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders6.Append(topBorder7);
            tableCellBorders6.Append(leftBorder7);
            tableCellBorders6.Append(bottomBorder7);
            tableCellBorders6.Append(rightBorder7);
            Shading shading1 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "0069B4" };
            TableCellVerticalAlignment tableCellVerticalAlignment1 = new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center };

            tableCellProperties6.Append(tableCellWidth6);
            tableCellProperties6.Append(tableCellBorders6);
            tableCellProperties6.Append(shading1);
            tableCellProperties6.Append(tableCellVerticalAlignment1);

            Paragraph paragraph6 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "63EAFC9C", TextId = "77777777" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines() { Before = "550", After = "800" };
            Indentation indentation1 = new Indentation() { Left = "432" };

            paragraphProperties1.Append(spacingBetweenLines1);
            paragraphProperties1.Append(indentation1);

            Run run2 = new Run();

            RunProperties runProperties2 = new RunProperties();
            Color color1 = new Color() { Val = "FFFFFF" };
            FontSize fontSize1 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript() { Val = "18" };

            runProperties2.Append(color1);
            runProperties2.Append(fontSize1);
            runProperties2.Append(fontSizeComplexScript1);
            Text text1 = new Text();
            text1.Text = "Confidential candidate CV";

            run2.Append(runProperties2);
            run2.Append(text1);

            paragraph6.Append(paragraphProperties1);
            paragraph6.Append(run2);

            Paragraph paragraph7 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "0007641E", ParagraphId = "48E9D2B9", TextId = "21C16ECD" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines2 = new SpacingBetweenLines() { After = "0" };
            Indentation indentation2 = new Indentation() { Left = "432" };

            paragraphProperties2.Append(spacingBetweenLines2);
            paragraphProperties2.Append(indentation2);

            Run run3 = new Run();

            RunProperties runProperties3 = new RunProperties();
            Bold bold1 = new Bold();
            Color color2 = new Color() { Val = "FFFFFF" };
            FontSize fontSize2 = new FontSize() { Val = "33" };
            FontSizeComplexScript fontSizeComplexScript2 = new FontSizeComplexScript() { Val = "33" };

            runProperties3.Append(bold1);
            runProperties3.Append(color2);
            runProperties3.Append(fontSize2);
            runProperties3.Append(fontSizeComplexScript2);
            Text text2 = new Text();
            text2.Text = data.TitleArea.Name;

            run3.Append(runProperties3);
            run3.Append(text2);

            paragraph7.Append(paragraphProperties2);
            paragraph7.Append(run3);

            Paragraph paragraph8 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "4D45EC2E", TextId = "77777777" };

            ParagraphProperties paragraphProperties3 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines3 = new SpacingBetweenLines() { Before = "800", After = "550", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation3 = new Indentation() { Left = "432" };

            paragraphProperties3.Append(spacingBetweenLines3);
            paragraphProperties3.Append(indentation3);

            Run run4 = new Run();

            RunProperties runProperties4 = new RunProperties();
            Color color3 = new Color() { Val = "FFFFFF" };
            FontSize fontSize3 = new FontSize() { Val = "18" };
            FontSizeComplexScript fontSizeComplexScript3 = new FontSizeComplexScript() { Val = "18" };

            runProperties4.Append(color3);
            runProperties4.Append(fontSize3);
            runProperties4.Append(fontSizeComplexScript3);
            Text text3 = new Text();
            text3.Text = data.TitleArea.Date;

            run4.Append(runProperties4);
            run4.Append(text3);

            paragraph8.Append(paragraphProperties3);
            paragraph8.Append(run4);

            tableCell6.Append(tableCellProperties6);
            tableCell6.Append(paragraph6);
            tableCell6.Append(paragraph7);
            tableCell6.Append(paragraph8);

            tableRow4.Append(tableCell4);
            tableRow4.Append(tableCell5);
            tableRow4.Append(tableCell6);

            TableRow tableRow5 = new TableRow() { RsidTableRowAddition = "009B2C1D", ParagraphId = "485735CB", TextId = "77777777" };

            TableRowProperties tableRowProperties4 = new TableRowProperties();
            GridAfter gridAfter4 = new GridAfter() { Val = 2 };
            WidthAfterTableRow widthAfterTableRow4 = new WidthAfterTableRow() { Width = "6375", Type = TableWidthUnitValues.Dxa };

            tableRowProperties4.Append(gridAfter4);
            tableRowProperties4.Append(widthAfterTableRow4);

            TableCell tableCell7 = new TableCell();

            TableCellProperties tableCellProperties7 = new TableCellProperties();
            TableCellWidth tableCellWidth7 = new TableCellWidth() { Width = "800", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders7 = new TableCellBorders();
            TopBorder topBorder8 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder8 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder8 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder8 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders7.Append(topBorder8);
            tableCellBorders7.Append(leftBorder8);
            tableCellBorders7.Append(bottomBorder8);
            tableCellBorders7.Append(rightBorder8);

            tableCellProperties7.Append(tableCellWidth7);
            tableCellProperties7.Append(tableCellBorders7);
            Paragraph paragraph9 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "41648536", TextId = "77777777" };

            tableCell7.Append(tableCellProperties7);
            tableCell7.Append(paragraph9);

            tableRow5.Append(tableRowProperties4);
            tableRow5.Append(tableCell7);

            TableRow tableRow6 = new TableRow() { RsidTableRowAddition = "009B2C1D", ParagraphId = "20373438", TextId = "77777777" };

            TableRowProperties tableRowProperties5 = new TableRowProperties();
            GridAfter gridAfter5 = new GridAfter() { Val = 2 };
            WidthAfterTableRow widthAfterTableRow5 = new WidthAfterTableRow() { Width = "6375", Type = TableWidthUnitValues.Dxa };

            tableRowProperties5.Append(gridAfter5);
            tableRowProperties5.Append(widthAfterTableRow5);

            TableCell tableCell8 = new TableCell();

            TableCellProperties tableCellProperties8 = new TableCellProperties();
            TableCellWidth tableCellWidth8 = new TableCellWidth() { Width = "800", Type = TableWidthUnitValues.Dxa };

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
            Paragraph paragraph10 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "54B78A08", TextId = "77777777" };

            tableCell8.Append(tableCellProperties8);
            tableCell8.Append(paragraph10);

            tableRow6.Append(tableRowProperties5);
            tableRow6.Append(tableCell8);

            table1.Append(tableProperties1);
            table1.Append(tableGrid1);
            table1.Append(tableRow1);
            table1.Append(tableRow2);
            table1.Append(tableRow3);
            table1.Append(tableRow4);
            table1.Append(tableRow5);
            table1.Append(tableRow6);
            return table1;
        }
    }
}
