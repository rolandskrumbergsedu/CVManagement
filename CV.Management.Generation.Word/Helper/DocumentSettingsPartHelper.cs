using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace CV.Management.Generation.Word.Helpers
{
    public static class DocumentSettingsPartHelper
    {
        public static void GenerateDocumentSettingsPart1Content(DocumentSettingsPart documentSettingsPart1)
        {
            var settings1 = new Settings { MCAttributes = new MarkupCompatibilityAttributes { Ignorable = "w14 w15 w16se w16cid" } };
            settings1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            settings1.AddNamespaceDeclaration("o", "urn:schemas-microsoft-com:office:office");
            settings1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            settings1.AddNamespaceDeclaration("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
            settings1.AddNamespaceDeclaration("v", "urn:schemas-microsoft-com:vml");
            settings1.AddNamespaceDeclaration("w10", "urn:schemas-microsoft-com:office:word");
            settings1.AddNamespaceDeclaration("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
            settings1.AddNamespaceDeclaration("w14", "http://schemas.microsoft.com/office/word/2010/wordml");
            settings1.AddNamespaceDeclaration("w15", "http://schemas.microsoft.com/office/word/2012/wordml");
            settings1.AddNamespaceDeclaration("w16cid", "http://schemas.microsoft.com/office/word/2016/wordml/cid");
            settings1.AddNamespaceDeclaration("w16se", "http://schemas.microsoft.com/office/word/2015/wordml/symex");
            settings1.AddNamespaceDeclaration("sl", "http://schemas.openxmlformats.org/schemaLibrary/2006/main");
            Zoom zoom1 = new Zoom() { Percent = "100" };
            ProofState proofState1 = new ProofState() { Spelling = ProofingStateValues.Clean, Grammar = ProofingStateValues.Clean };
            DefaultTabStop defaultTabStop1 = new DefaultTabStop() { Val = 708 };
            HyphenationZone hyphenationZone1 = new HyphenationZone() { Val = "425" };
            CharacterSpacingControl characterSpacingControl1 = new CharacterSpacingControl() { Val = CharacterSpacingValues.DoNotCompress };

            FootnoteDocumentWideProperties footnoteDocumentWideProperties1 = new FootnoteDocumentWideProperties();
            FootnoteSpecialReference footnoteSpecialReference1 = new FootnoteSpecialReference() { Id = -1 };
            FootnoteSpecialReference footnoteSpecialReference2 = new FootnoteSpecialReference() { Id = 0 };

            footnoteDocumentWideProperties1.Append(footnoteSpecialReference1);
            footnoteDocumentWideProperties1.Append(footnoteSpecialReference2);

            EndnoteDocumentWideProperties endnoteDocumentWideProperties1 = new EndnoteDocumentWideProperties();
            EndnoteSpecialReference endnoteSpecialReference1 = new EndnoteSpecialReference() { Id = -1 };
            EndnoteSpecialReference endnoteSpecialReference2 = new EndnoteSpecialReference() { Id = 0 };

            endnoteDocumentWideProperties1.Append(endnoteSpecialReference1);
            endnoteDocumentWideProperties1.Append(endnoteSpecialReference2);

            Compatibility compatibility1 = new Compatibility();
            CompatibilitySetting compatibilitySetting1 = new CompatibilitySetting() { Name = CompatSettingNameValues.CompatibilityMode, Uri = "http://schemas.microsoft.com/office/word", Val = "15" };
            CompatibilitySetting compatibilitySetting2 = new CompatibilitySetting() { Name = CompatSettingNameValues.OverrideTableStyleFontSizeAndJustification, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting3 = new CompatibilitySetting() { Name = CompatSettingNameValues.EnableOpenTypeFeatures, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting4 = new CompatibilitySetting() { Name = CompatSettingNameValues.DoNotFlipMirrorIndents, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting5 = new CompatibilitySetting() { Name = CompatSettingNameValues.DifferentiateMultirowTableHeaders, Uri = "http://schemas.microsoft.com/office/word", Val = "1" };
            CompatibilitySetting compatibilitySetting6 = new CompatibilitySetting() { Name = new EnumValue<CompatSettingNameValues>() { InnerText = "useWord2013TrackBottomHyphenation" }, Uri = "http://schemas.microsoft.com/office/word", Val = "0" };

            compatibility1.Append(compatibilitySetting1);
            compatibility1.Append(compatibilitySetting2);
            compatibility1.Append(compatibilitySetting3);
            compatibility1.Append(compatibilitySetting4);
            compatibility1.Append(compatibilitySetting5);
            compatibility1.Append(compatibilitySetting6);

            Rsids rsids1 = new Rsids();
            RsidRoot rsidRoot1 = new RsidRoot() { Val = "009B2C1D" };
            Rsid rsid1 = new Rsid() { Val = "0007641E" };
            Rsid rsid2 = new Rsid() { Val = "003C529E" };
            Rsid rsid3 = new Rsid() { Val = "009B2C1D" };
            Rsid rsid4 = new Rsid() { Val = "009E39C2" };
            Rsid rsid5 = new Rsid() { Val = "00E11B23" };
            Rsid rsid6 = new Rsid() { Val = "00F225EA" };

            rsids1.Append(rsidRoot1);
            rsids1.Append(rsid1);
            rsids1.Append(rsid2);
            rsids1.Append(rsid3);
            rsids1.Append(rsid4);
            rsids1.Append(rsid5);
            rsids1.Append(rsid6);

            DocumentFormat.OpenXml.Math.MathProperties mathProperties1 = new DocumentFormat.OpenXml.Math.MathProperties();
            DocumentFormat.OpenXml.Math.MathFont mathFont1 = new DocumentFormat.OpenXml.Math.MathFont() { Val = "Cambria Math" };
            DocumentFormat.OpenXml.Math.BreakBinary breakBinary1 = new DocumentFormat.OpenXml.Math.BreakBinary() { Val = DocumentFormat.OpenXml.Math.BreakBinaryOperatorValues.Before };
            DocumentFormat.OpenXml.Math.BreakBinarySubtraction breakBinarySubtraction1 = new DocumentFormat.OpenXml.Math.BreakBinarySubtraction() { Val = DocumentFormat.OpenXml.Math.BreakBinarySubtractionValues.MinusMinus };
            DocumentFormat.OpenXml.Math.SmallFraction smallFraction1 = new DocumentFormat.OpenXml.Math.SmallFraction() { Val = DocumentFormat.OpenXml.Math.BooleanValues.Zero };
            DocumentFormat.OpenXml.Math.DisplayDefaults displayDefaults1 = new DocumentFormat.OpenXml.Math.DisplayDefaults();
            DocumentFormat.OpenXml.Math.LeftMargin leftMargin1 = new DocumentFormat.OpenXml.Math.LeftMargin() { Val = (UInt32Value)0U };
            DocumentFormat.OpenXml.Math.RightMargin rightMargin1 = new DocumentFormat.OpenXml.Math.RightMargin() { Val = (UInt32Value)0U };
            DocumentFormat.OpenXml.Math.DefaultJustification defaultJustification1 = new DocumentFormat.OpenXml.Math.DefaultJustification() { Val = DocumentFormat.OpenXml.Math.JustificationValues.CenterGroup };
            DocumentFormat.OpenXml.Math.WrapIndent wrapIndent1 = new DocumentFormat.OpenXml.Math.WrapIndent() { Val = (UInt32Value)1440U };
            DocumentFormat.OpenXml.Math.IntegralLimitLocation integralLimitLocation1 = new DocumentFormat.OpenXml.Math.IntegralLimitLocation() { Val = DocumentFormat.OpenXml.Math.LimitLocationValues.SubscriptSuperscript };
            DocumentFormat.OpenXml.Math.NaryLimitLocation naryLimitLocation1 = new DocumentFormat.OpenXml.Math.NaryLimitLocation() { Val = DocumentFormat.OpenXml.Math.LimitLocationValues.UnderOver };

            mathProperties1.Append(mathFont1);
            mathProperties1.Append(breakBinary1);
            mathProperties1.Append(breakBinarySubtraction1);
            mathProperties1.Append(smallFraction1);
            mathProperties1.Append(displayDefaults1);
            mathProperties1.Append(leftMargin1);
            mathProperties1.Append(rightMargin1);
            mathProperties1.Append(defaultJustification1);
            mathProperties1.Append(wrapIndent1);
            mathProperties1.Append(integralLimitLocation1);
            mathProperties1.Append(naryLimitLocation1);
            ThemeFontLanguages themeFontLanguages1 = new ThemeFontLanguages() { Val = "en-US" };
            ColorSchemeMapping colorSchemeMapping1 = new ColorSchemeMapping() { Background1 = ColorSchemeIndexValues.Light1, Text1 = ColorSchemeIndexValues.Dark1, Background2 = ColorSchemeIndexValues.Light2, Text2 = ColorSchemeIndexValues.Dark2, Accent1 = ColorSchemeIndexValues.Accent1, Accent2 = ColorSchemeIndexValues.Accent2, Accent3 = ColorSchemeIndexValues.Accent3, Accent4 = ColorSchemeIndexValues.Accent4, Accent5 = ColorSchemeIndexValues.Accent5, Accent6 = ColorSchemeIndexValues.Accent6, Hyperlink = ColorSchemeIndexValues.Hyperlink, FollowedHyperlink = ColorSchemeIndexValues.FollowedHyperlink };

            ShapeDefaults shapeDefaults1 = new ShapeDefaults();
            DocumentFormat.OpenXml.Vml.Office.ShapeDefaults shapeDefaults2 = new DocumentFormat.OpenXml.Vml.Office.ShapeDefaults() { Extension = DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues.Edit, MaxShapeId = 1026 };

            DocumentFormat.OpenXml.Vml.Office.ShapeLayout shapeLayout1 = new DocumentFormat.OpenXml.Vml.Office.ShapeLayout() { Extension = DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues.Edit };
            DocumentFormat.OpenXml.Vml.Office.ShapeIdMap shapeIdMap1 = new DocumentFormat.OpenXml.Vml.Office.ShapeIdMap() { Extension = DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues.Edit, Data = "1" };

            shapeLayout1.Append(shapeIdMap1);

            shapeDefaults1.Append(shapeDefaults2);
            shapeDefaults1.Append(shapeLayout1);
            DecimalSymbol decimalSymbol1 = new DecimalSymbol() { Val = "," };
            ListSeparator listSeparator1 = new ListSeparator() { Val = ";" };
            DocumentFormat.OpenXml.Office2010.Word.DocumentId documentId1 = new DocumentFormat.OpenXml.Office2010.Word.DocumentId() { Val = "376E9E86" };
            DocumentFormat.OpenXml.Office2013.Word.PersistentDocumentId persistentDocumentId1 = new DocumentFormat.OpenXml.Office2013.Word.PersistentDocumentId() { Val = "{0360345E-CE15-4CE5-8174-6F23AE099AF0}" };

            settings1.Append(zoom1);
            settings1.Append(proofState1);
            settings1.Append(defaultTabStop1);
            settings1.Append(hyphenationZone1);
            settings1.Append(characterSpacingControl1);
            settings1.Append(footnoteDocumentWideProperties1);
            settings1.Append(endnoteDocumentWideProperties1);
            settings1.Append(compatibility1);
            settings1.Append(rsids1);
            settings1.Append(mathProperties1);
            settings1.Append(themeFontLanguages1);
            settings1.Append(colorSchemeMapping1);
            settings1.Append(shapeDefaults1);
            settings1.Append(decimalSymbol1);
            settings1.Append(listSeparator1);
            settings1.Append(documentId1);
            settings1.Append(persistentDocumentId1);

            documentSettingsPart1.Settings = settings1;
        }
    }
}
