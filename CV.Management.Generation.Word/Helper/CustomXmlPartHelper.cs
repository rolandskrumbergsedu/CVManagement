using DocumentFormat.OpenXml.Packaging;
using Ds = DocumentFormat.OpenXml.CustomXmlDataProperties;

namespace CV.Management.Generation.Word.Helpers
{
    public static class CustomXmlPartHelper
    {
        public static void GenerateCustomXmlPart1Content(CustomXmlPart customXmlPart1)
        {
            var writer = new System.Xml.XmlTextWriter(customXmlPart1.GetStream(System.IO.FileMode.Create), System.Text.Encoding.UTF8);
            writer.WriteRaw("<?xml version=\"1.0\" encoding=\"utf-8\"?><p:properties xmlns:p=\"http://schemas.microsoft.com/office/2006/metadata/properties\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:pc=\"http://schemas.microsoft.com/office/infopath/2007/PartnerControls\"><documentManagement/></p:properties>");
            writer.Flush();
            writer.Close();
        }
        public static void GenerateCustomXmlPropertiesPart1Content(CustomXmlPropertiesPart customXmlPropertiesPart1)
        {
            var dataStoreItem1 = new DocumentFormat.OpenXml.CustomXmlDataProperties.DataStoreItem() { ItemId = "{58BABFA7-2624-4FA3-9991-4F285D687B5F}" };
            dataStoreItem1.AddNamespaceDeclaration("ds", "http://schemas.openxmlformats.org/officeDocument/2006/customXml");

            var schemaReferences1 = new DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReferences();
            var schemaReference1 = new DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference() { Uri = "http://schemas.microsoft.com/office/2006/metadata/properties" };
            var schemaReference2 = new DocumentFormat.OpenXml.CustomXmlDataProperties.SchemaReference() { Uri = "http://schemas.microsoft.com/office/infopath/2007/PartnerControls" };

            schemaReferences1.Append(schemaReference1);
            schemaReferences1.Append(schemaReference2);

            dataStoreItem1.Append(schemaReferences1);

            customXmlPropertiesPart1.DataStoreItem = dataStoreItem1;
        }

