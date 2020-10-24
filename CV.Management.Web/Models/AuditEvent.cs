using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CV.Management.Web.Models
{
    public enum AuditEvent
    {
        ViewAdminPage,
        ViewConfirmDeleteUserPage,
        DeleteUser,
        DownloadPpt,
        DownloadDoc,
        ViewUser
    }
}