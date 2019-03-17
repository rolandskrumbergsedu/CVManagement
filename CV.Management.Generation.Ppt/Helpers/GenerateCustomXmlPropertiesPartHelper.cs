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
    public static class GenerateCustomXmlPropertiesPartHelper
    {
        public static void GenerateCustomXmlPropertiesPart1Content(CustomXmlPropertiesPart customXmlPropertiesPart1)
        {
            Ds.DataStoreItem dataStoreItem1 = new Ds.DataStoreItem() { ItemId = "{64AC9C18-D41E-498F-B0D7-25FEAA2ECF4F}" };
            dataStoreItem1.AddNamespaceDeclaration("ds", "http://schemas.openxmlformats.org/officeDocument/2006/customXml");

            Ds.SchemaReferences schemaReferences1 = new Ds.SchemaReferences();
            Ds.SchemaReference schemaReference1 = new Ds.SchemaReference() { Uri = "http://purl.org/dc/terms/" };
            Ds.SchemaReference schemaReference2 = new Ds.SchemaReference() { Uri = "4fc81810-4f98-4e7e-b20e-7b2a690091c4" };
            Ds.SchemaReference schemaReference3 = new Ds.SchemaReference() { Uri = "http://schemas.microsoft.com/office/2006/documentManagement/types" };
            Ds.SchemaReference schemaReference4 = new Ds.SchemaReference() { Uri = "http://schemas.microsoft.com/office/infopath/2007/PartnerControls" };
            Ds.SchemaReference schemaReference5 = new Ds.SchemaReference() { Uri = "http://purl.org/dc/elements/1.1/" };
            Ds.SchemaReference schemaReference6 = new Ds.SchemaReference() { Uri = "http://schemas.microsoft.com/office/2006/metadata/properties" };
            Ds.SchemaReference schemaReference7 = new Ds.SchemaReference() { Uri = "067d236f-0129-4702-b692-531fc2f871d2" };
            Ds.SchemaReference schemaReference8 = new Ds.SchemaReference() { Uri = "http://schemas.openxmlformats.org/package/2006/metadata/core-properties" };
            Ds.SchemaReference schemaReference9 = new Ds.SchemaReference() { Uri = "http://www.w3.org/XML/1998/namespace" };
            Ds.SchemaReference schemaReference10 = new Ds.SchemaReference() { Uri = "http://purl.org/dc/dcmitype/" };

            schemaReferences1.Append(schemaReference1);
            schemaReferences1.Append(schemaReference2);
            schemaReferences1.Append(schemaReference3);
            schemaReferences1.Append(schemaReference4);
            schemaReferences1.Append(schemaReference5);
            schemaReferences1.Append(schemaReference6);
            schemaReferences1.Append(schemaReference7);
            schemaReferences1.Append(schemaReference8);
            schemaReferences1.Append(schemaReference9);
            schemaReferences1.Append(schemaReference10);

            dataStoreItem1.Append(schemaReferences1);

            customXmlPropertiesPart1.DataStoreItem = dataStoreItem1;
        }

        public static void GenerateCustomXmlPropertiesPart2Content(CustomXmlPropertiesPart customXmlPropertiesPart2)
        {
            Ds.DataStoreItem dataStoreItem2 = new Ds.DataStoreItem() { ItemId = "{712D5C48-63A0-44E3-B76A-BF5D263C6E7E}" };
            dataStoreItem2.AddNamespaceDeclaration("ds", "http://schemas.openxmlformats.org/officeDocument/2006/customXml");

            Ds.SchemaReferences schemaReferences2 = new Ds.SchemaReferences();
            Ds.SchemaReference schemaReference11 = new Ds.SchemaReference() { Uri = "http://schemas.microsoft.com/office/2006/metadata/contentType" };
            Ds.SchemaReference schemaReference12 = new Ds.SchemaReference() { Uri = "http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes" };
            Ds.SchemaReference schemaReference13 = new Ds.SchemaReference() { Uri = "http://www.w3.org/2001/XMLSchema" };
            Ds.SchemaReference schemaReference14 = new Ds.SchemaReference() { Uri = "http://schemas.microsoft.com/office/2006/metadata/properties" };
            Ds.SchemaReference schemaReference15 = new Ds.SchemaReference() { Uri = "4fc81810-4f98-4e7e-b20e-7b2a690091c4" };
            Ds.SchemaReference schemaReference16 = new Ds.SchemaReference() { Uri = "067d236f-0129-4702-b692-531fc2f871d2" };
            Ds.SchemaReference schemaReference17 = new Ds.SchemaReference() { Uri = "http://schemas.microsoft.com/office/2006/documentManagement/types" };
            Ds.SchemaReference schemaReference18 = new Ds.SchemaReference() { Uri = "http://schemas.microsoft.com/office/infopath/2007/PartnerControls" };
            Ds.SchemaReference schemaReference19 = new Ds.SchemaReference() { Uri = "http://schemas.openxmlformats.org/package/2006/metadata/core-properties" };
            Ds.SchemaReference schemaReference20 = new Ds.SchemaReference() { Uri = "http://purl.org/dc/elements/1.1/" };
            Ds.SchemaReference schemaReference21 = new Ds.SchemaReference() { Uri = "http://purl.org/dc/terms/" };
            Ds.SchemaReference schemaReference22 = new Ds.SchemaReference() { Uri = "http://schemas.microsoft.com/internal/obd" };

            schemaReferences2.Append(schemaReference11);
            schemaReferences2.Append(schemaReference12);
            schemaReferences2.Append(schemaReference13);
            schemaReferences2.Append(schemaReference14);
            schemaReferences2.Append(schemaReference15);
            schemaReferences2.Append(schemaReference16);
            schemaReferences2.Append(schemaReference17);
            schemaReferences2.Append(schemaReference18);
            schemaReferences2.Append(schemaReference19);
            schemaReferences2.Append(schemaReference20);
            schemaReferences2.Append(schemaReference21);
            schemaReferences2.Append(schemaReference22);

            dataStoreItem2.Append(schemaReferences2);

            customXmlPropertiesPart2.DataStoreItem = dataStoreItem2;
        }

        public static void GenerateCustomXmlPropertiesPart3Content(CustomXmlPropertiesPart customXmlPropertiesPart3)
        {
            Ds.DataStoreItem dataStoreItem3 = new Ds.DataStoreItem() { ItemId = "{5804A2E3-5823-485C-929F-CC83322FF56F}" };
            dataStoreItem3.AddNamespaceDeclaration("ds", "http://schemas.openxmlformats.org/officeDocument/2006/customXml");

            Ds.SchemaReferences schemaReferences3 = new Ds.SchemaReferences();
            Ds.SchemaReference schemaReference23 = new Ds.SchemaReference() { Uri = "http://schemas.microsoft.com/sharepoint/v3/contenttype/forms" };

            schemaReferences3.Append(schemaReference23);

            dataStoreItem3.Append(schemaReferences3);

            customXmlPropertiesPart3.DataStoreItem = dataStoreItem3;
        }
    }
}
