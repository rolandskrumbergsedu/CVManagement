using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Presentation;
using A = DocumentFormat.OpenXml.Drawing;
using P15 = DocumentFormat.OpenXml.Office2013.PowerPoint;

namespace CV.Management.Generation.Ppt.Helpers
{
    public static class GeneratePresentationPartHelper
    {
        public static void GeneratePresentationPart1Content(PresentationPart presentationPart1)
        {
            Presentation presentation1 = new Presentation() { ShowSpecialPlaceholderOnTitleSlide = false, RemovePersonalInfoOnSave = true, StrictFirstAndLastChars = false, SaveSubsetFonts = true };
            presentation1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            presentation1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            presentation1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            SlideMasterIdList slideMasterIdList1 = new SlideMasterIdList();
            SlideMasterId slideMasterId1 = new SlideMasterId() { Id = (UInt32Value)2147483648U, RelationshipId = "rId4" };

            slideMasterIdList1.Append(slideMasterId1);

            NotesMasterIdList notesMasterIdList1 = new NotesMasterIdList();
            NotesMasterId notesMasterId1 = new NotesMasterId() { Id = "rId6" };

            notesMasterIdList1.Append(notesMasterId1);

            HandoutMasterIdList handoutMasterIdList1 = new HandoutMasterIdList();
            HandoutMasterId handoutMasterId1 = new HandoutMasterId() { Id = "rId7" };

            handoutMasterIdList1.Append(handoutMasterId1);

            SlideIdList slideIdList1 = new SlideIdList();
            SlideId slideId1 = new SlideId() { Id = (UInt32Value)371U, RelationshipId = "rId5" };

            slideIdList1.Append(slideId1);
            SlideSize slideSize1 = new SlideSize() { Cx = 9906000, Cy = 6858000, Type = SlideSizeValues.A4 };
            NotesSize notesSize1 = new NotesSize() { Cx = 6797675L, Cy = 9874250L };

            DefaultTextStyle defaultTextStyle1 = new DefaultTextStyle();

            A.DefaultParagraphProperties defaultParagraphProperties1 = new A.DefaultParagraphProperties();
            A.DefaultRunProperties defaultRunProperties1 = new A.DefaultRunProperties() { Language = "en-US" };

            defaultParagraphProperties1.Append(defaultRunProperties1);

            A.Level1ParagraphProperties level1ParagraphProperties1 = new A.Level1ParagraphProperties() { Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore1 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent1 = new A.SpacingPercent() { Val = 0 };

            spaceBefore1.Append(spacingPercent1);

            A.SpaceAfter spaceAfter1 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent2 = new A.SpacingPercent() { Val = 0 };

            spaceAfter1.Append(spacingPercent2);

            A.DefaultRunProperties defaultRunProperties2 = new A.DefaultRunProperties() { FontSize = 2400, Kerning = 1200 };

            A.SolidFill solidFill1 = new A.SolidFill();
            A.SchemeColor schemeColor1 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill1.Append(schemeColor1);
            A.LatinFont latinFont1 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont1 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont1 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties2.Append(solidFill1);
            defaultRunProperties2.Append(latinFont1);
            defaultRunProperties2.Append(eastAsianFont1);
            defaultRunProperties2.Append(complexScriptFont1);

            level1ParagraphProperties1.Append(spaceBefore1);
            level1ParagraphProperties1.Append(spaceAfter1);
            level1ParagraphProperties1.Append(defaultRunProperties2);

            A.Level2ParagraphProperties level2ParagraphProperties1 = new A.Level2ParagraphProperties() { LeftMargin = 457200, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore2 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent3 = new A.SpacingPercent() { Val = 0 };

            spaceBefore2.Append(spacingPercent3);

            A.SpaceAfter spaceAfter2 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent4 = new A.SpacingPercent() { Val = 0 };

            spaceAfter2.Append(spacingPercent4);

            A.DefaultRunProperties defaultRunProperties3 = new A.DefaultRunProperties() { FontSize = 2400, Kerning = 1200 };

            A.SolidFill solidFill2 = new A.SolidFill();
            A.SchemeColor schemeColor2 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill2.Append(schemeColor2);
            A.LatinFont latinFont2 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont2 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont2 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties3.Append(solidFill2);
            defaultRunProperties3.Append(latinFont2);
            defaultRunProperties3.Append(eastAsianFont2);
            defaultRunProperties3.Append(complexScriptFont2);

            level2ParagraphProperties1.Append(spaceBefore2);
            level2ParagraphProperties1.Append(spaceAfter2);
            level2ParagraphProperties1.Append(defaultRunProperties3);

            A.Level3ParagraphProperties level3ParagraphProperties1 = new A.Level3ParagraphProperties() { LeftMargin = 914400, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore3 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent5 = new A.SpacingPercent() { Val = 0 };

            spaceBefore3.Append(spacingPercent5);

            A.SpaceAfter spaceAfter3 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent6 = new A.SpacingPercent() { Val = 0 };

            spaceAfter3.Append(spacingPercent6);

            A.DefaultRunProperties defaultRunProperties4 = new A.DefaultRunProperties() { FontSize = 2400, Kerning = 1200 };

            A.SolidFill solidFill3 = new A.SolidFill();
            A.SchemeColor schemeColor3 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill3.Append(schemeColor3);
            A.LatinFont latinFont3 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont3 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont3 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties4.Append(solidFill3);
            defaultRunProperties4.Append(latinFont3);
            defaultRunProperties4.Append(eastAsianFont3);
            defaultRunProperties4.Append(complexScriptFont3);

            level3ParagraphProperties1.Append(spaceBefore3);
            level3ParagraphProperties1.Append(spaceAfter3);
            level3ParagraphProperties1.Append(defaultRunProperties4);

            A.Level4ParagraphProperties level4ParagraphProperties1 = new A.Level4ParagraphProperties() { LeftMargin = 1371600, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore4 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent7 = new A.SpacingPercent() { Val = 0 };

            spaceBefore4.Append(spacingPercent7);

            A.SpaceAfter spaceAfter4 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent8 = new A.SpacingPercent() { Val = 0 };

            spaceAfter4.Append(spacingPercent8);

            A.DefaultRunProperties defaultRunProperties5 = new A.DefaultRunProperties() { FontSize = 2400, Kerning = 1200 };

            A.SolidFill solidFill4 = new A.SolidFill();
            A.SchemeColor schemeColor4 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill4.Append(schemeColor4);
            A.LatinFont latinFont4 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont4 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont4 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties5.Append(solidFill4);
            defaultRunProperties5.Append(latinFont4);
            defaultRunProperties5.Append(eastAsianFont4);
            defaultRunProperties5.Append(complexScriptFont4);

            level4ParagraphProperties1.Append(spaceBefore4);
            level4ParagraphProperties1.Append(spaceAfter4);
            level4ParagraphProperties1.Append(defaultRunProperties5);

            A.Level5ParagraphProperties level5ParagraphProperties1 = new A.Level5ParagraphProperties() { LeftMargin = 1828800, Alignment = A.TextAlignmentTypeValues.Left, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore5 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent9 = new A.SpacingPercent() { Val = 0 };

            spaceBefore5.Append(spacingPercent9);

            A.SpaceAfter spaceAfter5 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent10 = new A.SpacingPercent() { Val = 0 };

            spaceAfter5.Append(spacingPercent10);

            A.DefaultRunProperties defaultRunProperties6 = new A.DefaultRunProperties() { FontSize = 2400, Kerning = 1200 };

            A.SolidFill solidFill5 = new A.SolidFill();
            A.SchemeColor schemeColor5 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill5.Append(schemeColor5);
            A.LatinFont latinFont5 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont5 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont5 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties6.Append(solidFill5);
            defaultRunProperties6.Append(latinFont5);
            defaultRunProperties6.Append(eastAsianFont5);
            defaultRunProperties6.Append(complexScriptFont5);

            level5ParagraphProperties1.Append(spaceBefore5);
            level5ParagraphProperties1.Append(spaceAfter5);
            level5ParagraphProperties1.Append(defaultRunProperties6);

            A.Level6ParagraphProperties level6ParagraphProperties1 = new A.Level6ParagraphProperties() { LeftMargin = 2286000, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties7 = new A.DefaultRunProperties() { FontSize = 2400, Kerning = 1200 };

            A.SolidFill solidFill6 = new A.SolidFill();
            A.SchemeColor schemeColor6 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill6.Append(schemeColor6);
            A.LatinFont latinFont6 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont6 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont6 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties7.Append(solidFill6);
            defaultRunProperties7.Append(latinFont6);
            defaultRunProperties7.Append(eastAsianFont6);
            defaultRunProperties7.Append(complexScriptFont6);

            level6ParagraphProperties1.Append(defaultRunProperties7);

            A.Level7ParagraphProperties level7ParagraphProperties1 = new A.Level7ParagraphProperties() { LeftMargin = 2743200, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties8 = new A.DefaultRunProperties() { FontSize = 2400, Kerning = 1200 };

            A.SolidFill solidFill7 = new A.SolidFill();
            A.SchemeColor schemeColor7 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill7.Append(schemeColor7);
            A.LatinFont latinFont7 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont7 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont7 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties8.Append(solidFill7);
            defaultRunProperties8.Append(latinFont7);
            defaultRunProperties8.Append(eastAsianFont7);
            defaultRunProperties8.Append(complexScriptFont7);

            level7ParagraphProperties1.Append(defaultRunProperties8);

            A.Level8ParagraphProperties level8ParagraphProperties1 = new A.Level8ParagraphProperties() { LeftMargin = 3200400, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties9 = new A.DefaultRunProperties() { FontSize = 2400, Kerning = 1200 };

            A.SolidFill solidFill8 = new A.SolidFill();
            A.SchemeColor schemeColor8 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill8.Append(schemeColor8);
            A.LatinFont latinFont8 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont8 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont8 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties9.Append(solidFill8);
            defaultRunProperties9.Append(latinFont8);
            defaultRunProperties9.Append(eastAsianFont8);
            defaultRunProperties9.Append(complexScriptFont8);

            level8ParagraphProperties1.Append(defaultRunProperties9);

            A.Level9ParagraphProperties level9ParagraphProperties1 = new A.Level9ParagraphProperties() { LeftMargin = 3657600, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = true, LatinLineBreak = false, Height = true };

            A.DefaultRunProperties defaultRunProperties10 = new A.DefaultRunProperties() { FontSize = 2400, Kerning = 1200 };

            A.SolidFill solidFill9 = new A.SolidFill();
            A.SchemeColor schemeColor9 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill9.Append(schemeColor9);
            A.LatinFont latinFont9 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont9 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };
            A.ComplexScriptFont complexScriptFont9 = new A.ComplexScriptFont() { Typeface = "+mn-cs" };

            defaultRunProperties10.Append(solidFill9);
            defaultRunProperties10.Append(latinFont9);
            defaultRunProperties10.Append(eastAsianFont9);
            defaultRunProperties10.Append(complexScriptFont9);

            level9ParagraphProperties1.Append(defaultRunProperties10);

            defaultTextStyle1.Append(defaultParagraphProperties1);
            defaultTextStyle1.Append(level1ParagraphProperties1);
            defaultTextStyle1.Append(level2ParagraphProperties1);
            defaultTextStyle1.Append(level3ParagraphProperties1);
            defaultTextStyle1.Append(level4ParagraphProperties1);
            defaultTextStyle1.Append(level5ParagraphProperties1);
            defaultTextStyle1.Append(level6ParagraphProperties1);
            defaultTextStyle1.Append(level7ParagraphProperties1);
            defaultTextStyle1.Append(level8ParagraphProperties1);
            defaultTextStyle1.Append(level9ParagraphProperties1);

            PresentationExtensionList presentationExtensionList1 = new PresentationExtensionList();

            PresentationExtension presentationExtension1 = new PresentationExtension() { Uri = "{EFAFB233-063F-42B5-8137-9DF3F51BA10A}" };

            P15.SlideGuideList slideGuideList1 = new P15.SlideGuideList();
            slideGuideList1.AddNamespaceDeclaration("p15", "http://schemas.microsoft.com/office/powerpoint/2012/main");

            P15.ExtendedGuide extendedGuide1 = new P15.ExtendedGuide() { Id = (UInt32Value)1U, Orientation = DirectionValues.Horizontal, Position = 240 };

            P15.ColorType colorType1 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex1 = new A.RgbColorModelHex() { Val = "A4A3A4" };

            colorType1.Append(rgbColorModelHex1);

            extendedGuide1.Append(colorType1);

            P15.ExtendedGuide extendedGuide2 = new P15.ExtendedGuide() { Id = (UInt32Value)2U, Orientation = DirectionValues.Horizontal, Position = 3648, IsUserDrawn = true };

            P15.ColorType colorType2 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex2 = new A.RgbColorModelHex() { Val = "A4A3A4" };

            colorType2.Append(rgbColorModelHex2);

            extendedGuide2.Append(colorType2);

            P15.ExtendedGuide extendedGuide3 = new P15.ExtendedGuide() { Id = (UInt32Value)4U, Position = 2736, IsUserDrawn = true };

            P15.ColorType colorType3 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex3 = new A.RgbColorModelHex() { Val = "A4A3A4" };

            colorType3.Append(rgbColorModelHex3);

            extendedGuide3.Append(colorType3);

            P15.ExtendedGuide extendedGuide4 = new P15.ExtendedGuide() { Id = (UInt32Value)5U, Position = 5904 };

            P15.ColorType colorType4 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex4 = new A.RgbColorModelHex() { Val = "A4A3A4" };

            colorType4.Append(rgbColorModelHex4);

            extendedGuide4.Append(colorType4);

            P15.ExtendedGuide extendedGuide5 = new P15.ExtendedGuide() { Id = (UInt32Value)6U, Position = 336 };

            P15.ColorType colorType5 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex5 = new A.RgbColorModelHex() { Val = "A4A3A4" };

            colorType5.Append(rgbColorModelHex5);

            extendedGuide5.Append(colorType5);

            P15.ExtendedGuide extendedGuide6 = new P15.ExtendedGuide() { Id = (UInt32Value)7U, Orientation = DirectionValues.Horizontal, IsUserDrawn = true };

            P15.ColorType colorType6 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex6 = new A.RgbColorModelHex() { Val = "A4A3A4" };

            colorType6.Append(rgbColorModelHex6);

            extendedGuide6.Append(colorType6);

            P15.ExtendedGuide extendedGuide7 = new P15.ExtendedGuide() { Id = (UInt32Value)8U, Orientation = DirectionValues.Horizontal, Position = 1152, IsUserDrawn = true };

            P15.ColorType colorType7 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex7 = new A.RgbColorModelHex() { Val = "A4A3A4" };

            colorType7.Append(rgbColorModelHex7);

            extendedGuide7.Append(colorType7);

            P15.ExtendedGuide extendedGuide8 = new P15.ExtendedGuide() { Id = (UInt32Value)9U, Orientation = DirectionValues.Horizontal, Position = 1200, IsUserDrawn = true };

            P15.ColorType colorType8 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex8 = new A.RgbColorModelHex() { Val = "A4A3A4" };

            colorType8.Append(rgbColorModelHex8);

            extendedGuide8.Append(colorType8);

            P15.ExtendedGuide extendedGuide9 = new P15.ExtendedGuide() { Id = (UInt32Value)10U, Position = 2784, IsUserDrawn = true };

            P15.ColorType colorType9 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex9 = new A.RgbColorModelHex() { Val = "A4A3A4" };

            colorType9.Append(rgbColorModelHex9);

            extendedGuide9.Append(colorType9);

            P15.ExtendedGuide extendedGuide10 = new P15.ExtendedGuide() { Id = (UInt32Value)12U, Orientation = DirectionValues.Horizontal, Position = 2448, IsUserDrawn = true };

            P15.ColorType colorType10 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex10 = new A.RgbColorModelHex() { Val = "A4A3A4" };

            colorType10.Append(rgbColorModelHex10);

            extendedGuide10.Append(colorType10);

            P15.ExtendedGuide extendedGuide11 = new P15.ExtendedGuide() { Id = (UInt32Value)13U, Orientation = DirectionValues.Horizontal, Position = 2496, IsUserDrawn = true };

            P15.ColorType colorType11 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex11 = new A.RgbColorModelHex() { Val = "A4A3A4" };

            colorType11.Append(rgbColorModelHex11);

            extendedGuide11.Append(colorType11);

            P15.ExtendedGuide extendedGuide12 = new P15.ExtendedGuide() { Id = (UInt32Value)14U, Position = 1872, IsUserDrawn = true };

            P15.ColorType colorType12 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex12 = new A.RgbColorModelHex() { Val = "A4A3A4" };

            colorType12.Append(rgbColorModelHex12);

            extendedGuide12.Append(colorType12);

            P15.ExtendedGuide extendedGuide13 = new P15.ExtendedGuide() { Id = (UInt32Value)15U, Position = 2688, IsUserDrawn = true };

            P15.ColorType colorType13 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex13 = new A.RgbColorModelHex() { Val = "A4A3A4" };

            colorType13.Append(rgbColorModelHex13);

            extendedGuide13.Append(colorType13);

            P15.ExtendedGuide extendedGuide14 = new P15.ExtendedGuide() { Id = (UInt32Value)16U, Orientation = DirectionValues.Horizontal, Position = 288, IsUserDrawn = true };

            P15.ColorType colorType14 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex14 = new A.RgbColorModelHex() { Val = "A4A3A4" };

            colorType14.Append(rgbColorModelHex14);

            extendedGuide14.Append(colorType14);

            P15.ExtendedGuide extendedGuide15 = new P15.ExtendedGuide() { Id = (UInt32Value)17U, Orientation = DirectionValues.Horizontal, Position = 1104, IsUserDrawn = true };

            P15.ColorType colorType15 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex15 = new A.RgbColorModelHex() { Val = "A4A3A4" };

            colorType15.Append(rgbColorModelHex15);

            extendedGuide15.Append(colorType15);

            slideGuideList1.Append(extendedGuide1);
            slideGuideList1.Append(extendedGuide2);
            slideGuideList1.Append(extendedGuide3);
            slideGuideList1.Append(extendedGuide4);
            slideGuideList1.Append(extendedGuide5);
            slideGuideList1.Append(extendedGuide6);
            slideGuideList1.Append(extendedGuide7);
            slideGuideList1.Append(extendedGuide8);
            slideGuideList1.Append(extendedGuide9);
            slideGuideList1.Append(extendedGuide10);
            slideGuideList1.Append(extendedGuide11);
            slideGuideList1.Append(extendedGuide12);
            slideGuideList1.Append(extendedGuide13);
            slideGuideList1.Append(extendedGuide14);
            slideGuideList1.Append(extendedGuide15);

            presentationExtension1.Append(slideGuideList1);

            PresentationExtension presentationExtension2 = new PresentationExtension() { Uri = "{2D200454-40CA-4A62-9FC3-DE9A4176ACB9}" };

            P15.NotesGuideList notesGuideList1 = new P15.NotesGuideList();
            notesGuideList1.AddNamespaceDeclaration("p15", "http://schemas.microsoft.com/office/powerpoint/2012/main");

            P15.ExtendedGuide extendedGuide16 = new P15.ExtendedGuide() { Id = (UInt32Value)1U, Orientation = DirectionValues.Horizontal, Position = 3110, IsUserDrawn = true };

            P15.ColorType colorType16 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex16 = new A.RgbColorModelHex() { Val = "A4A3A4" };

            colorType16.Append(rgbColorModelHex16);

            extendedGuide16.Append(colorType16);

            P15.ExtendedGuide extendedGuide17 = new P15.ExtendedGuide() { Id = (UInt32Value)2U, Position = 2140, IsUserDrawn = true };

            P15.ColorType colorType17 = new P15.ColorType();
            A.RgbColorModelHex rgbColorModelHex17 = new A.RgbColorModelHex() { Val = "A4A3A4" };

            colorType17.Append(rgbColorModelHex17);

            extendedGuide17.Append(colorType17);

            notesGuideList1.Append(extendedGuide16);
            notesGuideList1.Append(extendedGuide17);

            presentationExtension2.Append(notesGuideList1);

            presentationExtensionList1.Append(presentationExtension1);
            presentationExtensionList1.Append(presentationExtension2);

            presentation1.Append(slideMasterIdList1);
            presentation1.Append(notesMasterIdList1);
            presentation1.Append(handoutMasterIdList1);
            presentation1.Append(slideIdList1);
            presentation1.Append(slideSize1);
            presentation1.Append(notesSize1);
            presentation1.Append(defaultTextStyle1);
            presentation1.Append(presentationExtensionList1);

            presentationPart1.Presentation = presentation1;
        }
    }
}
