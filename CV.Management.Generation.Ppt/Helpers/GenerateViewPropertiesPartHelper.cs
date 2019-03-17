using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using A = DocumentFormat.OpenXml.Drawing;

namespace CV.Management.Generation.Ppt.Helpers
{
    public static class GenerateViewPropertiesPartHelper
    {
        public static void GenerateViewPropertiesPart1Content(ViewPropertiesPart viewPropertiesPart1)
        {
            ViewProperties viewProperties1 = new ViewProperties() { LastView = ViewValues.SlideMasterView };
            viewProperties1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            viewProperties1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            viewProperties1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            NormalViewProperties normalViewProperties1 = new NormalViewProperties() { HorizontalBarState = SplitterBarStateValues.Maximized };
            RestoredLeft restoredLeft1 = new RestoredLeft() { Size = 12059, AutoAdjust = false };
            RestoredTop restoredTop1 = new RestoredTop() { Size = 90929 };

            normalViewProperties1.Append(restoredLeft1);
            normalViewProperties1.Append(restoredTop1);

            SlideViewProperties slideViewProperties1 = new SlideViewProperties();

            CommonSlideViewProperties commonSlideViewProperties1 = new CommonSlideViewProperties() { ShowGuides = true };

            CommonViewProperties commonViewProperties1 = new CommonViewProperties() { VariableScale = true };

            ScaleFactor scaleFactor1 = new ScaleFactor();
            A.ScaleX scaleX1 = new A.ScaleX() { Numerator = 115, Denominator = 100 };
            A.ScaleY scaleY1 = new A.ScaleY() { Numerator = 115, Denominator = 100 };

            scaleFactor1.Append(scaleX1);
            scaleFactor1.Append(scaleY1);
            Origin origin1 = new Origin() { X = 1422L, Y = 96L };

            commonViewProperties1.Append(scaleFactor1);
            commonViewProperties1.Append(origin1);

            GuideList guideList1 = new GuideList();
            Guide guide1 = new Guide() { Orientation = DirectionValues.Horizontal, Position = 240 };
            Guide guide2 = new Guide() { Orientation = DirectionValues.Horizontal, Position = 3648 };
            Guide guide3 = new Guide() { Position = 2736 };
            Guide guide4 = new Guide() { Position = 5904 };
            Guide guide5 = new Guide() { Position = 336 };
            Guide guide6 = new Guide() { Orientation = DirectionValues.Horizontal };
            Guide guide7 = new Guide() { Orientation = DirectionValues.Horizontal, Position = 1152 };
            Guide guide8 = new Guide() { Orientation = DirectionValues.Horizontal, Position = 1200 };
            Guide guide9 = new Guide() { Position = 2784 };
            Guide guide10 = new Guide() { Orientation = DirectionValues.Horizontal, Position = 2448 };
            Guide guide11 = new Guide() { Orientation = DirectionValues.Horizontal, Position = 2496 };
            Guide guide12 = new Guide() { Position = 1872 };
            Guide guide13 = new Guide() { Position = 2688 };
            Guide guide14 = new Guide() { Orientation = DirectionValues.Horizontal, Position = 288 };
            Guide guide15 = new Guide() { Orientation = DirectionValues.Horizontal, Position = 1104 };

            guideList1.Append(guide1);
            guideList1.Append(guide2);
            guideList1.Append(guide3);
            guideList1.Append(guide4);
            guideList1.Append(guide5);
            guideList1.Append(guide6);
            guideList1.Append(guide7);
            guideList1.Append(guide8);
            guideList1.Append(guide9);
            guideList1.Append(guide10);
            guideList1.Append(guide11);
            guideList1.Append(guide12);
            guideList1.Append(guide13);
            guideList1.Append(guide14);
            guideList1.Append(guide15);

            commonSlideViewProperties1.Append(commonViewProperties1);
            commonSlideViewProperties1.Append(guideList1);

            slideViewProperties1.Append(commonSlideViewProperties1);

            OutlineViewProperties outlineViewProperties1 = new OutlineViewProperties();

            CommonViewProperties commonViewProperties2 = new CommonViewProperties();

            ScaleFactor scaleFactor2 = new ScaleFactor();
            A.ScaleX scaleX2 = new A.ScaleX() { Numerator = 33, Denominator = 100 };
            A.ScaleY scaleY2 = new A.ScaleY() { Numerator = 33, Denominator = 100 };

            scaleFactor2.Append(scaleX2);
            scaleFactor2.Append(scaleY2);
            Origin origin2 = new Origin() { X = 0L, Y = 0L };

            commonViewProperties2.Append(scaleFactor2);
            commonViewProperties2.Append(origin2);

            outlineViewProperties1.Append(commonViewProperties2);

            NotesTextViewProperties notesTextViewProperties1 = new NotesTextViewProperties();

            CommonViewProperties commonViewProperties3 = new CommonViewProperties();

            ScaleFactor scaleFactor3 = new ScaleFactor();
            A.ScaleX scaleX3 = new A.ScaleX() { Numerator = 100, Denominator = 100 };
            A.ScaleY scaleY3 = new A.ScaleY() { Numerator = 100, Denominator = 100 };

            scaleFactor3.Append(scaleX3);
            scaleFactor3.Append(scaleY3);
            Origin origin3 = new Origin() { X = 0L, Y = 0L };

            commonViewProperties3.Append(scaleFactor3);
            commonViewProperties3.Append(origin3);

            notesTextViewProperties1.Append(commonViewProperties3);

            SorterViewProperties sorterViewProperties1 = new SorterViewProperties();

            CommonViewProperties commonViewProperties4 = new CommonViewProperties();

            ScaleFactor scaleFactor4 = new ScaleFactor();
            A.ScaleX scaleX4 = new A.ScaleX() { Numerator = 66, Denominator = 100 };
            A.ScaleY scaleY4 = new A.ScaleY() { Numerator = 66, Denominator = 100 };

            scaleFactor4.Append(scaleX4);
            scaleFactor4.Append(scaleY4);
            Origin origin4 = new Origin() { X = 0L, Y = 0L };

            commonViewProperties4.Append(scaleFactor4);
            commonViewProperties4.Append(origin4);

            sorterViewProperties1.Append(commonViewProperties4);

            NotesViewProperties notesViewProperties1 = new NotesViewProperties();

            CommonSlideViewProperties commonSlideViewProperties2 = new CommonSlideViewProperties() { ShowGuides = true };

            CommonViewProperties commonViewProperties5 = new CommonViewProperties() { VariableScale = true };

            ScaleFactor scaleFactor5 = new ScaleFactor();
            A.ScaleX scaleX5 = new A.ScaleX() { Numerator = 61, Denominator = 100 };
            A.ScaleY scaleY5 = new A.ScaleY() { Numerator = 61, Denominator = 100 };

            scaleFactor5.Append(scaleX5);
            scaleFactor5.Append(scaleY5);
            Origin origin5 = new Origin() { X = 3254L, Y = 67L };

            commonViewProperties5.Append(scaleFactor5);
            commonViewProperties5.Append(origin5);

            GuideList guideList2 = new GuideList();
            Guide guide16 = new Guide() { Orientation = DirectionValues.Horizontal, Position = 3110 };
            Guide guide17 = new Guide() { Position = 2140 };

            guideList2.Append(guide16);
            guideList2.Append(guide17);

            commonSlideViewProperties2.Append(commonViewProperties5);
            commonSlideViewProperties2.Append(guideList2);

            notesViewProperties1.Append(commonSlideViewProperties2);
            GridSpacing gridSpacing1 = new GridSpacing() { Cx = 76200L, Cy = 76200L };

            viewProperties1.Append(normalViewProperties1);
            viewProperties1.Append(slideViewProperties1);
            viewProperties1.Append(outlineViewProperties1);
            viewProperties1.Append(notesTextViewProperties1);
            viewProperties1.Append(sorterViewProperties1);
            viewProperties1.Append(notesViewProperties1);
            viewProperties1.Append(gridSpacing1);

            viewPropertiesPart1.ViewProperties = viewProperties1;

        }
    }
}
