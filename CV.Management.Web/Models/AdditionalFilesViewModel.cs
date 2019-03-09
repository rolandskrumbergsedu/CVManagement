using System.Collections.Generic;

namespace CV.Management.Web.Models
{
    public class AdditionalFilesViewModel
    {
        public List<AdditionalFileItem> Files { get; set; }    
    }

    public class AdditionalFileItem
    {
        public int AdditionalFileId { get; set; }
        //public string FileContent { get; set; }
        //public string FileType { get; set; }
        public string FileName { get; set; }
    }
}