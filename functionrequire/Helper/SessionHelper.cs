using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace functionrequire.Helper
{
    public static class SessionHelper
    {
        public static string UserId { get; set; }
        public static string FullName { get; set; }
        public static bool? Role { get; set; }
        static SessionHelper()
        {
            UserId = "0";
        }
    }
}