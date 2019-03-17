using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CV.Management.Generation.Ppt.Tests
{
    [TestClass]
    public class TestSimpleGeneration
    {
        [TestMethod]
        public void Test_FileStoring_TestRealData()
        {
            var documentManager = new PresentationDocumentManager();

            var simpleFile = GetGenerationData();

            var filePath = "E:\\Temp\\Amrop\\Generated\\PPT";
            var fileName = $"{Guid.NewGuid().ToString()}.pptx";

            documentManager.SaveDocument(simpleFile, filePath, fileName);
        }

        private static PresentationGenerationData GetGenerationData()
        {
            return new PresentationGenerationData
            {
                FullName = "Rolands Krumbergs",
                Email = "rolands.krumbergs@outlook.com",
                Phone = "+371 27164700"
            };
        }
    }
}
