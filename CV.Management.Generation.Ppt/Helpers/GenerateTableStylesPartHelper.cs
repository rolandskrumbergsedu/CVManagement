using DocumentFormat.OpenXml.Packaging;
using A = DocumentFormat.OpenXml.Drawing;

namespace CV.Management.Generation.Ppt.Helpers
{
    public static class GenerateTableStylesPartHelper
    {
        public static void GenerateTableStylesPart1Content(TableStylesPart tableStylesPart1)
        {
            A.TableStyleList tableStyleList1 = new A.TableStyleList() { Default = "{5C22544A-7EE6-4342-B048-85BDC9FD1C3A}" };
            tableStyleList1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");

            A.TableStyleEntry tableStyleEntry1 = new A.TableStyleEntry() { StyleId = "{5C22544A-7EE6-4342-B048-85BDC9FD1C3A}", StyleName = "Medium Style 2 - Accent 1" };

            A.WholeTable wholeTable1 = new A.WholeTable();

            A.TableCellTextStyle tableCellTextStyle1 = new A.TableCellTextStyle();

            A.FontReference fontReference1 = new A.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            A.PresetColor presetColor1 = new A.PresetColor() { Val = A.PresetColorValues.Black };

            fontReference1.Append(presetColor1);
            A.SchemeColor schemeColor26 = new A.SchemeColor() { Val = A.SchemeColorValues.Dark1 };

            tableCellTextStyle1.Append(fontReference1);
            tableCellTextStyle1.Append(schemeColor26);

            A.TableCellStyle tableCellStyle1 = new A.TableCellStyle();

            A.TableCellBorders tableCellBorders1 = new A.TableCellBorders();

            A.LeftBorder leftBorder1 = new A.LeftBorder();

            A.Outline outline4 = new A.Outline() { Width = 12700, CompoundLineType = A.CompoundLineValues.Single };

            A.SolidFill solidFill16 = new A.SolidFill();
            A.SchemeColor schemeColor27 = new A.SchemeColor() { Val = A.SchemeColorValues.Light1 };

            solidFill16.Append(schemeColor27);

            outline4.Append(solidFill16);

            leftBorder1.Append(outline4);

            A.RightBorder rightBorder1 = new A.RightBorder();

            A.Outline outline5 = new A.Outline() { Width = 12700, CompoundLineType = A.CompoundLineValues.Single };

            A.SolidFill solidFill17 = new A.SolidFill();
            A.SchemeColor schemeColor28 = new A.SchemeColor() { Val = A.SchemeColorValues.Light1 };

            solidFill17.Append(schemeColor28);

            outline5.Append(solidFill17);

            rightBorder1.Append(outline5);

            A.TopBorder topBorder1 = new A.TopBorder();

            A.Outline outline6 = new A.Outline() { Width = 12700, CompoundLineType = A.CompoundLineValues.Single };

            A.SolidFill solidFill18 = new A.SolidFill();
            A.SchemeColor schemeColor29 = new A.SchemeColor() { Val = A.SchemeColorValues.Light1 };

            solidFill18.Append(schemeColor29);

            outline6.Append(solidFill18);

            topBorder1.Append(outline6);

            A.BottomBorder bottomBorder1 = new A.BottomBorder();

            A.Outline outline7 = new A.Outline() { Width = 12700, CompoundLineType = A.CompoundLineValues.Single };

            A.SolidFill solidFill19 = new A.SolidFill();
            A.SchemeColor schemeColor30 = new A.SchemeColor() { Val = A.SchemeColorValues.Light1 };

            solidFill19.Append(schemeColor30);

            outline7.Append(solidFill19);

            bottomBorder1.Append(outline7);

            A.InsideHorizontalBorder insideHorizontalBorder1 = new A.InsideHorizontalBorder();

            A.Outline outline8 = new A.Outline() { Width = 12700, CompoundLineType = A.CompoundLineValues.Single };

            A.SolidFill solidFill20 = new A.SolidFill();
            A.SchemeColor schemeColor31 = new A.SchemeColor() { Val = A.SchemeColorValues.Light1 };

            solidFill20.Append(schemeColor31);

            outline8.Append(solidFill20);

            insideHorizontalBorder1.Append(outline8);

            A.InsideVerticalBorder insideVerticalBorder1 = new A.InsideVerticalBorder();

            A.Outline outline9 = new A.Outline() { Width = 12700, CompoundLineType = A.CompoundLineValues.Single };

            A.SolidFill solidFill21 = new A.SolidFill();
            A.SchemeColor schemeColor32 = new A.SchemeColor() { Val = A.SchemeColorValues.Light1 };

            solidFill21.Append(schemeColor32);

            outline9.Append(solidFill21);

            insideVerticalBorder1.Append(outline9);

            tableCellBorders1.Append(leftBorder1);
            tableCellBorders1.Append(rightBorder1);
            tableCellBorders1.Append(topBorder1);
            tableCellBorders1.Append(bottomBorder1);
            tableCellBorders1.Append(insideHorizontalBorder1);
            tableCellBorders1.Append(insideVerticalBorder1);

            A.FillProperties fillProperties1 = new A.FillProperties();

            A.SolidFill solidFill22 = new A.SolidFill();

            A.SchemeColor schemeColor33 = new A.SchemeColor() { Val = A.SchemeColorValues.Accent1 };
            A.Tint tint8 = new A.Tint() { Val = 20000 };

            schemeColor33.Append(tint8);

            solidFill22.Append(schemeColor33);

            fillProperties1.Append(solidFill22);

            tableCellStyle1.Append(tableCellBorders1);
            tableCellStyle1.Append(fillProperties1);

            wholeTable1.Append(tableCellTextStyle1);
            wholeTable1.Append(tableCellStyle1);

            A.Band1Horizontal band1Horizontal1 = new A.Band1Horizontal();

            A.TableCellStyle tableCellStyle2 = new A.TableCellStyle();
            A.TableCellBorders tableCellBorders2 = new A.TableCellBorders();

            A.FillProperties fillProperties2 = new A.FillProperties();

            A.SolidFill solidFill23 = new A.SolidFill();

            A.SchemeColor schemeColor34 = new A.SchemeColor() { Val = A.SchemeColorValues.Accent1 };
            A.Tint tint9 = new A.Tint() { Val = 40000 };

            schemeColor34.Append(tint9);

            solidFill23.Append(schemeColor34);

            fillProperties2.Append(solidFill23);

            tableCellStyle2.Append(tableCellBorders2);
            tableCellStyle2.Append(fillProperties2);

            band1Horizontal1.Append(tableCellStyle2);

            A.Band2Horizontal band2Horizontal1 = new A.Band2Horizontal();

            A.TableCellStyle tableCellStyle3 = new A.TableCellStyle();
            A.TableCellBorders tableCellBorders3 = new A.TableCellBorders();

            tableCellStyle3.Append(tableCellBorders3);

            band2Horizontal1.Append(tableCellStyle3);

            A.Band1Vertical band1Vertical1 = new A.Band1Vertical();

            A.TableCellStyle tableCellStyle4 = new A.TableCellStyle();
            A.TableCellBorders tableCellBorders4 = new A.TableCellBorders();

            A.FillProperties fillProperties3 = new A.FillProperties();

            A.SolidFill solidFill24 = new A.SolidFill();

            A.SchemeColor schemeColor35 = new A.SchemeColor() { Val = A.SchemeColorValues.Accent1 };
            A.Tint tint10 = new A.Tint() { Val = 40000 };

            schemeColor35.Append(tint10);

            solidFill24.Append(schemeColor35);

            fillProperties3.Append(solidFill24);

            tableCellStyle4.Append(tableCellBorders4);
            tableCellStyle4.Append(fillProperties3);

            band1Vertical1.Append(tableCellStyle4);

            A.Band2Vertical band2Vertical1 = new A.Band2Vertical();

            A.TableCellStyle tableCellStyle5 = new A.TableCellStyle();
            A.TableCellBorders tableCellBorders5 = new A.TableCellBorders();

            tableCellStyle5.Append(tableCellBorders5);

            band2Vertical1.Append(tableCellStyle5);

            A.LastColumn lastColumn1 = new A.LastColumn();

            A.TableCellTextStyle tableCellTextStyle2 = new A.TableCellTextStyle() { Bold = A.BooleanStyleValues.On };

            A.FontReference fontReference2 = new A.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            A.PresetColor presetColor2 = new A.PresetColor() { Val = A.PresetColorValues.Black };

            fontReference2.Append(presetColor2);
            A.SchemeColor schemeColor36 = new A.SchemeColor() { Val = A.SchemeColorValues.Light1 };

            tableCellTextStyle2.Append(fontReference2);
            tableCellTextStyle2.Append(schemeColor36);

            A.TableCellStyle tableCellStyle6 = new A.TableCellStyle();
            A.TableCellBorders tableCellBorders6 = new A.TableCellBorders();

            A.FillProperties fillProperties4 = new A.FillProperties();

            A.SolidFill solidFill25 = new A.SolidFill();
            A.SchemeColor schemeColor37 = new A.SchemeColor() { Val = A.SchemeColorValues.Accent1 };

            solidFill25.Append(schemeColor37);

            fillProperties4.Append(solidFill25);

            tableCellStyle6.Append(tableCellBorders6);
            tableCellStyle6.Append(fillProperties4);

            lastColumn1.Append(tableCellTextStyle2);
            lastColumn1.Append(tableCellStyle6);

            A.FirstColumn firstColumn1 = new A.FirstColumn();

            A.TableCellTextStyle tableCellTextStyle3 = new A.TableCellTextStyle() { Bold = A.BooleanStyleValues.On };

            A.FontReference fontReference3 = new A.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            A.PresetColor presetColor3 = new A.PresetColor() { Val = A.PresetColorValues.Black };

            fontReference3.Append(presetColor3);
            A.SchemeColor schemeColor38 = new A.SchemeColor() { Val = A.SchemeColorValues.Light1 };

            tableCellTextStyle3.Append(fontReference3);
            tableCellTextStyle3.Append(schemeColor38);

            A.TableCellStyle tableCellStyle7 = new A.TableCellStyle();
            A.TableCellBorders tableCellBorders7 = new A.TableCellBorders();

            A.FillProperties fillProperties5 = new A.FillProperties();

            A.SolidFill solidFill26 = new A.SolidFill();
            A.SchemeColor schemeColor39 = new A.SchemeColor() { Val = A.SchemeColorValues.Accent1 };

            solidFill26.Append(schemeColor39);

            fillProperties5.Append(solidFill26);

            tableCellStyle7.Append(tableCellBorders7);
            tableCellStyle7.Append(fillProperties5);

            firstColumn1.Append(tableCellTextStyle3);
            firstColumn1.Append(tableCellStyle7);

            A.LastRow lastRow1 = new A.LastRow();

            A.TableCellTextStyle tableCellTextStyle4 = new A.TableCellTextStyle() { Bold = A.BooleanStyleValues.On };

            A.FontReference fontReference4 = new A.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            A.PresetColor presetColor4 = new A.PresetColor() { Val = A.PresetColorValues.Black };

            fontReference4.Append(presetColor4);
            A.SchemeColor schemeColor40 = new A.SchemeColor() { Val = A.SchemeColorValues.Light1 };

            tableCellTextStyle4.Append(fontReference4);
            tableCellTextStyle4.Append(schemeColor40);

            A.TableCellStyle tableCellStyle8 = new A.TableCellStyle();

            A.TableCellBorders tableCellBorders8 = new A.TableCellBorders();

            A.TopBorder topBorder2 = new A.TopBorder();

            A.Outline outline10 = new A.Outline() { Width = 38100, CompoundLineType = A.CompoundLineValues.Single };

            A.SolidFill solidFill27 = new A.SolidFill();
            A.SchemeColor schemeColor41 = new A.SchemeColor() { Val = A.SchemeColorValues.Light1 };

            solidFill27.Append(schemeColor41);

            outline10.Append(solidFill27);

            topBorder2.Append(outline10);

            tableCellBorders8.Append(topBorder2);

            A.FillProperties fillProperties6 = new A.FillProperties();

            A.SolidFill solidFill28 = new A.SolidFill();
            A.SchemeColor schemeColor42 = new A.SchemeColor() { Val = A.SchemeColorValues.Accent1 };

            solidFill28.Append(schemeColor42);

            fillProperties6.Append(solidFill28);

            tableCellStyle8.Append(tableCellBorders8);
            tableCellStyle8.Append(fillProperties6);

            lastRow1.Append(tableCellTextStyle4);
            lastRow1.Append(tableCellStyle8);

            A.FirstRow firstRow1 = new A.FirstRow();

            A.TableCellTextStyle tableCellTextStyle5 = new A.TableCellTextStyle() { Bold = A.BooleanStyleValues.On };

            A.FontReference fontReference5 = new A.FontReference() { Index = A.FontCollectionIndexValues.Minor };
            A.PresetColor presetColor5 = new A.PresetColor() { Val = A.PresetColorValues.Black };

            fontReference5.Append(presetColor5);
            A.SchemeColor schemeColor43 = new A.SchemeColor() { Val = A.SchemeColorValues.Light1 };

            tableCellTextStyle5.Append(fontReference5);
            tableCellTextStyle5.Append(schemeColor43);

            A.TableCellStyle tableCellStyle9 = new A.TableCellStyle();

            A.TableCellBorders tableCellBorders9 = new A.TableCellBorders();

            A.BottomBorder bottomBorder2 = new A.BottomBorder();

            A.Outline outline11 = new A.Outline() { Width = 38100, CompoundLineType = A.CompoundLineValues.Single };

            A.SolidFill solidFill29 = new A.SolidFill();
            A.SchemeColor schemeColor44 = new A.SchemeColor() { Val = A.SchemeColorValues.Light1 };

            solidFill29.Append(schemeColor44);

            outline11.Append(solidFill29);

            bottomBorder2.Append(outline11);

            tableCellBorders9.Append(bottomBorder2);

            A.FillProperties fillProperties7 = new A.FillProperties();

            A.SolidFill solidFill30 = new A.SolidFill();
            A.SchemeColor schemeColor45 = new A.SchemeColor() { Val = A.SchemeColorValues.Accent1 };

            solidFill30.Append(schemeColor45);

            fillProperties7.Append(solidFill30);

            tableCellStyle9.Append(tableCellBorders9);
            tableCellStyle9.Append(fillProperties7);

            firstRow1.Append(tableCellTextStyle5);
            firstRow1.Append(tableCellStyle9);

            tableStyleEntry1.Append(wholeTable1);
            tableStyleEntry1.Append(band1Horizontal1);
            tableStyleEntry1.Append(band2Horizontal1);
            tableStyleEntry1.Append(band1Vertical1);
            tableStyleEntry1.Append(band2Vertical1);
            tableStyleEntry1.Append(lastColumn1);
            tableStyleEntry1.Append(firstColumn1);
            tableStyleEntry1.Append(lastRow1);
            tableStyleEntry1.Append(firstRow1);

            tableStyleList1.Append(tableStyleEntry1);

            tableStylesPart1.TableStyleList = tableStyleList1;
        }
    }
}
