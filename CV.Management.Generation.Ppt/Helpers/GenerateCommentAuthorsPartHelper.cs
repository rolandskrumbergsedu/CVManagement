using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Presentation;

namespace CV.Management.Generation.Ppt.Helpers
{
    public static class GenerateCommentAuthorsPartHelper
    {

        public static void GenerateCommentAuthorsPart1Content(CommentAuthorsPart commentAuthorsPart1)
        {
            CommentAuthorList commentAuthorList1 = new CommentAuthorList();
            commentAuthorList1.AddNamespaceDeclaration("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
            commentAuthorList1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
            commentAuthorList1.AddNamespaceDeclaration("p", "http://schemas.openxmlformats.org/presentationml/2006/main");
            CommentAuthor commentAuthor1 = new CommentAuthor() { Id = (UInt32Value)2U, Name = "Author", Initials = "A", LastIndex = (UInt32Value)1U, ColorIndex = (UInt32Value)1U };

            commentAuthorList1.Append(commentAuthor1);

            commentAuthorsPart1.CommentAuthorList = commentAuthorList1;
        }
    }
}
