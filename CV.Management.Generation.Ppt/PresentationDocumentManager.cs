using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using System.IO;
using CV.Management.Generation.Ppt.Helpers;

namespace CV.Management.Generation.Ppt
{
    public class PresentationDocumentManager
    {
        public void SaveDocument(PresentationGenerationData data, string filePath, string fileName)
        {
            using (var mem = new MemoryStream())
            {
                using (var package =
                    PresentationDocument.Create(mem, PresentationDocumentType.Presentation, true))
                {
                    CreateParts(package, data);
                }

                mem.Position = 0;

                using (var file = new FileStream($"{filePath}\\{fileName}", FileMode.CreateNew, FileAccess.Write))
                {
                    mem.CopyTo(file);
                }
            }
        }

        public byte[] GetDocument(PresentationGenerationData data)
        {
            using (var mem = new MemoryStream())
            {
                using (var package =
                    PresentationDocument.Create(mem, PresentationDocumentType.Presentation, true))
                {
                    CreateParts(package, data);
                }

                return mem.ToArray();
            }
        }

        private void CreateParts(PresentationDocument document, PresentationGenerationData data)
        {
            ExtendedFilePropertiesPart extendedFilePropertiesPart1 = document.AddNewPart<ExtendedFilePropertiesPart>("rId3");
            GenerateExtendedFilePropertiesPartHelper.GenerateExtendedFilePropertiesPart1Content(extendedFilePropertiesPart1);

            PresentationPart presentationPart1 = document.AddPresentationPart();
            GeneratePresentationPartHelper.GeneratePresentationPart1Content(presentationPart1);

            CommentAuthorsPart commentAuthorsPart1 = presentationPart1.AddNewPart<CommentAuthorsPart>("rId8");
            GenerateCommentAuthorsPartHelper.GenerateCommentAuthorsPart1Content(commentAuthorsPart1);

            CustomXmlPart customXmlPart1 = presentationPart1.AddNewPart<CustomXmlPart>("application/xml", "rId3");
            GenerateCustomXmlPartHelper.GenerateCustomXmlPart1Content(customXmlPart1);

            CustomXmlPropertiesPart customXmlPropertiesPart1 = customXmlPart1.AddNewPart<CustomXmlPropertiesPart>("rId1");
            GenerateCustomXmlPropertiesPartHelper.GenerateCustomXmlPropertiesPart1Content(customXmlPropertiesPart1);

            HandoutMasterPart handoutMasterPart1 = presentationPart1.AddNewPart<HandoutMasterPart>("rId7");
            GenerateHandoutMasterPartHelper.GenerateHandoutMasterPart1Content(handoutMasterPart1);

            ThemePart themePart1 = handoutMasterPart1.AddNewPart<ThemePart>("rId1");
            GenerateThemePartHelper.GenerateThemePart1Content(themePart1);

            TableStylesPart tableStylesPart1 = presentationPart1.AddNewPart<TableStylesPart>("rId12");
            GenerateTableStylesPartHelper.GenerateTableStylesPart1Content(tableStylesPart1);

            CustomXmlPart customXmlPart2 = presentationPart1.AddNewPart<CustomXmlPart>("application/xml", "rId2");
            GenerateCustomXmlPartHelper.GenerateCustomXmlPart2Content(customXmlPart2);

            CustomXmlPropertiesPart customXmlPropertiesPart2 = customXmlPart2.AddNewPart<CustomXmlPropertiesPart>("rId1");
            GenerateCustomXmlPropertiesPartHelper.GenerateCustomXmlPropertiesPart2Content(customXmlPropertiesPart2);

            CustomXmlPart customXmlPart3 = presentationPart1.AddNewPart<CustomXmlPart>("application/xml", "rId1");
            GenerateCustomXmlPartHelper.GenerateCustomXmlPart3Content(customXmlPart3);

            CustomXmlPropertiesPart customXmlPropertiesPart3 = customXmlPart3.AddNewPart<CustomXmlPropertiesPart>("rId1");
            GenerateCustomXmlPropertiesPartHelper.GenerateCustomXmlPropertiesPart3Content(customXmlPropertiesPart3);

            NotesMasterPart notesMasterPart1 = presentationPart1.AddNewPart<NotesMasterPart>("rId6");
            GenerateNotesMasterPartHelper.GenerateNotesMasterPart1Content(notesMasterPart1);

            ThemePart themePart2 = notesMasterPart1.AddNewPart<ThemePart>("rId1");
            GenerateThemePartHelper.GenerateThemePart2Content(themePart2);

            ThemePart themePart3 = presentationPart1.AddNewPart<ThemePart>("rId11");
            GenerateThemePartHelper.GenerateThemePart3Content(themePart3);

            SlidePart slidePart1 = presentationPart1.AddNewPart<SlidePart>("rId5");
            GenerateSlidePartHelper.GenerateSlidePart1Content(slidePart1, data);

            ImagePart imagePart1 = slidePart1.AddNewPart<ImagePart>("image/png", "rId3");
            GenerateImagePartHelper.GenerateImagePart1Content(imagePart1);

            NotesSlidePart notesSlidePart1 = slidePart1.AddNewPart<NotesSlidePart>("rId2");
            GenerateNotesSlidePartHelper.GenerateNotesSlidePart1Content(notesSlidePart1);

            notesSlidePart1.AddPart(slidePart1, "rId2");

            notesSlidePart1.AddPart(notesMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart1 = slidePart1.AddNewPart<SlideLayoutPart>("rId1");
            GenerateSlideLayoutPartHelper.GenerateSlideLayoutPart1Content(slideLayoutPart1);

            SlideMasterPart slideMasterPart1 = slideLayoutPart1.AddNewPart<SlideMasterPart>("rId1");
            GenerateSlideMasterPartHelper.GenerateSlideMasterPart1Content(slideMasterPart1);

            SlideLayoutPart slideLayoutPart2 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId8");
            GenerateSlideLayoutPartHelper.GenerateSlideLayoutPart2Content(slideLayoutPart2);

            slideLayoutPart2.AddPart(slideMasterPart1, "rId1");

            ImagePart imagePart2 = slideMasterPart1.AddNewPart<ImagePart>("image/jpeg", "rId13");
            GenerateImagePartHelper.GenerateImagePart2Content(imagePart2);

            SlideLayoutPart slideLayoutPart3 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId3");
            GenerateSlideLayoutPartHelper.GenerateSlideLayoutPart3Content(slideLayoutPart3);

            slideLayoutPart3.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart4 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId7");
            GenerateSlideLayoutPartHelper.GenerateSlideLayoutPart4Content(slideLayoutPart4);

            slideLayoutPart4.AddPart(slideMasterPart1, "rId1");

            slideMasterPart1.AddPart(themePart3, "rId12");

            slideMasterPart1.AddPart(slideLayoutPart1, "rId2");

            SlideLayoutPart slideLayoutPart5 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId1");
            GenerateSlideLayoutPartHelper.GenerateSlideLayoutPart5Content(slideLayoutPart5);

            ImagePart imagePart3 = slideLayoutPart5.AddNewPart<ImagePart>("image/jpeg", "rId3");
            GenerateImagePartHelper.GenerateImagePart3Content(imagePart3);

            ImagePart imagePart4 = slideLayoutPart5.AddNewPart<ImagePart>("image/png", "rId2");
            GenerateImagePartHelper.GenerateImagePart4Content(imagePart4);

            slideLayoutPart5.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart6 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId6");
            GenerateSlideLayoutPartHelper.GenerateSlideLayoutPart6Content(slideLayoutPart6);

            slideLayoutPart6.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart7 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId11");
            GenerateSlideLayoutPartHelper.GenerateSlideLayoutPart7Content(slideLayoutPart7);

            slideLayoutPart7.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart8 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId5");
            GenerateSlideLayoutPartHelper.GenerateSlideLayoutPart8Content(slideLayoutPart8);

            slideLayoutPart8.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart9 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId10");
            GenerateSlideLayoutPartHelper.GenerateSlideLayoutPart9Content(slideLayoutPart9);

            slideLayoutPart9.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart10 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId4");
            GenerateSlideLayoutPartHelper.GenerateSlideLayoutPart10Content(slideLayoutPart10);

            slideLayoutPart10.AddPart(slideMasterPart1, "rId1");

            SlideLayoutPart slideLayoutPart11 = slideMasterPart1.AddNewPart<SlideLayoutPart>("rId9");
            GenerateSlideLayoutPartHelper.GenerateSlideLayoutPart11Content(slideLayoutPart11);

            slideLayoutPart11.AddPart(slideMasterPart1, "rId1");

            ViewPropertiesPart viewPropertiesPart1 = presentationPart1.AddNewPart<ViewPropertiesPart>("rId10");
            GenerateViewPropertiesPartHelper.GenerateViewPropertiesPart1Content(viewPropertiesPart1);

            presentationPart1.AddPart(slideMasterPart1, "rId4");

            PresentationPropertiesPart presentationPropertiesPart1 = presentationPart1.AddNewPart<PresentationPropertiesPart>("rId9");
            GeneratePresentationPropertiesPartHelper.GeneratePresentationPropertiesPart1Content(presentationPropertiesPart1);

            CustomFilePropertiesPart customFilePropertiesPart1 = document.AddNewPart<CustomFilePropertiesPart>("rId4");
            CustomFilePropertiesPartHelper.GenerateCustomFilePropertiesPart1Content(customFilePropertiesPart1);

            SetPackageProperties(document);
        }

        private void SetPackageProperties(OpenXmlPackage document)
        {
            document.PackageProperties.Creator = "";
            document.PackageProperties.Title = "";
            document.PackageProperties.Revision = "1";
            document.PackageProperties.Created = System.Xml.XmlConvert.ToDateTime("2017-05-22T07:26:07Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.Modified = System.Xml.XmlConvert.ToDateTime("2018-12-07T15:01:42Z", System.Xml.XmlDateTimeSerializationMode.RoundtripKind);
            document.PackageProperties.LastModifiedBy = "";
        }
    }
}
