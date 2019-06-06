using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CV.Management.Generation.Word.ContentHelper
{
    public static class ContentTable7
    {
        // Creates an Table instance and adds its children.
        public static Table GenerateTable(GenerationData data)
        {
            Table table1 = new Table();

            TableProperties tableProperties1 = new TableProperties();
            TableWidth tableWidth1 = new TableWidth() { Width = "0", Type = TableWidthUnitValues.Auto };
            TableIndentation tableIndentation1 = new TableIndentation() { Width = 10, Type = TableWidthUnitValues.Dxa };

            TableBorders tableBorders1 = new TableBorders();
            TopBorder topBorder1 = new TopBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)10U, Space = (UInt32Value)0U };
            LeftBorder leftBorder1 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)10U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder1 = new BottomBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)10U, Space = (UInt32Value)0U };
            RightBorder rightBorder1 = new RightBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)10U, Space = (UInt32Value)0U };
            InsideHorizontalBorder insideHorizontalBorder1 = new InsideHorizontalBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)10U, Space = (UInt32Value)0U };
            InsideVerticalBorder insideVerticalBorder1 = new InsideVerticalBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)10U, Space = (UInt32Value)0U };

            tableBorders1.Append(topBorder1);
            tableBorders1.Append(leftBorder1);
            tableBorders1.Append(bottomBorder1);
            tableBorders1.Append(rightBorder1);
            tableBorders1.Append(insideHorizontalBorder1);
            tableBorders1.Append(insideVerticalBorder1);

            TableCellMarginDefault tableCellMarginDefault1 = new TableCellMarginDefault();
            TableCellLeftMargin tableCellLeftMargin1 = new TableCellLeftMargin() { Width = 10, Type = TableWidthValues.Dxa };
            TableCellRightMargin tableCellRightMargin1 = new TableCellRightMargin() { Width = 10, Type = TableWidthValues.Dxa };

            tableCellMarginDefault1.Append(tableCellLeftMargin1);
            tableCellMarginDefault1.Append(tableCellRightMargin1);
            TableLook tableLook1 = new TableLook() { Val = "0000", FirstRow = false, LastRow = false, FirstColumn = false, LastColumn = false, NoHorizontalBand = false, NoVerticalBand = false };

            tableProperties1.Append(tableWidth1);
            tableProperties1.Append(tableIndentation1);
            tableProperties1.Append(tableBorders1);
            tableProperties1.Append(tableCellMarginDefault1);
            tableProperties1.Append(tableLook1);

            TableGrid tableGrid1 = new TableGrid();
            GridColumn gridColumn1 = new GridColumn() { Width = "2550" };
            GridColumn gridColumn2 = new GridColumn() { Width = "6000" };
            GridColumn gridColumn3 = new GridColumn() { Width = "360" };

            tableGrid1.Append(gridColumn1);
            tableGrid1.Append(gridColumn2);
            tableGrid1.Append(gridColumn3);

            #region CAREER SUMMARY HEADING
            TableRow tableRow1 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "292E8487", TextId = "77777777" };

            TableCell tableCell1 = new TableCell();

            TableCellProperties tableCellProperties1 = new TableCellProperties();
            TableCellWidth tableCellWidth1 = new TableCellWidth() { Width = "8910", Type = TableWidthUnitValues.Dxa };
            GridSpan gridSpan1 = new GridSpan() { Val = 3 };

            TableCellBorders tableCellBorders1 = new TableCellBorders();
            TopBorder topBorder2 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder2 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder2 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder2 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders1.Append(topBorder2);
            tableCellBorders1.Append(leftBorder2);
            tableCellBorders1.Append(bottomBorder2);
            tableCellBorders1.Append(rightBorder2);

            tableCellProperties1.Append(tableCellWidth1);
            tableCellProperties1.Append(gridSpan1);
            tableCellProperties1.Append(tableCellBorders1);

            Paragraph paragraph1 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "1A8987E1", TextId = "77777777" };

            Run run1 = new Run();

            RunProperties runProperties1 = new RunProperties();
            Bold bold1 = new Bold();
            FontSize fontSize1 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript() { Val = "22" };

            runProperties1.Append(bold1);
            runProperties1.Append(fontSize1);
            runProperties1.Append(fontSizeComplexScript1);
            Text text1 = new Text();
            text1.Text = DocumentMetadataTexts.GetText(MetadataTexts.CV_CAREER_SUMMARY, data.Language).ToUpper();

            run1.Append(runProperties1);
            run1.Append(text1);
            
            paragraph1.Append(run1);

            tableCell1.Append(tableCellProperties1);
            tableCell1.Append(paragraph1);

            tableRow1.Append(tableCell1);
            #endregion

            table1.Append(tableProperties1);
            table1.Append(tableGrid1);
            table1.Append(tableRow1);

            var careerSummaries = SortCareerSummary(data.CareerSummary);

            for (int i = 0; i < careerSummaries.Count; i++)
            {
                table1.Append(CreateCompanySubheadingRow(careerSummaries[i], data.Language));
                table1.Append(CreateCompanyInformationRow(careerSummaries[i], data.Language));

                for (int j = 0; j < careerSummaries[i].Roles.Count; j++)
                {
                    table1.Append(CreateRoleInformationRow(careerSummaries[i].Roles[j], data.Language));

                    if (careerSummaries[i].Roles[j].Tasks != null && careerSummaries[i].Roles[j].Tasks.Count() > 1)
                    {
                        table1.Append(CreateTaskInformationRow(careerSummaries[i].Roles[j], data.Language));
                    }

                    if (!string.IsNullOrEmpty(careerSummaries[i].Roles[j].ReportingTo))
                    {
                        table1.Append(CreateReportingToRow(careerSummaries[i].Roles[j], data.Language));
                    }

                    if (!string.IsNullOrEmpty(careerSummaries[i].Roles[j].Subordinates))
                    {
                        table1.Append(CreateSubordinatesRow(careerSummaries[i].Roles[j], data.Language));
                    }

                    if (!string.IsNullOrEmpty(careerSummaries[i].Roles[j].Achievements))
                    {
                        table1.Append(CreateAchievementsRow(careerSummaries[i].Roles[j], data.Language));
                    }

                    if (!string.IsNullOrEmpty(careerSummaries[i].Roles[j].ReasonForLeaving))
                    {
                        table1.Append(CreateReasonForLeavingRow(careerSummaries[i].Roles[j], data.Language));
                    }
                }

                if (i != careerSummaries.Count - 1)
                {
                    table1.Append(CreateEmptyRow());
                }
            }
            
            return table1;
        }

        private static List<CareerSummaryItem> SortCareerSummary(List<CareerSummaryItem> careerSummary)
        {
            var result = new List<CareerSummaryItem>();

            var presentCompanies = careerSummary.Where(x => x.Roles.Where(y => y.EndingYear == null && y.Now.Value).Count() > 0);

            foreach (var company in presentCompanies)
            {
                company.Roles = company.Roles.OrderByDescending(x => x.StartingYear).ToList();
                result.Add(company);
            }

            var nonPresentCompanies = careerSummary.Where(x => x.Roles.Where(y => y.EndingYear.HasValue && !y.Now.Value).Count() > 0 && x.Roles.Where(y => y.EndingYear == null && y.Now.Value).Count() == 0).ToList();

            while(nonPresentCompanies.Count() > 0)
            {
                var highestYear = 0;

                foreach (var company in nonPresentCompanies)
                {
                    var highestYearInPosition = company.Roles.Max(x => x.EndingYear).Value;

                    if (highestYearInPosition > highestYear)
                    {
                        highestYear = highestYearInPosition;
                    }
                }

                var highestCompanies = nonPresentCompanies.Where(x => x.Roles.Where(y => y.EndingYear.HasValue && y.EndingYear.Value == highestYear).Count() > 0);

                var highestStartYear = 0;

                foreach (var company in nonPresentCompanies)
                {
                    var lowestYearInPosition = company.Roles.Min(x => x.StartingYear).Value;

                    if (lowestYearInPosition > highestStartYear)
                    {
                        highestStartYear = lowestYearInPosition;
                    }
                }

                var companies = highestCompanies.Where(x => x.Roles.Where(y => y.StartingYear.Value == highestStartYear).Count() > 0);

                foreach (var company in companies)
                {
                    company.Roles = company.Roles.OrderByDescending(x => x.StartingYear).ToList();
                    result.Add(company);
                }

                nonPresentCompanies.RemoveAll(x => x.Roles.Where(y => y.EndingYear.Value == highestYear && y.StartingYear.Value == highestStartYear).Count() > 0);
            }

            return result;
        }

        private static TableRow CreateCompanySubheadingRow(CareerSummaryItem data, string language)
        {
            TableRow tableRow2 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "69B55967", TextId = "77777777" };

            TableRowProperties tableRowProperties1 = new TableRowProperties();
            GridAfter gridAfter1 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow1 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties1.Append(gridAfter1);
            tableRowProperties1.Append(widthAfterTableRow1);

            TableCell tableCell2 = new TableCell();

            TableCellProperties tableCellProperties2 = new TableCellProperties();
            TableCellWidth tableCellWidth2 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders2 = new TableCellBorders();
            TopBorder topBorder3 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder3 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder3 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder3 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders2.Append(topBorder3);
            tableCellBorders2.Append(leftBorder3);
            tableCellBorders2.Append(bottomBorder3);
            tableCellBorders2.Append(rightBorder3);

            tableCellProperties2.Append(tableCellWidth2);
            tableCellProperties2.Append(tableCellBorders2);

            Paragraph paragraph2 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "789EF4F3", TextId = "77777777" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines() { Before = "30", After = "10" };

            paragraphProperties1.Append(spacingBetweenLines1);

            Run run3 = new Run();

            RunProperties runProperties3 = new RunProperties();
            FontSize fontSize3 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript3 = new FontSizeComplexScript() { Val = "22" };

            runProperties3.Append(fontSize3);
            runProperties3.Append(fontSizeComplexScript3);
            Text text3 = new Text();
            text3.Text = $"{GetCompanyStartingTime(data)} - {GetCompanyEndingTime(data, language)}";

            run3.Append(runProperties3);
            run3.Append(text3);

            paragraph2.Append(paragraphProperties1);
            paragraph2.Append(run3);

            tableCell2.Append(tableCellProperties2);
            tableCell2.Append(paragraph2);

            TableCell tableCell3 = new TableCell();

            TableCellProperties tableCellProperties3 = new TableCellProperties();
            TableCellWidth tableCellWidth3 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders3 = new TableCellBorders();
            TopBorder topBorder4 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder4 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder4 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder4 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders3.Append(topBorder4);
            tableCellBorders3.Append(leftBorder4);
            tableCellBorders3.Append(bottomBorder4);
            tableCellBorders3.Append(rightBorder4);
            Shading shading1 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "0069B4" };

            tableCellProperties3.Append(tableCellWidth3);
            tableCellProperties3.Append(tableCellBorders3);
            tableCellProperties3.Append(shading1);

            Paragraph paragraph3 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "0527FA2E", TextId = "6AA72ECF" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines2 = new SpacingBetweenLines() { Before = "30", After = "10", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation1 = new Indentation() { Left = "144" };

            paragraphProperties2.Append(spacingBetweenLines2);
            paragraphProperties2.Append(indentation1);

            Run run4 = new Run();

            RunProperties runProperties4 = new RunProperties();
            Bold bold2 = new Bold();
            Color color1 = new Color() { Val = "FFFFFF" };
            FontSize fontSize4 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript4 = new FontSizeComplexScript() { Val = "21" };

            runProperties4.Append(bold2);
            runProperties4.Append(color1);
            runProperties4.Append(fontSize4);
            runProperties4.Append(fontSizeComplexScript4);
            Text text4 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text4.Text = data.Company;

            run4.Append(runProperties4);
            run4.Append(text4);

            paragraph3.Append(paragraphProperties2);
            paragraph3.Append(run4);

            tableCell3.Append(tableCellProperties3);
            tableCell3.Append(paragraph3);

            tableRow2.Append(tableRowProperties1);
            tableRow2.Append(tableCell2);
            tableRow2.Append(tableCell3);

            return tableRow2;
        }

        private static TableRow CreateCompanyInformationRow(CareerSummaryItem data, string language)
        {

            TableRow tableRow3 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "25CC8C24", TextId = "77777777" };

            TableRowProperties tableRowProperties2 = new TableRowProperties();
            GridAfter gridAfter2 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow2 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties2.Append(gridAfter2);
            tableRowProperties2.Append(widthAfterTableRow2);

            TableCell tableCell4 = new TableCell();

            TableCellProperties tableCellProperties4 = new TableCellProperties();
            TableCellWidth tableCellWidth4 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders4 = new TableCellBorders();
            TopBorder topBorder5 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder5 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder5 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder5 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders4.Append(topBorder5);
            tableCellBorders4.Append(leftBorder5);
            tableCellBorders4.Append(bottomBorder5);
            tableCellBorders4.Append(rightBorder5);

            tableCellProperties4.Append(tableCellWidth4);
            tableCellProperties4.Append(tableCellBorders4);
            Paragraph paragraph4 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "6D33A213", TextId = "77777777" };

            tableCell4.Append(tableCellProperties4);
            tableCell4.Append(paragraph4);

            TableCell tableCell5 = new TableCell();

            TableCellProperties tableCellProperties5 = new TableCellProperties();
            TableCellWidth tableCellWidth5 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders5 = new TableCellBorders();
            TopBorder topBorder6 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder6 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder6 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder6 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders5.Append(topBorder6);
            tableCellBorders5.Append(leftBorder6);
            tableCellBorders5.Append(bottomBorder6);
            tableCellBorders5.Append(rightBorder6);

            tableCellProperties5.Append(tableCellWidth5);
            tableCellProperties5.Append(tableCellBorders5);

            Paragraph paragraph5 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "70DDB50D", TextId = "77777777" };

            ParagraphProperties paragraphProperties3 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines3 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation2 = new Indentation() { Left = "144" };

            paragraphProperties3.Append(spacingBetweenLines3);
            paragraphProperties3.Append(indentation2);

            Run run6 = new Run();

            RunProperties runProperties6 = new RunProperties();
            Bold bold4 = new Bold();
            FontSize fontSize6 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript6 = new FontSizeComplexScript() { Val = "22" };

            runProperties6.Append(bold4);
            runProperties6.Append(fontSize6);
            runProperties6.Append(fontSizeComplexScript6);
            Text text6 = new Text();
            text6.Text = $"{DocumentMetadataTexts.GetText(MetadataTexts.CV_COMPANY_INFORMATION, language)}:";

            run6.Append(runProperties6);
            run6.Append(text6);

            paragraph5.Append(paragraphProperties3);
            paragraph5.Append(run6);

            tableCell5.Append(tableCellProperties5);
            tableCell5.Append(paragraph5);

            if (!string.IsNullOrEmpty(data.City))
            {
                var paragraph10 = CreateCompanyInformationParagraph(DocumentMetadataTexts.GetText(MetadataTexts.CV_COMPANY_CITY, language), data.City);
                tableCell5.Append(paragraph10);
            }

            if (!string.IsNullOrEmpty(data.ParentCompany))
            {
                var paragraph10 = CreateCompanyInformationParagraph(DocumentMetadataTexts.GetText(MetadataTexts.CV_COMPANY_PARENT_COMPANY, language), data.ParentCompany);
                tableCell5.Append(paragraph10);
            }

            if (!string.IsNullOrEmpty(data.Industry))
            {
                var paragraph6 = CreateCompanyInformationParagraph(DocumentMetadataTexts.GetText(MetadataTexts.CV_COMPANY_INDUSTRY, language), data.Industry);
                tableCell5.Append(paragraph6);
            }

            if (!string.IsNullOrEmpty(data.Services))
            {
                var paragraph7 = CreateCompanyInformationParagraph(DocumentMetadataTexts.GetText(MetadataTexts.CV_COMPANY_SERVICES, language), data.Services);
                tableCell5.Append(paragraph7);
            }

            if (!string.IsNullOrEmpty(data.Turnover))
            {
                var paragraph8 = CreateCompanyInformationParagraph(DocumentMetadataTexts.GetText(MetadataTexts.CV_COMPANY_TURNOVER, language), data.Turnover);
                tableCell5.Append(paragraph8);
            }

            if (!string.IsNullOrEmpty(data.NumberOfEmployees))
            {
                var paragraph9 = CreateCompanyInformationParagraph(DocumentMetadataTexts.GetText(MetadataTexts.CV_COMPANY_EMPLOYEES, language), data.NumberOfEmployees);
                tableCell5.Append(paragraph9);
            }

            tableRow3.Append(tableRowProperties2);
            tableRow3.Append(tableCell4);
            tableRow3.Append(tableCell5);

            return tableRow3;
        }

        private static TableRow CreateRoleInformationRow(RoleInformation data, string language)
        {
            TableRow tableRow4 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "418DF43A", TextId = "77777777" };

            TableRowProperties tableRowProperties3 = new TableRowProperties();
            GridAfter gridAfter3 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow3 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties3.Append(gridAfter3);
            tableRowProperties3.Append(widthAfterTableRow3);

            TableCell tableCell6 = new TableCell();

            TableCellProperties tableCellProperties6 = new TableCellProperties();
            TableCellWidth tableCellWidth6 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders6 = new TableCellBorders();
            TopBorder topBorder7 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder7 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder7 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder7 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders6.Append(topBorder7);
            tableCellBorders6.Append(leftBorder7);
            tableCellBorders6.Append(bottomBorder7);
            tableCellBorders6.Append(rightBorder7);

            tableCellProperties6.Append(tableCellWidth6);
            tableCellProperties6.Append(tableCellBorders6);
            Paragraph paragraph10 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "3329142D", TextId = "77777777" };

            tableCell6.Append(tableCellProperties6);
            tableCell6.Append(paragraph10);

            TableCell tableCell7 = new TableCell();

            TableCellProperties tableCellProperties7 = new TableCellProperties();
            TableCellWidth tableCellWidth7 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders7 = new TableCellBorders();
            TopBorder topBorder8 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder8 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder8 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder8 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders7.Append(topBorder8);
            tableCellBorders7.Append(leftBorder8);
            tableCellBorders7.Append(bottomBorder8);
            tableCellBorders7.Append(rightBorder8);

            tableCellProperties7.Append(tableCellWidth7);
            tableCellProperties7.Append(tableCellBorders7);

            Paragraph paragraph11 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "49F7C6AF", TextId = "77777777" };

            ParagraphProperties paragraphProperties8 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines8 = new SpacingBetweenLines() { Before = "200", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation7 = new Indentation() { Left = "144" };

            paragraphProperties8.Append(spacingBetweenLines8);
            paragraphProperties8.Append(indentation7);

            Run run19 = new Run();

            RunProperties runProperties19 = new RunProperties();
            Bold bold5 = new Bold();
            FontSize fontSize19 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript19 = new FontSizeComplexScript() { Val = "21" };

            runProperties19.Append(bold5);
            runProperties19.Append(fontSize19);
            runProperties19.Append(fontSizeComplexScript19);
            Text text19 = new Text();
            text19.Text = data.Role.ToUpper();

            run19.Append(runProperties19);
            run19.Append(text19);

            Run run20 = new Run();

            RunProperties runProperties20 = new RunProperties();
            FontSize fontSize20 = new FontSize() { Val = "21" };
            FontSizeComplexScript fontSizeComplexScript20 = new FontSizeComplexScript() { Val = "21" };

            runProperties20.Append(fontSize20);
            runProperties20.Append(fontSizeComplexScript20);
            Text text20 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            var endingYear = data.EndingYear.HasValue ? data.EndingYear.ToString() : DocumentMetadataTexts.GetText(MetadataTexts.CV_PRESENT, language); ;
            text20.Text = $" ({data.StartingYear} - {endingYear})";

            run20.Append(runProperties20);
            run20.Append(text20);
            
            paragraph11.Append(paragraphProperties8);
            paragraph11.Append(run19);
            paragraph11.Append(run20);

            tableCell7.Append(tableCellProperties7);
            tableCell7.Append(paragraph11);

            tableRow4.Append(tableRowProperties3);
            tableRow4.Append(tableCell6);
            tableRow4.Append(tableCell7);

            return tableRow4;
        }

        private static TableRow CreateTaskInformationRow(RoleInformation data, string language)
        {
            TableRow tableRow5 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "7B3ACA60", TextId = "77777777" };

            TableRowProperties tableRowProperties4 = new TableRowProperties();
            GridAfter gridAfter4 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow4 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties4.Append(gridAfter4);
            tableRowProperties4.Append(widthAfterTableRow4);

            TableCell tableCell8 = new TableCell();

            TableCellProperties tableCellProperties8 = new TableCellProperties();
            TableCellWidth tableCellWidth8 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders8 = new TableCellBorders();
            TopBorder topBorder9 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder9 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder9 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder9 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders8.Append(topBorder9);
            tableCellBorders8.Append(leftBorder9);
            tableCellBorders8.Append(bottomBorder9);
            tableCellBorders8.Append(rightBorder9);

            tableCellProperties8.Append(tableCellWidth8);
            tableCellProperties8.Append(tableCellBorders8);
            Paragraph paragraph12 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "7DDF27F0", TextId = "77777777" };

            tableCell8.Append(tableCellProperties8);
            tableCell8.Append(paragraph12);

            TableCell tableCell9 = new TableCell();

            TableCellProperties tableCellProperties9 = new TableCellProperties();
            TableCellWidth tableCellWidth9 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders9 = new TableCellBorders();
            TopBorder topBorder10 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder10 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder10 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder10 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders9.Append(topBorder10);
            tableCellBorders9.Append(leftBorder10);
            tableCellBorders9.Append(bottomBorder10);
            tableCellBorders9.Append(rightBorder10);

            tableCellProperties9.Append(tableCellWidth9);
            tableCellProperties9.Append(tableCellBorders9);

            Paragraph paragraph13 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "750C1E57", TextId = "77777777" };

            ParagraphProperties paragraphProperties9 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines9 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation8 = new Indentation() { Left = "144" };

            paragraphProperties9.Append(spacingBetweenLines9);
            paragraphProperties9.Append(indentation8);

            Run run23 = new Run();

            RunProperties runProperties23 = new RunProperties();
            Bold bold6 = new Bold();
            FontSize fontSize23 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript23 = new FontSizeComplexScript() { Val = "22" };

            runProperties23.Append(bold6);
            runProperties23.Append(fontSize23);
            runProperties23.Append(fontSizeComplexScript23);
            Text text23 = new Text();
            text23.Text = $"{DocumentMetadataTexts.GetText(MetadataTexts.CV_TASK_INFORMATION, language)}: ";

            run23.Append(runProperties23);
            run23.Append(text23);

            paragraph13.Append(paragraphProperties9);
            paragraph13.Append(run23);

            var taskInformationParagraphs = new List<Paragraph>();

            foreach (var task in data.Tasks)
            {
                Paragraph paragraph14 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "0477A132", TextId = "77777777" };

                ParagraphProperties paragraphProperties10 = new ParagraphProperties();
                SpacingBetweenLines spacingBetweenLines10 = new SpacingBetweenLines() { After = "20" };
                Indentation indentation9 = new Indentation() { Left = "413", Hanging = "283" };

                paragraphProperties10.Append(spacingBetweenLines10);
                paragraphProperties10.Append(indentation9);

                Run run26 = new Run();

                RunProperties runProperties26 = new RunProperties();
                FontSize fontSize26 = new FontSize() { Val = "22" };
                FontSizeComplexScript fontSizeComplexScript26 = new FontSizeComplexScript() { Val = "22" };

                runProperties26.Append(fontSize26);
                runProperties26.Append(fontSizeComplexScript26);
                Text text26 = new Text() { Space = SpaceProcessingModeValues.Preserve };
                text26.Text = $"{task};";

                run26.Append(runProperties26);
                run26.Append(text26);

                NumberingProperties numberingProperties1 = new NumberingProperties();
                NumberingLevelReference numberingLevelReference1 = new NumberingLevelReference() { Val = 0 };
                NumberingId numberingId1 = new NumberingId() { Val = 1 };

                numberingProperties1.Append(numberingLevelReference1);
                numberingProperties1.Append(numberingId1);

                paragraph14.Append(numberingProperties1);

                paragraph14.Append(paragraphProperties10);
                paragraph14.Append(run26);

                taskInformationParagraphs.Add(paragraph14);
            }
            
            tableCell9.Append(tableCellProperties9);
            tableCell9.Append(paragraph13);

            taskInformationParagraphs.ForEach(x => tableCell9.Append(x));

            tableRow5.Append(tableRowProperties4);
            tableRow5.Append(tableCell8);
            tableRow5.Append(tableCell9);

            return tableRow5;
        }

        private static TableRow CreateReportingToRow(RoleInformation data, string language)
        {
            TableRow tableRow6 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "5D5C1C0F", TextId = "77777777" };

            TableRowProperties tableRowProperties5 = new TableRowProperties();
            GridAfter gridAfter5 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow5 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties5.Append(gridAfter5);
            tableRowProperties5.Append(widthAfterTableRow5);

            TableCell tableCell10 = new TableCell();

            TableCellProperties tableCellProperties10 = new TableCellProperties();
            TableCellWidth tableCellWidth10 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders10 = new TableCellBorders();
            TopBorder topBorder11 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder11 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder11 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder11 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders10.Append(topBorder11);
            tableCellBorders10.Append(leftBorder11);
            tableCellBorders10.Append(bottomBorder11);
            tableCellBorders10.Append(rightBorder11);

            tableCellProperties10.Append(tableCellWidth10);
            tableCellProperties10.Append(tableCellBorders10);
            Paragraph paragraph17 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "1972B01A", TextId = "77777777" };

            tableCell10.Append(tableCellProperties10);
            tableCell10.Append(paragraph17);

            TableCell tableCell11 = new TableCell();

            TableCellProperties tableCellProperties11 = new TableCellProperties();
            TableCellWidth tableCellWidth11 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders11 = new TableCellBorders();
            TopBorder topBorder12 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder12 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder12 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder12 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders11.Append(topBorder12);
            tableCellBorders11.Append(leftBorder12);
            tableCellBorders11.Append(bottomBorder12);
            tableCellBorders11.Append(rightBorder12);

            tableCellProperties11.Append(tableCellWidth11);
            tableCellProperties11.Append(tableCellBorders11);

            Paragraph paragraph18 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "5FDA8639", TextId = "2ABBA17A" };

            ParagraphProperties paragraphProperties13 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines13 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation12 = new Indentation() { Left = "144" };

            paragraphProperties13.Append(spacingBetweenLines13);
            paragraphProperties13.Append(indentation12);

            Run run33 = new Run();

            RunProperties runProperties33 = new RunProperties();
            Bold bold7 = new Bold();
            FontSize fontSize33 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript33 = new FontSizeComplexScript() { Val = "22" };

            runProperties33.Append(bold7);
            runProperties33.Append(fontSize33);
            runProperties33.Append(fontSizeComplexScript33);
            Text text33 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text33.Text = $"{DocumentMetadataTexts.GetText(MetadataTexts.CV_POSITION_REPORTING_TO, language)}: ";

            run33.Append(runProperties33);
            run33.Append(text33);

            Run run148 = new Run();

            RunProperties runProperties148 = new RunProperties();
            FontSize fontSize148 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript148 = new FontSizeComplexScript() { Val = "22" };

            runProperties148.Append(fontSize148);
            runProperties148.Append(fontSizeComplexScript148);
            Text text148 = new Text();
            text148.Text = data.ReportingTo;

            run148.Append(runProperties148);
            run148.Append(text148);

            paragraph18.Append(paragraphProperties13);
            paragraph18.Append(run33);
            paragraph18.Append(run148);

            tableCell11.Append(tableCellProperties11);
            tableCell11.Append(paragraph18);

            tableRow6.Append(tableRowProperties5);
            tableRow6.Append(tableCell10);
            tableRow6.Append(tableCell11);

            return tableRow6;
        }

        private static TableRow CreateSubordinatesRow(RoleInformation data, string language)
        {
            TableRow tableRow6 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "5D5C1C0F", TextId = "77777777" };

            TableRowProperties tableRowProperties5 = new TableRowProperties();
            GridAfter gridAfter5 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow5 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties5.Append(gridAfter5);
            tableRowProperties5.Append(widthAfterTableRow5);

            TableCell tableCell10 = new TableCell();

            TableCellProperties tableCellProperties10 = new TableCellProperties();
            TableCellWidth tableCellWidth10 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders10 = new TableCellBorders();
            TopBorder topBorder11 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder11 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder11 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder11 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders10.Append(topBorder11);
            tableCellBorders10.Append(leftBorder11);
            tableCellBorders10.Append(bottomBorder11);
            tableCellBorders10.Append(rightBorder11);

            tableCellProperties10.Append(tableCellWidth10);
            tableCellProperties10.Append(tableCellBorders10);
            Paragraph paragraph17 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "1972B01A", TextId = "77777777" };

            tableCell10.Append(tableCellProperties10);
            tableCell10.Append(paragraph17);

            TableCell tableCell11 = new TableCell();

            TableCellProperties tableCellProperties11 = new TableCellProperties();
            TableCellWidth tableCellWidth11 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders11 = new TableCellBorders();
            TopBorder topBorder12 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder12 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder12 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder12 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders11.Append(topBorder12);
            tableCellBorders11.Append(leftBorder12);
            tableCellBorders11.Append(bottomBorder12);
            tableCellBorders11.Append(rightBorder12);

            tableCellProperties11.Append(tableCellWidth11);
            tableCellProperties11.Append(tableCellBorders11);

            Paragraph paragraph18 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "5FDA8639", TextId = "2ABBA17A" };

            ParagraphProperties paragraphProperties13 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines13 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation12 = new Indentation() { Left = "144" };

            paragraphProperties13.Append(spacingBetweenLines13);
            paragraphProperties13.Append(indentation12);

            Run run33 = new Run();

            RunProperties runProperties33 = new RunProperties();
            Bold bold7 = new Bold();
            FontSize fontSize33 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript33 = new FontSizeComplexScript() { Val = "22" };

            runProperties33.Append(bold7);
            runProperties33.Append(fontSize33);
            runProperties33.Append(fontSizeComplexScript33);
            Text text33 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text33.Text = $"{DocumentMetadataTexts.GetText(MetadataTexts.CV_POSTION_SUBORDINATES, language)}: ";

            run33.Append(runProperties33);
            run33.Append(text33);

            Run run148 = new Run();

            RunProperties runProperties148 = new RunProperties();
            FontSize fontSize148 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript148 = new FontSizeComplexScript() { Val = "22" };

            runProperties148.Append(fontSize148);
            runProperties148.Append(fontSizeComplexScript148);
            Text text148 = new Text();
            text148.Text = data.Subordinates;

            run148.Append(runProperties148);
            run148.Append(text148);

            paragraph18.Append(paragraphProperties13);
            paragraph18.Append(run33);
            paragraph18.Append(run148);

            tableCell11.Append(tableCellProperties11);
            tableCell11.Append(paragraph18);

            tableRow6.Append(tableRowProperties5);
            tableRow6.Append(tableCell10);
            tableRow6.Append(tableCell11);

            return tableRow6;
        }

        private static TableRow CreateAchievementsRow(RoleInformation data, string language)
        {
            TableRow tableRow6 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "5D5C1C0F", TextId = "77777777" };

            TableRowProperties tableRowProperties5 = new TableRowProperties();
            GridAfter gridAfter5 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow5 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties5.Append(gridAfter5);
            tableRowProperties5.Append(widthAfterTableRow5);

            TableCell tableCell10 = new TableCell();

            TableCellProperties tableCellProperties10 = new TableCellProperties();
            TableCellWidth tableCellWidth10 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders10 = new TableCellBorders();
            TopBorder topBorder11 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder11 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder11 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder11 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders10.Append(topBorder11);
            tableCellBorders10.Append(leftBorder11);
            tableCellBorders10.Append(bottomBorder11);
            tableCellBorders10.Append(rightBorder11);

            tableCellProperties10.Append(tableCellWidth10);
            tableCellProperties10.Append(tableCellBorders10);
            Paragraph paragraph17 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "1972B01A", TextId = "77777777" };

            tableCell10.Append(tableCellProperties10);
            tableCell10.Append(paragraph17);

            TableCell tableCell11 = new TableCell();

            TableCellProperties tableCellProperties11 = new TableCellProperties();
            TableCellWidth tableCellWidth11 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders11 = new TableCellBorders();
            TopBorder topBorder12 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder12 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder12 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder12 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders11.Append(topBorder12);
            tableCellBorders11.Append(leftBorder12);
            tableCellBorders11.Append(bottomBorder12);
            tableCellBorders11.Append(rightBorder12);

            tableCellProperties11.Append(tableCellWidth11);
            tableCellProperties11.Append(tableCellBorders11);

            Paragraph paragraph18 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009E39C2", ParagraphId = "5FDA8639", TextId = "2ABBA17A" };

            ParagraphProperties paragraphProperties13 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines13 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation12 = new Indentation() { Left = "144" };

            paragraphProperties13.Append(spacingBetweenLines13);
            paragraphProperties13.Append(indentation12);

            Run run33 = new Run();

            RunProperties runProperties33 = new RunProperties();
            Bold bold7 = new Bold();
            FontSize fontSize33 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript33 = new FontSizeComplexScript() { Val = "22" };

            runProperties33.Append(bold7);
            runProperties33.Append(fontSize33);
            runProperties33.Append(fontSizeComplexScript33);
            Text text33 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text33.Text = $"{DocumentMetadataTexts.GetText(MetadataTexts.CV_POSITION_ACHIEVEMENTS, language)}: ";

            run33.Append(runProperties33);
            run33.Append(text33);

            Run run148 = new Run();

            RunProperties runProperties148 = new RunProperties();
            FontSize fontSize148 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript148 = new FontSizeComplexScript() { Val = "22" };

            runProperties148.Append(fontSize148);
            runProperties148.Append(fontSizeComplexScript148);
            Text text148 = new Text();
            text148.Text = data.Achievements;

            run148.Append(runProperties148);
            run148.Append(text148);

            paragraph18.Append(paragraphProperties13);
            paragraph18.Append(run33);
            paragraph18.Append(run148);

            tableCell11.Append(tableCellProperties11);
            tableCell11.Append(paragraph18);

            tableRow6.Append(tableRowProperties5);
            tableRow6.Append(tableCell10);
            tableRow6.Append(tableCell11);

            return tableRow6;
        }

        private static TableRow CreateReasonForLeavingRow(RoleInformation data, string language)
        {
            TableRow tableRow25 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "18133863", TextId = "77777777" };

            TableRowProperties tableRowProperties24 = new TableRowProperties();
            GridAfter gridAfter24 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow24 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties24.Append(gridAfter24);
            tableRowProperties24.Append(widthAfterTableRow24);

            TableCell tableCell48 = new TableCell();

            TableCellProperties tableCellProperties48 = new TableCellProperties();
            TableCellWidth tableCellWidth48 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders48 = new TableCellBorders();
            TopBorder topBorder49 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder49 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder49 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder49 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders48.Append(topBorder49);
            tableCellBorders48.Append(leftBorder49);
            tableCellBorders48.Append(bottomBorder49);
            tableCellBorders48.Append(rightBorder49);

            tableCellProperties48.Append(tableCellWidth48);
            tableCellProperties48.Append(tableCellBorders48);
            Paragraph paragraph77 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "275A5090", TextId = "77777777" };

            tableCell48.Append(tableCellProperties48);
            tableCell48.Append(paragraph77);

            TableCell tableCell49 = new TableCell();

            TableCellProperties tableCellProperties49 = new TableCellProperties();
            TableCellWidth tableCellWidth49 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders49 = new TableCellBorders();
            TopBorder topBorder50 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder50 = new LeftBorder() { Val = BorderValues.Single, Color = "000000", Size = (UInt32Value)1U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder50 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder50 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders49.Append(topBorder50);
            tableCellBorders49.Append(leftBorder50);
            tableCellBorders49.Append(bottomBorder50);
            tableCellBorders49.Append(rightBorder50);

            tableCellProperties49.Append(tableCellWidth49);
            tableCellProperties49.Append(tableCellBorders49);

            Paragraph paragraph78 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "50F6687C", TextId = "0F3C5F31" };

            ParagraphProperties paragraphProperties54 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines54 = new SpacingBetweenLines() { Before = "150", After = "100", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation50 = new Indentation() { Left = "144" };

            paragraphProperties54.Append(spacingBetweenLines54);
            paragraphProperties54.Append(indentation50);

            Run run147 = new Run();

            RunProperties runProperties147 = new RunProperties();
            Bold bold24 = new Bold();
            FontSize fontSize147 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript147 = new FontSizeComplexScript() { Val = "22" };

            runProperties147.Append(bold24);
            runProperties147.Append(fontSize147);
            runProperties147.Append(fontSizeComplexScript147);
            Text text147 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text147.Text = $"{DocumentMetadataTexts.GetText(MetadataTexts.CV_POSITION_REASON_FOR_LEAVING, language)}: ";

            run147.Append(runProperties147);
            run147.Append(text147);

            Run run148 = new Run();

            RunProperties runProperties148 = new RunProperties();
            FontSize fontSize148 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript148 = new FontSizeComplexScript() { Val = "22" };

            runProperties148.Append(fontSize148);
            runProperties148.Append(fontSizeComplexScript148);
            Text text148 = new Text();
            text148.Text = data.ReasonForLeaving;

            run148.Append(runProperties148);
            run148.Append(text148);

            paragraph78.Append(paragraphProperties54);
            paragraph78.Append(run147);
            paragraph78.Append(run148);

            tableCell49.Append(tableCellProperties49);
            tableCell49.Append(paragraph78);

            tableRow25.Append(tableRowProperties24);
            tableRow25.Append(tableCell48);
            tableRow25.Append(tableCell49);

            return tableRow25;
        }

        private static TableRow CreateEmptyRow()
        {
            TableRow tableRow7 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "13B6C217", TextId = "77777777" };

            TableRowProperties tableRowProperties6 = new TableRowProperties();
            GridAfter gridAfter6 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow6 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties6.Append(gridAfter6);
            tableRowProperties6.Append(widthAfterTableRow6);

            TableCell tableCell12 = new TableCell();

            TableCellProperties tableCellProperties12 = new TableCellProperties();
            TableCellWidth tableCellWidth12 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders12 = new TableCellBorders();
            TopBorder topBorder13 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder13 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder13 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder13 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders12.Append(topBorder13);
            tableCellBorders12.Append(leftBorder13);
            tableCellBorders12.Append(bottomBorder13);
            tableCellBorders12.Append(rightBorder13);

            tableCellProperties12.Append(tableCellWidth12);
            tableCellProperties12.Append(tableCellBorders12);
            Paragraph paragraph19 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "31AD661C", TextId = "77777777" };

            tableCell12.Append(tableCellProperties12);
            tableCell12.Append(paragraph19);

            TableCell tableCell13 = new TableCell();

            TableCellProperties tableCellProperties13 = new TableCellProperties();
            TableCellWidth tableCellWidth13 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders13 = new TableCellBorders();
            TopBorder topBorder14 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder14 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder14 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder14 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders13.Append(topBorder14);
            tableCellBorders13.Append(leftBorder14);
            tableCellBorders13.Append(bottomBorder14);
            tableCellBorders13.Append(rightBorder14);

            tableCellProperties13.Append(tableCellWidth13);
            tableCellProperties13.Append(tableCellBorders13);
            Paragraph paragraph20 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "643300E8", TextId = "77777777" };

            tableCell13.Append(tableCellProperties13);
            tableCell13.Append(paragraph20);

            tableRow7.Append(tableRowProperties6);
            tableRow7.Append(tableCell12);
            tableRow7.Append(tableCell13);

            return tableRow7;
        }

        private static TableRow CreateEndingRow()
        {
            TableRow tableRow39 = new TableRow() { RsidTableRowAddition = "009B2C1D", RsidTableRowProperties = "009E39C2", ParagraphId = "549FE295", TextId = "77777777" };

            TableRowProperties tableRowProperties38 = new TableRowProperties();
            GridAfter gridAfter38 = new GridAfter() { Val = 1 };
            WidthAfterTableRow widthAfterTableRow38 = new WidthAfterTableRow() { Width = "360", Type = TableWidthUnitValues.Dxa };

            tableRowProperties38.Append(gridAfter38);
            tableRowProperties38.Append(widthAfterTableRow38);

            TableCell tableCell76 = new TableCell();

            TableCellProperties tableCellProperties76 = new TableCellProperties();
            TableCellWidth tableCellWidth76 = new TableCellWidth() { Width = "2550", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders76 = new TableCellBorders();
            TopBorder topBorder77 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder77 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder77 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder77 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders76.Append(topBorder77);
            tableCellBorders76.Append(leftBorder77);
            tableCellBorders76.Append(bottomBorder77);
            tableCellBorders76.Append(rightBorder77);

            tableCellProperties76.Append(tableCellWidth76);
            tableCellProperties76.Append(tableCellBorders76);
            Paragraph paragraph124 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "79641948", TextId = "77777777" };

            tableCell76.Append(tableCellProperties76);
            tableCell76.Append(paragraph124);

            TableCell tableCell77 = new TableCell();

            TableCellProperties tableCellProperties77 = new TableCellProperties();
            TableCellWidth tableCellWidth77 = new TableCellWidth() { Width = "6000", Type = TableWidthUnitValues.Dxa };

            TableCellBorders tableCellBorders77 = new TableCellBorders();
            TopBorder topBorder78 = new TopBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            LeftBorder leftBorder78 = new LeftBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder78 = new BottomBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };
            RightBorder rightBorder78 = new RightBorder() { Val = BorderValues.Single, Color = "FFFFFF", Size = (UInt32Value)0U, Space = (UInt32Value)0U };

            tableCellBorders77.Append(topBorder78);
            tableCellBorders77.Append(leftBorder78);
            tableCellBorders77.Append(bottomBorder78);
            tableCellBorders77.Append(rightBorder78);

            tableCellProperties77.Append(tableCellWidth77);
            tableCellProperties77.Append(tableCellBorders77);
            Paragraph paragraph125 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidRunAdditionDefault = "009B2C1D", ParagraphId = "03280296", TextId = "77777777" };
            Paragraph paragraph126 = new Paragraph() { RsidParagraphAddition = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "300F77D7", TextId = "77777777" };
            Paragraph paragraph127 = new Paragraph() { RsidParagraphAddition = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "19BFA0FA", TextId = "77777777" };
            Paragraph paragraph128 = new Paragraph() { RsidParagraphAddition = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "102ACA4F", TextId = "5C754407" };

            tableCell77.Append(tableCellProperties77);
            tableCell77.Append(paragraph125);
            tableCell77.Append(paragraph126);
            tableCell77.Append(paragraph127);
            tableCell77.Append(paragraph128);

            tableRow39.Append(tableRowProperties38);
            tableRow39.Append(tableCell76);
            tableRow39.Append(tableCell77);

            return tableRow39;
        }

        private static Paragraph CreateCompanyInformationParagraph(string sectionName, string value)
        {
            Paragraph paragraph6 = new Paragraph() { RsidParagraphAddition = "009B2C1D", RsidParagraphProperties = "009E39C2", RsidRunAdditionDefault = "009E39C2", ParagraphId = "0477A132", TextId = "77777777" };

            ParagraphProperties paragraphProperties4 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines4 = new SpacingBetweenLines() { After = "20" };
            Indentation indentation3 = new Indentation() { Left = "413", Hanging = "283" };

            paragraphProperties4.Append(spacingBetweenLines4);
            paragraphProperties4.Append(indentation3);

            Run run9 = new Run();

            RunProperties runProperties9 = new RunProperties();
            FontSize fontSize9 = new FontSize() { Val = "22" };
            FontSizeComplexScript fontSizeComplexScript9 = new FontSizeComplexScript() { Val = "22" };

            runProperties9.Append(fontSize9);
            runProperties9.Append(fontSizeComplexScript9);
            Text text9 = new Text();
            text9.Text = $"{sectionName}: {value}";

            run9.Append(runProperties9);
            run9.Append(text9);

            NumberingProperties numberingProperties1 = new NumberingProperties();
            NumberingLevelReference numberingLevelReference1 = new NumberingLevelReference() { Val = 0 };
            NumberingId numberingId1 = new NumberingId() { Val = 1 };

            numberingProperties1.Append(numberingLevelReference1);
            numberingProperties1.Append(numberingId1);

            paragraph6.Append(numberingProperties1);

            paragraph6.Append(paragraphProperties4);
            paragraph6.Append(run9);

            return paragraph6;
        }

        private static string GetCompanyStartingTime(CareerSummaryItem data)
        {
            var minTime = data.Roles.Min(x => x.StartingYear).ToString();

            return minTime;
        }

        private static string GetCompanyEndingTime(CareerSummaryItem data, string language)
        {
            var role = data.Roles.FirstOrDefault(x => x.Now == true);

            if (role != null)
            {
                return DocumentMetadataTexts.GetText(MetadataTexts.CV_PRESENT, language);
            }

            var maxTime = data.Roles.Max(x => x.EndingYear).ToString();

            return maxTime;
        }
    }
}
