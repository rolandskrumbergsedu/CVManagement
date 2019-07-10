using System.Collections.Generic;
using System.Web;

namespace CV.Management.Web.Models
{
    public class AdditionalFilesViewModel
    {
        public List<AdditionalFileItem> Files { get; set; }
        public HttpPostedFileBase[] AdditionalFiles { get; set; }
    }

    public class AdditionalFileItem
    {
        public int AdditionalFileId { get; set; }
        public string FileName { get; set; }
        public string FileSrc { get; set; }
    }
}