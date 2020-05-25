using System.Collections.Generic;

namespace CV.Management.Web.Helpers
{
    public static class AccessHelper
    {
        public static bool IsAdmin(string username)
        {
            var allowedUsers = new List<string>
            {
                "rolands.krumbergs@outlook.com",
                "larisa.kovsare@gmail.com"
            };

            return allowedUsers.Contains(username);
        }
    }
}