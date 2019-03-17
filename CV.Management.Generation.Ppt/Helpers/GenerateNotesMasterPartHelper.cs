using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;
using Ap = DocumentFormat.OpenXml.ExtendedProperties;
using Vt = DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Presentation;
using A = DocumentFormat.OpenXml.Drawing;
using P15 = DocumentFormat.OpenXml.Office2013.PowerPoint;
using Ds = DocumentFormat.OpenXml.CustomXmlDataProperties;
using P14 = DocumentFormat.OpenXml.Office2010.PowerPoint;
using Thm15 = DocumentFormat.OpenXml.Office2013.Theme;
using A14 = DocumentFormat.OpenXml.Office2010.Drawing;
using Op = DocumentFormat.OpenXml.CustomProperties;
using System.IO;
using CV.Management.Generation.Ppt.Helpers;

namespace CV.Management.Generation.Ppt.Helpers
{
    public static class GenerateNotesMasterPartHelper
    {
        public static void GenerateNotesMasterPart1Content(NotesMasterPart notesMasterPart1)
        {
            NotesMaster notesMaster1 = new NotesMaster();
            notesMaster1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            notesMaster1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            notesMaster1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData2 = new CommonSlideData();

            Background background2 = new Background();

            BackgroundProperties backgroundProperties1 = new BackgroundProperties();

            A.SolidFill solidFill31 = new A.SolidFill();
            A.SchemeColor schemeColor46 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill31.Append(schemeColor46);
            A.EffectList effectList4 = new A.EffectList();

            backgroundProperties1.Append(solidFill31);
            backgroundProperties1.Append(effectList4);

            background2.Append(backgroundProperties1);

            ShapeTree shapeTree2 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties2 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties6 = new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties2 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties6 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties2.Append(nonVisualDrawingProperties6);
            nonVisualGroupShapeProperties2.Append(nonVisualGroupShapeDrawingProperties2);
            nonVisualGroupShapeProperties2.Append(applicationNonVisualDrawingProperties6);

            GroupShapeProperties groupShapeProperties2 = new GroupShapeProperties();

            A.TransformGroup transformGroup2 = new A.TransformGroup();
            A.Offset offset6 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents6 = new A.Extents() { Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset2 = new A.ChildOffset() { X = 0L, Y = 0L };
            A.ChildExtents childExtents2 = new A.ChildExtents() { Cx = 0L, Cy = 0L };

            transformGroup2.Append(offset6);
            transformGroup2.Append(extents6);
            transformGroup2.Append(childOffset2);
            transformGroup2.Append(childExtents2);

            groupShapeProperties2.Append(transformGroup2);

            Shape shape5 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties5 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties7 = new NonVisualDrawingProperties() { Id = (UInt32Value)3074U, Name = "Rectangle 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties5 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks5 = new A.ShapeLocks() { NoGrouping = true, NoChangeArrowheads = true };

            nonVisualShapeDrawingProperties5.Append(shapeLocks5);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties7 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape5 = new PlaceholderShape() { Type = PlaceholderValues.Header, Size = PlaceholderSizeValues.Quarter };

            applicationNonVisualDrawingProperties7.Append(placeholderShape5);

            nonVisualShapeProperties5.Append(nonVisualDrawingProperties7);
            nonVisualShapeProperties5.Append(nonVisualShapeDrawingProperties5);
            nonVisualShapeProperties5.Append(applicationNonVisualDrawingProperties7);

            ShapeProperties shapeProperties5 = new ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D5 = new A.Transform2D();
            A.Offset offset7 = new A.Offset() { X = 0L, Y = 1L };
            A.Extents extents7 = new A.Extents() { Cx = 2944813L, Cy = 493713L };

            transform2D5.Append(offset7);
            transform2D5.Append(extents7);

            A.PresetGeometry presetGeometry5 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList5 = new A.AdjustValueList();

            presetGeometry5.Append(adjustValueList5);
            A.NoFill noFill1 = new A.NoFill();

            A.Outline outline12 = new A.Outline() { Width = 9525 };
            A.NoFill noFill2 = new A.NoFill();
            A.Miter miter4 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd1 = new A.HeadEnd();
            A.TailEnd tailEnd1 = new A.TailEnd();

            outline12.Append(noFill2);
            outline12.Append(miter4);
            outline12.Append(headEnd1);
            outline12.Append(tailEnd1);

            shapeProperties5.Append(transform2D5);
            shapeProperties5.Append(presetGeometry5);
            shapeProperties5.Append(noFill1);
            shapeProperties5.Append(outline12);

            TextBody textBody5 = new TextBody();

            A.BodyProperties bodyProperties5 = new A.BodyProperties() { Vertical = A.TextVerticalValues.Horizontal, Wrap = A.TextWrappingValues.Square, LeftInset = 90664, TopInset = 45333, RightInset = 90664, BottomInset = 45333, ColumnCount = 1, Anchor = A.TextAnchoringTypeValues.Top, AnchorCenter = false, CompatibleLineSpacing = true };

            A.PresetTextWrap presetTextWrap1 = new A.PresetTextWrap() { Preset = A.TextShapeValues.TextNoShape };
            A.AdjustValueList adjustValueList6 = new A.AdjustValueList();

            presetTextWrap1.Append(adjustValueList6);

            bodyProperties5.Append(presetTextWrap1);

            A.ListStyle listStyle5 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties6 = new A.Level1ParagraphProperties() { EastAsianLineBreak = false, Height = false };

            A.DefaultRunProperties defaultRunProperties15 = new A.DefaultRunProperties() { FontSize = 1200 };
            A.LatinFont latinFont12 = new A.LatinFont() { Typeface = "Arial", CharacterSet = 0 };
            A.EastAsianFont eastAsianFont12 = new A.EastAsianFont() { Typeface = "ＭＳ Ｐゴシック", PitchFamily = 1, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont12 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties15.Append(latinFont12);
            defaultRunProperties15.Append(eastAsianFont12);
            defaultRunProperties15.Append(complexScriptFont12);

            level1ParagraphProperties6.Append(defaultRunProperties15);

            listStyle5.Append(level1ParagraphProperties6);

            A.Paragraph paragraph5 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties1 = new A.ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties16 = new A.DefaultRunProperties();

            paragraphProperties1.Append(defaultRunProperties16);
            A.EndParagraphRunProperties endParagraphRunProperties5 = new A.EndParagraphRunProperties() { Language = "en-US" };

            paragraph5.Append(paragraphProperties1);
            paragraph5.Append(endParagraphRunProperties5);

            textBody5.Append(bodyProperties5);
            textBody5.Append(listStyle5);
            textBody5.Append(paragraph5);

            shape5.Append(nonVisualShapeProperties5);
            shape5.Append(shapeProperties5);
            shape5.Append(textBody5);

            Shape shape6 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties6 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties8 = new NonVisualDrawingProperties() { Id = (UInt32Value)3075U, Name = "Rectangle 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties6 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks6 = new A.ShapeLocks() { NoGrouping = true, NoChangeArrowheads = true };

            nonVisualShapeDrawingProperties6.Append(shapeLocks6);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties8 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape6 = new PlaceholderShape() { Type = PlaceholderValues.DateAndTime, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties8.Append(placeholderShape6);

            nonVisualShapeProperties6.Append(nonVisualDrawingProperties8);
            nonVisualShapeProperties6.Append(nonVisualShapeDrawingProperties6);
            nonVisualShapeProperties6.Append(applicationNonVisualDrawingProperties8);

            ShapeProperties shapeProperties6 = new ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D6 = new A.Transform2D();
            A.Offset offset8 = new A.Offset() { X = 3852863L, Y = 1L };
            A.Extents extents8 = new A.Extents() { Cx = 2944812L, Cy = 493713L };

            transform2D6.Append(offset8);
            transform2D6.Append(extents8);

            A.PresetGeometry presetGeometry6 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList7 = new A.AdjustValueList();

            presetGeometry6.Append(adjustValueList7);
            A.NoFill noFill3 = new A.NoFill();

            A.Outline outline13 = new A.Outline() { Width = 9525 };
            A.NoFill noFill4 = new A.NoFill();
            A.Miter miter5 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd2 = new A.HeadEnd();
            A.TailEnd tailEnd2 = new A.TailEnd();

            outline13.Append(noFill4);
            outline13.Append(miter5);
            outline13.Append(headEnd2);
            outline13.Append(tailEnd2);

            shapeProperties6.Append(transform2D6);
            shapeProperties6.Append(presetGeometry6);
            shapeProperties6.Append(noFill3);
            shapeProperties6.Append(outline13);

            TextBody textBody6 = new TextBody();

            A.BodyProperties bodyProperties6 = new A.BodyProperties() { Vertical = A.TextVerticalValues.Horizontal, Wrap = A.TextWrappingValues.Square, LeftInset = 90664, TopInset = 45333, RightInset = 90664, BottomInset = 45333, ColumnCount = 1, Anchor = A.TextAnchoringTypeValues.Top, AnchorCenter = false, CompatibleLineSpacing = true };

            A.PresetTextWrap presetTextWrap2 = new A.PresetTextWrap() { Preset = A.TextShapeValues.TextNoShape };
            A.AdjustValueList adjustValueList8 = new A.AdjustValueList();

            presetTextWrap2.Append(adjustValueList8);

            bodyProperties6.Append(presetTextWrap2);

            A.ListStyle listStyle6 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties7 = new A.Level1ParagraphProperties() { Alignment = A.TextAlignmentTypeValues.Right, EastAsianLineBreak = false, Height = false };

            A.DefaultRunProperties defaultRunProperties17 = new A.DefaultRunProperties() { FontSize = 1200 };
            A.LatinFont latinFont13 = new A.LatinFont() { Typeface = "Arial", CharacterSet = 0 };
            A.EastAsianFont eastAsianFont13 = new A.EastAsianFont() { Typeface = "ＭＳ Ｐゴシック", PitchFamily = 1, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont13 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties17.Append(latinFont13);
            defaultRunProperties17.Append(eastAsianFont13);
            defaultRunProperties17.Append(complexScriptFont13);

            level1ParagraphProperties7.Append(defaultRunProperties17);

            listStyle6.Append(level1ParagraphProperties7);

            A.Paragraph paragraph6 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties2 = new A.ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties18 = new A.DefaultRunProperties();

            paragraphProperties2.Append(defaultRunProperties18);
            A.EndParagraphRunProperties endParagraphRunProperties6 = new A.EndParagraphRunProperties() { Language = "en-US" };

            paragraph6.Append(paragraphProperties2);
            paragraph6.Append(endParagraphRunProperties6);

            textBody6.Append(bodyProperties6);
            textBody6.Append(listStyle6);
            textBody6.Append(paragraph6);

            shape6.Append(nonVisualShapeProperties6);
            shape6.Append(shapeProperties6);
            shape6.Append(textBody6);

            Shape shape7 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties7 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties9 = new NonVisualDrawingProperties() { Id = (UInt32Value)3076U, Name = "Rectangle 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties7 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks7 = new A.ShapeLocks() { NoGrouping = true, NoRotation = true, NoChangeAspect = true, NoChangeArrowheads = true, NoTextEdit = true };

            nonVisualShapeDrawingProperties7.Append(shapeLocks7);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties9 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape7 = new PlaceholderShape() { Type = PlaceholderValues.SlideImage, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties9.Append(placeholderShape7);

            nonVisualShapeProperties7.Append(nonVisualDrawingProperties9);
            nonVisualShapeProperties7.Append(nonVisualShapeDrawingProperties7);
            nonVisualShapeProperties7.Append(applicationNonVisualDrawingProperties9);

            ShapeProperties shapeProperties7 = new ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D7 = new A.Transform2D();
            A.Offset offset9 = new A.Offset() { X = 723900L, Y = 739775L };
            A.Extents extents9 = new A.Extents() { Cx = 5349875L, Cy = 3703638L };

            transform2D7.Append(offset9);
            transform2D7.Append(extents9);

            A.PresetGeometry presetGeometry7 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList9 = new A.AdjustValueList();

            presetGeometry7.Append(adjustValueList9);
            A.NoFill noFill5 = new A.NoFill();

            A.Outline outline14 = new A.Outline() { Width = 9525 };

            A.SolidFill solidFill32 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex29 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill32.Append(rgbColorModelHex29);
            A.Miter miter6 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd3 = new A.HeadEnd();
            A.TailEnd tailEnd3 = new A.TailEnd();

            outline14.Append(solidFill32);
            outline14.Append(miter6);
            outline14.Append(headEnd3);
            outline14.Append(tailEnd3);

            A.ShapePropertiesExtensionList shapePropertiesExtensionList1 = new A.ShapePropertiesExtensionList();

            A.ShapePropertiesExtension shapePropertiesExtension1 = new A.ShapePropertiesExtension() { Uri = "{909E8E84-426E-40DD-AFC4-6F175D3DCCD1}" };

            A14.HiddenFillProperties hiddenFillProperties1 = new A14.HiddenFillProperties();
            hiddenFillProperties1.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill33 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex30 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            solidFill33.Append(rgbColorModelHex30);

            hiddenFillProperties1.Append(solidFill33);

            shapePropertiesExtension1.Append(hiddenFillProperties1);

            shapePropertiesExtensionList1.Append(shapePropertiesExtension1);

            shapeProperties7.Append(transform2D7);
            shapeProperties7.Append(presetGeometry7);
            shapeProperties7.Append(noFill5);
            shapeProperties7.Append(outline14);
            shapeProperties7.Append(shapePropertiesExtensionList1);

            shape7.Append(nonVisualShapeProperties7);
            shape7.Append(shapeProperties7);

            Shape shape8 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties8 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties10 = new NonVisualDrawingProperties() { Id = (UInt32Value)3077U, Name = "Rectangle 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties8 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks8 = new A.ShapeLocks() { NoGrouping = true, NoChangeArrowheads = true };

            nonVisualShapeDrawingProperties8.Append(shapeLocks8);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties10 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape8 = new PlaceholderShape() { Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)3U };

            applicationNonVisualDrawingProperties10.Append(placeholderShape8);

            nonVisualShapeProperties8.Append(nonVisualDrawingProperties10);
            nonVisualShapeProperties8.Append(nonVisualShapeDrawingProperties8);
            nonVisualShapeProperties8.Append(applicationNonVisualDrawingProperties10);

            ShapeProperties shapeProperties8 = new ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D8 = new A.Transform2D();
            A.Offset offset10 = new A.Offset() { X = 906463L, Y = 4689476L };
            A.Extents extents10 = new A.Extents() { Cx = 4984750L, Cy = 4445000L };

            transform2D8.Append(offset10);
            transform2D8.Append(extents10);

            A.PresetGeometry presetGeometry8 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList10 = new A.AdjustValueList();

            presetGeometry8.Append(adjustValueList10);
            A.NoFill noFill6 = new A.NoFill();

            A.Outline outline15 = new A.Outline() { Width = 9525 };
            A.NoFill noFill7 = new A.NoFill();
            A.Miter miter7 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd4 = new A.HeadEnd();
            A.TailEnd tailEnd4 = new A.TailEnd();

            outline15.Append(noFill7);
            outline15.Append(miter7);
            outline15.Append(headEnd4);
            outline15.Append(tailEnd4);

            shapeProperties8.Append(transform2D8);
            shapeProperties8.Append(presetGeometry8);
            shapeProperties8.Append(noFill6);
            shapeProperties8.Append(outline15);

            TextBody textBody7 = new TextBody();

            A.BodyProperties bodyProperties7 = new A.BodyProperties() { Vertical = A.TextVerticalValues.Horizontal, Wrap = A.TextWrappingValues.Square, LeftInset = 90664, TopInset = 45333, RightInset = 90664, BottomInset = 45333, ColumnCount = 1, Anchor = A.TextAnchoringTypeValues.Top, AnchorCenter = false, CompatibleLineSpacing = true };

            A.PresetTextWrap presetTextWrap3 = new A.PresetTextWrap() { Preset = A.TextShapeValues.TextNoShape };
            A.AdjustValueList adjustValueList11 = new A.AdjustValueList();

            presetTextWrap3.Append(adjustValueList11);

            bodyProperties7.Append(presetTextWrap3);
            A.ListStyle listStyle7 = new A.ListStyle();

            A.Paragraph paragraph7 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties3 = new A.ParagraphProperties() { Level = 0 };

            A.Run run1 = new A.Run();
            A.RunProperties runProperties3 = new A.RunProperties() { Language = "en-US", NoProof = false };
            A.Text text3 = new A.Text();
            text3.Text = "Click to edit Master text styles";

            run1.Append(runProperties3);
            run1.Append(text3);

            paragraph7.Append(paragraphProperties3);
            paragraph7.Append(run1);

            A.Paragraph paragraph8 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties4 = new A.ParagraphProperties() { Level = 1 };

            A.Run run2 = new A.Run();
            A.RunProperties runProperties4 = new A.RunProperties() { Language = "en-US", NoProof = false };
            A.Text text4 = new A.Text();
            text4.Text = "Second level";

            run2.Append(runProperties4);
            run2.Append(text4);

            paragraph8.Append(paragraphProperties4);
            paragraph8.Append(run2);

            A.Paragraph paragraph9 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties5 = new A.ParagraphProperties() { Level = 2 };

            A.Run run3 = new A.Run();
            A.RunProperties runProperties5 = new A.RunProperties() { Language = "en-US", NoProof = false };
            A.Text text5 = new A.Text();
            text5.Text = "Third level";

            run3.Append(runProperties5);
            run3.Append(text5);

            paragraph9.Append(paragraphProperties5);
            paragraph9.Append(run3);

            A.Paragraph paragraph10 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties6 = new A.ParagraphProperties() { Level = 3 };

            A.Run run4 = new A.Run();
            A.RunProperties runProperties6 = new A.RunProperties() { Language = "en-US", NoProof = false };
            A.Text text6 = new A.Text();
            text6.Text = "Fourth level";

            run4.Append(runProperties6);
            run4.Append(text6);

            paragraph10.Append(paragraphProperties6);
            paragraph10.Append(run4);

            A.Paragraph paragraph11 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties7 = new A.ParagraphProperties() { Level = 4 };

            A.Run run5 = new A.Run();
            A.RunProperties runProperties7 = new A.RunProperties() { Language = "en-US", NoProof = false };
            A.Text text7 = new A.Text();
            text7.Text = "Fifth level";

            run5.Append(runProperties7);
            run5.Append(text7);

            paragraph11.Append(paragraphProperties7);
            paragraph11.Append(run5);

            textBody7.Append(bodyProperties7);
            textBody7.Append(listStyle7);
            textBody7.Append(paragraph7);
            textBody7.Append(paragraph8);
            textBody7.Append(paragraph9);
            textBody7.Append(paragraph10);
            textBody7.Append(paragraph11);

            shape8.Append(nonVisualShapeProperties8);
            shape8.Append(shapeProperties8);
            shape8.Append(textBody7);

            Shape shape9 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties9 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties11 = new NonVisualDrawingProperties() { Id = (UInt32Value)3078U, Name = "Rectangle 6" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties9 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks9 = new A.ShapeLocks() { NoGrouping = true, NoChangeArrowheads = true };

            nonVisualShapeDrawingProperties9.Append(shapeLocks9);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties11 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape9 = new PlaceholderShape() { Type = PlaceholderValues.Footer, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)4U };

            applicationNonVisualDrawingProperties11.Append(placeholderShape9);

            nonVisualShapeProperties9.Append(nonVisualDrawingProperties11);
            nonVisualShapeProperties9.Append(nonVisualShapeDrawingProperties9);
            nonVisualShapeProperties9.Append(applicationNonVisualDrawingProperties11);

            ShapeProperties shapeProperties9 = new ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D9 = new A.Transform2D();
            A.Offset offset11 = new A.Offset() { X = 0L, Y = 9380539L };
            A.Extents extents11 = new A.Extents() { Cx = 2944813L, Cy = 493712L };

            transform2D9.Append(offset11);
            transform2D9.Append(extents11);

            A.PresetGeometry presetGeometry9 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList12 = new A.AdjustValueList();

            presetGeometry9.Append(adjustValueList12);
            A.NoFill noFill8 = new A.NoFill();

            A.Outline outline16 = new A.Outline() { Width = 9525 };
            A.NoFill noFill9 = new A.NoFill();
            A.Miter miter8 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd5 = new A.HeadEnd();
            A.TailEnd tailEnd5 = new A.TailEnd();

            outline16.Append(noFill9);
            outline16.Append(miter8);
            outline16.Append(headEnd5);
            outline16.Append(tailEnd5);

            shapeProperties9.Append(transform2D9);
            shapeProperties9.Append(presetGeometry9);
            shapeProperties9.Append(noFill8);
            shapeProperties9.Append(outline16);

            TextBody textBody8 = new TextBody();

            A.BodyProperties bodyProperties8 = new A.BodyProperties() { Vertical = A.TextVerticalValues.Horizontal, Wrap = A.TextWrappingValues.Square, LeftInset = 90664, TopInset = 45333, RightInset = 90664, BottomInset = 45333, ColumnCount = 1, Anchor = A.TextAnchoringTypeValues.Bottom, AnchorCenter = false, CompatibleLineSpacing = true };

            A.PresetTextWrap presetTextWrap4 = new A.PresetTextWrap() { Preset = A.TextShapeValues.TextNoShape };
            A.AdjustValueList adjustValueList13 = new A.AdjustValueList();

            presetTextWrap4.Append(adjustValueList13);

            bodyProperties8.Append(presetTextWrap4);

            A.ListStyle listStyle8 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties8 = new A.Level1ParagraphProperties() { EastAsianLineBreak = false, Height = false };

            A.DefaultRunProperties defaultRunProperties19 = new A.DefaultRunProperties() { FontSize = 1200 };
            A.LatinFont latinFont14 = new A.LatinFont() { Typeface = "Arial", CharacterSet = 0 };
            A.EastAsianFont eastAsianFont14 = new A.EastAsianFont() { Typeface = "ＭＳ Ｐゴシック", PitchFamily = 1, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont14 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties19.Append(latinFont14);
            defaultRunProperties19.Append(eastAsianFont14);
            defaultRunProperties19.Append(complexScriptFont14);

            level1ParagraphProperties8.Append(defaultRunProperties19);

            listStyle8.Append(level1ParagraphProperties8);

            A.Paragraph paragraph12 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties8 = new A.ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties20 = new A.DefaultRunProperties();

            paragraphProperties8.Append(defaultRunProperties20);
            A.EndParagraphRunProperties endParagraphRunProperties7 = new A.EndParagraphRunProperties() { Language = "en-US" };

            paragraph12.Append(paragraphProperties8);
            paragraph12.Append(endParagraphRunProperties7);

            textBody8.Append(bodyProperties8);
            textBody8.Append(listStyle8);
            textBody8.Append(paragraph12);

            shape9.Append(nonVisualShapeProperties9);
            shape9.Append(shapeProperties9);
            shape9.Append(textBody8);

            Shape shape10 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties10 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties12 = new NonVisualDrawingProperties() { Id = (UInt32Value)3079U, Name = "Rectangle 7" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties10 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks10 = new A.ShapeLocks() { NoGrouping = true, NoChangeArrowheads = true };

            nonVisualShapeDrawingProperties10.Append(shapeLocks10);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties12 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape10 = new PlaceholderShape() { Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)5U };

            applicationNonVisualDrawingProperties12.Append(placeholderShape10);

            nonVisualShapeProperties10.Append(nonVisualDrawingProperties12);
            nonVisualShapeProperties10.Append(nonVisualShapeDrawingProperties10);
            nonVisualShapeProperties10.Append(applicationNonVisualDrawingProperties12);

            ShapeProperties shapeProperties10 = new ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D10 = new A.Transform2D();
            A.Offset offset12 = new A.Offset() { X = 3852863L, Y = 9380539L };
            A.Extents extents12 = new A.Extents() { Cx = 2944812L, Cy = 493712L };

            transform2D10.Append(offset12);
            transform2D10.Append(extents12);

            A.PresetGeometry presetGeometry10 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList14 = new A.AdjustValueList();

            presetGeometry10.Append(adjustValueList14);
            A.NoFill noFill10 = new A.NoFill();

            A.Outline outline17 = new A.Outline() { Width = 9525 };
            A.NoFill noFill11 = new A.NoFill();
            A.Miter miter9 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd6 = new A.HeadEnd();
            A.TailEnd tailEnd6 = new A.TailEnd();

            outline17.Append(noFill11);
            outline17.Append(miter9);
            outline17.Append(headEnd6);
            outline17.Append(tailEnd6);

            shapeProperties10.Append(transform2D10);
            shapeProperties10.Append(presetGeometry10);
            shapeProperties10.Append(noFill10);
            shapeProperties10.Append(outline17);

            TextBody textBody9 = new TextBody();

            A.BodyProperties bodyProperties9 = new A.BodyProperties() { Vertical = A.TextVerticalValues.Horizontal, Wrap = A.TextWrappingValues.Square, LeftInset = 90664, TopInset = 45333, RightInset = 90664, BottomInset = 45333, ColumnCount = 1, Anchor = A.TextAnchoringTypeValues.Bottom, AnchorCenter = false, CompatibleLineSpacing = true };

            A.PresetTextWrap presetTextWrap5 = new A.PresetTextWrap() { Preset = A.TextShapeValues.TextNoShape };
            A.AdjustValueList adjustValueList15 = new A.AdjustValueList();

            presetTextWrap5.Append(adjustValueList15);

            bodyProperties9.Append(presetTextWrap5);

            A.ListStyle listStyle9 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties9 = new A.Level1ParagraphProperties() { Alignment = A.TextAlignmentTypeValues.Right };
            A.DefaultRunProperties defaultRunProperties21 = new A.DefaultRunProperties() { FontSize = 1200 };

            level1ParagraphProperties9.Append(defaultRunProperties21);

            listStyle9.Append(level1ParagraphProperties9);

            A.Paragraph paragraph13 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties9 = new A.ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties22 = new A.DefaultRunProperties();

            paragraphProperties9.Append(defaultRunProperties22);

            A.Field field3 = new A.Field() { Id = "{722524F9-6949-4819-BBB5-840FCB7E5F2E}", Type = "slidenum" };
            A.RunProperties runProperties8 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "lv-LV" };

            A.ParagraphProperties paragraphProperties10 = new A.ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties23 = new A.DefaultRunProperties();

            paragraphProperties10.Append(defaultRunProperties23);
            A.Text text8 = new A.Text();
            text8.Text = "‹#›";

            field3.Append(runProperties8);
            field3.Append(paragraphProperties10);
            field3.Append(text8);
            A.EndParagraphRunProperties endParagraphRunProperties8 = new A.EndParagraphRunProperties() { Language = "en-US", AlternativeLanguage = "lv-LV" };

            paragraph13.Append(paragraphProperties9);
            paragraph13.Append(field3);
            paragraph13.Append(endParagraphRunProperties8);

            textBody9.Append(bodyProperties9);
            textBody9.Append(listStyle9);
            textBody9.Append(paragraph13);

            shape10.Append(nonVisualShapeProperties10);
            shape10.Append(shapeProperties10);
            shape10.Append(textBody9);

            shapeTree2.Append(nonVisualGroupShapeProperties2);
            shapeTree2.Append(groupShapeProperties2);
            shapeTree2.Append(shape5);
            shapeTree2.Append(shape6);
            shapeTree2.Append(shape7);
            shapeTree2.Append(shape8);
            shapeTree2.Append(shape9);
            shapeTree2.Append(shape10);

            CommonSlideDataExtensionList commonSlideDataExtensionList2 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension2 = new CommonSlideDataExtension() { Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId2 = new P14.CreationId() { Val = (UInt32Value)2843136524U };
            creationId2.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension2.Append(creationId2);

            commonSlideDataExtensionList2.Append(commonSlideDataExtension2);

            commonSlideData2.Append(background2);
            commonSlideData2.Append(shapeTree2);
            commonSlideData2.Append(commonSlideDataExtensionList2);
            ColorMap colorMap2 = new ColorMap() { Background1 = A.ColorSchemeIndexValues.Light1, Text1 = A.ColorSchemeIndexValues.Dark1, Background2 = A.ColorSchemeIndexValues.Light2, Text2 = A.ColorSchemeIndexValues.Dark2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            NotesStyle notesStyle1 = new NotesStyle();

            A.Level1ParagraphProperties level1ParagraphProperties10 = new A.Level1ParagraphProperties() { Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore6 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent11 = new A.SpacingPercent() { Val = 30000 };

            spaceBefore6.Append(spacingPercent11);

            A.SpaceAfter spaceAfter6 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent12 = new A.SpacingPercent() { Val = 0 };

            spaceAfter6.Append(spacingPercent12);

            A.DefaultRunProperties defaultRunProperties24 = new A.DefaultRunProperties() { FontSize = 1200, Kerning = 1200 };

            A.SolidFill solidFill34 = new A.SolidFill();
            A.SchemeColor schemeColor47 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill34.Append(schemeColor47);
            A.LatinFont latinFont15 = new A.LatinFont() { Typeface = "Arial", CharacterSet = 0 };
            A.EastAsianFont eastAsianFont15 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont15 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties24.Append(solidFill34);
            defaultRunProperties24.Append(latinFont15);
            defaultRunProperties24.Append(eastAsianFont15);
            defaultRunProperties24.Append(complexScriptFont15);

            level1ParagraphProperties10.Append(spaceBefore6);
            level1ParagraphProperties10.Append(spaceAfter6);
            level1ParagraphProperties10.Append(defaultRunProperties24);

            A.Level2ParagraphProperties level2ParagraphProperties2 = new A.Level2ParagraphProperties() { LeftMargin = 457200, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore7 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent13 = new A.SpacingPercent() { Val = 30000 };

            spaceBefore7.Append(spacingPercent13);

            A.SpaceAfter spaceAfter7 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent14 = new A.SpacingPercent() { Val = 0 };

            spaceAfter7.Append(spacingPercent14);

            A.DefaultRunProperties defaultRunProperties25 = new A.DefaultRunProperties() { FontSize = 1200, Kerning = 1200 };

            A.SolidFill solidFill35 = new A.SolidFill();
            A.SchemeColor schemeColor48 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill35.Append(schemeColor48);
            A.LatinFont latinFont16 = new A.LatinFont() { Typeface = "Arial", CharacterSet = 0 };
            A.EastAsianFont eastAsianFont16 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont16 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties25.Append(solidFill35);
            defaultRunProperties25.Append(latinFont16);
            defaultRunProperties25.Append(eastAsianFont16);
            defaultRunProperties25.Append(complexScriptFont16);

            level2ParagraphProperties2.Append(spaceBefore7);
            level2ParagraphProperties2.Append(spaceAfter7);
            level2ParagraphProperties2.Append(defaultRunProperties25);

            A.Level3ParagraphProperties level3ParagraphProperties2 = new A.Level3ParagraphProperties() { LeftMargin = 914400, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore8 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent15 = new A.SpacingPercent() { Val = 30000 };

            spaceBefore8.Append(spacingPercent15);

            A.SpaceAfter spaceAfter8 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent16 = new A.SpacingPercent() { Val = 0 };

            spaceAfter8.Append(spacingPercent16);

            A.DefaultRunProperties defaultRunProperties26 = new A.DefaultRunProperties() { FontSize = 1200, Kerning = 1200 };

            A.SolidFill solidFill36 = new A.SolidFill();
            A.SchemeColor schemeColor49 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill36.Append(schemeColor49);
            A.LatinFont latinFont17 = new A.LatinFont() { Typeface = "Arial", CharacterSet = 0 };
            A.EastAsianFont eastAsianFont17 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont17 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties26.Append(solidFill36);
            defaultRunProperties26.Append(latinFont17);
            defaultRunProperties26.Append(eastAsianFont17);
            defaultRunProperties26.Append(complexScriptFont17);

            level3ParagraphProperties2.Append(spaceBefore8);
            level3ParagraphProperties2.Append(spaceAfter8);
            level3ParagraphProperties2.Append(defaultRunProperties26);

            A.Level4ParagraphProperties level4ParagraphProperties2 = new A.Level4ParagraphProperties() { LeftMargin = 1371600, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore9 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent17 = new A.SpacingPercent() { Val = 30000 };

            spaceBefore9.Append(spacingPercent17);

            A.SpaceAfter spaceAfter9 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent18 = new A.SpacingPercent() { Val = 0 };

            spaceAfter9.Append(spacingPercent18);

            A.DefaultRunProperties defaultRunProperties27 = new A.DefaultRunProperties() { FontSize = 1200, Kerning = 1200 };

            A.SolidFill solidFill37 = new A.SolidFill();
            A.SchemeColor schemeColor50 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill37.Append(schemeColor50);
            A.LatinFont latinFont18 = new A.LatinFont() { Typeface = "Arial", CharacterSet = 0 };
            A.EastAsianFont eastAsianFont18 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont18 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties27.Append(solidFill37);
            defaultRunProperties27.Append(latinFont18);
            defaultRunProperties27.Append(eastAsianFont18);
            defaultRunProperties27.Append(complexScriptFont18);

            level4ParagraphProperties2.Append(spaceBefore9);
            level4ParagraphProperties2.Append(spaceAfter9);
            level4ParagraphProperties2.Append(defaultRunProperties27);

            A.Level5ParagraphProperties level5ParagraphProperties2 = new A.Level5ParagraphProperties() { LeftMargin = 1828800, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore10 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent19 = new A.SpacingPercent() { Val = 30000 };

            spaceBefore10.Append(spacingPercent19);

            A.SpaceAfter spaceAfter10 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent20 = new A.SpacingPercent() { Val = 0 };

            spaceAfter10.Append(spacingPercent20);

            A.DefaultRunProperties defaultRunProperties28 = new A.DefaultRunProperties() { FontSize = 1200, Kerning = 1200 };

            A.SolidFill solidFill38 = new A.SolidFill();
            A.SchemeColor schemeColor51 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill38.Append(schemeColor51);
            A.LatinFont latinFont19 = new A.LatinFont() { Typeface = "Arial", CharacterSet = 0 };
            A.EastAsianFont eastAsianFont19 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont19 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties28.Append(solidFill38);
            defaultRunProperties28.Append(latinFont19);
            defaultRunProperties28.Append(eastAsianFont19);
            defaultRunProperties28.Append(complexScriptFont19);

            level5ParagraphProperties2.Append(spaceBefore10);
            level5ParagraphProperties2.Append(spaceAfter10);
            level5ParagraphProperties2.Append(defaultRunProperties28);

            A.Level6ParagraphProperties level6ParagraphProperties2 = new A.Level6ParagraphProperties() { LeftMargin = 2286000, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties29 = new A.DefaultRunProperties() { FontSize = 1200, Kerning = 1200 };

            A.SolidFill solidFill39 = new A.SolidFill();
            A.SchemeColor schemeColor52 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill39.Append(schemeColor52);
            A.LatinFont latinFont20 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont20 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont20 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties29.Append(solidFill39);
            defaultRunProperties29.Append(latinFont20);
            defaultRunProperties29.Append(eastAsianFont20);
            defaultRunProperties29.Append(complexScriptFont20);

            level6ParagraphProperties2.Append(defaultRunProperties29);

            A.Level7ParagraphProperties level7ParagraphProperties2 = new A.Level7ParagraphProperties() { LeftMargin = 2743200, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties30 = new A.DefaultRunProperties() { FontSize = 1200, Kerning = 1200 };

            A.SolidFill solidFill40 = new A.SolidFill();
            A.SchemeColor schemeColor53 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill40.Append(schemeColor53);
            A.LatinFont latinFont21 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont21 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont21 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties30.Append(solidFill40);
            defaultRunProperties30.Append(latinFont21);
            defaultRunProperties30.Append(eastAsianFont21);
            defaultRunProperties30.Append(complexScriptFont21);

            level7ParagraphProperties2.Append(defaultRunProperties30);

            A.Level8ParagraphProperties level8ParagraphProperties2 = new A.Level8ParagraphProperties() { LeftMargin = 3200400, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties31 = new A.DefaultRunProperties() { FontSize = 1200, Kerning = 1200 };

            A.SolidFill solidFill41 = new A.SolidFill();
            A.SchemeColor schemeColor54 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill41.Append(schemeColor54);
            A.LatinFont latinFont22 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont22 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont22 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties31.Append(solidFill41);
            defaultRunProperties31.Append(latinFont22);
            defaultRunProperties31.Append(eastAsianFont22);
            defaultRunProperties31.Append(complexScriptFont22);

            level8ParagraphProperties2.Append(defaultRunProperties31);

            A.Level9ParagraphProperties level9ParagraphProperties2 = new A.Level9ParagraphProperties() { LeftMargin = 3657600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties32 = new A.DefaultRunProperties() { FontSize = 1200, Kerning = 1200 };

            A.SolidFill solidFill42 = new A.SolidFill();
            A.SchemeColor schemeColor55 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill42.Append(schemeColor55);
            A.LatinFont latinFont23 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont23 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont23 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties32.Append(solidFill42);
            defaultRunProperties32.Append(latinFont23);
            defaultRunProperties32.Append(eastAsianFont23);
            defaultRunProperties32.Append(complexScriptFont23);

            level9ParagraphProperties2.Append(defaultRunProperties32);

            notesStyle1.Append(level1ParagraphProperties10);
            notesStyle1.Append(level2ParagraphProperties2);
            notesStyle1.Append(level3ParagraphProperties2);
            notesStyle1.Append(level4ParagraphProperties2);
            notesStyle1.Append(level5ParagraphProperties2);
            notesStyle1.Append(level6ParagraphProperties2);
            notesStyle1.Append(level7ParagraphProperties2);
            notesStyle1.Append(level8ParagraphProperties2);
            notesStyle1.Append(level9ParagraphProperties2);

            notesMaster1.Append(commonSlideData2);
            notesMaster1.Append(colorMap2);
            notesMaster1.Append(notesStyle1);

            notesMasterPart1.NotesMaster = notesMaster1;
        }
    }
}
