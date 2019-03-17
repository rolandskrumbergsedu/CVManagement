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
    public static class GenerateSlideLayoutPartHelper
    {
        public static void GenerateSlideLayoutPart11Content(SlideLayoutPart slideLayoutPart11)
        {
            SlideLayout slideLayout11 = new SlideLayout() { Type = SlideLayoutValues.PictureText, Preserve = true };
            slideLayout11.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout11.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout11.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData16 = new CommonSlideData() { Name = "Picture with Caption" };

            ShapeTree shapeTree16 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties16 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties61 = new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties16 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties61 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties16.Append(nonVisualDrawingProperties61);
            nonVisualGroupShapeProperties16.Append(nonVisualGroupShapeDrawingProperties16);
            nonVisualGroupShapeProperties16.Append(applicationNonVisualDrawingProperties61);

            GroupShapeProperties groupShapeProperties16 = new GroupShapeProperties();

            A.TransformGroup transformGroup16 = new A.TransformGroup();
            A.Offset offset55 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents55 = new A.Extents() { Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset16 = new A.ChildOffset() { X = 0L, Y = 0L };
            A.ChildExtents childExtents16 = new A.ChildExtents() { Cx = 0L, Cy = 0L };

            transformGroup16.Append(offset55);
            transformGroup16.Append(extents55);
            transformGroup16.Append(childOffset16);
            transformGroup16.Append(childExtents16);

            groupShapeProperties16.Append(transformGroup16);

            Shape shape42 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties42 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties62 = new NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties42 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks42 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties42.Append(shapeLocks42);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties62 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape35 = new PlaceholderShape() { Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties62.Append(placeholderShape35);

            nonVisualShapeProperties42.Append(nonVisualDrawingProperties62);
            nonVisualShapeProperties42.Append(nonVisualShapeDrawingProperties42);
            nonVisualShapeProperties42.Append(applicationNonVisualDrawingProperties62);

            ShapeProperties shapeProperties48 = new ShapeProperties();

            A.Transform2D transform2D40 = new A.Transform2D();
            A.Offset offset56 = new A.Offset() { X = 1941645L, Y = 4800600L };
            A.Extents extents56 = new A.Extents() { Cx = 5943600L, Cy = 566738L };

            transform2D40.Append(offset56);
            transform2D40.Append(extents56);

            shapeProperties48.Append(transform2D40);

            TextBody textBody40 = new TextBody();
            A.BodyProperties bodyProperties42 = new A.BodyProperties() { Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle42 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties34 = new A.Level1ParagraphProperties() { Alignment = A.TextAlignmentTypeValues.Left };
            A.DefaultRunProperties defaultRunProperties237 = new A.DefaultRunProperties() { FontSize = 2000, Bold = true };

            level1ParagraphProperties34.Append(defaultRunProperties237);

            listStyle42.Append(level1ParagraphProperties34);

            A.Paragraph paragraph97 = new A.Paragraph();

            A.Run run94 = new A.Run();
            A.RunProperties runProperties99 = new A.RunProperties() { Language = "en-US" };
            A.Text text99 = new A.Text();
            text99.Text = "Click to edit Master title style";

            run94.Append(runProperties99);
            run94.Append(text99);
            A.EndParagraphRunProperties endParagraphRunProperties39 = new A.EndParagraphRunProperties() { Language = "lv-LV" };

            paragraph97.Append(run94);
            paragraph97.Append(endParagraphRunProperties39);

            textBody40.Append(bodyProperties42);
            textBody40.Append(listStyle42);
            textBody40.Append(paragraph97);

            shape42.Append(nonVisualShapeProperties42);
            shape42.Append(shapeProperties48);
            shape42.Append(textBody40);

            Shape shape43 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties43 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties63 = new NonVisualDrawingProperties() { Id = (UInt32Value)3U, Name = "Picture Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties43 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks43 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties43.Append(shapeLocks43);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties63 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape36 = new PlaceholderShape() { Type = PlaceholderValues.Picture, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties63.Append(placeholderShape36);

            nonVisualShapeProperties43.Append(nonVisualDrawingProperties63);
            nonVisualShapeProperties43.Append(nonVisualShapeDrawingProperties43);
            nonVisualShapeProperties43.Append(applicationNonVisualDrawingProperties63);

            ShapeProperties shapeProperties49 = new ShapeProperties();

            A.Transform2D transform2D41 = new A.Transform2D();
            A.Offset offset57 = new A.Offset() { X = 1941645L, Y = 612775L };
            A.Extents extents57 = new A.Extents() { Cx = 5943600L, Cy = 4114800L };

            transform2D41.Append(offset57);
            transform2D41.Append(extents57);

            shapeProperties49.Append(transform2D41);

            TextBody textBody41 = new TextBody();
            A.BodyProperties bodyProperties43 = new A.BodyProperties();

            A.ListStyle listStyle43 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties35 = new A.Level1ParagraphProperties() { LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet54 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties238 = new A.DefaultRunProperties() { FontSize = 3200 };

            level1ParagraphProperties35.Append(noBullet54);
            level1ParagraphProperties35.Append(defaultRunProperties238);

            A.Level2ParagraphProperties level2ParagraphProperties23 = new A.Level2ParagraphProperties() { LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet55 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties239 = new A.DefaultRunProperties() { FontSize = 2800 };

            level2ParagraphProperties23.Append(noBullet55);
            level2ParagraphProperties23.Append(defaultRunProperties239);

            A.Level3ParagraphProperties level3ParagraphProperties23 = new A.Level3ParagraphProperties() { LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet56 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties240 = new A.DefaultRunProperties() { FontSize = 2400 };

            level3ParagraphProperties23.Append(noBullet56);
            level3ParagraphProperties23.Append(defaultRunProperties240);

            A.Level4ParagraphProperties level4ParagraphProperties23 = new A.Level4ParagraphProperties() { LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet57 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties241 = new A.DefaultRunProperties() { FontSize = 2000 };

            level4ParagraphProperties23.Append(noBullet57);
            level4ParagraphProperties23.Append(defaultRunProperties241);

            A.Level5ParagraphProperties level5ParagraphProperties23 = new A.Level5ParagraphProperties() { LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet58 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties242 = new A.DefaultRunProperties() { FontSize = 2000 };

            level5ParagraphProperties23.Append(noBullet58);
            level5ParagraphProperties23.Append(defaultRunProperties242);

            A.Level6ParagraphProperties level6ParagraphProperties23 = new A.Level6ParagraphProperties() { LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet59 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties243 = new A.DefaultRunProperties() { FontSize = 2000 };

            level6ParagraphProperties23.Append(noBullet59);
            level6ParagraphProperties23.Append(defaultRunProperties243);

            A.Level7ParagraphProperties level7ParagraphProperties23 = new A.Level7ParagraphProperties() { LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet60 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties244 = new A.DefaultRunProperties() { FontSize = 2000 };

            level7ParagraphProperties23.Append(noBullet60);
            level7ParagraphProperties23.Append(defaultRunProperties244);

            A.Level8ParagraphProperties level8ParagraphProperties23 = new A.Level8ParagraphProperties() { LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet61 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties245 = new A.DefaultRunProperties() { FontSize = 2000 };

            level8ParagraphProperties23.Append(noBullet61);
            level8ParagraphProperties23.Append(defaultRunProperties245);

            A.Level9ParagraphProperties level9ParagraphProperties23 = new A.Level9ParagraphProperties() { LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet62 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties246 = new A.DefaultRunProperties() { FontSize = 2000 };

            level9ParagraphProperties23.Append(noBullet62);
            level9ParagraphProperties23.Append(defaultRunProperties246);

            listStyle43.Append(level1ParagraphProperties35);
            listStyle43.Append(level2ParagraphProperties23);
            listStyle43.Append(level3ParagraphProperties23);
            listStyle43.Append(level4ParagraphProperties23);
            listStyle43.Append(level5ParagraphProperties23);
            listStyle43.Append(level6ParagraphProperties23);
            listStyle43.Append(level7ParagraphProperties23);
            listStyle43.Append(level8ParagraphProperties23);
            listStyle43.Append(level9ParagraphProperties23);

            A.Paragraph paragraph98 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties88 = new A.ParagraphProperties() { Level = 0 };
            A.EndParagraphRunProperties endParagraphRunProperties40 = new A.EndParagraphRunProperties() { Language = "lv-LV", NoProof = false };

            paragraph98.Append(paragraphProperties88);
            paragraph98.Append(endParagraphRunProperties40);

            textBody41.Append(bodyProperties43);
            textBody41.Append(listStyle43);
            textBody41.Append(paragraph98);

            shape43.Append(nonVisualShapeProperties43);
            shape43.Append(shapeProperties49);
            shape43.Append(textBody41);

            Shape shape44 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties44 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties64 = new NonVisualDrawingProperties() { Id = (UInt32Value)4U, Name = "Text Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties44 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks44 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties44.Append(shapeLocks44);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties64 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape37 = new PlaceholderShape() { Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties64.Append(placeholderShape37);

            nonVisualShapeProperties44.Append(nonVisualDrawingProperties64);
            nonVisualShapeProperties44.Append(nonVisualShapeDrawingProperties44);
            nonVisualShapeProperties44.Append(applicationNonVisualDrawingProperties64);

            ShapeProperties shapeProperties50 = new ShapeProperties();

            A.Transform2D transform2D42 = new A.Transform2D();
            A.Offset offset58 = new A.Offset() { X = 1941645L, Y = 5367338L };
            A.Extents extents58 = new A.Extents() { Cx = 5943600L, Cy = 804862L };

            transform2D42.Append(offset58);
            transform2D42.Append(extents58);

            shapeProperties50.Append(transform2D42);

            TextBody textBody42 = new TextBody();
            A.BodyProperties bodyProperties44 = new A.BodyProperties();

            A.ListStyle listStyle44 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties36 = new A.Level1ParagraphProperties() { LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet63 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties247 = new A.DefaultRunProperties() { FontSize = 1400 };

            level1ParagraphProperties36.Append(noBullet63);
            level1ParagraphProperties36.Append(defaultRunProperties247);

            A.Level2ParagraphProperties level2ParagraphProperties24 = new A.Level2ParagraphProperties() { LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet64 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties248 = new A.DefaultRunProperties() { FontSize = 1200 };

            level2ParagraphProperties24.Append(noBullet64);
            level2ParagraphProperties24.Append(defaultRunProperties248);

            A.Level3ParagraphProperties level3ParagraphProperties24 = new A.Level3ParagraphProperties() { LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet65 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties249 = new A.DefaultRunProperties() { FontSize = 1000 };

            level3ParagraphProperties24.Append(noBullet65);
            level3ParagraphProperties24.Append(defaultRunProperties249);

            A.Level4ParagraphProperties level4ParagraphProperties24 = new A.Level4ParagraphProperties() { LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet66 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties250 = new A.DefaultRunProperties() { FontSize = 900 };

            level4ParagraphProperties24.Append(noBullet66);
            level4ParagraphProperties24.Append(defaultRunProperties250);

            A.Level5ParagraphProperties level5ParagraphProperties24 = new A.Level5ParagraphProperties() { LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet67 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties251 = new A.DefaultRunProperties() { FontSize = 900 };

            level5ParagraphProperties24.Append(noBullet67);
            level5ParagraphProperties24.Append(defaultRunProperties251);

            A.Level6ParagraphProperties level6ParagraphProperties24 = new A.Level6ParagraphProperties() { LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet68 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties252 = new A.DefaultRunProperties() { FontSize = 900 };

            level6ParagraphProperties24.Append(noBullet68);
            level6ParagraphProperties24.Append(defaultRunProperties252);

            A.Level7ParagraphProperties level7ParagraphProperties24 = new A.Level7ParagraphProperties() { LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet69 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties253 = new A.DefaultRunProperties() { FontSize = 900 };

            level7ParagraphProperties24.Append(noBullet69);
            level7ParagraphProperties24.Append(defaultRunProperties253);

            A.Level8ParagraphProperties level8ParagraphProperties24 = new A.Level8ParagraphProperties() { LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet70 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties254 = new A.DefaultRunProperties() { FontSize = 900 };

            level8ParagraphProperties24.Append(noBullet70);
            level8ParagraphProperties24.Append(defaultRunProperties254);

            A.Level9ParagraphProperties level9ParagraphProperties24 = new A.Level9ParagraphProperties() { LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet71 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties255 = new A.DefaultRunProperties() { FontSize = 900 };

            level9ParagraphProperties24.Append(noBullet71);
            level9ParagraphProperties24.Append(defaultRunProperties255);

            listStyle44.Append(level1ParagraphProperties36);
            listStyle44.Append(level2ParagraphProperties24);
            listStyle44.Append(level3ParagraphProperties24);
            listStyle44.Append(level4ParagraphProperties24);
            listStyle44.Append(level5ParagraphProperties24);
            listStyle44.Append(level6ParagraphProperties24);
            listStyle44.Append(level7ParagraphProperties24);
            listStyle44.Append(level8ParagraphProperties24);
            listStyle44.Append(level9ParagraphProperties24);

            A.Paragraph paragraph99 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties89 = new A.ParagraphProperties() { Level = 0 };

            A.Run run95 = new A.Run();
            A.RunProperties runProperties100 = new A.RunProperties() { Language = "en-US" };
            A.Text text100 = new A.Text();
            text100.Text = "Click to edit Master text styles";

            run95.Append(runProperties100);
            run95.Append(text100);

            paragraph99.Append(paragraphProperties89);
            paragraph99.Append(run95);

            textBody42.Append(bodyProperties44);
            textBody42.Append(listStyle44);
            textBody42.Append(paragraph99);

            shape44.Append(nonVisualShapeProperties44);
            shape44.Append(shapeProperties50);
            shape44.Append(textBody42);

            shapeTree16.Append(nonVisualGroupShapeProperties16);
            shapeTree16.Append(groupShapeProperties16);
            shapeTree16.Append(shape42);
            shapeTree16.Append(shape43);
            shapeTree16.Append(shape44);

            CommonSlideDataExtensionList commonSlideDataExtensionList15 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension15 = new CommonSlideDataExtension() { Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId15 = new P14.CreationId() { Val = (UInt32Value)3423225199U };
            creationId15.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension15.Append(creationId15);

            commonSlideDataExtensionList15.Append(commonSlideDataExtension15);

            commonSlideData16.Append(shapeTree16);
            commonSlideData16.Append(commonSlideDataExtensionList15);

            ColorMapOverride colorMapOverride13 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping13 = new A.MasterColorMapping();

            colorMapOverride13.Append(masterColorMapping13);

            slideLayout11.Append(commonSlideData16);
            slideLayout11.Append(colorMapOverride13);

            slideLayoutPart11.SlideLayout = slideLayout11;

        }

        public static void GenerateSlideLayoutPart10Content(SlideLayoutPart slideLayoutPart10)
        {
            SlideLayout slideLayout10 = new SlideLayout() { Type = SlideLayoutValues.TwoObjects, Preserve = true };
            slideLayout10.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout10.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout10.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData15 = new CommonSlideData() { Name = "Two Content" };

            ShapeTree shapeTree15 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties15 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties57 = new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties15 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties57 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties15.Append(nonVisualDrawingProperties57);
            nonVisualGroupShapeProperties15.Append(nonVisualGroupShapeDrawingProperties15);
            nonVisualGroupShapeProperties15.Append(applicationNonVisualDrawingProperties57);

            GroupShapeProperties groupShapeProperties15 = new GroupShapeProperties();

            A.TransformGroup transformGroup15 = new A.TransformGroup();
            A.Offset offset52 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents52 = new A.Extents() { Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset15 = new A.ChildOffset() { X = 0L, Y = 0L };
            A.ChildExtents childExtents15 = new A.ChildExtents() { Cx = 0L, Cy = 0L };

            transformGroup15.Append(offset52);
            transformGroup15.Append(extents52);
            transformGroup15.Append(childOffset15);
            transformGroup15.Append(childExtents15);

            groupShapeProperties15.Append(transformGroup15);

            Shape shape39 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties39 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties58 = new NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties39 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks39 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties39.Append(shapeLocks39);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties58 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape32 = new PlaceholderShape() { Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties58.Append(placeholderShape32);

            nonVisualShapeProperties39.Append(nonVisualDrawingProperties58);
            nonVisualShapeProperties39.Append(nonVisualShapeDrawingProperties39);
            nonVisualShapeProperties39.Append(applicationNonVisualDrawingProperties58);
            ShapeProperties shapeProperties45 = new ShapeProperties();

            TextBody textBody37 = new TextBody();
            A.BodyProperties bodyProperties39 = new A.BodyProperties();
            A.ListStyle listStyle39 = new A.ListStyle();

            A.Paragraph paragraph86 = new A.Paragraph();

            A.Run run83 = new A.Run();
            A.RunProperties runProperties88 = new A.RunProperties() { Language = "en-US" };
            A.Text text88 = new A.Text();
            text88.Text = "Click to edit Master title style";

            run83.Append(runProperties88);
            run83.Append(text88);
            A.EndParagraphRunProperties endParagraphRunProperties36 = new A.EndParagraphRunProperties() { Language = "lv-LV" };

            paragraph86.Append(run83);
            paragraph86.Append(endParagraphRunProperties36);

            textBody37.Append(bodyProperties39);
            textBody37.Append(listStyle39);
            textBody37.Append(paragraph86);

            shape39.Append(nonVisualShapeProperties39);
            shape39.Append(shapeProperties45);
            shape39.Append(textBody37);

            Shape shape40 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties40 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties59 = new NonVisualDrawingProperties() { Id = (UInt32Value)3U, Name = "Content Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties40 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks40 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties40.Append(shapeLocks40);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties59 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape33 = new PlaceholderShape() { Size = PlaceholderSizeValues.Half, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties59.Append(placeholderShape33);

            nonVisualShapeProperties40.Append(nonVisualDrawingProperties59);
            nonVisualShapeProperties40.Append(nonVisualShapeDrawingProperties40);
            nonVisualShapeProperties40.Append(applicationNonVisualDrawingProperties59);

            ShapeProperties shapeProperties46 = new ShapeProperties();

            A.Transform2D transform2D38 = new A.Transform2D();
            A.Offset offset53 = new A.Offset() { X = 572692L, Y = 1525589L };
            A.Extents extents53 = new A.Extents() { Cx = 4294319L, Cy = 3957637L };

            transform2D38.Append(offset53);
            transform2D38.Append(extents53);

            shapeProperties46.Append(transform2D38);

            TextBody textBody38 = new TextBody();
            A.BodyProperties bodyProperties40 = new A.BodyProperties();

            A.ListStyle listStyle40 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties32 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties219 = new A.DefaultRunProperties() { FontSize = 2800 };

            level1ParagraphProperties32.Append(defaultRunProperties219);

            A.Level2ParagraphProperties level2ParagraphProperties21 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties220 = new A.DefaultRunProperties() { FontSize = 2400 };

            level2ParagraphProperties21.Append(defaultRunProperties220);

            A.Level3ParagraphProperties level3ParagraphProperties21 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties221 = new A.DefaultRunProperties() { FontSize = 2000 };

            level3ParagraphProperties21.Append(defaultRunProperties221);

            A.Level4ParagraphProperties level4ParagraphProperties21 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties222 = new A.DefaultRunProperties() { FontSize = 1800 };

            level4ParagraphProperties21.Append(defaultRunProperties222);

            A.Level5ParagraphProperties level5ParagraphProperties21 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties223 = new A.DefaultRunProperties() { FontSize = 1800 };

            level5ParagraphProperties21.Append(defaultRunProperties223);

            A.Level6ParagraphProperties level6ParagraphProperties21 = new A.Level6ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties224 = new A.DefaultRunProperties() { FontSize = 1800 };

            level6ParagraphProperties21.Append(defaultRunProperties224);

            A.Level7ParagraphProperties level7ParagraphProperties21 = new A.Level7ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties225 = new A.DefaultRunProperties() { FontSize = 1800 };

            level7ParagraphProperties21.Append(defaultRunProperties225);

            A.Level8ParagraphProperties level8ParagraphProperties21 = new A.Level8ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties226 = new A.DefaultRunProperties() { FontSize = 1800 };

            level8ParagraphProperties21.Append(defaultRunProperties226);

            A.Level9ParagraphProperties level9ParagraphProperties21 = new A.Level9ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties227 = new A.DefaultRunProperties() { FontSize = 1800 };

            level9ParagraphProperties21.Append(defaultRunProperties227);

            listStyle40.Append(level1ParagraphProperties32);
            listStyle40.Append(level2ParagraphProperties21);
            listStyle40.Append(level3ParagraphProperties21);
            listStyle40.Append(level4ParagraphProperties21);
            listStyle40.Append(level5ParagraphProperties21);
            listStyle40.Append(level6ParagraphProperties21);
            listStyle40.Append(level7ParagraphProperties21);
            listStyle40.Append(level8ParagraphProperties21);
            listStyle40.Append(level9ParagraphProperties21);

            A.Paragraph paragraph87 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties78 = new A.ParagraphProperties() { Level = 0 };

            A.Run run84 = new A.Run();
            A.RunProperties runProperties89 = new A.RunProperties() { Language = "en-US" };
            A.Text text89 = new A.Text();
            text89.Text = "Click to edit Master text styles";

            run84.Append(runProperties89);
            run84.Append(text89);

            paragraph87.Append(paragraphProperties78);
            paragraph87.Append(run84);

            A.Paragraph paragraph88 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties79 = new A.ParagraphProperties() { Level = 1 };

            A.Run run85 = new A.Run();
            A.RunProperties runProperties90 = new A.RunProperties() { Language = "en-US" };
            A.Text text90 = new A.Text();
            text90.Text = "Second level";

            run85.Append(runProperties90);
            run85.Append(text90);

            paragraph88.Append(paragraphProperties79);
            paragraph88.Append(run85);

            A.Paragraph paragraph89 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties80 = new A.ParagraphProperties() { Level = 2 };

            A.Run run86 = new A.Run();
            A.RunProperties runProperties91 = new A.RunProperties() { Language = "en-US" };
            A.Text text91 = new A.Text();
            text91.Text = "Third level";

            run86.Append(runProperties91);
            run86.Append(text91);

            paragraph89.Append(paragraphProperties80);
            paragraph89.Append(run86);

            A.Paragraph paragraph90 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties81 = new A.ParagraphProperties() { Level = 3 };

            A.Run run87 = new A.Run();
            A.RunProperties runProperties92 = new A.RunProperties() { Language = "en-US" };
            A.Text text92 = new A.Text();
            text92.Text = "Fourth level";

            run87.Append(runProperties92);
            run87.Append(text92);

            paragraph90.Append(paragraphProperties81);
            paragraph90.Append(run87);

            A.Paragraph paragraph91 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties82 = new A.ParagraphProperties() { Level = 4 };

            A.Run run88 = new A.Run();
            A.RunProperties runProperties93 = new A.RunProperties() { Language = "en-US" };
            A.Text text93 = new A.Text();
            text93.Text = "Fifth level";

            run88.Append(runProperties93);
            run88.Append(text93);
            A.EndParagraphRunProperties endParagraphRunProperties37 = new A.EndParagraphRunProperties() { Language = "lv-LV" };

            paragraph91.Append(paragraphProperties82);
            paragraph91.Append(run88);
            paragraph91.Append(endParagraphRunProperties37);

            textBody38.Append(bodyProperties40);
            textBody38.Append(listStyle40);
            textBody38.Append(paragraph87);
            textBody38.Append(paragraph88);
            textBody38.Append(paragraph89);
            textBody38.Append(paragraph90);
            textBody38.Append(paragraph91);

            shape40.Append(nonVisualShapeProperties40);
            shape40.Append(shapeProperties46);
            shape40.Append(textBody38);

            Shape shape41 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties41 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties60 = new NonVisualDrawingProperties() { Id = (UInt32Value)4U, Name = "Content Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties41 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks41 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties41.Append(shapeLocks41);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties60 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape34 = new PlaceholderShape() { Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties60.Append(placeholderShape34);

            nonVisualShapeProperties41.Append(nonVisualDrawingProperties60);
            nonVisualShapeProperties41.Append(nonVisualShapeDrawingProperties41);
            nonVisualShapeProperties41.Append(applicationNonVisualDrawingProperties60);

            ShapeProperties shapeProperties47 = new ShapeProperties();

            A.Transform2D transform2D39 = new A.Transform2D();
            A.Offset offset54 = new A.Offset() { X = 5032111L, Y = 1525589L };
            A.Extents extents54 = new A.Extents() { Cx = 4296040L, Cy = 3957637L };

            transform2D39.Append(offset54);
            transform2D39.Append(extents54);

            shapeProperties47.Append(transform2D39);

            TextBody textBody39 = new TextBody();
            A.BodyProperties bodyProperties41 = new A.BodyProperties();

            A.ListStyle listStyle41 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties33 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties228 = new A.DefaultRunProperties() { FontSize = 2800 };

            level1ParagraphProperties33.Append(defaultRunProperties228);

            A.Level2ParagraphProperties level2ParagraphProperties22 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties229 = new A.DefaultRunProperties() { FontSize = 2400 };

            level2ParagraphProperties22.Append(defaultRunProperties229);

            A.Level3ParagraphProperties level3ParagraphProperties22 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties230 = new A.DefaultRunProperties() { FontSize = 2000 };

            level3ParagraphProperties22.Append(defaultRunProperties230);

            A.Level4ParagraphProperties level4ParagraphProperties22 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties231 = new A.DefaultRunProperties() { FontSize = 1800 };

            level4ParagraphProperties22.Append(defaultRunProperties231);

            A.Level5ParagraphProperties level5ParagraphProperties22 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties232 = new A.DefaultRunProperties() { FontSize = 1800 };

            level5ParagraphProperties22.Append(defaultRunProperties232);

            A.Level6ParagraphProperties level6ParagraphProperties22 = new A.Level6ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties233 = new A.DefaultRunProperties() { FontSize = 1800 };

            level6ParagraphProperties22.Append(defaultRunProperties233);

            A.Level7ParagraphProperties level7ParagraphProperties22 = new A.Level7ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties234 = new A.DefaultRunProperties() { FontSize = 1800 };

            level7ParagraphProperties22.Append(defaultRunProperties234);

            A.Level8ParagraphProperties level8ParagraphProperties22 = new A.Level8ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties235 = new A.DefaultRunProperties() { FontSize = 1800 };

            level8ParagraphProperties22.Append(defaultRunProperties235);

            A.Level9ParagraphProperties level9ParagraphProperties22 = new A.Level9ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties236 = new A.DefaultRunProperties() { FontSize = 1800 };

            level9ParagraphProperties22.Append(defaultRunProperties236);

            listStyle41.Append(level1ParagraphProperties33);
            listStyle41.Append(level2ParagraphProperties22);
            listStyle41.Append(level3ParagraphProperties22);
            listStyle41.Append(level4ParagraphProperties22);
            listStyle41.Append(level5ParagraphProperties22);
            listStyle41.Append(level6ParagraphProperties22);
            listStyle41.Append(level7ParagraphProperties22);
            listStyle41.Append(level8ParagraphProperties22);
            listStyle41.Append(level9ParagraphProperties22);

            A.Paragraph paragraph92 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties83 = new A.ParagraphProperties() { Level = 0 };

            A.Run run89 = new A.Run();
            A.RunProperties runProperties94 = new A.RunProperties() { Language = "en-US" };
            A.Text text94 = new A.Text();
            text94.Text = "Click to edit Master text styles";

            run89.Append(runProperties94);
            run89.Append(text94);

            paragraph92.Append(paragraphProperties83);
            paragraph92.Append(run89);

            A.Paragraph paragraph93 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties84 = new A.ParagraphProperties() { Level = 1 };

            A.Run run90 = new A.Run();
            A.RunProperties runProperties95 = new A.RunProperties() { Language = "en-US" };
            A.Text text95 = new A.Text();
            text95.Text = "Second level";

            run90.Append(runProperties95);
            run90.Append(text95);

            paragraph93.Append(paragraphProperties84);
            paragraph93.Append(run90);

            A.Paragraph paragraph94 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties85 = new A.ParagraphProperties() { Level = 2 };

            A.Run run91 = new A.Run();
            A.RunProperties runProperties96 = new A.RunProperties() { Language = "en-US" };
            A.Text text96 = new A.Text();
            text96.Text = "Third level";

            run91.Append(runProperties96);
            run91.Append(text96);

            paragraph94.Append(paragraphProperties85);
            paragraph94.Append(run91);

            A.Paragraph paragraph95 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties86 = new A.ParagraphProperties() { Level = 3 };

            A.Run run92 = new A.Run();
            A.RunProperties runProperties97 = new A.RunProperties() { Language = "en-US" };
            A.Text text97 = new A.Text();
            text97.Text = "Fourth level";

            run92.Append(runProperties97);
            run92.Append(text97);

            paragraph95.Append(paragraphProperties86);
            paragraph95.Append(run92);

            A.Paragraph paragraph96 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties87 = new A.ParagraphProperties() { Level = 4 };

            A.Run run93 = new A.Run();
            A.RunProperties runProperties98 = new A.RunProperties() { Language = "en-US" };
            A.Text text98 = new A.Text();
            text98.Text = "Fifth level";

            run93.Append(runProperties98);
            run93.Append(text98);
            A.EndParagraphRunProperties endParagraphRunProperties38 = new A.EndParagraphRunProperties() { Language = "lv-LV" };

            paragraph96.Append(paragraphProperties87);
            paragraph96.Append(run93);
            paragraph96.Append(endParagraphRunProperties38);

            textBody39.Append(bodyProperties41);
            textBody39.Append(listStyle41);
            textBody39.Append(paragraph92);
            textBody39.Append(paragraph93);
            textBody39.Append(paragraph94);
            textBody39.Append(paragraph95);
            textBody39.Append(paragraph96);

            shape41.Append(nonVisualShapeProperties41);
            shape41.Append(shapeProperties47);
            shape41.Append(textBody39);

            shapeTree15.Append(nonVisualGroupShapeProperties15);
            shapeTree15.Append(groupShapeProperties15);
            shapeTree15.Append(shape39);
            shapeTree15.Append(shape40);
            shapeTree15.Append(shape41);

            CommonSlideDataExtensionList commonSlideDataExtensionList14 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension14 = new CommonSlideDataExtension() { Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId14 = new P14.CreationId() { Val = (UInt32Value)178459135U };
            creationId14.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension14.Append(creationId14);

            commonSlideDataExtensionList14.Append(commonSlideDataExtension14);

            commonSlideData15.Append(shapeTree15);
            commonSlideData15.Append(commonSlideDataExtensionList14);

            ColorMapOverride colorMapOverride12 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping12 = new A.MasterColorMapping();

            colorMapOverride12.Append(masterColorMapping12);

            slideLayout10.Append(commonSlideData15);
            slideLayout10.Append(colorMapOverride12);

            slideLayoutPart10.SlideLayout = slideLayout10;
        }

        public static void GenerateSlideLayoutPart9Content(SlideLayoutPart slideLayoutPart9)
        {
            SlideLayout slideLayout9 = new SlideLayout() { Type = SlideLayoutValues.VerticalText, Preserve = true };
            slideLayout9.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout9.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout9.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData14 = new CommonSlideData() { Name = "Title and Vertical Text" };

            ShapeTree shapeTree14 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties14 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties54 = new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties14 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties54 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties14.Append(nonVisualDrawingProperties54);
            nonVisualGroupShapeProperties14.Append(nonVisualGroupShapeDrawingProperties14);
            nonVisualGroupShapeProperties14.Append(applicationNonVisualDrawingProperties54);

            GroupShapeProperties groupShapeProperties14 = new GroupShapeProperties();

            A.TransformGroup transformGroup14 = new A.TransformGroup();
            A.Offset offset51 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents51 = new A.Extents() { Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset14 = new A.ChildOffset() { X = 0L, Y = 0L };
            A.ChildExtents childExtents14 = new A.ChildExtents() { Cx = 0L, Cy = 0L };

            transformGroup14.Append(offset51);
            transformGroup14.Append(extents51);
            transformGroup14.Append(childOffset14);
            transformGroup14.Append(childExtents14);

            groupShapeProperties14.Append(transformGroup14);

            Shape shape37 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties37 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties55 = new NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties37 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks37 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties37.Append(shapeLocks37);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties55 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape30 = new PlaceholderShape() { Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties55.Append(placeholderShape30);

            nonVisualShapeProperties37.Append(nonVisualDrawingProperties55);
            nonVisualShapeProperties37.Append(nonVisualShapeDrawingProperties37);
            nonVisualShapeProperties37.Append(applicationNonVisualDrawingProperties55);
            ShapeProperties shapeProperties43 = new ShapeProperties();

            TextBody textBody35 = new TextBody();
            A.BodyProperties bodyProperties37 = new A.BodyProperties();
            A.ListStyle listStyle37 = new A.ListStyle();

            A.Paragraph paragraph80 = new A.Paragraph();

            A.Run run77 = new A.Run();
            A.RunProperties runProperties82 = new A.RunProperties() { Language = "en-US" };
            A.Text text82 = new A.Text();
            text82.Text = "Click to edit Master title style";

            run77.Append(runProperties82);
            run77.Append(text82);
            A.EndParagraphRunProperties endParagraphRunProperties34 = new A.EndParagraphRunProperties() { Language = "lv-LV" };

            paragraph80.Append(run77);
            paragraph80.Append(endParagraphRunProperties34);

            textBody35.Append(bodyProperties37);
            textBody35.Append(listStyle37);
            textBody35.Append(paragraph80);

            shape37.Append(nonVisualShapeProperties37);
            shape37.Append(shapeProperties43);
            shape37.Append(textBody35);

            Shape shape38 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties38 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties56 = new NonVisualDrawingProperties() { Id = (UInt32Value)3U, Name = "Vertical Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties38 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks38 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties38.Append(shapeLocks38);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties56 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape31 = new PlaceholderShape() { Type = PlaceholderValues.Body, Orientation = DirectionValues.Vertical, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties56.Append(placeholderShape31);

            nonVisualShapeProperties38.Append(nonVisualDrawingProperties56);
            nonVisualShapeProperties38.Append(nonVisualShapeDrawingProperties38);
            nonVisualShapeProperties38.Append(applicationNonVisualDrawingProperties56);
            ShapeProperties shapeProperties44 = new ShapeProperties();

            TextBody textBody36 = new TextBody();
            A.BodyProperties bodyProperties38 = new A.BodyProperties() { Vertical = A.TextVerticalValues.EastAsianVetical };
            A.ListStyle listStyle38 = new A.ListStyle();

            A.Paragraph paragraph81 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties73 = new A.ParagraphProperties() { Level = 0 };

            A.Run run78 = new A.Run();
            A.RunProperties runProperties83 = new A.RunProperties() { Language = "en-US" };
            A.Text text83 = new A.Text();
            text83.Text = "Click to edit Master text styles";

            run78.Append(runProperties83);
            run78.Append(text83);

            paragraph81.Append(paragraphProperties73);
            paragraph81.Append(run78);

            A.Paragraph paragraph82 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties74 = new A.ParagraphProperties() { Level = 1 };

            A.Run run79 = new A.Run();
            A.RunProperties runProperties84 = new A.RunProperties() { Language = "en-US" };
            A.Text text84 = new A.Text();
            text84.Text = "Second level";

            run79.Append(runProperties84);
            run79.Append(text84);

            paragraph82.Append(paragraphProperties74);
            paragraph82.Append(run79);

            A.Paragraph paragraph83 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties75 = new A.ParagraphProperties() { Level = 2 };

            A.Run run80 = new A.Run();
            A.RunProperties runProperties85 = new A.RunProperties() { Language = "en-US" };
            A.Text text85 = new A.Text();
            text85.Text = "Third level";

            run80.Append(runProperties85);
            run80.Append(text85);

            paragraph83.Append(paragraphProperties75);
            paragraph83.Append(run80);

            A.Paragraph paragraph84 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties76 = new A.ParagraphProperties() { Level = 3 };

            A.Run run81 = new A.Run();
            A.RunProperties runProperties86 = new A.RunProperties() { Language = "en-US" };
            A.Text text86 = new A.Text();
            text86.Text = "Fourth level";

            run81.Append(runProperties86);
            run81.Append(text86);

            paragraph84.Append(paragraphProperties76);
            paragraph84.Append(run81);

            A.Paragraph paragraph85 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties77 = new A.ParagraphProperties() { Level = 4 };

            A.Run run82 = new A.Run();
            A.RunProperties runProperties87 = new A.RunProperties() { Language = "en-US" };
            A.Text text87 = new A.Text();
            text87.Text = "Fifth level";

            run82.Append(runProperties87);
            run82.Append(text87);
            A.EndParagraphRunProperties endParagraphRunProperties35 = new A.EndParagraphRunProperties() { Language = "lv-LV" };

            paragraph85.Append(paragraphProperties77);
            paragraph85.Append(run82);
            paragraph85.Append(endParagraphRunProperties35);

            textBody36.Append(bodyProperties38);
            textBody36.Append(listStyle38);
            textBody36.Append(paragraph81);
            textBody36.Append(paragraph82);
            textBody36.Append(paragraph83);
            textBody36.Append(paragraph84);
            textBody36.Append(paragraph85);

            shape38.Append(nonVisualShapeProperties38);
            shape38.Append(shapeProperties44);
            shape38.Append(textBody36);

            shapeTree14.Append(nonVisualGroupShapeProperties14);
            shapeTree14.Append(groupShapeProperties14);
            shapeTree14.Append(shape37);
            shapeTree14.Append(shape38);

            CommonSlideDataExtensionList commonSlideDataExtensionList13 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension13 = new CommonSlideDataExtension() { Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId13 = new P14.CreationId() { Val = (UInt32Value)2943347409U };
            creationId13.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension13.Append(creationId13);

            commonSlideDataExtensionList13.Append(commonSlideDataExtension13);

            commonSlideData14.Append(shapeTree14);
            commonSlideData14.Append(commonSlideDataExtensionList13);

            ColorMapOverride colorMapOverride11 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping11 = new A.MasterColorMapping();

            colorMapOverride11.Append(masterColorMapping11);

            slideLayout9.Append(commonSlideData14);
            slideLayout9.Append(colorMapOverride11);

            slideLayoutPart9.SlideLayout = slideLayout9;

        }

        public static void GenerateSlideLayoutPart8Content(SlideLayoutPart slideLayoutPart8)
        {

            SlideLayout slideLayout8 = new SlideLayout() { Type = SlideLayoutValues.TwoTextAndTwoObjects, Preserve = true };
            slideLayout8.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout8.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout8.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData13 = new CommonSlideData() { Name = "Comparison" };

            ShapeTree shapeTree13 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties13 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties48 = new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties13 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties48 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties13.Append(nonVisualDrawingProperties48);
            nonVisualGroupShapeProperties13.Append(nonVisualGroupShapeDrawingProperties13);
            nonVisualGroupShapeProperties13.Append(applicationNonVisualDrawingProperties48);

            GroupShapeProperties groupShapeProperties13 = new GroupShapeProperties();

            A.TransformGroup transformGroup13 = new A.TransformGroup();
            A.Offset offset45 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents45 = new A.Extents() { Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset13 = new A.ChildOffset() { X = 0L, Y = 0L };
            A.ChildExtents childExtents13 = new A.ChildExtents() { Cx = 0L, Cy = 0L };

            transformGroup13.Append(offset45);
            transformGroup13.Append(extents45);
            transformGroup13.Append(childOffset13);
            transformGroup13.Append(childExtents13);

            groupShapeProperties13.Append(transformGroup13);

            Shape shape32 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties32 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties49 = new NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties32 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks32 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties32.Append(shapeLocks32);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties49 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape25 = new PlaceholderShape() { Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties49.Append(placeholderShape25);

            nonVisualShapeProperties32.Append(nonVisualDrawingProperties49);
            nonVisualShapeProperties32.Append(nonVisualShapeDrawingProperties32);
            nonVisualShapeProperties32.Append(applicationNonVisualDrawingProperties49);

            ShapeProperties shapeProperties38 = new ShapeProperties();

            A.Transform2D transform2D33 = new A.Transform2D();
            A.Offset offset46 = new A.Offset() { X = 495300L, Y = 274638L };
            A.Extents extents46 = new A.Extents() { Cx = 8915400L, Cy = 1143000L };

            transform2D33.Append(offset46);
            transform2D33.Append(extents46);

            shapeProperties38.Append(transform2D33);

            TextBody textBody30 = new TextBody();
            A.BodyProperties bodyProperties32 = new A.BodyProperties();

            A.ListStyle listStyle32 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties27 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties182 = new A.DefaultRunProperties();

            level1ParagraphProperties27.Append(defaultRunProperties182);

            listStyle32.Append(level1ParagraphProperties27);

            A.Paragraph paragraph67 = new A.Paragraph();

            A.Run run64 = new A.Run();
            A.RunProperties runProperties69 = new A.RunProperties() { Language = "en-US" };
            A.Text text69 = new A.Text();
            text69.Text = "Click to edit Master title style";

            run64.Append(runProperties69);
            run64.Append(text69);
            A.EndParagraphRunProperties endParagraphRunProperties31 = new A.EndParagraphRunProperties() { Language = "lv-LV" };

            paragraph67.Append(run64);
            paragraph67.Append(endParagraphRunProperties31);

            textBody30.Append(bodyProperties32);
            textBody30.Append(listStyle32);
            textBody30.Append(paragraph67);

            shape32.Append(nonVisualShapeProperties32);
            shape32.Append(shapeProperties38);
            shape32.Append(textBody30);

            Shape shape33 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties33 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties50 = new NonVisualDrawingProperties() { Id = (UInt32Value)3U, Name = "Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties33 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks33 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties33.Append(shapeLocks33);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties50 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape26 = new PlaceholderShape() { Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties50.Append(placeholderShape26);

            nonVisualShapeProperties33.Append(nonVisualDrawingProperties50);
            nonVisualShapeProperties33.Append(nonVisualShapeDrawingProperties33);
            nonVisualShapeProperties33.Append(applicationNonVisualDrawingProperties50);

            ShapeProperties shapeProperties39 = new ShapeProperties();

            A.Transform2D transform2D34 = new A.Transform2D();
            A.Offset offset47 = new A.Offset() { X = 495300L, Y = 1535113L };
            A.Extents extents47 = new A.Extents() { Cx = 4376870L, Cy = 639762L };

            transform2D34.Append(offset47);
            transform2D34.Append(extents47);

            shapeProperties39.Append(transform2D34);

            TextBody textBody31 = new TextBody();
            A.BodyProperties bodyProperties33 = new A.BodyProperties() { Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle33 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties28 = new A.Level1ParagraphProperties() { LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet36 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties183 = new A.DefaultRunProperties() { FontSize = 2400, Bold = true };

            level1ParagraphProperties28.Append(noBullet36);
            level1ParagraphProperties28.Append(defaultRunProperties183);

            A.Level2ParagraphProperties level2ParagraphProperties17 = new A.Level2ParagraphProperties() { LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet37 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties184 = new A.DefaultRunProperties() { FontSize = 2000, Bold = true };

            level2ParagraphProperties17.Append(noBullet37);
            level2ParagraphProperties17.Append(defaultRunProperties184);

            A.Level3ParagraphProperties level3ParagraphProperties17 = new A.Level3ParagraphProperties() { LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet38 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties185 = new A.DefaultRunProperties() { FontSize = 1800, Bold = true };

            level3ParagraphProperties17.Append(noBullet38);
            level3ParagraphProperties17.Append(defaultRunProperties185);

            A.Level4ParagraphProperties level4ParagraphProperties17 = new A.Level4ParagraphProperties() { LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet39 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties186 = new A.DefaultRunProperties() { FontSize = 1600, Bold = true };

            level4ParagraphProperties17.Append(noBullet39);
            level4ParagraphProperties17.Append(defaultRunProperties186);

            A.Level5ParagraphProperties level5ParagraphProperties17 = new A.Level5ParagraphProperties() { LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet40 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties187 = new A.DefaultRunProperties() { FontSize = 1600, Bold = true };

            level5ParagraphProperties17.Append(noBullet40);
            level5ParagraphProperties17.Append(defaultRunProperties187);

            A.Level6ParagraphProperties level6ParagraphProperties17 = new A.Level6ParagraphProperties() { LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet41 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties188 = new A.DefaultRunProperties() { FontSize = 1600, Bold = true };

            level6ParagraphProperties17.Append(noBullet41);
            level6ParagraphProperties17.Append(defaultRunProperties188);

            A.Level7ParagraphProperties level7ParagraphProperties17 = new A.Level7ParagraphProperties() { LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet42 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties189 = new A.DefaultRunProperties() { FontSize = 1600, Bold = true };

            level7ParagraphProperties17.Append(noBullet42);
            level7ParagraphProperties17.Append(defaultRunProperties189);

            A.Level8ParagraphProperties level8ParagraphProperties17 = new A.Level8ParagraphProperties() { LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet43 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties190 = new A.DefaultRunProperties() { FontSize = 1600, Bold = true };

            level8ParagraphProperties17.Append(noBullet43);
            level8ParagraphProperties17.Append(defaultRunProperties190);

            A.Level9ParagraphProperties level9ParagraphProperties17 = new A.Level9ParagraphProperties() { LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet44 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties191 = new A.DefaultRunProperties() { FontSize = 1600, Bold = true };

            level9ParagraphProperties17.Append(noBullet44);
            level9ParagraphProperties17.Append(defaultRunProperties191);

            listStyle33.Append(level1ParagraphProperties28);
            listStyle33.Append(level2ParagraphProperties17);
            listStyle33.Append(level3ParagraphProperties17);
            listStyle33.Append(level4ParagraphProperties17);
            listStyle33.Append(level5ParagraphProperties17);
            listStyle33.Append(level6ParagraphProperties17);
            listStyle33.Append(level7ParagraphProperties17);
            listStyle33.Append(level8ParagraphProperties17);
            listStyle33.Append(level9ParagraphProperties17);

            A.Paragraph paragraph68 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties61 = new A.ParagraphProperties() { Level = 0 };

            A.Run run65 = new A.Run();
            A.RunProperties runProperties70 = new A.RunProperties() { Language = "en-US" };
            A.Text text70 = new A.Text();
            text70.Text = "Click to edit Master text styles";

            run65.Append(runProperties70);
            run65.Append(text70);

            paragraph68.Append(paragraphProperties61);
            paragraph68.Append(run65);

            textBody31.Append(bodyProperties33);
            textBody31.Append(listStyle33);
            textBody31.Append(paragraph68);

            shape33.Append(nonVisualShapeProperties33);
            shape33.Append(shapeProperties39);
            shape33.Append(textBody31);

            Shape shape34 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties34 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties51 = new NonVisualDrawingProperties() { Id = (UInt32Value)4U, Name = "Content Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties34 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks34 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties34.Append(shapeLocks34);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties51 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape27 = new PlaceholderShape() { Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties51.Append(placeholderShape27);

            nonVisualShapeProperties34.Append(nonVisualDrawingProperties51);
            nonVisualShapeProperties34.Append(nonVisualShapeDrawingProperties34);
            nonVisualShapeProperties34.Append(applicationNonVisualDrawingProperties51);

            ShapeProperties shapeProperties40 = new ShapeProperties();

            A.Transform2D transform2D35 = new A.Transform2D();
            A.Offset offset48 = new A.Offset() { X = 495300L, Y = 2174875L };
            A.Extents extents48 = new A.Extents() { Cx = 4376870L, Cy = 3951288L };

            transform2D35.Append(offset48);
            transform2D35.Append(extents48);

            shapeProperties40.Append(transform2D35);

            TextBody textBody32 = new TextBody();
            A.BodyProperties bodyProperties34 = new A.BodyProperties();

            A.ListStyle listStyle34 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties29 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties192 = new A.DefaultRunProperties() { FontSize = 2400 };

            level1ParagraphProperties29.Append(defaultRunProperties192);

            A.Level2ParagraphProperties level2ParagraphProperties18 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties193 = new A.DefaultRunProperties() { FontSize = 2000 };

            level2ParagraphProperties18.Append(defaultRunProperties193);

            A.Level3ParagraphProperties level3ParagraphProperties18 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties194 = new A.DefaultRunProperties() { FontSize = 1800 };

            level3ParagraphProperties18.Append(defaultRunProperties194);

            A.Level4ParagraphProperties level4ParagraphProperties18 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties195 = new A.DefaultRunProperties() { FontSize = 1600 };

            level4ParagraphProperties18.Append(defaultRunProperties195);

            A.Level5ParagraphProperties level5ParagraphProperties18 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties196 = new A.DefaultRunProperties() { FontSize = 1600 };

            level5ParagraphProperties18.Append(defaultRunProperties196);

            A.Level6ParagraphProperties level6ParagraphProperties18 = new A.Level6ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties197 = new A.DefaultRunProperties() { FontSize = 1600 };

            level6ParagraphProperties18.Append(defaultRunProperties197);

            A.Level7ParagraphProperties level7ParagraphProperties18 = new A.Level7ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties198 = new A.DefaultRunProperties() { FontSize = 1600 };

            level7ParagraphProperties18.Append(defaultRunProperties198);

            A.Level8ParagraphProperties level8ParagraphProperties18 = new A.Level8ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties199 = new A.DefaultRunProperties() { FontSize = 1600 };

            level8ParagraphProperties18.Append(defaultRunProperties199);

            A.Level9ParagraphProperties level9ParagraphProperties18 = new A.Level9ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties200 = new A.DefaultRunProperties() { FontSize = 1600 };

            level9ParagraphProperties18.Append(defaultRunProperties200);

            listStyle34.Append(level1ParagraphProperties29);
            listStyle34.Append(level2ParagraphProperties18);
            listStyle34.Append(level3ParagraphProperties18);
            listStyle34.Append(level4ParagraphProperties18);
            listStyle34.Append(level5ParagraphProperties18);
            listStyle34.Append(level6ParagraphProperties18);
            listStyle34.Append(level7ParagraphProperties18);
            listStyle34.Append(level8ParagraphProperties18);
            listStyle34.Append(level9ParagraphProperties18);

            A.Paragraph paragraph69 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties62 = new A.ParagraphProperties() { Level = 0 };

            A.Run run66 = new A.Run();
            A.RunProperties runProperties71 = new A.RunProperties() { Language = "en-US" };
            A.Text text71 = new A.Text();
            text71.Text = "Click to edit Master text styles";

            run66.Append(runProperties71);
            run66.Append(text71);

            paragraph69.Append(paragraphProperties62);
            paragraph69.Append(run66);

            A.Paragraph paragraph70 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties63 = new A.ParagraphProperties() { Level = 1 };

            A.Run run67 = new A.Run();
            A.RunProperties runProperties72 = new A.RunProperties() { Language = "en-US" };
            A.Text text72 = new A.Text();
            text72.Text = "Second level";

            run67.Append(runProperties72);
            run67.Append(text72);

            paragraph70.Append(paragraphProperties63);
            paragraph70.Append(run67);

            A.Paragraph paragraph71 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties64 = new A.ParagraphProperties() { Level = 2 };

            A.Run run68 = new A.Run();
            A.RunProperties runProperties73 = new A.RunProperties() { Language = "en-US" };
            A.Text text73 = new A.Text();
            text73.Text = "Third level";

            run68.Append(runProperties73);
            run68.Append(text73);

            paragraph71.Append(paragraphProperties64);
            paragraph71.Append(run68);

            A.Paragraph paragraph72 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties65 = new A.ParagraphProperties() { Level = 3 };

            A.Run run69 = new A.Run();
            A.RunProperties runProperties74 = new A.RunProperties() { Language = "en-US" };
            A.Text text74 = new A.Text();
            text74.Text = "Fourth level";

            run69.Append(runProperties74);
            run69.Append(text74);

            paragraph72.Append(paragraphProperties65);
            paragraph72.Append(run69);

            A.Paragraph paragraph73 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties66 = new A.ParagraphProperties() { Level = 4 };

            A.Run run70 = new A.Run();
            A.RunProperties runProperties75 = new A.RunProperties() { Language = "en-US" };
            A.Text text75 = new A.Text();
            text75.Text = "Fifth level";

            run70.Append(runProperties75);
            run70.Append(text75);
            A.EndParagraphRunProperties endParagraphRunProperties32 = new A.EndParagraphRunProperties() { Language = "lv-LV" };

            paragraph73.Append(paragraphProperties66);
            paragraph73.Append(run70);
            paragraph73.Append(endParagraphRunProperties32);

            textBody32.Append(bodyProperties34);
            textBody32.Append(listStyle34);
            textBody32.Append(paragraph69);
            textBody32.Append(paragraph70);
            textBody32.Append(paragraph71);
            textBody32.Append(paragraph72);
            textBody32.Append(paragraph73);

            shape34.Append(nonVisualShapeProperties34);
            shape34.Append(shapeProperties40);
            shape34.Append(textBody32);

            Shape shape35 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties35 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties52 = new NonVisualDrawingProperties() { Id = (UInt32Value)5U, Name = "Text Placeholder 4" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties35 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks35 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties35.Append(shapeLocks35);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties52 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape28 = new PlaceholderShape() { Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)3U };

            applicationNonVisualDrawingProperties52.Append(placeholderShape28);

            nonVisualShapeProperties35.Append(nonVisualDrawingProperties52);
            nonVisualShapeProperties35.Append(nonVisualShapeDrawingProperties35);
            nonVisualShapeProperties35.Append(applicationNonVisualDrawingProperties52);

            ShapeProperties shapeProperties41 = new ShapeProperties();

            A.Transform2D transform2D36 = new A.Transform2D();
            A.Offset offset49 = new A.Offset() { X = 5032111L, Y = 1535113L };
            A.Extents extents49 = new A.Extents() { Cx = 4378590L, Cy = 639762L };

            transform2D36.Append(offset49);
            transform2D36.Append(extents49);

            shapeProperties41.Append(transform2D36);

            TextBody textBody33 = new TextBody();
            A.BodyProperties bodyProperties35 = new A.BodyProperties() { Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle35 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties30 = new A.Level1ParagraphProperties() { LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet45 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties201 = new A.DefaultRunProperties() { FontSize = 2400, Bold = true };

            level1ParagraphProperties30.Append(noBullet45);
            level1ParagraphProperties30.Append(defaultRunProperties201);

            A.Level2ParagraphProperties level2ParagraphProperties19 = new A.Level2ParagraphProperties() { LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet46 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties202 = new A.DefaultRunProperties() { FontSize = 2000, Bold = true };

            level2ParagraphProperties19.Append(noBullet46);
            level2ParagraphProperties19.Append(defaultRunProperties202);

            A.Level3ParagraphProperties level3ParagraphProperties19 = new A.Level3ParagraphProperties() { LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet47 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties203 = new A.DefaultRunProperties() { FontSize = 1800, Bold = true };

            level3ParagraphProperties19.Append(noBullet47);
            level3ParagraphProperties19.Append(defaultRunProperties203);

            A.Level4ParagraphProperties level4ParagraphProperties19 = new A.Level4ParagraphProperties() { LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet48 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties204 = new A.DefaultRunProperties() { FontSize = 1600, Bold = true };

            level4ParagraphProperties19.Append(noBullet48);
            level4ParagraphProperties19.Append(defaultRunProperties204);

            A.Level5ParagraphProperties level5ParagraphProperties19 = new A.Level5ParagraphProperties() { LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet49 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties205 = new A.DefaultRunProperties() { FontSize = 1600, Bold = true };

            level5ParagraphProperties19.Append(noBullet49);
            level5ParagraphProperties19.Append(defaultRunProperties205);

            A.Level6ParagraphProperties level6ParagraphProperties19 = new A.Level6ParagraphProperties() { LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet50 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties206 = new A.DefaultRunProperties() { FontSize = 1600, Bold = true };

            level6ParagraphProperties19.Append(noBullet50);
            level6ParagraphProperties19.Append(defaultRunProperties206);

            A.Level7ParagraphProperties level7ParagraphProperties19 = new A.Level7ParagraphProperties() { LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet51 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties207 = new A.DefaultRunProperties() { FontSize = 1600, Bold = true };

            level7ParagraphProperties19.Append(noBullet51);
            level7ParagraphProperties19.Append(defaultRunProperties207);

            A.Level8ParagraphProperties level8ParagraphProperties19 = new A.Level8ParagraphProperties() { LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet52 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties208 = new A.DefaultRunProperties() { FontSize = 1600, Bold = true };

            level8ParagraphProperties19.Append(noBullet52);
            level8ParagraphProperties19.Append(defaultRunProperties208);

            A.Level9ParagraphProperties level9ParagraphProperties19 = new A.Level9ParagraphProperties() { LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet53 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties209 = new A.DefaultRunProperties() { FontSize = 1600, Bold = true };

            level9ParagraphProperties19.Append(noBullet53);
            level9ParagraphProperties19.Append(defaultRunProperties209);

            listStyle35.Append(level1ParagraphProperties30);
            listStyle35.Append(level2ParagraphProperties19);
            listStyle35.Append(level3ParagraphProperties19);
            listStyle35.Append(level4ParagraphProperties19);
            listStyle35.Append(level5ParagraphProperties19);
            listStyle35.Append(level6ParagraphProperties19);
            listStyle35.Append(level7ParagraphProperties19);
            listStyle35.Append(level8ParagraphProperties19);
            listStyle35.Append(level9ParagraphProperties19);

            A.Paragraph paragraph74 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties67 = new A.ParagraphProperties() { Level = 0 };

            A.Run run71 = new A.Run();
            A.RunProperties runProperties76 = new A.RunProperties() { Language = "en-US" };
            A.Text text76 = new A.Text();
            text76.Text = "Click to edit Master text styles";

            run71.Append(runProperties76);
            run71.Append(text76);

            paragraph74.Append(paragraphProperties67);
            paragraph74.Append(run71);

            textBody33.Append(bodyProperties35);
            textBody33.Append(listStyle35);
            textBody33.Append(paragraph74);

            shape35.Append(nonVisualShapeProperties35);
            shape35.Append(shapeProperties41);
            shape35.Append(textBody33);

            Shape shape36 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties36 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties53 = new NonVisualDrawingProperties() { Id = (UInt32Value)6U, Name = "Content Placeholder 5" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties36 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks36 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties36.Append(shapeLocks36);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties53 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape29 = new PlaceholderShape() { Size = PlaceholderSizeValues.Quarter, Index = (UInt32Value)4U };

            applicationNonVisualDrawingProperties53.Append(placeholderShape29);

            nonVisualShapeProperties36.Append(nonVisualDrawingProperties53);
            nonVisualShapeProperties36.Append(nonVisualShapeDrawingProperties36);
            nonVisualShapeProperties36.Append(applicationNonVisualDrawingProperties53);

            ShapeProperties shapeProperties42 = new ShapeProperties();

            A.Transform2D transform2D37 = new A.Transform2D();
            A.Offset offset50 = new A.Offset() { X = 5032111L, Y = 2174875L };
            A.Extents extents50 = new A.Extents() { Cx = 4378590L, Cy = 3951288L };

            transform2D37.Append(offset50);
            transform2D37.Append(extents50);

            shapeProperties42.Append(transform2D37);

            TextBody textBody34 = new TextBody();
            A.BodyProperties bodyProperties36 = new A.BodyProperties();

            A.ListStyle listStyle36 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties31 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties210 = new A.DefaultRunProperties() { FontSize = 2400 };

            level1ParagraphProperties31.Append(defaultRunProperties210);

            A.Level2ParagraphProperties level2ParagraphProperties20 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties211 = new A.DefaultRunProperties() { FontSize = 2000 };

            level2ParagraphProperties20.Append(defaultRunProperties211);

            A.Level3ParagraphProperties level3ParagraphProperties20 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties212 = new A.DefaultRunProperties() { FontSize = 1800 };

            level3ParagraphProperties20.Append(defaultRunProperties212);

            A.Level4ParagraphProperties level4ParagraphProperties20 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties213 = new A.DefaultRunProperties() { FontSize = 1600 };

            level4ParagraphProperties20.Append(defaultRunProperties213);

            A.Level5ParagraphProperties level5ParagraphProperties20 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties214 = new A.DefaultRunProperties() { FontSize = 1600 };

            level5ParagraphProperties20.Append(defaultRunProperties214);

            A.Level6ParagraphProperties level6ParagraphProperties20 = new A.Level6ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties215 = new A.DefaultRunProperties() { FontSize = 1600 };

            level6ParagraphProperties20.Append(defaultRunProperties215);

            A.Level7ParagraphProperties level7ParagraphProperties20 = new A.Level7ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties216 = new A.DefaultRunProperties() { FontSize = 1600 };

            level7ParagraphProperties20.Append(defaultRunProperties216);

            A.Level8ParagraphProperties level8ParagraphProperties20 = new A.Level8ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties217 = new A.DefaultRunProperties() { FontSize = 1600 };

            level8ParagraphProperties20.Append(defaultRunProperties217);

            A.Level9ParagraphProperties level9ParagraphProperties20 = new A.Level9ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties218 = new A.DefaultRunProperties() { FontSize = 1600 };

            level9ParagraphProperties20.Append(defaultRunProperties218);

            listStyle36.Append(level1ParagraphProperties31);
            listStyle36.Append(level2ParagraphProperties20);
            listStyle36.Append(level3ParagraphProperties20);
            listStyle36.Append(level4ParagraphProperties20);
            listStyle36.Append(level5ParagraphProperties20);
            listStyle36.Append(level6ParagraphProperties20);
            listStyle36.Append(level7ParagraphProperties20);
            listStyle36.Append(level8ParagraphProperties20);
            listStyle36.Append(level9ParagraphProperties20);

            A.Paragraph paragraph75 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties68 = new A.ParagraphProperties() { Level = 0 };

            A.Run run72 = new A.Run();
            A.RunProperties runProperties77 = new A.RunProperties() { Language = "en-US" };
            A.Text text77 = new A.Text();
            text77.Text = "Click to edit Master text styles";

            run72.Append(runProperties77);
            run72.Append(text77);

            paragraph75.Append(paragraphProperties68);
            paragraph75.Append(run72);

            A.Paragraph paragraph76 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties69 = new A.ParagraphProperties() { Level = 1 };

            A.Run run73 = new A.Run();
            A.RunProperties runProperties78 = new A.RunProperties() { Language = "en-US" };
            A.Text text78 = new A.Text();
            text78.Text = "Second level";

            run73.Append(runProperties78);
            run73.Append(text78);

            paragraph76.Append(paragraphProperties69);
            paragraph76.Append(run73);

            A.Paragraph paragraph77 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties70 = new A.ParagraphProperties() { Level = 2 };

            A.Run run74 = new A.Run();
            A.RunProperties runProperties79 = new A.RunProperties() { Language = "en-US" };
            A.Text text79 = new A.Text();
            text79.Text = "Third level";

            run74.Append(runProperties79);
            run74.Append(text79);

            paragraph77.Append(paragraphProperties70);
            paragraph77.Append(run74);

            A.Paragraph paragraph78 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties71 = new A.ParagraphProperties() { Level = 3 };

            A.Run run75 = new A.Run();
            A.RunProperties runProperties80 = new A.RunProperties() { Language = "en-US" };
            A.Text text80 = new A.Text();
            text80.Text = "Fourth level";

            run75.Append(runProperties80);
            run75.Append(text80);

            paragraph78.Append(paragraphProperties71);
            paragraph78.Append(run75);

            A.Paragraph paragraph79 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties72 = new A.ParagraphProperties() { Level = 4 };

            A.Run run76 = new A.Run();
            A.RunProperties runProperties81 = new A.RunProperties() { Language = "en-US" };
            A.Text text81 = new A.Text();
            text81.Text = "Fifth level";

            run76.Append(runProperties81);
            run76.Append(text81);
            A.EndParagraphRunProperties endParagraphRunProperties33 = new A.EndParagraphRunProperties() { Language = "lv-LV" };

            paragraph79.Append(paragraphProperties72);
            paragraph79.Append(run76);
            paragraph79.Append(endParagraphRunProperties33);

            textBody34.Append(bodyProperties36);
            textBody34.Append(listStyle36);
            textBody34.Append(paragraph75);
            textBody34.Append(paragraph76);
            textBody34.Append(paragraph77);
            textBody34.Append(paragraph78);
            textBody34.Append(paragraph79);

            shape36.Append(nonVisualShapeProperties36);
            shape36.Append(shapeProperties42);
            shape36.Append(textBody34);

            shapeTree13.Append(nonVisualGroupShapeProperties13);
            shapeTree13.Append(groupShapeProperties13);
            shapeTree13.Append(shape32);
            shapeTree13.Append(shape33);
            shapeTree13.Append(shape34);
            shapeTree13.Append(shape35);
            shapeTree13.Append(shape36);

            CommonSlideDataExtensionList commonSlideDataExtensionList12 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension12 = new CommonSlideDataExtension() { Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId12 = new P14.CreationId() { Val = (UInt32Value)970016699U };
            creationId12.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension12.Append(creationId12);

            commonSlideDataExtensionList12.Append(commonSlideDataExtension12);

            commonSlideData13.Append(shapeTree13);
            commonSlideData13.Append(commonSlideDataExtensionList12);

            ColorMapOverride colorMapOverride10 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping10 = new A.MasterColorMapping();

            colorMapOverride10.Append(masterColorMapping10);

            slideLayout8.Append(commonSlideData13);
            slideLayout8.Append(colorMapOverride10);

            slideLayoutPart8.SlideLayout = slideLayout8;
        }

        public static void GenerateSlideLayoutPart7Content(SlideLayoutPart slideLayoutPart7)
        {
            SlideLayout slideLayout7 = new SlideLayout() { Type = SlideLayoutValues.VerticalTitleAndText, Preserve = true };
            slideLayout7.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout7.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout7.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData12 = new CommonSlideData() { Name = "Vertical Title and Text" };

            ShapeTree shapeTree12 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties12 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties45 = new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties12 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties45 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties12.Append(nonVisualDrawingProperties45);
            nonVisualGroupShapeProperties12.Append(nonVisualGroupShapeDrawingProperties12);
            nonVisualGroupShapeProperties12.Append(applicationNonVisualDrawingProperties45);

            GroupShapeProperties groupShapeProperties12 = new GroupShapeProperties();

            A.TransformGroup transformGroup12 = new A.TransformGroup();
            A.Offset offset42 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents42 = new A.Extents() { Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset12 = new A.ChildOffset() { X = 0L, Y = 0L };
            A.ChildExtents childExtents12 = new A.ChildExtents() { Cx = 0L, Cy = 0L };

            transformGroup12.Append(offset42);
            transformGroup12.Append(extents42);
            transformGroup12.Append(childOffset12);
            transformGroup12.Append(childExtents12);

            groupShapeProperties12.Append(transformGroup12);

            Shape shape30 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties30 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties46 = new NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = "Vertical Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties30 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks30 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties30.Append(shapeLocks30);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties46 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape23 = new PlaceholderShape() { Type = PlaceholderValues.Title, Orientation = DirectionValues.Vertical };

            applicationNonVisualDrawingProperties46.Append(placeholderShape23);

            nonVisualShapeProperties30.Append(nonVisualDrawingProperties46);
            nonVisualShapeProperties30.Append(nonVisualShapeDrawingProperties30);
            nonVisualShapeProperties30.Append(applicationNonVisualDrawingProperties46);

            ShapeProperties shapeProperties36 = new ShapeProperties();

            A.Transform2D transform2D31 = new A.Transform2D();
            A.Offset offset43 = new A.Offset() { X = 7166373L, Y = 365125L };
            A.Extents extents43 = new A.Extents() { Cx = 2196173L, Cy = 5118100L };

            transform2D31.Append(offset43);
            transform2D31.Append(extents43);

            shapeProperties36.Append(transform2D31);

            TextBody textBody28 = new TextBody();
            A.BodyProperties bodyProperties30 = new A.BodyProperties() { Vertical = A.TextVerticalValues.EastAsianVetical };
            A.ListStyle listStyle30 = new A.ListStyle();

            A.Paragraph paragraph61 = new A.Paragraph();

            A.Run run58 = new A.Run();
            A.RunProperties runProperties63 = new A.RunProperties() { Language = "en-US" };
            A.Text text63 = new A.Text();
            text63.Text = "Click to edit Master title style";

            run58.Append(runProperties63);
            run58.Append(text63);
            A.EndParagraphRunProperties endParagraphRunProperties29 = new A.EndParagraphRunProperties() { Language = "lv-LV" };

            paragraph61.Append(run58);
            paragraph61.Append(endParagraphRunProperties29);

            textBody28.Append(bodyProperties30);
            textBody28.Append(listStyle30);
            textBody28.Append(paragraph61);

            shape30.Append(nonVisualShapeProperties30);
            shape30.Append(shapeProperties36);
            shape30.Append(textBody28);

            Shape shape31 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties31 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties47 = new NonVisualDrawingProperties() { Id = (UInt32Value)3U, Name = "Vertical Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties31 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks31 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties31.Append(shapeLocks31);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties47 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape24 = new PlaceholderShape() { Type = PlaceholderValues.Body, Orientation = DirectionValues.Vertical, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties47.Append(placeholderShape24);

            nonVisualShapeProperties31.Append(nonVisualDrawingProperties47);
            nonVisualShapeProperties31.Append(nonVisualShapeDrawingProperties31);
            nonVisualShapeProperties31.Append(applicationNonVisualDrawingProperties47);

            ShapeProperties shapeProperties37 = new ShapeProperties();

            A.Transform2D transform2D32 = new A.Transform2D();
            A.Offset offset44 = new A.Offset() { X = 572692L, Y = 365125L };
            A.Extents extents44 = new A.Extents() { Cx = 6428581L, Cy = 5118100L };

            transform2D32.Append(offset44);
            transform2D32.Append(extents44);

            shapeProperties37.Append(transform2D32);

            TextBody textBody29 = new TextBody();
            A.BodyProperties bodyProperties31 = new A.BodyProperties() { Vertical = A.TextVerticalValues.EastAsianVetical };
            A.ListStyle listStyle31 = new A.ListStyle();

            A.Paragraph paragraph62 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties56 = new A.ParagraphProperties() { Level = 0 };

            A.Run run59 = new A.Run();
            A.RunProperties runProperties64 = new A.RunProperties() { Language = "en-US" };
            A.Text text64 = new A.Text();
            text64.Text = "Click to edit Master text styles";

            run59.Append(runProperties64);
            run59.Append(text64);

            paragraph62.Append(paragraphProperties56);
            paragraph62.Append(run59);

            A.Paragraph paragraph63 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties57 = new A.ParagraphProperties() { Level = 1 };

            A.Run run60 = new A.Run();
            A.RunProperties runProperties65 = new A.RunProperties() { Language = "en-US" };
            A.Text text65 = new A.Text();
            text65.Text = "Second level";

            run60.Append(runProperties65);
            run60.Append(text65);

            paragraph63.Append(paragraphProperties57);
            paragraph63.Append(run60);

            A.Paragraph paragraph64 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties58 = new A.ParagraphProperties() { Level = 2 };

            A.Run run61 = new A.Run();
            A.RunProperties runProperties66 = new A.RunProperties() { Language = "en-US" };
            A.Text text66 = new A.Text();
            text66.Text = "Third level";

            run61.Append(runProperties66);
            run61.Append(text66);

            paragraph64.Append(paragraphProperties58);
            paragraph64.Append(run61);

            A.Paragraph paragraph65 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties59 = new A.ParagraphProperties() { Level = 3 };

            A.Run run62 = new A.Run();
            A.RunProperties runProperties67 = new A.RunProperties() { Language = "en-US" };
            A.Text text67 = new A.Text();
            text67.Text = "Fourth level";

            run62.Append(runProperties67);
            run62.Append(text67);

            paragraph65.Append(paragraphProperties59);
            paragraph65.Append(run62);

            A.Paragraph paragraph66 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties60 = new A.ParagraphProperties() { Level = 4 };

            A.Run run63 = new A.Run();
            A.RunProperties runProperties68 = new A.RunProperties() { Language = "en-US" };
            A.Text text68 = new A.Text();
            text68.Text = "Fifth level";

            run63.Append(runProperties68);
            run63.Append(text68);
            A.EndParagraphRunProperties endParagraphRunProperties30 = new A.EndParagraphRunProperties() { Language = "lv-LV" };

            paragraph66.Append(paragraphProperties60);
            paragraph66.Append(run63);
            paragraph66.Append(endParagraphRunProperties30);

            textBody29.Append(bodyProperties31);
            textBody29.Append(listStyle31);
            textBody29.Append(paragraph62);
            textBody29.Append(paragraph63);
            textBody29.Append(paragraph64);
            textBody29.Append(paragraph65);
            textBody29.Append(paragraph66);

            shape31.Append(nonVisualShapeProperties31);
            shape31.Append(shapeProperties37);
            shape31.Append(textBody29);

            shapeTree12.Append(nonVisualGroupShapeProperties12);
            shapeTree12.Append(groupShapeProperties12);
            shapeTree12.Append(shape30);
            shapeTree12.Append(shape31);

            CommonSlideDataExtensionList commonSlideDataExtensionList11 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension11 = new CommonSlideDataExtension() { Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId11 = new P14.CreationId() { Val = (UInt32Value)961882248U };
            creationId11.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension11.Append(creationId11);

            commonSlideDataExtensionList11.Append(commonSlideDataExtension11);

            commonSlideData12.Append(shapeTree12);
            commonSlideData12.Append(commonSlideDataExtensionList11);

            ColorMapOverride colorMapOverride9 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping9 = new A.MasterColorMapping();

            colorMapOverride9.Append(masterColorMapping9);

            slideLayout7.Append(commonSlideData12);
            slideLayout7.Append(colorMapOverride9);

            slideLayoutPart7.SlideLayout = slideLayout7;
        }

        public static void GenerateSlideLayoutPart6Content(SlideLayoutPart slideLayoutPart6)
        {
            SlideLayout slideLayout6 = new SlideLayout() { Type = SlideLayoutValues.TitleOnly, Preserve = true };
            slideLayout6.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout6.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout6.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData11 = new CommonSlideData() { Name = "Title Only" };

            ShapeTree shapeTree11 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties11 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties43 = new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties11 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties43 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties11.Append(nonVisualDrawingProperties43);
            nonVisualGroupShapeProperties11.Append(nonVisualGroupShapeDrawingProperties11);
            nonVisualGroupShapeProperties11.Append(applicationNonVisualDrawingProperties43);

            GroupShapeProperties groupShapeProperties11 = new GroupShapeProperties();

            A.TransformGroup transformGroup11 = new A.TransformGroup();
            A.Offset offset41 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents41 = new A.Extents() { Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset11 = new A.ChildOffset() { X = 0L, Y = 0L };
            A.ChildExtents childExtents11 = new A.ChildExtents() { Cx = 0L, Cy = 0L };

            transformGroup11.Append(offset41);
            transformGroup11.Append(extents41);
            transformGroup11.Append(childOffset11);
            transformGroup11.Append(childExtents11);

            groupShapeProperties11.Append(transformGroup11);

            Shape shape29 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties29 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties44 = new NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties29 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks29 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties29.Append(shapeLocks29);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties44 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape22 = new PlaceholderShape() { Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties44.Append(placeholderShape22);

            nonVisualShapeProperties29.Append(nonVisualDrawingProperties44);
            nonVisualShapeProperties29.Append(nonVisualShapeDrawingProperties29);
            nonVisualShapeProperties29.Append(applicationNonVisualDrawingProperties44);
            ShapeProperties shapeProperties35 = new ShapeProperties();

            TextBody textBody27 = new TextBody();
            A.BodyProperties bodyProperties29 = new A.BodyProperties();
            A.ListStyle listStyle29 = new A.ListStyle();

            A.Paragraph paragraph60 = new A.Paragraph();

            A.Run run57 = new A.Run();
            A.RunProperties runProperties62 = new A.RunProperties() { Language = "en-US" };
            A.Text text62 = new A.Text();
            text62.Text = "Click to edit Master title style";

            run57.Append(runProperties62);
            run57.Append(text62);
            A.EndParagraphRunProperties endParagraphRunProperties28 = new A.EndParagraphRunProperties() { Language = "lv-LV" };

            paragraph60.Append(run57);
            paragraph60.Append(endParagraphRunProperties28);

            textBody27.Append(bodyProperties29);
            textBody27.Append(listStyle29);
            textBody27.Append(paragraph60);

            shape29.Append(nonVisualShapeProperties29);
            shape29.Append(shapeProperties35);
            shape29.Append(textBody27);

            shapeTree11.Append(nonVisualGroupShapeProperties11);
            shapeTree11.Append(groupShapeProperties11);
            shapeTree11.Append(shape29);

            CommonSlideDataExtensionList commonSlideDataExtensionList10 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension10 = new CommonSlideDataExtension() { Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId10 = new P14.CreationId() { Val = (UInt32Value)2745802028U };
            creationId10.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension10.Append(creationId10);

            commonSlideDataExtensionList10.Append(commonSlideDataExtension10);

            commonSlideData11.Append(shapeTree11);
            commonSlideData11.Append(commonSlideDataExtensionList10);

            ColorMapOverride colorMapOverride8 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping8 = new A.MasterColorMapping();

            colorMapOverride8.Append(masterColorMapping8);

            slideLayout6.Append(commonSlideData11);
            slideLayout6.Append(colorMapOverride8);

            slideLayoutPart6.SlideLayout = slideLayout6;
        }

        public static void GenerateSlideLayoutPart5Content(SlideLayoutPart slideLayoutPart5)
        {
            SlideLayout slideLayout5 = new SlideLayout() { ShowMasterShapes = false, Type = SlideLayoutValues.Title, Preserve = true };
            slideLayout5.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout5.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout5.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData10 = new CommonSlideData() { Name = "Title Slide" };

            ShapeTree shapeTree10 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties10 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties40 = new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties10 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties40 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties10.Append(nonVisualDrawingProperties40);
            nonVisualGroupShapeProperties10.Append(nonVisualGroupShapeDrawingProperties10);
            nonVisualGroupShapeProperties10.Append(applicationNonVisualDrawingProperties40);

            GroupShapeProperties groupShapeProperties10 = new GroupShapeProperties();

            A.TransformGroup transformGroup10 = new A.TransformGroup();
            A.Offset offset38 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents38 = new A.Extents() { Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset10 = new A.ChildOffset() { X = 0L, Y = 0L };
            A.ChildExtents childExtents10 = new A.ChildExtents() { Cx = 0L, Cy = 0L };

            transformGroup10.Append(offset38);
            transformGroup10.Append(extents38);
            transformGroup10.Append(childOffset10);
            transformGroup10.Append(childExtents10);

            groupShapeProperties10.Append(transformGroup10);

            Picture picture3 = new Picture();

            NonVisualPictureProperties nonVisualPictureProperties3 = new NonVisualPictureProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties41 = new NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = "Picture 35", Description = "half_nexus" };

            NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties3 = new NonVisualPictureDrawingProperties();
            A.PictureLocks pictureLocks3 = new A.PictureLocks() { NoChangeAspect = true, NoChangeArrowheads = true };

            nonVisualPictureDrawingProperties3.Append(pictureLocks3);
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties41 = new ApplicationNonVisualDrawingProperties() { UserDrawn = true };

            nonVisualPictureProperties3.Append(nonVisualDrawingProperties41);
            nonVisualPictureProperties3.Append(nonVisualPictureDrawingProperties3);
            nonVisualPictureProperties3.Append(applicationNonVisualDrawingProperties41);

            BlipFill blipFill3 = new BlipFill();

            A.Blip blip3 = new A.Blip() { Embed = "rId2" };

            A.BlipExtensionList blipExtensionList2 = new A.BlipExtensionList();

            A.BlipExtension blipExtension2 = new A.BlipExtension() { Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}" };

            A14.UseLocalDpi useLocalDpi2 = new A14.UseLocalDpi() { Val = false };
            useLocalDpi2.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            blipExtension2.Append(useLocalDpi2);

            blipExtensionList2.Append(blipExtension2);

            blip3.Append(blipExtensionList2);
            A.SourceRectangle sourceRectangle3 = new A.SourceRectangle();

            A.Stretch stretch3 = new A.Stretch();
            A.FillRectangle fillRectangle2 = new A.FillRectangle();

            stretch3.Append(fillRectangle2);

            blipFill3.Append(blip3);
            blipFill3.Append(sourceRectangle3);
            blipFill3.Append(stretch3);

            ShapeProperties shapeProperties33 = new ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D29 = new A.Transform2D();
            A.Offset offset39 = new A.Offset() { X = 5756275L, Y = 173038L };
            A.Extents extents39 = new A.Extents() { Cx = 3678238L, Cy = 6543675L };

            transform2D29.Append(offset39);
            transform2D29.Append(extents39);

            A.PresetGeometry presetGeometry22 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList33 = new A.AdjustValueList();

            presetGeometry22.Append(adjustValueList33);
            A.NoFill noFill30 = new A.NoFill();

            A.Outline outline41 = new A.Outline();
            A.NoFill noFill31 = new A.NoFill();

            outline41.Append(noFill31);

            A.ShapePropertiesExtensionList shapePropertiesExtensionList14 = new A.ShapePropertiesExtensionList();

            A.ShapePropertiesExtension shapePropertiesExtension20 = new A.ShapePropertiesExtension() { Uri = "{909E8E84-426E-40DD-AFC4-6F175D3DCCD1}" };

            A14.HiddenFillProperties hiddenFillProperties8 = new A14.HiddenFillProperties();
            hiddenFillProperties8.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill230 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex261 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            solidFill230.Append(rgbColorModelHex261);

            hiddenFillProperties8.Append(solidFill230);

            shapePropertiesExtension20.Append(hiddenFillProperties8);

            A.ShapePropertiesExtension shapePropertiesExtension21 = new A.ShapePropertiesExtension() { Uri = "{91240B29-F687-4F45-9708-019B960494DF}" };

            A14.HiddenLineProperties hiddenLineProperties13 = new A14.HiddenLineProperties() { Width = 9525 };
            hiddenLineProperties13.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill231 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex262 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill231.Append(rgbColorModelHex262);
            A.Miter miter22 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd21 = new A.HeadEnd();
            A.TailEnd tailEnd21 = new A.TailEnd();

            hiddenLineProperties13.Append(solidFill231);
            hiddenLineProperties13.Append(miter22);
            hiddenLineProperties13.Append(headEnd21);
            hiddenLineProperties13.Append(tailEnd21);

            shapePropertiesExtension21.Append(hiddenLineProperties13);

            shapePropertiesExtensionList14.Append(shapePropertiesExtension20);
            shapePropertiesExtensionList14.Append(shapePropertiesExtension21);

            shapeProperties33.Append(transform2D29);
            shapeProperties33.Append(presetGeometry22);
            shapeProperties33.Append(noFill30);
            shapeProperties33.Append(outline41);
            shapeProperties33.Append(shapePropertiesExtensionList14);

            picture3.Append(nonVisualPictureProperties3);
            picture3.Append(blipFill3);
            picture3.Append(shapeProperties33);

            Picture picture4 = new Picture();

            NonVisualPictureProperties nonVisualPictureProperties4 = new NonVisualPictureProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties42 = new NonVisualDrawingProperties() { Id = (UInt32Value)3U, Name = "Picture 8" };

            NonVisualPictureDrawingProperties nonVisualPictureDrawingProperties4 = new NonVisualPictureDrawingProperties();
            A.PictureLocks pictureLocks4 = new A.PictureLocks() { NoChangeAspect = true };

            nonVisualPictureDrawingProperties4.Append(pictureLocks4);
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties42 = new ApplicationNonVisualDrawingProperties() { UserDrawn = true };

            nonVisualPictureProperties4.Append(nonVisualDrawingProperties42);
            nonVisualPictureProperties4.Append(nonVisualPictureDrawingProperties4);
            nonVisualPictureProperties4.Append(applicationNonVisualDrawingProperties42);

            BlipFill blipFill4 = new BlipFill();

            A.Blip blip4 = new A.Blip() { Embed = "rId3" };

            A.BlipExtensionList blipExtensionList3 = new A.BlipExtensionList();

            A.BlipExtension blipExtension3 = new A.BlipExtension() { Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}" };

            A14.UseLocalDpi useLocalDpi3 = new A14.UseLocalDpi() { Val = false };
            useLocalDpi3.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            blipExtension3.Append(useLocalDpi3);

            blipExtensionList3.Append(blipExtension3);

            blip4.Append(blipExtensionList3);
            A.SourceRectangle sourceRectangle4 = new A.SourceRectangle();

            A.Stretch stretch4 = new A.Stretch();
            A.FillRectangle fillRectangle3 = new A.FillRectangle();

            stretch4.Append(fillRectangle3);

            blipFill4.Append(blip4);
            blipFill4.Append(sourceRectangle4);
            blipFill4.Append(stretch4);

            ShapeProperties shapeProperties34 = new ShapeProperties() { BlackWhiteMode = A.BlackWhiteModeValues.Auto };

            A.Transform2D transform2D30 = new A.Transform2D();
            A.Offset offset40 = new A.Offset() { X = 609600L, Y = 609600L };
            A.Extents extents40 = new A.Extents() { Cx = 2301875L, Cy = 1066800L };

            transform2D30.Append(offset40);
            transform2D30.Append(extents40);

            A.PresetGeometry presetGeometry23 = new A.PresetGeometry() { Preset = A.ShapeTypeValues.Rectangle };
            A.AdjustValueList adjustValueList34 = new A.AdjustValueList();

            presetGeometry23.Append(adjustValueList34);
            A.NoFill noFill32 = new A.NoFill();

            A.Outline outline42 = new A.Outline();
            A.NoFill noFill33 = new A.NoFill();

            outline42.Append(noFill33);

            A.ShapePropertiesExtensionList shapePropertiesExtensionList15 = new A.ShapePropertiesExtensionList();

            A.ShapePropertiesExtension shapePropertiesExtension22 = new A.ShapePropertiesExtension() { Uri = "{909E8E84-426E-40DD-AFC4-6F175D3DCCD1}" };

            A14.HiddenFillProperties hiddenFillProperties9 = new A14.HiddenFillProperties();
            hiddenFillProperties9.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill232 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex263 = new A.RgbColorModelHex() { Val = "FFFFFF" };

            solidFill232.Append(rgbColorModelHex263);

            hiddenFillProperties9.Append(solidFill232);

            shapePropertiesExtension22.Append(hiddenFillProperties9);

            A.ShapePropertiesExtension shapePropertiesExtension23 = new A.ShapePropertiesExtension() { Uri = "{91240B29-F687-4F45-9708-019B960494DF}" };

            A14.HiddenLineProperties hiddenLineProperties14 = new A14.HiddenLineProperties() { Width = 9525 };
            hiddenLineProperties14.AddNamespaceDeclaration("a14", "http://schemas.microsoft.com/office/drawing/2010/main");

            A.SolidFill solidFill233 = new A.SolidFill();
            A.RgbColorModelHex rgbColorModelHex264 = new A.RgbColorModelHex() { Val = "000000" };

            solidFill233.Append(rgbColorModelHex264);
            A.Miter miter23 = new A.Miter() { Limit = 800000 };
            A.HeadEnd headEnd22 = new A.HeadEnd();
            A.TailEnd tailEnd22 = new A.TailEnd();

            hiddenLineProperties14.Append(solidFill233);
            hiddenLineProperties14.Append(miter23);
            hiddenLineProperties14.Append(headEnd22);
            hiddenLineProperties14.Append(tailEnd22);

            shapePropertiesExtension23.Append(hiddenLineProperties14);

            shapePropertiesExtensionList15.Append(shapePropertiesExtension22);
            shapePropertiesExtensionList15.Append(shapePropertiesExtension23);

            shapeProperties34.Append(transform2D30);
            shapeProperties34.Append(presetGeometry23);
            shapeProperties34.Append(noFill32);
            shapeProperties34.Append(outline42);
            shapeProperties34.Append(shapePropertiesExtensionList15);

            picture4.Append(nonVisualPictureProperties4);
            picture4.Append(blipFill4);
            picture4.Append(shapeProperties34);

            shapeTree10.Append(nonVisualGroupShapeProperties10);
            shapeTree10.Append(groupShapeProperties10);
            shapeTree10.Append(picture3);
            shapeTree10.Append(picture4);

            CommonSlideDataExtensionList commonSlideDataExtensionList9 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension9 = new CommonSlideDataExtension() { Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId9 = new P14.CreationId() { Val = (UInt32Value)1124666035U };
            creationId9.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension9.Append(creationId9);

            commonSlideDataExtensionList9.Append(commonSlideDataExtension9);

            commonSlideData10.Append(shapeTree10);
            commonSlideData10.Append(commonSlideDataExtensionList9);

            ColorMapOverride colorMapOverride7 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping7 = new A.MasterColorMapping();

            colorMapOverride7.Append(masterColorMapping7);

            slideLayout5.Append(commonSlideData10);
            slideLayout5.Append(colorMapOverride7);

            slideLayoutPart5.SlideLayout = slideLayout5;
        }

        public static void GenerateSlideLayoutPart4Content(SlideLayoutPart slideLayoutPart4)
        {
            SlideLayout slideLayout4 = new SlideLayout() { Type = SlideLayoutValues.Blank, Preserve = true };
            slideLayout4.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout4.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout4.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData9 = new CommonSlideData() { Name = "Blank" };

            ShapeTree shapeTree9 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties9 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties39 = new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties9 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties39 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties9.Append(nonVisualDrawingProperties39);
            nonVisualGroupShapeProperties9.Append(nonVisualGroupShapeDrawingProperties9);
            nonVisualGroupShapeProperties9.Append(applicationNonVisualDrawingProperties39);

            GroupShapeProperties groupShapeProperties9 = new GroupShapeProperties();

            A.TransformGroup transformGroup9 = new A.TransformGroup();
            A.Offset offset37 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents37 = new A.Extents() { Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset9 = new A.ChildOffset() { X = 0L, Y = 0L };
            A.ChildExtents childExtents9 = new A.ChildExtents() { Cx = 0L, Cy = 0L };

            transformGroup9.Append(offset37);
            transformGroup9.Append(extents37);
            transformGroup9.Append(childOffset9);
            transformGroup9.Append(childExtents9);

            groupShapeProperties9.Append(transformGroup9);

            shapeTree9.Append(nonVisualGroupShapeProperties9);
            shapeTree9.Append(groupShapeProperties9);

            CommonSlideDataExtensionList commonSlideDataExtensionList8 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension8 = new CommonSlideDataExtension() { Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId8 = new P14.CreationId() { Val = (UInt32Value)3642380631U };
            creationId8.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension8.Append(creationId8);

            commonSlideDataExtensionList8.Append(commonSlideDataExtension8);

            commonSlideData9.Append(shapeTree9);
            commonSlideData9.Append(commonSlideDataExtensionList8);

            ColorMapOverride colorMapOverride6 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping6 = new A.MasterColorMapping();

            colorMapOverride6.Append(masterColorMapping6);

            slideLayout4.Append(commonSlideData9);
            slideLayout4.Append(colorMapOverride6);

            slideLayoutPart4.SlideLayout = slideLayout4;
        }

        public static void GenerateSlideLayoutPart3Content(SlideLayoutPart slideLayoutPart3)
        {
            SlideLayout slideLayout3 = new SlideLayout() { Type = SlideLayoutValues.SectionHeader, Preserve = true };
            slideLayout3.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout3.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout3.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData8 = new CommonSlideData() { Name = "Section Header" };

            ShapeTree shapeTree8 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties8 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties36 = new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties8 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties36 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties8.Append(nonVisualDrawingProperties36);
            nonVisualGroupShapeProperties8.Append(nonVisualGroupShapeDrawingProperties8);
            nonVisualGroupShapeProperties8.Append(applicationNonVisualDrawingProperties36);

            GroupShapeProperties groupShapeProperties8 = new GroupShapeProperties();

            A.TransformGroup transformGroup8 = new A.TransformGroup();
            A.Offset offset34 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents34 = new A.Extents() { Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset8 = new A.ChildOffset() { X = 0L, Y = 0L };
            A.ChildExtents childExtents8 = new A.ChildExtents() { Cx = 0L, Cy = 0L };

            transformGroup8.Append(offset34);
            transformGroup8.Append(extents34);
            transformGroup8.Append(childOffset8);
            transformGroup8.Append(childExtents8);

            groupShapeProperties8.Append(transformGroup8);

            Shape shape27 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties27 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties37 = new NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties27 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks27 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties27.Append(shapeLocks27);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties37 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape20 = new PlaceholderShape() { Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties37.Append(placeholderShape20);

            nonVisualShapeProperties27.Append(nonVisualDrawingProperties37);
            nonVisualShapeProperties27.Append(nonVisualShapeDrawingProperties27);
            nonVisualShapeProperties27.Append(applicationNonVisualDrawingProperties37);

            ShapeProperties shapeProperties31 = new ShapeProperties();

            A.Transform2D transform2D27 = new A.Transform2D();
            A.Offset offset35 = new A.Offset() { X = 782506L, Y = 4406901L };
            A.Extents extents35 = new A.Extents() { Cx = 8420100L, Cy = 1362075L };

            transform2D27.Append(offset35);
            transform2D27.Append(extents35);

            shapeProperties31.Append(transform2D27);

            TextBody textBody25 = new TextBody();
            A.BodyProperties bodyProperties27 = new A.BodyProperties();

            A.ListStyle listStyle27 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties25 = new A.Level1ParagraphProperties() { Alignment = A.TextAlignmentTypeValues.Left };

            A.DefaultRunProperties defaultRunProperties172 = new A.DefaultRunProperties() { FontSize = 4000, Bold = true, Capital = A.TextCapsValues.All };
            A.LatinFont latinFont170 = new A.LatinFont() { Typeface = "DaxPro-Medium", PitchFamily = 50, CharacterSet = -70 };

            defaultRunProperties172.Append(latinFont170);

            level1ParagraphProperties25.Append(defaultRunProperties172);

            listStyle27.Append(level1ParagraphProperties25);

            A.Paragraph paragraph58 = new A.Paragraph();

            A.Run run55 = new A.Run();
            A.RunProperties runProperties60 = new A.RunProperties() { Language = "en-US", Dirty = false };
            A.Text text60 = new A.Text();
            text60.Text = "Click to edit Master title style";

            run55.Append(runProperties60);
            run55.Append(text60);
            A.EndParagraphRunProperties endParagraphRunProperties27 = new A.EndParagraphRunProperties() { Language = "lv-LV", Dirty = false };

            paragraph58.Append(run55);
            paragraph58.Append(endParagraphRunProperties27);

            textBody25.Append(bodyProperties27);
            textBody25.Append(listStyle27);
            textBody25.Append(paragraph58);

            shape27.Append(nonVisualShapeProperties27);
            shape27.Append(shapeProperties31);
            shape27.Append(textBody25);

            Shape shape28 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties28 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties38 = new NonVisualDrawingProperties() { Id = (UInt32Value)3U, Name = "Text Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties28 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks28 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties28.Append(shapeLocks28);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties38 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape21 = new PlaceholderShape() { Type = PlaceholderValues.Body, Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties38.Append(placeholderShape21);

            nonVisualShapeProperties28.Append(nonVisualDrawingProperties38);
            nonVisualShapeProperties28.Append(nonVisualShapeDrawingProperties28);
            nonVisualShapeProperties28.Append(applicationNonVisualDrawingProperties38);

            ShapeProperties shapeProperties32 = new ShapeProperties();

            A.Transform2D transform2D28 = new A.Transform2D();
            A.Offset offset36 = new A.Offset() { X = 782506L, Y = 2906713L };
            A.Extents extents36 = new A.Extents() { Cx = 8420100L, Cy = 1500187L };

            transform2D28.Append(offset36);
            transform2D28.Append(extents36);

            shapeProperties32.Append(transform2D28);

            TextBody textBody26 = new TextBody();
            A.BodyProperties bodyProperties28 = new A.BodyProperties() { Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle28 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties26 = new A.Level1ParagraphProperties() { LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet27 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties173 = new A.DefaultRunProperties() { FontSize = 2000 };

            level1ParagraphProperties26.Append(noBullet27);
            level1ParagraphProperties26.Append(defaultRunProperties173);

            A.Level2ParagraphProperties level2ParagraphProperties16 = new A.Level2ParagraphProperties() { LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet28 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties174 = new A.DefaultRunProperties() { FontSize = 1800 };

            level2ParagraphProperties16.Append(noBullet28);
            level2ParagraphProperties16.Append(defaultRunProperties174);

            A.Level3ParagraphProperties level3ParagraphProperties16 = new A.Level3ParagraphProperties() { LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet29 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties175 = new A.DefaultRunProperties() { FontSize = 1600 };

            level3ParagraphProperties16.Append(noBullet29);
            level3ParagraphProperties16.Append(defaultRunProperties175);

            A.Level4ParagraphProperties level4ParagraphProperties16 = new A.Level4ParagraphProperties() { LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet30 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties176 = new A.DefaultRunProperties() { FontSize = 1400 };

            level4ParagraphProperties16.Append(noBullet30);
            level4ParagraphProperties16.Append(defaultRunProperties176);

            A.Level5ParagraphProperties level5ParagraphProperties16 = new A.Level5ParagraphProperties() { LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet31 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties177 = new A.DefaultRunProperties() { FontSize = 1400 };

            level5ParagraphProperties16.Append(noBullet31);
            level5ParagraphProperties16.Append(defaultRunProperties177);

            A.Level6ParagraphProperties level6ParagraphProperties16 = new A.Level6ParagraphProperties() { LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet32 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties178 = new A.DefaultRunProperties() { FontSize = 1400 };

            level6ParagraphProperties16.Append(noBullet32);
            level6ParagraphProperties16.Append(defaultRunProperties178);

            A.Level7ParagraphProperties level7ParagraphProperties16 = new A.Level7ParagraphProperties() { LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet33 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties179 = new A.DefaultRunProperties() { FontSize = 1400 };

            level7ParagraphProperties16.Append(noBullet33);
            level7ParagraphProperties16.Append(defaultRunProperties179);

            A.Level8ParagraphProperties level8ParagraphProperties16 = new A.Level8ParagraphProperties() { LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet34 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties180 = new A.DefaultRunProperties() { FontSize = 1400 };

            level8ParagraphProperties16.Append(noBullet34);
            level8ParagraphProperties16.Append(defaultRunProperties180);

            A.Level9ParagraphProperties level9ParagraphProperties16 = new A.Level9ParagraphProperties() { LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet35 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties181 = new A.DefaultRunProperties() { FontSize = 1400 };

            level9ParagraphProperties16.Append(noBullet35);
            level9ParagraphProperties16.Append(defaultRunProperties181);

            listStyle28.Append(level1ParagraphProperties26);
            listStyle28.Append(level2ParagraphProperties16);
            listStyle28.Append(level3ParagraphProperties16);
            listStyle28.Append(level4ParagraphProperties16);
            listStyle28.Append(level5ParagraphProperties16);
            listStyle28.Append(level6ParagraphProperties16);
            listStyle28.Append(level7ParagraphProperties16);
            listStyle28.Append(level8ParagraphProperties16);
            listStyle28.Append(level9ParagraphProperties16);

            A.Paragraph paragraph59 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties55 = new A.ParagraphProperties() { Level = 0 };

            A.Run run56 = new A.Run();
            A.RunProperties runProperties61 = new A.RunProperties() { Language = "en-US", Dirty = false };
            A.Text text61 = new A.Text();
            text61.Text = "Click to edit Master text styles";

            run56.Append(runProperties61);
            run56.Append(text61);

            paragraph59.Append(paragraphProperties55);
            paragraph59.Append(run56);

            textBody26.Append(bodyProperties28);
            textBody26.Append(listStyle28);
            textBody26.Append(paragraph59);

            shape28.Append(nonVisualShapeProperties28);
            shape28.Append(shapeProperties32);
            shape28.Append(textBody26);

            shapeTree8.Append(nonVisualGroupShapeProperties8);
            shapeTree8.Append(groupShapeProperties8);
            shapeTree8.Append(shape27);
            shapeTree8.Append(shape28);

            CommonSlideDataExtensionList commonSlideDataExtensionList7 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension7 = new CommonSlideDataExtension() { Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId7 = new P14.CreationId() { Val = (UInt32Value)4019828715U };
            creationId7.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension7.Append(creationId7);

            commonSlideDataExtensionList7.Append(commonSlideDataExtension7);

            commonSlideData8.Append(shapeTree8);
            commonSlideData8.Append(commonSlideDataExtensionList7);

            ColorMapOverride colorMapOverride5 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping5 = new A.MasterColorMapping();

            colorMapOverride5.Append(masterColorMapping5);

            slideLayout3.Append(commonSlideData8);
            slideLayout3.Append(colorMapOverride5);

            slideLayoutPart3.SlideLayout = slideLayout3;
        }

        public static void GenerateSlideLayoutPart2Content(SlideLayoutPart slideLayoutPart2)
        {
            SlideLayout slideLayout2 = new SlideLayout() { Type = SlideLayoutValues.ObjectText, Preserve = true };
            slideLayout2.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout2.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout2.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData7 = new CommonSlideData() { Name = "Content with Caption" };

            ShapeTree shapeTree7 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties7 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties32 = new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties7 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties32 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties7.Append(nonVisualDrawingProperties32);
            nonVisualGroupShapeProperties7.Append(nonVisualGroupShapeDrawingProperties7);
            nonVisualGroupShapeProperties7.Append(applicationNonVisualDrawingProperties32);

            GroupShapeProperties groupShapeProperties7 = new GroupShapeProperties();

            A.TransformGroup transformGroup7 = new A.TransformGroup();
            A.Offset offset30 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents30 = new A.Extents() { Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset7 = new A.ChildOffset() { X = 0L, Y = 0L };
            A.ChildExtents childExtents7 = new A.ChildExtents() { Cx = 0L, Cy = 0L };

            transformGroup7.Append(offset30);
            transformGroup7.Append(extents30);
            transformGroup7.Append(childOffset7);
            transformGroup7.Append(childExtents7);

            groupShapeProperties7.Append(transformGroup7);

            Shape shape24 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties24 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties33 = new NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties24 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks24 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties24.Append(shapeLocks24);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties33 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape17 = new PlaceholderShape() { Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties33.Append(placeholderShape17);

            nonVisualShapeProperties24.Append(nonVisualDrawingProperties33);
            nonVisualShapeProperties24.Append(nonVisualShapeDrawingProperties24);
            nonVisualShapeProperties24.Append(applicationNonVisualDrawingProperties33);

            ShapeProperties shapeProperties28 = new ShapeProperties();

            A.Transform2D transform2D24 = new A.Transform2D();
            A.Offset offset31 = new A.Offset() { X = 495300L, Y = 273050L };
            A.Extents extents31 = new A.Extents() { Cx = 3259006L, Cy = 1162050L };

            transform2D24.Append(offset31);
            transform2D24.Append(extents31);

            shapeProperties28.Append(transform2D24);

            TextBody textBody22 = new TextBody();
            A.BodyProperties bodyProperties24 = new A.BodyProperties() { Anchor = A.TextAnchoringTypeValues.Bottom };

            A.ListStyle listStyle24 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties22 = new A.Level1ParagraphProperties() { Alignment = A.TextAlignmentTypeValues.Left };
            A.DefaultRunProperties defaultRunProperties153 = new A.DefaultRunProperties() { FontSize = 2000, Bold = true };

            level1ParagraphProperties22.Append(defaultRunProperties153);

            listStyle24.Append(level1ParagraphProperties22);

            A.Paragraph paragraph51 = new A.Paragraph();

            A.Run run48 = new A.Run();
            A.RunProperties runProperties53 = new A.RunProperties() { Language = "en-US" };
            A.Text text53 = new A.Text();
            text53.Text = "Click to edit Master title style";

            run48.Append(runProperties53);
            run48.Append(text53);
            A.EndParagraphRunProperties endParagraphRunProperties25 = new A.EndParagraphRunProperties() { Language = "lv-LV" };

            paragraph51.Append(run48);
            paragraph51.Append(endParagraphRunProperties25);

            textBody22.Append(bodyProperties24);
            textBody22.Append(listStyle24);
            textBody22.Append(paragraph51);

            shape24.Append(nonVisualShapeProperties24);
            shape24.Append(shapeProperties28);
            shape24.Append(textBody22);

            Shape shape25 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties25 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties34 = new NonVisualDrawingProperties() { Id = (UInt32Value)3U, Name = "Content Placeholder 2" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties25 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks25 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties25.Append(shapeLocks25);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties34 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape18 = new PlaceholderShape() { Index = (UInt32Value)1U };

            applicationNonVisualDrawingProperties34.Append(placeholderShape18);

            nonVisualShapeProperties25.Append(nonVisualDrawingProperties34);
            nonVisualShapeProperties25.Append(nonVisualShapeDrawingProperties25);
            nonVisualShapeProperties25.Append(applicationNonVisualDrawingProperties34);

            ShapeProperties shapeProperties29 = new ShapeProperties();

            A.Transform2D transform2D25 = new A.Transform2D();
            A.Offset offset32 = new A.Offset() { X = 3872971L, Y = 273051L };
            A.Extents extents32 = new A.Extents() { Cx = 5537729L, Cy = 5853113L };

            transform2D25.Append(offset32);
            transform2D25.Append(extents32);

            shapeProperties29.Append(transform2D25);

            TextBody textBody23 = new TextBody();
            A.BodyProperties bodyProperties25 = new A.BodyProperties();

            A.ListStyle listStyle25 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties23 = new A.Level1ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties154 = new A.DefaultRunProperties() { FontSize = 3200 };

            level1ParagraphProperties23.Append(defaultRunProperties154);

            A.Level2ParagraphProperties level2ParagraphProperties14 = new A.Level2ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties155 = new A.DefaultRunProperties() { FontSize = 2800 };

            level2ParagraphProperties14.Append(defaultRunProperties155);

            A.Level3ParagraphProperties level3ParagraphProperties14 = new A.Level3ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties156 = new A.DefaultRunProperties() { FontSize = 2400 };

            level3ParagraphProperties14.Append(defaultRunProperties156);

            A.Level4ParagraphProperties level4ParagraphProperties14 = new A.Level4ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties157 = new A.DefaultRunProperties() { FontSize = 2000 };

            level4ParagraphProperties14.Append(defaultRunProperties157);

            A.Level5ParagraphProperties level5ParagraphProperties14 = new A.Level5ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties158 = new A.DefaultRunProperties() { FontSize = 2000 };

            level5ParagraphProperties14.Append(defaultRunProperties158);

            A.Level6ParagraphProperties level6ParagraphProperties14 = new A.Level6ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties159 = new A.DefaultRunProperties() { FontSize = 2000 };

            level6ParagraphProperties14.Append(defaultRunProperties159);

            A.Level7ParagraphProperties level7ParagraphProperties14 = new A.Level7ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties160 = new A.DefaultRunProperties() { FontSize = 2000 };

            level7ParagraphProperties14.Append(defaultRunProperties160);

            A.Level8ParagraphProperties level8ParagraphProperties14 = new A.Level8ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties161 = new A.DefaultRunProperties() { FontSize = 2000 };

            level8ParagraphProperties14.Append(defaultRunProperties161);

            A.Level9ParagraphProperties level9ParagraphProperties14 = new A.Level9ParagraphProperties();
            A.DefaultRunProperties defaultRunProperties162 = new A.DefaultRunProperties() { FontSize = 2000 };

            level9ParagraphProperties14.Append(defaultRunProperties162);

            listStyle25.Append(level1ParagraphProperties23);
            listStyle25.Append(level2ParagraphProperties14);
            listStyle25.Append(level3ParagraphProperties14);
            listStyle25.Append(level4ParagraphProperties14);
            listStyle25.Append(level5ParagraphProperties14);
            listStyle25.Append(level6ParagraphProperties14);
            listStyle25.Append(level7ParagraphProperties14);
            listStyle25.Append(level8ParagraphProperties14);
            listStyle25.Append(level9ParagraphProperties14);

            A.Paragraph paragraph52 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties49 = new A.ParagraphProperties() { Level = 0 };

            A.Run run49 = new A.Run();
            A.RunProperties runProperties54 = new A.RunProperties() { Language = "en-US" };
            A.Text text54 = new A.Text();
            text54.Text = "Click to edit Master text styles";

            run49.Append(runProperties54);
            run49.Append(text54);

            paragraph52.Append(paragraphProperties49);
            paragraph52.Append(run49);

            A.Paragraph paragraph53 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties50 = new A.ParagraphProperties() { Level = 1 };

            A.Run run50 = new A.Run();
            A.RunProperties runProperties55 = new A.RunProperties() { Language = "en-US" };
            A.Text text55 = new A.Text();
            text55.Text = "Second level";

            run50.Append(runProperties55);
            run50.Append(text55);

            paragraph53.Append(paragraphProperties50);
            paragraph53.Append(run50);

            A.Paragraph paragraph54 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties51 = new A.ParagraphProperties() { Level = 2 };

            A.Run run51 = new A.Run();
            A.RunProperties runProperties56 = new A.RunProperties() { Language = "en-US" };
            A.Text text56 = new A.Text();
            text56.Text = "Third level";

            run51.Append(runProperties56);
            run51.Append(text56);

            paragraph54.Append(paragraphProperties51);
            paragraph54.Append(run51);

            A.Paragraph paragraph55 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties52 = new A.ParagraphProperties() { Level = 3 };

            A.Run run52 = new A.Run();
            A.RunProperties runProperties57 = new A.RunProperties() { Language = "en-US" };
            A.Text text57 = new A.Text();
            text57.Text = "Fourth level";

            run52.Append(runProperties57);
            run52.Append(text57);

            paragraph55.Append(paragraphProperties52);
            paragraph55.Append(run52);

            A.Paragraph paragraph56 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties53 = new A.ParagraphProperties() { Level = 4 };

            A.Run run53 = new A.Run();
            A.RunProperties runProperties58 = new A.RunProperties() { Language = "en-US" };
            A.Text text58 = new A.Text();
            text58.Text = "Fifth level";

            run53.Append(runProperties58);
            run53.Append(text58);
            A.EndParagraphRunProperties endParagraphRunProperties26 = new A.EndParagraphRunProperties() { Language = "lv-LV" };

            paragraph56.Append(paragraphProperties53);
            paragraph56.Append(run53);
            paragraph56.Append(endParagraphRunProperties26);

            textBody23.Append(bodyProperties25);
            textBody23.Append(listStyle25);
            textBody23.Append(paragraph52);
            textBody23.Append(paragraph53);
            textBody23.Append(paragraph54);
            textBody23.Append(paragraph55);
            textBody23.Append(paragraph56);

            shape25.Append(nonVisualShapeProperties25);
            shape25.Append(shapeProperties29);
            shape25.Append(textBody23);

            Shape shape26 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties26 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties35 = new NonVisualDrawingProperties() { Id = (UInt32Value)4U, Name = "Text Placeholder 3" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties26 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks26 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties26.Append(shapeLocks26);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties35 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape19 = new PlaceholderShape() { Type = PlaceholderValues.Body, Size = PlaceholderSizeValues.Half, Index = (UInt32Value)2U };

            applicationNonVisualDrawingProperties35.Append(placeholderShape19);

            nonVisualShapeProperties26.Append(nonVisualDrawingProperties35);
            nonVisualShapeProperties26.Append(nonVisualShapeDrawingProperties26);
            nonVisualShapeProperties26.Append(applicationNonVisualDrawingProperties35);

            ShapeProperties shapeProperties30 = new ShapeProperties();

            A.Transform2D transform2D26 = new A.Transform2D();
            A.Offset offset33 = new A.Offset() { X = 495300L, Y = 1435101L };
            A.Extents extents33 = new A.Extents() { Cx = 3259006L, Cy = 4691063L };

            transform2D26.Append(offset33);
            transform2D26.Append(extents33);

            shapeProperties30.Append(transform2D26);

            TextBody textBody24 = new TextBody();
            A.BodyProperties bodyProperties26 = new A.BodyProperties();

            A.ListStyle listStyle26 = new A.ListStyle();

            A.Level1ParagraphProperties level1ParagraphProperties24 = new A.Level1ParagraphProperties() { LeftMargin = 0, Indent = 0 };
            A.NoBullet noBullet18 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties163 = new A.DefaultRunProperties() { FontSize = 1400 };

            level1ParagraphProperties24.Append(noBullet18);
            level1ParagraphProperties24.Append(defaultRunProperties163);

            A.Level2ParagraphProperties level2ParagraphProperties15 = new A.Level2ParagraphProperties() { LeftMargin = 457200, Indent = 0 };
            A.NoBullet noBullet19 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties164 = new A.DefaultRunProperties() { FontSize = 1200 };

            level2ParagraphProperties15.Append(noBullet19);
            level2ParagraphProperties15.Append(defaultRunProperties164);

            A.Level3ParagraphProperties level3ParagraphProperties15 = new A.Level3ParagraphProperties() { LeftMargin = 914400, Indent = 0 };
            A.NoBullet noBullet20 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties165 = new A.DefaultRunProperties() { FontSize = 1000 };

            level3ParagraphProperties15.Append(noBullet20);
            level3ParagraphProperties15.Append(defaultRunProperties165);

            A.Level4ParagraphProperties level4ParagraphProperties15 = new A.Level4ParagraphProperties() { LeftMargin = 1371600, Indent = 0 };
            A.NoBullet noBullet21 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties166 = new A.DefaultRunProperties() { FontSize = 900 };

            level4ParagraphProperties15.Append(noBullet21);
            level4ParagraphProperties15.Append(defaultRunProperties166);

            A.Level5ParagraphProperties level5ParagraphProperties15 = new A.Level5ParagraphProperties() { LeftMargin = 1828800, Indent = 0 };
            A.NoBullet noBullet22 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties167 = new A.DefaultRunProperties() { FontSize = 900 };

            level5ParagraphProperties15.Append(noBullet22);
            level5ParagraphProperties15.Append(defaultRunProperties167);

            A.Level6ParagraphProperties level6ParagraphProperties15 = new A.Level6ParagraphProperties() { LeftMargin = 2286000, Indent = 0 };
            A.NoBullet noBullet23 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties168 = new A.DefaultRunProperties() { FontSize = 900 };

            level6ParagraphProperties15.Append(noBullet23);
            level6ParagraphProperties15.Append(defaultRunProperties168);

            A.Level7ParagraphProperties level7ParagraphProperties15 = new A.Level7ParagraphProperties() { LeftMargin = 2743200, Indent = 0 };
            A.NoBullet noBullet24 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties169 = new A.DefaultRunProperties() { FontSize = 900 };

            level7ParagraphProperties15.Append(noBullet24);
            level7ParagraphProperties15.Append(defaultRunProperties169);

            A.Level8ParagraphProperties level8ParagraphProperties15 = new A.Level8ParagraphProperties() { LeftMargin = 3200400, Indent = 0 };
            A.NoBullet noBullet25 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties170 = new A.DefaultRunProperties() { FontSize = 900 };

            level8ParagraphProperties15.Append(noBullet25);
            level8ParagraphProperties15.Append(defaultRunProperties170);

            A.Level9ParagraphProperties level9ParagraphProperties15 = new A.Level9ParagraphProperties() { LeftMargin = 3657600, Indent = 0 };
            A.NoBullet noBullet26 = new A.NoBullet();
            A.DefaultRunProperties defaultRunProperties171 = new A.DefaultRunProperties() { FontSize = 900 };

            level9ParagraphProperties15.Append(noBullet26);
            level9ParagraphProperties15.Append(defaultRunProperties171);

            listStyle26.Append(level1ParagraphProperties24);
            listStyle26.Append(level2ParagraphProperties15);
            listStyle26.Append(level3ParagraphProperties15);
            listStyle26.Append(level4ParagraphProperties15);
            listStyle26.Append(level5ParagraphProperties15);
            listStyle26.Append(level6ParagraphProperties15);
            listStyle26.Append(level7ParagraphProperties15);
            listStyle26.Append(level8ParagraphProperties15);
            listStyle26.Append(level9ParagraphProperties15);

            A.Paragraph paragraph57 = new A.Paragraph();
            A.ParagraphProperties paragraphProperties54 = new A.ParagraphProperties() { Level = 0 };

            A.Run run54 = new A.Run();
            A.RunProperties runProperties59 = new A.RunProperties() { Language = "en-US" };
            A.Text text59 = new A.Text();
            text59.Text = "Click to edit Master text styles";

            run54.Append(runProperties59);
            run54.Append(text59);

            paragraph57.Append(paragraphProperties54);
            paragraph57.Append(run54);

            textBody24.Append(bodyProperties26);
            textBody24.Append(listStyle26);
            textBody24.Append(paragraph57);

            shape26.Append(nonVisualShapeProperties26);
            shape26.Append(shapeProperties30);
            shape26.Append(textBody24);

            shapeTree7.Append(nonVisualGroupShapeProperties7);
            shapeTree7.Append(groupShapeProperties7);
            shapeTree7.Append(shape24);
            shapeTree7.Append(shape25);
            shapeTree7.Append(shape26);

            CommonSlideDataExtensionList commonSlideDataExtensionList6 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension6 = new CommonSlideDataExtension() { Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId6 = new P14.CreationId() { Val = (UInt32Value)784282561U };
            creationId6.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension6.Append(creationId6);

            commonSlideDataExtensionList6.Append(commonSlideDataExtension6);

            commonSlideData7.Append(shapeTree7);
            commonSlideData7.Append(commonSlideDataExtensionList6);

            ColorMapOverride colorMapOverride4 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping4 = new A.MasterColorMapping();

            colorMapOverride4.Append(masterColorMapping4);

            slideLayout2.Append(commonSlideData7);
            slideLayout2.Append(colorMapOverride4);

            slideLayoutPart2.SlideLayout = slideLayout2;
        }

        public static void GenerateSlideLayoutPart1Content(SlideLayoutPart slideLayoutPart1)
        {
            SlideLayout slideLayout1 = new SlideLayout() { Preserve = true, UserDrawn = true };
            slideLayout1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            slideLayout1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            slideLayout1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            CommonSlideData commonSlideData5 = new CommonSlideData() { Name = "Title and Content" };

            ShapeTree shapeTree5 = new ShapeTree();

            NonVisualGroupShapeProperties nonVisualGroupShapeProperties5 = new NonVisualGroupShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties24 = new NonVisualDrawingProperties() { Id = (UInt32Value)1U, Name = "" };
            NonVisualGroupShapeDrawingProperties nonVisualGroupShapeDrawingProperties5 = new NonVisualGroupShapeDrawingProperties();
            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties24 = new ApplicationNonVisualDrawingProperties();

            nonVisualGroupShapeProperties5.Append(nonVisualDrawingProperties24);
            nonVisualGroupShapeProperties5.Append(nonVisualGroupShapeDrawingProperties5);
            nonVisualGroupShapeProperties5.Append(applicationNonVisualDrawingProperties24);

            GroupShapeProperties groupShapeProperties5 = new GroupShapeProperties();

            A.TransformGroup transformGroup5 = new A.TransformGroup();
            A.Offset offset23 = new A.Offset() { X = 0L, Y = 0L };
            A.Extents extents23 = new A.Extents() { Cx = 0L, Cy = 0L };
            A.ChildOffset childOffset5 = new A.ChildOffset() { X = 0L, Y = 0L };
            A.ChildExtents childExtents5 = new A.ChildExtents() { Cx = 0L, Cy = 0L };

            transformGroup5.Append(offset23);
            transformGroup5.Append(extents23);
            transformGroup5.Append(childOffset5);
            transformGroup5.Append(childExtents5);

            groupShapeProperties5.Append(transformGroup5);

            Shape shape19 = new Shape();

            NonVisualShapeProperties nonVisualShapeProperties19 = new NonVisualShapeProperties();
            NonVisualDrawingProperties nonVisualDrawingProperties25 = new NonVisualDrawingProperties() { Id = (UInt32Value)2U, Name = "Title 1" };

            NonVisualShapeDrawingProperties nonVisualShapeDrawingProperties19 = new NonVisualShapeDrawingProperties();
            A.ShapeLocks shapeLocks19 = new A.ShapeLocks() { NoGrouping = true };

            nonVisualShapeDrawingProperties19.Append(shapeLocks19);

            ApplicationNonVisualDrawingProperties applicationNonVisualDrawingProperties25 = new ApplicationNonVisualDrawingProperties();
            PlaceholderShape placeholderShape14 = new PlaceholderShape() { Type = PlaceholderValues.Title };

            applicationNonVisualDrawingProperties25.Append(placeholderShape14);

            nonVisualShapeProperties19.Append(nonVisualDrawingProperties25);
            nonVisualShapeProperties19.Append(nonVisualShapeDrawingProperties19);
            nonVisualShapeProperties19.Append(applicationNonVisualDrawingProperties25);
            ShapeProperties shapeProperties22 = new ShapeProperties();

            TextBody textBody17 = new TextBody();
            A.BodyProperties bodyProperties19 = new A.BodyProperties();
            A.ListStyle listStyle19 = new A.ListStyle();

            A.Paragraph paragraph42 = new A.Paragraph();

            A.Run run38 = new A.Run();
            A.RunProperties runProperties42 = new A.RunProperties() { Language = "en-US" };
            A.Text text42 = new A.Text();
            text42.Text = "Click to edit Master title style";

            run38.Append(runProperties42);
            run38.Append(text42);
            A.EndParagraphRunProperties endParagraphRunProperties23 = new A.EndParagraphRunProperties() { Language = "lv-LV" };

            paragraph42.Append(run38);
            paragraph42.Append(endParagraphRunProperties23);

            textBody17.Append(bodyProperties19);
            textBody17.Append(listStyle19);
            textBody17.Append(paragraph42);

            shape19.Append(nonVisualShapeProperties19);
            shape19.Append(shapeProperties22);
            shape19.Append(textBody17);

            shapeTree5.Append(nonVisualGroupShapeProperties5);
            shapeTree5.Append(groupShapeProperties5);
            shapeTree5.Append(shape19);

            CommonSlideDataExtensionList commonSlideDataExtensionList5 = new CommonSlideDataExtensionList();

            CommonSlideDataExtension commonSlideDataExtension5 = new CommonSlideDataExtension() { Uri = "{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}" };

            P14.CreationId creationId5 = new P14.CreationId() { Val = (UInt32Value)735272394U };
            creationId5.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            commonSlideDataExtension5.Append(creationId5);

            commonSlideDataExtensionList5.Append(commonSlideDataExtension5);

            commonSlideData5.Append(shapeTree5);
            commonSlideData5.Append(commonSlideDataExtensionList5);

            ColorMapOverride colorMapOverride3 = new ColorMapOverride();
            A.MasterColorMapping masterColorMapping3 = new A.MasterColorMapping();

            colorMapOverride3.Append(masterColorMapping3);

            slideLayout1.Append(commonSlideData5);
            slideLayout1.Append(colorMapOverride3);

            slideLayoutPart1.SlideLayout = slideLayout1;
        }

    }
}
