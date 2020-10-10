using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography;
using System.IO;


/// <summary>
/// This page will be used to generate salt for users, hash password and store
/// UserName, Hashed Password, and User salt in Database
/// Written by Ian Brinkerhoff - OCT 2020
/// </summary>
namespace Typing.Pages
{
    public class RegisterModel : PageModel
    {

        public string sSalt;

        public void OnGet()
        {
            //Bool set to false in order to view registration form
            UserStatus.registered = false;
            UserStatus.SaltCreated = false;
        }

        /// <summary>
        /// Form will not post unless username and 2 passwords are filled out
        /// Javascript is used to verify that password and confirm password are matched
        /// before posting the form, we will now generate a salt for each user,
        /// hash the password and store this data in the DB
        /// </summary>
        public void OnPost()
        {
            //Bool set to true in order to view "registration complete page"
            UserStatus.registered = true;

            //Sets current user
            UserStatus.currentUser = Request.Form["UserName"];
            createUser();
        }

        /// <summary>
        /// Will be used to set attributes of newAccount
        /// UserName / Password to be hashed / Unique Salt
        /// </summary>
        public void createUser()
        { 

            //Gets username from form
            Account.UserName = UserStatus.currentUser;

            //Generates 16 character random char and appends to usersalt
            if (!UserStatus.SaltCreated)
            {
                Account.UserSalt = createSalt();
                UserStatus.SaltCreated = true;
                sSalt = Account.UserSalt;
            }
            //hashes password and salt to form hashed password
            Account.HashedPassword = "";
        }

        /// <summary>
        /// Create salt by generating random char and appending to string
        /// </summary>
        /// <returns>16 character random string</returns>
        public string createSalt()
        {
            //Instance of random number
            var rand = new Random();

            //string used to store the salt
            StringBuilder salt = new StringBuilder();

            //Loop runs 16 times, eachtime generate number from 33-126, 
            //converts number to char and appends char to salt
            for (int i = 1; i <= 16; i++)
            {
                salt.Append((char)rand.Next(33, 127));
            }

            return salt.ToString();
        }

    }
}
