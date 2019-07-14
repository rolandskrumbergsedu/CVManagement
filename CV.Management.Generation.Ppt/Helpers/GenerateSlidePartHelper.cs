using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Presentation;
using A = DocumentFormat.OpenXml.Drawing;
using P14 = DocumentFormat.OpenXml.Office2010.PowerPoint;
using A14 = DocumentFormat.OpenXml.Office2010.Drawing;
using System.Collections.Generic;
using System.Text;

namespace CV.Management.Generation.Ppt.Helpers
{
    public static class GenerateSlidePartHelper
    {
        public static void GenerateSlidePart1Content(SlidePart slidePart1, PresentationGenerationData data)
        {
            Slide slide1 = new Slide();
            slide1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slide1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slide1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData3 = new CommonSlideData();

            ShapeTree shapeTree3 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties3 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties13 = new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties3 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties13 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties3.Append(nonVisualDrawingProperties13);
            nonVisualGroupShapeProperties3.Append(nonVisualGroupShapeDrawingProperties3);
            nonVisualGroupShapeProperties3.Append(applicationNonVisualDrawingProperties13);

            GroupShapeProperties groupShapeProperties3 = new GroupShapeProperties();

            A.TransformGroup transformGroup3 = new A.TransformGroup();
            A.Offset offset15 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents15 = new A.Extents() { Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset3 = new A.ChildOffset() { X = 0L, Y = 0L };
            A.ChildExtents childExtents3 = new A.ChildExtents() { Cx = 0L, Cy = 0L };

            transformGroup3.Append(offset15);
            transformGroup3.Append(extents15);
            transformGroup3.Append(childOffset3);
            transformGroup3.Append(childExtents3);

            groupShapeProperties3.Append(transformGroup3);

            Shape shape11 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties11 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties14 = new NonVisualDrawingProperties() { Id = (UInt32Value)18434U, Name = "Text Box 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties11 = new NonVisualShapeDrawingProperties() { TextBox = true };
            A.ShapeLocks shapeLocks11 = new A.ShapeLocks() { NoChangeArrowheads = true };

            nonVisualShapeDrawingProperties11.Append(shapeLocks11);
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties14 = new ApplicationNonVisualDrawingProperties();

            nonVisualShapeProperties11.Append(nonVisualDrawingProperties14);
            nonVisualShapeProperties11.Append(nonVisualShapeDrawingProperties11);
            nonVisualShapeProperties11.Append(applicationNonVisualDrawingProperties14);

            ShapeProperties shapeProperties13 = new ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D13 = new A.Transform2D();
            A.Offset offset16 = new A.Offset() { X = 533400L, Y = 381000L };
            A.Extents extents16 = new A.Extents() { Cx = 3810000L, Cy = 1447800L };

            transform2D13.Append(offset16);
            transform2D13.Append(extents16);

            A.PresetGeometry presetGeometry11 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList20 = new A.AdjustValueList();

            presetGeometry11.Append(adjustValueList20);

            A.SolidFill solidFill59 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex205 = new A.RgbColorModelHex() { Val = "262261" };

            solidFill59.Append(rgbColorModelHex205);

            A.Outline outline28 = new A.Outline();
            A.NoFill noFill14 = new A.NoFill();

            outline28.Append(noFill14);

            A.ShapePropertiesExtensionList shapePropertiesExtensionList2 = new A.ShapePropertiesExtensionList();

            A.ShapePropertiesExtension shapePropertiesExtension2 = new A.ShapePropertiesExtension() { Uri = "{91240B29-F687-4F45-9708-019B960494DF}" };

            A14.HiddenLineProperties hiddenLineProperties1 = new A14.HiddenLineProperties() { Width = 9525 };
            hiddenLineProperties1.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill60 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex206 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill60.Append(rgbColorModelHex206);
            A.Miter miter10 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd9 = new A.HeadEnd();
            A.TailEnd tailEnd9 = new A.TailEnd();

            hiddenLineProperties1.Append(solidFill60);
            hiddenLineProperties1.Append(miter10);
            hiddenLineProperties1.Append(headEnd9);
            hiddenLineProperties1.Append(tailEnd9);

            shapePropertiesExtension2.Append(hiddenLineProperties1);

            shapePropertiesExtensionList2.Append(shapePropertiesExtension2);

            shapeProperties13.Append(transform2D13);
            shapeProperties13.Append(presetGeometry11);
            shapeProperties13.Append(solidFill59);
            shapeProperties13.Append(outline28);
            shapeProperties13.Append(shapePropertiesExtensionList2);

            TextBody textBody10 = new TextBody();
            A.BodyProperties bodyProperties12 = new A.BodyProperties() { LeftInset = 108000, TopInset = 108000, RightInset = 108000, BottomInset = 108000 };

            A.ListStyle listStyle12 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties11 = new A.Level1ParagraphProperties();

            A.SpaceBefore spaceBefore13 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent27 = new A.SpacingPercent() { Val = 50000 };

            spaceBefore13.Append(spacingPercent27);

            A.BulletColor bulletColor1 = new A.BulletColor();
            A.SchemeColor schemeColor94 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor1.Append(schemeColor94);
            A.BulletFont bulletFont1 = new A.BulletFont() { Typeface = "Wingdings", Panose = "05000000000000000000", PitchFamily = 2, CharacterSet = 2 };

            A.DefaultRunProperties defaultRunProperties35 = new A.DefaultRunProperties();

            A.SolidFill solidFill61 = new A.SolidFill();
            A.SchemeColor schemeColor95 = new A.SchemeColor() { Val = A.SchemeColorValues.Background2 };

            solidFill61.Append(schemeColor95);
            A.LatinFont latinFont30 = new A.LatinFont() { Typeface = "Bliss Pro Regular", Panose = "02010006030000020004", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont30 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties35.Append(solidFill61);
            defaultRunProperties35.Append(latinFont30);
            defaultRunProperties35.Append(eastAsianFont30);

            level1ParagraphProperties11.Append(spaceBefore13);
            level1ParagraphProperties11.Append(bulletColor1);
            level1ParagraphProperties11.Append(bulletFont1);
            level1ParagraphProperties11.Append(defaultRunProperties35);

            A.Level2ParagraphProperties level2ParagraphProperties3 = new A.Level2ParagraphProperties() { LeftMargin = 742950, Indent = -285750 };

            A.SpaceBefore spaceBefore14 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent28 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore14.Append(spacingPercent28);

            A.BulletColor bulletColor2 = new A.BulletColor();
            A.SchemeColor schemeColor96 = new A.SchemeColor() { Val = A.SchemeColorValues.Background2 };

            bulletColor2.Append(schemeColor96);
            A.BulletFont bulletFont2 = new A.BulletFont() { Typeface = "Times", Panose = "02020603050405020304", PitchFamily = 18, CharacterSet = 0 };
            A.CharacterBullet characterBullet1 = new A.CharacterBullet() { Char = "•" };

            A.DefaultRunProperties defaultRunProperties36 = new A.DefaultRunProperties();

            A.SolidFill solidFill62 = new A.SolidFill();
            A.SchemeColor schemeColor97 = new A.SchemeColor() { Val = A.SchemeColorValues.Background2 };

            solidFill62.Append(schemeColor97);
            A.LatinFont latinFont31 = new A.LatinFont() { Typeface = "Bliss Pro Regular", Panose = "02010006030000020004", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont31 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties36.Append(solidFill62);
            defaultRunProperties36.Append(latinFont31);
            defaultRunProperties36.Append(eastAsianFont31);

            level2ParagraphProperties3.Append(spaceBefore14);
            level2ParagraphProperties3.Append(bulletColor2);
            level2ParagraphProperties3.Append(bulletFont2);
            level2ParagraphProperties3.Append(characterBullet1);
            level2ParagraphProperties3.Append(defaultRunProperties36);

            A.Level3ParagraphProperties level3ParagraphProperties3 = new A.Level3ParagraphProperties() { LeftMargin = 1143000, Indent = -228600 };

            A.SpaceBefore spaceBefore15 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent29 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore15.Append(spacingPercent29);

            A.BulletColor bulletColor3 = new A.BulletColor();
            A.SchemeColor schemeColor98 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor3.Append(schemeColor98);

            A.DefaultRunProperties defaultRunProperties37 = new A.DefaultRunProperties();

            A.SolidFill solidFill63 = new A.SolidFill();
            A.SchemeColor schemeColor99 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill63.Append(schemeColor99);
            A.LatinFont latinFont32 = new A.LatinFont() { Typeface = "Bliss Pro Regular", Panose = "02010006030000020004", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont32 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties37.Append(solidFill63);
            defaultRunProperties37.Append(latinFont32);
            defaultRunProperties37.Append(eastAsianFont32);

            level3ParagraphProperties3.Append(spaceBefore15);
            level3ParagraphProperties3.Append(bulletColor3);
            level3ParagraphProperties3.Append(defaultRunProperties37);

            A.Level4ParagraphProperties level4ParagraphProperties3 = new A.Level4ParagraphProperties() { LeftMargin = 1600200, Indent = -228600 };

            A.SpaceBefore spaceBefore16 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent30 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore16.Append(spacingPercent30);

            A.BulletColor bulletColor4 = new A.BulletColor();
            A.SchemeColor schemeColor100 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor4.Append(schemeColor100);
            A.BulletFont bulletFont3 = new A.BulletFont() { Typeface = "Wingdings", Panose = "05000000000000000000", PitchFamily = 2, CharacterSet = 2 };

            A.DefaultRunProperties defaultRunProperties38 = new A.DefaultRunProperties();

            A.SolidFill solidFill64 = new A.SolidFill();
            A.SchemeColor schemeColor101 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill64.Append(schemeColor101);
            A.LatinFont latinFont33 = new A.LatinFont() { Typeface = "Bliss Pro Regular", Panose = "02010006030000020004", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont33 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties38.Append(solidFill64);
            defaultRunProperties38.Append(latinFont33);
            defaultRunProperties38.Append(eastAsianFont33);

            level4ParagraphProperties3.Append(spaceBefore16);
            level4ParagraphProperties3.Append(bulletColor4);
            level4ParagraphProperties3.Append(bulletFont3);
            level4ParagraphProperties3.Append(defaultRunProperties38);

            A.Level5ParagraphProperties level5ParagraphProperties3 = new A.Level5ParagraphProperties() { LeftMargin = 2057400, Indent = -228600 };

            A.SpaceBefore spaceBefore17 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent31 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore17.Append(spacingPercent31);

            A.BulletColor bulletColor5 = new A.BulletColor();
            A.SchemeColor schemeColor102 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor5.Append(schemeColor102);

            A.DefaultRunProperties defaultRunProperties39 = new A.DefaultRunProperties();

            A.SolidFill solidFill65 = new A.SolidFill();
            A.SchemeColor schemeColor103 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill65.Append(schemeColor103);
            A.LatinFont latinFont34 = new A.LatinFont() { Typeface = "Bliss Pro Regular", Panose = "02010006030000020004", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont34 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties39.Append(solidFill65);
            defaultRunProperties39.Append(latinFont34);
            defaultRunProperties39.Append(eastAsianFont34);

            level5ParagraphProperties3.Append(spaceBefore17);
            level5ParagraphProperties3.Append(bulletColor5);
            level5ParagraphProperties3.Append(defaultRunProperties39);

            A.Level6ParagraphProperties level6ParagraphProperties3 = new A.Level6ParagraphProperties() { LeftMargin = 2514600, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore18 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent32 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore18.Append(spacingPercent32);

            A.SpaceAfter spaceAfter13 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent33 = new A.SpacingPercent() { Val = 0 };

            spaceAfter13.Append(spacingPercent33);

            A.BulletColor bulletColor6 = new A.BulletColor();
            A.SchemeColor schemeColor104 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor6.Append(schemeColor104);

            A.DefaultRunProperties defaultRunProperties40 = new A.DefaultRunProperties();

            A.SolidFill solidFill66 = new A.SolidFill();
            A.SchemeColor schemeColor105 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill66.Append(schemeColor105);
            A.LatinFont latinFont35 = new A.LatinFont() { Typeface = "Bliss Pro Regular", Panose = "02010006030000020004", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont35 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties40.Append(solidFill66);
            defaultRunProperties40.Append(latinFont35);
            defaultRunProperties40.Append(eastAsianFont35);

            level6ParagraphProperties3.Append(spaceBefore18);
            level6ParagraphProperties3.Append(spaceAfter13);
            level6ParagraphProperties3.Append(bulletColor6);
            level6ParagraphProperties3.Append(defaultRunProperties40);

            A.Level7ParagraphProperties level7ParagraphProperties3 = new A.Level7ParagraphProperties() { LeftMargin = 2971800, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore19 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent34 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore19.Append(spacingPercent34);

            A.SpaceAfter spaceAfter14 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent35 = new A.SpacingPercent() { Val = 0 };

            spaceAfter14.Append(spacingPercent35);

            A.BulletColor bulletColor7 = new A.BulletColor();
            A.SchemeColor schemeColor106 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor7.Append(schemeColor106);

            A.DefaultRunProperties defaultRunProperties41 = new A.DefaultRunProperties();

            A.SolidFill solidFill67 = new A.SolidFill();
            A.SchemeColor schemeColor107 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill67.Append(schemeColor107);
            A.LatinFont latinFont36 = new A.LatinFont() { Typeface = "Bliss Pro Regular", Panose = "02010006030000020004", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont36 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties41.Append(solidFill67);
            defaultRunProperties41.Append(latinFont36);
            defaultRunProperties41.Append(eastAsianFont36);

            level7ParagraphProperties3.Append(spaceBefore19);
            level7ParagraphProperties3.Append(spaceAfter14);
            level7ParagraphProperties3.Append(bulletColor7);
            level7ParagraphProperties3.Append(defaultRunProperties41);

            A.Level8ParagraphProperties level8ParagraphProperties3 = new A.Level8ParagraphProperties() { LeftMargin = 3429000, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore20 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent36 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore20.Append(spacingPercent36);

            A.SpaceAfter spaceAfter15 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent37 = new A.SpacingPercent() { Val = 0 };

            spaceAfter15.Append(spacingPercent37);

            A.BulletColor bulletColor8 = new A.BulletColor();
            A.SchemeColor schemeColor108 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor8.Append(schemeColor108);

            A.DefaultRunProperties defaultRunProperties42 = new A.DefaultRunProperties();

            A.SolidFill solidFill68 = new A.SolidFill();
            A.SchemeColor schemeColor109 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill68.Append(schemeColor109);
            A.LatinFont latinFont37 = new A.LatinFont() { Typeface = "Bliss Pro Regular", Panose = "02010006030000020004", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont37 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties42.Append(solidFill68);
            defaultRunProperties42.Append(latinFont37);
            defaultRunProperties42.Append(eastAsianFont37);

            level8ParagraphProperties3.Append(spaceBefore20);
            level8ParagraphProperties3.Append(spaceAfter15);
            level8ParagraphProperties3.Append(bulletColor8);
            level8ParagraphProperties3.Append(defaultRunProperties42);

            A.Level9ParagraphProperties level9ParagraphProperties3 = new A.Level9ParagraphProperties() { LeftMargin = 3886200, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore21 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent38 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore21.Append(spacingPercent38);

            A.SpaceAfter spaceAfter16 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent39 = new A.SpacingPercent() { Val = 0 };

            spaceAfter16.Append(spacingPercent39);

            A.BulletColor bulletColor9 = new A.BulletColor();
            A.SchemeColor schemeColor110 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor9.Append(schemeColor110);

            A.DefaultRunProperties defaultRunProperties43 = new A.DefaultRunProperties();

            A.SolidFill solidFill69 = new A.SolidFill();
            A.SchemeColor schemeColor111 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill69.Append(schemeColor111);
            A.LatinFont latinFont38 = new A.LatinFont() { Typeface = "Bliss Pro Regular", Panose = "02010006030000020004", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont38 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties43.Append(solidFill69);
            defaultRunProperties43.Append(latinFont38);
            defaultRunProperties43.Append(eastAsianFont38);

            level9ParagraphProperties3.Append(spaceBefore21);
            level9ParagraphProperties3.Append(spaceAfter16);
            level9ParagraphProperties3.Append(bulletColor9);
            level9ParagraphProperties3.Append(defaultRunProperties43);

            listStyle12.Append(level1ParagraphProperties11);
            listStyle12.Append(level2ParagraphProperties3);
            listStyle12.Append(level3ParagraphProperties3);
            listStyle12.Append(level4ParagraphProperties3);
            listStyle12.Append(level5ParagraphProperties3);
            listStyle12.Append(level6ParagraphProperties3);
            listStyle12.Append(level7ParagraphProperties3);
            listStyle12.Append(level8ParagraphProperties3);
            listStyle12.Append(level9ParagraphProperties3);

            A.Paragraph paragraph14 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties11 = new A.ParagraphProperties();

            A.SpaceBefore spaceBefore22 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints1 = new A.SpacingPoints() { Val = 600 };

            spaceBefore22.Append(spacingPoints1);

            A.SpaceAfter spaceAfter17 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints2 = new A.SpacingPoints() { Val = 600 };

            spaceAfter17.Append(spacingPoints2);

            A.BulletColor bulletColor10 = new A.BulletColor();
            A.RgbColorModelHex rgbColorModelHex207 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            bulletColor10.Append(rgbColorModelHex207);
            A.BulletFontText bulletFontText3 = new A.BulletFontText();
            A.NoBullet noBullet3 = new A.NoBullet();

            paragraphProperties11.Append(spaceBefore22);
            paragraphProperties11.Append(spaceAfter17);
            paragraphProperties11.Append(bulletColor10);
            paragraphProperties11.Append(bulletFontText3);
            paragraphProperties11.Append(noBullet3);

            A.Run run6 = new A.Run();

            A.RunProperties runProperties9 = new A.RunProperties() { Language = "lv-LV", AlternativeLanguage = "et-EE", FontSize = 1600, Bold = true, Dirty = false, SpellingError = true };

            A.SolidFill solidFill70 = new A.SolidFill();
            A.SchemeColor schemeColor112 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill70.Append(schemeColor112);
            A.LatinFont latinFont39 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.ComplexScriptFont complexScriptFont28 = new A.ComplexScriptFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };

            runProperties9.Append(solidFill70);
            runProperties9.Append(latinFont39);
            runProperties9.Append(complexScriptFont28);
            A.Text text9 = new A.Text();
            text9.Text = data.FullName;

            run6.Append(runProperties9);
            run6.Append(text9);

            A.EndParagraphRunProperties endParagraphRunProperties9 = new A.EndParagraphRunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1600, Bold = true, Dirty = false };

            A.SolidFill solidFill73 = new A.SolidFill();
            A.SchemeColor schemeColor115 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill73.Append(schemeColor115);
            A.LatinFont latinFont42 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.ComplexScriptFont complexScriptFont31 = new A.ComplexScriptFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };

            endParagraphRunProperties9.Append(solidFill73);
            endParagraphRunProperties9.Append(latinFont42);
            endParagraphRunProperties9.Append(complexScriptFont31);

            paragraph14.Append(paragraphProperties11);
            paragraph14.Append(run6);
            paragraph14.Append(endParagraphRunProperties9);

            A.Paragraph paragraph15 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties12 = new A.ParagraphProperties();

            A.SpaceBefore spaceBefore23 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints3 = new A.SpacingPoints() { Val = 600 };

            spaceBefore23.Append(spacingPoints3);

            A.SpaceAfter spaceAfter18 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints4 = new A.SpacingPoints() { Val = 600 };

            spaceAfter18.Append(spacingPoints4);

            A.BulletColor bulletColor11 = new A.BulletColor();
            A.RgbColorModelHex rgbColorModelHex208 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            bulletColor11.Append(rgbColorModelHex208);
            A.BulletFontText bulletFontText4 = new A.BulletFontText();
            A.NoBullet noBullet4 = new A.NoBullet();

            paragraphProperties12.Append(spaceBefore23);
            paragraphProperties12.Append(spaceAfter18);
            paragraphProperties12.Append(bulletColor11);
            paragraphProperties12.Append(bulletFontText4);
            paragraphProperties12.Append(noBullet4);

            A.Run run9 = new A.Run();

            A.RunProperties runProperties12 = new A.RunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill74 = new A.SolidFill();
            A.SchemeColor schemeColor116 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill74.Append(schemeColor116);
            A.LatinFont latinFont43 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.ComplexScriptFont complexScriptFont32 = new A.ComplexScriptFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };

            runProperties12.Append(solidFill74);
            runProperties12.Append(latinFont43);
            runProperties12.Append(complexScriptFont32);
            A.Text text12 = new A.Text();
            text12.Text = $"{PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.PHONE, data.Language)}: ";

            run9.Append(runProperties12);
            run9.Append(text12);

            A.Run run10 = new A.Run();

            A.RunProperties runProperties13 = new A.RunProperties() { Language = "lv-LV", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill75 = new A.SolidFill();
            A.SchemeColor schemeColor117 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill75.Append(schemeColor117);
            A.LatinFont latinFont44 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.ComplexScriptFont complexScriptFont33 = new A.ComplexScriptFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };

            runProperties13.Append(solidFill75);
            runProperties13.Append(latinFont44);
            runProperties13.Append(complexScriptFont33);
            A.Text text13 = new A.Text();
            text13.Text = data.Phone;

            run10.Append(runProperties13);
            run10.Append(text13);

            A.EndParagraphRunProperties endParagraphRunProperties10 = new A.EndParagraphRunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill76 = new A.SolidFill();
            A.SchemeColor schemeColor118 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill76.Append(schemeColor118);
            A.LatinFont latinFont45 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.ComplexScriptFont complexScriptFont34 = new A.ComplexScriptFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };

            endParagraphRunProperties10.Append(solidFill76);
            endParagraphRunProperties10.Append(latinFont45);
            endParagraphRunProperties10.Append(complexScriptFont34);

            paragraph15.Append(paragraphProperties12);
            paragraph15.Append(run9);
            paragraph15.Append(run10);
            paragraph15.Append(endParagraphRunProperties10);

            A.Paragraph paragraph16 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties13 = new A.ParagraphProperties();

            A.SpaceBefore spaceBefore24 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints5 = new A.SpacingPoints() { Val = 600 };

            spaceBefore24.Append(spacingPoints5);

            A.SpaceAfter spaceAfter19 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints6 = new A.SpacingPoints() { Val = 600 };

            spaceAfter19.Append(spacingPoints6);

            A.BulletColor bulletColor12 = new A.BulletColor();
            A.RgbColorModelHex rgbColorModelHex209 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            bulletColor12.Append(rgbColorModelHex209);
            A.BulletFontText bulletFontText5 = new A.BulletFontText();
            A.NoBullet noBullet5 = new A.NoBullet();

            paragraphProperties13.Append(spaceBefore24);
            paragraphProperties13.Append(spaceAfter19);
            paragraphProperties13.Append(bulletColor12);
            paragraphProperties13.Append(bulletFontText5);
            paragraphProperties13.Append(noBullet5);

            A.Run run11 = new A.Run();

            A.RunProperties runProperties14 = new A.RunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill77 = new A.SolidFill();
            A.SchemeColor schemeColor119 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill77.Append(schemeColor119);
            A.LatinFont latinFont46 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.ComplexScriptFont complexScriptFont35 = new A.ComplexScriptFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };

            runProperties14.Append(solidFill77);
            runProperties14.Append(latinFont46);
            runProperties14.Append(complexScriptFont35);
            A.Text text14 = new A.Text();
            text14.Text = $"{PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.EMAIL, data.Language)}: ";

            run11.Append(runProperties14);
            run11.Append(text14);

            A.Run run12 = new A.Run();

            A.RunProperties runProperties15 = new A.RunProperties() { Language = "lv-LV", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill78 = new A.SolidFill();
            A.SchemeColor schemeColor120 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill78.Append(schemeColor120);
            A.LatinFont latinFont47 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.ComplexScriptFont complexScriptFont36 = new A.ComplexScriptFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };

            runProperties15.Append(solidFill78);
            runProperties15.Append(latinFont47);
            runProperties15.Append(complexScriptFont36);
            A.Text text15 = new A.Text();
            text15.Text = data.Email;

            run12.Append(runProperties15);
            run12.Append(text15);

            A.EndParagraphRunProperties endParagraphRunProperties11 = new A.EndParagraphRunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill79 = new A.SolidFill();
            A.SchemeColor schemeColor121 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill79.Append(schemeColor121);
            A.LatinFont latinFont48 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.ComplexScriptFont complexScriptFont37 = new A.ComplexScriptFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };

            endParagraphRunProperties11.Append(solidFill79);
            endParagraphRunProperties11.Append(latinFont48);
            endParagraphRunProperties11.Append(complexScriptFont37);

            paragraph16.Append(paragraphProperties13);
            paragraph16.Append(run11);
            paragraph16.Append(run12);
            paragraph16.Append(endParagraphRunProperties11);

            textBody10.Append(bodyProperties12);
            textBody10.Append(listStyle12);
            textBody10.Append(paragraph14);
            textBody10.Append(paragraph15);
            textBody10.Append(paragraph16);

            shape11.Append(nonVisualShapeProperties11);
            shape11.Append(shapeProperties13);
            shape11.Append(textBody10);

            Shape shape12 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties12 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties15 = new NonVisualDrawingProperties() { Id = (UInt32Value)6147U, Name = "Text Box 6" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties12 = new NonVisualShapeDrawingProperties() { TextBox = true };
            A.ShapeLocks shapeLocks12 = new A.ShapeLocks() { NoChangeArrowheads = true };

            nonVisualShapeDrawingProperties12.Append(shapeLocks12);
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties15 = new ApplicationNonVisualDrawingProperties();

            nonVisualShapeProperties12.Append(nonVisualDrawingProperties15);
            nonVisualShapeProperties12.Append(nonVisualShapeDrawingProperties12);
            nonVisualShapeProperties12.Append(applicationNonVisualDrawingProperties15);

            ShapeProperties shapeProperties14 = new ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D14 = new A.Transform2D();
            A.Offset offset17 = new A.Offset() { X = 4424363L, Y = 381000L };
            A.Extents extents17 = new A.Extents() { Cx = 4953000L, Cy = 3505200L };

            transform2D14.Append(offset17);
            transform2D14.Append(extents17);

            A.PresetGeometry presetGeometry12 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList21 = new A.AdjustValueList();

            presetGeometry12.Append(adjustValueList21);

            A.SolidFill solidFill80 = new A.SolidFill();
            A.SchemeColor schemeColor122 = new A.SchemeColor() { Val = A.SchemeColorValues.Accent2 };

            solidFill80.Append(schemeColor122);

            A.Outline outline29 = new A.Outline();
            A.NoFill noFill15 = new A.NoFill();

            outline29.Append(noFill15);

            A.ShapePropertiesExtensionList shapePropertiesExtensionList3 = new A.ShapePropertiesExtensionList();

            A.ShapePropertiesExtension shapePropertiesExtension3 = new A.ShapePropertiesExtension() { Uri = "{91240B29-F687-4F45-9708-019B960494DF}" };

            A14.HiddenLineProperties hiddenLineProperties2 = new A14.HiddenLineProperties() { Width = 9525 };
            hiddenLineProperties2.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill81 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex210 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill81.Append(rgbColorModelHex210);
            A.Miter miter11 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd10 = new A.HeadEnd();
            A.TailEnd tailEnd10 = new A.TailEnd();

            hiddenLineProperties2.Append(solidFill81);
            hiddenLineProperties2.Append(miter11);
            hiddenLineProperties2.Append(headEnd10);
            hiddenLineProperties2.Append(tailEnd10);

            shapePropertiesExtension3.Append(hiddenLineProperties2);

            shapePropertiesExtensionList3.Append(shapePropertiesExtension3);

            shapeProperties14.Append(transform2D14);
            shapeProperties14.Append(presetGeometry12);
            shapeProperties14.Append(solidFill80);
            shapeProperties14.Append(outline29);
            shapeProperties14.Append(shapePropertiesExtensionList3);

            TextBody textBody11 = new TextBody();
            A.BodyProperties bodyProperties13 = new A.BodyProperties() { LeftInset = 108000, TopInset = 108000, RightInset = 108000, BottomInset = 108000 };

            A.ListStyle listStyle13 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties12 = new A.Level1ParagraphProperties();

            A.SpaceBefore spaceBefore25 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent40 = new A.SpacingPercent() { Val = 50000 };

            spaceBefore25.Append(spacingPercent40);

            A.BulletColor bulletColor13 = new A.BulletColor();
            A.SchemeColor schemeColor123 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor13.Append(schemeColor123);
            A.BulletFont bulletFont4 = new A.BulletFont() { Typeface = "Wingdings", PitchFamily = 2, CharacterSet = 2 };

            A.DefaultRunProperties defaultRunProperties44 = new A.DefaultRunProperties();

            A.SolidFill solidFill82 = new A.SolidFill();
            A.SchemeColor schemeColor124 = new A.SchemeColor() { Val = A.SchemeColorValues.Background2 };

            solidFill82.Append(schemeColor124);
            A.LatinFont latinFont49 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont39 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties44.Append(solidFill82);
            defaultRunProperties44.Append(latinFont49);
            defaultRunProperties44.Append(eastAsianFont39);

            level1ParagraphProperties12.Append(spaceBefore25);
            level1ParagraphProperties12.Append(bulletColor13);
            level1ParagraphProperties12.Append(bulletFont4);
            level1ParagraphProperties12.Append(defaultRunProperties44);

            A.Level2ParagraphProperties level2ParagraphProperties4 = new A.Level2ParagraphProperties() { LeftMargin = 742950, Indent = -285750 };

            A.SpaceBefore spaceBefore26 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent41 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore26.Append(spacingPercent41);

            A.BulletColor bulletColor14 = new A.BulletColor();
            A.SchemeColor schemeColor125 = new A.SchemeColor() { Val = A.SchemeColorValues.Background2 };

            bulletColor14.Append(schemeColor125);
            A.BulletFont bulletFont5 = new A.BulletFont() { Typeface = "Times", PitchFamily = 18, CharacterSet = 0 };
            A.CharacterBullet characterBullet2 = new A.CharacterBullet() { Char = "•" };

            A.DefaultRunProperties defaultRunProperties45 = new A.DefaultRunProperties();

            A.SolidFill solidFill83 = new A.SolidFill();
            A.SchemeColor schemeColor126 = new A.SchemeColor() { Val = A.SchemeColorValues.Background2 };

            solidFill83.Append(schemeColor126);
            A.LatinFont latinFont50 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont40 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties45.Append(solidFill83);
            defaultRunProperties45.Append(latinFont50);
            defaultRunProperties45.Append(eastAsianFont40);

            level2ParagraphProperties4.Append(spaceBefore26);
            level2ParagraphProperties4.Append(bulletColor14);
            level2ParagraphProperties4.Append(bulletFont5);
            level2ParagraphProperties4.Append(characterBullet2);
            level2ParagraphProperties4.Append(defaultRunProperties45);

            A.Level3ParagraphProperties level3ParagraphProperties4 = new A.Level3ParagraphProperties() { LeftMargin = 1143000, Indent = -228600 };

            A.SpaceBefore spaceBefore27 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent42 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore27.Append(spacingPercent42);

            A.BulletColor bulletColor15 = new A.BulletColor();
            A.SchemeColor schemeColor127 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor15.Append(schemeColor127);

            A.DefaultRunProperties defaultRunProperties46 = new A.DefaultRunProperties();

            A.SolidFill solidFill84 = new A.SolidFill();
            A.SchemeColor schemeColor128 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill84.Append(schemeColor128);
            A.LatinFont latinFont51 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont41 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties46.Append(solidFill84);
            defaultRunProperties46.Append(latinFont51);
            defaultRunProperties46.Append(eastAsianFont41);

            level3ParagraphProperties4.Append(spaceBefore27);
            level3ParagraphProperties4.Append(bulletColor15);
            level3ParagraphProperties4.Append(defaultRunProperties46);

            A.Level4ParagraphProperties level4ParagraphProperties4 = new A.Level4ParagraphProperties() { LeftMargin = 1600200, Indent = -228600 };

            A.SpaceBefore spaceBefore28 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent43 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore28.Append(spacingPercent43);

            A.BulletColor bulletColor16 = new A.BulletColor();
            A.SchemeColor schemeColor129 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor16.Append(schemeColor129);
            A.BulletFont bulletFont6 = new A.BulletFont() { Typeface = "Wingdings", PitchFamily = 2, CharacterSet = 2 };

            A.DefaultRunProperties defaultRunProperties47 = new A.DefaultRunProperties();

            A.SolidFill solidFill85 = new A.SolidFill();
            A.SchemeColor schemeColor130 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill85.Append(schemeColor130);
            A.LatinFont latinFont52 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont42 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties47.Append(solidFill85);
            defaultRunProperties47.Append(latinFont52);
            defaultRunProperties47.Append(eastAsianFont42);

            level4ParagraphProperties4.Append(spaceBefore28);
            level4ParagraphProperties4.Append(bulletColor16);
            level4ParagraphProperties4.Append(bulletFont6);
            level4ParagraphProperties4.Append(defaultRunProperties47);

            A.Level5ParagraphProperties level5ParagraphProperties4 = new A.Level5ParagraphProperties() { LeftMargin = 2057400, Indent = -228600 };

            A.SpaceBefore spaceBefore29 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent44 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore29.Append(spacingPercent44);

            A.BulletColor bulletColor17 = new A.BulletColor();
            A.SchemeColor schemeColor131 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor17.Append(schemeColor131);

            A.DefaultRunProperties defaultRunProperties48 = new A.DefaultRunProperties();

            A.SolidFill solidFill86 = new A.SolidFill();
            A.SchemeColor schemeColor132 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill86.Append(schemeColor132);
            A.LatinFont latinFont53 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont43 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties48.Append(solidFill86);
            defaultRunProperties48.Append(latinFont53);
            defaultRunProperties48.Append(eastAsianFont43);

            level5ParagraphProperties4.Append(spaceBefore29);
            level5ParagraphProperties4.Append(bulletColor17);
            level5ParagraphProperties4.Append(defaultRunProperties48);

            A.Level6ParagraphProperties level6ParagraphProperties4 = new A.Level6ParagraphProperties() { LeftMargin = 2514600, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore30 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent45 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore30.Append(spacingPercent45);

            A.SpaceAfter spaceAfter20 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent46 = new A.SpacingPercent() { Val = 0 };

            spaceAfter20.Append(spacingPercent46);

            A.BulletColor bulletColor18 = new A.BulletColor();
            A.SchemeColor schemeColor133 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor18.Append(schemeColor133);

            A.DefaultRunProperties defaultRunProperties49 = new A.DefaultRunProperties();

            A.SolidFill solidFill87 = new A.SolidFill();
            A.SchemeColor schemeColor134 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill87.Append(schemeColor134);
            A.LatinFont latinFont54 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont44 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties49.Append(solidFill87);
            defaultRunProperties49.Append(latinFont54);
            defaultRunProperties49.Append(eastAsianFont44);

            level6ParagraphProperties4.Append(spaceBefore30);
            level6ParagraphProperties4.Append(spaceAfter20);
            level6ParagraphProperties4.Append(bulletColor18);
            level6ParagraphProperties4.Append(defaultRunProperties49);

            A.Level7ParagraphProperties level7ParagraphProperties4 = new A.Level7ParagraphProperties() { LeftMargin = 2971800, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore31 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent47 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore31.Append(spacingPercent47);

            A.SpaceAfter spaceAfter21 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent48 = new A.SpacingPercent() { Val = 0 };

            spaceAfter21.Append(spacingPercent48);

            A.BulletColor bulletColor19 = new A.BulletColor();
            A.SchemeColor schemeColor135 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor19.Append(schemeColor135);

            A.DefaultRunProperties defaultRunProperties50 = new A.DefaultRunProperties();

            A.SolidFill solidFill88 = new A.SolidFill();
            A.SchemeColor schemeColor136 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill88.Append(schemeColor136);
            A.LatinFont latinFont55 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont45 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties50.Append(solidFill88);
            defaultRunProperties50.Append(latinFont55);
            defaultRunProperties50.Append(eastAsianFont45);

            level7ParagraphProperties4.Append(spaceBefore31);
            level7ParagraphProperties4.Append(spaceAfter21);
            level7ParagraphProperties4.Append(bulletColor19);
            level7ParagraphProperties4.Append(defaultRunProperties50);

            A.Level8ParagraphProperties level8ParagraphProperties4 = new A.Level8ParagraphProperties() { LeftMargin = 3429000, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore32 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent49 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore32.Append(spacingPercent49);

            A.SpaceAfter spaceAfter22 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent50 = new A.SpacingPercent() { Val = 0 };

            spaceAfter22.Append(spacingPercent50);

            A.BulletColor bulletColor20 = new A.BulletColor();
            A.SchemeColor schemeColor137 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor20.Append(schemeColor137);

            A.DefaultRunProperties defaultRunProperties51 = new A.DefaultRunProperties();

            A.SolidFill solidFill89 = new A.SolidFill();
            A.SchemeColor schemeColor138 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill89.Append(schemeColor138);
            A.LatinFont latinFont56 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont46 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties51.Append(solidFill89);
            defaultRunProperties51.Append(latinFont56);
            defaultRunProperties51.Append(eastAsianFont46);

            level8ParagraphProperties4.Append(spaceBefore32);
            level8ParagraphProperties4.Append(spaceAfter22);
            level8ParagraphProperties4.Append(bulletColor20);
            level8ParagraphProperties4.Append(defaultRunProperties51);

            A.Level9ParagraphProperties level9ParagraphProperties4 = new A.Level9ParagraphProperties() { LeftMargin = 3886200, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore33 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent51 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore33.Append(spacingPercent51);

            A.SpaceAfter spaceAfter23 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent52 = new A.SpacingPercent() { Val = 0 };

            spaceAfter23.Append(spacingPercent52);

            A.BulletColor bulletColor21 = new A.BulletColor();
            A.SchemeColor schemeColor139 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor21.Append(schemeColor139);

            A.DefaultRunProperties defaultRunProperties52 = new A.DefaultRunProperties();

            A.SolidFill solidFill90 = new A.SolidFill();
            A.SchemeColor schemeColor140 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill90.Append(schemeColor140);
            A.LatinFont latinFont57 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont47 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties52.Append(solidFill90);
            defaultRunProperties52.Append(latinFont57);
            defaultRunProperties52.Append(eastAsianFont47);

            level9ParagraphProperties4.Append(spaceBefore33);
            level9ParagraphProperties4.Append(spaceAfter23);
            level9ParagraphProperties4.Append(bulletColor21);
            level9ParagraphProperties4.Append(defaultRunProperties52);

            listStyle13.Append(level1ParagraphProperties12);
            listStyle13.Append(level2ParagraphProperties4);
            listStyle13.Append(level3ParagraphProperties4);
            listStyle13.Append(level4ParagraphProperties4);
            listStyle13.Append(level5ParagraphProperties4);
            listStyle13.Append(level6ParagraphProperties4);
            listStyle13.Append(level7ParagraphProperties4);
            listStyle13.Append(level8ParagraphProperties4);
            listStyle13.Append(level9ParagraphProperties4);

            A.Paragraph paragraph17 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties14 = new A.ParagraphProperties();

            A.SpaceBefore spaceBefore34 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints7 = new A.SpacingPoints() { Val = 600 };

            spaceBefore34.Append(spacingPoints7);

            A.SpaceAfter spaceAfter24 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints8 = new A.SpacingPoints() { Val = 600 };

            spaceAfter24.Append(spacingPoints8);

            A.BulletColor bulletColor22 = new A.BulletColor();
            A.RgbColorModelHex rgbColorModelHex211 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            bulletColor22.Append(rgbColorModelHex211);
            A.BulletFontText bulletFontText6 = new A.BulletFontText();
            A.NoBullet noBullet6 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties53 = new A.DefaultRunProperties();

            paragraphProperties14.Append(spaceBefore34);
            paragraphProperties14.Append(spaceAfter24);
            paragraphProperties14.Append(bulletColor22);
            paragraphProperties14.Append(bulletFontText6);
            paragraphProperties14.Append(noBullet6);
            paragraphProperties14.Append(defaultRunProperties53);

            A.Run run13 = new A.Run();

            A.RunProperties runProperties16 = new A.RunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1400, Bold = true, Dirty = false };

            A.SolidFill solidFill91 = new A.SolidFill();
            A.SchemeColor schemeColor141 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill91.Append(schemeColor141);
            A.LatinFont latinFont58 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.ComplexScriptFont complexScriptFont38 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            runProperties16.Append(solidFill91);
            runProperties16.Append(latinFont58);
            runProperties16.Append(complexScriptFont38);
            A.Text text16 = new A.Text();
            text16.Text = $"{PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.EXPERIENCE, data.Language)}";

            run13.Append(runProperties16);
            run13.Append(text16);

            paragraph17.Append(paragraphProperties14);
            paragraph17.Append(run13);

            //A.Paragraph paragraph18 = new A.Paragraph();

            //A.ParagraphProperties paragraphProperties15 = new A.ParagraphProperties();

            //A.SpaceBefore spaceBefore35 = new A.SpaceBefore();
            //A.SpacingPoints spacingPoints9 = new A.SpacingPoints() { Val = 0 };

            //spaceBefore35.Append(spacingPoints9);

            //A.SpaceAfter spaceAfter25 = new A.SpaceAfter();
            //A.SpacingPoints spacingPoints10 = new A.SpacingPoints() { Val = 0 };

            //spaceAfter25.Append(spacingPoints10);

            //A.BulletColor bulletColor23 = new A.BulletColor();
            //A.RgbColorModelHex rgbColorModelHex212 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            //bulletColor23.Append(rgbColorModelHex212);
            //A.BulletFontText bulletFontText7 = new A.BulletFontText();
            //A.NoBullet noBullet7 = new A.NoBullet();
            //A.DefaultRunProperties defaultRunProperties54 = new A.DefaultRunProperties();

            //paragraphProperties15.Append(spaceBefore35);
            //paragraphProperties15.Append(spaceAfter25);
            //paragraphProperties15.Append(bulletColor23);
            //paragraphProperties15.Append(bulletFontText7);
            //paragraphProperties15.Append(noBullet7);
            //paragraphProperties15.Append(defaultRunProperties54);

            //A.Run run14 = new A.Run();

            //A.RunProperties runProperties17 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            //A.SolidFill solidFill92 = new A.SolidFill();
            //A.SchemeColor schemeColor142 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            //solidFill92.Append(schemeColor142);
            //A.LatinFont latinFont59 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            //A.ComplexScriptFont complexScriptFont39 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            //runProperties17.Append(solidFill92);
            //runProperties17.Append(latinFont59);
            //runProperties17.Append(complexScriptFont39);
            //A.Text text17 = new A.Text();
            //text17.Text = "2017 - ";

            //run14.Append(runProperties17);
            //run14.Append(text17);

            //A.Run run15 = new A.Run();

            //A.RunProperties runProperties18 = new A.RunProperties() { Language = "lv-LV", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false, SpellingError = true };

            //A.SolidFill solidFill93 = new A.SolidFill();
            //A.SchemeColor schemeColor143 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            //solidFill93.Append(schemeColor143);
            //A.LatinFont latinFont60 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            //A.ComplexScriptFont complexScriptFont40 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            //runProperties18.Append(solidFill93);
            //runProperties18.Append(latinFont60);
            //runProperties18.Append(complexScriptFont40);
            //A.Text text18 = new A.Text();
            //text18.Text = "present";

            //run15.Append(runProperties18);
            //run15.Append(text18);

            //A.Run run16 = new A.Run();

            //A.RunProperties runProperties19 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            //A.SolidFill solidFill94 = new A.SolidFill();
            //A.SchemeColor schemeColor144 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            //solidFill94.Append(schemeColor144);
            //A.LatinFont latinFont61 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            //A.ComplexScriptFont complexScriptFont41 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            //runProperties19.Append(solidFill94);
            //runProperties19.Append(latinFont61);
            //runProperties19.Append(complexScriptFont41);
            //A.Text text19 = new A.Text();
            //text19.Text = " BANKA - Head of Baltic Private banking";

            //run16.Append(runProperties19);
            //run16.Append(text19);

            //paragraph18.Append(paragraphProperties15);
            //paragraph18.Append(run14);
            //paragraph18.Append(run15);
            //paragraph18.Append(run16);

            //A.Paragraph paragraph19 = new A.Paragraph();

            //A.ParagraphProperties paragraphProperties16 = new A.ParagraphProperties();

            //A.SpaceBefore spaceBefore36 = new A.SpaceBefore();
            //A.SpacingPoints spacingPoints11 = new A.SpacingPoints() { Val = 0 };

            //spaceBefore36.Append(spacingPoints11);

            //A.SpaceAfter spaceAfter26 = new A.SpaceAfter();
            //A.SpacingPoints spacingPoints12 = new A.SpacingPoints() { Val = 0 };

            //spaceAfter26.Append(spacingPoints12);

            //A.BulletColor bulletColor24 = new A.BulletColor();
            //A.RgbColorModelHex rgbColorModelHex213 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            //bulletColor24.Append(rgbColorModelHex213);
            //A.BulletFontText bulletFontText8 = new A.BulletFontText();
            //A.NoBullet noBullet8 = new A.NoBullet();
            //A.DefaultRunProperties defaultRunProperties55 = new A.DefaultRunProperties();

            //paragraphProperties16.Append(spaceBefore36);
            //paragraphProperties16.Append(spaceAfter26);
            //paragraphProperties16.Append(bulletColor24);
            //paragraphProperties16.Append(bulletFontText8);
            //paragraphProperties16.Append(noBullet8);
            //paragraphProperties16.Append(defaultRunProperties55);

            //A.Run run17 = new A.Run();

            //A.RunProperties runProperties20 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            //A.SolidFill solidFill95 = new A.SolidFill();
            //A.SchemeColor schemeColor145 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            //solidFill95.Append(schemeColor145);
            //A.LatinFont latinFont62 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            //A.ComplexScriptFont complexScriptFont42 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            //runProperties20.Append(solidFill95);
            //runProperties20.Append(latinFont62);
            //runProperties20.Append(complexScriptFont42);
            //A.Text text20 = new A.Text();
            //text20.Text = "2015 - 2017 BANKA - Head of Retail Baltic\'s";

            //run17.Append(runProperties20);
            //run17.Append(text20);

            //paragraph19.Append(paragraphProperties16);
            //paragraph19.Append(run17);

            //A.Paragraph paragraph20 = new A.Paragraph();

            //A.ParagraphProperties paragraphProperties17 = new A.ParagraphProperties();

            //A.SpaceBefore spaceBefore37 = new A.SpaceBefore();
            //A.SpacingPoints spacingPoints13 = new A.SpacingPoints() { Val = 0 };

            //spaceBefore37.Append(spacingPoints13);

            //A.SpaceAfter spaceAfter27 = new A.SpaceAfter();
            //A.SpacingPoints spacingPoints14 = new A.SpacingPoints() { Val = 0 };

            //spaceAfter27.Append(spacingPoints14);

            //A.BulletColor bulletColor25 = new A.BulletColor();
            //A.RgbColorModelHex rgbColorModelHex214 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            //bulletColor25.Append(rgbColorModelHex214);
            //A.BulletFontText bulletFontText9 = new A.BulletFontText();
            //A.NoBullet noBullet9 = new A.NoBullet();
            //A.DefaultRunProperties defaultRunProperties56 = new A.DefaultRunProperties();

            //paragraphProperties17.Append(spaceBefore37);
            //paragraphProperties17.Append(spaceAfter27);
            //paragraphProperties17.Append(bulletColor25);
            //paragraphProperties17.Append(bulletFontText9);
            //paragraphProperties17.Append(noBullet9);
            //paragraphProperties17.Append(defaultRunProperties56);

            //A.Run run18 = new A.Run();

            //A.RunProperties runProperties21 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            //A.SolidFill solidFill96 = new A.SolidFill();
            //A.SchemeColor schemeColor146 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            //solidFill96.Append(schemeColor146);
            //A.LatinFont latinFont63 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            //A.ComplexScriptFont complexScriptFont43 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            //runProperties21.Append(solidFill96);
            //runProperties21.Append(latinFont63);
            //runProperties21.Append(complexScriptFont43);
            //A.Text text21 = new A.Text();
            //text21.Text = "2013 - 2015 BANKA - Head of Retail Lending Division";

            //run18.Append(runProperties21);
            //run18.Append(text21);

            //paragraph20.Append(paragraphProperties17);
            //paragraph20.Append(run18);

            //A.Paragraph paragraph21 = new A.Paragraph();

            //A.ParagraphProperties paragraphProperties18 = new A.ParagraphProperties();

            //A.SpaceBefore spaceBefore38 = new A.SpaceBefore();
            //A.SpacingPoints spacingPoints15 = new A.SpacingPoints() { Val = 0 };

            //spaceBefore38.Append(spacingPoints15);

            //A.SpaceAfter spaceAfter28 = new A.SpaceAfter();
            //A.SpacingPoints spacingPoints16 = new A.SpacingPoints() { Val = 0 };

            //spaceAfter28.Append(spacingPoints16);

            //A.BulletColor bulletColor26 = new A.BulletColor();
            //A.RgbColorModelHex rgbColorModelHex215 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            //bulletColor26.Append(rgbColorModelHex215);
            //A.BulletFontText bulletFontText10 = new A.BulletFontText();
            //A.NoBullet noBullet10 = new A.NoBullet();
            //A.DefaultRunProperties defaultRunProperties57 = new A.DefaultRunProperties();

            //paragraphProperties18.Append(spaceBefore38);
            //paragraphProperties18.Append(spaceAfter28);
            //paragraphProperties18.Append(bulletColor26);
            //paragraphProperties18.Append(bulletFontText10);
            //paragraphProperties18.Append(noBullet10);
            //paragraphProperties18.Append(defaultRunProperties57);

            //A.Run run19 = new A.Run();

            //A.RunProperties runProperties22 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            //A.SolidFill solidFill97 = new A.SolidFill();
            //A.SchemeColor schemeColor147 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            //solidFill97.Append(schemeColor147);
            //A.LatinFont latinFont64 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            //A.ComplexScriptFont complexScriptFont44 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            //runProperties22.Append(solidFill97);
            //runProperties22.Append(latinFont64);
            //runProperties22.Append(complexScriptFont44);
            //A.Text text22 = new A.Text();
            //text22.Text = "2013 - 2014 BANKA - Head of Gold Service Lending Department";

            //run19.Append(runProperties22);
            //run19.Append(text22);

            //paragraph21.Append(paragraphProperties18);
            //paragraph21.Append(run19);

            //A.Paragraph paragraph22 = new A.Paragraph();

            //A.ParagraphProperties paragraphProperties19 = new A.ParagraphProperties();

            //A.SpaceBefore spaceBefore39 = new A.SpaceBefore();
            //A.SpacingPoints spacingPoints17 = new A.SpacingPoints() { Val = 0 };

            //spaceBefore39.Append(spacingPoints17);

            //A.SpaceAfter spaceAfter29 = new A.SpaceAfter();
            //A.SpacingPoints spacingPoints18 = new A.SpacingPoints() { Val = 0 };

            //spaceAfter29.Append(spacingPoints18);

            //A.BulletColor bulletColor27 = new A.BulletColor();
            //A.RgbColorModelHex rgbColorModelHex216 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            //bulletColor27.Append(rgbColorModelHex216);
            //A.BulletFontText bulletFontText11 = new A.BulletFontText();
            //A.NoBullet noBullet11 = new A.NoBullet();
            //A.DefaultRunProperties defaultRunProperties58 = new A.DefaultRunProperties();

            //paragraphProperties19.Append(spaceBefore39);
            //paragraphProperties19.Append(spaceAfter29);
            //paragraphProperties19.Append(bulletColor27);
            //paragraphProperties19.Append(bulletFontText11);
            //paragraphProperties19.Append(noBullet11);
            //paragraphProperties19.Append(defaultRunProperties58);

            //A.Run run20 = new A.Run();

            //A.RunProperties runProperties23 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            //A.SolidFill solidFill98 = new A.SolidFill();
            //A.SchemeColor schemeColor148 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            //solidFill98.Append(schemeColor148);
            //A.LatinFont latinFont65 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            //A.ComplexScriptFont complexScriptFont45 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            //runProperties23.Append(solidFill98);
            //runProperties23.Append(latinFont65);
            //runProperties23.Append(complexScriptFont45);
            //A.Text text23 = new A.Text();
            //text23.Text = "2012 - 2015 ASSOCIATION OF COMMERCIAL BANKS OF LATVIA - Chairman of Mortgage Committee";

            //run20.Append(runProperties23);
            //run20.Append(text23);

            //paragraph22.Append(paragraphProperties19);
            //paragraph22.Append(run20);

            //A.Paragraph paragraph23 = new A.Paragraph();

            //A.ParagraphProperties paragraphProperties20 = new A.ParagraphProperties();

            //A.SpaceBefore spaceBefore40 = new A.SpaceBefore();
            //A.SpacingPoints spacingPoints19 = new A.SpacingPoints() { Val = 0 };

            //spaceBefore40.Append(spacingPoints19);

            //A.SpaceAfter spaceAfter30 = new A.SpaceAfter();
            //A.SpacingPoints spacingPoints20 = new A.SpacingPoints() { Val = 0 };

            //spaceAfter30.Append(spacingPoints20);

            //A.BulletColor bulletColor28 = new A.BulletColor();
            //A.RgbColorModelHex rgbColorModelHex217 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            //bulletColor28.Append(rgbColorModelHex217);
            //A.BulletFontText bulletFontText12 = new A.BulletFontText();
            //A.NoBullet noBullet12 = new A.NoBullet();
            //A.DefaultRunProperties defaultRunProperties59 = new A.DefaultRunProperties();

            //paragraphProperties20.Append(spaceBefore40);
            //paragraphProperties20.Append(spaceAfter30);
            //paragraphProperties20.Append(bulletColor28);
            //paragraphProperties20.Append(bulletFontText12);
            //paragraphProperties20.Append(noBullet12);
            //paragraphProperties20.Append(defaultRunProperties59);

            //A.Run run21 = new A.Run();

            //A.RunProperties runProperties24 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            //A.SolidFill solidFill99 = new A.SolidFill();
            //A.SchemeColor schemeColor149 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            //solidFill99.Append(schemeColor149);
            //A.LatinFont latinFont66 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            //A.ComplexScriptFont complexScriptFont46 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            //runProperties24.Append(solidFill99);
            //runProperties24.Append(latinFont66);
            //runProperties24.Append(complexScriptFont46);
            //A.Text text24 = new A.Text();
            //text24.Text = "2011 - 2013 BANKA - Head of Mortgage and SMEs Lending Division";

            //run21.Append(runProperties24);
            //run21.Append(text24);

            //paragraph23.Append(paragraphProperties20);
            //paragraph23.Append(run21);

            //A.Paragraph paragraph24 = new A.Paragraph();

            //A.ParagraphProperties paragraphProperties21 = new A.ParagraphProperties();

            //A.SpaceBefore spaceBefore41 = new A.SpaceBefore();
            //A.SpacingPoints spacingPoints21 = new A.SpacingPoints() { Val = 0 };

            //spaceBefore41.Append(spacingPoints21);

            //A.SpaceAfter spaceAfter31 = new A.SpaceAfter();
            //A.SpacingPoints spacingPoints22 = new A.SpacingPoints() { Val = 0 };

            //spaceAfter31.Append(spacingPoints22);

            //A.BulletColor bulletColor29 = new A.BulletColor();
            //A.RgbColorModelHex rgbColorModelHex218 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            //bulletColor29.Append(rgbColorModelHex218);
            //A.BulletFontText bulletFontText13 = new A.BulletFontText();
            //A.NoBullet noBullet13 = new A.NoBullet();
            //A.DefaultRunProperties defaultRunProperties60 = new A.DefaultRunProperties();

            //paragraphProperties21.Append(spaceBefore41);
            //paragraphProperties21.Append(spaceAfter31);
            //paragraphProperties21.Append(bulletColor29);
            //paragraphProperties21.Append(bulletFontText13);
            //paragraphProperties21.Append(noBullet13);
            //paragraphProperties21.Append(defaultRunProperties60);

            //A.Run run22 = new A.Run();

            //A.RunProperties runProperties25 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            //A.SolidFill solidFill100 = new A.SolidFill();
            //A.SchemeColor schemeColor150 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            //solidFill100.Append(schemeColor150);
            //A.LatinFont latinFont67 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            //A.ComplexScriptFont complexScriptFont47 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            //runProperties25.Append(solidFill100);
            //runProperties25.Append(latinFont67);
            //runProperties25.Append(complexScriptFont47);
            //A.Text text25 = new A.Text();
            //text25.Text = "2009 - 2011 BANKA - Head of Riga Lending Department";

            //run22.Append(runProperties25);
            //run22.Append(text25);

            //paragraph24.Append(paragraphProperties21);
            //paragraph24.Append(run22);

            //A.Paragraph paragraph25 = new A.Paragraph();

            //A.ParagraphProperties paragraphProperties22 = new A.ParagraphProperties();

            //A.SpaceBefore spaceBefore42 = new A.SpaceBefore();
            //A.SpacingPoints spacingPoints23 = new A.SpacingPoints() { Val = 0 };

            //spaceBefore42.Append(spacingPoints23);

            //A.SpaceAfter spaceAfter32 = new A.SpaceAfter();
            //A.SpacingPoints spacingPoints24 = new A.SpacingPoints() { Val = 0 };

            //spaceAfter32.Append(spacingPoints24);

            //A.BulletColor bulletColor30 = new A.BulletColor();
            //A.RgbColorModelHex rgbColorModelHex219 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            //bulletColor30.Append(rgbColorModelHex219);
            //A.BulletFontText bulletFontText14 = new A.BulletFontText();
            //A.NoBullet noBullet14 = new A.NoBullet();
            //A.DefaultRunProperties defaultRunProperties61 = new A.DefaultRunProperties();

            //paragraphProperties22.Append(spaceBefore42);
            //paragraphProperties22.Append(spaceAfter32);
            //paragraphProperties22.Append(bulletColor30);
            //paragraphProperties22.Append(bulletFontText14);
            //paragraphProperties22.Append(noBullet14);
            //paragraphProperties22.Append(defaultRunProperties61);

            //A.Run run23 = new A.Run();

            //A.RunProperties runProperties26 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            //A.SolidFill solidFill101 = new A.SolidFill();
            //A.SchemeColor schemeColor151 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            //solidFill101.Append(schemeColor151);
            //A.LatinFont latinFont68 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            //A.ComplexScriptFont complexScriptFont48 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            //runProperties26.Append(solidFill101);
            //runProperties26.Append(latinFont68);
            //runProperties26.Append(complexScriptFont48);
            //A.Text text26 = new A.Text();
            //text26.Text = "2008 - 2009 BANK";

            //run23.Append(runProperties26);
            //run23.Append(text26);

            //A.Run run24 = new A.Run();

            //A.RunProperties runProperties27 = new A.RunProperties() { Language = "lv-LV", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            //A.SolidFill solidFill102 = new A.SolidFill();
            //A.SchemeColor schemeColor152 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            //solidFill102.Append(schemeColor152);
            //A.LatinFont latinFont69 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            //A.ComplexScriptFont complexScriptFont49 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            //runProperties27.Append(solidFill102);
            //runProperties27.Append(latinFont69);
            //runProperties27.Append(complexScriptFont49);
            //A.Text text27 = new A.Text();
            //text27.Text = "A";

            //run24.Append(runProperties27);
            //run24.Append(text27);

            //A.Run run25 = new A.Run();

            //A.RunProperties runProperties28 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            //A.SolidFill solidFill103 = new A.SolidFill();
            //A.SchemeColor schemeColor153 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            //solidFill103.Append(schemeColor153);
            //A.LatinFont latinFont70 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            //A.ComplexScriptFont complexScriptFont50 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            //runProperties28.Append(solidFill103);
            //runProperties28.Append(latinFont70);
            //runProperties28.Append(complexScriptFont50);
            //A.Text text28 = new A.Text();
            //text28.Text = " - Head of Mortgage Lending Department in a Branch";

            //run25.Append(runProperties28);
            //run25.Append(text28);

            //A.EndParagraphRunProperties endParagraphRunProperties12 = new A.EndParagraphRunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            //A.SolidFill solidFill104 = new A.SolidFill();
            //A.SchemeColor schemeColor154 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            //solidFill104.Append(schemeColor154);
            //A.LatinFont latinFont71 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            //A.ComplexScriptFont complexScriptFont51 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            //endParagraphRunProperties12.Append(solidFill104);
            //endParagraphRunProperties12.Append(latinFont71);
            //endParagraphRunProperties12.Append(complexScriptFont51);

            //paragraph25.Append(paragraphProperties22);
            //paragraph25.Append(run23);
            //paragraph25.Append(run24);
            //paragraph25.Append(run25);
            //paragraph25.Append(endParagraphRunProperties12);

            textBody11.Append(bodyProperties13);
            textBody11.Append(listStyle13);
            textBody11.Append(paragraph17);

            foreach (var item in data.Experience)
            {
                textBody11.Append(CreateExperienceParagraph(item));
            }

            shape12.Append(nonVisualShapeProperties12);
            shape12.Append(shapeProperties14);
            shape12.Append(textBody11);

            Shape shape13 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties13 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties16 = new NonVisualDrawingProperties() { Id = (UInt32Value)6148U, Name = "Rectangle 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties13 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks13 = new A.ShapeLocks() { NoChangeArrowheads = true };

            nonVisualShapeDrawingProperties13.Append(shapeLocks13);
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties16 = new ApplicationNonVisualDrawingProperties();

            nonVisualShapeProperties13.Append(nonVisualDrawingProperties16);
            nonVisualShapeProperties13.Append(nonVisualShapeDrawingProperties13);
            nonVisualShapeProperties13.Append(applicationNonVisualDrawingProperties16);

            ShapeProperties shapeProperties15 = new ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D15 = new A.Transform2D();
            A.Offset offset18 = new A.Offset() { X = 533400L, Y = 1905000L };
            A.Extents extents18 = new A.Extents() { Cx = 3808917L, Cy = 1981200L };

            transform2D15.Append(offset18);
            transform2D15.Append(extents18);

            A.PresetGeometry presetGeometry13 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList22 = new A.AdjustValueList();

            presetGeometry13.Append(adjustValueList22);

            A.SolidFill solidFill105 = new A.SolidFill();
            A.SchemeColor schemeColor155 = new A.SchemeColor() { Val = A.SchemeColorValues.FollowedHyperlink };

            solidFill105.Append(schemeColor155);

            A.Outline outline30 = new A.Outline();
            A.NoFill noFill16 = new A.NoFill();

            outline30.Append(noFill16);

            A.ShapePropertiesExtensionList shapePropertiesExtensionList4 = new A.ShapePropertiesExtensionList();

            A.ShapePropertiesExtension shapePropertiesExtension4 = new A.ShapePropertiesExtension() { Uri = "{91240B29-F687-4F45-9708-019B960494DF}" };

            A14.HiddenLineProperties hiddenLineProperties3 = new A14.HiddenLineProperties() { Width = 9525 };
            hiddenLineProperties3.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill106 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex220 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill106.Append(rgbColorModelHex220);
            A.Miter miter12 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd11 = new A.HeadEnd();
            A.TailEnd tailEnd11 = new A.TailEnd();

            hiddenLineProperties3.Append(solidFill106);
            hiddenLineProperties3.Append(miter12);
            hiddenLineProperties3.Append(headEnd11);
            hiddenLineProperties3.Append(tailEnd11);

            shapePropertiesExtension4.Append(hiddenLineProperties3);

            shapePropertiesExtensionList4.Append(shapePropertiesExtension4);

            shapeProperties15.Append(transform2D15);
            shapeProperties15.Append(presetGeometry13);
            shapeProperties15.Append(solidFill105);
            shapeProperties15.Append(outline30);
            shapeProperties15.Append(shapePropertiesExtensionList4);

            TextBody textBody12 = new TextBody();
            A.BodyProperties bodyProperties14 = new A.BodyProperties() { LeftInset = 108000, TopInset = 108000, RightInset = 108000, BottomInset = 108000 };

            A.ListStyle listStyle14 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties13 = new A.Level1ParagraphProperties();

            A.SpaceBefore spaceBefore43 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent53 = new A.SpacingPercent() { Val = 50000 };

            spaceBefore43.Append(spacingPercent53);

            A.BulletColor bulletColor31 = new A.BulletColor();
            A.SchemeColor schemeColor156 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor31.Append(schemeColor156);
            A.BulletFont bulletFont7 = new A.BulletFont() { Typeface = "Wingdings", PitchFamily = 2, CharacterSet = 2 };

            A.DefaultRunProperties defaultRunProperties62 = new A.DefaultRunProperties();

            A.SolidFill solidFill107 = new A.SolidFill();
            A.SchemeColor schemeColor157 = new A.SchemeColor() { Val = A.SchemeColorValues.Background2 };

            solidFill107.Append(schemeColor157);
            A.LatinFont latinFont72 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont48 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties62.Append(solidFill107);
            defaultRunProperties62.Append(latinFont72);
            defaultRunProperties62.Append(eastAsianFont48);

            level1ParagraphProperties13.Append(spaceBefore43);
            level1ParagraphProperties13.Append(bulletColor31);
            level1ParagraphProperties13.Append(bulletFont7);
            level1ParagraphProperties13.Append(defaultRunProperties62);

            A.Level2ParagraphProperties level2ParagraphProperties5 = new A.Level2ParagraphProperties() { LeftMargin = 742950, Indent = -285750 };

            A.SpaceBefore spaceBefore44 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent54 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore44.Append(spacingPercent54);

            A.BulletColor bulletColor32 = new A.BulletColor();
            A.SchemeColor schemeColor158 = new A.SchemeColor() { Val = A.SchemeColorValues.Background2 };

            bulletColor32.Append(schemeColor158);
            A.BulletFont bulletFont8 = new A.BulletFont() { Typeface = "Times", PitchFamily = 18, CharacterSet = 0 };
            A.CharacterBullet characterBullet3 = new A.CharacterBullet() { Char = "•" };

            A.DefaultRunProperties defaultRunProperties63 = new A.DefaultRunProperties();

            A.SolidFill solidFill108 = new A.SolidFill();
            A.SchemeColor schemeColor159 = new A.SchemeColor() { Val = A.SchemeColorValues.Background2 };

            solidFill108.Append(schemeColor159);
            A.LatinFont latinFont73 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont49 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties63.Append(solidFill108);
            defaultRunProperties63.Append(latinFont73);
            defaultRunProperties63.Append(eastAsianFont49);

            level2ParagraphProperties5.Append(spaceBefore44);
            level2ParagraphProperties5.Append(bulletColor32);
            level2ParagraphProperties5.Append(bulletFont8);
            level2ParagraphProperties5.Append(characterBullet3);
            level2ParagraphProperties5.Append(defaultRunProperties63);

            A.Level3ParagraphProperties level3ParagraphProperties5 = new A.Level3ParagraphProperties() { LeftMargin = 1143000, Indent = -228600 };

            A.SpaceBefore spaceBefore45 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent55 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore45.Append(spacingPercent55);

            A.BulletColor bulletColor33 = new A.BulletColor();
            A.SchemeColor schemeColor160 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor33.Append(schemeColor160);

            A.DefaultRunProperties defaultRunProperties64 = new A.DefaultRunProperties();

            A.SolidFill solidFill109 = new A.SolidFill();
            A.SchemeColor schemeColor161 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill109.Append(schemeColor161);
            A.LatinFont latinFont74 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont50 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties64.Append(solidFill109);
            defaultRunProperties64.Append(latinFont74);
            defaultRunProperties64.Append(eastAsianFont50);

            level3ParagraphProperties5.Append(spaceBefore45);
            level3ParagraphProperties5.Append(bulletColor33);
            level3ParagraphProperties5.Append(defaultRunProperties64);

            A.Level4ParagraphProperties level4ParagraphProperties5 = new A.Level4ParagraphProperties() { LeftMargin = 1600200, Indent = -228600 };

            A.SpaceBefore spaceBefore46 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent56 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore46.Append(spacingPercent56);

            A.BulletColor bulletColor34 = new A.BulletColor();
            A.SchemeColor schemeColor162 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor34.Append(schemeColor162);
            A.BulletFont bulletFont9 = new A.BulletFont() { Typeface = "Wingdings", PitchFamily = 2, CharacterSet = 2 };

            A.DefaultRunProperties defaultRunProperties65 = new A.DefaultRunProperties();

            A.SolidFill solidFill110 = new A.SolidFill();
            A.SchemeColor schemeColor163 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill110.Append(schemeColor163);
            A.LatinFont latinFont75 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont51 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties65.Append(solidFill110);
            defaultRunProperties65.Append(latinFont75);
            defaultRunProperties65.Append(eastAsianFont51);

            level4ParagraphProperties5.Append(spaceBefore46);
            level4ParagraphProperties5.Append(bulletColor34);
            level4ParagraphProperties5.Append(bulletFont9);
            level4ParagraphProperties5.Append(defaultRunProperties65);

            A.Level5ParagraphProperties level5ParagraphProperties5 = new A.Level5ParagraphProperties() { LeftMargin = 2057400, Indent = -228600 };

            A.SpaceBefore spaceBefore47 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent57 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore47.Append(spacingPercent57);

            A.BulletColor bulletColor35 = new A.BulletColor();
            A.SchemeColor schemeColor164 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor35.Append(schemeColor164);

            A.DefaultRunProperties defaultRunProperties66 = new A.DefaultRunProperties();

            A.SolidFill solidFill111 = new A.SolidFill();
            A.SchemeColor schemeColor165 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill111.Append(schemeColor165);
            A.LatinFont latinFont76 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont52 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties66.Append(solidFill111);
            defaultRunProperties66.Append(latinFont76);
            defaultRunProperties66.Append(eastAsianFont52);

            level5ParagraphProperties5.Append(spaceBefore47);
            level5ParagraphProperties5.Append(bulletColor35);
            level5ParagraphProperties5.Append(defaultRunProperties66);

            A.Level6ParagraphProperties level6ParagraphProperties5 = new A.Level6ParagraphProperties() { LeftMargin = 2514600, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore48 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent58 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore48.Append(spacingPercent58);

            A.SpaceAfter spaceAfter33 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent59 = new A.SpacingPercent() { Val = 0 };

            spaceAfter33.Append(spacingPercent59);

            A.BulletColor bulletColor36 = new A.BulletColor();
            A.SchemeColor schemeColor166 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor36.Append(schemeColor166);

            A.DefaultRunProperties defaultRunProperties67 = new A.DefaultRunProperties();

            A.SolidFill solidFill112 = new A.SolidFill();
            A.SchemeColor schemeColor167 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill112.Append(schemeColor167);
            A.LatinFont latinFont77 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont53 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties67.Append(solidFill112);
            defaultRunProperties67.Append(latinFont77);
            defaultRunProperties67.Append(eastAsianFont53);

            level6ParagraphProperties5.Append(spaceBefore48);
            level6ParagraphProperties5.Append(spaceAfter33);
            level6ParagraphProperties5.Append(bulletColor36);
            level6ParagraphProperties5.Append(defaultRunProperties67);

            A.Level7ParagraphProperties level7ParagraphProperties5 = new A.Level7ParagraphProperties() { LeftMargin = 2971800, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore49 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent60 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore49.Append(spacingPercent60);

            A.SpaceAfter spaceAfter34 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent61 = new A.SpacingPercent() { Val = 0 };

            spaceAfter34.Append(spacingPercent61);

            A.BulletColor bulletColor37 = new A.BulletColor();
            A.SchemeColor schemeColor168 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor37.Append(schemeColor168);

            A.DefaultRunProperties defaultRunProperties68 = new A.DefaultRunProperties();

            A.SolidFill solidFill113 = new A.SolidFill();
            A.SchemeColor schemeColor169 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill113.Append(schemeColor169);
            A.LatinFont latinFont78 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont54 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties68.Append(solidFill113);
            defaultRunProperties68.Append(latinFont78);
            defaultRunProperties68.Append(eastAsianFont54);

            level7ParagraphProperties5.Append(spaceBefore49);
            level7ParagraphProperties5.Append(spaceAfter34);
            level7ParagraphProperties5.Append(bulletColor37);
            level7ParagraphProperties5.Append(defaultRunProperties68);

            A.Level8ParagraphProperties level8ParagraphProperties5 = new A.Level8ParagraphProperties() { LeftMargin = 3429000, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore50 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent62 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore50.Append(spacingPercent62);

            A.SpaceAfter spaceAfter35 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent63 = new A.SpacingPercent() { Val = 0 };

            spaceAfter35.Append(spacingPercent63);

            A.BulletColor bulletColor38 = new A.BulletColor();
            A.SchemeColor schemeColor170 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor38.Append(schemeColor170);

            A.DefaultRunProperties defaultRunProperties69 = new A.DefaultRunProperties();

            A.SolidFill solidFill114 = new A.SolidFill();
            A.SchemeColor schemeColor171 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill114.Append(schemeColor171);
            A.LatinFont latinFont79 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont55 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties69.Append(solidFill114);
            defaultRunProperties69.Append(latinFont79);
            defaultRunProperties69.Append(eastAsianFont55);

            level8ParagraphProperties5.Append(spaceBefore50);
            level8ParagraphProperties5.Append(spaceAfter35);
            level8ParagraphProperties5.Append(bulletColor38);
            level8ParagraphProperties5.Append(defaultRunProperties69);

            A.Level9ParagraphProperties level9ParagraphProperties5 = new A.Level9ParagraphProperties() { LeftMargin = 3886200, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore51 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent64 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore51.Append(spacingPercent64);

            A.SpaceAfter spaceAfter36 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent65 = new A.SpacingPercent() { Val = 0 };

            spaceAfter36.Append(spacingPercent65);

            A.BulletColor bulletColor39 = new A.BulletColor();
            A.SchemeColor schemeColor172 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor39.Append(schemeColor172);

            A.DefaultRunProperties defaultRunProperties70 = new A.DefaultRunProperties();

            A.SolidFill solidFill115 = new A.SolidFill();
            A.SchemeColor schemeColor173 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill115.Append(schemeColor173);
            A.LatinFont latinFont80 = new A.LatinFont() { Typeface = "Bliss Pro Regular" };
            A.EastAsianFont eastAsianFont56 = new A.EastAsianFont() { Typeface = "MS PGothic", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties70.Append(solidFill115);
            defaultRunProperties70.Append(latinFont80);
            defaultRunProperties70.Append(eastAsianFont56);

            level9ParagraphProperties5.Append(spaceBefore51);
            level9ParagraphProperties5.Append(spaceAfter36);
            level9ParagraphProperties5.Append(bulletColor39);
            level9ParagraphProperties5.Append(defaultRunProperties70);

            listStyle14.Append(level1ParagraphProperties13);
            listStyle14.Append(level2ParagraphProperties5);
            listStyle14.Append(level3ParagraphProperties5);
            listStyle14.Append(level4ParagraphProperties5);
            listStyle14.Append(level5ParagraphProperties5);
            listStyle14.Append(level6ParagraphProperties5);
            listStyle14.Append(level7ParagraphProperties5);
            listStyle14.Append(level8ParagraphProperties5);
            listStyle14.Append(level9ParagraphProperties5);

            A.Paragraph paragraph26 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties23 = new A.ParagraphProperties();

            A.SpaceBefore spaceBefore52 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints25 = new A.SpacingPoints() { Val = 600 };

            spaceBefore52.Append(spacingPoints25);

            A.SpaceAfter spaceAfter37 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints26 = new A.SpacingPoints() { Val = 600 };

            spaceAfter37.Append(spacingPoints26);

            A.BulletColor bulletColor40 = new A.BulletColor();
            A.RgbColorModelHex rgbColorModelHex221 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            bulletColor40.Append(rgbColorModelHex221);
            A.DefaultRunProperties defaultRunProperties71 = new A.DefaultRunProperties();

            paragraphProperties23.Append(spaceBefore52);
            paragraphProperties23.Append(spaceAfter37);
            paragraphProperties23.Append(bulletColor40);
            paragraphProperties23.Append(defaultRunProperties71);

            A.Run run26 = new A.Run();

            A.RunProperties runProperties29 = new A.RunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1400, Bold = true, Dirty = false };

            A.SolidFill solidFill116 = new A.SolidFill();
            A.SchemeColor schemeColor174 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill116.Append(schemeColor174);
            A.LatinFont latinFont81 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.ComplexScriptFont complexScriptFont52 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            runProperties29.Append(solidFill116);
            runProperties29.Append(latinFont81);
            runProperties29.Append(complexScriptFont52);
            A.Text text29 = new A.Text();
            text29.Text = $"{PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.EDUCATION, data.Language)}"; 

            run26.Append(runProperties29);
            run26.Append(text29);

            paragraph26.Append(paragraphProperties23);
            paragraph26.Append(run26);

            //A.Paragraph paragraph27 = new A.Paragraph();

            //A.ParagraphProperties paragraphProperties24 = new A.ParagraphProperties();

            //A.SpaceBefore spaceBefore53 = new A.SpaceBefore();
            //A.SpacingPercent spacingPercent66 = new A.SpacingPercent() { Val = 0 };

            //spaceBefore53.Append(spacingPercent66);

            //A.SpaceAfter spaceAfter38 = new A.SpaceAfter();
            //A.SpacingPoints spacingPoints27 = new A.SpacingPoints() { Val = 600 };

            //spaceAfter38.Append(spacingPoints27);

            //A.BulletColor bulletColor41 = new A.BulletColor();
            //A.RgbColorModelHex rgbColorModelHex222 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            //bulletColor41.Append(rgbColorModelHex222);
            //A.DefaultRunProperties defaultRunProperties72 = new A.DefaultRunProperties();

            //paragraphProperties24.Append(spaceBefore53);
            //paragraphProperties24.Append(spaceAfter38);
            //paragraphProperties24.Append(bulletColor41);
            //paragraphProperties24.Append(defaultRunProperties72);

            //A.Run run27 = new A.Run();

            //A.RunProperties runProperties30 = new A.RunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1050, Bold = true, Dirty = false };

            //A.SolidFill solidFill117 = new A.SolidFill();
            //A.SchemeColor schemeColor175 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            //solidFill117.Append(schemeColor175);
            //A.LatinFont latinFont82 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            //A.ComplexScriptFont complexScriptFont53 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            //runProperties30.Append(solidFill117);
            //runProperties30.Append(latinFont82);
            //runProperties30.Append(complexScriptFont53);
            //A.Text text30 = new A.Text();
            //text30.Text = "2006 BA School of Business and Finance ";

            //run27.Append(runProperties30);
            //run27.Append(text30);

            //A.Run run28 = new A.Run();

            //A.RunProperties runProperties31 = new A.RunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            //A.SolidFill solidFill118 = new A.SolidFill();
            //A.SchemeColor schemeColor176 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            //solidFill118.Append(schemeColor176);
            //A.LatinFont latinFont83 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            //A.ComplexScriptFont complexScriptFont54 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            //runProperties31.Append(solidFill118);
            //runProperties31.Append(latinFont83);
            //runProperties31.Append(complexScriptFont54);
            //A.Text text31 = new A.Text();
            //text31.Text = "- Bachelor’s degree, Business Administration, Entrepreneurship";

            //run28.Append(runProperties31);
            //run28.Append(text31);

            //paragraph27.Append(paragraphProperties24);
            //paragraph27.Append(run27);
            //paragraph27.Append(run28);

            A.Paragraph paragraph28 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties25 = new A.ParagraphProperties();

            A.SpaceBefore spaceBefore54 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent67 = new A.SpacingPercent() { Val = 0 };

            spaceBefore54.Append(spacingPercent67);

            A.SpaceAfter spaceAfter39 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints28 = new A.SpacingPoints() { Val = 600 };

            spaceAfter39.Append(spacingPoints28);

            A.BulletColor bulletColor42 = new A.BulletColor();
            A.RgbColorModelHex rgbColorModelHex223 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            bulletColor42.Append(rgbColorModelHex223);
            A.DefaultRunProperties defaultRunProperties73 = new A.DefaultRunProperties();

            paragraphProperties25.Append(spaceBefore54);
            paragraphProperties25.Append(spaceAfter39);
            paragraphProperties25.Append(bulletColor42);
            paragraphProperties25.Append(defaultRunProperties73);

            A.EndParagraphRunProperties endParagraphRunProperties13 = new A.EndParagraphRunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill119 = new A.SolidFill();
            A.SchemeColor schemeColor177 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill119.Append(schemeColor177);
            A.LatinFont latinFont84 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.ComplexScriptFont complexScriptFont55 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            endParagraphRunProperties13.Append(solidFill119);
            endParagraphRunProperties13.Append(latinFont84);
            endParagraphRunProperties13.Append(complexScriptFont55);

            paragraph28.Append(paragraphProperties25);
            paragraph28.Append(endParagraphRunProperties13);

            A.Paragraph paragraph29 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties26 = new A.ParagraphProperties();

            A.SpaceBefore spaceBefore55 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent68 = new A.SpacingPercent() { Val = 0 };

            spaceBefore55.Append(spacingPercent68);

            A.SpaceAfter spaceAfter40 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints29 = new A.SpacingPoints() { Val = 600 };

            spaceAfter40.Append(spacingPoints29);

            A.BulletColor bulletColor43 = new A.BulletColor();
            A.RgbColorModelHex rgbColorModelHex224 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            bulletColor43.Append(rgbColorModelHex224);
            A.DefaultRunProperties defaultRunProperties74 = new A.DefaultRunProperties();

            paragraphProperties26.Append(spaceBefore55);
            paragraphProperties26.Append(spaceAfter40);
            paragraphProperties26.Append(bulletColor43);
            paragraphProperties26.Append(defaultRunProperties74);

            A.EndParagraphRunProperties endParagraphRunProperties14 = new A.EndParagraphRunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill120 = new A.SolidFill();
            A.SchemeColor schemeColor178 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill120.Append(schemeColor178);
            A.LatinFont latinFont85 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.ComplexScriptFont complexScriptFont56 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            endParagraphRunProperties14.Append(solidFill120);
            endParagraphRunProperties14.Append(latinFont85);
            endParagraphRunProperties14.Append(complexScriptFont56);

            paragraph29.Append(paragraphProperties26);
            paragraph29.Append(endParagraphRunProperties14);

            A.Paragraph paragraph30 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties27 = new A.ParagraphProperties();

            A.SpaceBefore spaceBefore56 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent69 = new A.SpacingPercent() { Val = 0 };

            spaceBefore56.Append(spacingPercent69);

            A.SpaceAfter spaceAfter41 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints30 = new A.SpacingPoints() { Val = 600 };

            spaceAfter41.Append(spacingPoints30);

            A.BulletColor bulletColor44 = new A.BulletColor();
            A.RgbColorModelHex rgbColorModelHex225 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            bulletColor44.Append(rgbColorModelHex225);
            A.DefaultRunProperties defaultRunProperties75 = new A.DefaultRunProperties();

            paragraphProperties27.Append(spaceBefore56);
            paragraphProperties27.Append(spaceAfter41);
            paragraphProperties27.Append(bulletColor44);
            paragraphProperties27.Append(defaultRunProperties75);

            A.EndParagraphRunProperties endParagraphRunProperties15 = new A.EndParagraphRunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill121 = new A.SolidFill();
            A.SchemeColor schemeColor179 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill121.Append(schemeColor179);
            A.LatinFont latinFont86 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.ComplexScriptFont complexScriptFont57 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            endParagraphRunProperties15.Append(solidFill121);
            endParagraphRunProperties15.Append(latinFont86);
            endParagraphRunProperties15.Append(complexScriptFont57);

            paragraph30.Append(paragraphProperties27);
            paragraph30.Append(endParagraphRunProperties15);

            A.Paragraph paragraph31 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties28 = new A.ParagraphProperties();

            A.SpaceBefore spaceBefore57 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent70 = new A.SpacingPercent() { Val = 0 };

            spaceBefore57.Append(spacingPercent70);

            A.SpaceAfter spaceAfter42 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints31 = new A.SpacingPoints() { Val = 600 };

            spaceAfter42.Append(spacingPoints31);

            A.BulletColor bulletColor45 = new A.BulletColor();
            A.RgbColorModelHex rgbColorModelHex226 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            bulletColor45.Append(rgbColorModelHex226);
            A.DefaultRunProperties defaultRunProperties76 = new A.DefaultRunProperties();

            paragraphProperties28.Append(spaceBefore57);
            paragraphProperties28.Append(spaceAfter42);
            paragraphProperties28.Append(bulletColor45);
            paragraphProperties28.Append(defaultRunProperties76);

            A.Run run29 = new A.Run();

            A.RunProperties runProperties32 = new A.RunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1050, Bold = true, Dirty = false };

            A.SolidFill solidFill122 = new A.SolidFill();
            A.SchemeColor schemeColor180 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill122.Append(schemeColor180);
            A.LatinFont latinFont87 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.ComplexScriptFont complexScriptFont58 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            runProperties32.Append(solidFill122);
            runProperties32.Append(latinFont87);
            runProperties32.Append(complexScriptFont58);
            A.Text text32 = new A.Text();
            text32.Text = $"{PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.STRENGTHS, data.Language)}: ";

            run29.Append(runProperties32);
            run29.Append(text32);

            A.Run run30 = new A.Run();

            A.RunProperties runProperties33 = new A.RunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill123 = new A.SolidFill();
            A.SchemeColor schemeColor181 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill123.Append(schemeColor181);
            A.LatinFont latinFont88 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.ComplexScriptFont complexScriptFont59 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            runProperties33.Append(solidFill123);
            runProperties33.Append(latinFont88);
            runProperties33.Append(complexScriptFont59);

            A.Text text33 = new A.Text();
            text33.Text = GetLanguages(data);

            run30.Append(runProperties33);
            run30.Append(text33);

            paragraph31.Append(paragraphProperties28);
            paragraph31.Append(run29);
            paragraph31.Append(run30);

            textBody12.Append(bodyProperties14);
            textBody12.Append(listStyle14);
            textBody12.Append(paragraph26);

            foreach (var item in data.Education)
            {
                textBody12.Append(CreateEducationParagraph(item));
            }
            
            textBody12.Append(paragraph28);
            textBody12.Append(paragraph29);
            textBody12.Append(paragraph30);
            textBody12.Append(paragraph31);

            shape13.Append(nonVisualShapeProperties13);
            shape13.Append(shapeProperties15);
            shape13.Append(textBody12);

            Shape shape14 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties14 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties17 = new NonVisualDrawingProperties() { Id = (UInt32Value)18437U, Name = "Rectangle 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties14 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks14 = new A.ShapeLocks() { NoChangeArrowheads = true };

            nonVisualShapeDrawingProperties14.Append(shapeLocks14);
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties17 = new ApplicationNonVisualDrawingProperties();

            nonVisualShapeProperties14.Append(nonVisualDrawingProperties17);
            nonVisualShapeProperties14.Append(nonVisualShapeDrawingProperties14);
            nonVisualShapeProperties14.Append(applicationNonVisualDrawingProperties17);

            ShapeProperties shapeProperties16 = new ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D16 = new A.Transform2D();
            A.Offset offset19 = new A.Offset() { X = 533400L, Y = 3962400L };
            A.Extents extents19 = new A.Extents() { Cx = 3808917L, Cy = 1828800L };

            transform2D16.Append(offset19);
            transform2D16.Append(extents19);

            A.PresetGeometry presetGeometry14 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList23 = new A.AdjustValueList();

            presetGeometry14.Append(adjustValueList23);

            A.SolidFill solidFill124 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex227 = new A.RgbColorModelHex() { Val = "BF1E2D" };

            solidFill124.Append(rgbColorModelHex227);

            A.Outline outline31 = new A.Outline();
            A.NoFill noFill17 = new A.NoFill();

            outline31.Append(noFill17);

            A.ShapePropertiesExtensionList shapePropertiesExtensionList5 = new A.ShapePropertiesExtensionList();

            A.ShapePropertiesExtension shapePropertiesExtension5 = new A.ShapePropertiesExtension() { Uri = "{91240B29-F687-4F45-9708-019B960494DF}" };

            A14.HiddenLineProperties hiddenLineProperties4 = new A14.HiddenLineProperties() { Width = 9525 };
            hiddenLineProperties4.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill125 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex228 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill125.Append(rgbColorModelHex228);
            A.Miter miter13 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd12 = new A.HeadEnd();
            A.TailEnd tailEnd12 = new A.TailEnd();

            hiddenLineProperties4.Append(solidFill125);
            hiddenLineProperties4.Append(miter13);
            hiddenLineProperties4.Append(headEnd12);
            hiddenLineProperties4.Append(tailEnd12);

            shapePropertiesExtension5.Append(hiddenLineProperties4);

            shapePropertiesExtensionList5.Append(shapePropertiesExtension5);

            shapeProperties16.Append(transform2D16);
            shapeProperties16.Append(presetGeometry14);
            shapeProperties16.Append(solidFill124);
            shapeProperties16.Append(outline31);
            shapeProperties16.Append(shapePropertiesExtensionList5);

            TextBody textBody13 = new TextBody();
            A.BodyProperties bodyProperties15 = new A.BodyProperties() { LeftInset = 108000, TopInset = 108000, RightInset = 108000, BottomInset = 108000 };

            A.ListStyle listStyle15 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties14 = new A.Level1ParagraphProperties();

            A.SpaceBefore spaceBefore58 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent71 = new A.SpacingPercent() { Val = 50000 };

            spaceBefore58.Append(spacingPercent71);

            A.BulletColor bulletColor46 = new A.BulletColor();
            A.SchemeColor schemeColor182 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor46.Append(schemeColor182);
            A.BulletFont bulletFont10 = new A.BulletFont() { Typeface = "Wingdings", Panose = "05000000000000000000", PitchFamily = 2, CharacterSet = 2 };

            A.DefaultRunProperties defaultRunProperties77 = new A.DefaultRunProperties();

            A.SolidFill solidFill126 = new A.SolidFill();
            A.SchemeColor schemeColor183 = new A.SchemeColor() { Val = A.SchemeColorValues.Background2 };

            solidFill126.Append(schemeColor183);
            A.LatinFont latinFont89 = new A.LatinFont() { Typeface = "Bliss Pro Regular", Panose = "02010006030000020004", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont57 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties77.Append(solidFill126);
            defaultRunProperties77.Append(latinFont89);
            defaultRunProperties77.Append(eastAsianFont57);

            level1ParagraphProperties14.Append(spaceBefore58);
            level1ParagraphProperties14.Append(bulletColor46);
            level1ParagraphProperties14.Append(bulletFont10);
            level1ParagraphProperties14.Append(defaultRunProperties77);

            A.Level2ParagraphProperties level2ParagraphProperties6 = new A.Level2ParagraphProperties() { LeftMargin = 742950, Indent = -285750 };

            A.SpaceBefore spaceBefore59 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent72 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore59.Append(spacingPercent72);

            A.BulletColor bulletColor47 = new A.BulletColor();
            A.SchemeColor schemeColor184 = new A.SchemeColor() { Val = A.SchemeColorValues.Background2 };

            bulletColor47.Append(schemeColor184);
            A.BulletFont bulletFont11 = new A.BulletFont() { Typeface = "Times", Panose = "02020603050405020304", PitchFamily = 18, CharacterSet = 0 };
            A.CharacterBullet characterBullet4 = new A.CharacterBullet() { Char = "•" };

            A.DefaultRunProperties defaultRunProperties78 = new A.DefaultRunProperties();

            A.SolidFill solidFill127 = new A.SolidFill();
            A.SchemeColor schemeColor185 = new A.SchemeColor() { Val = A.SchemeColorValues.Background2 };

            solidFill127.Append(schemeColor185);
            A.LatinFont latinFont90 = new A.LatinFont() { Typeface = "Bliss Pro Regular", Panose = "02010006030000020004", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont58 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties78.Append(solidFill127);
            defaultRunProperties78.Append(latinFont90);
            defaultRunProperties78.Append(eastAsianFont58);

            level2ParagraphProperties6.Append(spaceBefore59);
            level2ParagraphProperties6.Append(bulletColor47);
            level2ParagraphProperties6.Append(bulletFont11);
            level2ParagraphProperties6.Append(characterBullet4);
            level2ParagraphProperties6.Append(defaultRunProperties78);

            A.Level3ParagraphProperties level3ParagraphProperties6 = new A.Level3ParagraphProperties() { LeftMargin = 1143000, Indent = -228600 };

            A.SpaceBefore spaceBefore60 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent73 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore60.Append(spacingPercent73);

            A.BulletColor bulletColor48 = new A.BulletColor();
            A.SchemeColor schemeColor186 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor48.Append(schemeColor186);

            A.DefaultRunProperties defaultRunProperties79 = new A.DefaultRunProperties();

            A.SolidFill solidFill128 = new A.SolidFill();
            A.SchemeColor schemeColor187 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill128.Append(schemeColor187);
            A.LatinFont latinFont91 = new A.LatinFont() { Typeface = "Bliss Pro Regular", Panose = "02010006030000020004", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont59 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties79.Append(solidFill128);
            defaultRunProperties79.Append(latinFont91);
            defaultRunProperties79.Append(eastAsianFont59);

            level3ParagraphProperties6.Append(spaceBefore60);
            level3ParagraphProperties6.Append(bulletColor48);
            level3ParagraphProperties6.Append(defaultRunProperties79);

            A.Level4ParagraphProperties level4ParagraphProperties6 = new A.Level4ParagraphProperties() { LeftMargin = 1600200, Indent = -228600 };

            A.SpaceBefore spaceBefore61 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent74 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore61.Append(spacingPercent74);

            A.BulletColor bulletColor49 = new A.BulletColor();
            A.SchemeColor schemeColor188 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor49.Append(schemeColor188);
            A.BulletFont bulletFont12 = new A.BulletFont() { Typeface = "Wingdings", Panose = "05000000000000000000", PitchFamily = 2, CharacterSet = 2 };

            A.DefaultRunProperties defaultRunProperties80 = new A.DefaultRunProperties();

            A.SolidFill solidFill129 = new A.SolidFill();
            A.SchemeColor schemeColor189 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill129.Append(schemeColor189);
            A.LatinFont latinFont92 = new A.LatinFont() { Typeface = "Bliss Pro Regular", Panose = "02010006030000020004", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont60 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties80.Append(solidFill129);
            defaultRunProperties80.Append(latinFont92);
            defaultRunProperties80.Append(eastAsianFont60);

            level4ParagraphProperties6.Append(spaceBefore61);
            level4ParagraphProperties6.Append(bulletColor49);
            level4ParagraphProperties6.Append(bulletFont12);
            level4ParagraphProperties6.Append(defaultRunProperties80);

            A.Level5ParagraphProperties level5ParagraphProperties6 = new A.Level5ParagraphProperties() { LeftMargin = 2057400, Indent = -228600 };

            A.SpaceBefore spaceBefore62 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent75 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore62.Append(spacingPercent75);

            A.BulletColor bulletColor50 = new A.BulletColor();
            A.SchemeColor schemeColor190 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor50.Append(schemeColor190);

            A.DefaultRunProperties defaultRunProperties81 = new A.DefaultRunProperties();

            A.SolidFill solidFill130 = new A.SolidFill();
            A.SchemeColor schemeColor191 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill130.Append(schemeColor191);
            A.LatinFont latinFont93 = new A.LatinFont() { Typeface = "Bliss Pro Regular", Panose = "02010006030000020004", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont61 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties81.Append(solidFill130);
            defaultRunProperties81.Append(latinFont93);
            defaultRunProperties81.Append(eastAsianFont61);

            level5ParagraphProperties6.Append(spaceBefore62);
            level5ParagraphProperties6.Append(bulletColor50);
            level5ParagraphProperties6.Append(defaultRunProperties81);

            A.Level6ParagraphProperties level6ParagraphProperties6 = new A.Level6ParagraphProperties() { LeftMargin = 2514600, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore63 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent76 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore63.Append(spacingPercent76);

            A.SpaceAfter spaceAfter43 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent77 = new A.SpacingPercent() { Val = 0 };

            spaceAfter43.Append(spacingPercent77);

            A.BulletColor bulletColor51 = new A.BulletColor();
            A.SchemeColor schemeColor192 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor51.Append(schemeColor192);

            A.DefaultRunProperties defaultRunProperties82 = new A.DefaultRunProperties();

            A.SolidFill solidFill131 = new A.SolidFill();
            A.SchemeColor schemeColor193 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill131.Append(schemeColor193);
            A.LatinFont latinFont94 = new A.LatinFont() { Typeface = "Bliss Pro Regular", Panose = "02010006030000020004", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont62 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties82.Append(solidFill131);
            defaultRunProperties82.Append(latinFont94);
            defaultRunProperties82.Append(eastAsianFont62);

            level6ParagraphProperties6.Append(spaceBefore63);
            level6ParagraphProperties6.Append(spaceAfter43);
            level6ParagraphProperties6.Append(bulletColor51);
            level6ParagraphProperties6.Append(defaultRunProperties82);

            A.Level7ParagraphProperties level7ParagraphProperties6 = new A.Level7ParagraphProperties() { LeftMargin = 2971800, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore64 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent78 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore64.Append(spacingPercent78);

            A.SpaceAfter spaceAfter44 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent79 = new A.SpacingPercent() { Val = 0 };

            spaceAfter44.Append(spacingPercent79);

            A.BulletColor bulletColor52 = new A.BulletColor();
            A.SchemeColor schemeColor194 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor52.Append(schemeColor194);

            A.DefaultRunProperties defaultRunProperties83 = new A.DefaultRunProperties();

            A.SolidFill solidFill132 = new A.SolidFill();
            A.SchemeColor schemeColor195 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill132.Append(schemeColor195);
            A.LatinFont latinFont95 = new A.LatinFont() { Typeface = "Bliss Pro Regular", Panose = "02010006030000020004", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont63 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties83.Append(solidFill132);
            defaultRunProperties83.Append(latinFont95);
            defaultRunProperties83.Append(eastAsianFont63);

            level7ParagraphProperties6.Append(spaceBefore64);
            level7ParagraphProperties6.Append(spaceAfter44);
            level7ParagraphProperties6.Append(bulletColor52);
            level7ParagraphProperties6.Append(defaultRunProperties83);

            A.Level8ParagraphProperties level8ParagraphProperties6 = new A.Level8ParagraphProperties() { LeftMargin = 3429000, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore65 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent80 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore65.Append(spacingPercent80);

            A.SpaceAfter spaceAfter45 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent81 = new A.SpacingPercent() { Val = 0 };

            spaceAfter45.Append(spacingPercent81);

            A.BulletColor bulletColor53 = new A.BulletColor();
            A.SchemeColor schemeColor196 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor53.Append(schemeColor196);

            A.DefaultRunProperties defaultRunProperties84 = new A.DefaultRunProperties();

            A.SolidFill solidFill133 = new A.SolidFill();
            A.SchemeColor schemeColor197 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill133.Append(schemeColor197);
            A.LatinFont latinFont96 = new A.LatinFont() { Typeface = "Bliss Pro Regular", Panose = "02010006030000020004", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont64 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties84.Append(solidFill133);
            defaultRunProperties84.Append(latinFont96);
            defaultRunProperties84.Append(eastAsianFont64);

            level8ParagraphProperties6.Append(spaceBefore65);
            level8ParagraphProperties6.Append(spaceAfter45);
            level8ParagraphProperties6.Append(bulletColor53);
            level8ParagraphProperties6.Append(defaultRunProperties84);

            A.Level9ParagraphProperties level9ParagraphProperties6 = new A.Level9ParagraphProperties() { LeftMargin = 3886200, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore66 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent82 = new A.SpacingPercent() { Val = 20000 };

            spaceBefore66.Append(spacingPercent82);

            A.SpaceAfter spaceAfter46 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent83 = new A.SpacingPercent() { Val = 0 };

            spaceAfter46.Append(spacingPercent83);

            A.BulletColor bulletColor54 = new A.BulletColor();
            A.SchemeColor schemeColor198 = new A.SchemeColor() { Val = A.SchemeColorValues.Text2 };

            bulletColor54.Append(schemeColor198);

            A.DefaultRunProperties defaultRunProperties85 = new A.DefaultRunProperties();

            A.SolidFill solidFill134 = new A.SolidFill();
            A.SchemeColor schemeColor199 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill134.Append(schemeColor199);
            A.LatinFont latinFont97 = new A.LatinFont() { Typeface = "Bliss Pro Regular", Panose = "02010006030000020004", PitchFamily = 50, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont65 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties85.Append(solidFill134);
            defaultRunProperties85.Append(latinFont97);
            defaultRunProperties85.Append(eastAsianFont65);

            level9ParagraphProperties6.Append(spaceBefore66);
            level9ParagraphProperties6.Append(spaceAfter46);
            level9ParagraphProperties6.Append(bulletColor54);
            level9ParagraphProperties6.Append(defaultRunProperties85);

            listStyle15.Append(level1ParagraphProperties14);
            listStyle15.Append(level2ParagraphProperties6);
            listStyle15.Append(level3ParagraphProperties6);
            listStyle15.Append(level4ParagraphProperties6);
            listStyle15.Append(level5ParagraphProperties6);
            listStyle15.Append(level6ParagraphProperties6);
            listStyle15.Append(level7ParagraphProperties6);
            listStyle15.Append(level8ParagraphProperties6);
            listStyle15.Append(level9ParagraphProperties6);

            A.Paragraph paragraph32 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties29 = new A.ParagraphProperties();

            A.SpaceBefore spaceBefore67 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent84 = new A.SpacingPercent() { Val = 0 };

            spaceBefore67.Append(spacingPercent84);

            A.SpaceAfter spaceAfter47 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints32 = new A.SpacingPoints() { Val = 600 };

            spaceAfter47.Append(spacingPoints32);

            A.BulletColor bulletColor55 = new A.BulletColor();
            A.RgbColorModelHex rgbColorModelHex229 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            bulletColor55.Append(rgbColorModelHex229);
            A.BulletFontText bulletFontText15 = new A.BulletFontText();
            A.NoBullet noBullet15 = new A.NoBullet();

            paragraphProperties29.Append(spaceBefore67);
            paragraphProperties29.Append(spaceAfter47);
            paragraphProperties29.Append(bulletColor55);
            paragraphProperties29.Append(bulletFontText15);
            paragraphProperties29.Append(noBullet15);

            A.Run run31 = new A.Run();

            A.RunProperties runProperties34 = new A.RunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1400, Bold = true, Dirty = false };

            A.SolidFill solidFill135 = new A.SolidFill();
            A.SchemeColor schemeColor200 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill135.Append(schemeColor200);
            A.LatinFont latinFont98 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.ComplexScriptFont complexScriptFont60 = new A.ComplexScriptFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };

            runProperties34.Append(solidFill135);
            runProperties34.Append(latinFont98);
            runProperties34.Append(complexScriptFont60);
            A.Text text34 = new A.Text();
            text34.Text = $"{PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.STRENGTHS, data.Language)}";

            run31.Append(runProperties34);
            run31.Append(text34);

            paragraph32.Append(paragraphProperties29);
            paragraph32.Append(run31);

            A.Paragraph paragraph33 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties30 = new A.ParagraphProperties();

            A.SpaceBefore spaceBefore68 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent85 = new A.SpacingPercent() { Val = 0 };

            spaceBefore68.Append(spacingPercent85);

            A.SpaceAfter spaceAfter48 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints33 = new A.SpacingPoints() { Val = 600 };

            spaceAfter48.Append(spacingPoints33);

            A.BulletColor bulletColor56 = new A.BulletColor();
            A.RgbColorModelHex rgbColorModelHex230 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            bulletColor56.Append(rgbColorModelHex230);
            A.BulletFontText bulletFontText16 = new A.BulletFontText();
            A.NoBullet noBullet16 = new A.NoBullet();

            paragraphProperties30.Append(spaceBefore68);
            paragraphProperties30.Append(spaceAfter48);
            paragraphProperties30.Append(bulletColor56);
            paragraphProperties30.Append(bulletFontText16);
            paragraphProperties30.Append(noBullet16);

            A.Run run32 = new A.Run();

            A.RunProperties runProperties35 = new A.RunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill136 = new A.SolidFill();
            A.SchemeColor schemeColor201 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill136.Append(schemeColor201);
            A.LatinFont latinFont99 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };

            runProperties35.Append(solidFill136);
            runProperties35.Append(latinFont99);
            A.Text text35 = new A.Text();
            text35.Text = "+";

            run32.Append(runProperties35);
            run32.Append(text35);

            A.EndParagraphRunProperties endParagraphRunProperties16 = new A.EndParagraphRunProperties() { Language = "lv-LV", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill137 = new A.SolidFill();
            A.SchemeColor schemeColor202 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill137.Append(schemeColor202);
            A.LatinFont latinFont100 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };

            endParagraphRunProperties16.Append(solidFill137);
            endParagraphRunProperties16.Append(latinFont100);

            paragraph33.Append(paragraphProperties30);
            paragraph33.Append(run32);
            paragraph33.Append(endParagraphRunProperties16);

            A.Paragraph paragraph34 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties31 = new A.ParagraphProperties();

            A.SpaceBefore spaceBefore69 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent86 = new A.SpacingPercent() { Val = 0 };

            spaceBefore69.Append(spacingPercent86);

            A.SpaceAfter spaceAfter49 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints34 = new A.SpacingPoints() { Val = 600 };

            spaceAfter49.Append(spacingPoints34);

            A.BulletColor bulletColor57 = new A.BulletColor();
            A.RgbColorModelHex rgbColorModelHex231 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            bulletColor57.Append(rgbColorModelHex231);
            A.BulletFontText bulletFontText17 = new A.BulletFontText();
            A.NoBullet noBullet17 = new A.NoBullet();

            paragraphProperties31.Append(spaceBefore69);
            paragraphProperties31.Append(spaceAfter49);
            paragraphProperties31.Append(bulletColor57);
            paragraphProperties31.Append(bulletFontText17);
            paragraphProperties31.Append(noBullet17);

            A.Run run33 = new A.Run();

            A.RunProperties runProperties36 = new A.RunProperties() { Language = "lv-LV", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill138 = new A.SolidFill();
            A.SchemeColor schemeColor203 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill138.Append(schemeColor203);
            A.LatinFont latinFont101 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };

            runProperties36.Append(solidFill138);
            runProperties36.Append(latinFont101);
            A.Text text36 = new A.Text();
            text36.Text = "- ";

            run33.Append(runProperties36);
            run33.Append(text36);

            A.EndParagraphRunProperties endParagraphRunProperties17 = new A.EndParagraphRunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill139 = new A.SolidFill();
            A.SchemeColor schemeColor204 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill139.Append(schemeColor204);
            A.LatinFont latinFont102 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };

            endParagraphRunProperties17.Append(solidFill139);
            endParagraphRunProperties17.Append(latinFont102);

            paragraph34.Append(paragraphProperties31);
            paragraph34.Append(run33);
            paragraph34.Append(endParagraphRunProperties17);

            textBody13.Append(bodyProperties15);
            textBody13.Append(listStyle15);
            textBody13.Append(paragraph32);
            textBody13.Append(paragraph33);
            textBody13.Append(paragraph34);

            shape14.Append(nonVisualShapeProperties14);
            shape14.Append(shapeProperties16);
            shape14.Append(textBody13);

            Shape shape15 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties15 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties18 = new NonVisualDrawingProperties() { Id = (UInt32Value)18438U, Name = "Rectangle 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties15 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks15 = new A.ShapeLocks() { NoChangeArrowheads = true };

            nonVisualShapeDrawingProperties15.Append(shapeLocks15);
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties18 = new ApplicationNonVisualDrawingProperties();

            nonVisualShapeProperties15.Append(nonVisualDrawingProperties18);
            nonVisualShapeProperties15.Append(nonVisualShapeDrawingProperties15);
            nonVisualShapeProperties15.Append(applicationNonVisualDrawingProperties18);

            ShapeProperties shapeProperties17 = new ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D17 = new A.Transform2D();
            A.Offset offset20 = new A.Offset() { X = 4424363L, Y = 3962400L };
            A.Extents extents20 = new A.Extents() { Cx = 4953000L, Cy = 1828800L };

            transform2D17.Append(offset20);
            transform2D17.Append(extents20);

            A.PresetGeometry presetGeometry15 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList24 = new A.AdjustValueList();

            presetGeometry15.Append(adjustValueList24);

            A.SolidFill solidFill140 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex232 = new A.RgbColorModelHex() { Val = "F15A29" };

            solidFill140.Append(rgbColorModelHex232);

            A.Outline outline32 = new A.Outline();
            A.NoFill noFill18 = new A.NoFill();

            outline32.Append(noFill18);

            A.ShapePropertiesExtensionList shapePropertiesExtensionList6 = new A.ShapePropertiesExtensionList();

            A.ShapePropertiesExtension shapePropertiesExtension6 = new A.ShapePropertiesExtension() { Uri = "{91240B29-F687-4F45-9708-019B960494DF}" };

            A14.HiddenLineProperties hiddenLineProperties5 = new A14.HiddenLineProperties() { Width = 9525 };
            hiddenLineProperties5.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill141 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex233 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill141.Append(rgbColorModelHex233);
            A.Miter miter14 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd13 = new A.HeadEnd();
            A.TailEnd tailEnd13 = new A.TailEnd();

            hiddenLineProperties5.Append(solidFill141);
            hiddenLineProperties5.Append(miter14);
            hiddenLineProperties5.Append(headEnd13);
            hiddenLineProperties5.Append(tailEnd13);

            shapePropertiesExtension6.Append(hiddenLineProperties5);

            shapePropertiesExtensionList6.Append(shapePropertiesExtension6);

            shapeProperties17.Append(transform2D17);
            shapeProperties17.Append(presetGeometry15);
            shapeProperties17.Append(solidFill140);
            shapeProperties17.Append(outline32);
            shapeProperties17.Append(shapePropertiesExtensionList6);

            TextBody textBody14 = new TextBody();
            A.BodyProperties bodyProperties16 = new A.BodyProperties() { LeftInset = 108000, TopInset = 108000, RightInset = 108000, BottomInset = 108000 };

            A.ListStyle listStyle16 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties15 = new A.Level1ParagraphProperties();

            A.DefaultRunProperties defaultRunProperties86 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill142 = new A.SolidFill();
            A.SchemeColor schemeColor205 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill142.Append(schemeColor205);
            A.LatinFont latinFont103 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont66 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties86.Append(solidFill142);
            defaultRunProperties86.Append(latinFont103);
            defaultRunProperties86.Append(eastAsianFont66);

            level1ParagraphProperties15.Append(defaultRunProperties86);

            A.Level2ParagraphProperties level2ParagraphProperties7 = new A.Level2ParagraphProperties() { LeftMargin = 742950, Indent = -285750 };

            A.DefaultRunProperties defaultRunProperties87 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill143 = new A.SolidFill();
            A.SchemeColor schemeColor206 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill143.Append(schemeColor206);
            A.LatinFont latinFont104 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont67 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties87.Append(solidFill143);
            defaultRunProperties87.Append(latinFont104);
            defaultRunProperties87.Append(eastAsianFont67);

            level2ParagraphProperties7.Append(defaultRunProperties87);

            A.Level3ParagraphProperties level3ParagraphProperties7 = new A.Level3ParagraphProperties() { LeftMargin = 1143000, Indent = -228600 };

            A.DefaultRunProperties defaultRunProperties88 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill144 = new A.SolidFill();
            A.SchemeColor schemeColor207 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill144.Append(schemeColor207);
            A.LatinFont latinFont105 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont68 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties88.Append(solidFill144);
            defaultRunProperties88.Append(latinFont105);
            defaultRunProperties88.Append(eastAsianFont68);

            level3ParagraphProperties7.Append(defaultRunProperties88);

            A.Level4ParagraphProperties level4ParagraphProperties7 = new A.Level4ParagraphProperties() { LeftMargin = 1600200, Indent = -228600 };

            A.DefaultRunProperties defaultRunProperties89 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill145 = new A.SolidFill();
            A.SchemeColor schemeColor208 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill145.Append(schemeColor208);
            A.LatinFont latinFont106 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont69 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties89.Append(solidFill145);
            defaultRunProperties89.Append(latinFont106);
            defaultRunProperties89.Append(eastAsianFont69);

            level4ParagraphProperties7.Append(defaultRunProperties89);

            A.Level5ParagraphProperties level5ParagraphProperties7 = new A.Level5ParagraphProperties() { LeftMargin = 2057400, Indent = -228600 };

            A.DefaultRunProperties defaultRunProperties90 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill146 = new A.SolidFill();
            A.SchemeColor schemeColor209 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill146.Append(schemeColor209);
            A.LatinFont latinFont107 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont70 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties90.Append(solidFill146);
            defaultRunProperties90.Append(latinFont107);
            defaultRunProperties90.Append(eastAsianFont70);

            level5ParagraphProperties7.Append(defaultRunProperties90);

            A.Level6ParagraphProperties level6ParagraphProperties7 = new A.Level6ParagraphProperties() { LeftMargin = 2514600, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore70 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent87 = new A.SpacingPercent() { Val = 0 };

            spaceBefore70.Append(spacingPercent87);

            A.SpaceAfter spaceAfter50 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent88 = new A.SpacingPercent() { Val = 0 };

            spaceAfter50.Append(spacingPercent88);

            A.DefaultRunProperties defaultRunProperties91 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill147 = new A.SolidFill();
            A.SchemeColor schemeColor210 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill147.Append(schemeColor210);
            A.LatinFont latinFont108 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont71 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties91.Append(solidFill147);
            defaultRunProperties91.Append(latinFont108);
            defaultRunProperties91.Append(eastAsianFont71);

            level6ParagraphProperties7.Append(spaceBefore70);
            level6ParagraphProperties7.Append(spaceAfter50);
            level6ParagraphProperties7.Append(defaultRunProperties91);

            A.Level7ParagraphProperties level7ParagraphProperties7 = new A.Level7ParagraphProperties() { LeftMargin = 2971800, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore71 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent89 = new A.SpacingPercent() { Val = 0 };

            spaceBefore71.Append(spacingPercent89);

            A.SpaceAfter spaceAfter51 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent90 = new A.SpacingPercent() { Val = 0 };

            spaceAfter51.Append(spacingPercent90);

            A.DefaultRunProperties defaultRunProperties92 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill148 = new A.SolidFill();
            A.SchemeColor schemeColor211 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill148.Append(schemeColor211);
            A.LatinFont latinFont109 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont72 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties92.Append(solidFill148);
            defaultRunProperties92.Append(latinFont109);
            defaultRunProperties92.Append(eastAsianFont72);

            level7ParagraphProperties7.Append(spaceBefore71);
            level7ParagraphProperties7.Append(spaceAfter51);
            level7ParagraphProperties7.Append(defaultRunProperties92);

            A.Level8ParagraphProperties level8ParagraphProperties7 = new A.Level8ParagraphProperties() { LeftMargin = 3429000, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore72 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent91 = new A.SpacingPercent() { Val = 0 };

            spaceBefore72.Append(spacingPercent91);

            A.SpaceAfter spaceAfter52 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent92 = new A.SpacingPercent() { Val = 0 };

            spaceAfter52.Append(spacingPercent92);

            A.DefaultRunProperties defaultRunProperties93 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill149 = new A.SolidFill();
            A.SchemeColor schemeColor212 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill149.Append(schemeColor212);
            A.LatinFont latinFont110 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont73 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties93.Append(solidFill149);
            defaultRunProperties93.Append(latinFont110);
            defaultRunProperties93.Append(eastAsianFont73);

            level8ParagraphProperties7.Append(spaceBefore72);
            level8ParagraphProperties7.Append(spaceAfter52);
            level8ParagraphProperties7.Append(defaultRunProperties93);

            A.Level9ParagraphProperties level9ParagraphProperties7 = new A.Level9ParagraphProperties() { LeftMargin = 3886200, Indent = -228600, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore73 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent93 = new A.SpacingPercent() { Val = 0 };

            spaceBefore73.Append(spacingPercent93);

            A.SpaceAfter spaceAfter53 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent94 = new A.SpacingPercent() { Val = 0 };

            spaceAfter53.Append(spacingPercent94);

            A.DefaultRunProperties defaultRunProperties94 = new A.DefaultRunProperties() { FontSize = 2400 };

            A.SolidFill solidFill150 = new A.SolidFill();
            A.SchemeColor schemeColor213 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill150.Append(schemeColor213);
            A.LatinFont latinFont111 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont74 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties94.Append(solidFill150);
            defaultRunProperties94.Append(latinFont111);
            defaultRunProperties94.Append(eastAsianFont74);

            level9ParagraphProperties7.Append(spaceBefore73);
            level9ParagraphProperties7.Append(spaceAfter53);
            level9ParagraphProperties7.Append(defaultRunProperties94);

            listStyle16.Append(level1ParagraphProperties15);
            listStyle16.Append(level2ParagraphProperties7);
            listStyle16.Append(level3ParagraphProperties7);
            listStyle16.Append(level4ParagraphProperties7);
            listStyle16.Append(level5ParagraphProperties7);
            listStyle16.Append(level6ParagraphProperties7);
            listStyle16.Append(level7ParagraphProperties7);
            listStyle16.Append(level8ParagraphProperties7);
            listStyle16.Append(level9ParagraphProperties7);

            A.Paragraph paragraph35 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties32 = new A.ParagraphProperties();

            A.SpaceAfter spaceAfter54 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints35 = new A.SpacingPoints() { Val = 600 };

            spaceAfter54.Append(spacingPoints35);

            A.BulletColor bulletColor58 = new A.BulletColor();
            A.RgbColorModelHex rgbColorModelHex234 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            bulletColor58.Append(rgbColorModelHex234);

            paragraphProperties32.Append(spaceAfter54);
            paragraphProperties32.Append(bulletColor58);

            A.Run run34 = new A.Run();

            A.RunProperties runProperties37 = new A.RunProperties() { Language = "en-GB", AlternativeLanguage = "lv-LV", FontSize = 1400, Bold = true, Dirty = false };

            A.SolidFill solidFill151 = new A.SolidFill();
            A.SchemeColor schemeColor214 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill151.Append(schemeColor214);

            runProperties37.Append(solidFill151);
            A.Text text37 = new A.Text();
            text37.Text = $"{PresentationMetadataTexts.GetText(PresentationMetadataTextsEnum.MOTIVATION, data.Language)}";

            run34.Append(runProperties37);
            run34.Append(text37);

            paragraph35.Append(paragraphProperties32);
            paragraph35.Append(run34);

            A.Paragraph paragraph36 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties33 = new A.ParagraphProperties();

            A.SpaceAfter spaceAfter55 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints36 = new A.SpacingPoints() { Val = 600 };

            spaceAfter55.Append(spacingPoints36);

            A.BulletColor bulletColor59 = new A.BulletColor();
            A.RgbColorModelHex rgbColorModelHex235 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            bulletColor59.Append(rgbColorModelHex235);

            paragraphProperties33.Append(spaceAfter55);
            paragraphProperties33.Append(bulletColor59);

            A.EndParagraphRunProperties endParagraphRunProperties18 = new A.EndParagraphRunProperties() { Language = "lv-LV", AlternativeLanguage = "lv-LV", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill152 = new A.SolidFill();
            A.SchemeColor schemeColor215 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill152.Append(schemeColor215);

            endParagraphRunProperties18.Append(solidFill152);

            paragraph36.Append(paragraphProperties33);
            paragraph36.Append(endParagraphRunProperties18);

            A.Paragraph paragraph37 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties34 = new A.ParagraphProperties();

            A.SpaceAfter spaceAfter56 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints37 = new A.SpacingPoints() { Val = 600 };

            spaceAfter56.Append(spacingPoints37);

            A.BulletColor bulletColor60 = new A.BulletColor();
            A.RgbColorModelHex rgbColorModelHex236 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            bulletColor60.Append(rgbColorModelHex236);

            paragraphProperties34.Append(spaceAfter56);
            paragraphProperties34.Append(bulletColor60);

            A.EndParagraphRunProperties endParagraphRunProperties19 = new A.EndParagraphRunProperties() { Language = "lv-LV", AlternativeLanguage = "lv-LV", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill153 = new A.SolidFill();
            A.SchemeColor schemeColor216 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill153.Append(schemeColor216);

            endParagraphRunProperties19.Append(solidFill153);

            paragraph37.Append(paragraphProperties34);
            paragraph37.Append(endParagraphRunProperties19);

            A.Paragraph paragraph38 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties35 = new A.ParagraphProperties();

            A.SpaceAfter spaceAfter57 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints38 = new A.SpacingPoints() { Val = 600 };

            spaceAfter57.Append(spacingPoints38);

            A.BulletColor bulletColor61 = new A.BulletColor();
            A.RgbColorModelHex rgbColorModelHex237 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            bulletColor61.Append(rgbColorModelHex237);

            paragraphProperties35.Append(spaceAfter57);
            paragraphProperties35.Append(bulletColor61);

            A.EndParagraphRunProperties endParagraphRunProperties20 = new A.EndParagraphRunProperties() { Language = "en-GB", AlternativeLanguage = "lv-LV", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill154 = new A.SolidFill();
            A.SchemeColor schemeColor217 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill154.Append(schemeColor217);

            endParagraphRunProperties20.Append(solidFill154);

            paragraph38.Append(paragraphProperties35);
            paragraph38.Append(endParagraphRunProperties20);

            //A.Paragraph paragraph39 = new A.Paragraph();

            //A.ParagraphProperties paragraphProperties36 = new A.ParagraphProperties();

            //A.SpaceAfter spaceAfter58 = new A.SpaceAfter();
            //A.SpacingPoints spacingPoints39 = new A.SpacingPoints() { Val = 600 };

            //spaceAfter58.Append(spacingPoints39);

            //A.BulletColor bulletColor62 = new A.BulletColor();
            //A.RgbColorModelHex rgbColorModelHex238 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            //bulletColor62.Append(rgbColorModelHex238);

            //paragraphProperties36.Append(spaceAfter58);
            //paragraphProperties36.Append(bulletColor62);

            //A.Run run35 = new A.Run();

            //A.RunProperties runProperties38 = new A.RunProperties() { Language = "en-GB", AlternativeLanguage = "lv-LV", FontSize = 1050, Dirty = false };

            //A.SolidFill solidFill155 = new A.SolidFill();
            //A.SchemeColor schemeColor218 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            //solidFill155.Append(schemeColor218);

            //runProperties38.Append(solidFill155);
            //A.Text text38 = new A.Text();
            //text38.Text = "Remuneration: ";

            //run35.Append(runProperties38);
            //run35.Append(text38);

            //A.Run run37 = new A.Run();

            //A.RunProperties runProperties40 = new A.RunProperties() { Language = "en-GB", AlternativeLanguage = "lv-LV", FontSize = 1050, Dirty = false };

            //A.SolidFill solidFill157 = new A.SolidFill();
            //A.SchemeColor schemeColor220 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            //solidFill157.Append(schemeColor220);

            //runProperties40.Append(solidFill157);
            //A.Text text40 = new A.Text();
            //text40.Text = "8 500 EUR Gross (base salary)";

            //run37.Append(runProperties40);
            //run37.Append(text40);

            //paragraph39.Append(paragraphProperties36);
            //paragraph39.Append(run35);
            //paragraph39.Append(run37);

            textBody14.Append(bodyProperties16);
            textBody14.Append(listStyle16);
            textBody14.Append(paragraph35);
            textBody14.Append(paragraph36);
            textBody14.Append(paragraph37);
            textBody14.Append(paragraph38);

            foreach (var item in data.Motivation)
            {
                textBody14.Append(CreateMotivationParagraph(item));
            }

            shape15.Append(nonVisualShapeProperties15);
            shape15.Append(shapeProperties17);
            shape15.Append(textBody14);

            Picture picture1 = new Picture();

            NonVisualPictureProperties nonVisualPictureProperties1 = new NonVisualPictureProperties();

            NonVisualDrawingProperties nonVisualDrawingProperties19 = new NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = "Picture 1" };

            A.NonVisualDrawingPropertiesExtensionList nonVisualDrawingPropertiesExtensionList5 = new A.NonVisualDrawingPropertiesExtensionList();

            A.NonVisualDrawingPropertiesExtension nonVisualDrawingPropertiesExtension5 = new A.NonVisualDrawingPropertiesExtension() { Uri = "{FF2B5EF4-FFF2-40B4-BE49-F238E27FC236}" };

            OpenXmlUnknownElement openXmlUnknownElement5 = OpenXmlUnknownElement.CreateOpenXmlUnknownElement("<a16:creationId xmlns:a16=\"http://schemas.microsoft.com/office/drawing/2014/main\" id=\"{6612B199-2916-41CA-80F7-9E49FF07DDC2}\" />");

            nonVisualDrawingPropertiesExtension5.Append(openXmlUnknownElement5);

            nonVisualDrawingPropertiesExtensionList5.Append(nonVisualDrawingPropertiesExtension5);

            nonVisualDrawingProperties19.Append(nonVisualDrawingPropertiesExtensionList5);

            NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties1 = new NonVisualPictureDrawingProperties();
            A.PictureLocks pictureLocks1 = new A.PictureLocks() { NoChangeAspect = true };

            nonVisualPictureDrawingProperties1.Append(pictureLocks1);
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties19 = new ApplicationNonVisualDrawingProperties();

            nonVisualPictureProperties1.Append(nonVisualDrawingProperties19);
            nonVisualPictureProperties1.Append(nonVisualPictureDrawingProperties1);
            nonVisualPictureProperties1.Append(applicationNonVisualDrawingProperties19);

            BlipFill blipFill1 = new BlipFill() { RotateWithShape = true };
            A.Blip blip1 = new A.Blip() { Embed = "rId3" };
            A.SourceRectangle sourceRectangle1 = new A.SourceRectangle() { Left = 16783, Right = 14685, Bottom = 22727 };
            A.Stretch stretch1 = new A.Stretch();

            blipFill1.Append(blip1);
            blipFill1.Append(sourceRectangle1);
            blipFill1.Append(stretch1);

            ShapeProperties shapeProperties18 = new ShapeProperties();

            A.Transform2D transform2D18 = new A.Transform2D();
            A.Offset offset21 = new A.Offset() { X = 3200400L, Y = 457200L };
            A.Extents extents21 = new A.Extents() { Cx = 1066800L, Cy = 1295400L };

            transform2D18.Append(offset21);
            transform2D18.Append(extents21);

            A.PresetGeometry presetGeometry16 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList25 = new A.AdjustValueList();

            presetGeometry16.Append(adjustValueList25);

            shapeProperties18.Append(transform2D18);
            shapeProperties18.Append(presetGeometry16);

            picture1.Append(nonVisualPictureProperties1);
            picture1.Append(blipFill1);
            picture1.Append(shapeProperties18);

            shapeTree3.Append(nonVisualGroupShapeProperties3);
            shapeTree3.Append(groupShapeProperties3);
            shapeTree3.Append(shape11);
            shapeTree3.Append(shape12);
            shapeTree3.Append(shape13);
            shapeTree3.Append(shape14);
            shapeTree3.Append(shape15);
            shapeTree3.Append(picture1);

            CommonSlideDataExtensionList commonSlideDataExtensionList3 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension3 = new CommonSlideDataExtension() { Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId3 = new P14.CreationId() { Val = (UInt32Value)1926896120U };
            creationId3.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension3.Append(creationId3);

            commonSlideDataExtensionList3.Append(commonSlideDataExtension3);

            commonSlideData3.Append(shapeTree3);
            commonSlideData3.Append(commonSlideDataExtensionList3);

            ColorMapOverride colorMapOverride1 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping1 = new A.MasterColorMapping();

            colorMapOverride1.Append(masterColorMapping1);

            slide1.Append(commonSlideData3);
            slide1.Append(colorMapOverride1);

            slidePart1.Slide = slide1;
        }

        private static A.Paragraph CreateEducationParagraph(EducationItem item)
        {
            A.Paragraph paragraph27 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties24 = new A.ParagraphProperties();

            A.SpaceBefore spaceBefore53 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent66 = new A.SpacingPercent() { Val = 0 };

            spaceBefore53.Append(spacingPercent66);

            A.SpaceAfter spaceAfter38 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints27 = new A.SpacingPoints() { Val = 600 };

            spaceAfter38.Append(spacingPoints27);

            A.BulletColor bulletColor41 = new A.BulletColor();
            A.RgbColorModelHex rgbColorModelHex222 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            bulletColor41.Append(rgbColorModelHex222);
            A.DefaultRunProperties defaultRunProperties72 = new A.DefaultRunProperties();

            paragraphProperties24.Append(spaceBefore53);
            paragraphProperties24.Append(spaceAfter38);
            paragraphProperties24.Append(bulletColor41);
            paragraphProperties24.Append(defaultRunProperties72);

            A.Run run27 = new A.Run();

            A.RunProperties runProperties30 = new A.RunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1050, Bold = true, Dirty = false };

            A.SolidFill solidFill117 = new A.SolidFill();
            A.SchemeColor schemeColor175 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill117.Append(schemeColor175);
            A.LatinFont latinFont82 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.ComplexScriptFont complexScriptFont53 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            runProperties30.Append(solidFill117);
            runProperties30.Append(latinFont82);
            runProperties30.Append(complexScriptFont53);
            A.Text text30 = new A.Text();
            text30.Text = $"{item.EndYear} {item.University} ";

            run27.Append(runProperties30);
            run27.Append(text30);

            A.Run run28 = new A.Run();

            A.RunProperties runProperties31 = new A.RunProperties() { Language = "en-GB", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill118 = new A.SolidFill();
            A.SchemeColor schemeColor176 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill118.Append(schemeColor176);
            A.LatinFont latinFont83 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.ComplexScriptFont complexScriptFont54 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            runProperties31.Append(solidFill118);
            runProperties31.Append(latinFont83);
            runProperties31.Append(complexScriptFont54);
            A.Text text31 = new A.Text();
            text31.Text = $"- {item.Degree}";

            run28.Append(runProperties31);
            run28.Append(text31);

            paragraph27.Append(paragraphProperties24);
            paragraph27.Append(run27);
            paragraph27.Append(run28);

            return paragraph27;
        }

        private static string GetLanguages(PresentationGenerationData data)
        {
            var sb = new StringBuilder();

            foreach (var language in data.Languages)
            {
                sb.Append($"{language.LanguageName} - {language.LanguageLevel}; ");
            }

            return sb.ToString();
        }

        private static A.Paragraph CreateExperienceParagraph(ExperienceItem item)
        {
            A.Paragraph paragraph19 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties16 = new A.ParagraphProperties();

            A.SpaceBefore spaceBefore36 = new A.SpaceBefore();
            A.SpacingPoints spacingPoints11 = new A.SpacingPoints() { Val = 0 };

            spaceBefore36.Append(spacingPoints11);

            A.SpaceAfter spaceAfter26 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints12 = new A.SpacingPoints() { Val = 0 };

            spaceAfter26.Append(spacingPoints12);

            A.BulletColor bulletColor24 = new A.BulletColor();
            A.RgbColorModelHex rgbColorModelHex213 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            bulletColor24.Append(rgbColorModelHex213);
            A.BulletFontText bulletFontText8 = new A.BulletFontText();
            A.NoBullet noBullet8 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties55 = new A.DefaultRunProperties();

            paragraphProperties16.Append(spaceBefore36);
            paragraphProperties16.Append(spaceAfter26);
            paragraphProperties16.Append(bulletColor24);
            paragraphProperties16.Append(bulletFontText8);
            paragraphProperties16.Append(noBullet8);
            paragraphProperties16.Append(defaultRunProperties55);

            A.Run run17 = new A.Run();

            A.RunProperties runProperties20 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "et-EE", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill95 = new A.SolidFill();
            A.SchemeColor schemeColor145 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill95.Append(schemeColor145);
            A.LatinFont latinFont62 = new A.LatinFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };
            A.ComplexScriptFont complexScriptFont42 = new A.ComplexScriptFont() { Typeface = "Arial", PitchFamily = 34, CharacterSet = 0 };

            runProperties20.Append(solidFill95);
            runProperties20.Append(latinFont62);
            runProperties20.Append(complexScriptFont42);
            A.Text text20 = new A.Text();
            text20.Text = $"{item.StartingYear} - {item.EndingYear} {item.Company} - {item.Position}";

            run17.Append(runProperties20);
            run17.Append(text20);

            paragraph19.Append(paragraphProperties16);
            paragraph19.Append(run17);

            return paragraph19;
        }

        private static A.Paragraph CreateMotivationParagraph(MotivationItem item)
        {
            A.Paragraph paragraph39 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties36 = new A.ParagraphProperties();

            A.SpaceAfter spaceAfter58 = new A.SpaceAfter();
            A.SpacingPoints spacingPoints39 = new A.SpacingPoints() { Val = 600 };

            spaceAfter58.Append(spacingPoints39);

            A.BulletColor bulletColor62 = new A.BulletColor();
            A.RgbColorModelHex rgbColorModelHex238 = new A.RgbColorModelHex() { Val = "8EBAE5" };

            bulletColor62.Append(rgbColorModelHex238);

            paragraphProperties36.Append(spaceAfter58);
            paragraphProperties36.Append(bulletColor62);

            A.Run run35 = new A.Run();

            A.RunProperties runProperties38 = new A.RunProperties() { Language = "en-GB", AlternativeLanguage = "lv-LV", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill155 = new A.SolidFill();
            A.SchemeColor schemeColor218 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill155.Append(schemeColor218);

            runProperties38.Append(solidFill155);
            A.Text text38 = new A.Text();
            text38.Text = $"{item.Label}: ";

            run35.Append(runProperties38);
            run35.Append(text38);

            A.Run run37 = new A.Run();

            A.RunProperties runProperties40 = new A.RunProperties() { Language = "en-GB", AlternativeLanguage = "lv-LV", FontSize = 1050, Dirty = false };

            A.SolidFill solidFill157 = new A.SolidFill();
            A.SchemeColor schemeColor220 = new A.SchemeColor() { Val = A.SchemeColorValues.Background1 };

            solidFill157.Append(schemeColor220);

            runProperties40.Append(solidFill157);
            A.Text text40 = new A.Text();
            text40.Text = item.Content;

            run37.Append(runProperties40);
            run37.Append(text40);

            paragraph39.Append(paragraphProperties36);
            paragraph39.Append(run35);
            paragraph39.Append(run37);

            return paragraph39;
        }
    }
}
