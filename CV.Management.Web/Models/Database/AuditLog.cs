using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV.Management.Web.Models.Database
{
    public class AuditLog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuditLogId { get; set; }
        public string AuditEvent { get; set; }
        public string Username { get; set; }
        public DateTime EventTime { get; set; }
        public string UserAffected { get; set; }
        public string UserAffectedId { get; set; }
    }
}