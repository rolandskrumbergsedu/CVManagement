using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Packaging;

namespace CV.Management.Generation.Word.Helpers
{
    public static class ThemePartHelper
    {
        public static void GenerateThemePart1Content(ThemePart themePart1)
        {
            var theme1 = new DocumentFormat.OpenXml.Drawing.Theme() { Name = "Office Theme" };
            theme1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            var themeElements1 = new DocumentFormat.OpenXml.Drawing.ThemeElements();

            var colorScheme1 = new DocumentFormat.OpenXml.Drawing.ColorScheme { Name = "Office" };

            var dark1Color1 = new DocumentFormat.OpenXml.Drawing.Dark1Color();
            var systemColor1 = new DocumentFormat.OpenXml.Drawing.SystemColor { Val = DocumentFormat.OpenXml.Drawing.SystemColorValues.WindowText, LastColor = "000000" };

            dark1Color1.Append(systemColor1);

            var light1Color1 = new DocumentFormat.OpenXml.Drawing.Light1Color();
            var systemColor2 = new DocumentFormat.OpenXml.Drawing.SystemColor { Val = DocumentFormat.OpenXml.Drawing.SystemColorValues.Window, LastColor = "FFFFFF" };

            light1Color1.Append(systemColor2);

            var dark2Color1 = new DocumentFormat.OpenXml.Drawing.Dark2Color();
            var rgbColorModelHex1 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "1F497D" };

            dark2Color1.Append(rgbColorModelHex1);

            var light2Color1 = new DocumentFormat.OpenXml.Drawing.Light2Color();
            var rgbColorModelHex2 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "EEECE1" };

            light2Color1.Append(rgbColorModelHex2);

