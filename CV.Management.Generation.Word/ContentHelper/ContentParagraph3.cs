using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using A = DocumentFormat.OpenXml.Drawing;
using Pic = DocumentFormat.OpenXml.Drawing.Pictures;
using A14 = DocumentFormat.OpenXml.Office2010.Drawing;
using Wp14 = DocumentFormat.OpenXml.Office2010.Word.Drawing;
using DocumentFormat.OpenXml;

namespace CV.Management.Generation.Word.ContentHelper
{
    public static class ContentParagraph3
    {
        // Creates an Paragraph instance and adds its children.
        public static Paragraph GenerateParagraph()
        {
            Paragraph paragraph1 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "00B96314", ParagraphId = "0B39323B", TextId = "7F2F315D" };
            BookmarkStart bookmarkStart1 = new BookmarkStart() { Name = "_GoBack", Id = "0" };

            Run run1 = new Run();

            RunProperties runProperties1 = new RunProperties();
            NoProof noProof1 = new NoProof();

            runProperties1.Append(noProof1);

            Drawing drawing1 = new Drawing();

            Anchor anchor1 = new Anchor() { DistanceFromTop = (UInt32Value)0U, DistanceFromBottom = (UInt32Value)0U, DistanceFromLeft = (UInt32Value)114300U, DistanceFromRight = (UInt32Value)114300U, SimplePos = false, RelativeHeight = (UInt32Value)251659264U, BehindDoc = true, Locked = false, LayoutInCell = true, AllowOverlap = true, EditId = "3E042748", AnchorId = "3A391EBB" };
            SimplePosition simplePosition1 = new SimplePosition() { X = 0L, Y = 0L };

            HorizontalPosition horizontalPosition1 = new HorizontalPosition() { RelativeFrom = HorizontalRelativePositionValues.Column };
            PositionOffset positionOffset1 = new PositionOffset();
            positionOffset1.Text = "4435475";

            horizontalPosition1.Append(positionOffset1);

            VerticalPosition verticalPosition1 = new VerticalPosition() { RelativeFrom = VerticalRelativePositionValues.Paragraph };
            PositionOffset positionOffset2 = new PositionOffset();
            positionOffset2.Text = "306171";

            verticalPosition1.Append(positionOffset2);
            Extent extent1 = new Extent() { Cx = 1187454L, Cy = 1486814L };
            EffectExtent effectExtent1 = new EffectExtent() { LeftEdge = 0L, TopEdge = 0L, RightEdge = 0L, BottomEdge = 0L };
            WrapNone wrapNone1 = new WrapNone();
            DocProperties docProperties1 = new DocProperties() { Id = (UInt32Value)30U, Name = "Picture 30" };

            NonVisualGraphicFrameDrawingProperties nonVisualGraphicFrameDrawingProperties1 = new NonVisualGraphicFrameDrawingProperties();

            A.GraphicFrameLocks graphicFrameLocks1 = new A.GraphicFrameLocks() { NoChangeAspect = true };
            graphicFrameLocks1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            nonVisualGraphicFrameDrawingProperties1.Append(graphicFrameLocks1);

