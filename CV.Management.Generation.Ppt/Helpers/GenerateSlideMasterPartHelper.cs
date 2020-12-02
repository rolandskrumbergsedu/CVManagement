using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Presentation;
using A = DocumentFormat.OpenXml.Drawing;
using A14 = DocumentFormat.OpenXml.Office2010.Drawing;
using System;

namespace CV.Management.Generation.Ppt.Helpers
{
    public static class GenerateSlideMasterPartHelper
    {
        public static void GenerateSlideMasterPart1Content(SlideMasterPart slideMasterPart1)
        {
            SlideMaster slideMaster1 = new SlideMaster();
            slideMaster1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideMaster1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideMaster1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData6 = new CommonSlideData();

            Background background3 = new Background();

            BackgroundProperties backgroundProperties2 = new BackgroundProperties();

            A.SolidFill solidFill171 = new A.SolidFill();
            A.SchemeColor schemeColor230 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill171.Append(schemeColor230);
            A.EffectList effectList15 = new A.EffectList();

            backgroundProperties2.Append(solidFill171);
            backgroundProperties2.Append(effectList15);

            background3.Append(backgroundProperties2);

            ShapeTree shapeTree6 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties6 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties26 = new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties6 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties26 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties6.Append(nonVisualDrawingProperties26);
            nonVisualGroupShapeProperties6.Append(nonVisualGroupShapeDrawingProperties6);
            nonVisualGroupShapeProperties6.Append(applicationNonVisualDrawingProperties26);

            GroupShapeProperties groupShapeProperties6 = new GroupShapeProperties();

            A.TransformGroup transformGroup6 = new A.TransformGroup();
            A.Offset offset24 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents24 = new A.Extents() { Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset6 = new A.ChildOffset() { X = 0L, Y = 0L };
            A.ChildExtents childExtents6 = new A.ChildExtents() { Cx = 0L, Cy = 0L };

            transformGroup6.Append(offset24);
            transformGroup6.Append(extents24);
            transformGroup6.Append(childOffset6);
            transformGroup6.Append(childExtents6);

            groupShapeProperties6.Append(transformGroup6);

            Shape shape20 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties20 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties27 = new NonVisualDrawingProperties() { Id = (UInt32Value)1026U, Name = "Rectangle 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties20 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks20 = new A.ShapeLocks() { NoGrouping = true, NoChangeArrowheads = true };

            nonVisualShapeDrawingProperties20.Append(shapeLocks20);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties27 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape15 = new PlaceholderShape() { Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties27.Append(placeholderShape15);

            nonVisualShapeProperties20.Append(nonVisualDrawingProperties27);
            nonVisualShapeProperties20.Append(nonVisualShapeDrawingProperties20);
            nonVisualShapeProperties20.Append(applicationNonVisualDrawingProperties27);

            ShapeProperties shapeProperties23 = new ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D19 = new A.Transform2D();
            A.Offset offset25 = new A.Offset() { X = 577850L, Y = 365125L };
            A.Extents extents25 = new A.Extents() { Cx = 8785225L, Cy = 622300L };

            transform2D19.Append(offset25);
            transform2D19.Append(extents25);

            A.PresetGeometry presetGeometry17 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList26 = new A.AdjustValueList();

            presetGeometry17.Append(adjustValueList26);
            A.NoFill noFill21 = new A.NoFill();

            A.Outline outline36 = new A.Outline();
            A.NoFill noFill22 = new A.NoFill();

            outline36.Append(noFill22);

            A.ShapePropertiesExtensionList shapePropertiesExtensionList9 = new A.ShapePropertiesExtensionList();

            A.ShapePropertiesExtension shapePropertiesExtension11 = new A.ShapePropertiesExtension() { Uri = "{909E8E84-426E-40DD-AFC4-6F175D3DCCD1}" };

            A14.HiddenFillProperties hiddenFillProperties4 = new A14.HiddenFillProperties();
            hiddenFillProperties4.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill172 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex243 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            solidFill172.Append(rgbColorModelHex243);

            hiddenFillProperties4.Append(solidFill172);

            shapePropertiesExtension11.Append(hiddenFillProperties4);

            A.ShapePropertiesExtension shapePropertiesExtension12 = new A.ShapePropertiesExtension() { Uri = "{91240B29-F687-4F45-9708-019B960494DF}" };

            A14.HiddenLineProperties hiddenLineProperties8 = new A14.HiddenLineProperties() { Width = 9525 };
            hiddenLineProperties8.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill173 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex244 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill173.Append(rgbColorModelHex244);
            A.Miter miter17 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd16 = new A.HeadEnd();
            A.TailEnd tailEnd16 = new A.TailEnd();

            hiddenLineProperties8.Append(solidFill173);
            hiddenLineProperties8.Append(miter17);
            hiddenLineProperties8.Append(headEnd16);
            hiddenLineProperties8.Append(tailEnd16);

            shapePropertiesExtension12.Append(hiddenLineProperties8);

            shapePropertiesExtensionList9.Append(shapePropertiesExtension11);
            shapePropertiesExtensionList9.Append(shapePropertiesExtension12);

            shapeProperties23.Append(transform2D19);
            shapeProperties23.Append(presetGeometry17);
            shapeProperties23.Append(noFill21);
            shapeProperties23.Append(outline36);
            shapeProperties23.Append(shapePropertiesExtensionList9);

            TextBody textBody18 = new TextBody();

            A.BodyProperties bodyProperties20 = new A.BodyProperties() { Vertical = A.TextVerticalValues.Horizontal, Wrap = A.TextWrappingValues.Square, LeftInset = 0, TopInset = 0, RightInset = 0, BottomInset = 0, ColumnCount = 1, Anchor = A.TextAnchoringTypeValues.Top, AnchorCenter = false, CompatibleLineSpacing = true };

            A.PresetTextWrap presetTextWrap8 = new A.PresetTextWrap() { Preset = A.TextShapeValues.TextNoShape };
            A.AdjustValueList adjustValueList27 = new A.AdjustValueList();

            presetTextWrap8.Append(adjustValueList27);

            bodyProperties20.Append(presetTextWrap8);
            A.ListStyle listStyle20 = new A.ListStyle();

            A.Paragraph paragraph43 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties40 = new A.ParagraphProperties() { Level = 0 };

            A.Run run39 = new A.Run();
            A.RunProperties runProperties43 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "et-EE" };
            A.Text text43 = new A.Text();
            text43.Text = "Click to edit Master title style";

            run39.Append(runProperties43);
            run39.Append(text43);

            paragraph43.Append(paragraphProperties40);
            paragraph43.Append(run39);

            textBody18.Append(bodyProperties20);
            textBody18.Append(listStyle20);
            textBody18.Append(paragraph43);

            shape20.Append(nonVisualShapeProperties20);
            shape20.Append(shapeProperties23);
            shape20.Append(textBody18);

            Shape shape21 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties21 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties28 = new NonVisualDrawingProperties() { Id = (UInt32Value)1027U, Name = "Rectangle 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties21 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks21 = new A.ShapeLocks() { NoGrouping = true, NoChangeArrowheads = true };

            nonVisualShapeDrawingProperties21.Append(shapeLocks21);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties28 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape16 = new PlaceholderShape() { Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties28.Append(placeholderShape16);

            nonVisualShapeProperties21.Append(nonVisualDrawingProperties28);
            nonVisualShapeProperties21.Append(nonVisualShapeDrawingProperties21);
            nonVisualShapeProperties21.Append(applicationNonVisualDrawingProperties28);

            ShapeProperties shapeProperties24 = new ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D20 = new A.Transform2D();
            A.Offset offset26 = new A.Offset() { X = 573088L, Y = 1525588L };
            A.Extents extents26 = new A.Extents() { Cx = 8755062L, Cy = 3957637L };

            transform2D20.Append(offset26);
            transform2D20.Append(extents26);

            A.PresetGeometry presetGeometry18 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList28 = new A.AdjustValueList();

            presetGeometry18.Append(adjustValueList28);
            A.NoFill noFill23 = new A.NoFill();

            A.Outline outline37 = new A.Outline();
            A.NoFill noFill24 = new A.NoFill();

            outline37.Append(noFill24);

            A.ShapePropertiesExtensionList shapePropertiesExtensionList10 = new A.ShapePropertiesExtensionList();

            A.ShapePropertiesExtension shapePropertiesExtension13 = new A.ShapePropertiesExtension() { Uri = "{909E8E84-426E-40DD-AFC4-6F175D3DCCD1}" };

            A14.HiddenFillProperties hiddenFillProperties5 = new A14.HiddenFillProperties();
            hiddenFillProperties5.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill174 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex245 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            solidFill174.Append(rgbColorModelHex245);

            hiddenFillProperties5.Append(solidFill174);

            shapePropertiesExtension13.Append(hiddenFillProperties5);

            A.ShapePropertiesExtension shapePropertiesExtension14 = new A.ShapePropertiesExtension() { Uri = "{91240B29-F687-4F45-9708-019B960494DF}" };

            A14.HiddenLineProperties hiddenLineProperties9 = new A14.HiddenLineProperties() { Width = 9525 };
            hiddenLineProperties9.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill175 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex246 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill175.Append(rgbColorModelHex246);
            A.Miter miter18 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd17 = new A.HeadEnd();
            A.TailEnd tailEnd17 = new A.TailEnd();

            hiddenLineProperties9.Append(solidFill175);
            hiddenLineProperties9.Append(miter18);
            hiddenLineProperties9.Append(headEnd17);
            hiddenLineProperties9.Append(tailEnd17);

            shapePropertiesExtension14.Append(hiddenLineProperties9);

            shapePropertiesExtensionList10.Append(shapePropertiesExtension13);
            shapePropertiesExtensionList10.Append(shapePropertiesExtension14);

            shapeProperties24.Append(transform2D20);
            shapeProperties24.Append(presetGeometry18);
            shapeProperties24.Append(noFill23);
            shapeProperties24.Append(outline37);
            shapeProperties24.Append(shapePropertiesExtensionList10);

            TextBody textBody19 = new TextBody();

            A.BodyProperties bodyProperties21 = new A.BodyProperties() { Vertical = A.TextVerticalValues.Horizontal, Wrap = A.TextWrappingValues.Square, LeftInset = 0, TopInset = 0, RightInset = 0, BottomInset = 0, ColumnCount = 1, Anchor = A.TextAnchoringTypeValues.Top, AnchorCenter = false, CompatibleLineSpacing = true };

            A.PresetTextWrap presetTextWrap9 = new A.PresetTextWrap() { Preset = A.TextShapeValues.TextNoShape };
            A.AdjustValueList adjustValueList29 = new A.AdjustValueList();

            presetTextWrap9.Append(adjustValueList29);

            bodyProperties21.Append(presetTextWrap9);
            A.ListStyle listStyle21 = new A.ListStyle();

            A.Paragraph paragraph44 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties41 = new A.ParagraphProperties() { Level = 0 };

            A.Run run40 = new A.Run();
            A.RunProperties runProperties44 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "et-EE" };
            A.Text text44 = new A.Text();
            text44.Text = "Click to edit Master text styles";

            run40.Append(runProperties44);
            run40.Append(text44);

            paragraph44.Append(paragraphProperties41);
            paragraph44.Append(run40);

            A.Paragraph paragraph45 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties42 = new A.ParagraphProperties() { Level = 1 };

            A.Run run41 = new A.Run();
            A.RunProperties runProperties45 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "et-EE" };
            A.Text text45 = new A.Text();
            text45.Text = "Second level";

            run41.Append(runProperties45);
            run41.Append(text45);

            paragraph45.Append(paragraphProperties42);
            paragraph45.Append(run41);

            A.Paragraph paragraph46 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties43 = new A.ParagraphProperties() { Level = 2 };

            A.Run run42 = new A.Run();
            A.RunProperties runProperties46 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "et-EE" };
            A.Text text46 = new A.Text();
            text46.Text = "Third level";

            run42.Append(runProperties46);
            run42.Append(text46);

            paragraph46.Append(paragraphProperties43);
            paragraph46.Append(run42);

            A.Paragraph paragraph47 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties44 = new A.ParagraphProperties() { Level = 3 };

            A.Run run43 = new A.Run();
            A.RunProperties runProperties47 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "et-EE" };
            A.Text text47 = new A.Text();
            text47.Text = "Fourth level";

            run43.Append(runProperties47);
            run43.Append(text47);

            paragraph47.Append(paragraphProperties44);
            paragraph47.Append(run43);

            A.Paragraph paragraph48 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties45 = new A.ParagraphProperties() { Level = 4 };

            A.Run run44 = new A.Run();
            A.RunProperties runProperties48 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "et-EE" };
            A.Text text48 = new A.Text();
            text48.Text = "Fifth level";

