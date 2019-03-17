using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Presentation;
using A = DocumentFormat.OpenXml.Drawing;
using P14 = DocumentFormat.OpenXml.Office2010.PowerPoint;
using A14 = DocumentFormat.OpenXml.Office2010.Drawing;

namespace CV.Management.Generation.Ppt.Helpers
{
    public static class GenerateNotesSlidePartHelper
    {
        public static void GenerateNotesSlidePart1Content(NotesSlidePart notesSlidePart1)
        {
            NotesSlide notesSlide1 = new NotesSlide();
            notesSlide1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            notesSlide1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            notesSlide1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData4 = new CommonSlideData();

            ShapeTree shapeTree4 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties4 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties20 = new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties4 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties20 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties4.Append(nonVisualDrawingProperties20);
            nonVisualGroupShapeProperties4.Append(nonVisualGroupShapeDrawingProperties4);
            nonVisualGroupShapeProperties4.Append(applicationNonVisualDrawingProperties20);

            GroupShapeProperties groupShapeProperties4 = new GroupShapeProperties();

            A.TransformGroup transformGroup4 = new A.TransformGroup();
            A.Offset offset22 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents22 = new A.Extents() { Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset4 = new A.ChildOffset() { X = 0L, Y = 0L };
            A.ChildExtents childExtents4 = new A.ChildExtents() { Cx = 0L, Cy = 0L };

            transformGroup4.Append(offset22);
            transformGroup4.Append(extents22);
            transformGroup4.Append(childOffset4);
            transformGroup4.Append(childExtents4);

            groupShapeProperties4.Append(transformGroup4);

            Shape shape16 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties16 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties21 = new NonVisualDrawingProperties() { Id = (UInt32Value)19458U, Name = "Rectangle 7" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties16 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks16 = new A.ShapeLocks() { NoGrouping = true, NoChangeArrowheads = true };

            nonVisualShapeDrawingProperties16.Append(shapeLocks16);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties21 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape11 = new PlaceholderShape() { Type = PlaceholderValues.SlideNumber, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)5U };

            applicationNonVisualDrawingProperties21.Append(placeholderShape11);

            nonVisualShapeProperties16.Append(nonVisualDrawingProperties21);
            nonVisualShapeProperties16.Append(nonVisualShapeDrawingProperties16);
            nonVisualShapeProperties16.Append(applicationNonVisualDrawingProperties21);

            ShapeProperties shapeProperties19 = new ShapeProperties();
            A.NoFill noFill19 = new A.NoFill();
            A.Outline outline33 = new A.Outline();

            A.ShapePropertiesExtensionList shapePropertiesExtensionList7 = new A.ShapePropertiesExtensionList();

            A.ShapePropertiesExtension shapePropertiesExtension7 = new A.ShapePropertiesExtension() { Uri = "{909E8E84-426E-40DD-AFC4-6F175D3DCCD1}" };

            A14.HiddenFillProperties hiddenFillProperties2 = new A14.HiddenFillProperties();
            hiddenFillProperties2.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill158 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex239 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            solidFill158.Append(rgbColorModelHex239);

            hiddenFillProperties2.Append(solidFill158);

            shapePropertiesExtension7.Append(hiddenFillProperties2);

            A.ShapePropertiesExtension shapePropertiesExtension8 = new A.ShapePropertiesExtension() { Uri = "{91240B29-F687-4F45-9708-019B960494DF}" };

            A14.HiddenLineProperties hiddenLineProperties6 = new A14.HiddenLineProperties() { Width = 9525 };
            hiddenLineProperties6.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill159 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex240 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill159.Append(rgbColorModelHex240);
            A.Miter miter15 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd14 = new A.HeadEnd();
            A.TailEnd tailEnd14 = new A.TailEnd();

            hiddenLineProperties6.Append(solidFill159);
            hiddenLineProperties6.Append(miter15);
            hiddenLineProperties6.Append(headEnd14);
            hiddenLineProperties6.Append(tailEnd14);

            shapePropertiesExtension8.Append(hiddenLineProperties6);

            shapePropertiesExtensionList7.Append(shapePropertiesExtension7);
            shapePropertiesExtensionList7.Append(shapePropertiesExtension8);

            shapeProperties19.Append(noFill19);
            shapeProperties19.Append(outline33);
            shapeProperties19.Append(shapePropertiesExtensionList7);

            TextBody textBody15 = new TextBody();
            A.BodyProperties bodyProperties17 = new A.BodyProperties();

            A.ListStyle listStyle17 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties16 = new A.Level1ParagraphProperties();

            A.SpaceBefore spaceBefore74 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent95 = new A.SpacingPercent() { Val = 30000 };

            spaceBefore74.Append(spacingPercent95);

            A.DefaultRunProperties defaultRunProperties95 = new A.DefaultRunProperties() { FontSize = 1200 };

            A.SolidFill solidFill160 = new A.SolidFill();
            A.SchemeColor schemeColor221 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill160.Append(schemeColor221);
            A.LatinFont latinFont112 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont75 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties95.Append(solidFill160);
            defaultRunProperties95.Append(latinFont112);
            defaultRunProperties95.Append(eastAsianFont75);

            level1ParagraphProperties16.Append(spaceBefore74);
            level1ParagraphProperties16.Append(defaultRunProperties95);

            A.Level2ParagraphProperties level2ParagraphProperties8 = new A.Level2ParagraphProperties() { LeftMargin = 735013, Indent = -280988 };

            A.SpaceBefore spaceBefore75 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent96 = new A.SpacingPercent() { Val = 30000 };

            spaceBefore75.Append(spacingPercent96);

            A.DefaultRunProperties defaultRunProperties96 = new A.DefaultRunProperties() { FontSize = 1200 };

            A.SolidFill solidFill161 = new A.SolidFill();
            A.SchemeColor schemeColor222 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill161.Append(schemeColor222);
            A.LatinFont latinFont113 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont76 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties96.Append(solidFill161);
            defaultRunProperties96.Append(latinFont113);
            defaultRunProperties96.Append(eastAsianFont76);

            level2ParagraphProperties8.Append(spaceBefore75);
            level2ParagraphProperties8.Append(defaultRunProperties96);

            A.Level3ParagraphProperties level3ParagraphProperties8 = new A.Level3ParagraphProperties() { LeftMargin = 1131888, Indent = -225425 };

            A.SpaceBefore spaceBefore76 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent97 = new A.SpacingPercent() { Val = 30000 };

            spaceBefore76.Append(spacingPercent97);

            A.DefaultRunProperties defaultRunProperties97 = new A.DefaultRunProperties() { FontSize = 1200 };

            A.SolidFill solidFill162 = new A.SolidFill();
            A.SchemeColor schemeColor223 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill162.Append(schemeColor223);
            A.LatinFont latinFont114 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont77 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties97.Append(solidFill162);
            defaultRunProperties97.Append(latinFont114);
            defaultRunProperties97.Append(eastAsianFont77);

            level3ParagraphProperties8.Append(spaceBefore76);
            level3ParagraphProperties8.Append(defaultRunProperties97);

            A.Level4ParagraphProperties level4ParagraphProperties8 = new A.Level4ParagraphProperties() { LeftMargin = 1585913, Indent = -225425 };

            A.SpaceBefore spaceBefore77 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent98 = new A.SpacingPercent() { Val = 30000 };

            spaceBefore77.Append(spacingPercent98);

            A.DefaultRunProperties defaultRunProperties98 = new A.DefaultRunProperties() { FontSize = 1200 };

            A.SolidFill solidFill163 = new A.SolidFill();
            A.SchemeColor schemeColor224 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill163.Append(schemeColor224);
            A.LatinFont latinFont115 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont78 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties98.Append(solidFill163);
            defaultRunProperties98.Append(latinFont115);
            defaultRunProperties98.Append(eastAsianFont78);

            level4ParagraphProperties8.Append(spaceBefore77);
            level4ParagraphProperties8.Append(defaultRunProperties98);

            A.Level5ParagraphProperties level5ParagraphProperties8 = new A.Level5ParagraphProperties() { LeftMargin = 2038350, Indent = -225425 };

            A.SpaceBefore spaceBefore78 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent99 = new A.SpacingPercent() { Val = 30000 };

            spaceBefore78.Append(spacingPercent99);

            A.DefaultRunProperties defaultRunProperties99 = new A.DefaultRunProperties() { FontSize = 1200 };

            A.SolidFill solidFill164 = new A.SolidFill();
            A.SchemeColor schemeColor225 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill164.Append(schemeColor225);
            A.LatinFont latinFont116 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont79 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties99.Append(solidFill164);
            defaultRunProperties99.Append(latinFont116);
            defaultRunProperties99.Append(eastAsianFont79);

            level5ParagraphProperties8.Append(spaceBefore78);
            level5ParagraphProperties8.Append(defaultRunProperties99);

            A.Level6ParagraphProperties level6ParagraphProperties8 = new A.Level6ParagraphProperties() { LeftMargin = 2495550, Indent = -225425, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore79 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent100 = new A.SpacingPercent() { Val = 30000 };

            spaceBefore79.Append(spacingPercent100);

            A.SpaceAfter spaceAfter59 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent101 = new A.SpacingPercent() { Val = 0 };

            spaceAfter59.Append(spacingPercent101);

            A.DefaultRunProperties defaultRunProperties100 = new A.DefaultRunProperties() { FontSize = 1200 };

            A.SolidFill solidFill165 = new A.SolidFill();
            A.SchemeColor schemeColor226 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill165.Append(schemeColor226);
            A.LatinFont latinFont117 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont80 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties100.Append(solidFill165);
            defaultRunProperties100.Append(latinFont117);
            defaultRunProperties100.Append(eastAsianFont80);

            level6ParagraphProperties8.Append(spaceBefore79);
            level6ParagraphProperties8.Append(spaceAfter59);
            level6ParagraphProperties8.Append(defaultRunProperties100);

            A.Level7ParagraphProperties level7ParagraphProperties8 = new A.Level7ParagraphProperties() { LeftMargin = 2952750, Indent = -225425, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore80 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent102 = new A.SpacingPercent() { Val = 30000 };

            spaceBefore80.Append(spacingPercent102);

            A.SpaceAfter spaceAfter60 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent103 = new A.SpacingPercent() { Val = 0 };

            spaceAfter60.Append(spacingPercent103);

            A.DefaultRunProperties defaultRunProperties101 = new A.DefaultRunProperties() { FontSize = 1200 };

            A.SolidFill solidFill166 = new A.SolidFill();
            A.SchemeColor schemeColor227 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill166.Append(schemeColor227);
            A.LatinFont latinFont118 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont81 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties101.Append(solidFill166);
            defaultRunProperties101.Append(latinFont118);
            defaultRunProperties101.Append(eastAsianFont81);

            level7ParagraphProperties8.Append(spaceBefore80);
            level7ParagraphProperties8.Append(spaceAfter60);
            level7ParagraphProperties8.Append(defaultRunProperties101);

            A.Level8ParagraphProperties level8ParagraphProperties8 = new A.Level8ParagraphProperties() { LeftMargin = 3409950, Indent = -225425, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore81 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent104 = new A.SpacingPercent() { Val = 30000 };

            spaceBefore81.Append(spacingPercent104);

            A.SpaceAfter spaceAfter61 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent105 = new A.SpacingPercent() { Val = 0 };

            spaceAfter61.Append(spacingPercent105);

            A.DefaultRunProperties defaultRunProperties102 = new A.DefaultRunProperties() { FontSize = 1200 };

            A.SolidFill solidFill167 = new A.SolidFill();
            A.SchemeColor schemeColor228 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill167.Append(schemeColor228);
            A.LatinFont latinFont119 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont82 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties102.Append(solidFill167);
            defaultRunProperties102.Append(latinFont119);
            defaultRunProperties102.Append(eastAsianFont82);

            level8ParagraphProperties8.Append(spaceBefore81);
            level8ParagraphProperties8.Append(spaceAfter61);
            level8ParagraphProperties8.Append(defaultRunProperties102);

            A.Level9ParagraphProperties level9ParagraphProperties8 = new A.Level9ParagraphProperties() { LeftMargin = 3867150, Indent = -225425, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, Height = false };

            A.SpaceBefore spaceBefore82 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent106 = new A.SpacingPercent() { Val = 30000 };

            spaceBefore82.Append(spacingPercent106);

            A.SpaceAfter spaceAfter62 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent107 = new A.SpacingPercent() { Val = 0 };

            spaceAfter62.Append(spacingPercent107);

            A.DefaultRunProperties defaultRunProperties103 = new A.DefaultRunProperties() { FontSize = 1200 };

            A.SolidFill solidFill168 = new A.SolidFill();
            A.SchemeColor schemeColor229 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill168.Append(schemeColor229);
            A.LatinFont latinFont120 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };
            A.EastAsianFont eastAsianFont83 = new A.EastAsianFont() { Typeface = "MS PGothic", Panose = "020B0600070205080204", PitchFamily = 34, CharacterSet = -128 };

            defaultRunProperties103.Append(solidFill168);
            defaultRunProperties103.Append(latinFont120);
            defaultRunProperties103.Append(eastAsianFont83);

            level9ParagraphProperties8.Append(spaceBefore82);
            level9ParagraphProperties8.Append(spaceAfter62);
            level9ParagraphProperties8.Append(defaultRunProperties103);

            listStyle17.Append(level1ParagraphProperties16);
            listStyle17.Append(level2ParagraphProperties8);
            listStyle17.Append(level3ParagraphProperties8);
            listStyle17.Append(level4ParagraphProperties8);
            listStyle17.Append(level5ParagraphProperties8);
            listStyle17.Append(level6ParagraphProperties8);
            listStyle17.Append(level7ParagraphProperties8);
            listStyle17.Append(level8ParagraphProperties8);
            listStyle17.Append(level9ParagraphProperties8);

            A.Paragraph paragraph40 = new A.Paragraph();

            A.ParagraphProperties paragraphProperties37 = new A.ParagraphProperties();

            A.SpaceBefore spaceBefore83 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent108 = new A.SpacingPercent() { Val = 0 };

            spaceBefore83.Append(spacingPercent108);

            paragraphProperties37.Append(spaceBefore83);

            A.Field field4 = new A.Field() { Id = "{99BBE751-775A-442D-AED5-C8FC60817C7D}", Type = "slidenum" };

            A.RunProperties runProperties41 = new A.RunProperties() { Language = "en-US", AlternativeLanguage = "et-EE" };
            runProperties41.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));
            A.ComplexScriptFont complexScriptFont61 = new A.ComplexScriptFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };

            runProperties41.Append(complexScriptFont61);

            A.ParagraphProperties paragraphProperties38 = new A.ParagraphProperties();

            A.SpaceBefore spaceBefore84 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent109 = new A.SpacingPercent() { Val = 0 };

            spaceBefore84.Append(spacingPercent109);

            paragraphProperties38.Append(spaceBefore84);
            A.Text text41 = new A.Text();
            text41.Text = "1";

            field4.Append(runProperties41);
            field4.Append(paragraphProperties38);
            field4.Append(text41);

            A.EndParagraphRunProperties endParagraphRunProperties21 = new A.EndParagraphRunProperties() { Language = "en-US", AlternativeLanguage = "et-EE" };
            A.ComplexScriptFont complexScriptFont62 = new A.ComplexScriptFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };

