using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using A = DocumentFormat.OpenXml.Drawing;
using Thm15 = DocumentFormat.OpenXml.Office2013.Theme;

namespace CV.Management.Generation.Ppt.Helpers
{
    public static class GenerateThemePartHelper
    {
        public static void GenerateThemePart1Content(ThemePart themePart1)
        {
            A.Theme theme1 = new A.Theme() { Name = "Office Theme" };
            theme1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.ThemeElements themeElements1 = new A.ThemeElements();

            A.ColorScheme colorScheme1 = new A.ColorScheme() { Name = "Office" };

            A.Dark1Color dark1Color1 = new A.Dark1Color();
            A.SystemColor systemColor1 = new A.SystemColor() { Val = A.SystemColorValues.WindowText, LastColor = "000000" };

            dark1Color1.Append(systemColor1);

            A.Light1Color light1Color1 = new A.Light1Color();
            A.SystemColor systemColor2 = new A.SystemColor() { Val = A.SystemColorValues.Window, LastColor = "FFFFFF" };

            light1Color1.Append(systemColor2);

            A.Dark2Color dark2Color1 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex18 = new A.RgbColorModelHex() { Val = "44546A" };

            dark2Color1.Append(rgbColorModelHex18);

            A.Light2Color light2Color1 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex19 = new A.RgbColorModelHex() { Val = "E7E6E6" };

            light2Color1.Append(rgbColorModelHex19);

            A.Accent1Color accent1Color1 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex20 = new A.RgbColorModelHex() { Val = "4472C4" };

            accent1Color1.Append(rgbColorModelHex20);

            A.Accent2Color accent2Color1 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex21 = new A.RgbColorModelHex() { Val = "ED7D31" };

            accent2Color1.Append(rgbColorModelHex21);

            A.Accent3Color accent3Color1 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex22 = new A.RgbColorModelHex() { Val = "A5A5A5" };

            accent3Color1.Append(rgbColorModelHex22);

            A.Accent4Color accent4Color1 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex23 = new A.RgbColorModelHex() { Val = "FFC000" };

            accent4Color1.Append(rgbColorModelHex23);

            A.Accent5Color accent5Color1 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex24 = new A.RgbColorModelHex() { Val = "5B9BD5" };

            accent5Color1.Append(rgbColorModelHex24);

            A.Accent6Color accent6Color1 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex25 = new A.RgbColorModelHex() { Val = "70AD47" };

            accent6Color1.Append(rgbColorModelHex25);

            A.Hyperlink hyperlink1 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex26 = new A.RgbColorModelHex() { Val = "0563C1" };

            hyperlink1.Append(rgbColorModelHex26);

            A.FollowedHyperlinkColor followedHyperlinkColor1 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex27 = new A.RgbColorModelHex() { Val = "954F72" };

            followedHyperlinkColor1.Append(rgbColorModelHex27);

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

            A.FontScheme fontScheme1 = new A.FontScheme() { Name = "Office" };

            A.MajorFont majorFont1 = new A.MajorFont();
            A.LatinFont latinFont10 = new A.LatinFont() { Typeface = "Calibri Light", Panose = "020F0302020204030204" };
            A.EastAsianFont eastAsianFont10 = new A.EastAsianFont() { Typeface = "" };
            A.ComplexScriptFont complexScriptFont10 = new A.ComplexScriptFont() { Typeface = "" };
            A.SupplementalFont supplementalFont1 = new A.SupplementalFont() { Script = "Jpan", Typeface = "游ゴシック Light" };
            A.SupplementalFont supplementalFont2 = new A.SupplementalFont() { Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont3 = new A.SupplementalFont() { Script = "Hans", Typeface = "等线 Light" };
            A.SupplementalFont supplementalFont4 = new A.SupplementalFont() { Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont5 = new A.SupplementalFont() { Script = "Arab", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont6 = new A.SupplementalFont() { Script = "Hebr", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont7 = new A.SupplementalFont() { Script = "Thai", Typeface = "Angsana New" };
            A.SupplementalFont supplementalFont8 = new A.SupplementalFont() { Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont9 = new A.SupplementalFont() { Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont10 = new A.SupplementalFont() { Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont11 = new A.SupplementalFont() { Script = "Khmr", Typeface = "MoolBoran" };
            A.SupplementalFont supplementalFont12 = new A.SupplementalFont() { Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont13 = new A.SupplementalFont() { Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont14 = new A.SupplementalFont() { Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont15 = new A.SupplementalFont() { Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont16 = new A.SupplementalFont() { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont17 = new A.SupplementalFont() { Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont18 = new A.SupplementalFont() { Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont19 = new A.SupplementalFont() { Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont20 = new A.SupplementalFont() { Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont21 = new A.SupplementalFont() { Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont22 = new A.SupplementalFont() { Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont23 = new A.SupplementalFont() { Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont24 = new A.SupplementalFont() { Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont25 = new A.SupplementalFont() { Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont26 = new A.SupplementalFont() { Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont27 = new A.SupplementalFont() { Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont28 = new A.SupplementalFont() { Script = "Viet", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont29 = new A.SupplementalFont() { Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont30 = new A.SupplementalFont() { Script = "Geor", Typeface = "Sylfaen" };
            A.SupplementalFont supplementalFont31 = new A.SupplementalFont() { Script = "Armn", Typeface = "Arial" };
            A.SupplementalFont supplementalFont32 = new A.SupplementalFont() { Script = "Bugi", Typeface = "Leelawadee UI" };
            A.SupplementalFont supplementalFont33 = new A.SupplementalFont() { Script = "Bopo", Typeface = "Microsoft JhengHei" };
            A.SupplementalFont supplementalFont34 = new A.SupplementalFont() { Script = "Java", Typeface = "Javanese Text" };
            A.SupplementalFont supplementalFont35 = new A.SupplementalFont() { Script = "Lisu", Typeface = "Segoe UI" };
            A.SupplementalFont supplementalFont36 = new A.SupplementalFont() { Script = "Mymr", Typeface = "Myanmar Text" };
            A.SupplementalFont supplementalFont37 = new A.SupplementalFont() { Script = "Nkoo", Typeface = "Ebrima" };
            A.SupplementalFont supplementalFont38 = new A.SupplementalFont() { Script = "Olck", Typeface = "Nirmala UI" };
            A.SupplementalFont supplementalFont39 = new A.SupplementalFont() { Script = "Osma", Typeface = "Ebrima" };
            A.SupplementalFont supplementalFont40 = new A.SupplementalFont() { Script = "Phag", Typeface = "Phagspa" };
            A.SupplementalFont supplementalFont41 = new A.SupplementalFont() { Script = "Syrn", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont42 = new A.SupplementalFont() { Script = "Syrj", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont43 = new A.SupplementalFont() { Script = "Syre", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont44 = new A.SupplementalFont() { Script = "Sora", Typeface = "Nirmala UI" };
            A.SupplementalFont supplementalFont45 = new A.SupplementalFont() { Script = "Tale", Typeface = "Microsoft Tai Le" };
            A.SupplementalFont supplementalFont46 = new A.SupplementalFont() { Script = "Talu", Typeface = "Microsoft New Tai Lue" };
            A.SupplementalFont supplementalFont47 = new A.SupplementalFont() { Script = "Tfng", Typeface = "Ebrima" };

            majorFont1.Append(latinFont10);
            majorFont1.Append(eastAsianFont10);
            majorFont1.Append(complexScriptFont10);
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
            majorFont1.Append(supplementalFont30);
            majorFont1.Append(supplementalFont31);
            majorFont1.Append(supplementalFont32);
            majorFont1.Append(supplementalFont33);
            majorFont1.Append(supplementalFont34);
            majorFont1.Append(supplementalFont35);
            majorFont1.Append(supplementalFont36);
            majorFont1.Append(supplementalFont37);
            majorFont1.Append(supplementalFont38);
            majorFont1.Append(supplementalFont39);
            majorFont1.Append(supplementalFont40);
            majorFont1.Append(supplementalFont41);
            majorFont1.Append(supplementalFont42);
            majorFont1.Append(supplementalFont43);
            majorFont1.Append(supplementalFont44);
            majorFont1.Append(supplementalFont45);
            majorFont1.Append(supplementalFont46);
            majorFont1.Append(supplementalFont47);

            A.MinorFont minorFont1 = new A.MinorFont();
            A.LatinFont latinFont11 = new A.LatinFont() { Typeface = "Calibri", Panose = "020F0502020204030204" };
            A.EastAsianFont eastAsianFont11 = new A.EastAsianFont() { Typeface = "" };
            A.ComplexScriptFont complexScriptFont11 = new A.ComplexScriptFont() { Typeface = "" };
            A.SupplementalFont supplementalFont48 = new A.SupplementalFont() { Script = "Jpan", Typeface = "游ゴシック" };
            A.SupplementalFont supplementalFont49 = new A.SupplementalFont() { Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont50 = new A.SupplementalFont() { Script = "Hans", Typeface = "等线" };
            A.SupplementalFont supplementalFont51 = new A.SupplementalFont() { Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont52 = new A.SupplementalFont() { Script = "Arab", Typeface = "Arial" };
            A.SupplementalFont supplementalFont53 = new A.SupplementalFont() { Script = "Hebr", Typeface = "Arial" };
            A.SupplementalFont supplementalFont54 = new A.SupplementalFont() { Script = "Thai", Typeface = "Cordia New" };
            A.SupplementalFont supplementalFont55 = new A.SupplementalFont() { Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont56 = new A.SupplementalFont() { Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont57 = new A.SupplementalFont() { Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont58 = new A.SupplementalFont() { Script = "Khmr", Typeface = "DaunPenh" };
            A.SupplementalFont supplementalFont59 = new A.SupplementalFont() { Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont60 = new A.SupplementalFont() { Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont61 = new A.SupplementalFont() { Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont62 = new A.SupplementalFont() { Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont63 = new A.SupplementalFont() { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont64 = new A.SupplementalFont() { Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont65 = new A.SupplementalFont() { Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont66 = new A.SupplementalFont() { Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont67 = new A.SupplementalFont() { Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont68 = new A.SupplementalFont() { Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont69 = new A.SupplementalFont() { Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont70 = new A.SupplementalFont() { Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont71 = new A.SupplementalFont() { Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont72 = new A.SupplementalFont() { Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont73 = new A.SupplementalFont() { Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont74 = new A.SupplementalFont() { Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont75 = new A.SupplementalFont() { Script = "Viet", Typeface = "Arial" };
            A.SupplementalFont supplementalFont76 = new A.SupplementalFont() { Script = "Uigh", Typeface = "Microsoft Uighur" };
            A.SupplementalFont supplementalFont77 = new A.SupplementalFont() { Script = "Geor", Typeface = "Sylfaen" };
            A.SupplementalFont supplementalFont78 = new A.SupplementalFont() { Script = "Armn", Typeface = "Arial" };
            A.SupplementalFont supplementalFont79 = new A.SupplementalFont() { Script = "Bugi", Typeface = "Leelawadee UI" };
            A.SupplementalFont supplementalFont80 = new A.SupplementalFont() { Script = "Bopo", Typeface = "Microsoft JhengHei" };
            A.SupplementalFont supplementalFont81 = new A.SupplementalFont() { Script = "Java", Typeface = "Javanese Text" };
            A.SupplementalFont supplementalFont82 = new A.SupplementalFont() { Script = "Lisu", Typeface = "Segoe UI" };
            A.SupplementalFont supplementalFont83 = new A.SupplementalFont() { Script = "Mymr", Typeface = "Myanmar Text" };
            A.SupplementalFont supplementalFont84 = new A.SupplementalFont() { Script = "Nkoo", Typeface = "Ebrima" };
            A.SupplementalFont supplementalFont85 = new A.SupplementalFont() { Script = "Olck", Typeface = "Nirmala UI" };
            A.SupplementalFont supplementalFont86 = new A.SupplementalFont() { Script = "Osma", Typeface = "Ebrima" };
            A.SupplementalFont supplementalFont87 = new A.SupplementalFont() { Script = "Phag", Typeface = "Phagspa" };
            A.SupplementalFont supplementalFont88 = new A.SupplementalFont() { Script = "Syrn", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont89 = new A.SupplementalFont() { Script = "Syrj", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont90 = new A.SupplementalFont() { Script = "Syre", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont91 = new A.SupplementalFont() { Script = "Sora", Typeface = "Nirmala UI" };
            A.SupplementalFont supplementalFont92 = new A.SupplementalFont() { Script = "Tale", Typeface = "Microsoft Tai Le" };
            A.SupplementalFont supplementalFont93 = new A.SupplementalFont() { Script = "Talu", Typeface = "Microsoft New Tai Lue" };
            A.SupplementalFont supplementalFont94 = new A.SupplementalFont() { Script = "Tfng", Typeface = "Ebrima" };

            minorFont1.Append(latinFont11);
            minorFont1.Append(eastAsianFont11);
            minorFont1.Append(complexScriptFont11);
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
            minorFont1.Append(supplementalFont59);
            minorFont1.Append(supplementalFont60);
            minorFont1.Append(supplementalFont61);
            minorFont1.Append(supplementalFont62);
            minorFont1.Append(supplementalFont63);
            minorFont1.Append(supplementalFont64);
            minorFont1.Append(supplementalFont65);
            minorFont1.Append(supplementalFont66);
            minorFont1.Append(supplementalFont67);
            minorFont1.Append(supplementalFont68);
            minorFont1.Append(supplementalFont69);
            minorFont1.Append(supplementalFont70);
            minorFont1.Append(supplementalFont71);
            minorFont1.Append(supplementalFont72);
            minorFont1.Append(supplementalFont73);
            minorFont1.Append(supplementalFont74);
            minorFont1.Append(supplementalFont75);
            minorFont1.Append(supplementalFont76);
            minorFont1.Append(supplementalFont77);
            minorFont1.Append(supplementalFont78);
            minorFont1.Append(supplementalFont79);
            minorFont1.Append(supplementalFont80);
            minorFont1.Append(supplementalFont81);
            minorFont1.Append(supplementalFont82);
            minorFont1.Append(supplementalFont83);
            minorFont1.Append(supplementalFont84);
            minorFont1.Append(supplementalFont85);
            minorFont1.Append(supplementalFont86);
            minorFont1.Append(supplementalFont87);
            minorFont1.Append(supplementalFont88);
            minorFont1.Append(supplementalFont89);
            minorFont1.Append(supplementalFont90);
            minorFont1.Append(supplementalFont91);
            minorFont1.Append(supplementalFont92);
            minorFont1.Append(supplementalFont93);
            minorFont1.Append(supplementalFont94);

            fontScheme1.Append(majorFont1);
            fontScheme1.Append(minorFont1);

            A.FormatScheme formatScheme1 = new A.FormatScheme() { Name = "Office" };

            A.FillStyleList fillStyleList1 = new A.FillStyleList();

            A.SolidFill solidFill10 = new A.SolidFill();
            A.SchemeColor schemeColor11 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill10.Append(schemeColor11);

            A.GradientFill gradientFill1 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList1 = new A.GradientStopList();

            A.GradientStop gradientStop1 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor12 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation1 = new A.LuminanceModulation() { Val = 110000 };
            A.SaturationModulation saturationModulation1 = new A.SaturationModulation() { Val = 105000 };
            A.Tint tint1 = new A.Tint() { Val = 67000 };

            schemeColor12.Append(luminanceModulation1);
            schemeColor12.Append(saturationModulation1);
            schemeColor12.Append(tint1);

            gradientStop1.Append(schemeColor12);

            A.GradientStop gradientStop2 = new A.GradientStop() { Position = 50000 };

            A.SchemeColor schemeColor13 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation2 = new A.LuminanceModulation() { Val = 105000 };
            A.SaturationModulation saturationModulation2 = new A.SaturationModulation() { Val = 103000 };
            A.Tint tint2 = new A.Tint() { Val = 73000 };

            schemeColor13.Append(luminanceModulation2);
            schemeColor13.Append(saturationModulation2);
            schemeColor13.Append(tint2);

            gradientStop2.Append(schemeColor13);

            A.GradientStop gradientStop3 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor14 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation3 = new A.LuminanceModulation() { Val = 105000 };
            A.SaturationModulation saturationModulation3 = new A.SaturationModulation() { Val = 109000 };
            A.Tint tint3 = new A.Tint() { Val = 81000 };

            schemeColor14.Append(luminanceModulation3);
            schemeColor14.Append(saturationModulation3);
            schemeColor14.Append(tint3);

            gradientStop3.Append(schemeColor14);

            gradientStopList1.Append(gradientStop1);
            gradientStopList1.Append(gradientStop2);
            gradientStopList1.Append(gradientStop3);
            A.LinearGradientFill linearGradientFill1 = new A.LinearGradientFill() { Angle = 5400000, Scaled = false };

            gradientFill1.Append(gradientStopList1);
            gradientFill1.Append(linearGradientFill1);

            A.GradientFill gradientFill2 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList2 = new A.GradientStopList();

            A.GradientStop gradientStop4 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor15 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.SaturationModulation saturationModulation4 = new A.SaturationModulation() { Val = 103000 };
            A.LuminanceModulation luminanceModulation4 = new A.LuminanceModulation() { Val = 102000 };
            A.Tint tint4 = new A.Tint() { Val = 94000 };

            schemeColor15.Append(saturationModulation4);
            schemeColor15.Append(luminanceModulation4);
            schemeColor15.Append(tint4);

            gradientStop4.Append(schemeColor15);

            A.GradientStop gradientStop5 = new A.GradientStop() { Position = 50000 };

            A.SchemeColor schemeColor16 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.SaturationModulation saturationModulation5 = new A.SaturationModulation() { Val = 110000 };
            A.LuminanceModulation luminanceModulation5 = new A.LuminanceModulation() { Val = 100000 };
            A.Shade shade1 = new A.Shade() { Val = 100000 };

            schemeColor16.Append(saturationModulation5);
            schemeColor16.Append(luminanceModulation5);
            schemeColor16.Append(shade1);

            gradientStop5.Append(schemeColor16);

            A.GradientStop gradientStop6 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor17 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.LuminanceModulation luminanceModulation6 = new A.LuminanceModulation() { Val = 99000 };
            A.SaturationModulation saturationModulation6 = new A.SaturationModulation() { Val = 120000 };
            A.Shade shade2 = new A.Shade() { Val = 78000 };

            schemeColor17.Append(luminanceModulation6);
            schemeColor17.Append(saturationModulation6);
            schemeColor17.Append(shade2);

            gradientStop6.Append(schemeColor17);

            gradientStopList2.Append(gradientStop4);
            gradientStopList2.Append(gradientStop5);
            gradientStopList2.Append(gradientStop6);
            A.LinearGradientFill linearGradientFill2 = new A.LinearGradientFill() { Angle = 5400000, Scaled = false };

            gradientFill2.Append(gradientStopList2);
            gradientFill2.Append(linearGradientFill2);

            fillStyleList1.Append(solidFill10);
            fillStyleList1.Append(gradientFill1);
            fillStyleList1.Append(gradientFill2);

            A.LineStyleList lineStyleList1 = new A.LineStyleList();

            A.Outline outline1 = new A.Outline() { Width = 6350, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill11 = new A.SolidFill();
            A.SchemeColor schemeColor18 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill11.Append(schemeColor18);
            A.PresetDash presetDash1 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };
            A.Miter miter1 = new A.Miter() { Limit = 800000 };

            outline1.Append(solidFill11);
            outline1.Append(presetDash1);
            outline1.Append(miter1);

            A.Outline outline2 = new A.Outline() { Width = 12700, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill12 = new A.SolidFill();
            A.SchemeColor schemeColor19 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill12.Append(schemeColor19);
            A.PresetDash presetDash2 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };
            A.Miter miter2 = new A.Miter() { Limit = 800000 };

            outline2.Append(solidFill12);
            outline2.Append(presetDash2);
            outline2.Append(miter2);

            A.Outline outline3 = new A.Outline() { Width = 19050, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill13 = new A.SolidFill();
            A.SchemeColor schemeColor20 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill13.Append(schemeColor20);
            A.PresetDash presetDash3 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };
            A.Miter miter3 = new A.Miter() { Limit = 800000 };

            outline3.Append(solidFill13);
            outline3.Append(presetDash3);
            outline3.Append(miter3);

            lineStyleList1.Append(outline1);
            lineStyleList1.Append(outline2);
            lineStyleList1.Append(outline3);

            A.EffectStyleList effectStyleList1 = new A.EffectStyleList();

            A.EffectStyle effectStyle1 = new A.EffectStyle();
            A.EffectList effectList1 = new A.EffectList();

            effectStyle1.Append(effectList1);

            A.EffectStyle effectStyle2 = new A.EffectStyle();
            A.EffectList effectList2 = new A.EffectList();

            effectStyle2.Append(effectList2);

            A.EffectStyle effectStyle3 = new A.EffectStyle();

            A.EffectList effectList3 = new A.EffectList();

            A.OuterShadow outerShadow1 = new A.OuterShadow() { BlurRadius = 57150L, Distance = 19050L, Direction = 5400000, Alignment = A.RectangleAlignmentValues.Center, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex28 = new A.RgbColorModelHex() { Val = "000000" };
            A.Alpha alpha1 = new A.Alpha() { Val = 63000 };

            rgbColorModelHex28.Append(alpha1);

            outerShadow1.Append(rgbColorModelHex28);

            effectList3.Append(outerShadow1);

            effectStyle3.Append(effectList3);

            effectStyleList1.Append(effectStyle1);
            effectStyleList1.Append(effectStyle2);
            effectStyleList1.Append(effectStyle3);

            A.BackgroundFillStyleList backgroundFillStyleList1 = new A.BackgroundFillStyleList();

            A.SolidFill solidFill14 = new A.SolidFill();
            A.SchemeColor schemeColor21 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill14.Append(schemeColor21);

            A.SolidFill solidFill15 = new A.SolidFill();

            A.SchemeColor schemeColor22 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint5 = new A.Tint() { Val = 95000 };
            A.SaturationModulation saturationModulation7 = new A.SaturationModulation() { Val = 170000 };

            schemeColor22.Append(tint5);
            schemeColor22.Append(saturationModulation7);

            solidFill15.Append(schemeColor22);

            A.GradientFill gradientFill3 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList3 = new A.GradientStopList();

            A.GradientStop gradientStop7 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor23 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint6 = new A.Tint() { Val = 93000 };
            A.SaturationModulation saturationModulation8 = new A.SaturationModulation() { Val = 150000 };
            A.Shade shade3 = new A.Shade() { Val = 98000 };
            A.LuminanceModulation luminanceModulation7 = new A.LuminanceModulation() { Val = 102000 };

            schemeColor23.Append(tint6);
            schemeColor23.Append(saturationModulation8);
            schemeColor23.Append(shade3);
            schemeColor23.Append(luminanceModulation7);

            gradientStop7.Append(schemeColor23);

            A.GradientStop gradientStop8 = new A.GradientStop() { Position = 50000 };

            A.SchemeColor schemeColor24 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint7 = new A.Tint() { Val = 98000 };
            A.SaturationModulation saturationModulation9 = new A.SaturationModulation() { Val = 130000 };
            A.Shade shade4 = new A.Shade() { Val = 90000 };
            A.LuminanceModulation luminanceModulation8 = new A.LuminanceModulation() { Val = 103000 };

            schemeColor24.Append(tint7);
            schemeColor24.Append(saturationModulation9);
            schemeColor24.Append(shade4);
            schemeColor24.Append(luminanceModulation8);

            gradientStop8.Append(schemeColor24);

            A.GradientStop gradientStop9 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor25 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade5 = new A.Shade() { Val = 63000 };
            A.SaturationModulation saturationModulation10 = new A.SaturationModulation() { Val = 120000 };

            schemeColor25.Append(shade5);
            schemeColor25.Append(saturationModulation10);

            gradientStop9.Append(schemeColor25);

            gradientStopList3.Append(gradientStop7);
            gradientStopList3.Append(gradientStop8);
            gradientStopList3.Append(gradientStop9);
            A.LinearGradientFill linearGradientFill3 = new A.LinearGradientFill() { Angle = 5400000, Scaled = false };

            gradientFill3.Append(gradientStopList3);
            gradientFill3.Append(linearGradientFill3);

            backgroundFillStyleList1.Append(solidFill14);
            backgroundFillStyleList1.Append(solidFill15);
            backgroundFillStyleList1.Append(gradientFill3);

            formatScheme1.Append(fillStyleList1);
            formatScheme1.Append(lineStyleList1);
            formatScheme1.Append(effectStyleList1);
            formatScheme1.Append(backgroundFillStyleList1);

            themeElements1.Append(colorScheme1);
            themeElements1.Append(fontScheme1);
            themeElements1.Append(formatScheme1);
            A.ObjectDefaults objectDefaults1 = new A.ObjectDefaults();
            A.ExtraColorSchemeList extraColorSchemeList1 = new A.ExtraColorSchemeList();

            A.OfficeStyleSheetExtensionList officeStyleSheetExtensionList1 = new A.OfficeStyleSheetExtensionList();

            A.OfficeStyleSheetExtension officeStyleSheetExtension1 = new A.OfficeStyleSheetExtension() { Uri = "{05A4C25C-085E-4340-85A3-A5531E510DB2}" };

            Thm15.ThemeFamily themeFamily1 = new Thm15.ThemeFamily() { Name = "Office Theme", Id = "{62F939B6-93AF-4DB8-9C6B-D6C7DFDC589F}", Vid = "{4A3C46E8-61CC-4603-A589-7422A47A8E4A}" };
            themeFamily1.AddNamespaceDeclaration("thm15", "http://schemas.microsoft.com/office/thememl/2012/main");

            officeStyleSheetExtension1.Append(themeFamily1);

            officeStyleSheetExtensionList1.Append(officeStyleSheetExtension1);

            theme1.Append(themeElements1);
            theme1.Append(objectDefaults1);
            theme1.Append(extraColorSchemeList1);
            theme1.Append(officeStyleSheetExtensionList1);

            themePart1.Theme = theme1;
        }

        public static void GenerateThemePart2Content(ThemePart themePart2)
        {
            A.Theme theme2 = new A.Theme() { Name = "Office Theme" };
            theme2.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.ThemeElements themeElements2 = new A.ThemeElements();

            A.ColorScheme colorScheme2 = new A.ColorScheme() { Name = "" };

            A.Dark1Color dark1Color2 = new A.Dark1Color();
            A.RgbColorModelHex rgbColorModelHex31 = new A.RgbColorModelHex() { Val = "000000" };

            dark1Color2.Append(rgbColorModelHex31);

            A.Light1Color light1Color2 = new A.Light1Color();
            A.RgbColorModelHex rgbColorModelHex32 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            light1Color2.Append(rgbColorModelHex32);

            A.Dark2Color dark2Color2 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex33 = new A.RgbColorModelHex() { Val = "000000" };

            dark2Color2.Append(rgbColorModelHex33);

            A.Light2Color light2Color2 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex34 = new A.RgbColorModelHex() { Val = "808080" };

            light2Color2.Append(rgbColorModelHex34);

            A.Accent1Color accent1Color2 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex35 = new A.RgbColorModelHex() { Val = "BBE0E3" };

            accent1Color2.Append(rgbColorModelHex35);

            A.Accent2Color accent2Color2 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex36 = new A.RgbColorModelHex() { Val = "333399" };

            accent2Color2.Append(rgbColorModelHex36);

            A.Accent3Color accent3Color2 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex37 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            accent3Color2.Append(rgbColorModelHex37);

            A.Accent4Color accent4Color2 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex38 = new A.RgbColorModelHex() { Val = "000000" };

            accent4Color2.Append(rgbColorModelHex38);

            A.Accent5Color accent5Color2 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex39 = new A.RgbColorModelHex() { Val = "DAEDEF" };

            accent5Color2.Append(rgbColorModelHex39);

            A.Accent6Color accent6Color2 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex40 = new A.RgbColorModelHex() { Val = "2D2D8A" };

            accent6Color2.Append(rgbColorModelHex40);

            A.Hyperlink hyperlink2 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex41 = new A.RgbColorModelHex() { Val = "009999" };

            hyperlink2.Append(rgbColorModelHex41);

            A.FollowedHyperlinkColor followedHyperlinkColor2 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex42 = new A.RgbColorModelHex() { Val = "99CC00" };

            followedHyperlinkColor2.Append(rgbColorModelHex42);

            colorScheme2.Append(dark1Color2);
            colorScheme2.Append(light1Color2);
            colorScheme2.Append(dark2Color2);
            colorScheme2.Append(light2Color2);
            colorScheme2.Append(accent1Color2);
            colorScheme2.Append(accent2Color2);
            colorScheme2.Append(accent3Color2);
            colorScheme2.Append(accent4Color2);
            colorScheme2.Append(accent5Color2);
            colorScheme2.Append(accent6Color2);
            colorScheme2.Append(hyperlink2);
            colorScheme2.Append(followedHyperlinkColor2);

            A.FontScheme fontScheme2 = new A.FontScheme() { Name = "Office" };

            A.MajorFont majorFont2 = new A.MajorFont();
            A.LatinFont latinFont24 = new A.LatinFont() { Typeface = "Calibri" };
            A.EastAsianFont eastAsianFont24 = new A.EastAsianFont() { Typeface = "" };
            A.ComplexScriptFont complexScriptFont24 = new A.ComplexScriptFont() { Typeface = "" };
            A.SupplementalFont supplementalFont95 = new A.SupplementalFont() { Script = "Jpan", Typeface = "ＭＳ Ｐゴシック" };
            A.SupplementalFont supplementalFont96 = new A.SupplementalFont() { Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont97 = new A.SupplementalFont() { Script = "Hans", Typeface = "宋体" };
            A.SupplementalFont supplementalFont98 = new A.SupplementalFont() { Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont99 = new A.SupplementalFont() { Script = "Arab", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont100 = new A.SupplementalFont() { Script = "Hebr", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont101 = new A.SupplementalFont() { Script = "Thai", Typeface = "Angsana New" };
            A.SupplementalFont supplementalFont102 = new A.SupplementalFont() { Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont103 = new A.SupplementalFont() { Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont104 = new A.SupplementalFont() { Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont105 = new A.SupplementalFont() { Script = "Khmr", Typeface = "MoolBoran" };
            A.SupplementalFont supplementalFont106 = new A.SupplementalFont() { Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont107 = new A.SupplementalFont() { Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont108 = new A.SupplementalFont() { Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont109 = new A.SupplementalFont() { Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont110 = new A.SupplementalFont() { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont111 = new A.SupplementalFont() { Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont112 = new A.SupplementalFont() { Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont113 = new A.SupplementalFont() { Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont114 = new A.SupplementalFont() { Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont115 = new A.SupplementalFont() { Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont116 = new A.SupplementalFont() { Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont117 = new A.SupplementalFont() { Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont118 = new A.SupplementalFont() { Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont119 = new A.SupplementalFont() { Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont120 = new A.SupplementalFont() { Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont121 = new A.SupplementalFont() { Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont122 = new A.SupplementalFont() { Script = "Viet", Typeface = "Times New Roman" };
            A.SupplementalFont supplementalFont123 = new A.SupplementalFont() { Script = "Uigh", Typeface = "Microsoft Uighur" };

            majorFont2.Append(latinFont24);
            majorFont2.Append(eastAsianFont24);
            majorFont2.Append(complexScriptFont24);
            majorFont2.Append(supplementalFont95);
            majorFont2.Append(supplementalFont96);
            majorFont2.Append(supplementalFont97);
            majorFont2.Append(supplementalFont98);
            majorFont2.Append(supplementalFont99);
            majorFont2.Append(supplementalFont100);
            majorFont2.Append(supplementalFont101);
            majorFont2.Append(supplementalFont102);
            majorFont2.Append(supplementalFont103);
            majorFont2.Append(supplementalFont104);
            majorFont2.Append(supplementalFont105);
            majorFont2.Append(supplementalFont106);
            majorFont2.Append(supplementalFont107);
            majorFont2.Append(supplementalFont108);
            majorFont2.Append(supplementalFont109);
            majorFont2.Append(supplementalFont110);
            majorFont2.Append(supplementalFont111);
            majorFont2.Append(supplementalFont112);
            majorFont2.Append(supplementalFont113);
            majorFont2.Append(supplementalFont114);
            majorFont2.Append(supplementalFont115);
            majorFont2.Append(supplementalFont116);
            majorFont2.Append(supplementalFont117);
            majorFont2.Append(supplementalFont118);
            majorFont2.Append(supplementalFont119);
            majorFont2.Append(supplementalFont120);
            majorFont2.Append(supplementalFont121);
            majorFont2.Append(supplementalFont122);
            majorFont2.Append(supplementalFont123);

            A.MinorFont minorFont2 = new A.MinorFont();
            A.LatinFont latinFont25 = new A.LatinFont() { Typeface = "Calibri" };
            A.EastAsianFont eastAsianFont25 = new A.EastAsianFont() { Typeface = "" };
            A.ComplexScriptFont complexScriptFont25 = new A.ComplexScriptFont() { Typeface = "" };
            A.SupplementalFont supplementalFont124 = new A.SupplementalFont() { Script = "Jpan", Typeface = "ＭＳ Ｐゴシック" };
            A.SupplementalFont supplementalFont125 = new A.SupplementalFont() { Script = "Hang", Typeface = "맑은 고딕" };
            A.SupplementalFont supplementalFont126 = new A.SupplementalFont() { Script = "Hans", Typeface = "宋体" };
            A.SupplementalFont supplementalFont127 = new A.SupplementalFont() { Script = "Hant", Typeface = "新細明體" };
            A.SupplementalFont supplementalFont128 = new A.SupplementalFont() { Script = "Arab", Typeface = "Arial" };
            A.SupplementalFont supplementalFont129 = new A.SupplementalFont() { Script = "Hebr", Typeface = "Arial" };
            A.SupplementalFont supplementalFont130 = new A.SupplementalFont() { Script = "Thai", Typeface = "Cordia New" };
            A.SupplementalFont supplementalFont131 = new A.SupplementalFont() { Script = "Ethi", Typeface = "Nyala" };
            A.SupplementalFont supplementalFont132 = new A.SupplementalFont() { Script = "Beng", Typeface = "Vrinda" };
            A.SupplementalFont supplementalFont133 = new A.SupplementalFont() { Script = "Gujr", Typeface = "Shruti" };
            A.SupplementalFont supplementalFont134 = new A.SupplementalFont() { Script = "Khmr", Typeface = "DaunPenh" };
            A.SupplementalFont supplementalFont135 = new A.SupplementalFont() { Script = "Knda", Typeface = "Tunga" };
            A.SupplementalFont supplementalFont136 = new A.SupplementalFont() { Script = "Guru", Typeface = "Raavi" };
            A.SupplementalFont supplementalFont137 = new A.SupplementalFont() { Script = "Cans", Typeface = "Euphemia" };
            A.SupplementalFont supplementalFont138 = new A.SupplementalFont() { Script = "Cher", Typeface = "Plantagenet Cherokee" };
            A.SupplementalFont supplementalFont139 = new A.SupplementalFont() { Script = "Yiii", Typeface = "Microsoft Yi Baiti" };
            A.SupplementalFont supplementalFont140 = new A.SupplementalFont() { Script = "Tibt", Typeface = "Microsoft Himalaya" };
            A.SupplementalFont supplementalFont141 = new A.SupplementalFont() { Script = "Thaa", Typeface = "MV Boli" };
            A.SupplementalFont supplementalFont142 = new A.SupplementalFont() { Script = "Deva", Typeface = "Mangal" };
            A.SupplementalFont supplementalFont143 = new A.SupplementalFont() { Script = "Telu", Typeface = "Gautami" };
            A.SupplementalFont supplementalFont144 = new A.SupplementalFont() { Script = "Taml", Typeface = "Latha" };
            A.SupplementalFont supplementalFont145 = new A.SupplementalFont() { Script = "Syrc", Typeface = "Estrangelo Edessa" };
            A.SupplementalFont supplementalFont146 = new A.SupplementalFont() { Script = "Orya", Typeface = "Kalinga" };
            A.SupplementalFont supplementalFont147 = new A.SupplementalFont() { Script = "Mlym", Typeface = "Kartika" };
            A.SupplementalFont supplementalFont148 = new A.SupplementalFont() { Script = "Laoo", Typeface = "DokChampa" };
            A.SupplementalFont supplementalFont149 = new A.SupplementalFont() { Script = "Sinh", Typeface = "Iskoola Pota" };
            A.SupplementalFont supplementalFont150 = new A.SupplementalFont() { Script = "Mong", Typeface = "Mongolian Baiti" };
            A.SupplementalFont supplementalFont151 = new A.SupplementalFont() { Script = "Viet", Typeface = "Arial" };
            A.SupplementalFont supplementalFont152 = new A.SupplementalFont() { Script = "Uigh", Typeface = "Microsoft Uighur" };

            minorFont2.Append(latinFont25);
            minorFont2.Append(eastAsianFont25);
            minorFont2.Append(complexScriptFont25);
            minorFont2.Append(supplementalFont124);
            minorFont2.Append(supplementalFont125);
            minorFont2.Append(supplementalFont126);
            minorFont2.Append(supplementalFont127);
            minorFont2.Append(supplementalFont128);
            minorFont2.Append(supplementalFont129);
            minorFont2.Append(supplementalFont130);
            minorFont2.Append(supplementalFont131);
            minorFont2.Append(supplementalFont132);
            minorFont2.Append(supplementalFont133);
            minorFont2.Append(supplementalFont134);
            minorFont2.Append(supplementalFont135);
            minorFont2.Append(supplementalFont136);
            minorFont2.Append(supplementalFont137);
            minorFont2.Append(supplementalFont138);
            minorFont2.Append(supplementalFont139);
            minorFont2.Append(supplementalFont140);
            minorFont2.Append(supplementalFont141);
            minorFont2.Append(supplementalFont142);
            minorFont2.Append(supplementalFont143);
            minorFont2.Append(supplementalFont144);
            minorFont2.Append(supplementalFont145);
            minorFont2.Append(supplementalFont146);
            minorFont2.Append(supplementalFont147);
            minorFont2.Append(supplementalFont148);
            minorFont2.Append(supplementalFont149);
            minorFont2.Append(supplementalFont150);
            minorFont2.Append(supplementalFont151);
            minorFont2.Append(supplementalFont152);

            fontScheme2.Append(majorFont2);
            fontScheme2.Append(minorFont2);

            A.FormatScheme formatScheme2 = new A.FormatScheme() { Name = "Office" };

            A.FillStyleList fillStyleList2 = new A.FillStyleList();

            A.SolidFill solidFill43 = new A.SolidFill();
            A.SchemeColor schemeColor56 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill43.Append(schemeColor56);

            A.GradientFill gradientFill4 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList4 = new A.GradientStopList();

            A.GradientStop gradientStop10 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor57 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint11 = new A.Tint() { Val = 50000 };
            A.SaturationModulation saturationModulation11 = new A.SaturationModulation() { Val = 300000 };

            schemeColor57.Append(tint11);
            schemeColor57.Append(saturationModulation11);

            gradientStop10.Append(schemeColor57);

            A.GradientStop gradientStop11 = new A.GradientStop() { Position = 35000 };

            A.SchemeColor schemeColor58 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint12 = new A.Tint() { Val = 37000 };
            A.SaturationModulation saturationModulation12 = new A.SaturationModulation() { Val = 300000 };

            schemeColor58.Append(tint12);
            schemeColor58.Append(saturationModulation12);

            gradientStop11.Append(schemeColor58);

            A.GradientStop gradientStop12 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor59 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint13 = new A.Tint() { Val = 15000 };
            A.SaturationModulation saturationModulation13 = new A.SaturationModulation() { Val = 350000 };

            schemeColor59.Append(tint13);
            schemeColor59.Append(saturationModulation13);

            gradientStop12.Append(schemeColor59);

            gradientStopList4.Append(gradientStop10);
            gradientStopList4.Append(gradientStop11);
            gradientStopList4.Append(gradientStop12);
            A.LinearGradientFill linearGradientFill4 = new A.LinearGradientFill() { Angle = 16200000, Scaled = true };

            gradientFill4.Append(gradientStopList4);
            gradientFill4.Append(linearGradientFill4);

            A.GradientFill gradientFill5 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList5 = new A.GradientStopList();

            A.GradientStop gradientStop13 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor60 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade6 = new A.Shade() { Val = 51000 };
            A.SaturationModulation saturationModulation14 = new A.SaturationModulation() { Val = 130000 };

            schemeColor60.Append(shade6);
            schemeColor60.Append(saturationModulation14);

            gradientStop13.Append(schemeColor60);

            A.GradientStop gradientStop14 = new A.GradientStop() { Position = 80000 };

            A.SchemeColor schemeColor61 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade7 = new A.Shade() { Val = 93000 };
            A.SaturationModulation saturationModulation15 = new A.SaturationModulation() { Val = 130000 };

            schemeColor61.Append(shade7);
            schemeColor61.Append(saturationModulation15);

            gradientStop14.Append(schemeColor61);

            A.GradientStop gradientStop15 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor62 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade8 = new A.Shade() { Val = 94000 };
            A.SaturationModulation saturationModulation16 = new A.SaturationModulation() { Val = 135000 };

            schemeColor62.Append(shade8);
            schemeColor62.Append(saturationModulation16);

            gradientStop15.Append(schemeColor62);

            gradientStopList5.Append(gradientStop13);
            gradientStopList5.Append(gradientStop14);
            gradientStopList5.Append(gradientStop15);
            A.LinearGradientFill linearGradientFill5 = new A.LinearGradientFill() { Angle = 16200000, Scaled = false };

            gradientFill5.Append(gradientStopList5);
            gradientFill5.Append(linearGradientFill5);

            fillStyleList2.Append(solidFill43);
            fillStyleList2.Append(gradientFill4);
            fillStyleList2.Append(gradientFill5);

            A.LineStyleList lineStyleList2 = new A.LineStyleList();

            A.Outline outline18 = new A.Outline() { Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill44 = new A.SolidFill();

            A.SchemeColor schemeColor63 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade9 = new A.Shade() { Val = 95000 };
            A.SaturationModulation saturationModulation17 = new A.SaturationModulation() { Val = 105000 };

            schemeColor63.Append(shade9);
            schemeColor63.Append(saturationModulation17);

            solidFill44.Append(schemeColor63);
            A.PresetDash presetDash4 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };

            outline18.Append(solidFill44);
            outline18.Append(presetDash4);

            A.Outline outline19 = new A.Outline() { Width = 25400, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill45 = new A.SolidFill();
            A.SchemeColor schemeColor64 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill45.Append(schemeColor64);
            A.PresetDash presetDash5 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };

            outline19.Append(solidFill45);
            outline19.Append(presetDash5);

            A.Outline outline20 = new A.Outline() { Width = 38100, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill46 = new A.SolidFill();
            A.SchemeColor schemeColor65 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill46.Append(schemeColor65);
            A.PresetDash presetDash6 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };

            outline20.Append(solidFill46);
            outline20.Append(presetDash6);

            lineStyleList2.Append(outline18);
            lineStyleList2.Append(outline19);
            lineStyleList2.Append(outline20);

            A.EffectStyleList effectStyleList2 = new A.EffectStyleList();

            A.EffectStyle effectStyle4 = new A.EffectStyle();

            A.EffectList effectList5 = new A.EffectList();

            A.OuterShadow outerShadow2 = new A.OuterShadow() { BlurRadius = 40000L, Distance = 20000L, Direction = 5400000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex43 = new A.RgbColorModelHex() { Val = "000000" };
            A.Alpha alpha2 = new A.Alpha() { Val = 38000 };

            rgbColorModelHex43.Append(alpha2);

            outerShadow2.Append(rgbColorModelHex43);

            effectList5.Append(outerShadow2);

            effectStyle4.Append(effectList5);

            A.EffectStyle effectStyle5 = new A.EffectStyle();

            A.EffectList effectList6 = new A.EffectList();

            A.OuterShadow outerShadow3 = new A.OuterShadow() { BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex44 = new A.RgbColorModelHex() { Val = "000000" };
            A.Alpha alpha3 = new A.Alpha() { Val = 35000 };

            rgbColorModelHex44.Append(alpha3);

            outerShadow3.Append(rgbColorModelHex44);

            effectList6.Append(outerShadow3);

            effectStyle5.Append(effectList6);

            A.EffectStyle effectStyle6 = new A.EffectStyle();

            A.EffectList effectList7 = new A.EffectList();

            A.OuterShadow outerShadow4 = new A.OuterShadow() { BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex45 = new A.RgbColorModelHex() { Val = "000000" };
            A.Alpha alpha4 = new A.Alpha() { Val = 35000 };

            rgbColorModelHex45.Append(alpha4);

            outerShadow4.Append(rgbColorModelHex45);

            effectList7.Append(outerShadow4);

            A.Scene3DType scene3DType1 = new A.Scene3DType();

            A.Camera camera1 = new A.Camera() { Preset = A.PresetCameraValues.OrthographicFront };
            A.Rotation rotation1 = new A.Rotation() { Latitude = 0, Longitude = 0, Revolution = 0 };

            camera1.Append(rotation1);

            A.LightRig lightRig1 = new A.LightRig() { Rig = A.LightRigValues.ThreePoints, Direction = A.LightRigDirectionValues.Top };
            A.Rotation rotation2 = new A.Rotation() { Latitude = 0, Longitude = 0, Revolution = 1200000 };

            lightRig1.Append(rotation2);

            scene3DType1.Append(camera1);
            scene3DType1.Append(lightRig1);

            A.Shape3DType shape3DType1 = new A.Shape3DType();
            A.BevelTop bevelTop1 = new A.BevelTop() { Width = 63500L, Height = 25400L };

            shape3DType1.Append(bevelTop1);

            effectStyle6.Append(effectList7);
            effectStyle6.Append(scene3DType1);
            effectStyle6.Append(shape3DType1);

            effectStyleList2.Append(effectStyle4);
            effectStyleList2.Append(effectStyle5);
            effectStyleList2.Append(effectStyle6);

            A.BackgroundFillStyleList backgroundFillStyleList2 = new A.BackgroundFillStyleList();

            A.SolidFill solidFill47 = new A.SolidFill();
            A.SchemeColor schemeColor66 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill47.Append(schemeColor66);

            A.GradientFill gradientFill6 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList6 = new A.GradientStopList();

            A.GradientStop gradientStop16 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor67 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint14 = new A.Tint() { Val = 40000 };
            A.SaturationModulation saturationModulation18 = new A.SaturationModulation() { Val = 350000 };

            schemeColor67.Append(tint14);
            schemeColor67.Append(saturationModulation18);

            gradientStop16.Append(schemeColor67);

            A.GradientStop gradientStop17 = new A.GradientStop() { Position = 40000 };

            A.SchemeColor schemeColor68 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint15 = new A.Tint() { Val = 45000 };
            A.Shade shade10 = new A.Shade() { Val = 99000 };
            A.SaturationModulation saturationModulation19 = new A.SaturationModulation() { Val = 350000 };

            schemeColor68.Append(tint15);
            schemeColor68.Append(shade10);
            schemeColor68.Append(saturationModulation19);

            gradientStop17.Append(schemeColor68);

            A.GradientStop gradientStop18 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor69 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade11 = new A.Shade() { Val = 20000 };
            A.SaturationModulation saturationModulation20 = new A.SaturationModulation() { Val = 255000 };

            schemeColor69.Append(shade11);
            schemeColor69.Append(saturationModulation20);

            gradientStop18.Append(schemeColor69);

            gradientStopList6.Append(gradientStop16);
            gradientStopList6.Append(gradientStop17);
            gradientStopList6.Append(gradientStop18);

            A.PathGradientFill pathGradientFill1 = new A.PathGradientFill() { Path = A.PathShadeValues.Circle };
            A.FillToRectangle fillToRectangle1 = new A.FillToRectangle() { Left = 50000, Top = -80000, Right = 50000, Bottom = 180000 };

            pathGradientFill1.Append(fillToRectangle1);

            gradientFill6.Append(gradientStopList6);
            gradientFill6.Append(pathGradientFill1);

            A.GradientFill gradientFill7 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList7 = new A.GradientStopList();

            A.GradientStop gradientStop19 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor70 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint16 = new A.Tint() { Val = 80000 };
            A.SaturationModulation saturationModulation21 = new A.SaturationModulation() { Val = 300000 };

            schemeColor70.Append(tint16);
            schemeColor70.Append(saturationModulation21);

            gradientStop19.Append(schemeColor70);

            A.GradientStop gradientStop20 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor71 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade12 = new A.Shade() { Val = 30000 };
            A.SaturationModulation saturationModulation22 = new A.SaturationModulation() { Val = 200000 };

            schemeColor71.Append(shade12);
            schemeColor71.Append(saturationModulation22);

            gradientStop20.Append(schemeColor71);

            gradientStopList7.Append(gradientStop19);
            gradientStopList7.Append(gradientStop20);

            A.PathGradientFill pathGradientFill2 = new A.PathGradientFill() { Path = A.PathShadeValues.Circle };
            A.FillToRectangle fillToRectangle2 = new A.FillToRectangle() { Left = 50000, Top = 50000, Right = 50000, Bottom = 50000 };

            pathGradientFill2.Append(fillToRectangle2);

            gradientFill7.Append(gradientStopList7);
            gradientFill7.Append(pathGradientFill2);

            backgroundFillStyleList2.Append(solidFill47);
            backgroundFillStyleList2.Append(gradientFill6);
            backgroundFillStyleList2.Append(gradientFill7);

            formatScheme2.Append(fillStyleList2);
            formatScheme2.Append(lineStyleList2);
            formatScheme2.Append(effectStyleList2);
            formatScheme2.Append(backgroundFillStyleList2);

            themeElements2.Append(colorScheme2);
            themeElements2.Append(fontScheme2);
            themeElements2.Append(formatScheme2);
            A.ObjectDefaults objectDefaults2 = new A.ObjectDefaults();
            A.ExtraColorSchemeList extraColorSchemeList2 = new A.ExtraColorSchemeList();

            theme2.Append(themeElements2);
            theme2.Append(objectDefaults2);
            theme2.Append(extraColorSchemeList2);

            themePart2.Theme = theme2;
        }

        public static void GenerateThemePart3Content(ThemePart themePart3)
        {
            A.Theme theme3 = new A.Theme() { Name = "NAS001_FINRA_Presentation_071907" };
            theme3.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.ThemeElements themeElements3 = new A.ThemeElements();

            A.ColorScheme colorScheme3 = new A.ColorScheme() { Name = "" };

            A.Dark1Color dark1Color3 = new A.Dark1Color();
            A.RgbColorModelHex rgbColorModelHex46 = new A.RgbColorModelHex() { Val = "000000" };

            dark1Color3.Append(rgbColorModelHex46);

            A.Light1Color light1Color3 = new A.Light1Color();
            A.RgbColorModelHex rgbColorModelHex47 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            light1Color3.Append(rgbColorModelHex47);

            A.Dark2Color dark2Color3 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex48 = new A.RgbColorModelHex() { Val = "58595B" };

            dark2Color3.Append(rgbColorModelHex48);

            A.Light2Color light2Color3 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex49 = new A.RgbColorModelHex() { Val = "3B3D3C" };

            light2Color3.Append(rgbColorModelHex49);

            A.Accent1Color accent1Color3 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex50 = new A.RgbColorModelHex() { Val = "E6E7E8" };

            accent1Color3.Append(rgbColorModelHex50);

            A.Accent2Color accent2Color3 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex51 = new A.RgbColorModelHex() { Val = "1B75BC" };

            accent2Color3.Append(rgbColorModelHex51);

            A.Accent3Color accent3Color3 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex52 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            accent3Color3.Append(rgbColorModelHex52);

            A.Accent4Color accent4Color3 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex53 = new A.RgbColorModelHex() { Val = "000000" };

            accent4Color3.Append(rgbColorModelHex53);

            A.Accent5Color accent5Color3 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex54 = new A.RgbColorModelHex() { Val = "F0F1F2" };

            accent5Color3.Append(rgbColorModelHex54);

            A.Accent6Color accent6Color3 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex55 = new A.RgbColorModelHex() { Val = "1769AA" };

            accent6Color3.Append(rgbColorModelHex55);

            A.Hyperlink hyperlink3 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex56 = new A.RgbColorModelHex() { Val = "9E1F63" };

            hyperlink3.Append(rgbColorModelHex56);

            A.FollowedHyperlinkColor followedHyperlinkColor3 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex57 = new A.RgbColorModelHex() { Val = "009344" };

            followedHyperlinkColor3.Append(rgbColorModelHex57);

            colorScheme3.Append(dark1Color3);
            colorScheme3.Append(light1Color3);
            colorScheme3.Append(dark2Color3);
            colorScheme3.Append(light2Color3);
            colorScheme3.Append(accent1Color3);
            colorScheme3.Append(accent2Color3);
            colorScheme3.Append(accent3Color3);
            colorScheme3.Append(accent4Color3);
            colorScheme3.Append(accent5Color3);
            colorScheme3.Append(accent6Color3);
            colorScheme3.Append(hyperlink3);
            colorScheme3.Append(followedHyperlinkColor3);

            A.FontScheme fontScheme3 = new A.FontScheme() { Name = "NAS001_FINRA_Presentation_071907" };

            A.MajorFont majorFont3 = new A.MajorFont();
            A.LatinFont latinFont26 = new A.LatinFont() { Typeface = "Arial" };
            A.EastAsianFont eastAsianFont26 = new A.EastAsianFont() { Typeface = "ＭＳ Ｐゴシック" };
            A.ComplexScriptFont complexScriptFont26 = new A.ComplexScriptFont() { Typeface = "" };

            majorFont3.Append(latinFont26);
            majorFont3.Append(eastAsianFont26);
            majorFont3.Append(complexScriptFont26);

            A.MinorFont minorFont3 = new A.MinorFont();
            A.LatinFont latinFont27 = new A.LatinFont() { Typeface = "Arial" };
            A.EastAsianFont eastAsianFont27 = new A.EastAsianFont() { Typeface = "ＭＳ Ｐゴシック" };
            A.ComplexScriptFont complexScriptFont27 = new A.ComplexScriptFont() { Typeface = "" };

            minorFont3.Append(latinFont27);
            minorFont3.Append(eastAsianFont27);
            minorFont3.Append(complexScriptFont27);

            fontScheme3.Append(majorFont3);
            fontScheme3.Append(minorFont3);

            A.FormatScheme formatScheme3 = new A.FormatScheme() { Name = "Office" };

            A.FillStyleList fillStyleList3 = new A.FillStyleList();

            A.SolidFill solidFill48 = new A.SolidFill();
            A.SchemeColor schemeColor72 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill48.Append(schemeColor72);

            A.GradientFill gradientFill8 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList8 = new A.GradientStopList();

            A.GradientStop gradientStop21 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor73 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint17 = new A.Tint() { Val = 50000 };
            A.SaturationModulation saturationModulation23 = new A.SaturationModulation() { Val = 300000 };

            schemeColor73.Append(tint17);
            schemeColor73.Append(saturationModulation23);

            gradientStop21.Append(schemeColor73);

            A.GradientStop gradientStop22 = new A.GradientStop() { Position = 35000 };

            A.SchemeColor schemeColor74 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint18 = new A.Tint() { Val = 37000 };
            A.SaturationModulation saturationModulation24 = new A.SaturationModulation() { Val = 300000 };

            schemeColor74.Append(tint18);
            schemeColor74.Append(saturationModulation24);

            gradientStop22.Append(schemeColor74);

            A.GradientStop gradientStop23 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor75 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint19 = new A.Tint() { Val = 15000 };
            A.SaturationModulation saturationModulation25 = new A.SaturationModulation() { Val = 350000 };

            schemeColor75.Append(tint19);
            schemeColor75.Append(saturationModulation25);

            gradientStop23.Append(schemeColor75);

            gradientStopList8.Append(gradientStop21);
            gradientStopList8.Append(gradientStop22);
            gradientStopList8.Append(gradientStop23);
            A.LinearGradientFill linearGradientFill6 = new A.LinearGradientFill() { Angle = 16200000, Scaled = true };

            gradientFill8.Append(gradientStopList8);
            gradientFill8.Append(linearGradientFill6);

            A.GradientFill gradientFill9 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList9 = new A.GradientStopList();

            A.GradientStop gradientStop24 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor76 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade13 = new A.Shade() { Val = 51000 };
            A.SaturationModulation saturationModulation26 = new A.SaturationModulation() { Val = 130000 };

            schemeColor76.Append(shade13);
            schemeColor76.Append(saturationModulation26);

            gradientStop24.Append(schemeColor76);

            A.GradientStop gradientStop25 = new A.GradientStop() { Position = 80000 };

            A.SchemeColor schemeColor77 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade14 = new A.Shade() { Val = 93000 };
            A.SaturationModulation saturationModulation27 = new A.SaturationModulation() { Val = 130000 };

            schemeColor77.Append(shade14);
            schemeColor77.Append(saturationModulation27);

            gradientStop25.Append(schemeColor77);

            A.GradientStop gradientStop26 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor78 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade15 = new A.Shade() { Val = 94000 };
            A.SaturationModulation saturationModulation28 = new A.SaturationModulation() { Val = 135000 };

            schemeColor78.Append(shade15);
            schemeColor78.Append(saturationModulation28);

            gradientStop26.Append(schemeColor78);

            gradientStopList9.Append(gradientStop24);
            gradientStopList9.Append(gradientStop25);
            gradientStopList9.Append(gradientStop26);
            A.LinearGradientFill linearGradientFill7 = new A.LinearGradientFill() { Angle = 16200000, Scaled = false };

            gradientFill9.Append(gradientStopList9);
            gradientFill9.Append(linearGradientFill7);

            fillStyleList3.Append(solidFill48);
            fillStyleList3.Append(gradientFill8);
            fillStyleList3.Append(gradientFill9);

            A.LineStyleList lineStyleList3 = new A.LineStyleList();

            A.Outline outline21 = new A.Outline() { Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill49 = new A.SolidFill();

            A.SchemeColor schemeColor79 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade16 = new A.Shade() { Val = 95000 };
            A.SaturationModulation saturationModulation29 = new A.SaturationModulation() { Val = 105000 };

            schemeColor79.Append(shade16);
            schemeColor79.Append(saturationModulation29);

            solidFill49.Append(schemeColor79);
            A.PresetDash presetDash7 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };

            outline21.Append(solidFill49);
            outline21.Append(presetDash7);

            A.Outline outline22 = new A.Outline() { Width = 25400, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill50 = new A.SolidFill();
            A.SchemeColor schemeColor80 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill50.Append(schemeColor80);
            A.PresetDash presetDash8 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };

            outline22.Append(solidFill50);
            outline22.Append(presetDash8);

            A.Outline outline23 = new A.Outline() { Width = 38100, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill51 = new A.SolidFill();
            A.SchemeColor schemeColor81 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill51.Append(schemeColor81);
            A.PresetDash presetDash9 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };

            outline23.Append(solidFill51);
            outline23.Append(presetDash9);

            lineStyleList3.Append(outline21);
            lineStyleList3.Append(outline22);
            lineStyleList3.Append(outline23);

            A.EffectStyleList effectStyleList3 = new A.EffectStyleList();

            A.EffectStyle effectStyle7 = new A.EffectStyle();

            A.EffectList effectList8 = new A.EffectList();

            A.OuterShadow outerShadow5 = new A.OuterShadow() { BlurRadius = 40000L, Distance = 20000L, Direction = 5400000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex58 = new A.RgbColorModelHex() { Val = "000000" };
            A.Alpha alpha5 = new A.Alpha() { Val = 38000 };

            rgbColorModelHex58.Append(alpha5);

            outerShadow5.Append(rgbColorModelHex58);

            effectList8.Append(outerShadow5);

            effectStyle7.Append(effectList8);

            A.EffectStyle effectStyle8 = new A.EffectStyle();

            A.EffectList effectList9 = new A.EffectList();

            A.OuterShadow outerShadow6 = new A.OuterShadow() { BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex59 = new A.RgbColorModelHex() { Val = "000000" };
            A.Alpha alpha6 = new A.Alpha() { Val = 35000 };

            rgbColorModelHex59.Append(alpha6);

            outerShadow6.Append(rgbColorModelHex59);

            effectList9.Append(outerShadow6);

            effectStyle8.Append(effectList9);

            A.EffectStyle effectStyle9 = new A.EffectStyle();

            A.EffectList effectList10 = new A.EffectList();

            A.OuterShadow outerShadow7 = new A.OuterShadow() { BlurRadius = 40000L, Distance = 23000L, Direction = 5400000, RotateWithShape = false };

            A.RgbColorModelHex rgbColorModelHex60 = new A.RgbColorModelHex() { Val = "000000" };
            A.Alpha alpha7 = new A.Alpha() { Val = 35000 };

            rgbColorModelHex60.Append(alpha7);

            outerShadow7.Append(rgbColorModelHex60);

            effectList10.Append(outerShadow7);

            A.Scene3DType scene3DType2 = new A.Scene3DType();

            A.Camera camera2 = new A.Camera() { Preset = A.PresetCameraValues.OrthographicFront };
            A.Rotation rotation3 = new A.Rotation() { Latitude = 0, Longitude = 0, Revolution = 0 };

            camera2.Append(rotation3);

            A.LightRig lightRig2 = new A.LightRig() { Rig = A.LightRigValues.ThreePoints, Direction = A.LightRigDirectionValues.Top };
            A.Rotation rotation4 = new A.Rotation() { Latitude = 0, Longitude = 0, Revolution = 1200000 };

            lightRig2.Append(rotation4);

            scene3DType2.Append(camera2);
            scene3DType2.Append(lightRig2);

            A.Shape3DType shape3DType2 = new A.Shape3DType();
            A.BevelTop bevelTop2 = new A.BevelTop() { Width = 63500L, Height = 25400L };

            shape3DType2.Append(bevelTop2);

            effectStyle9.Append(effectList10);
            effectStyle9.Append(scene3DType2);
            effectStyle9.Append(shape3DType2);

            effectStyleList3.Append(effectStyle7);
            effectStyleList3.Append(effectStyle8);
            effectStyleList3.Append(effectStyle9);

            A.BackgroundFillStyleList backgroundFillStyleList3 = new A.BackgroundFillStyleList();

            A.SolidFill solidFill52 = new A.SolidFill();
            A.SchemeColor schemeColor82 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };

            solidFill52.Append(schemeColor82);

            A.GradientFill gradientFill10 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList10 = new A.GradientStopList();

            A.GradientStop gradientStop27 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor83 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint20 = new A.Tint() { Val = 40000 };
            A.SaturationModulation saturationModulation30 = new A.SaturationModulation() { Val = 350000 };

            schemeColor83.Append(tint20);
            schemeColor83.Append(saturationModulation30);

            gradientStop27.Append(schemeColor83);

            A.GradientStop gradientStop28 = new A.GradientStop() { Position = 40000 };

            A.SchemeColor schemeColor84 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint21 = new A.Tint() { Val = 45000 };
            A.Shade shade17 = new A.Shade() { Val = 99000 };
            A.SaturationModulation saturationModulation31 = new A.SaturationModulation() { Val = 350000 };

            schemeColor84.Append(tint21);
            schemeColor84.Append(shade17);
            schemeColor84.Append(saturationModulation31);

            gradientStop28.Append(schemeColor84);

            A.GradientStop gradientStop29 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor85 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade18 = new A.Shade() { Val = 20000 };
            A.SaturationModulation saturationModulation32 = new A.SaturationModulation() { Val = 255000 };

            schemeColor85.Append(shade18);
            schemeColor85.Append(saturationModulation32);

            gradientStop29.Append(schemeColor85);

            gradientStopList10.Append(gradientStop27);
            gradientStopList10.Append(gradientStop28);
            gradientStopList10.Append(gradientStop29);

            A.PathGradientFill pathGradientFill3 = new A.PathGradientFill() { Path = A.PathShadeValues.Circle };
            A.FillToRectangle fillToRectangle3 = new A.FillToRectangle() { Left = 50000, Top = -80000, Right = 50000, Bottom = 180000 };

            pathGradientFill3.Append(fillToRectangle3);

            gradientFill10.Append(gradientStopList10);
            gradientFill10.Append(pathGradientFill3);

            A.GradientFill gradientFill11 = new A.GradientFill() { RotateWithShape = true };

            A.GradientStopList gradientStopList11 = new A.GradientStopList();

            A.GradientStop gradientStop30 = new A.GradientStop() { Position = 0 };

            A.SchemeColor schemeColor86 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Tint tint22 = new A.Tint() { Val = 80000 };
            A.SaturationModulation saturationModulation33 = new A.SaturationModulation() { Val = 300000 };

            schemeColor86.Append(tint22);
            schemeColor86.Append(saturationModulation33);

            gradientStop30.Append(schemeColor86);

            A.GradientStop gradientStop31 = new A.GradientStop() { Position = 100000 };

            A.SchemeColor schemeColor87 = new A.SchemeColor() { Val = A.SchemeColorValues.PhColor };
            A.Shade shade19 = new A.Shade() { Val = 30000 };
            A.SaturationModulation saturationModulation34 = new A.SaturationModulation() { Val = 200000 };

            schemeColor87.Append(shade19);
            schemeColor87.Append(saturationModulation34);

            gradientStop31.Append(schemeColor87);

            gradientStopList11.Append(gradientStop30);
            gradientStopList11.Append(gradientStop31);

            A.PathGradientFill pathGradientFill4 = new A.PathGradientFill() { Path = A.PathShadeValues.Circle };
            A.FillToRectangle fillToRectangle4 = new A.FillToRectangle() { Left = 50000, Top = 50000, Right = 50000, Bottom = 50000 };

            pathGradientFill4.Append(fillToRectangle4);

            gradientFill11.Append(gradientStopList11);
            gradientFill11.Append(pathGradientFill4);

            backgroundFillStyleList3.Append(solidFill52);
            backgroundFillStyleList3.Append(gradientFill10);
            backgroundFillStyleList3.Append(gradientFill11);

            formatScheme3.Append(fillStyleList3);
            formatScheme3.Append(lineStyleList3);
            formatScheme3.Append(effectStyleList3);
            formatScheme3.Append(backgroundFillStyleList3);

            themeElements3.Append(colorScheme3);
            themeElements3.Append(fontScheme3);
            themeElements3.Append(formatScheme3);

            A.ObjectDefaults objectDefaults3 = new A.ObjectDefaults();

            A.ShapeDefault shapeDefault1 = new A.ShapeDefault();

            A.ShapeProperties shapeProperties11 = new A.ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D11 = new A.Transform2D();
            A.Offset offset13 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents13 = new A.Extents() { Cx = 1L, Cy = 1L };

            transform2D11.Append(offset13);
            transform2D11.Append(extents13);

            A.CustomGeometry customGeometry1 = new A.CustomGeometry();
            A.AdjustValueList adjustValueList16 = new A.AdjustValueList();
            A.ShapeGuideList shapeGuideList1 = new A.ShapeGuideList();
            A.AdjustHandleList adjustHandleList1 = new A.AdjustHandleList();
            A.ConnectionSiteList connectionSiteList1 = new A.ConnectionSiteList();
            A.Rectangle rectangle1 = new A.Rectangle() { Left = "0", Top = "0", Right = "0", Bottom = "0" };
            A.PathList pathList1 = new A.PathList();

            customGeometry1.Append(adjustValueList16);
            customGeometry1.Append(shapeGuideList1);
            customGeometry1.Append(adjustHandleList1);
            customGeometry1.Append(connectionSiteList1);
            customGeometry1.Append(rectangle1);
            customGeometry1.Append(pathList1);

            A.SolidFill solidFill53 = new A.SolidFill();
            A.SchemeColor schemeColor88 = new A.SchemeColor() { Val = A.SchemeColorValues.Accent1 };

            solidFill53.Append(schemeColor88);

            A.Outline outline24 = new A.Outline() { Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill54 = new A.SolidFill();
            A.SchemeColor schemeColor89 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill54.Append(schemeColor89);
            A.PresetDash presetDash10 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };
            A.Round round1 = new A.Round();
            A.HeadEnd headEnd7 = new A.HeadEnd() { Type = A.LineEndValues.None, Width = A.LineEndWidthValues.Medium, Length = A.LineEndLengthValues.Medium };
            A.TailEnd tailEnd7 = new A.TailEnd() { Type = A.LineEndValues.None, Width = A.LineEndWidthValues.Medium, Length = A.LineEndLengthValues.Medium };

            outline24.Append(solidFill54);
            outline24.Append(presetDash10);
            outline24.Append(round1);
            outline24.Append(headEnd7);
            outline24.Append(tailEnd7);
            A.EffectList effectList11 = new A.EffectList();

            shapeProperties11.Append(transform2D11);
            shapeProperties11.Append(customGeometry1);
            shapeProperties11.Append(solidFill53);
            shapeProperties11.Append(outline24);
            shapeProperties11.Append(effectList11);

            A.BodyProperties bodyProperties10 = new A.BodyProperties() { Vertical = A.TextVerticalValues.Horizontal, Wrap = A.TextWrappingValues.Square, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, ColumnCount = 1, Anchor = A.TextAnchoringTypeValues.Top, AnchorCenter = false, CompatibleLineSpacing = true };

            A.PresetTextWrap presetTextWrap6 = new A.PresetTextWrap() { Preset = A.TextShapeValues.TextNoShape };
            A.AdjustValueList adjustValueList17 = new A.AdjustValueList();

            presetTextWrap6.Append(adjustValueList17);

            bodyProperties10.Append(presetTextWrap6);

            A.ListStyle listStyle10 = new A.ListStyle();

            A.DefaultParagraphProperties defaultParagraphProperties2 = new A.DefaultParagraphProperties() { LeftMargin = 0, RightMargin = 0, Indent = 0, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, LatinLineBreak = false, Height = false };

            A.LineSpacing lineSpacing1 = new A.LineSpacing();
            A.SpacingPercent spacingPercent21 = new A.SpacingPercent() { Val = 100000 };

            lineSpacing1.Append(spacingPercent21);

            A.SpaceBefore spaceBefore11 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent22 = new A.SpacingPercent() { Val = 0 };

            spaceBefore11.Append(spacingPercent22);

            A.SpaceAfter spaceAfter11 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent23 = new A.SpacingPercent() { Val = 0 };

            spaceAfter11.Append(spacingPercent23);
            A.BulletColorText bulletColorText1 = new A.BulletColorText();
            A.BulletSizeText bulletSizeText1 = new A.BulletSizeText();
            A.BulletFontText bulletFontText1 = new A.BulletFontText();
            A.NoBullet noBullet1 = new A.NoBullet();
            A.TabStopList tabStopList1 = new A.TabStopList();

            A.DefaultRunProperties defaultRunProperties33 = new A.DefaultRunProperties() { Kumimoji = false, Language = "en-US", FontSize = 2400, Bold = false, Italic = false, Underline = A.TextUnderlineValues.None, Strike = A.TextStrikeValues.NoStrike, Capital = A.TextCapsValues.None, NormalizeHeight = false, Baseline = 0 };
            defaultRunProperties33.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));

            A.Outline outline25 = new A.Outline();
            A.NoFill noFill12 = new A.NoFill();

            outline25.Append(noFill12);

            A.SolidFill solidFill55 = new A.SolidFill();
            A.SchemeColor schemeColor90 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill55.Append(schemeColor90);
            A.EffectList effectList12 = new A.EffectList();
            A.LatinFont latinFont28 = new A.LatinFont() { Typeface = "Arial", CharacterSet = 0 };
            A.EastAsianFont eastAsianFont28 = new A.EastAsianFont() { Typeface = "ＭＳ Ｐゴシック", PitchFamily = 1, CharacterSet = -128 };

            defaultRunProperties33.Append(outline25);
            defaultRunProperties33.Append(solidFill55);
            defaultRunProperties33.Append(effectList12);
            defaultRunProperties33.Append(latinFont28);
            defaultRunProperties33.Append(eastAsianFont28);

            defaultParagraphProperties2.Append(lineSpacing1);
            defaultParagraphProperties2.Append(spaceBefore11);
            defaultParagraphProperties2.Append(spaceAfter11);
            defaultParagraphProperties2.Append(bulletColorText1);
            defaultParagraphProperties2.Append(bulletSizeText1);
            defaultParagraphProperties2.Append(bulletFontText1);
            defaultParagraphProperties2.Append(noBullet1);
            defaultParagraphProperties2.Append(tabStopList1);
            defaultParagraphProperties2.Append(defaultRunProperties33);

            listStyle10.Append(defaultParagraphProperties2);

            shapeDefault1.Append(shapeProperties11);
            shapeDefault1.Append(bodyProperties10);
            shapeDefault1.Append(listStyle10);

            A.LineDefault lineDefault1 = new A.LineDefault();

            A.ShapeProperties shapeProperties12 = new A.ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D12 = new A.Transform2D();
            A.Offset offset14 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents14 = new A.Extents() { Cx = 1L, Cy = 1L };

            transform2D12.Append(offset14);
            transform2D12.Append(extents14);

            A.CustomGeometry customGeometry2 = new A.CustomGeometry();
            A.AdjustValueList adjustValueList18 = new A.AdjustValueList();
            A.ShapeGuideList shapeGuideList2 = new A.ShapeGuideList();
            A.AdjustHandleList adjustHandleList2 = new A.AdjustHandleList();
            A.ConnectionSiteList connectionSiteList2 = new A.ConnectionSiteList();
            A.Rectangle rectangle2 = new A.Rectangle() { Left = "0", Top = "0", Right = "0", Bottom = "0" };
            A.PathList pathList2 = new A.PathList();

            customGeometry2.Append(adjustValueList18);
            customGeometry2.Append(shapeGuideList2);
            customGeometry2.Append(adjustHandleList2);
            customGeometry2.Append(connectionSiteList2);
            customGeometry2.Append(rectangle2);
            customGeometry2.Append(pathList2);

            A.SolidFill solidFill56 = new A.SolidFill();
            A.SchemeColor schemeColor91 = new A.SchemeColor() { Val = A.SchemeColorValues.Accent1 };

            solidFill56.Append(schemeColor91);

            A.Outline outline26 = new A.Outline() { Width = 9525, CapType = A.LineCapValues.Flat, CompoundLineType = A.CompoundLineValues.Single, Alignment = A.PenAlignmentValues.Center };

            A.SolidFill solidFill57 = new A.SolidFill();
            A.SchemeColor schemeColor92 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill57.Append(schemeColor92);
            A.PresetDash presetDash11 = new A.PresetDash() { Val = A.PresetLineDashValues.Solid };
            A.Round round2 = new A.Round();
            A.HeadEnd headEnd8 = new A.HeadEnd() { Type = A.LineEndValues.None, Width = A.LineEndWidthValues.Medium, Length = A.LineEndLengthValues.Medium };
            A.TailEnd tailEnd8 = new A.TailEnd() { Type = A.LineEndValues.None, Width = A.LineEndWidthValues.Medium, Length = A.LineEndLengthValues.Medium };

            outline26.Append(solidFill57);
            outline26.Append(presetDash11);
            outline26.Append(round2);
            outline26.Append(headEnd8);
            outline26.Append(tailEnd8);
            A.EffectList effectList13 = new A.EffectList();

            shapeProperties12.Append(transform2D12);
            shapeProperties12.Append(customGeometry2);
            shapeProperties12.Append(solidFill56);
            shapeProperties12.Append(outline26);
            shapeProperties12.Append(effectList13);

            A.BodyProperties bodyProperties11 = new A.BodyProperties() { Vertical = A.TextVerticalValues.Horizontal, Wrap = A.TextWrappingValues.Square, LeftInset = 91440, TopInset = 45720, RightInset = 91440, BottomInset = 45720, ColumnCount = 1, Anchor = A.TextAnchoringTypeValues.Top, AnchorCenter = false, CompatibleLineSpacing = true };

            A.PresetTextWrap presetTextWrap7 = new A.PresetTextWrap() { Preset = A.TextShapeValues.TextNoShape };
            A.AdjustValueList adjustValueList19 = new A.AdjustValueList();

            presetTextWrap7.Append(adjustValueList19);

            bodyProperties11.Append(presetTextWrap7);

            A.ListStyle listStyle11 = new A.ListStyle();

            A.DefaultParagraphProperties defaultParagraphProperties3 = new A.DefaultParagraphProperties() { LeftMargin = 0, RightMargin = 0, Indent = 0, Alignment = A.TextAlignmentTypeValues.Left, DefaultTabSize = 914400, RightToLeft = false, EastAsianLineBreak = false, FontAlignment = A.TextFontAlignmentValues.Baseline, LatinLineBreak = false, Height = false };

            A.LineSpacing lineSpacing2 = new A.LineSpacing();
            A.SpacingPercent spacingPercent24 = new A.SpacingPercent() { Val = 100000 };

            lineSpacing2.Append(spacingPercent24);

            A.SpaceBefore spaceBefore12 = new A.SpaceBefore();
            A.SpacingPercent spacingPercent25 = new A.SpacingPercent() { Val = 0 };

            spaceBefore12.Append(spacingPercent25);

            A.SpaceAfter spaceAfter12 = new A.SpaceAfter();
            A.SpacingPercent spacingPercent26 = new A.SpacingPercent() { Val = 0 };

            spaceAfter12.Append(spacingPercent26);
            A.BulletColorText bulletColorText2 = new A.BulletColorText();
            A.BulletSizeText bulletSizeText2 = new A.BulletSizeText();
            A.BulletFontText bulletFontText2 = new A.BulletFontText();
            A.NoBullet noBullet2 = new A.NoBullet();
            A.TabStopList tabStopList2 = new A.TabStopList();

            A.DefaultRunProperties defaultRunProperties34 = new A.DefaultRunProperties() { Kumimoji = false, Language = "en-US", FontSize = 2400, Bold = false, Italic = false, Underline = A.TextUnderlineValues.None, Strike = A.TextStrikeValues.NoStrike, Capital = A.TextCapsValues.None, NormalizeHeight = false, Baseline = 0 };
            defaultRunProperties34.SetAttribute(new OpenXmlAttribute("", "smtClean", "", "0"));

            A.Outline outline27 = new A.Outline();
            A.NoFill noFill13 = new A.NoFill();

            outline27.Append(noFill13);

            A.SolidFill solidFill58 = new A.SolidFill();
            A.SchemeColor schemeColor93 = new A.SchemeColor() { Val = A.SchemeColorValues.Text1 };

            solidFill58.Append(schemeColor93);
            A.EffectList effectList14 = new A.EffectList();
            A.LatinFont latinFont29 = new A.LatinFont() { Typeface = "Arial", CharacterSet = 0 };
            A.EastAsianFont eastAsianFont29 = new A.EastAsianFont() { Typeface = "ＭＳ Ｐゴシック", PitchFamily = 1, CharacterSet = -128 };

            defaultRunProperties34.Append(outline27);
            defaultRunProperties34.Append(solidFill58);
            defaultRunProperties34.Append(effectList14);
            defaultRunProperties34.Append(latinFont29);
            defaultRunProperties34.Append(eastAsianFont29);

            defaultParagraphProperties3.Append(lineSpacing2);
            defaultParagraphProperties3.Append(spaceBefore12);
            defaultParagraphProperties3.Append(spaceAfter12);
            defaultParagraphProperties3.Append(bulletColorText2);
            defaultParagraphProperties3.Append(bulletSizeText2);
            defaultParagraphProperties3.Append(bulletFontText2);
            defaultParagraphProperties3.Append(noBullet2);
            defaultParagraphProperties3.Append(tabStopList2);
            defaultParagraphProperties3.Append(defaultRunProperties34);

            listStyle11.Append(defaultParagraphProperties3);

            lineDefault1.Append(shapeProperties12);
            lineDefault1.Append(bodyProperties11);
            lineDefault1.Append(listStyle11);

            objectDefaults3.Append(shapeDefault1);
            objectDefaults3.Append(lineDefault1);

            A.ExtraColorSchemeList extraColorSchemeList3 = new A.ExtraColorSchemeList();

            A.ExtraColorScheme extraColorScheme1 = new A.ExtraColorScheme();

            A.ColorScheme colorScheme4 = new A.ColorScheme() { Name = "NAS001_FINRA_Presentation_071907 1" };

            A.Dark1Color dark1Color4 = new A.Dark1Color();
            A.RgbColorModelHex rgbColorModelHex61 = new A.RgbColorModelHex() { Val = "000000" };

            dark1Color4.Append(rgbColorModelHex61);

            A.Light1Color light1Color4 = new A.Light1Color();
            A.RgbColorModelHex rgbColorModelHex62 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            light1Color4.Append(rgbColorModelHex62);

            A.Dark2Color dark2Color4 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex63 = new A.RgbColorModelHex() { Val = "000000" };

            dark2Color4.Append(rgbColorModelHex63);

            A.Light2Color light2Color4 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex64 = new A.RgbColorModelHex() { Val = "808080" };

            light2Color4.Append(rgbColorModelHex64);

            A.Accent1Color accent1Color4 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex65 = new A.RgbColorModelHex() { Val = "BBE0E3" };

            accent1Color4.Append(rgbColorModelHex65);

            A.Accent2Color accent2Color4 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex66 = new A.RgbColorModelHex() { Val = "333399" };

            accent2Color4.Append(rgbColorModelHex66);

            A.Accent3Color accent3Color4 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex67 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            accent3Color4.Append(rgbColorModelHex67);

            A.Accent4Color accent4Color4 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex68 = new A.RgbColorModelHex() { Val = "000000" };

            accent4Color4.Append(rgbColorModelHex68);

            A.Accent5Color accent5Color4 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex69 = new A.RgbColorModelHex() { Val = "DAEDEF" };

            accent5Color4.Append(rgbColorModelHex69);

            A.Accent6Color accent6Color4 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex70 = new A.RgbColorModelHex() { Val = "2D2D8A" };

            accent6Color4.Append(rgbColorModelHex70);

            A.Hyperlink hyperlink4 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex71 = new A.RgbColorModelHex() { Val = "009999" };

            hyperlink4.Append(rgbColorModelHex71);

            A.FollowedHyperlinkColor followedHyperlinkColor4 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex72 = new A.RgbColorModelHex() { Val = "99CC00" };

            followedHyperlinkColor4.Append(rgbColorModelHex72);

            colorScheme4.Append(dark1Color4);
            colorScheme4.Append(light1Color4);
            colorScheme4.Append(dark2Color4);
            colorScheme4.Append(light2Color4);
            colorScheme4.Append(accent1Color4);
            colorScheme4.Append(accent2Color4);
            colorScheme4.Append(accent3Color4);
            colorScheme4.Append(accent4Color4);
            colorScheme4.Append(accent5Color4);
            colorScheme4.Append(accent6Color4);
            colorScheme4.Append(hyperlink4);
            colorScheme4.Append(followedHyperlinkColor4);
            A.ColorMap colorMap3 = new A.ColorMap() { Background1 = A.ColorSchemeIndexValues.Light1, Text1 = A.ColorSchemeIndexValues.Dark1, Background2 = A.ColorSchemeIndexValues.Light2, Text2 = A.ColorSchemeIndexValues.Dark2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            extraColorScheme1.Append(colorScheme4);
            extraColorScheme1.Append(colorMap3);

            A.ExtraColorScheme extraColorScheme2 = new A.ExtraColorScheme();

            A.ColorScheme colorScheme5 = new A.ColorScheme() { Name = "NAS001_FINRA_Presentation_071907 2" };

            A.Dark1Color dark1Color5 = new A.Dark1Color();
            A.RgbColorModelHex rgbColorModelHex73 = new A.RgbColorModelHex() { Val = "000000" };

            dark1Color5.Append(rgbColorModelHex73);

            A.Light1Color light1Color5 = new A.Light1Color();
            A.RgbColorModelHex rgbColorModelHex74 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            light1Color5.Append(rgbColorModelHex74);

            A.Dark2Color dark2Color5 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex75 = new A.RgbColorModelHex() { Val = "000000" };

            dark2Color5.Append(rgbColorModelHex75);

            A.Light2Color light2Color5 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex76 = new A.RgbColorModelHex() { Val = "969696" };

            light2Color5.Append(rgbColorModelHex76);

            A.Accent1Color accent1Color5 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex77 = new A.RgbColorModelHex() { Val = "FBDF53" };

            accent1Color5.Append(rgbColorModelHex77);

            A.Accent2Color accent2Color5 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex78 = new A.RgbColorModelHex() { Val = "FF9966" };

            accent2Color5.Append(rgbColorModelHex78);

            A.Accent3Color accent3Color5 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex79 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            accent3Color5.Append(rgbColorModelHex79);

            A.Accent4Color accent4Color5 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex80 = new A.RgbColorModelHex() { Val = "000000" };

            accent4Color5.Append(rgbColorModelHex80);

            A.Accent5Color accent5Color5 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex81 = new A.RgbColorModelHex() { Val = "FDECB3" };

            accent5Color5.Append(rgbColorModelHex81);

            A.Accent6Color accent6Color5 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex82 = new A.RgbColorModelHex() { Val = "E78A5C" };

            accent6Color5.Append(rgbColorModelHex82);

            A.Hyperlink hyperlink5 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex83 = new A.RgbColorModelHex() { Val = "CC3300" };

            hyperlink5.Append(rgbColorModelHex83);

            A.FollowedHyperlinkColor followedHyperlinkColor5 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex84 = new A.RgbColorModelHex() { Val = "996600" };

            followedHyperlinkColor5.Append(rgbColorModelHex84);

            colorScheme5.Append(dark1Color5);
            colorScheme5.Append(light1Color5);
            colorScheme5.Append(dark2Color5);
            colorScheme5.Append(light2Color5);
            colorScheme5.Append(accent1Color5);
            colorScheme5.Append(accent2Color5);
            colorScheme5.Append(accent3Color5);
            colorScheme5.Append(accent4Color5);
            colorScheme5.Append(accent5Color5);
            colorScheme5.Append(accent6Color5);
            colorScheme5.Append(hyperlink5);
            colorScheme5.Append(followedHyperlinkColor5);
            A.ColorMap colorMap4 = new A.ColorMap() { Background1 = A.ColorSchemeIndexValues.Light1, Text1 = A.ColorSchemeIndexValues.Dark1, Background2 = A.ColorSchemeIndexValues.Light2, Text2 = A.ColorSchemeIndexValues.Dark2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            extraColorScheme2.Append(colorScheme5);
            extraColorScheme2.Append(colorMap4);

            A.ExtraColorScheme extraColorScheme3 = new A.ExtraColorScheme();

            A.ColorScheme colorScheme6 = new A.ColorScheme() { Name = "NAS001_FINRA_Presentation_071907 3" };

            A.Dark1Color dark1Color6 = new A.Dark1Color();
            A.RgbColorModelHex rgbColorModelHex85 = new A.RgbColorModelHex() { Val = "000000" };

            dark1Color6.Append(rgbColorModelHex85);

            A.Light1Color light1Color6 = new A.Light1Color();
            A.RgbColorModelHex rgbColorModelHex86 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            light1Color6.Append(rgbColorModelHex86);

            A.Dark2Color dark2Color6 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex87 = new A.RgbColorModelHex() { Val = "000000" };

            dark2Color6.Append(rgbColorModelHex87);

            A.Light2Color light2Color6 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex88 = new A.RgbColorModelHex() { Val = "808080" };

            light2Color6.Append(rgbColorModelHex88);

            A.Accent1Color accent1Color6 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex89 = new A.RgbColorModelHex() { Val = "99CCFF" };

            accent1Color6.Append(rgbColorModelHex89);

            A.Accent2Color accent2Color6 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex90 = new A.RgbColorModelHex() { Val = "CCCCFF" };

            accent2Color6.Append(rgbColorModelHex90);

            A.Accent3Color accent3Color6 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex91 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            accent3Color6.Append(rgbColorModelHex91);

            A.Accent4Color accent4Color6 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex92 = new A.RgbColorModelHex() { Val = "000000" };

            accent4Color6.Append(rgbColorModelHex92);

            A.Accent5Color accent5Color6 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex93 = new A.RgbColorModelHex() { Val = "CAE2FF" };

            accent5Color6.Append(rgbColorModelHex93);

            A.Accent6Color accent6Color6 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex94 = new A.RgbColorModelHex() { Val = "B9B9E7" };

            accent6Color6.Append(rgbColorModelHex94);

            A.Hyperlink hyperlink6 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex95 = new A.RgbColorModelHex() { Val = "3333CC" };

            hyperlink6.Append(rgbColorModelHex95);

            A.FollowedHyperlinkColor followedHyperlinkColor6 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex96 = new A.RgbColorModelHex() { Val = "AF67FF" };

            followedHyperlinkColor6.Append(rgbColorModelHex96);

            colorScheme6.Append(dark1Color6);
            colorScheme6.Append(light1Color6);
            colorScheme6.Append(dark2Color6);
            colorScheme6.Append(light2Color6);
            colorScheme6.Append(accent1Color6);
            colorScheme6.Append(accent2Color6);
            colorScheme6.Append(accent3Color6);
            colorScheme6.Append(accent4Color6);
            colorScheme6.Append(accent5Color6);
            colorScheme6.Append(accent6Color6);
            colorScheme6.Append(hyperlink6);
            colorScheme6.Append(followedHyperlinkColor6);
            A.ColorMap colorMap5 = new A.ColorMap() { Background1 = A.ColorSchemeIndexValues.Light1, Text1 = A.ColorSchemeIndexValues.Dark1, Background2 = A.ColorSchemeIndexValues.Light2, Text2 = A.ColorSchemeIndexValues.Dark2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            extraColorScheme3.Append(colorScheme6);
            extraColorScheme3.Append(colorMap5);

            A.ExtraColorScheme extraColorScheme4 = new A.ExtraColorScheme();

            A.ColorScheme colorScheme7 = new A.ColorScheme() { Name = "NAS001_FINRA_Presentation_071907 4" };

            A.Dark1Color dark1Color7 = new A.Dark1Color();
            A.RgbColorModelHex rgbColorModelHex97 = new A.RgbColorModelHex() { Val = "000000" };

            dark1Color7.Append(rgbColorModelHex97);

            A.Light1Color light1Color7 = new A.Light1Color();
            A.RgbColorModelHex rgbColorModelHex98 = new A.RgbColorModelHex() { Val = "DEF6F1" };

            light1Color7.Append(rgbColorModelHex98);

            A.Dark2Color dark2Color7 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex99 = new A.RgbColorModelHex() { Val = "000000" };

            dark2Color7.Append(rgbColorModelHex99);

            A.Light2Color light2Color7 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex100 = new A.RgbColorModelHex() { Val = "969696" };

            light2Color7.Append(rgbColorModelHex100);

            A.Accent1Color accent1Color7 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex101 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            accent1Color7.Append(rgbColorModelHex101);

            A.Accent2Color accent2Color7 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex102 = new A.RgbColorModelHex() { Val = "8DC6FF" };

            accent2Color7.Append(rgbColorModelHex102);

            A.Accent3Color accent3Color7 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex103 = new A.RgbColorModelHex() { Val = "ECFAF7" };

            accent3Color7.Append(rgbColorModelHex103);

            A.Accent4Color accent4Color7 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex104 = new A.RgbColorModelHex() { Val = "000000" };

            accent4Color7.Append(rgbColorModelHex104);

            A.Accent5Color accent5Color7 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex105 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            accent5Color7.Append(rgbColorModelHex105);

            A.Accent6Color accent6Color7 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex106 = new A.RgbColorModelHex() { Val = "7FB3E7" };

            accent6Color7.Append(rgbColorModelHex106);

            A.Hyperlink hyperlink7 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex107 = new A.RgbColorModelHex() { Val = "0066CC" };

            hyperlink7.Append(rgbColorModelHex107);

            A.FollowedHyperlinkColor followedHyperlinkColor7 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex108 = new A.RgbColorModelHex() { Val = "00A800" };

            followedHyperlinkColor7.Append(rgbColorModelHex108);

            colorScheme7.Append(dark1Color7);
            colorScheme7.Append(light1Color7);
            colorScheme7.Append(dark2Color7);
            colorScheme7.Append(light2Color7);
            colorScheme7.Append(accent1Color7);
            colorScheme7.Append(accent2Color7);
            colorScheme7.Append(accent3Color7);
            colorScheme7.Append(accent4Color7);
            colorScheme7.Append(accent5Color7);
            colorScheme7.Append(accent6Color7);
            colorScheme7.Append(hyperlink7);
            colorScheme7.Append(followedHyperlinkColor7);
            A.ColorMap colorMap6 = new A.ColorMap() { Background1 = A.ColorSchemeIndexValues.Light1, Text1 = A.ColorSchemeIndexValues.Dark1, Background2 = A.ColorSchemeIndexValues.Light2, Text2 = A.ColorSchemeIndexValues.Dark2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            extraColorScheme4.Append(colorScheme7);
            extraColorScheme4.Append(colorMap6);

            A.ExtraColorScheme extraColorScheme5 = new A.ExtraColorScheme();

            A.ColorScheme colorScheme8 = new A.ColorScheme() { Name = "NAS001_FINRA_Presentation_071907 5" };

            A.Dark1Color dark1Color8 = new A.Dark1Color();
            A.RgbColorModelHex rgbColorModelHex109 = new A.RgbColorModelHex() { Val = "000000" };

            dark1Color8.Append(rgbColorModelHex109);

            A.Light1Color light1Color8 = new A.Light1Color();
            A.RgbColorModelHex rgbColorModelHex110 = new A.RgbColorModelHex() { Val = "FFFFD9" };

            light1Color8.Append(rgbColorModelHex110);

            A.Dark2Color dark2Color8 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex111 = new A.RgbColorModelHex() { Val = "000000" };

            dark2Color8.Append(rgbColorModelHex111);

            A.Light2Color light2Color8 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex112 = new A.RgbColorModelHex() { Val = "777777" };

            light2Color8.Append(rgbColorModelHex112);

            A.Accent1Color accent1Color8 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex113 = new A.RgbColorModelHex() { Val = "FFFFF7" };

            accent1Color8.Append(rgbColorModelHex113);

            A.Accent2Color accent2Color8 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex114 = new A.RgbColorModelHex() { Val = "33CCCC" };

            accent2Color8.Append(rgbColorModelHex114);

            A.Accent3Color accent3Color8 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex115 = new A.RgbColorModelHex() { Val = "FFFFE9" };

            accent3Color8.Append(rgbColorModelHex115);

            A.Accent4Color accent4Color8 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex116 = new A.RgbColorModelHex() { Val = "000000" };

            accent4Color8.Append(rgbColorModelHex116);

            A.Accent5Color accent5Color8 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex117 = new A.RgbColorModelHex() { Val = "FFFFFA" };

            accent5Color8.Append(rgbColorModelHex117);

            A.Accent6Color accent6Color8 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex118 = new A.RgbColorModelHex() { Val = "2DB9B9" };

            accent6Color8.Append(rgbColorModelHex118);

            A.Hyperlink hyperlink8 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex119 = new A.RgbColorModelHex() { Val = "FF5050" };

            hyperlink8.Append(rgbColorModelHex119);

            A.FollowedHyperlinkColor followedHyperlinkColor8 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex120 = new A.RgbColorModelHex() { Val = "FF9900" };

            followedHyperlinkColor8.Append(rgbColorModelHex120);

            colorScheme8.Append(dark1Color8);
            colorScheme8.Append(light1Color8);
            colorScheme8.Append(dark2Color8);
            colorScheme8.Append(light2Color8);
            colorScheme8.Append(accent1Color8);
            colorScheme8.Append(accent2Color8);
            colorScheme8.Append(accent3Color8);
            colorScheme8.Append(accent4Color8);
            colorScheme8.Append(accent5Color8);
            colorScheme8.Append(accent6Color8);
            colorScheme8.Append(hyperlink8);
            colorScheme8.Append(followedHyperlinkColor8);
            A.ColorMap colorMap7 = new A.ColorMap() { Background1 = A.ColorSchemeIndexValues.Light1, Text1 = A.ColorSchemeIndexValues.Dark1, Background2 = A.ColorSchemeIndexValues.Light2, Text2 = A.ColorSchemeIndexValues.Dark2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            extraColorScheme5.Append(colorScheme8);
            extraColorScheme5.Append(colorMap7);

            A.ExtraColorScheme extraColorScheme6 = new A.ExtraColorScheme();

            A.ColorScheme colorScheme9 = new A.ColorScheme() { Name = "NAS001_FINRA_Presentation_071907 6" };

            A.Dark1Color dark1Color9 = new A.Dark1Color();
            A.RgbColorModelHex rgbColorModelHex121 = new A.RgbColorModelHex() { Val = "005A58" };

            dark1Color9.Append(rgbColorModelHex121);

            A.Light1Color light1Color9 = new A.Light1Color();
            A.RgbColorModelHex rgbColorModelHex122 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            light1Color9.Append(rgbColorModelHex122);

            A.Dark2Color dark2Color9 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex123 = new A.RgbColorModelHex() { Val = "008080" };

            dark2Color9.Append(rgbColorModelHex123);

            A.Light2Color light2Color9 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex124 = new A.RgbColorModelHex() { Val = "FFFF99" };

            light2Color9.Append(rgbColorModelHex124);

            A.Accent1Color accent1Color9 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex125 = new A.RgbColorModelHex() { Val = "006462" };

            accent1Color9.Append(rgbColorModelHex125);

            A.Accent2Color accent2Color9 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex126 = new A.RgbColorModelHex() { Val = "6D6FC7" };

            accent2Color9.Append(rgbColorModelHex126);

            A.Accent3Color accent3Color9 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex127 = new A.RgbColorModelHex() { Val = "AAC0C0" };

            accent3Color9.Append(rgbColorModelHex127);

            A.Accent4Color accent4Color9 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex128 = new A.RgbColorModelHex() { Val = "DADADA" };

            accent4Color9.Append(rgbColorModelHex128);

            A.Accent5Color accent5Color9 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex129 = new A.RgbColorModelHex() { Val = "AAB8B7" };

            accent5Color9.Append(rgbColorModelHex129);

            A.Accent6Color accent6Color9 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex130 = new A.RgbColorModelHex() { Val = "6264B4" };

            accent6Color9.Append(rgbColorModelHex130);

            A.Hyperlink hyperlink9 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex131 = new A.RgbColorModelHex() { Val = "00FFFF" };

            hyperlink9.Append(rgbColorModelHex131);

            A.FollowedHyperlinkColor followedHyperlinkColor9 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex132 = new A.RgbColorModelHex() { Val = "00FF00" };

            followedHyperlinkColor9.Append(rgbColorModelHex132);

            colorScheme9.Append(dark1Color9);
            colorScheme9.Append(light1Color9);
            colorScheme9.Append(dark2Color9);
            colorScheme9.Append(light2Color9);
            colorScheme9.Append(accent1Color9);
            colorScheme9.Append(accent2Color9);
            colorScheme9.Append(accent3Color9);
            colorScheme9.Append(accent4Color9);
            colorScheme9.Append(accent5Color9);
            colorScheme9.Append(accent6Color9);
            colorScheme9.Append(hyperlink9);
            colorScheme9.Append(followedHyperlinkColor9);
            A.ColorMap colorMap8 = new A.ColorMap() { Background1 = A.ColorSchemeIndexValues.Dark2, Text1 = A.ColorSchemeIndexValues.Light1, Background2 = A.ColorSchemeIndexValues.Dark1, Text2 = A.ColorSchemeIndexValues.Light2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            extraColorScheme6.Append(colorScheme9);
            extraColorScheme6.Append(colorMap8);

            A.ExtraColorScheme extraColorScheme7 = new A.ExtraColorScheme();

            A.ColorScheme colorScheme10 = new A.ColorScheme() { Name = "NAS001_FINRA_Presentation_071907 7" };

            A.Dark1Color dark1Color10 = new A.Dark1Color();
            A.RgbColorModelHex rgbColorModelHex133 = new A.RgbColorModelHex() { Val = "5C1F00" };

            dark1Color10.Append(rgbColorModelHex133);

            A.Light1Color light1Color10 = new A.Light1Color();
            A.RgbColorModelHex rgbColorModelHex134 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            light1Color10.Append(rgbColorModelHex134);

            A.Dark2Color dark2Color10 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex135 = new A.RgbColorModelHex() { Val = "800000" };

            dark2Color10.Append(rgbColorModelHex135);

            A.Light2Color light2Color10 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex136 = new A.RgbColorModelHex() { Val = "DFD293" };

            light2Color10.Append(rgbColorModelHex136);

            A.Accent1Color accent1Color10 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex137 = new A.RgbColorModelHex() { Val = "713E39" };

            accent1Color10.Append(rgbColorModelHex137);

            A.Accent2Color accent2Color10 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex138 = new A.RgbColorModelHex() { Val = "BE7960" };

            accent2Color10.Append(rgbColorModelHex138);

            A.Accent3Color accent3Color10 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex139 = new A.RgbColorModelHex() { Val = "C0AAAA" };

            accent3Color10.Append(rgbColorModelHex139);

            A.Accent4Color accent4Color10 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex140 = new A.RgbColorModelHex() { Val = "DADADA" };

            accent4Color10.Append(rgbColorModelHex140);

            A.Accent5Color accent5Color10 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex141 = new A.RgbColorModelHex() { Val = "BBAFAE" };

            accent5Color10.Append(rgbColorModelHex141);

            A.Accent6Color accent6Color10 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex142 = new A.RgbColorModelHex() { Val = "AC6D56" };

            accent6Color10.Append(rgbColorModelHex142);

            A.Hyperlink hyperlink10 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex143 = new A.RgbColorModelHex() { Val = "FFFF99" };

            hyperlink10.Append(rgbColorModelHex143);

            A.FollowedHyperlinkColor followedHyperlinkColor10 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex144 = new A.RgbColorModelHex() { Val = "D3A219" };

            followedHyperlinkColor10.Append(rgbColorModelHex144);

            colorScheme10.Append(dark1Color10);
            colorScheme10.Append(light1Color10);
            colorScheme10.Append(dark2Color10);
            colorScheme10.Append(light2Color10);
            colorScheme10.Append(accent1Color10);
            colorScheme10.Append(accent2Color10);
            colorScheme10.Append(accent3Color10);
            colorScheme10.Append(accent4Color10);
            colorScheme10.Append(accent5Color10);
            colorScheme10.Append(accent6Color10);
            colorScheme10.Append(hyperlink10);
            colorScheme10.Append(followedHyperlinkColor10);
            A.ColorMap colorMap9 = new A.ColorMap() { Background1 = A.ColorSchemeIndexValues.Dark2, Text1 = A.ColorSchemeIndexValues.Light1, Background2 = A.ColorSchemeIndexValues.Dark1, Text2 = A.ColorSchemeIndexValues.Light2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            extraColorScheme7.Append(colorScheme10);
            extraColorScheme7.Append(colorMap9);

            A.ExtraColorScheme extraColorScheme8 = new A.ExtraColorScheme();

            A.ColorScheme colorScheme11 = new A.ColorScheme() { Name = "NAS001_FINRA_Presentation_071907 8" };

            A.Dark1Color dark1Color11 = new A.Dark1Color();
            A.RgbColorModelHex rgbColorModelHex145 = new A.RgbColorModelHex() { Val = "003366" };

            dark1Color11.Append(rgbColorModelHex145);

            A.Light1Color light1Color11 = new A.Light1Color();
            A.RgbColorModelHex rgbColorModelHex146 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            light1Color11.Append(rgbColorModelHex146);

            A.Dark2Color dark2Color11 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex147 = new A.RgbColorModelHex() { Val = "000099" };

            dark2Color11.Append(rgbColorModelHex147);

            A.Light2Color light2Color11 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex148 = new A.RgbColorModelHex() { Val = "CCFFFF" };

            light2Color11.Append(rgbColorModelHex148);

            A.Accent1Color accent1Color11 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex149 = new A.RgbColorModelHex() { Val = "3366CC" };

            accent1Color11.Append(rgbColorModelHex149);

            A.Accent2Color accent2Color11 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex150 = new A.RgbColorModelHex() { Val = "00B000" };

            accent2Color11.Append(rgbColorModelHex150);

            A.Accent3Color accent3Color11 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex151 = new A.RgbColorModelHex() { Val = "AAAACA" };

            accent3Color11.Append(rgbColorModelHex151);

            A.Accent4Color accent4Color11 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex152 = new A.RgbColorModelHex() { Val = "DADADA" };

            accent4Color11.Append(rgbColorModelHex152);

            A.Accent5Color accent5Color11 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex153 = new A.RgbColorModelHex() { Val = "ADB8E2" };

            accent5Color11.Append(rgbColorModelHex153);

            A.Accent6Color accent6Color11 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex154 = new A.RgbColorModelHex() { Val = "009F00" };

            accent6Color11.Append(rgbColorModelHex154);

            A.Hyperlink hyperlink11 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex155 = new A.RgbColorModelHex() { Val = "66CCFF" };

            hyperlink11.Append(rgbColorModelHex155);

            A.FollowedHyperlinkColor followedHyperlinkColor11 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex156 = new A.RgbColorModelHex() { Val = "FFE701" };

            followedHyperlinkColor11.Append(rgbColorModelHex156);

            colorScheme11.Append(dark1Color11);
            colorScheme11.Append(light1Color11);
            colorScheme11.Append(dark2Color11);
            colorScheme11.Append(light2Color11);
            colorScheme11.Append(accent1Color11);
            colorScheme11.Append(accent2Color11);
            colorScheme11.Append(accent3Color11);
            colorScheme11.Append(accent4Color11);
            colorScheme11.Append(accent5Color11);
            colorScheme11.Append(accent6Color11);
            colorScheme11.Append(hyperlink11);
            colorScheme11.Append(followedHyperlinkColor11);
            A.ColorMap colorMap10 = new A.ColorMap() { Background1 = A.ColorSchemeIndexValues.Dark2, Text1 = A.ColorSchemeIndexValues.Light1, Background2 = A.ColorSchemeIndexValues.Dark1, Text2 = A.ColorSchemeIndexValues.Light2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            extraColorScheme8.Append(colorScheme11);
            extraColorScheme8.Append(colorMap10);

            A.ExtraColorScheme extraColorScheme9 = new A.ExtraColorScheme();

            A.ColorScheme colorScheme12 = new A.ColorScheme() { Name = "NAS001_FINRA_Presentation_071907 9" };

            A.Dark1Color dark1Color12 = new A.Dark1Color();
            A.RgbColorModelHex rgbColorModelHex157 = new A.RgbColorModelHex() { Val = "336699" };

            dark1Color12.Append(rgbColorModelHex157);

            A.Light1Color light1Color12 = new A.Light1Color();
            A.RgbColorModelHex rgbColorModelHex158 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            light1Color12.Append(rgbColorModelHex158);

            A.Dark2Color dark2Color12 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex159 = new A.RgbColorModelHex() { Val = "000000" };

            dark2Color12.Append(rgbColorModelHex159);

            A.Light2Color light2Color12 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex160 = new A.RgbColorModelHex() { Val = "E3EBF1" };

            light2Color12.Append(rgbColorModelHex160);

            A.Accent1Color accent1Color12 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex161 = new A.RgbColorModelHex() { Val = "003399" };

            accent1Color12.Append(rgbColorModelHex161);

            A.Accent2Color accent2Color12 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex162 = new A.RgbColorModelHex() { Val = "468A4B" };

            accent2Color12.Append(rgbColorModelHex162);

            A.Accent3Color accent3Color12 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex163 = new A.RgbColorModelHex() { Val = "AAAAAA" };

            accent3Color12.Append(rgbColorModelHex163);

            A.Accent4Color accent4Color12 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex164 = new A.RgbColorModelHex() { Val = "DADADA" };

            accent4Color12.Append(rgbColorModelHex164);

            A.Accent5Color accent5Color12 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex165 = new A.RgbColorModelHex() { Val = "AAADCA" };

            accent5Color12.Append(rgbColorModelHex165);

            A.Accent6Color accent6Color12 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex166 = new A.RgbColorModelHex() { Val = "3F7D43" };

            accent6Color12.Append(rgbColorModelHex166);

            A.Hyperlink hyperlink12 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex167 = new A.RgbColorModelHex() { Val = "66CCFF" };

            hyperlink12.Append(rgbColorModelHex167);

            A.FollowedHyperlinkColor followedHyperlinkColor12 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex168 = new A.RgbColorModelHex() { Val = "F0E500" };

            followedHyperlinkColor12.Append(rgbColorModelHex168);

            colorScheme12.Append(dark1Color12);
            colorScheme12.Append(light1Color12);
            colorScheme12.Append(dark2Color12);
            colorScheme12.Append(light2Color12);
            colorScheme12.Append(accent1Color12);
            colorScheme12.Append(accent2Color12);
            colorScheme12.Append(accent3Color12);
            colorScheme12.Append(accent4Color12);
            colorScheme12.Append(accent5Color12);
            colorScheme12.Append(accent6Color12);
            colorScheme12.Append(hyperlink12);
            colorScheme12.Append(followedHyperlinkColor12);
            A.ColorMap colorMap11 = new A.ColorMap() { Background1 = A.ColorSchemeIndexValues.Dark2, Text1 = A.ColorSchemeIndexValues.Light1, Background2 = A.ColorSchemeIndexValues.Dark1, Text2 = A.ColorSchemeIndexValues.Light2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            extraColorScheme9.Append(colorScheme12);
            extraColorScheme9.Append(colorMap11);

            A.ExtraColorScheme extraColorScheme10 = new A.ExtraColorScheme();

            A.ColorScheme colorScheme13 = new A.ColorScheme() { Name = "NAS001_FINRA_Presentation_071907 10" };

            A.Dark1Color dark1Color13 = new A.Dark1Color();
            A.RgbColorModelHex rgbColorModelHex169 = new A.RgbColorModelHex() { Val = "777777" };

            dark1Color13.Append(rgbColorModelHex169);

            A.Light1Color light1Color13 = new A.Light1Color();
            A.RgbColorModelHex rgbColorModelHex170 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            light1Color13.Append(rgbColorModelHex170);

            A.Dark2Color dark2Color13 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex171 = new A.RgbColorModelHex() { Val = "686B5D" };

            dark2Color13.Append(rgbColorModelHex171);

            A.Light2Color light2Color13 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex172 = new A.RgbColorModelHex() { Val = "D1D1CB" };

            light2Color13.Append(rgbColorModelHex172);

            A.Accent1Color accent1Color13 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex173 = new A.RgbColorModelHex() { Val = "909082" };

            accent1Color13.Append(rgbColorModelHex173);

            A.Accent2Color accent2Color13 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex174 = new A.RgbColorModelHex() { Val = "809EA8" };

            accent2Color13.Append(rgbColorModelHex174);

            A.Accent3Color accent3Color13 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex175 = new A.RgbColorModelHex() { Val = "B9BAB6" };

            accent3Color13.Append(rgbColorModelHex175);

            A.Accent4Color accent4Color13 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex176 = new A.RgbColorModelHex() { Val = "DADADA" };

            accent4Color13.Append(rgbColorModelHex176);

            A.Accent5Color accent5Color13 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex177 = new A.RgbColorModelHex() { Val = "C6C6C1" };

            accent5Color13.Append(rgbColorModelHex177);

            A.Accent6Color accent6Color13 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex178 = new A.RgbColorModelHex() { Val = "738F98" };

            accent6Color13.Append(rgbColorModelHex178);

            A.Hyperlink hyperlink13 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex179 = new A.RgbColorModelHex() { Val = "FFCC66" };

            hyperlink13.Append(rgbColorModelHex179);

            A.FollowedHyperlinkColor followedHyperlinkColor13 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex180 = new A.RgbColorModelHex() { Val = "E9DCB9" };

            followedHyperlinkColor13.Append(rgbColorModelHex180);

            colorScheme13.Append(dark1Color13);
            colorScheme13.Append(light1Color13);
            colorScheme13.Append(dark2Color13);
            colorScheme13.Append(light2Color13);
            colorScheme13.Append(accent1Color13);
            colorScheme13.Append(accent2Color13);
            colorScheme13.Append(accent3Color13);
            colorScheme13.Append(accent4Color13);
            colorScheme13.Append(accent5Color13);
            colorScheme13.Append(accent6Color13);
            colorScheme13.Append(hyperlink13);
            colorScheme13.Append(followedHyperlinkColor13);
            A.ColorMap colorMap12 = new A.ColorMap() { Background1 = A.ColorSchemeIndexValues.Dark2, Text1 = A.ColorSchemeIndexValues.Light1, Background2 = A.ColorSchemeIndexValues.Dark1, Text2 = A.ColorSchemeIndexValues.Light2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            extraColorScheme10.Append(colorScheme13);
            extraColorScheme10.Append(colorMap12);

            A.ExtraColorScheme extraColorScheme11 = new A.ExtraColorScheme();

            A.ColorScheme colorScheme14 = new A.ColorScheme() { Name = "NAS001_FINRA_Presentation_071907 11" };

            A.Dark1Color dark1Color14 = new A.Dark1Color();
            A.RgbColorModelHex rgbColorModelHex181 = new A.RgbColorModelHex() { Val = "3E3E5C" };

            dark1Color14.Append(rgbColorModelHex181);

            A.Light1Color light1Color14 = new A.Light1Color();
            A.RgbColorModelHex rgbColorModelHex182 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            light1Color14.Append(rgbColorModelHex182);

            A.Dark2Color dark2Color14 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex183 = new A.RgbColorModelHex() { Val = "666699" };

            dark2Color14.Append(rgbColorModelHex183);

            A.Light2Color light2Color14 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex184 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            light2Color14.Append(rgbColorModelHex184);

            A.Accent1Color accent1Color14 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex185 = new A.RgbColorModelHex() { Val = "60597B" };

            accent1Color14.Append(rgbColorModelHex185);

            A.Accent2Color accent2Color14 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex186 = new A.RgbColorModelHex() { Val = "6666FF" };

            accent2Color14.Append(rgbColorModelHex186);

            A.Accent3Color accent3Color14 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex187 = new A.RgbColorModelHex() { Val = "B8B8CA" };

            accent3Color14.Append(rgbColorModelHex187);

            A.Accent4Color accent4Color14 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex188 = new A.RgbColorModelHex() { Val = "DADADA" };

            accent4Color14.Append(rgbColorModelHex188);

            A.Accent5Color accent5Color14 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex189 = new A.RgbColorModelHex() { Val = "B6B5BF" };

            accent5Color14.Append(rgbColorModelHex189);

            A.Accent6Color accent6Color14 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex190 = new A.RgbColorModelHex() { Val = "5C5CE7" };

            accent6Color14.Append(rgbColorModelHex190);

            A.Hyperlink hyperlink14 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex191 = new A.RgbColorModelHex() { Val = "99CCFF" };

            hyperlink14.Append(rgbColorModelHex191);

            A.FollowedHyperlinkColor followedHyperlinkColor14 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex192 = new A.RgbColorModelHex() { Val = "FFFF99" };

            followedHyperlinkColor14.Append(rgbColorModelHex192);

            colorScheme14.Append(dark1Color14);
            colorScheme14.Append(light1Color14);
            colorScheme14.Append(dark2Color14);
            colorScheme14.Append(light2Color14);
            colorScheme14.Append(accent1Color14);
            colorScheme14.Append(accent2Color14);
            colorScheme14.Append(accent3Color14);
            colorScheme14.Append(accent4Color14);
            colorScheme14.Append(accent5Color14);
            colorScheme14.Append(accent6Color14);
            colorScheme14.Append(hyperlink14);
            colorScheme14.Append(followedHyperlinkColor14);
            A.ColorMap colorMap13 = new A.ColorMap() { Background1 = A.ColorSchemeIndexValues.Dark2, Text1 = A.ColorSchemeIndexValues.Light1, Background2 = A.ColorSchemeIndexValues.Dark1, Text2 = A.ColorSchemeIndexValues.Light2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            extraColorScheme11.Append(colorScheme14);
            extraColorScheme11.Append(colorMap13);

            A.ExtraColorScheme extraColorScheme12 = new A.ExtraColorScheme();

            A.ColorScheme colorScheme15 = new A.ColorScheme() { Name = "NAS001_FINRA_Presentation_071907 12" };

            A.Dark1Color dark1Color15 = new A.Dark1Color();
            A.RgbColorModelHex rgbColorModelHex193 = new A.RgbColorModelHex() { Val = "2D2015" };

            dark1Color15.Append(rgbColorModelHex193);

            A.Light1Color light1Color15 = new A.Light1Color();
            A.RgbColorModelHex rgbColorModelHex194 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            light1Color15.Append(rgbColorModelHex194);

            A.Dark2Color dark2Color15 = new A.Dark2Color();
            A.RgbColorModelHex rgbColorModelHex195 = new A.RgbColorModelHex() { Val = "523E26" };

            dark2Color15.Append(rgbColorModelHex195);

            A.Light2Color light2Color15 = new A.Light2Color();
            A.RgbColorModelHex rgbColorModelHex196 = new A.RgbColorModelHex() { Val = "DFC08D" };

            light2Color15.Append(rgbColorModelHex196);

            A.Accent1Color accent1Color15 = new A.Accent1Color();
            A.RgbColorModelHex rgbColorModelHex197 = new A.RgbColorModelHex() { Val = "8C7B70" };

            accent1Color15.Append(rgbColorModelHex197);

            A.Accent2Color accent2Color15 = new A.Accent2Color();
            A.RgbColorModelHex rgbColorModelHex198 = new A.RgbColorModelHex() { Val = "8F5F2F" };

            accent2Color15.Append(rgbColorModelHex198);

            A.Accent3Color accent3Color15 = new A.Accent3Color();
            A.RgbColorModelHex rgbColorModelHex199 = new A.RgbColorModelHex() { Val = "B3AFAC" };

            accent3Color15.Append(rgbColorModelHex199);

            A.Accent4Color accent4Color15 = new A.Accent4Color();
            A.RgbColorModelHex rgbColorModelHex200 = new A.RgbColorModelHex() { Val = "DADADA" };

            accent4Color15.Append(rgbColorModelHex200);

            A.Accent5Color accent5Color15 = new A.Accent5Color();
            A.RgbColorModelHex rgbColorModelHex201 = new A.RgbColorModelHex() { Val = "C5BFBB" };

            accent5Color15.Append(rgbColorModelHex201);

            A.Accent6Color accent6Color15 = new A.Accent6Color();
            A.RgbColorModelHex rgbColorModelHex202 = new A.RgbColorModelHex() { Val = "81552A" };

            accent6Color15.Append(rgbColorModelHex202);

            A.Hyperlink hyperlink15 = new A.Hyperlink();
            A.RgbColorModelHex rgbColorModelHex203 = new A.RgbColorModelHex() { Val = "CCB400" };

            hyperlink15.Append(rgbColorModelHex203);

            A.FollowedHyperlinkColor followedHyperlinkColor15 = new A.FollowedHyperlinkColor();
            A.RgbColorModelHex rgbColorModelHex204 = new A.RgbColorModelHex() { Val = "8C9EA0" };

            followedHyperlinkColor15.Append(rgbColorModelHex204);

            colorScheme15.Append(dark1Color15);
            colorScheme15.Append(light1Color15);
            colorScheme15.Append(dark2Color15);
            colorScheme15.Append(light2Color15);
            colorScheme15.Append(accent1Color15);
            colorScheme15.Append(accent2Color15);
            colorScheme15.Append(accent3Color15);
            colorScheme15.Append(accent4Color15);
            colorScheme15.Append(accent5Color15);
            colorScheme15.Append(accent6Color15);
            colorScheme15.Append(hyperlink15);
            colorScheme15.Append(followedHyperlinkColor15);
            A.ColorMap colorMap14 = new A.ColorMap() { Background1 = A.ColorSchemeIndexValues.Dark2, Text1 = A.ColorSchemeIndexValues.Light1, Background2 = A.ColorSchemeIndexValues.Dark1, Text2 = A.ColorSchemeIndexValues.Light2, Accent1 = A.ColorSchemeIndexValues.Accent1, Accent2 = A.ColorSchemeIndexValues.Accent2, Accent3 = A.ColorSchemeIndexValues.Accent3, Accent4 = A.ColorSchemeIndexValues.Accent4, Accent5 = A.ColorSchemeIndexValues.Accent5, Accent6 = A.ColorSchemeIndexValues.Accent6, Hyperlink = A.ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = A.ColorSchemeIndexValues.FollowedHyperlink };

            extraColorScheme12.Append(colorScheme15);
            extraColorScheme12.Append(colorMap14);

            extraColorSchemeList3.Append(extraColorScheme1);
            extraColorSchemeList3.Append(extraColorScheme2);
            extraColorSchemeList3.Append(extraColorScheme3);
            extraColorSchemeList3.Append(extraColorScheme4);
            extraColorSchemeList3.Append(extraColorScheme5);
            extraColorSchemeList3.Append(extraColorScheme6);
            extraColorSchemeList3.Append(extraColorScheme7);
            extraColorSchemeList3.Append(extraColorScheme8);
            extraColorSchemeList3.Append(extraColorScheme9);
            extraColorSchemeList3.Append(extraColorScheme10);
            extraColorSchemeList3.Append(extraColorScheme11);
            extraColorSchemeList3.Append(extraColorScheme12);

            theme3.Append(themeElements3);
            theme3.Append(objectDefaults3);
            theme3.Append(extraColorSchemeList3);

            themePart3.Theme = theme3;
        }
    }
}
