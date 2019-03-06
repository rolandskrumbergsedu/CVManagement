using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CV.Management.Web.Models.Database
{
    public class KeyTask
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KeyTaskId { get; set; }
        public string Name { get; set; }

        public virtual Position Position { get; set; }
    }
}