        public static void GenerateCustomXmlPart2Content(CustomXmlPart customXmlPart2)
        {
            var writer = new System.Xml.XmlTextWriter(customXmlPart2.GetStream(System.IO.FileMode.Create), System.Text.Encoding.UTF8);
            writer.WriteRaw("<?xml version=\"1.0\" encoding=\"utf-8\"?><ct:contentTypeSchema ct:_=\"\" ma:_=\"\" ma:contentTypeName=\"Document\" ma:contentTypeID=\"0x0101004B3CC135CC07AD41A19C6A3D7A557156\" ma:contentTypeVersion=\"\" ma:contentTypeDescription=\"Create a new document.\" ma:contentTypeScope=\"\" ma:versionID=\"ed709af8e00f2f37000702baf4108691\" xmlns:ct=\"http://schemas.microsoft.com/office/2006/metadata/contentType\" xmlns:ma=\"http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes\">\r\n<xsd:schema targetNamespace=\"http://schemas.microsoft.com/office/2006/metadata/properties\" ma:root=\"true\" ma:fieldsID=\"6d238f72868eae9cb05cfc0c92331025\" ns2:_=\"\" ns3:_=\"\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xs=\"http://www.w3.org/2001/XMLSchema\" xmlns:p=\"http://schemas.microsoft.com/office/2006/metadata/properties\" xmlns:ns2=\"4fc81810-4f98-4e7e-b20e-7b2a690091c4\" xmlns:ns3=\"067d236f-0129-4702-b692-531fc2f871d2\">\r\n<xsd:import namespace=\"4fc81810-4f98-4e7e-b20e-7b2a690091c4\"/>\r\n<xsd:import namespace=\"067d236f-0129-4702-b692-531fc2f871d2\"/>\r\n<xsd:element name=\"properties\">\r\n<xsd:complexType>\r\n<xsd:sequence>\r\n<xsd:element name=\"documentManagement\">\r\n<xsd:complexType>\r\n<xsd:all>\r\n<xsd:element ref=\"ns2:MediaServiceMetadata\" minOccurs=\"0\"/>\r\n<xsd:element ref=\"ns2:MediaServiceFastMetadata\" minOccurs=\"0\"/>\r\n<xsd:element ref=\"ns2:MediaServiceDateTaken\" minOccurs=\"0\"/>\r\n<xsd:element ref=\"ns2:MediaServiceAutoTags\" minOccurs=\"0\"/>\r\n<xsd:element ref=\"ns2:MediaServiceOCR\" minOccurs=\"0\"/>\r\n<xsd:element ref=\"ns2:MediaServiceLocation\" minOccurs=\"0\"/>\r\n<xsd:element ref=\"ns3:SharedWithUsers\" minOccurs=\"0\"/>\r\n<xsd:element ref=\"ns3:SharedWithDetails\" minOccurs=\"0\"/>\r\n</xsd:all>\r\n</xsd:complexType>\r\n</xsd:element>\r\n</xsd:sequence>\r\n</xsd:complexType>\r\n</xsd:element>\r\n</xsd:schema>\r\n<xsd:schema targetNamespace=\"4fc81810-4f98-4e7e-b20e-7b2a690091c4\" elementFormDefault=\"qualified\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xs=\"http://www.w3.org/2001/XMLSchema\" xmlns:dms=\"http://schemas.microsoft.com/office/2006/documentManagement/types\" xmlns:pc=\"http://schemas.microsoft.com/office/infopath/2007/PartnerControls\">\r\n<xsd:import namespace=\"http://schemas.microsoft.com/office/2006/documentManagement/types\"/>\r\n<xsd:import namespace=\"http://schemas.microsoft.com/office/infopath/2007/PartnerControls\"/>\r\n<xsd:element name=\"MediaServiceMetadata\" ma:index=\"8\" nillable=\"true\" ma:displayName=\"MediaServiceMetadata\" ma:hidden=\"true\" ma:internalName=\"MediaServiceMetadata\" ma:readOnly=\"true\">\r\n<xsd:simpleType>\r\n<xsd:restriction base=\"dms:Note\"/>\r\n</xsd:simpleType>\r\n</xsd:element>\r\n<xsd:element name=\"MediaServiceFastMetadata\" ma:index=\"9\" nillable=\"true\" ma:displayName=\"MediaServiceFastMetadata\" ma:hidden=\"true\" ma:internalName=\"MediaServiceFastMetadata\" ma:readOnly=\"true\">\r\n<xsd:simpleType>\r\n<xsd:restriction base=\"dms:Note\"/>\r\n</xsd:simpleType>\r\n</xsd:element>\r\n<xsd:element name=\"MediaServiceDateTaken\" ma:index=\"10\" nillable=\"true\" ma:displayName=\"MediaServiceDateTaken\" ma:hidden=\"true\" ma:internalName=\"MediaServiceDateTaken\" ma:readOnly=\"true\">\r\n<xsd:simpleType>\r\n<xsd:restriction base=\"dms:Text\"/>\r\n</xsd:simpleType>\r\n</xsd:element>\r\n<xsd:element name=\"MediaServiceAutoTags\" ma:index=\"11\" nillable=\"true\" ma:displayName=\"Tags\" ma:internalName=\"MediaServiceAutoTags\" ma:readOnly=\"true\">\r\n<xsd:simpleType>\r\n<xsd:restriction base=\"dms:Text\"/>\r\n</xsd:simpleType>\r\n</xsd:element>\r\n<xsd:element name=\"MediaServiceOCR\" ma:index=\"12\" nillable=\"true\" ma:displayName=\"Extracted Text\" ma:internalName=\"MediaServiceOCR\" ma:readOnly=\"true\">\r\n<xsd:simpleType>\r\n<xsd:restriction base=\"dms:Note\">\r\n<xsd:maxLength value=\"255\"/>\r\n</xsd:restriction>\r\n</xsd:simpleType>\r\n</xsd:element>\r\n<xsd:element name=\"MediaServiceLocation\" ma:index=\"13\" nillable=\"true\" ma:displayName=\"Location\" ma:internalName=\"MediaServiceLocation\" ma:readOnly=\"true\">\r\n<xsd:simpleType>\r\n<xsd:restriction base=\"dms:Text\"/>\r\n</xsd:simpleType>\r\n</xsd:element>\r\n</xsd:schema>\r\n<xsd:schema targetNamespace=\"067d236f-0129-4702-b692-531fc2f871d2\" elementFormDefault=\"qualified\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xs=\"http://www.w3.org/2001/XMLSchema\" xmlns:dms=\"http://schemas.microsoft.com/office/2006/documentManagement/types\" xmlns:pc=\"http://schemas.microsoft.com/office/infopath/2007/PartnerControls\">\r\n<xsd:import namespace=\"http://schemas.microsoft.com/office/2006/documentManagement/types\"/>\r\n<xsd:import namespace=\"http://schemas.microsoft.com/office/infopath/2007/PartnerControls\"/>\r\n<xsd:element name=\"SharedWithUsers\" ma:index=\"14\" nillable=\"true\" ma:displayName=\"Shared With\" ma:internalName=\"SharedWithUsers\" ma:readOnly=\"true\">\r\n<xsd:complexType>\r\n<xsd:complexContent>\r\n<xsd:extension base=\"dms:UserMulti\">\r\n<xsd:sequence>\r\n<xsd:element name=\"UserInfo\" minOccurs=\"0\" maxOccurs=\"unbounded\">\r\n<xsd:complexType>\r\n<xsd:sequence>\r\n<xsd:element name=\"DisplayName\" type=\"xsd:string\" minOccurs=\"0\"/>\r\n<xsd:element name=\"AccountId\" type=\"dms:UserId\" minOccurs=\"0\" nillable=\"true\"/>\r\n<xsd:element name=\"AccountType\" type=\"xsd:string\" minOccurs=\"0\"/>\r\n</xsd:sequence>\r\n</xsd:complexType>\r\n</xsd:element>\r\n</xsd:sequence>\r\n</xsd:extension>\r\n</xsd:complexContent>\r\n</xsd:complexType>\r\n</xsd:element>\r\n<xsd:element name=\"SharedWithDetails\" ma:index=\"15\" nillable=\"true\" ma:displayName=\"Shared With Details\" ma:internalName=\"SharedWithDetails\" ma:readOnly=\"true\">\r\n<xsd:simpleType>\r\n<xsd:restriction base=\"dms:Note\">\r\n<xsd:maxLength value=\"255\"/>\r\n</xsd:restriction>\r\n</xsd:simpleType>\r\n</xsd:element>\r\n</xsd:schema>\r\n<xsd:schema targetNamespace=\"http://schemas.openxmlformats.org/package/2006/metadata/core-properties\" elementFormDefault=\"qualified\" attributeFormDefault=\"unqualified\" blockDefault=\"#all\" xmlns=\"http://schemas.openxmlformats.org/package/2006/metadata/core-properties\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:dcterms=\"http://purl.org/dc/terms/\" xmlns:odoc=\"http://schemas.microsoft.com/internal/obd\">\r\n<xsd:import namespace=\"http://purl.org/dc/elements/1.1/\" schemaLocation=\"http://dublincore.org/schemas/xmls/qdc/2003/04/02/dc.xsd\"/>\r\n<xsd:import namespace=\"http://purl.org/dc/terms/\" schemaLocation=\"http://dublincore.org/schemas/xmls/qdc/2003/04/02/dcterms.xsd\"/>\r\n<xsd:element name=\"coreProperties\" type=\"CT_coreProperties\"/>\r\n<xsd:complexType name=\"CT_coreProperties\">\r\n<xsd:all>\r\n<xsd:element ref=\"dc:creator\" minOccurs=\"0\" maxOccurs=\"1\"/>\r\n<xsd:element ref=\"dcterms:created\" minOccurs=\"0\" maxOccurs=\"1\"/>\r\n<xsd:element ref=\"dc:identifier\" minOccurs=\"0\" maxOccurs=\"1\"/>\r\n<xsd:element name=\"contentType\" minOccurs=\"0\" maxOccurs=\"1\" type=\"xsd:string\" ma:index=\"0\" ma:displayName=\"Content Type\"/>\r\n<xsd:element ref=\"dc:title\" minOccurs=\"0\" maxOccurs=\"1\" ma:index=\"4\" ma:displayName=\"Title\"/>\r\n<xsd:element ref=\"dc:subject\" minOccurs=\"0\" maxOccurs=\"1\"/>\r\n<xsd:element ref=\"dc:description\" minOccurs=\"0\" maxOccurs=\"1\"/>\r\n<xsd:element name=\"keywords\" minOccurs=\"0\" maxOccurs=\"1\" type=\"xsd:string\"/>\r\n<xsd:element ref=\"dc:language\" minOccurs=\"0\" maxOccurs=\"1\"/>\r\n<xsd:element name=\"category\" minOccurs=\"0\" maxOccurs=\"1\" type=\"xsd:string\"/>\r\n<xsd:element name=\"version\" minOccurs=\"0\" maxOccurs=\"1\" type=\"xsd:string\"/>\r\n<xsd:element name=\"revision\" minOccurs=\"0\" maxOccurs=\"1\" type=\"xsd:string\">\r\n<xsd:annotation>\r\n<xsd:documentation>\r\n                        This value indicates the number of saves or revisions. The application is responsible for updating this value after each revision.\r\n                    </xsd:documentation>\r\n</xsd:annotation>\r\n</xsd:element>\r\n<xsd:element name=\"lastModifiedBy\" minOccurs=\"0\" maxOccurs=\"1\" type=\"xsd:string\"/>\r\n<xsd:element ref=\"dcterms:modified\" minOccurs=\"0\" maxOccurs=\"1\"/>\r\n<xsd:element name=\"contentStatus\" minOccurs=\"0\" maxOccurs=\"1\" type=\"xsd:string\"/>\r\n</xsd:all>\r\n</xsd:complexType>\r\n</xsd:schema>\r\n<xs:schema targetNamespace=\"http://schemas.microsoft.com/office/infopath/2007/PartnerControls\" elementFormDefault=\"qualified\" attributeFormDefault=\"unqualified\" xmlns:pc=\"http://schemas.microsoft.com/office/infopath/2007/PartnerControls\" xmlns:xs=\"http://www.w3.org/2001/XMLSchema\">\r\n<xs:element name=\"Person\">\r\n<xs:complexType>\r\n<xs:sequence>\r\n<xs:element ref=\"pc:DisplayName\" minOccurs=\"0\"></xs:element>\r\n<xs:element ref=\"pc:AccountId\" minOccurs=\"0\"></xs:element>\r\n<xs:element ref=\"pc:AccountType\" minOccurs=\"0\"></xs:element>\r\n</xs:sequence>\r\n</xs:complexType>\r\n</xs:element>\r\n<xs:element name=\"DisplayName\" type=\"xs:string\"></xs:element>\r\n<xs:element name=\"AccountId\" type=\"xs:string\"></xs:element>\r\n<xs:element name=\"AccountType\" type=\"xs:string\"></xs:element>\r\n<xs:element name=\"BDCAssociatedEntity\">\r\n<xs:complexType>\r\n<xs:sequence>\r\n<xs:element ref=\"pc:BDCEntity\" minOccurs=\"0\" maxOccurs=\"unbounded\"></xs:element>\r\n</xs:sequence>\r\n<xs:attribute ref=\"pc:EntityNamespace\"></xs:attribute>\r\n<xs:attribute ref=\"pc:EntityName\"></xs:attribute>\r\n<xs:attribute ref=\"pc:SystemInstanceName\"></xs:attribute>\r\n<xs:attribute ref=\"pc:AssociationName\"></xs:attribute>\r\n</xs:complexType>\r\n</xs:element>\r\n<xs:attribute name=\"EntityNamespace\" type=\"xs:string\"></xs:attribute>\r\n<xs:attribute name=\"EntityName\" type=\"xs:string\"></xs:attribute>\r\n<xs:attribute name=\"SystemInstanceName\" type=\"xs:string\"></xs:attribute>\r\n<xs:attribute name=\"AssociationName\" type=\"xs:string\"></xs:attribute>\r\n<xs:element name=\"BDCEntity\">\r\n<xs:complexType>\r\n<xs:sequence>\r\n<xs:element ref=\"pc:EntityDisplayName\" minOccurs=\"0\"></xs:element>\r\n<xs:element ref=\"pc:EntityInstanceReference\" minOccurs=\"0\"></xs:element>\r\n<xs:element ref=\"pc:EntityId1\" minOccurs=\"0\"></xs:element>\r\n<xs:element ref=\"pc:EntityId2\" minOccurs=\"0\"></xs:element>\r\n<xs:element ref=\"pc:EntityId3\" minOccurs=\"0\"></xs:element>\r\n<xs:element ref=\"pc:EntityId4\" minOccurs=\"0\"></xs:element>\r\n<xs:element ref=\"pc:EntityId5\" minOccurs=\"0\"></xs:element>\r\n</xs:sequence>\r\n</xs:complexType>\r\n</xs:element>\r\n<xs:element name=\"EntityDisplayName\" type=\"xs:string\"></xs:element>\r\n<xs:element name=\"EntityInstanceReference\" type=\"xs:string\"></xs:element>\r\n<xs:element name=\"EntityId1\" type=\"xs:string\"></xs:element>\r\n<xs:element name=\"EntityId2\" type=\"xs:string\"></xs:element>\r\n<xs:element name=\"EntityId3\" type=\"xs:string\"></xs:element>\r\n<xs:element name=\"EntityId4\" type=\"xs:string\"></xs:element>\r\n<xs:element name=\"EntityId5\" type=\"xs:string\"></xs:element>\r\n<xs:element name=\"Terms\">\r\n<xs:complexType>\r\n<xs:sequence>\r\n<xs:element ref=\"pc:TermInfo\" minOccurs=\"0\" maxOccurs=\"unbounded\"></xs:element>\r\n</xs:sequence>\r\n</xs:complexType>\r\n</xs:element>\r\n<xs:element name=\"TermInfo\">\r\n<xs:complexType>\r\n<xs:sequence>\r\n<xs:element ref=\"pc:TermName\" minOccurs=\"0\"></xs:element>\r\n<xs:element ref=\"pc:TermId\" minOccurs=\"0\"></xs:element>\r\n</xs:sequence>\r\n</xs:complexType>\r\n</xs:element>\r\n<xs:element name=\"TermName\" type=\"xs:string\"></xs:element>\r\n<xs:element name=\"TermId\" type=\"xs:string\"></xs:element>\r\n</xs:schema>\r\n</ct:contentTypeSchema>");
            writer.Flush();
            writer.Close();
        }