            endParagraphRunProperties21.Append(complexScriptFont62);

            paragraph40.Append(paragraphProperties37);
            paragraph40.Append(field4);
            paragraph40.Append(endParagraphRunProperties21);

            textBody15.Append(bodyProperties17);
            textBody15.Append(listStyle17);
            textBody15.Append(paragraph40);

            shape16.Append(nonVisualShapeProperties16);
            shape16.Append(shapeProperties19);
            shape16.Append(textBody15);

            Shape shape17 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties17 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties22 = new NonVisualDrawingProperties() { Id = (UInt32Value)19459U, Name = "Rectangle 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties17 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks17 = new A.ShapeLocks() { NoGrouping = true, NoRotation = true, NoChangeAspect = true, NoChangeArrowheads = true, NoTextEdit = true };

            nonVisualShapeDrawingProperties17.Append(shapeLocks17);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties22 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape12 = new PlaceholderShape() { Type = PlaceholderValues.SlideImage };

            applicationNonVisualDrawingProperties22.Append(placeholderShape12);

            nonVisualShapeProperties17.Append(nonVisualDrawingProperties22);
            nonVisualShapeProperties17.Append(nonVisualShapeDrawingProperties17);
            nonVisualShapeProperties17.Append(applicationNonVisualDrawingProperties22);

            ShapeProperties shapeProperties20 = new ShapeProperties();
            A.Outline outline34 = new A.Outline();

            shapeProperties20.Append(outline34);

            shape17.Append(nonVisualShapeProperties17);
            shape17.Append(shapeProperties20);

            Shape shape18 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties18 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties23 = new NonVisualDrawingProperties() { Id = (UInt32Value)19460U, Name = "Rectangle 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties18 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks18 = new A.ShapeLocks() { NoGrouping = true, NoChangeArrowheads = true };

            nonVisualShapeDrawingProperties18.Append(shapeLocks18);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties23 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape13 = new PlaceholderShape() { Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties23.Append(placeholderShape13);

            nonVisualShapeProperties18.Append(nonVisualDrawingProperties23);
            nonVisualShapeProperties18.Append(nonVisualShapeDrawingProperties18);
            nonVisualShapeProperties18.Append(applicationNonVisualDrawingProperties23);

            ShapeProperties shapeProperties21 = new ShapeProperties();
            A.NoFill noFill20 = new A.NoFill();
            A.Outline outline35 = new A.Outline();

            A.ShapePropertiesExtensionList shapePropertiesExtensionList8 = new A.ShapePropertiesExtensionList();

            A.ShapePropertiesExtension shapePropertiesExtension9 = new A.ShapePropertiesExtension() { Uri = "{909E8E84-426E-40DD-AFC4-6F175D3DCCD1}" };

            A14.HiddenFillProperties hiddenFillProperties3 = new A14.HiddenFillProperties();
            hiddenFillProperties3.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill169 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex241 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            solidFill169.Append(rgbColorModelHex241);

            hiddenFillProperties3.Append(solidFill169);

            shapePropertiesExtension9.Append(hiddenFillProperties3);

            A.ShapePropertiesExtension shapePropertiesExtension10 = new A.ShapePropertiesExtension() { Uri = "{91240B29-F687-4F45-9708-019B960494DF}" };

            A14.HiddenLineProperties hiddenLineProperties7 = new A14.HiddenLineProperties() { Width = 9525 };
            hiddenLineProperties7.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill170 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex242 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill170.Append(rgbColorModelHex242);
            A.Miter miter16 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd15 = new A.HeadEnd();
            A.TailEnd tailEnd15 = new A.TailEnd();

            hiddenLineProperties7.Append(solidFill170);
            hiddenLineProperties7.Append(miter16);
            hiddenLineProperties7.Append(headEnd15);
            hiddenLineProperties7.Append(tailEnd15);

            shapePropertiesExtension10.Append(hiddenLineProperties7);

            shapePropertiesExtensionList8.Append(shapePropertiesExtension9);
            shapePropertiesExtensionList8.Append(shapePropertiesExtension10);

            shapeProperties21.Append(noFill20);
            shapeProperties21.Append(outline35);
            shapeProperties21.Append(shapePropertiesExtensionList8);

            TextBody textBody16 = new TextBody();
            A.BodyProperties bodyProperties18 = new A.BodyProperties();
            A.ListStyle listStyle18 = new A.ListStyle();

            A.Paragraph paragraph41 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties39 = new A.ParagraphProperties() { EastAsianLineBreak = true, Height = true };

            A.EndParagraphRunProperties endParagraphRunProperties22 = new A.EndParagraphRunProperties() { Language = "lv-LV", AlternativeLanguage = "et-EE" };
            A.LatinFont latinFont121 = new A.LatinFont() { Typeface = "Arial", Panose = "020B0604020202020204", PitchFamily = 34, CharacterSet = 0 };

            endParagraphRunProperties22.Append(latinFont121);

            paragraph41.Append(paragraphProperties39);
            paragraph41.Append(endParagraphRunProperties22);

            textBody16.Append(bodyProperties18);
            textBody16.Append(listStyle18);
            textBody16.Append(paragraph41);

            shape18.Append(nonVisualShapeProperties18);
            shape18.Append(shapeProperties21);
            shape18.Append(textBody16);

            shapeTree4.Append(nonVisualGroupShapeProperties4);
            shapeTree4.Append(groupShapeProperties4);
            shapeTree4.Append(shape16);
            shapeTree4.Append(shape17);
            shapeTree4.Append(shape18);

            CommonSlideDataExtensionList commonSlideDataExtensionList4 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension4 = new CommonSlideDataExtension() { Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId4 = new P14.CreationId() { Val = (UInt32Value)4141007346U };
            creationId4.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension4.Append(creationId4);

            commonSlideDataExtensionList4.Append(commonSlideDataExtension4);

            commonSlideData4.Append(shapeTree4);
            commonSlideData4.Append(commonSlideDataExtensionList4);

            ColorMapOverride colorMapOverride2 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping2 = new A.MasterColorMapping();

            colorMapOverride2.Append(masterColorMapping2);

            notesSlide1.Append(commonSlideData4);
            notesSlide1.Append(colorMapOverride2);

            notesSlidePart1.NotesSlide = notesSlide1;
        }
    }
}
