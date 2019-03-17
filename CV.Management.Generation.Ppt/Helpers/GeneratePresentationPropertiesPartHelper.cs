using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Presentation;
using A = DocumentFormat.OpenXml.Drawing;
using P15 = DocumentFormat.OpenXml.Office2013.PowerPoint;
using P14 = DocumentFormat.OpenXml.Office2010.PowerPoint;

namespace CV.Management.Generation.Ppt.Helpers
{
    public static class GeneratePresentationPropertiesPartHelper
    {
        public static void GeneratePresentationPropertiesPart1Content(PresentationPropertiesPart presentationPropertiesPart1)
        {
            PresentationProperties presentationProperties1 = new PresentationProperties();
            presentationProperties1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            presentationProperties1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            presentationProperties1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");

            ShowProperties showProperties1 = new ShowProperties() { ShowNarration = true };
            PresenterSlideMode presenterSlideMode1 = new PresenterSlideMode();
            SlideAll slideAll1 = new SlideAll();

            PenColor penColor1 = new PenColor();
            A.PresetColor presetColor6 = new A.PresetColor() { Val = A.PresetColorValues.Red };

            penColor1.Append(presetColor6);

            ShowPropertiesExtensionList showPropertiesExtensionList1 = new ShowPropertiesExtensionList();

            ShowPropertiesExtension showPropertiesExtension1 = new ShowPropertiesExtension() { Uri = "{EC167BDD-8182-4AB7-AECC-EB403E3ABB37}" };

            P14.LaserColor laserColor1 = new P14.LaserColor();
            laserColor1.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");
            A.RgbColorModelHex rgbColorModelHex265 = new A.RgbColorModelHex() { Val = "FF0000" };

            laserColor1.Append(rgbColorModelHex265);

            showPropertiesExtension1.Append(laserColor1);

            ShowPropertiesExtension showPropertiesExtension2 = new ShowPropertiesExtension() { Uri = "{2FDB2607-1784-4EEB-B798-7EB5836EED8A}" };

            P14.ShowMediaControls showMediaControls1 = new P14.ShowMediaControls() { Val = true };
            showMediaControls1.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            showPropertiesExtension2.Append(showMediaControls1);

            showPropertiesExtensionList1.Append(showPropertiesExtension1);
            showPropertiesExtensionList1.Append(showPropertiesExtension2);

            showProperties1.Append(presenterSlideMode1);
            showProperties1.Append(slideAll1);
            showProperties1.Append(penColor1);
            showProperties1.Append(showPropertiesExtensionList1);

            ColorMostRecentlyUsed colorMostRecentlyUsed1 = new ColorMostRecentlyUsed();
            A.RgbColorModelHex rgbColorModelHex266 = new A.RgbColorModelHex() { Val = "F15A29" };
            A.RgbColorModelHex rgbColorModelHex267 = new A.RgbColorModelHex() { Val = "9E1F63" };
            A.RgbColorModelHex rgbColorModelHex268 = new A.RgbColorModelHex() { Val = "262261" };
            A.RgbColorModelHex rgbColorModelHex269 = new A.RgbColorModelHex() { Val = "ED1C24" };
            A.RgbColorModelHex rgbColorModelHex270 = new A.RgbColorModelHex() { Val = "91278F" };
            A.RgbColorModelHex rgbColorModelHex271 = new A.RgbColorModelHex() { Val = "29AAE2" };
            A.RgbColorModelHex rgbColorModelHex272 = new A.RgbColorModelHex() { Val = "2E3192" };
            A.RgbColorModelHex rgbColorModelHex273 = new A.RgbColorModelHex() { Val = "BF1E2D" };

            colorMostRecentlyUsed1.Append(rgbColorModelHex266);
            colorMostRecentlyUsed1.Append(rgbColorModelHex267);
            colorMostRecentlyUsed1.Append(rgbColorModelHex268);
            colorMostRecentlyUsed1.Append(rgbColorModelHex269);
            colorMostRecentlyUsed1.Append(rgbColorModelHex270);
            colorMostRecentlyUsed1.Append(rgbColorModelHex271);
            colorMostRecentlyUsed1.Append(rgbColorModelHex272);
            colorMostRecentlyUsed1.Append(rgbColorModelHex273);

            PresentationPropertiesExtensionList presentationPropertiesExtensionList1 = new PresentationPropertiesExtensionList();

            PresentationPropertiesExtension presentationPropertiesExtension1 = new PresentationPropertiesExtension() { Uri = "{E76CE94A-603C-4142-B9EB-6D1370010A27}" };

            P14.DiscardImageEditData discardImageEditData1 = new P14.DiscardImageEditData() { Val = false };
            discardImageEditData1.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            presentationPropertiesExtension1.Append(discardImageEditData1);

            PresentationPropertiesExtension presentationPropertiesExtension2 = new PresentationPropertiesExtension() { Uri = "{D31A062A-798A-4329-ABDD-BBA856620510}" };

            P14.DefaultImageDpi defaultImageDpi1 = new P14.DefaultImageDpi() { Val = (UInt32Value)220U };
            defaultImageDpi1.AddNamespaceDeclaration("p14", "http://schemas.microsoft.com/office/powerpoint/2010/main");

            presentationPropertiesExtension2.Append(defaultImageDpi1);

            PresentationPropertiesExtension presentationPropertiesExtension3 = new PresentationPropertiesExtension() { Uri = "{FD5EFAAD-0ECE-453E-9831-46B23BE46B34}" };

            P15.ChartTrackingReferenceBased chartTrackingReferenceBased1 = new P15.ChartTrackingReferenceBased() { Val = false };
            chartTrackingReferenceBased1.AddNamespaceDeclaration("p15", "http://schemas.microsoft.com/office/powerpoint/2012/main");

            presentationPropertiesExtension3.Append(chartTrackingReferenceBased1);

            presentationPropertiesExtensionList1.Append(presentationPropertiesExtension1);
            presentationPropertiesExtensionList1.Append(presentationPropertiesExtension2);
            presentationPropertiesExtensionList1.Append(presentationPropertiesExtension3);

            presentationProperties1.Append(showProperties1);
            presentationProperties1.Append(colorMostRecentlyUsed1);
            presentationProperties1.Append(presentationPropertiesExtensionList1);

            presentationPropertiesPart1.PresentationProperties = presentationProperties1;

        }
    }
}