        public static void GenerateCustomXmlPropertiesPart2Content(CustomXmlPropertiesPart customXmlPropertiesPart2)
        {
            var dataStoreItem2 = new Ds.DataStoreItem { ItemId = "{F775187F-6448-4D29-88AA-E6D4EE8DAECF}" };
            dataStoreItem2.AddNamespaceDeclaration("ds", "http://schemas.openxmlformats.org/officeDocument/2006/customXml");

            var schemaReferences2 = new Ds.SchemaReferences();
            var schemaReference3 = new Ds.SchemaReference { Uri = "http://schemas.microsoft.com/office/2006/metadata/contentType" };
            var schemaReference4 = new Ds.SchemaReference { Uri = "http://schemas.microsoft.com/office/2006/metadata/properties/metaAttributes" };
            var schemaReference5 = new Ds.SchemaReference { Uri = "http://www.w3.org/2001/XMLSchema" };
            var schemaReference6 = new Ds.SchemaReference { Uri = "http://schemas.microsoft.com/office/2006/metadata/properties" };
            var schemaReference7 = new Ds.SchemaReference { Uri = "4fc81810-4f98-4e7e-b20e-7b2a690091c4" };
            var schemaReference8 = new Ds.SchemaReference { Uri = "067d236f-0129-4702-b692-531fc2f871d2" };
            var schemaReference9 = new Ds.SchemaReference { Uri = "http://schemas.microsoft.com/office/2006/documentManagement/types" };
            var schemaReference10 = new Ds.SchemaReference { Uri = "http://schemas.microsoft.com/office/infopath/2007/PartnerControls" };
            var schemaReference11 = new Ds.SchemaReference { Uri = "http://schemas.openxmlformats.org/package/2006/metadata/core-properties" };
            var schemaReference12 = new Ds.SchemaReference { Uri = "http://purl.org/dc/elements/1.1/" };
            var schemaReference13 = new Ds.SchemaReference { Uri = "http://purl.org/dc/terms/" };
            var schemaReference14 = new Ds.SchemaReference { Uri = "http://schemas.microsoft.com/internal/obd" };

            schemaReferences2.Append(schemaReference3);
            schemaReferences2.Append(schemaReference4);
            schemaReferences2.Append(schemaReference5);
            schemaReferences2.Append(schemaReference6);
            schemaReferences2.Append(schemaReference7);
            schemaReferences2.Append(schemaReference8);
            schemaReferences2.Append(schemaReference9);
            schemaReferences2.Append(schemaReference10);
            schemaReferences2.Append(schemaReference11);
            schemaReferences2.Append(schemaReference12);
            schemaReferences2.Append(schemaReference13);
            schemaReferences2.Append(schemaReference14);

            dataStoreItem2.Append(schemaReferences2);

            customXmlPropertiesPart2.DataStoreItem = dataStoreItem2;
        }

