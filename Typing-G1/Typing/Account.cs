using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Typing
{
    /// <summary>
    /// Class used to create user account
    /// </summary>
    public class Account
    {
        //Attribute used to hold username
        public static string UserName;

        //String to hold user password after being hashed
        public static string HashedPassword;

        //Hash used to store salt unique to each user
        public static string UserSalt;
    }
}
