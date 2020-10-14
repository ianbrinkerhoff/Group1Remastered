using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Typing
{
    public class UserStatus
    {
        /// <summary>
        /// bool used to determine if anyone is logged in
        /// </summary>
        public static bool loggedIn { get; set; }

        /// <summary>
        /// bool used to determine when user has registered
        /// </summary>
        public static bool registered { get; set; }

        /// <summary>
        /// String to hold username of current user
        /// </summary>
        public static string currentUser { get; set; }

    }
}