            A.Graphic graphic1 = new A.Graphic();
            graphic1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.GraphicData graphicData1 = new A.GraphicData() { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" };

            Pic.Picture picture1 = new Pic.Picture();
            picture1.AddNamespaceDeclaration("pic", "http://schemas.openxmlformats.org/drawingml/2006/picture");

            Pic.NonVisualPictureProperties nonVisualPictureProperties1 = new Pic.NonVisualPictureProperties();
            Pic.NonVisualDrawingProperties nonVisualDrawingProperties1 = new Pic.NonVisualDrawingProperties() { Id = (UInt32Value)30U, Name = "aZanriba.jfif" };
            Pic.NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties1 = new Pic.NonVisualPictureDrawingProperties();

            nonVisualPictureProperties1.Append(nonVisualDrawingProperties1);
            nonVisualPictureProperties1.Append(nonVisualPictureDrawingProperties1);

            Pic.BlipFill blipFill1 = new Pic.BlipFill() { RotateWithShape = true };

            A.Blip blip1 = new A.Blip() { Embed = "rId30" };

            A.BlipExtensionList blipExtensionList1 = new A.BlipExtensionList();

            A.BlipExtension blipExtension1 = new A.BlipExtension() { Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}" };

            A14.UseLocalDpi useLocalDpi1 = new A14.UseLocalDpi() { Val = false };
            useLocalDpi1.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            blipExtension1.Append(useLocalDpi1);

            blipExtensionList1.Append(blipExtension1);

            blip1.Append(blipExtensionList1);
            A.SourceRectangle sourceRectangle1 = new A.SourceRectangle() { Left = 13333, Right = 7334 };
            A.Stretch stretch1 = new A.Stretch();

            blipFill1.Append(blip1);
            blipFill1.Append(sourceRectangle1);
            blipFill1.Append(stretch1);

            Pic.ShapeProperties shapeProperties1 = new Pic.ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D1 = new A.Transform2D();
            A.Offset offset1 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents1 = new A.Extents() { Cx = 1187454L, Cy = 1486814L };

            transform2D1.Append(offset1);
            transform2D1.Append(extents1);

            A.PresetGeometry presetGeometry1 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList1 = new A.AdjustValueList();

            presetGeometry1.Append(adjustValueList1);

            A.Outline outline1 = new A.Outline();
            A.NoFill noFill1 = new A.NoFill();

            outline1.Append(noFill1);

            A.ShapePropertiesExtensionList shapePropertiesExtensionList1 = new A.ShapePropertiesExtensionList();

            A.ShapePropertiesExtension shapePropertiesExtension1 = new A.ShapePropertiesExtension() { Uri = "{53640926-AAD7-44D8-BBD7-CCE9431645EC}" };

            A14.ShadowObscured shadowObscured1 = new A14.ShadowObscured();
            shadowObscured1.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            shapePropertiesExtension1.Append(shadowObscured1);

            shapePropertiesExtensionList1.Append(shapePropertiesExtension1);

            shapeProperties1.Append(transform2D1);
            shapeProperties1.Append(presetGeometry1);
            shapeProperties1.Append(outline1);
            shapeProperties1.Append(shapePropertiesExtensionList1);

            picture1.Append(nonVisualPictureProperties1);
            picture1.Append(blipFill1);
            picture1.Append(shapeProperties1);

            graphicData1.Append(picture1);

            graphic1.Append(graphicData1);

            Wp14.RelativeWidth relativeWidth1 = new Wp14.RelativeWidth() { ObjectId = Wp14.SizeRelativeHorizontallyValues.Page };
            Wp14.PercentageWidth percentageWidth1 = new Wp14.PercentageWidth();
            percentageWidth1.Text = "0";

            relativeWidth1.Append(percentageWidth1);

            Wp14.RelativeHeight relativeHeight1 = new Wp14.RelativeHeight() { RelativeFrom = Wp14.SizeRelativeVerticallyValues.Page };
            Wp14.PercentageHeight percentageHeight1 = new Wp14.PercentageHeight();
            percentageHeight1.Text = "0";

            relativeHeight1.Append(percentageHeight1);

            anchor1.Append(simplePosition1);
            anchor1.Append(horizontalPosition1);
            anchor1.Append(verticalPosition1);
            anchor1.Append(extent1);
            anchor1.Append(effectExtent1);
            anchor1.Append(wrapNone1);
            anchor1.Append(docProperties1);
            anchor1.Append(nonVisualGraphicFrameDrawingProperties1);
            anchor1.Append(graphic1);
            anchor1.Append(relativeWidth1);
            anchor1.Append(relativeHeight1);

            drawing1.Append(anchor1);

            run1.Append(runProperties1);
            run1.Append(drawing1);
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd() { Id = "0" };

            Run run2 = new Run();

            RunProperties runProperties2 = new RunProperties();
            FontSize fontSize1 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript() { Val = "22" };

            runProperties2.Append(fontSize1);
            runProperties2.Append(fontSizeComplexScript1);
            Break break1 = new Break() { Type = BreakValues.TextWrapping, Clear = BreakTextRestartLocationValues.All };

            run2.Append(runProperties2);
            run2.Append(break1);

            Run run3 = new Run() { RsidRunAddition = "009E39C2" };

            RunProperties runProperties3 = new RunProperties();
            FontSize fontSize2 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript2 = new FontSizeComplexScript() { Val = "22" };

            runProperties3.Append(fontSize2);
            runProperties3.Append(fontSizeComplexScript2);
            Text text1 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text1.Text = "  ";

            run3.Append(runProperties3);
            run3.Append(text1);

            paragraph1.Append(bookmarkStart1);
            paragraph1.Append(run1);
            paragraph1.Append(bookmarkEnd1);
            paragraph1.Append(run2);
            paragraph1.Append(run3);
            return paragraph1;

        }


    }
}