            run44.Append(runProperties48);
            run44.Append(text48);

            paragraph48.Append(paragraphProperties45);
            paragraph48.Append(run44);

            textBody19.Append(bodyProperties21);
            textBody19.Append(listStyle21);
            textBody19.Append(paragraph44);
            textBody19.Append(paragraph45);
            textBody19.Append(paragraph46);
            textBody19.Append(paragraph47);
            textBody19.Append(paragraph48);

            shape21.Append(nonVisualShapeProperties21);
            shape21.Append(shapeProperties24);
            shape21.Append(textBody19);

            Shape shape22 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties22 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties29 = new NonVisualDrawingProperties() { Id = (UInt32Value)1028U, Name = "Text Box 24" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties22 = new NonVisualShapeDrawingProperties() { TextBox = true };
            A.ShapeLocks shapeLocks22 = new A.ShapeLocks() { NoChangeArrowheads = true };

            nonVisualShapeDrawingProperties22.Append(shapeLocks22);
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties29 = new ApplicationNonVisualDrawingProperties();

            nonVisualShapeProperties22.Append(nonVisualDrawingProperties29);
            nonVisualShapeProperties22.Append(nonVisualShapeDrawingProperties22);
            nonVisualShapeProperties22.Append(applicationNonVisualDrawingProperties29);

            ShapeProperties shapeProperties25 = new ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D21 = new A.Transform2D();
            A.Offset offset27 = new A.Offset() { X = 8997950L, Y = 6400800L };
            A.Extents extents27 = new A.Extents() { Cx = 412750L, Cy = 244475L };

            transform2D21.Append(offset27);
            transform2D21.Append(extents27);

            A.PresetGeometry presetGeometry19 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList30 = new A.AdjustValueList();

            presetGeometry19.Append(adjustValueList30);
            A.NoFill noFill25 = new A.NoFill();

            A.Outline outline38 = new A.Outline();
            A.NoFill noFill26 = new A.NoFill();

            outline38.Append(noFill26);

            A.ShapePropertiesExtensionList shapePropertiesExtensionList11 = new A.ShapePropertiesExtensionList();

            A.ShapePropertiesExtension shapePropertiesExtension15 = new A.ShapePropertiesExtension() { Uri = "{909E8E84-426E-40DD-AFC4-6F175D3DCCD1}" };

            A14.HiddenFillProperties hiddenFillProperties6 = new A14.HiddenFillProperties();
            hiddenFillProperties6.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill176 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex247 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            solidFill176.Append(rgbColorModelHex247);

            hiddenFillProperties6.Append(solidFill176);

            shapePropertiesExtension15.Append(hiddenFillProperties6);

            A.ShapePropertiesExtension shapePropertiesExtension16 = new A.ShapePropertiesExtension() { Uri = "{91240B29-F687-4F45-9708-019B960494DF}" };

            A14.HiddenLineProperties hiddenLineProperties10 = new A14.HiddenLineProperties() { Width = 9525 };
            hiddenLineProperties10.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill177 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex248 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill177.Append(rgbColorModelHex248);
            A.Miter miter19 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd18 = new A.HeadEnd();
            A.TailEnd tailEnd18 = new A.TailEnd();

            hiddenLineProperties10.Append(solidFill177);
            hiddenLineProperties10.Append(miter19);
            hiddenLineProperties10.Append(headEnd18);
            hiddenLineProperties10.Append(tailEnd18);

            shapePropertiesExtension16.Append(hiddenLineProperties10);

            shapePropertiesExtensionList11.Append(shapePropertiesExtension15);
            shapePropertiesExtensionList11.Append(shapePropertiesExtension16);

            shapeProperties25.Append(transform2D21);
            shapeProperties25.Append(presetGeometry19);
            shapeProperties25.Append(noFill25);
            shapeProperties25.Append(outline38);
            shapeProperties25.Append(shapePropertiesExtensionList11);

            TextBody textBody20 = new TextBody();

            A.BodyProperties bodyProperties22 = new A.BodyProperties();
            A.ShapeAutoFit shapeAutoFit1 = new A.ShapeAutoFit();

            bodyProperties22.Append(shapeAutoFit1);

            A.ListStyle listStyle22 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties17 = new A.Level1ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties104 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill178 = new A.SolidFill();
            A.SchemeColor schemeColor231 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill178.Append(schemeColor231);
            A.LatinFont latinFont122 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont84 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties104.Append(solidFill178);
            defaultRunProperties104.Append(latinFont122);
            defaultRunProperties104.Append(eastAsianFont84);

            level1ParagraphProperties17.Append(defaultRunProperties104);

            A.Level2ParagraphProperties level2ParagraphProperties9 = new A.Level2ParagraphProperties() { LeftMargin = 742950, Indent = -285750 };

            A.DefaultRunProperties defaultRunProperties105 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill179 = new A.SolidFill();
            A.SchemeColor schemeColor232 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill179.Append(schemeColor232);
            A.LatinFont latinFont123 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont85 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties105.Append(solidFill179);
            defaultRunProperties105.Append(latinFont123);
            defaultRunProperties105.Append(eastAsianFont85);

            level2ParagraphProperties9.Append(defaultRunProperties105);

            A.Level3ParagraphProperties level3ParagraphProperties9 = new A.Level3ParagraphProperties() { LeftMargin = 1143000, Indent = -228600 };

            A.DefaultRunProperties defaultRunProperties106 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill180 = new A.SolidFill();
            A.SchemeColor schemeColor233 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill180.Append(schemeColor233);
            A.LatinFont latinFont124 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont86 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties106.Append(solidFill180);
            defaultRunProperties106.Append(latinFont124);
            defaultRunProperties106.Append(eastAsianFont86);

            level3ParagraphProperties9.Append(defaultRunProperties106);

            A.Level4ParagraphProperties level4ParagraphProperties9 = new A.Level4ParagraphProperties() { LeftMargin = 1600200, Indent = -228600 };

            A.DefaultRunProperties defaultRunProperties107 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill181 = new A.SolidFill();
            A.SchemeColor schemeColor234 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill181.Append(schemeColor234);
            A.LatinFont latinFont125 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont87 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties107.Append(solidFill181);
            defaultRunProperties107.Append(latinFont125);
            defaultRunProperties107.Append(eastAsianFont87);

            level4ParagraphProperties9.Append(defaultRunProperties107);

            A.Level5ParagraphProperties level5ParagraphProperties9 = new A.Level5ParagraphProperties() { LeftMargin = 2057400, Indent = -228600 };

            A.DefaultRunProperties defaultRunProperties108 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill182 = new A.SolidFill();
            A.SchemeColor schemeColor235 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill182.Append(schemeColor235);
            A.LatinFont latinFont126 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont88 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties108.Append(solidFill182);
            defaultRunProperties108.Append(latinFont126);
            defaultRunProperties108.Append(eastAsianFont88);

            level5ParagraphProperties9.Append(defaultRunProperties108);

            A.Level6ParagraphProperties level6ParagraphProperties9 = new A.Level6ParagraphProperties() { LeftMargin = 2514600, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore85 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent110 = new A.SpacingPercent() { Val = 0 };

            spaceBefore85.Append(spacingPercent110);

            A.SpaceAfter spaceAfter63 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent111 = new A.SpacingPercent() { Val = 0 };

            spaceAfter63.Append(spacingPercent111);

            A.DefaultRunProperties defaultRunProperties109 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill183 = new A.SolidFill();
            A.SchemeColor schemeColor236 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill183.Append(schemeColor236);
            A.LatinFont latinFont127 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont89 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties109.Append(solidFill183);
            defaultRunProperties109.Append(latinFont127);
            defaultRunProperties109.Append(eastAsianFont89);

            level6ParagraphProperties9.Append(spaceBefore85);
            level6ParagraphProperties9.Append(spaceAfter63);
            level6ParagraphProperties9.Append(defaultRunProperties109);

            A.Level7ParagraphProperties level7ParagraphProperties9 = new A.Level7ParagraphProperties() { LeftMargin = 2971800, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore86 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent112 = new A.SpacingPercent() { Val = 0 };

            spaceBefore86.Append(spacingPercent112);

            A.SpaceAfter spaceAfter64 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent113 = new A.SpacingPercent() { Val = 0 };

            spaceAfter64.Append(spacingPercent113);

            A.DefaultRunProperties defaultRunProperties110 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill184 = new A.SolidFill();
            A.SchemeColor schemeColor237 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill184.Append(schemeColor237);
            A.LatinFont latinFont128 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont90 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties110.Append(solidFill184);
            defaultRunProperties110.Append(latinFont128);
            defaultRunProperties110.Append(eastAsianFont90);

            level7ParagraphProperties9.Append(spaceBefore86);
            level7ParagraphProperties9.Append(spaceAfter64);
            level7ParagraphProperties9.Append(defaultRunProperties110);

            A.Level8ParagraphProperties level8ParagraphProperties9 = new A.Level8ParagraphProperties() { LeftMargin = 3429000, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore87 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent114 = new A.SpacingPercent() { Val = 0 };

            spaceBefore87.Append(spacingPercent114);

            A.SpaceAfter spaceAfter65 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent115 = new A.SpacingPercent() { Val = 0 };

            spaceAfter65.Append(spacingPercent115);

            A.DefaultRunProperties defaultRunProperties111 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill185 = new A.SolidFill();
            A.SchemeColor schemeColor238 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill185.Append(schemeColor238);
            A.LatinFont latinFont129 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont91 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties111.Append(solidFill185);
            defaultRunProperties111.Append(latinFont129);
            defaultRunProperties111.Append(eastAsianFont91);

            level8ParagraphProperties9.Append(spaceBefore87);
            level8ParagraphProperties9.Append(spaceAfter65);
            level8ParagraphProperties9.Append(defaultRunProperties111);

            A.Level9ParagraphProperties level9ParagraphProperties9 = new A.Level9ParagraphProperties() { LeftMargin = 3886200, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore88 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent116 = new A.SpacingPercent() { Val = 0 };

            spaceBefore88.Append(spacingPercent116);

            A.SpaceAfter spaceAfter66 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent117 = new A.SpacingPercent() { Val = 0 };

            spaceAfter66.Append(spacingPercent117);

            A.DefaultRunProperties defaultRunProperties112 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill186 = new A.SolidFill();
            A.SchemeColor schemeColor239 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill186.Append(schemeColor239);
            A.LatinFont latinFont130 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont92 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties112.Append(solidFill186);
            defaultRunProperties112.Append(latinFont130);
            defaultRunProperties112.Append(eastAsianFont92);

            level9ParagraphProperties9.Append(spaceBefore88);
            level9ParagraphProperties9.Append(spaceAfter66);
            level9ParagraphProperties9.Append(defaultRunProperties112);

            listStyle22.Append(level1ParagraphProperties17);
            listStyle22.Append(level2ParagraphProperties9);
            listStyle22.Append(level3ParagraphProperties9);
            listStyle22.Append(level4ParagraphProperties9);
            listStyle22.Append(level5ParagraphProperties9);
            listStyle22.Append(level6ParagraphProperties9);
            listStyle22.Append(level7ParagraphProperties9);
            listStyle22.Append(level8ParagraphProperties9);
            listStyle22.Append(level9ParagraphProperties9);

            A.Paragraph paragraph49 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties46 = new A.ParagraphProperties() { Alignment = A.TextAlignmentTypeValues.Right };

            A.SpaceBefore spaceBefore89 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent118 = new A.SpacingPercent() { Val = 50000 };

            spaceBefore89.Append(spacingPercent118);
            A.DefaultRunProperties defaultRunProperties113 = new A.DefaultRunProperties();

            paragraphProperties46.Append(spaceBefore89);
            paragraphProperties46.Append(defaultRunProperties113);

            A.Field field5 = new A.Field() { Id = "{A355A000-8E0A-4C62-AF76-3D247C56F70B}", Type = "slidenum" };

            A.RunProperties runProperties49 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "et-EE", FontSize = 1000 };
            runProperties49.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));

            A.ParagraphProperties paragraphProperties47 = new A.ParagraphProperties() { Alignment = A.TextAlignmentTypeValues.Right };

            A.SpaceBefore spaceBefore90 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent119 = new A.SpacingPercent() { Val = 50000 };

            spaceBefore90.Append(spacingPercent119);
            A.DefaultRunProperties defaultRunProperties114 = new A.DefaultRunProperties();

            paragraphProperties47.Append(spaceBefore90);
            paragraphProperties47.Append(defaultRunProperties114);
            A.Text text49 = new A.Text();
            text49.Text = "‹#›";

            field5.Append(runProperties49);
            field5.Append(paragraphProperties47);
            field5.Append(text49);
            A.EndParagraphRunProperties endParagraphRunProperties24 = new A.EndParagraphRunProperties() { Language = "en-US", AlternativeLanguage = "et-EE", FontSize = 1200 };

            paragraph49.Append(paragraphProperties46);
            paragraph49.Append(field5);
            paragraph49.Append(endParagraphRunProperties24);

            textBody20.Append(bodyProperties22);
            textBody20.Append(listStyle22);
            textBody20.Append(paragraph49);

            shape22.Append(nonVisualShapeProperties22);
            shape22.Append(shapeProperties25);
            shape22.Append(textBody20);

            Shape shape23 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties23 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties30 = new NonVisualDrawingProperties() { Id = (UInt32Value)1029U, Name = "Text Box 7" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties23 = new NonVisualShapeDrawingProperties() { TextBox = true };
            A.ShapeLocks shapeLocks23 = new A.ShapeLocks() { NoChangeArrowheads = true };

            nonVisualShapeDrawingProperties23.Append(shapeLocks23);
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties30 = new ApplicationNonVisualDrawingProperties();

            nonVisualShapeProperties23.Append(nonVisualDrawingProperties30);
            nonVisualShapeProperties23.Append(nonVisualShapeDrawingProperties23);
            nonVisualShapeProperties23.Append(applicationNonVisualDrawingProperties30);

            ShapeProperties shapeProperties26 = new ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D22 = new A.Transform2D();
            A.Offset offset28 = new A.Offset() { X = 4787900L, Y = 6400800L };
            A.Extents extents28 = new A.Extents() { Cx = 4292600L, Cy = 244475L };

            transform2D22.Append(offset28);
            transform2D22.Append(extents28);

            A.PresetGeometry presetGeometry20 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList31 = new A.AdjustValueList();

            presetGeometry20.Append(adjustValueList31);

            A.SolidFill solidFill187 = new A.SolidFill();
            A.SchemeColor schemeColor240 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill187.Append(schemeColor240);

            A.Outline outline39 = new A.Outline();
            A.NoFill noFill27 = new A.NoFill();

            outline39.Append(noFill27);

            A.ShapePropertiesExtensionList shapePropertiesExtensionList12 = new A.ShapePropertiesExtensionList();

            A.ShapePropertiesExtension shapePropertiesExtension17 = new A.ShapePropertiesExtension() { Uri = "{91240B29-F687-4F45-9708-019B960494DF}" };

            A14.HiddenLineProperties hiddenLineProperties11 = new A14.HiddenLineProperties() { Width = 9525 };
            hiddenLineProperties11.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill188 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex249 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill188.Append(rgbColorModelHex249);
            A.Miter miter20 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd19 = new A.HeadEnd();
            A.TailEnd tailEnd19 = new A.TailEnd();

            hiddenLineProperties11.Append(solidFill188);
            hiddenLineProperties11.Append(miter20);
            hiddenLineProperties11.Append(headEnd19);
            hiddenLineProperties11.Append(tailEnd19);

            shapePropertiesExtension17.Append(hiddenLineProperties11);

            shapePropertiesExtensionList12.Append(shapePropertiesExtension17);

            shapeProperties26.Append(transform2D22);
            shapeProperties26.Append(presetGeometry20);
            shapeProperties26.Append(solidFill187);
            shapeProperties26.Append(outline39);
            shapeProperties26.Append(shapePropertiesExtensionList12);

            TextBody textBody21 = new TextBody();

            A.BodyProperties bodyProperties23 = new A.BodyProperties();
            A.ShapeAutoFit shapeAutoFit2 = new A.ShapeAutoFit();

            bodyProperties23.Append(shapeAutoFit2);

            A.ListStyle listStyle23 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties18 = new A.Level1ParagraphProperties() { EastAsianLineBreak = false, Height = false };

            A.DefaultRunProperties defaultRunProperties115 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill189 = new A.SolidFill();
            A.SchemeColor schemeColor241 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill189.Append(schemeColor241);
            A.LatinFont latinFont131 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont93 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties115.Append(solidFill189);
            defaultRunProperties115.Append(latinFont131);
            defaultRunProperties115.Append(eastAsianFont93);

            level1ParagraphProperties18.Append(defaultRunProperties115);

            A.Level2ParagraphProperties level2ParagraphProperties10 = new A.Level2ParagraphProperties() { LeftMargin = 742950, Indent = -285750, EastAsianLineBreak = false, Height = false };

            A.DefaultRunProperties defaultRunProperties116 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill190 = new A.SolidFill();
            A.SchemeColor schemeColor242 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill190.Append(schemeColor242);
            A.LatinFont latinFont132 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont94 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties116.Append(solidFill190);
            defaultRunProperties116.Append(latinFont132);
            defaultRunProperties116.Append(eastAsianFont94);

            level2ParagraphProperties10.Append(defaultRunProperties116);

            A.Level3ParagraphProperties level3ParagraphProperties10 = new A.Level3ParagraphProperties() { LeftMargin = 1143000, Indent = -228600, EastAsianLineBreak = false, Height = false };

            A.DefaultRunProperties defaultRunProperties117 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill191 = new A.SolidFill();
            A.SchemeColor schemeColor243 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill191.Append(schemeColor243);
            A.LatinFont latinFont133 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont95 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties117.Append(solidFill191);
            defaultRunProperties117.Append(latinFont133);
            defaultRunProperties117.Append(eastAsianFont95);

            level3ParagraphProperties10.Append(defaultRunProperties117);

            A.Level4ParagraphProperties level4ParagraphProperties10 = new A.Level4ParagraphProperties() { LeftMargin = 1600200, Indent = -228600, EastAsianLineBreak = false, Height = false };

            A.DefaultRunProperties defaultRunProperties118 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill192 = new A.SolidFill();
            A.SchemeColor schemeColor244 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill192.Append(schemeColor244);
            A.LatinFont latinFont134 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont96 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties118.Append(solidFill192);
            defaultRunProperties118.Append(latinFont134);
            defaultRunProperties118.Append(eastAsianFont96);

            level4ParagraphProperties10.Append(defaultRunProperties118);

            A.Level5ParagraphProperties level5ParagraphProperties10 = new A.Level5ParagraphProperties() { LeftMargin = 2057400, Indent = -228600, EastAsianLineBreak = false, Height = false };

            A.DefaultRunProperties defaultRunProperties119 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill193 = new A.SolidFill();
            A.SchemeColor schemeColor245 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill193.Append(schemeColor245);
            A.LatinFont latinFont135 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont97 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties119.Append(solidFill193);
            defaultRunProperties119.Append(latinFont135);
            defaultRunProperties119.Append(eastAsianFont97);

            level5ParagraphProperties10.Append(defaultRunProperties119);

            A.Level6ParagraphProperties level6ParagraphProperties10 = new A.Level6ParagraphProperties() { LeftMargin = 2514600, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore91 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent120 = new A.SpacingPercent() { Val = 0 };

            spaceBefore91.Append(spacingPercent120);

            A.SpaceAfter spaceAfter67 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent121 = new A.SpacingPercent() { Val = 0 };

            spaceAfter67.Append(spacingPercent121);

            A.DefaultRunProperties defaultRunProperties120 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill194 = new A.SolidFill();
            A.SchemeColor schemeColor246 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill194.Append(schemeColor246);
            A.LatinFont latinFont136 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont98 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties120.Append(solidFill194);
            defaultRunProperties120.Append(latinFont136);
            defaultRunProperties120.Append(eastAsianFont98);

            level6ParagraphProperties10.Append(spaceBefore91);
            level6ParagraphProperties10.Append(spaceAfter67);
            level6ParagraphProperties10.Append(defaultRunProperties120);

            A.Level7ParagraphProperties level7ParagraphProperties10 = new A.Level7ParagraphProperties() { LeftMargin = 2971800, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore92 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent122 = new A.SpacingPercent() { Val = 0 };

            spaceBefore92.Append(spacingPercent122);

            A.SpaceAfter spaceAfter68 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent123 = new A.SpacingPercent() { Val = 0 };

            spaceAfter68.Append(spacingPercent123);

            A.DefaultRunProperties defaultRunProperties121 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill195 = new A.SolidFill();
            A.SchemeColor schemeColor247 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill195.Append(schemeColor247);
            A.LatinFont latinFont137 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont99 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties121.Append(solidFill195);
            defaultRunProperties121.Append(latinFont137);
            defaultRunProperties121.Append(eastAsianFont99);

            level7ParagraphProperties10.Append(spaceBefore92);
            level7ParagraphProperties10.Append(spaceAfter68);
            level7ParagraphProperties10.Append(defaultRunProperties121);

            A.Level8ParagraphProperties level8ParagraphProperties10 = new A.Level8ParagraphProperties() { LeftMargin = 3429000, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore93 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent124 = new A.SpacingPercent() { Val = 0 };

            spaceBefore93.Append(spacingPercent124);

            A.SpaceAfter spaceAfter69 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent125 = new A.SpacingPercent() { Val = 0 };

            spaceAfter69.Append(spacingPercent125);

            A.DefaultRunProperties defaultRunProperties122 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill196 = new A.SolidFill();
            A.SchemeColor schemeColor248 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill196.Append(schemeColor248);
            A.LatinFont latinFont138 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont100 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties122.Append(solidFill196);
            defaultRunProperties122.Append(latinFont138);
            defaultRunProperties122.Append(eastAsianFont100);

            level8ParagraphProperties10.Append(spaceBefore93);
            level8ParagraphProperties10.Append(spaceAfter69);
            level8ParagraphProperties10.Append(defaultRunProperties122);

            A.Level9ParagraphProperties level9ParagraphProperties10 = new A.Level9ParagraphProperties() { LeftMargin = 3886200, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore94 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent126 = new A.SpacingPercent() { Val = 0 };

            spaceBefore94.Append(spacingPercent126);

            A.SpaceAfter spaceAfter70 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent127 = new A.SpacingPercent() { Val = 0 };

            spaceAfter70.Append(spacingPercent127);

            A.DefaultRunProperties defaultRunProperties123 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill197 = new A.SolidFill();
            A.SchemeColor schemeColor249 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill197.Append(schemeColor249);
            A.LatinFont latinFont139 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont101 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties123.Append(solidFill197);
            defaultRunProperties123.Append(latinFont139);
            defaultRunProperties123.Append(eastAsianFont101);

            level9ParagraphProperties10.Append(spaceBefore94);
            level9ParagraphProperties10.Append(spaceAfter70);
            level9ParagraphProperties10.Append(defaultRunProperties123);

            listStyle23.Append(level1ParagraphProperties18);
            listStyle23.Append(level2ParagraphProperties10);
            listStyle23.Append(level3ParagraphProperties10);
            listStyle23.Append(level4ParagraphProperties10);
            listStyle23.Append(level5ParagraphProperties10);
            listStyle23.Append(level6ParagraphProperties10);
            listStyle23.Append(level7ParagraphProperties10);
            listStyle23.Append(level8ParagraphProperties10);
            listStyle23.Append(level9ParagraphProperties10);

            A.Paragraph paragraph50 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties48 = new A.ParagraphProperties() { Alignment = A.TextAlignmentTypeValues.Right };

            A.SpaceBefore spaceBefore95 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent128 = new A.SpacingPercent() { Val = 50000 };

            spaceBefore95.Append(spacingPercent128);
            A.DefaultRunProperties defaultRunProperties124 = new A.DefaultRunProperties();

            paragraphProperties48.Append(spaceBefore95);
            paragraphProperties48.Append(defaultRunProperties124);

            A.Run run45 = new A.Run();

            A.RunProperties runProperties50 = new A.RunProperties() { Language = "lv-LV", FontSize = 1000, Kerning = 1200, NoProof = false, Dirty = false, SpellingError = true };

            A.SolidFill solidFill198 = new A.SolidFill();
            A.SchemeColor schemeColor250 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill198.Append(schemeColor250);
            A.LatinFont latinFont140 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont102 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont63 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            runProperties50.Append(solidFill198);
            runProperties50.Append(latinFont140);
            runProperties50.Append(eastAsianFont102);
            runProperties50.Append(complexScriptFont63);
            A.Text text50 = new A.Text();
            text50.Text = ""; // "October"; // TO DO: Date needed?

            run45.Append(runProperties50);
            run45.Append(text50);

            A.Run run46 = new A.Run();

            A.RunProperties runProperties51 = new A.RunProperties() { Language = "lv-LV", FontSize = 1000, Kerning = 1200, NoProof = false, Dirty = false };

            A.SolidFill solidFill199 = new A.SolidFill();
            A.SchemeColor schemeColor251 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill199.Append(schemeColor251);
            A.LatinFont latinFont141 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont103 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont64 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            runProperties51.Append(solidFill199);
            runProperties51.Append(latinFont141);
            runProperties51.Append(eastAsianFont103);
            runProperties51.Append(complexScriptFont64);
            A.Text text51 = new A.Text();
            text51.Text = $"{DateTime.Now.Year}";

            run46.Append(runProperties51);
            run46.Append(text51);

            A.Run run47 = new A.Run();

            A.RunProperties runProperties52 = new A.RunProperties() { Language = "en-US", FontSize = 1000, Kerning = 1200, NoProof = false, Dirty = false };

            A.SolidFill solidFill200 = new A.SolidFill();
            A.SchemeColor schemeColor252 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill200.Append(schemeColor252);
            A.LatinFont latinFont142 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont104 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont65 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            runProperties52.Append(solidFill200);
            runProperties52.Append(latinFont142);
            runProperties52.Append(eastAsianFont104);
            runProperties52.Append(complexScriptFont65);
            A.Text text52 = new A.Text();
            text52.Text = "   www.amrop.com";

            run47.Append(runProperties52);
            run47.Append(text52);

            paragraph50.Append(paragraphProperties48);
            paragraph50.Append(run45);
            paragraph50.Append(run46);
            paragraph50.Append(run47);

            textBody21.Append(bodyProperties23);
            textBody21.Append(listStyle23);
            textBody21.Append(paragraph50);

            shape23.Append(nonVisualShapeProperties23);
            shape23.Append(shapeProperties26);
            shape23.Append(textBody21);

            Picture picture2 = new Picture();

            NonVisualPictureProperties nonVisualPictureProperties2 = new NonVisualPictureProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties31 = new NonVisualDrawingProperties() { Id = (UInt32Value)1030U, Name = "Picture 1", Description = "cid:image001.jpg@01CF4E7B.20423EB0" };

            NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties2 = new NonVisualPictureDrawingProperties();
            A.PictureLocks pictureLocks2 = new A.PictureLocks() { NoChangeAspect = true, NoChangeArrowheads = true };

            nonVisualPictureDrawingProperties2.Append(pictureLocks2);
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties31 = new ApplicationNonVisualDrawingProperties() { UserDrawn = true };

            nonVisualPictureProperties2.Append(nonVisualDrawingProperties31);
            nonVisualPictureProperties2.Append(nonVisualPictureDrawingProperties2);
            nonVisualPictureProperties2.Append(applicationNonVisualDrawingProperties31);

            BlipFill blipFill2 = new BlipFill();

            A.Blip blip2 = new A.Blip() { Embed = "rId13" };

            A.BlipExtensionList blipExtensionList1 = new A.BlipExtensionList();

            A.BlipExtension blipExtension1 = new A.BlipExtension() { Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}" };

            A14.UseLocalDpi useLocalDpi1 = new A14.UseLocalDpi() { Val = false };
            useLocalDpi1.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            blipExtension1.Append(useLocalDpi1);

            blipExtensionList1.Append(blipExtension1);

            blip2.Append(blipExtensionList1);
            A.SourceRectangle sourceRectangle2 = new A.SourceRectangle();

            A.Stretch stretch2 = new A.Stretch();
            A.FillRectangle fillRectangle1 = new A.FillRectangle();

            stretch2.Append(fillRectangle1);

            blipFill2.Append(blip2);
            blipFill2.Append(sourceRectangle2);
            blipFill2.Append(stretch2);

            ShapeProperties shapeProperties27 = new ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D23 = new A.Transform2D();
            A.Offset offset29 = new A.Offset() { X = 533400L, Y = 5816600L };
            A.Extents extents29 = new A.Extents() { Cx = 2295525L, Cy = 828675L };

            transform2D23.Append(offset29);
            transform2D23.Append(extents29);

            A.PresetGeometry presetGeometry21 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList32 = new A.AdjustValueList();

            presetGeometry21.Append(adjustValueList32);
            A.NoFill noFill28 = new A.NoFill();

            A.Outline outline40 = new A.Outline();
            A.NoFill noFill29 = new A.NoFill();

            outline40.Append(noFill29);

            A.ShapePropertiesExtensionList shapePropertiesExtensionList13 = new A.ShapePropertiesExtensionList();

            A.ShapePropertiesExtension shapePropertiesExtension18 = new A.ShapePropertiesExtension() { Uri = "{909E8E84-426E-40DD-AFC4-6F175D3DCCD1}" };

            A14.HiddenFillProperties hiddenFillProperties7 = new A14.HiddenFillProperties();
            hiddenFillProperties7.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill201 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex250 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            solidFill201.Append(rgbColorModelHex250);

            hiddenFillProperties7.Append(solidFill201);

            shapePropertiesExtension18.Append(hiddenFillProperties7);

            A.ShapePropertiesExtension shapePropertiesExtension19 = new A.ShapePropertiesExtension() { Uri = "{91240B29-F687-4F45-9708-019B960494DF}" };

            A14.HiddenLineProperties hiddenLineProperties12 = new A14.HiddenLineProperties() { Width = 9525 };
            hiddenLineProperties12.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill202 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex251 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill202.Append(rgbColorModelHex251);
            A.Miter miter21 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd20 = new A.HeadEnd();
            A.TailEnd tailEnd20 = new A.TailEnd();

            hiddenLineProperties12.Append(solidFill202);
            hiddenLineProperties12.Append(miter21);
            hiddenLineProperties12.Append(headEnd20);
            hiddenLineProperties12.Append(tailEnd20);

            shapePropertiesExtension19.Append(hiddenLineProperties12);

            shapePropertiesExtensionList13.Append(shapePropertiesExtension18);
            shapePropertiesExtensionList13.Append(shapePropertiesExtension19);

            shapeProperties27.Append(transform2D23);
            shapeProperties27.Append(presetGeometry21);
            shapeProperties27.Append(noFill28);
            shapeProperties27.Append(outline40);
            shapeProperties27.Append(shapePropertiesExtensionList13);

            picture2.Append(nonVisualPictureProperties2);
            picture2.Append(blipFill2);
            picture2.Append(shapeProperties27);

            shapeTree6.Append(nonVisualGroupShapeProperties6);
            shapeTree6.Append(groupShapeProperties6);
            shapeTree6.Append(shape20);
            shapeTree6.Append(shape21);
            shapeTree6.Append(shape22);
            shapeTree6.Append(shape23);
            shapeTree6.Append(picture2);

            commonSlideData6.Append(background3);
            commonSlideData6.Append(shapeTree6);
            ColorMap colorMap15 = new ColorMap() { Background1 = A.ColorSchemeIndexValues.Light1, Text1 = A.ColorSchemeIndexValues.Dark1, Background2 = A.ColorSchemeIndexValues.Light2, Text2 = A.ColorSchemeIndexValues.Dark2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            SlideLayoutIdList slideLayoutIdList1 = new SlideLayoutIdList();
            SlideLayoutId slideLayoutId1 = new SlideLayoutId() { Id = (UInt32Value)2147484167U, RelationshipId = "rId1" };
            SlideLayoutId slideLayoutId2 = new SlideLayoutId() { Id = (UInt32Value)2147484157U, RelationshipId = "rId2" };
            SlideLayoutId slideLayoutId3 = new SlideLayoutId() { Id = (UInt32Value)2147484158U, RelationshipId = "rId3" };
            SlideLayoutId slideLayoutId4 = new SlideLayoutId() { Id = (UInt32Value)2147484159U, RelationshipId = "rId4" };
            SlideLayoutId slideLayoutId5 = new SlideLayoutId() { Id = (UInt32Value)2147484160U, RelationshipId = "rId5" };
            SlideLayoutId slideLayoutId6 = new SlideLayoutId() { Id = (UInt32Value)2147484161U, RelationshipId = "rId6" };
            SlideLayoutId slideLayoutId7 = new SlideLayoutId() { Id = (UInt32Value)2147484162U, RelationshipId = "rId7" };
            SlideLayoutId slideLayoutId8 = new SlideLayoutId() { Id = (UInt32Value)2147484163U, RelationshipId = "rId8" };
            SlideLayoutId slideLayoutId9 = new SlideLayoutId() { Id = (UInt32Value)2147484164U, RelationshipId = "rId9" };
            SlideLayoutId slideLayoutId10 = new SlideLayoutId() { Id = (UInt32Value)2147484165U, RelationshipId = "rId10" };
            SlideLayoutId slideLayoutId11 = new SlideLayoutId() { Id = (UInt32Value)2147484166U, RelationshipId = "rId11" };

            slideLayoutIdList1.Append(slideLayoutId1);
            slideLayoutIdList1.Append(slideLayoutId2);
            slideLayoutIdList1.Append(slideLayoutId3);
            slideLayoutIdList1.Append(slideLayoutId4);
            slideLayoutIdList1.Append(slideLayoutId5);
            slideLayoutIdList1.Append(slideLayoutId6);
            slideLayoutIdList1.Append(slideLayoutId7);
            slideLayoutIdList1.Append(slideLayoutId8);
            slideLayoutIdList1.Append(slideLayoutId9);
            slideLayoutIdList1.Append(slideLayoutId10);
            slideLayoutIdList1.Append(slideLayoutId11);

            TextStyles textStyles1 = new TextStyles();

            TitleStyle titleStyle1 = new TitleStyle();

            A.Level1ParagraphProperties level1ParagraphProperties19 = new A.Level1ParagraphProperties() { Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore96 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent129 = new A.SpacingPercent() { Val = 0 };

            spaceBefore96.Append(spacingPercent129);

            A.SpaceAfter spaceAfter71 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent130 = new A.SpacingPercent() { Val = 0 };

            spaceAfter71.Append(spacingPercent130);

            A.DefaultRunProperties defaultRunProperties125 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill203 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex252 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill203.Append(rgbColorModelHex252);
            A.LatinFont latinFont143 = new A.LatinFont() { Typeface = "Bliss Pro Regular", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont105 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont66 = new A.ComplexScriptFont() { Typeface = "+mj-cs" };

            defaultRunProperties125.Append(solidFill203);
            defaultRunProperties125.Append(latinFont143);
            defaultRunProperties125.Append(eastAsianFont105);
            defaultRunProperties125.Append(complexScriptFont66);

            level1ParagraphProperties19.Append(spaceBefore96);
            level1ParagraphProperties19.Append(spaceAfter71);
            level1ParagraphProperties19.Append(defaultRunProperties125);

            A.Level2ParagraphProperties level2ParagraphProperties11 = new A.Level2ParagraphProperties() { Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore97 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent131 = new A.SpacingPercent() { Val = 0 };

            spaceBefore97.Append(spacingPercent131);

            A.SpaceAfter spaceAfter72 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent132 = new A.SpacingPercent() { Val = 0 };

            spaceAfter72.Append(spacingPercent132);

            A.DefaultRunProperties defaultRunProperties126 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill204 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex253 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill204.Append(rgbColorModelHex253);
            A.LatinFont latinFont144 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont106 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties126.Append(solidFill204);
            defaultRunProperties126.Append(latinFont144);
            defaultRunProperties126.Append(eastAsianFont106);

            level2ParagraphProperties11.Append(spaceBefore97);
            level2ParagraphProperties11.Append(spaceAfter72);
            level2ParagraphProperties11.Append(defaultRunProperties126);

            A.Level3ParagraphProperties level3ParagraphProperties11 = new A.Level3ParagraphProperties() { Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore98 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent133 = new A.SpacingPercent() { Val = 0 };

            spaceBefore98.Append(spacingPercent133);

            A.SpaceAfter spaceAfter73 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent134 = new A.SpacingPercent() { Val = 0 };

            spaceAfter73.Append(spacingPercent134);

            A.DefaultRunProperties defaultRunProperties127 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill205 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex254 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill205.Append(rgbColorModelHex254);
            A.LatinFont latinFont145 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont107 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties127.Append(solidFill205);
            defaultRunProperties127.Append(latinFont145);
            defaultRunProperties127.Append(eastAsianFont107);

            level3ParagraphProperties11.Append(spaceBefore98);
            level3ParagraphProperties11.Append(spaceAfter73);
            level3ParagraphProperties11.Append(defaultRunProperties127);

            A.Level4ParagraphProperties level4ParagraphProperties11 = new A.Level4ParagraphProperties() { Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore99 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent135 = new A.SpacingPercent() { Val = 0 };

            spaceBefore99.Append(spacingPercent135);

            A.SpaceAfter spaceAfter74 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent136 = new A.SpacingPercent() { Val = 0 };

            spaceAfter74.Append(spacingPercent136);

            A.DefaultRunProperties defaultRunProperties128 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill206 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex255 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill206.Append(rgbColorModelHex255);
            A.LatinFont latinFont146 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont108 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties128.Append(solidFill206);
            defaultRunProperties128.Append(latinFont146);
            defaultRunProperties128.Append(eastAsianFont108);

            level4ParagraphProperties11.Append(spaceBefore99);
            level4ParagraphProperties11.Append(spaceAfter74);
            level4ParagraphProperties11.Append(defaultRunProperties128);

            A.Level5ParagraphProperties level5ParagraphProperties11 = new A.Level5ParagraphProperties() { Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore100 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent137 = new A.SpacingPercent() { Val = 0 };

            spaceBefore100.Append(spacingPercent137);

            A.SpaceAfter spaceAfter75 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent138 = new A.SpacingPercent() { Val = 0 };

            spaceAfter75.Append(spacingPercent138);

            A.DefaultRunProperties defaultRunProperties129 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill207 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex256 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill207.Append(rgbColorModelHex256);
            A.LatinFont latinFont147 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont109 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties129.Append(solidFill207);
            defaultRunProperties129.Append(latinFont147);
            defaultRunProperties129.Append(eastAsianFont109);

            level5ParagraphProperties11.Append(spaceBefore100);
            level5ParagraphProperties11.Append(spaceAfter75);
            level5ParagraphProperties11.Append(defaultRunProperties129);

            A.Level6ParagraphProperties level6ParagraphProperties11 = new A.Level6ParagraphProperties() { LeftMargin = 457200, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, FontAlignment = A.TextFontAlignmentValues.Baseline };

            A.SpaceBefore spaceBefore101 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent139 = new A.SpacingPercent() { Val = 0 };

            spaceBefore101.Append(spacingPercent139);

            A.SpaceAfter spaceAfter76 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent140 = new A.SpacingPercent() { Val = 0 };

            spaceAfter76.Append(spacingPercent140);

            A.DefaultRunProperties defaultRunProperties130 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill208 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex257 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill208.Append(rgbColorModelHex257);
            A.LatinFont latinFont148 = new A.LatinFont() { Typeface = "Arial", CharacterSet = 0 };
            A.EastAsianFont eastAsianFont110 = new A.EastAsianFont() { Typeface = "ＭＳ Ｐゴシック", PitchFamily = 1, CharacterSet = -128 };

            defaultRunProperties130.Append(solidFill208);
            defaultRunProperties130.Append(latinFont148);
            defaultRunProperties130.Append(eastAsianFont110);

            level6ParagraphProperties11.Append(spaceBefore101);
            level6ParagraphProperties11.Append(spaceAfter76);
            level6ParagraphProperties11.Append(defaultRunProperties130);

            A.Level7ParagraphProperties level7ParagraphProperties11 = new A.Level7ParagraphProperties() { LeftMargin = 914400, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, FontAlignment = A.TextFontAlignmentValues.Baseline };

            A.SpaceBefore spaceBefore102 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent141 = new A.SpacingPercent() { Val = 0 };

            spaceBefore102.Append(spacingPercent141);

            A.SpaceAfter spaceAfter77 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent142 = new A.SpacingPercent() { Val = 0 };

            spaceAfter77.Append(spacingPercent142);

            A.DefaultRunProperties defaultRunProperties131 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill209 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex258 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill209.Append(rgbColorModelHex258);
            A.LatinFont latinFont149 = new A.LatinFont() { Typeface = "Arial", CharacterSet = 0 };
            A.EastAsianFont eastAsianFont111 = new A.EastAsianFont() { Typeface = "ＭＳ Ｐゴシック", PitchFamily = 1, CharacterSet = -128 };

            defaultRunProperties131.Append(solidFill209);
            defaultRunProperties131.Append(latinFont149);
            defaultRunProperties131.Append(eastAsianFont111);

            level7ParagraphProperties11.Append(spaceBefore102);
            level7ParagraphProperties11.Append(spaceAfter77);
            level7ParagraphProperties11.Append(defaultRunProperties131);

            A.Level8ParagraphProperties level8ParagraphProperties11 = new A.Level8ParagraphProperties() { LeftMargin = 1371600, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, FontAlignment = A.TextFontAlignmentValues.Baseline };

            A.SpaceBefore spaceBefore103 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent143 = new A.SpacingPercent() { Val = 0 };

            spaceBefore103.Append(spacingPercent143);

            A.SpaceAfter spaceAfter78 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent144 = new A.SpacingPercent() { Val = 0 };

            spaceAfter78.Append(spacingPercent144);

            A.DefaultRunProperties defaultRunProperties132 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill210 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex259 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill210.Append(rgbColorModelHex259);
            A.LatinFont latinFont150 = new A.LatinFont() { Typeface = "Arial", CharacterSet = 0 };
            A.EastAsianFont eastAsianFont112 = new A.EastAsianFont() { Typeface = "ＭＳ Ｐゴシック", PitchFamily = 1, CharacterSet = -128 };

            defaultRunProperties132.Append(solidFill210);
            defaultRunProperties132.Append(latinFont150);
            defaultRunProperties132.Append(eastAsianFont112);

            level8ParagraphProperties11.Append(spaceBefore103);
            level8ParagraphProperties11.Append(spaceAfter78);
            level8ParagraphProperties11.Append(defaultRunProperties132);

            A.Level9ParagraphProperties level9ParagraphProperties11 = new A.Level9ParagraphProperties() { LeftMargin = 1828800, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, FontAlignment = A.TextFontAlignmentValues.Baseline };

            A.SpaceBefore spaceBefore104 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent145 = new A.SpacingPercent() { Val = 0 };

            spaceBefore104.Append(spacingPercent145);

            A.SpaceAfter spaceAfter79 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent146 = new A.SpacingPercent() { Val = 0 };

            spaceAfter79.Append(spacingPercent146);

            A.DefaultRunProperties defaultRunProperties133 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill211 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex260 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill211.Append(rgbColorModelHex260);
            A.LatinFont latinFont151 = new A.LatinFont() { Typeface = "Arial", CharacterSet = 0 };
            A.EastAsianFont eastAsianFont113 = new A.EastAsianFont() { Typeface = "ＭＳ Ｐゴシック", PitchFamily = 1, CharacterSet = -128 };

            defaultRunProperties133.Append(solidFill211);
            defaultRunProperties133.Append(latinFont151);
            defaultRunProperties133.Append(eastAsianFont113);

            level9ParagraphProperties11.Append(spaceBefore104);
            level9ParagraphProperties11.Append(spaceAfter79);
            level9ParagraphProperties11.Append(defaultRunProperties133);

            titleStyle1.Append(level1ParagraphProperties19);
            titleStyle1.Append(level2ParagraphProperties11);
            titleStyle1.Append(level3ParagraphProperties11);
            titleStyle1.Append(level4ParagraphProperties11);
            titleStyle1.Append(level5ParagraphProperties11);
            titleStyle1.Append(level6ParagraphProperties11);
            titleStyle1.Append(level7ParagraphProperties11);
            titleStyle1.Append(level8ParagraphProperties11);
            titleStyle1.Append(level9ParagraphProperties11);

            BodyStyle bodyStyle1 = new BodyStyle();

            A.Level1ParagraphProperties level1ParagraphProperties20 = new A.Level1ParagraphProperties() { LeftMargin = 342900, Indent = -342900, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore105 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent147 = new A.SpacingPercent() { Val = 50000 };

            spaceBefore105.Append(spacingPercent147);

            A.SpaceAfter spaceAfter80 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent148 = new A.SpacingPercent() { Val = 0 };

            spaceAfter80.Append(spacingPercent148);

            A.BulletColor bulletColor63 = new A.BulletColor();
            A.SchemeColor schemeColor253 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor63.Append(schemeColor253);
            A.BulletFont bulletFont13 = new A.BulletFont() { Typeface = "Wingdings", Panose = "05000000000000000000", PitchFamily = 2, CharacterSet = 2 };

            A.DefaultRunProperties defaultRunProperties134 = new A.DefaultRunProperties();

            A.SolidFill solidFill212 = new A.SolidFill();
            A.SchemeColor schemeColor254 = new A.SchemeColor() { Val = A.SchemeColorValues.Background2 };

            solidFill212.Append(schemeColor254);
            A.LatinFont latinFont152 = new A.LatinFont() { Typeface = "Bliss Pro Regular", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont114 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont67 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties134.Append(solidFill212);
            defaultRunProperties134.Append(latinFont152);
            defaultRunProperties134.Append(eastAsianFont114);
            defaultRunProperties134.Append(complexScriptFont67);

            level1ParagraphProperties20.Append(spaceBefore105);
            level1ParagraphProperties20.Append(spaceAfter80);
            level1ParagraphProperties20.Append(bulletColor63);
            level1ParagraphProperties20.Append(bulletFont13);
            level1ParagraphProperties20.Append(defaultRunProperties134);

            A.Level2ParagraphProperties level2ParagraphProperties12 = new A.Level2ParagraphProperties() { LeftMargin = 342900, Indent = -165100, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore106 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent149 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore106.Append(spacingPercent149);

            A.SpaceAfter spaceAfter81 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent150 = new A.SpacingPercent() { Val = 0 };

            spaceAfter81.Append(spacingPercent150);

            A.BulletColor bulletColor64 = new A.BulletColor();
            A.SchemeColor schemeColor255 = new A.SchemeColor() { Val = A.SchemeColorValues.Background2 };

            bulletColor64.Append(schemeColor255);
            A.BulletFont bulletFont14 = new A.BulletFont() { Typeface = "Times", Panose = "02020603050405020304", PitchFamily = 18, CharacterSet = 0 };
            A.CharacterBullet characterBullet5 = new A.CharacterBullet() { Char = "•" };

            A.DefaultRunProperties defaultRunProperties135 = new A.DefaultRunProperties();

            A.SolidFill solidFill213 = new A.SolidFill();
            A.SchemeColor schemeColor256 = new A.SchemeColor() { Val = A.SchemeColorValues.Background2 };

            solidFill213.Append(schemeColor256);
            A.LatinFont latinFont153 = new A.LatinFont() { Typeface = "Bliss Pro Regular", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont115 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties135.Append(solidFill213);
            defaultRunProperties135.Append(latinFont153);
            defaultRunProperties135.Append(eastAsianFont115);

            level2ParagraphProperties12.Append(spaceBefore106);
            level2ParagraphProperties12.Append(spaceAfter81);
            level2ParagraphProperties12.Append(bulletColor64);
            level2ParagraphProperties12.Append(bulletFont14);
            level2ParagraphProperties12.Append(characterBullet5);
            level2ParagraphProperties12.Append(defaultRunProperties135);

            A.Level3ParagraphProperties level3ParagraphProperties12 = new A.Level3ParagraphProperties() { LeftMargin = 858838, Indent = -173038, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore107 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent151 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore107.Append(spacingPercent151);

            A.SpaceAfter spaceAfter82 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent152 = new A.SpacingPercent() { Val = 0 };

            spaceAfter82.Append(spacingPercent152);

            A.BulletColor bulletColor65 = new A.BulletColor();
            A.SchemeColor schemeColor257 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor65.Append(schemeColor257);

            A.DefaultRunProperties defaultRunProperties136 = new A.DefaultRunProperties();

            A.SolidFill solidFill214 = new A.SolidFill();
            A.SchemeColor schemeColor258 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill214.Append(schemeColor258);
            A.LatinFont latinFont154 = new A.LatinFont() { Typeface = "Bliss Pro Regular", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont116 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties136.Append(solidFill214);
            defaultRunProperties136.Append(latinFont154);
            defaultRunProperties136.Append(eastAsianFont116);

            level3ParagraphProperties12.Append(spaceBefore107);
            level3ParagraphProperties12.Append(spaceAfter82);
            level3ParagraphProperties12.Append(bulletColor65);
            level3ParagraphProperties12.Append(defaultRunProperties136);

            A.Level4ParagraphProperties level4ParagraphProperties12 = new A.Level4ParagraphProperties() { LeftMargin = 1152525, Indent = -179388, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore108 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent153 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore108.Append(spacingPercent153);

            A.SpaceAfter spaceAfter83 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent154 = new A.SpacingPercent() { Val = 0 };

            spaceAfter83.Append(spacingPercent154);

            A.BulletColor bulletColor66 = new A.BulletColor();
            A.SchemeColor schemeColor259 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor66.Append(schemeColor259);
            A.BulletFont bulletFont15 = new A.BulletFont() { Typeface = "Wingdings", Panose = "05000000000000000000", PitchFamily = 2, CharacterSet = 2 };

            A.DefaultRunProperties defaultRunProperties137 = new A.DefaultRunProperties();

            A.SolidFill solidFill215 = new A.SolidFill();
            A.SchemeColor schemeColor260 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill215.Append(schemeColor260);
            A.LatinFont latinFont155 = new A.LatinFont() { Typeface = "Bliss Pro Regular", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont117 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties137.Append(solidFill215);
            defaultRunProperties137.Append(latinFont155);
            defaultRunProperties137.Append(eastAsianFont117);

            level4ParagraphProperties12.Append(spaceBefore108);
            level4ParagraphProperties12.Append(spaceAfter83);
            level4ParagraphProperties12.Append(bulletColor66);
            level4ParagraphProperties12.Append(bulletFont15);
            level4ParagraphProperties12.Append(defaultRunProperties137);

            A.Level5ParagraphProperties level5ParagraphProperties12 = new A.Level5ParagraphProperties() { LeftMargin = 1497013, Indent = -230188, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore109 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent155 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore109.Append(spacingPercent155);

            A.SpaceAfter spaceAfter84 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent156 = new A.SpacingPercent() { Val = 0 };

            spaceAfter84.Append(spacingPercent156);

            A.BulletColor bulletColor67 = new A.BulletColor();
            A.SchemeColor schemeColor261 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor67.Append(schemeColor261);

            A.DefaultRunProperties defaultRunProperties138 = new A.DefaultRunProperties();

            A.SolidFill solidFill216 = new A.SolidFill();
            A.SchemeColor schemeColor262 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill216.Append(schemeColor262);
            A.LatinFont latinFont156 = new A.LatinFont() { Typeface = "Bliss Pro Regular", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont118 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties138.Append(solidFill216);
            defaultRunProperties138.Append(latinFont156);
            defaultRunProperties138.Append(eastAsianFont118);

            level5ParagraphProperties12.Append(spaceBefore109);
            level5ParagraphProperties12.Append(spaceAfter84);
            level5ParagraphProperties12.Append(bulletColor67);
            level5ParagraphProperties12.Append(defaultRunProperties138);

            A.Level6ParagraphProperties level6ParagraphProperties12 = new A.Level6ParagraphProperties() { LeftMargin = 1954213, Indent = -230188, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, FontAlignment = A.TextFontAlignmentValues.Baseline };

            A.SpaceBefore spaceBefore110 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent157 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore110.Append(spacingPercent157);

            A.SpaceAfter spaceAfter85 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent158 = new A.SpacingPercent() { Val = 0 };

            spaceAfter85.Append(spacingPercent158);

            A.BulletColor bulletColor68 = new A.BulletColor();
            A.SchemeColor schemeColor263 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor68.Append(schemeColor263);

            A.DefaultRunProperties defaultRunProperties139 = new A.DefaultRunProperties();

            A.SolidFill solidFill217 = new A.SolidFill();
            A.SchemeColor schemeColor264 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill217.Append(schemeColor264);
            A.LatinFont latinFont157 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont119 = new A.EastAsianFont() { Typeface = "+mn-ea" };

            defaultRunProperties139.Append(solidFill217);
            defaultRunProperties139.Append(latinFont157);
            defaultRunProperties139.Append(eastAsianFont119);

            level6ParagraphProperties12.Append(spaceBefore110);
            level6ParagraphProperties12.Append(spaceAfter85);
            level6ParagraphProperties12.Append(bulletColor68);
            level6ParagraphProperties12.Append(defaultRunProperties139);

            A.Level7ParagraphProperties level7ParagraphProperties12 = new A.Level7ParagraphProperties() { LeftMargin = 2411413, Indent = -230188, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, FontAlignment = A.TextFontAlignmentValues.Baseline };

            A.SpaceBefore spaceBefore111 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent159 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore111.Append(spacingPercent159);

            A.SpaceAfter spaceAfter86 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent160 = new A.SpacingPercent() { Val = 0 };

            spaceAfter86.Append(spacingPercent160);

            A.BulletColor bulletColor69 = new A.BulletColor();
            A.SchemeColor schemeColor265 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor69.Append(schemeColor265);

            A.DefaultRunProperties defaultRunProperties140 = new A.DefaultRunProperties();

            A.SolidFill solidFill218 = new A.SolidFill();
            A.SchemeColor schemeColor266 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill218.Append(schemeColor266);
            A.LatinFont latinFont158 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont120 = new A.EastAsianFont() { Typeface = "+mn-ea" };

            defaultRunProperties140.Append(solidFill218);
            defaultRunProperties140.Append(latinFont158);
            defaultRunProperties140.Append(eastAsianFont120);

            level7ParagraphProperties12.Append(spaceBefore111);
            level7ParagraphProperties12.Append(spaceAfter86);
            level7ParagraphProperties12.Append(bulletColor69);
            level7ParagraphProperties12.Append(defaultRunProperties140);

            A.Level8ParagraphProperties level8ParagraphProperties12 = new A.Level8ParagraphProperties() { LeftMargin = 2868613, Indent = -230188, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, FontAlignment = A.TextFontAlignmentValues.Baseline };

            A.SpaceBefore spaceBefore112 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent161 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore112.Append(spacingPercent161);

            A.SpaceAfter spaceAfter87 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent162 = new A.SpacingPercent() { Val = 0 };

            spaceAfter87.Append(spacingPercent162);

            A.BulletColor bulletColor70 = new A.BulletColor();
            A.SchemeColor schemeColor267 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor70.Append(schemeColor267);

            A.DefaultRunProperties defaultRunProperties141 = new A.DefaultRunProperties();

            A.SolidFill solidFill219 = new A.SolidFill();
            A.SchemeColor schemeColor268 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill219.Append(schemeColor268);
            A.LatinFont latinFont159 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont121 = new A.EastAsianFont() { Typeface = "+mn-ea" };

            defaultRunProperties141.Append(solidFill219);
            defaultRunProperties141.Append(latinFont159);
            defaultRunProperties141.Append(eastAsianFont121);

            level8ParagraphProperties12.Append(spaceBefore112);
            level8ParagraphProperties12.Append(spaceAfter87);
            level8ParagraphProperties12.Append(bulletColor70);
            level8ParagraphProperties12.Append(defaultRunProperties141);

            A.Level9ParagraphProperties level9ParagraphProperties12 = new A.Level9ParagraphProperties() { LeftMargin = 3325813, Indent = -230188, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, FontAlignment = A.TextFontAlignmentValues.Baseline };

            A.SpaceBefore spaceBefore113 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent163 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore113.Append(spacingPercent163);

            A.SpaceAfter spaceAfter88 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent164 = new A.SpacingPercent() { Val = 0 };

            spaceAfter88.Append(spacingPercent164);

            A.BulletColor bulletColor71 = new A.BulletColor();
            A.SchemeColor schemeColor269 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor71.Append(schemeColor269);

            A.DefaultRunProperties defaultRunProperties142 = new A.DefaultRunProperties();

            A.SolidFill solidFill220 = new A.SolidFill();
            A.SchemeColor schemeColor270 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill220.Append(schemeColor270);
            A.LatinFont latinFont160 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont122 = new A.EastAsianFont() { Typeface = "+mn-ea" };

            defaultRunProperties142.Append(solidFill220);
            defaultRunProperties142.Append(latinFont160);
            defaultRunProperties142.Append(eastAsianFont122);

            level9ParagraphProperties12.Append(spaceBefore113);
            level9ParagraphProperties12.Append(spaceAfter88);
            level9ParagraphProperties12.Append(bulletColor71);
            level9ParagraphProperties12.Append(defaultRunProperties142);

            bodyStyle1.Append(level1ParagraphProperties20);
            bodyStyle1.Append(level2ParagraphProperties12);
            bodyStyle1.Append(level3ParagraphProperties12);
            bodyStyle1.Append(level4ParagraphProperties12);
            bodyStyle1.Append(level5ParagraphProperties12);
            bodyStyle1.Append(level6ParagraphProperties12);
            bodyStyle1.Append(level7ParagraphProperties12);
            bodyStyle1.Append(level8ParagraphProperties12);
            bodyStyle1.Append(level9ParagraphProperties12);

            OtherStyle otherStyle1 = new OtherStyle();

            A.DefaultParagraphProperties defaultParagraphProperties4 = new A.DefaultParagraphProperties();
            A.DefaultRunProperties defaultRunProperties143 = new A.DefaultRunProperties() { Language = "lv-LV" };

            defaultParagraphProperties4.Append(defaultRunProperties143);

            A.Level1ParagraphProperties level1ParagraphProperties21 = new A.Level1ParagraphProperties() { LeftMargin = 0, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties144 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill221 = new A.SolidFill();
            A.SchemeColor schemeColor271 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill221.Append(schemeColor271);
            A.LatinFont latinFont161 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont123 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont68 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties144.Append(solidFill221);
            defaultRunProperties144.Append(latinFont161);
            defaultRunProperties144.Append(eastAsianFont123);
            defaultRunProperties144.Append(complexScriptFont68);

            level1ParagraphProperties21.Append(defaultRunProperties144);

            A.Level2ParagraphProperties level2ParagraphProperties13 = new A.Level2ParagraphProperties() { LeftMargin = 457200, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties145 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill222 = new A.SolidFill();
            A.SchemeColor schemeColor272 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill222.Append(schemeColor272);
            A.LatinFont latinFont162 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont124 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont69 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties145.Append(solidFill222);
            defaultRunProperties145.Append(latinFont162);
            defaultRunProperties145.Append(eastAsianFont124);
            defaultRunProperties145.Append(complexScriptFont69);

            level2ParagraphProperties13.Append(defaultRunProperties145);

            A.Level3ParagraphProperties level3ParagraphProperties13 = new A.Level3ParagraphProperties() { LeftMargin = 914400, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties146 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill223 = new A.SolidFill();
            A.SchemeColor schemeColor273 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill223.Append(schemeColor273);
            A.LatinFont latinFont163 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont125 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont70 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties146.Append(solidFill223);
            defaultRunProperties146.Append(latinFont163);
            defaultRunProperties146.Append(eastAsianFont125);
            defaultRunProperties146.Append(complexScriptFont70);

            level3ParagraphProperties13.Append(defaultRunProperties146);

            A.Level4ParagraphProperties level4ParagraphProperties13 = new A.Level4ParagraphProperties() { LeftMargin = 1371600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties147 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill224 = new A.SolidFill();
            A.SchemeColor schemeColor274 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill224.Append(schemeColor274);
            A.LatinFont latinFont164 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont126 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont71 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties147.Append(solidFill224);
            defaultRunProperties147.Append(latinFont164);
            defaultRunProperties147.Append(eastAsianFont126);
            defaultRunProperties147.Append(complexScriptFont71);

            level4ParagraphProperties13.Append(defaultRunProperties147);

            A.Level5ParagraphProperties level5ParagraphProperties13 = new A.Level5ParagraphProperties() { LeftMargin = 1828800, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties148 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill225 = new A.SolidFill();
            A.SchemeColor schemeColor275 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill225.Append(schemeColor275);
            A.LatinFont latinFont165 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont127 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont72 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties148.Append(solidFill225);
            defaultRunProperties148.Append(latinFont165);
            defaultRunProperties148.Append(eastAsianFont127);
            defaultRunProperties148.Append(complexScriptFont72);

            level5ParagraphProperties13.Append(defaultRunProperties148);

            A.Level6ParagraphProperties level6ParagraphProperties13 = new A.Level6ParagraphProperties() { LeftMargin = 2286000, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties149 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill226 = new A.SolidFill();
            A.SchemeColor schemeColor276 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill226.Append(schemeColor276);
            A.LatinFont latinFont166 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont128 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont73 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties149.Append(solidFill226);
            defaultRunProperties149.Append(latinFont166);
            defaultRunProperties149.Append(eastAsianFont128);
            defaultRunProperties149.Append(complexScriptFont73);

            level6ParagraphProperties13.Append(defaultRunProperties149);

            A.Level7ParagraphProperties level7ParagraphProperties13 = new A.Level7ParagraphProperties() { LeftMargin = 2743200, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties150 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill227 = new A.SolidFill();
            A.SchemeColor schemeColor277 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill227.Append(schemeColor277);
            A.LatinFont latinFont167 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont129 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont74 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties150.Append(solidFill227);
            defaultRunProperties150.Append(latinFont167);
            defaultRunProperties150.Append(eastAsianFont129);
            defaultRunProperties150.Append(complexScriptFont74);

            level7ParagraphProperties13.Append(defaultRunProperties150);

            A.Level8ParagraphProperties level8ParagraphProperties13 = new A.Level8ParagraphProperties() { LeftMargin = 3200400, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties151 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill228 = new A.SolidFill();
            A.SchemeColor schemeColor278 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill228.Append(schemeColor278);
            A.LatinFont latinFont168 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont130 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont75 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties151.Append(solidFill228);
            defaultRunProperties151.Append(latinFont168);
            defaultRunProperties151.Append(eastAsianFont130);
            defaultRunProperties151.Append(complexScriptFont75);

            level8ParagraphProperties13.Append(defaultRunProperties151);

            A.Level9ParagraphProperties level9ParagraphProperties13 = new A.Level9ParagraphProperties() { LeftMargin = 3657600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties152 = new A.DefaultRunProperties() { FontSize = 1800, Kerning = 1200 };

            A.SolidFill solidFill229 = new A.SolidFill();
            A.SchemeColor schemeColor279 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill229.Append(schemeColor279);
            A.LatinFont latinFont169 = new A.LatinFont() { Typeface = "+mn-lt" };
            A.EastAsianFont eastAsianFont131 = new A.EastAsianFont() { Typeface = "+mn-ea" };
            A.ComplexScriptFont complexScriptFont76 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties152.Append(solidFill229);
            defaultRunProperties152.Append(latinFont169);
            defaultRunProperties152.Append(eastAsianFont131);
            defaultRunProperties152.Append(complexScriptFont76);

            level9ParagraphProperties13.Append(defaultRunProperties152);

            otherStyle1.Append(defaultParagraphProperties4);
            otherStyle1.Append(level1ParagraphProperties21);
            otherStyle1.Append(level2ParagraphProperties13);
            otherStyle1.Append(level3ParagraphProperties13);
            otherStyle1.Append(level4ParagraphProperties13);
            otherStyle1.Append(level5ParagraphProperties13);
            otherStyle1.Append(level6ParagraphProperties13);
            otherStyle1.Append(level7ParagraphProperties13);
            otherStyle1.Append(level8ParagraphProperties13);
            otherStyle1.Append(level9ParagraphProperties13);

            textStyles1.Append(titleStyle1);
            textStyles1.Append(bodyStyle1);
            textStyles1.Append(otherStyle1);

            slideMaster1.Append(commonSlideData6);
            slideMaster1.Append(colorMap15);
            slideMaster1.Append(slideLayoutIdList1);
            slideMaster1.Append(textStyles1);

            slideMasterPart1.SlideMaster = slideMaster1;
        }
    }
}