        public static void GenerateCustomXmlPart3Content(CustomXmlPart customXmlPart3)
        {
            var writer = new System.Xml.XmlTextWriter(customXmlPart3.GetStream(System.IO.FileMode.Create), System.Text.Encoding.UTF8);
            writer.WriteRaw("<?mso-contentType?><FormTemplates xmlns=\"http://schemas.microsoft.com/sharepoint/v3/contenttype/forms\"><Display>DocumentLibraryForm</Display><Edit>DocumentLibraryForm</Edit><New>DocumentLibraryForm</New></FormTemplates>");
            writer.Flush();
            writer.Close();
        }

        public static void GenerateCustomXmlPropertiesPart3Content(CustomXmlPropertiesPart customXmlPropertiesPart3)
        {
            var dataStoreItem3 = new Ds.DataStoreItem { ItemId = "{4FC9BDEA-EA46-43A8-AA87-476FAB077CDB}" };
            dataStoreItem3.AddNamespaceDeclaration("ds", "http://schemas.openxmlformats.org/officeDocument/2006/customXml");

            var schemaReferences3 = new Ds.SchemaReferences();
            var schemaReference15 = new Ds.SchemaReference { Uri = "http://schemas.microsoft.com/sharepoint/v3/contenttype/forms" };

            schemaReferences3.Append(schemaReference15);

            dataStoreItem3.Append(schemaReferences3);

            customXmlPropertiesPart3.DataStoreItem = dataStoreItem3;
        }
    }
}