            var accent1Color1 = new DocumentFormat.OpenXml.Drawing.Accent1Color();
            var rgbColorModelHex3 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "4F81BD" };

            accent1Color1.Append(rgbColorModelHex3);

            var accent2Color1 = new DocumentFormat.OpenXml.Drawing.Accent2Color();
            var rgbColorModelHex4 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "C0504D" };

            accent2Color1.Append(rgbColorModelHex4);

            var accent3Color1 = new DocumentFormat.OpenXml.Drawing.Accent3Color();
            var rgbColorModelHex5 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "9BBB59" };

            accent3Color1.Append(rgbColorModelHex5);

            var accent4Color1 = new DocumentFormat.OpenXml.Drawing.Accent4Color();
            var rgbColorModelHex6 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "8064A2" };

            accent4Color1.Append(rgbColorModelHex6);

            var accent5Color1 = new DocumentFormat.OpenXml.Drawing.Accent5Color();
            var rgbColorModelHex7 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "4BACC6" };

            accent5Color1.Append(rgbColorModelHex7);

            var accent6Color1 = new DocumentFormat.OpenXml.Drawing.Accent6Color();
            var rgbColorModelHex8 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "F79646" };

            accent6Color1.Append(rgbColorModelHex8);

            var hyperlink1 = new DocumentFormat.OpenXml.Drawing.Hyperlink();
            var rgbColorModelHex9 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "0000FF" };

            hyperlink1.Append(rgbColorModelHex9);

            var followedHyperlinkColor1 = new DocumentFormat.OpenXml.Drawing.FollowedHyperlinkColor();
            var rgbColorModelHex10 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex { Val = "800080" };

            followedHyperlinkColor1.Append(rgbColorModelHex10);

            colorScheme1.Append(dark1Color1);
            colorScheme1.Append(light1Color1);
            colorScheme1.Append(dark2Color1);
            colorScheme1.Append(light2Color1);
            colorScheme1.Append(accent1Color1);
            colorScheme1.Append(accent2Color1);
            colorScheme1.Append(accent3Color1);
            colorScheme1.Append(accent4Color1);
            colorScheme1.Append(accent5Color1);
            colorScheme1.Append(accent6Color1);
            colorScheme1.Append(hyperlink1);
            colorScheme1.Append(followedHyperlinkColor1);

            var fontScheme1 = new DocumentFormat.OpenXml.Drawing.FontScheme { Name = "Office" };

            var majorFont1 = new DocumentFormat.OpenXml.Drawing.MajorFont();
            var latinFont1 = new DocumentFormat.OpenXml.Drawing.LatinFont { Typeface = "Cambria" };
            var eastAsianFont1 = new DocumentFormat.OpenXml.Drawing.EastAsianFont { Typeface = "" };
            var complexScriptFont1 = new DocumentFormat.OpenXml.Drawing.ComplexScriptFont { Typeface = "" };
            var supplementalFont1 = new DocumentFormat.OpenXml.Drawing.SupplementalFont { Script = "Jpan", Typeface = "ＭＳ ゴシック" };
            var supplementalFont2 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Hang", Typeface = "맑은 고딕" };
            var supplementalFont3 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Hans", Typeface = "宋体" };
            var supplementalFont4 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Hant", Typeface = "新細明體" };
            var supplementalFont5 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Arab", Typeface = "Times New Roman" };
            var supplementalFont6 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Hebr", Typeface = "Times New Roman" };
            var supplementalFont7 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Thai", Typeface = "Angsana New" };
            var supplementalFont8 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Ethi", Typeface = "Nyala" };
            var supplementalFont9 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Beng", Typeface = "Vrinda" };
            var supplementalFont10 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Gujr", Typeface = "Shruti" };
            var supplementalFont11 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Khmr", Typeface = "MoolBoran" };
            var supplementalFont12 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Knda", Typeface = "Tunga" };
            var supplementalFont13 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Guru", Typeface = "Raavi" };
            var supplementalFont14 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Cans", Typeface = "Euphemia" };
            var supplementalFont15 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Cher", Typeface = "Plantagenet Cherokee" };
            var supplementalFont16 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            var supplementalFont17 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Tibt", Typeface = "Microsoft Himalaya" };
            var supplementalFont18 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Thaa", Typeface = "MV Boli" };
            var supplementalFont19 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Deva", Typeface = "Mangal" };
            var supplementalFont20 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Telu", Typeface = "Gautami" };
            var supplementalFont21 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Taml", Typeface = "Latha" };
            var supplementalFont22 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Syrc", Typeface = "Estrangelo Edessa" };
            var supplementalFont23 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Orya", Typeface = "Kalinga" };
            var supplementalFont24 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Mlym", Typeface = "Kartika" };
            var supplementalFont25 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Laoo", Typeface = "DokChampa" };
            var supplementalFont26 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Sinh", Typeface = "Iskoola Pota" };
            var supplementalFont27 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Mong", Typeface = "Mongolian Baiti" };
            var supplementalFont28 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Viet", Typeface = "Times New Roman" };
            var supplementalFont29 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Uigh", Typeface = "Microsoft Uighur" };

            majorFont1.Append(latinFont1);
            majorFont1.Append(eastAsianFont1);
            majorFont1.Append(complexScriptFont1);
            majorFont1.Append(supplementalFont1);
            majorFont1.Append(supplementalFont2);
            majorFont1.Append(supplementalFont3);
            majorFont1.Append(supplementalFont4);
            majorFont1.Append(supplementalFont5);
            majorFont1.Append(supplementalFont6);
            majorFont1.Append(supplementalFont7);
            majorFont1.Append(supplementalFont8);
            majorFont1.Append(supplementalFont9);
            majorFont1.Append(supplementalFont10);
            majorFont1.Append(supplementalFont11);
            majorFont1.Append(supplementalFont12);
            majorFont1.Append(supplementalFont13);
            majorFont1.Append(supplementalFont14);
            majorFont1.Append(supplementalFont15);
            majorFont1.Append(supplementalFont16);
            majorFont1.Append(supplementalFont17);
            majorFont1.Append(supplementalFont18);
            majorFont1.Append(supplementalFont19);
            majorFont1.Append(supplementalFont20);
            majorFont1.Append(supplementalFont21);
            majorFont1.Append(supplementalFont22);
            majorFont1.Append(supplementalFont23);
            majorFont1.Append(supplementalFont24);
            majorFont1.Append(supplementalFont25);
            majorFont1.Append(supplementalFont26);
            majorFont1.Append(supplementalFont27);
            majorFont1.Append(supplementalFont28);
            majorFont1.Append(supplementalFont29);

            DocumentFormat.OpenXml.Drawing.MinorFont minorFont1 = new DocumentFormat.OpenXml.Drawing.MinorFont();
            DocumentFormat.OpenXml.Drawing.LatinFont latinFont2 = new DocumentFormat.OpenXml.Drawing.LatinFont() { Typeface = "Calibri" };
            DocumentFormat.OpenXml.Drawing.EastAsianFont eastAsianFont2 = new DocumentFormat.OpenXml.Drawing.EastAsianFont() { Typeface = "" };
            DocumentFormat.OpenXml.Drawing.ComplexScriptFont complexScriptFont2 = new DocumentFormat.OpenXml.Drawing.ComplexScriptFont() { Typeface = "" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont30 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Jpan", Typeface = "ＭＳ 明朝" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont31 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Hang", Typeface = "맑은 고딕" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont32 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Hans", Typeface = "宋体" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont33 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Hant", Typeface = "新細明體" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont34 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Arab", Typeface = "Arial" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont35 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Hebr", Typeface = "Arial" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont36 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Thai", Typeface = "Cordia New" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont37 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Ethi", Typeface = "Nyala" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont38 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Beng", Typeface = "Vrinda" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont39 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Gujr", Typeface = "Shruti" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont40 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Khmr", Typeface = "DaunPenh" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont41 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Knda", Typeface = "Tunga" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont42 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Guru", Typeface = "Raavi" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont43 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Cans", Typeface = "Euphemia" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont44 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Cher", Typeface = "Plantagenet Cherokee" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont45 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont46 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Tibt", Typeface = "Microsoft Himalaya" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont47 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Thaa", Typeface = "MV Boli" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont48 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Deva", Typeface = "Mangal" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont49 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Telu", Typeface = "Gautami" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont50 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Taml", Typeface = "Latha" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont51 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Syrc", Typeface = "Estrangelo Edessa" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont52 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Orya", Typeface = "Kalinga" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont53 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Mlym", Typeface = "Kartika" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont54 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Laoo", Typeface = "DokChampa" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont55 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Sinh", Typeface = "Iskoola Pota" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont56 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Mong", Typeface = "Mongolian Baiti" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont57 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Viet", Typeface = "Arial" };
            DocumentFormat.OpenXml.Drawing.SupplementalFont supplementalFont58 = new DocumentFormat.OpenXml.Drawing.SupplementalFont() { Script = "Uigh", Typeface = "Microsoft Uighur" };

            minorFont1.Append(latinFont2);
            minorFont1.Append(eastAsianFont2);
            minorFont1.Append(complexScriptFont2);
            minorFont1.Append(supplementalFont30);
            minorFont1.Append(supplementalFont31);
            minorFont1.Append(supplementalFont32);
            minorFont1.Append(supplementalFont33);
            minorFont1.Append(supplementalFont34);
            minorFont1.Append(supplementalFont35);
            minorFont1.Append(supplementalFont36);
            minorFont1.Append(supplementalFont37);
            minorFont1.Append(supplementalFont38);
            minorFont1.Append(supplementalFont39);
            minorFont1.Append(supplementalFont40);
            minorFont1.Append(supplementalFont41);
            minorFont1.Append(supplementalFont42);
            minorFont1.Append(supplementalFont43);
            minorFont1.Append(supplementalFont44);
            minorFont1.Append(supplementalFont45);
            minorFont1.Append(supplementalFont46);
            minorFont1.Append(supplementalFont47);
            minorFont1.Append(supplementalFont48);
            minorFont1.Append(supplementalFont49);
            minorFont1.Append(supplementalFont50);
            minorFont1.Append(supplementalFont51);
            minorFont1.Append(supplementalFont52);
            minorFont1.Append(supplementalFont53);
            minorFont1.Append(supplementalFont54);
            minorFont1.Append(supplementalFont55);
            minorFont1.Append(supplementalFont56);
            minorFont1.Append(supplementalFont57);
            minorFont1.Append(supplementalFont58);

            fontScheme1.Append(majorFont1);
            fontScheme1.Append(minorFont1);

            DocumentFormat.OpenXml.Drawing.FormatScheme formatScheme1 = new DocumentFormat.OpenXml.Drawing.FormatScheme() { Name = "Office" };

            DocumentFormat.OpenXml.Drawing.FillStyleList fillStyleList1 = new DocumentFormat.OpenXml.Drawing.FillStyleList();

            DocumentFormat.OpenXml.Drawing.SolidFill solidFill1 = new DocumentFormat.OpenXml.Drawing.SolidFill();
            DocumentFormat.OpenXml.Drawing.SchemeColor schemeColor1 = new DocumentFormat.OpenXml.Drawing.SchemeColor() { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };

            solidFill1.Append(schemeColor1);

            DocumentFormat.OpenXml.Drawing.GradientFill gradientFill1 = new DocumentFormat.OpenXml.Drawing.GradientFill() { RotateWithShape = true };

            DocumentFormat.OpenXml.Drawing.GradientStopList gradientStopList1 = new DocumentFormat.OpenXml.Drawing.GradientStopList();

            DocumentFormat.OpenXml.Drawing.GradientStop gradientStop1 = new DocumentFormat.OpenXml.Drawing.GradientStop() { Position = 0 };

            DocumentFormat.OpenXml.Drawing.SchemeColor schemeColor2 = new DocumentFormat.OpenXml.Drawing.SchemeColor() { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
            DocumentFormat.OpenXml.Drawing.Tint tint1 = new DocumentFormat.OpenXml.Drawing.Tint() { Val = 50000 };
            DocumentFormat.OpenXml.Drawing.SaturationModulation saturationModulation1 = new DocumentFormat.OpenXml.Drawing.SaturationModulation() { Val = 300000 };

            schemeColor2.Append(tint1);
            schemeColor2.Append(saturationModulation1);

            gradientStop1.Append(schemeColor2);

            DocumentFormat.OpenXml.Drawing.GradientStop gradientStop2 = new DocumentFormat.OpenXml.Drawing.GradientStop() { Position = 35000 };

            DocumentFormat.OpenXml.Drawing.SchemeColor schemeColor3 = new DocumentFormat.OpenXml.Drawing.SchemeColor() { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
            DocumentFormat.OpenXml.Drawing.Tint tint2 = new DocumentFormat.OpenXml.Drawing.Tint() { Val = 37000 };
            DocumentFormat.OpenXml.Drawing.SaturationModulation saturationModulation2 = new DocumentFormat.OpenXml.Drawing.SaturationModulation() { Val = 300000 };

            schemeColor3.Append(tint2);
            schemeColor3.Append(saturationModulation2);

            gradientStop2.Append(schemeColor3);

            DocumentFormat.OpenXml.Drawing.GradientStop gradientStop3 = new DocumentFormat.OpenXml.Drawing.GradientStop() { Position = 100000 };

            DocumentFormat.OpenXml.Drawing.SchemeColor schemeColor4 = new DocumentFormat.OpenXml.Drawing.SchemeColor() { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
            DocumentFormat.OpenXml.Drawing.Tint tint3 = new DocumentFormat.OpenXml.Drawing.Tint() { Val = 15000 };
            DocumentFormat.OpenXml.Drawing.SaturationModulation saturationModulation3 = new DocumentFormat.OpenXml.Drawing.SaturationModulation() { Val = 350000 };

            schemeColor4.Append(tint3);
            schemeColor4.Append(saturationModulation3);

            gradientStop3.Append(schemeColor4);

            gradientStopList1.Append(gradientStop1);
            gradientStopList1.Append(gradientStop2);
            gradientStopList1.Append(gradientStop3);
            DocumentFormat.OpenXml.Drawing.LinearGradientFill linearGradientFill1 = new DocumentFormat.OpenXml.Drawing.LinearGradientFill() { Angle = 16200000, Scaled = true };

            gradientFill1.Append(gradientStopList1);
            gradientFill1.Append(linearGradientFill1);

            DocumentFormat.OpenXml.Drawing.GradientFill gradientFill2 = new DocumentFormat.OpenXml.Drawing.GradientFill() { RotateWithShape = true };

            DocumentFormat.OpenXml.Drawing.GradientStopList gradientStopList2 = new DocumentFormat.OpenXml.Drawing.GradientStopList();

            DocumentFormat.OpenXml.Drawing.GradientStop gradientStop4 = new DocumentFormat.OpenXml.Drawing.GradientStop() { Position = 0 };

            DocumentFormat.OpenXml.Drawing.SchemeColor schemeColor5 = new DocumentFormat.OpenXml.Drawing.SchemeColor() { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
            DocumentFormat.OpenXml.Drawing.Shade shade1 = new DocumentFormat.OpenXml.Drawing.Shade() { Val = 51000 };
            DocumentFormat.OpenXml.Drawing.SaturationModulation saturationModulation4 = new DocumentFormat.OpenXml.Drawing.SaturationModulation() { Val = 130000 };

            schemeColor5.Append(shade1);
            schemeColor5.Append(saturationModulation4);

            gradientStop4.Append(schemeColor5);

            DocumentFormat.OpenXml.Drawing.GradientStop gradientStop5 = new DocumentFormat.OpenXml.Drawing.GradientStop() { Position = 80000 };

            DocumentFormat.OpenXml.Drawing.SchemeColor schemeColor6 = new DocumentFormat.OpenXml.Drawing.SchemeColor() { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
            DocumentFormat.OpenXml.Drawing.Shade shade2 = new DocumentFormat.OpenXml.Drawing.Shade() { Val = 93000 };
            DocumentFormat.OpenXml.Drawing.SaturationModulation saturationModulation5 = new DocumentFormat.OpenXml.Drawing.SaturationModulation() { Val = 130000 };

            schemeColor6.Append(shade2);
            schemeColor6.Append(saturationModulation5);

            gradientStop5.Append(schemeColor6);

            DocumentFormat.OpenXml.Drawing.GradientStop gradientStop6 = new DocumentFormat.OpenXml.Drawing.GradientStop() { Position = 100000 };

            DocumentFormat.OpenXml.Drawing.SchemeColor schemeColor7 = new DocumentFormat.OpenXml.Drawing.SchemeColor() { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
            DocumentFormat.OpenXml.Drawing.Shade shade3 = new DocumentFormat.OpenXml.Drawing.Shade() { Val = 94000 };
            DocumentFormat.OpenXml.Drawing.SaturationModulation saturationModulation6 = new DocumentFormat.OpenXml.Drawing.SaturationModulation() { Val = 135000 };

            schemeColor7.Append(shade3);
            schemeColor7.Append(saturationModulation6);

            gradientStop6.Append(schemeColor7);

            gradientStopList2.Append(gradientStop4);
            gradientStopList2.Append(gradientStop5);
            gradientStopList2.Append(gradientStop6);
            DocumentFormat.OpenXml.Drawing.LinearGradientFill linearGradientFill2 = new DocumentFormat.OpenXml.Drawing.LinearGradientFill() { Angle = 16200000, Scaled = false };

            gradientFill2.Append(gradientStopList2);
            gradientFill2.Append(linearGradientFill2);

            fillStyleList1.Append(solidFill1);
            fillStyleList1.Append(gradientFill1);
            fillStyleList1.Append(gradientFill2);

            DocumentFormat.OpenXml.Drawing.LineStyleList lineStyleList1 = new DocumentFormat.OpenXml.Drawing.LineStyleList();

            DocumentFormat.OpenXml.Drawing.Outline outline28 = new DocumentFormat.OpenXml.Drawing.Outline() { Width = 9525, CapType = DocumentFormat.OpenXml.Drawing.LineCapValues.Flat, CompoundLineType = DocumentFormat.OpenXml.Drawing.CompoundLineValues.Single, Alignment = DocumentFormat.OpenXml.Drawing.PenAlignmentValues.Center };

            DocumentFormat.OpenXml.Drawing.SolidFill solidFill2 = new DocumentFormat.OpenXml.Drawing.SolidFill();

            DocumentFormat.OpenXml.Drawing.SchemeColor schemeColor8 = new DocumentFormat.OpenXml.Drawing.SchemeColor() { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
            DocumentFormat.OpenXml.Drawing.Shade shade4 = new DocumentFormat.OpenXml.Drawing.Shade() { Val = 95000 };
            DocumentFormat.OpenXml.Drawing.SaturationModulation saturationModulation7 = new DocumentFormat.OpenXml.Drawing.SaturationModulation() { Val = 105000 };

            schemeColor8.Append(shade4);
            schemeColor8.Append(saturationModulation7);

            solidFill2.Append(schemeColor8);
            DocumentFormat.OpenXml.Drawing.PresetDash presetDash1 = new DocumentFormat.OpenXml.Drawing.PresetDash() { Val = DocumentFormat.OpenXml.Drawing.PresetLineDashValues.Solid };

            outline28.Append(solidFill2);
            outline28.Append(presetDash1);

            DocumentFormat.OpenXml.Drawing.Outline outline29 = new DocumentFormat.OpenXml.Drawing.Outline() { Width = 25400, CapType = DocumentFormat.OpenXml.Drawing.LineCapValues.Flat, CompoundLineType = DocumentFormat.OpenXml.Drawing.CompoundLineValues.Single, Alignment = DocumentFormat.OpenXml.Drawing.PenAlignmentValues.Center };

            DocumentFormat.OpenXml.Drawing.SolidFill solidFill3 = new DocumentFormat.OpenXml.Drawing.SolidFill();
            DocumentFormat.OpenXml.Drawing.SchemeColor schemeColor9 = new DocumentFormat.OpenXml.Drawing.SchemeColor() { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };

            solidFill3.Append(schemeColor9);
            DocumentFormat.OpenXml.Drawing.PresetDash presetDash2 = new DocumentFormat.OpenXml.Drawing.PresetDash() { Val = DocumentFormat.OpenXml.Drawing.PresetLineDashValues.Solid };

            outline29.Append(solidFill3);
            outline29.Append(presetDash2);

            DocumentFormat.OpenXml.Drawing.Outline outline30 = new DocumentFormat.OpenXml.Drawing.Outline() { Width = 38100, CapType = DocumentFormat.OpenXml.Drawing.LineCapValues.Flat, CompoundLineType = DocumentFormat.OpenXml.Drawing.CompoundLineValues.Single, Alignment = DocumentFormat.OpenXml.Drawing.PenAlignmentValues.Center };

            DocumentFormat.OpenXml.Drawing.SolidFill solidFill4 = new DocumentFormat.OpenXml.Drawing.SolidFill();
            DocumentFormat.OpenXml.Drawing.SchemeColor schemeColor10 = new DocumentFormat.OpenXml.Drawing.SchemeColor() { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };

            solidFill4.Append(schemeColor10);
            DocumentFormat.OpenXml.Drawing.PresetDash presetDash3 = new DocumentFormat.OpenXml.Drawing.PresetDash() { Val = DocumentFormat.OpenXml.Drawing.PresetLineDashValues.Solid };

            outline30.Append(solidFill4);
            outline30.Append(presetDash3);

            lineStyleList1.Append(outline28);
            lineStyleList1.Append(outline29);
            lineStyleList1.Append(outline30);

            DocumentFormat.OpenXml.Drawing.EffectStyleList effectStyleList1 = new DocumentFormat.OpenXml.Drawing.EffectStyleList();

            DocumentFormat.OpenXml.Drawing.EffectStyle effectStyle1 = new DocumentFormat.OpenXml.Drawing.EffectStyle();

            DocumentFormat.OpenXml.Drawing.EffectList effectList1 = new DocumentFormat.OpenXml.Drawing.EffectList();

            DocumentFormat.OpenXml.Drawing.OuterShadow outerShadow1 = new DocumentFormat.OpenXml.Drawing.OuterShadow() { BlurRadius = 40000L, Distance = 20000L, Direction = 5400000, RotateWithShape = false };

            DocumentFormat.OpenXml.Drawing.RgbColorModelHex rgbColorModelHex11 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex() { Val = "000000" };
            DocumentFormat.OpenXml.Drawing.Alpha alpha1 = new DocumentFormat.OpenXml.Drawing.Alpha() { Val = 38000 };

            rgbColorModelHex11.Append(alpha1);

            outerShadow1.Append(rgbColorModelHex11);

            effectList1.Append(outerShadow1);

            effectStyle1.Append(effectList1);

            DocumentFormat.OpenXml.Drawing.EffectStyle effectStyle2 = new DocumentFormat.OpenXml.Drawing.EffectStyle();

            DocumentFormat.OpenXml.Drawing.EffectList effectList2 = new DocumentFormat.OpenXml.Drawing.EffectList();

            DocumentFormat.OpenXml.Drawing.OuterShadow outerShadow2 = new DocumentFormat.OpenXml.Drawing.OuterShadow() { BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

            DocumentFormat.OpenXml.Drawing.RgbColorModelHex rgbColorModelHex12 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex() { Val = "000000" };
            DocumentFormat.OpenXml.Drawing.Alpha alpha2 = new DocumentFormat.OpenXml.Drawing.Alpha() { Val = 35000 };

            rgbColorModelHex12.Append(alpha2);

            outerShadow2.Append(rgbColorModelHex12);

            effectList2.Append(outerShadow2);

            effectStyle2.Append(effectList2);

            DocumentFormat.OpenXml.Drawing.EffectStyle effectStyle3 = new DocumentFormat.OpenXml.Drawing.EffectStyle();

            DocumentFormat.OpenXml.Drawing.EffectList effectList3 = new DocumentFormat.OpenXml.Drawing.EffectList();

            DocumentFormat.OpenXml.Drawing.OuterShadow outerShadow3 = new DocumentFormat.OpenXml.Drawing.OuterShadow() { BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

            DocumentFormat.OpenXml.Drawing.RgbColorModelHex rgbColorModelHex13 = new DocumentFormat.OpenXml.Drawing.RgbColorModelHex() { Val = "000000" };
            DocumentFormat.OpenXml.Drawing.Alpha alpha3 = new DocumentFormat.OpenXml.Drawing.Alpha() { Val = 35000 };

            rgbColorModelHex13.Append(alpha3);

            outerShadow3.Append(rgbColorModelHex13);

            effectList3.Append(outerShadow3);

            DocumentFormat.OpenXml.Drawing.Scene3DType scene3DType1 = new DocumentFormat.OpenXml.Drawing.Scene3DType();

            DocumentFormat.OpenXml.Drawing.Camera camera1 = new DocumentFormat.OpenXml.Drawing.Camera() { Preset = DocumentFormat.OpenXml.Drawing.PresetCameraValues.OrthographicFront };
            DocumentFormat.OpenXml.Drawing.Rotation rotation1 = new DocumentFormat.OpenXml.Drawing.Rotation() { Latitude = 0, Longitude = 0, Revolution = 0 };

            camera1.Append(rotation1);

            DocumentFormat.OpenXml.Drawing.LightRig lightRig1 = new DocumentFormat.OpenXml.Drawing.LightRig() { Rig = DocumentFormat.OpenXml.Drawing.LightRigValues.ThreePoints, Direction = DocumentFormat.OpenXml.Drawing.LightRigDirectionValues.Top };
            DocumentFormat.OpenXml.Drawing.Rotation rotation2 = new DocumentFormat.OpenXml.Drawing.Rotation() { Latitude = 0, Longitude = 0, Revolution = 1200000 };

            lightRig1.Append(rotation2);

            scene3DType1.Append(camera1);
            scene3DType1.Append(lightRig1);

            DocumentFormat.OpenXml.Drawing.Shape3DType shape3DType1 = new DocumentFormat.OpenXml.Drawing.Shape3DType();
            DocumentFormat.OpenXml.Drawing.BevelTop bevelTop1 = new DocumentFormat.OpenXml.Drawing.BevelTop() { Width = 63500L, Height = 25400L };

            shape3DType1.Append(bevelTop1);

            effectStyle3.Append(effectList3);
            effectStyle3.Append(scene3DType1);
            effectStyle3.Append(shape3DType1);

            effectStyleList1.Append(effectStyle1);
            effectStyleList1.Append(effectStyle2);
            effectStyleList1.Append(effectStyle3);

            DocumentFormat.OpenXml.Drawing.BackgroundFillStyleList backgroundFillStyleList1 = new DocumentFormat.OpenXml.Drawing.BackgroundFillStyleList();

            DocumentFormat.OpenXml.Drawing.SolidFill solidFill5 = new DocumentFormat.OpenXml.Drawing.SolidFill();
            DocumentFormat.OpenXml.Drawing.SchemeColor schemeColor11 = new DocumentFormat.OpenXml.Drawing.SchemeColor() { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };

            solidFill5.Append(schemeColor11);

            DocumentFormat.OpenXml.Drawing.GradientFill gradientFill3 = new DocumentFormat.OpenXml.Drawing.GradientFill() { RotateWithShape = true };

            DocumentFormat.OpenXml.Drawing.GradientStopList gradientStopList3 = new DocumentFormat.OpenXml.Drawing.GradientStopList();

            DocumentFormat.OpenXml.Drawing.GradientStop gradientStop7 = new DocumentFormat.OpenXml.Drawing.GradientStop() { Position = 0 };

            DocumentFormat.OpenXml.Drawing.SchemeColor schemeColor12 = new DocumentFormat.OpenXml.Drawing.SchemeColor() { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
            DocumentFormat.OpenXml.Drawing.Tint tint4 = new DocumentFormat.OpenXml.Drawing.Tint() { Val = 40000 };
            DocumentFormat.OpenXml.Drawing.SaturationModulation saturationModulation8 = new DocumentFormat.OpenXml.Drawing.SaturationModulation() { Val = 350000 };

            schemeColor12.Append(tint4);
            schemeColor12.Append(saturationModulation8);

            gradientStop7.Append(schemeColor12);

            DocumentFormat.OpenXml.Drawing.GradientStop gradientStop8 = new DocumentFormat.OpenXml.Drawing.GradientStop() { Position = 40000 };

            DocumentFormat.OpenXml.Drawing.SchemeColor schemeColor13 = new DocumentFormat.OpenXml.Drawing.SchemeColor() { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
            DocumentFormat.OpenXml.Drawing.Tint tint5 = new DocumentFormat.OpenXml.Drawing.Tint() { Val = 45000 };
            DocumentFormat.OpenXml.Drawing.Shade shade5 = new DocumentFormat.OpenXml.Drawing.Shade() { Val = 99000 };
            DocumentFormat.OpenXml.Drawing.SaturationModulation saturationModulation9 = new DocumentFormat.OpenXml.Drawing.SaturationModulation() { Val = 350000 };

            schemeColor13.Append(tint5);
            schemeColor13.Append(shade5);
            schemeColor13.Append(saturationModulation9);

            gradientStop8.Append(schemeColor13);

            DocumentFormat.OpenXml.Drawing.GradientStop gradientStop9 = new DocumentFormat.OpenXml.Drawing.GradientStop() { Position = 100000 };

            DocumentFormat.OpenXml.Drawing.SchemeColor schemeColor14 = new DocumentFormat.OpenXml.Drawing.SchemeColor() { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
            DocumentFormat.OpenXml.Drawing.Shade shade6 = new DocumentFormat.OpenXml.Drawing.Shade() { Val = 20000 };
            DocumentFormat.OpenXml.Drawing.SaturationModulation saturationModulation10 = new DocumentFormat.OpenXml.Drawing.SaturationModulation() { Val = 255000 };

            schemeColor14.Append(shade6);
            schemeColor14.Append(saturationModulation10);

            gradientStop9.Append(schemeColor14);

            gradientStopList3.Append(gradientStop7);
            gradientStopList3.Append(gradientStop8);
            gradientStopList3.Append(gradientStop9);

            DocumentFormat.OpenXml.Drawing.PathGradientFill pathGradientFill1 = new DocumentFormat.OpenXml.Drawing.PathGradientFill() { Path = DocumentFormat.OpenXml.Drawing.PathShadeValues.Circle };
            DocumentFormat.OpenXml.Drawing.FillToRectangle fillToRectangle1 = new DocumentFormat.OpenXml.Drawing.FillToRectangle() { Left = 50000, Top = -80000, Right = 50000, Bottom = 180000 };

            pathGradientFill1.Append(fillToRectangle1);

            gradientFill3.Append(gradientStopList3);
            gradientFill3.Append(pathGradientFill1);

            DocumentFormat.OpenXml.Drawing.GradientFill gradientFill4 = new DocumentFormat.OpenXml.Drawing.GradientFill() { RotateWithShape = true };

            DocumentFormat.OpenXml.Drawing.GradientStopList gradientStopList4 = new DocumentFormat.OpenXml.Drawing.GradientStopList();

            DocumentFormat.OpenXml.Drawing.GradientStop gradientStop10 = new DocumentFormat.OpenXml.Drawing.GradientStop() { Position = 0 };

            DocumentFormat.OpenXml.Drawing.SchemeColor schemeColor15 = new DocumentFormat.OpenXml.Drawing.SchemeColor() { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
            DocumentFormat.OpenXml.Drawing.Tint tint6 = new DocumentFormat.OpenXml.Drawing.Tint() { Val = 80000 };
            DocumentFormat.OpenXml.Drawing.SaturationModulation saturationModulation11 = new DocumentFormat.OpenXml.Drawing.SaturationModulation() { Val = 300000 };

            schemeColor15.Append(tint6);
            schemeColor15.Append(saturationModulation11);

            gradientStop10.Append(schemeColor15);

            DocumentFormat.OpenXml.Drawing.GradientStop gradientStop11 = new DocumentFormat.OpenXml.Drawing.GradientStop() { Position = 100000 };

            DocumentFormat.OpenXml.Drawing.SchemeColor schemeColor16 = new DocumentFormat.OpenXml.Drawing.SchemeColor() { Val = DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor };
            DocumentFormat.OpenXml.Drawing.Shade shade7 = new DocumentFormat.OpenXml.Drawing.Shade() { Val = 30000 };
            DocumentFormat.OpenXml.Drawing.SaturationModulation saturationModulation12 = new DocumentFormat.OpenXml.Drawing.SaturationModulation() { Val = 200000 };

            schemeColor16.Append(shade7);
            schemeColor16.Append(saturationModulation12);

            gradientStop11.Append(schemeColor16);

            gradientStopList4.Append(gradientStop10);
            gradientStopList4.Append(gradientStop11);

            DocumentFormat.OpenXml.Drawing.PathGradientFill pathGradientFill2 = new DocumentFormat.OpenXml.Drawing.PathGradientFill() { Path = DocumentFormat.OpenXml.Drawing.PathShadeValues.Circle };
            DocumentFormat.OpenXml.Drawing.FillToRectangle fillToRectangle2 = new DocumentFormat.OpenXml.Drawing.FillToRectangle() { Left = 50000, Top = 50000, Right = 50000, Bottom = 50000 };

            pathGradientFill2.Append(fillToRectangle2);

            gradientFill4.Append(gradientStopList4);
            gradientFill4.Append(pathGradientFill2);

            backgroundFillStyleList1.Append(solidFill5);
            backgroundFillStyleList1.Append(gradientFill3);
            backgroundFillStyleList1.Append(gradientFill4);

            formatScheme1.Append(fillStyleList1);
            formatScheme1.Append(lineStyleList1);
            formatScheme1.Append(effectStyleList1);
            formatScheme1.Append(backgroundFillStyleList1);

            themeElements1.Append(colorScheme1);
            themeElements1.Append(fontScheme1);
            themeElements1.Append(formatScheme1);
            DocumentFormat.OpenXml.Drawing.ObjectDefaults objectDefaults1 = new DocumentFormat.OpenXml.Drawing.ObjectDefaults();
            DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList extraColorSchemeList1 = new DocumentFormat.OpenXml.Drawing.ExtraColorSchemeList();

            theme1.Append(themeElements1);
            theme1.Append(objectDefaults1);
            theme1.Append(extraColorSchemeList1);

            themePart1.Theme = theme1;
        }
    }
}
