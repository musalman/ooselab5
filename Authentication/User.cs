using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication
{

    public class User
    {
        public static List<User> users = new List<User>();
        public string Username { get; set; }
        public string Password { get; set; }
        public User()
        {

        }
        public User(string u, string p)
        {
            this.Username = u;
            this.Password = p;
        }

        //Check if username already exists
        static bool CheckExistence(string u)
        {
            if (!users.Any() || users.Count > 0)
            {
                List<User> temp = users.Where(x => x.Username.Equals(u)).ToList();
                if (temp.Count>0)
                {
                    //User already exists
                    return true;
                }
                else
                {
                    //User doesnot exist
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //Signup function
        public static bool CreateAccount(string u, string p)
        {
            if (CheckExistence(u))
            {
                //User already exists : Signup unsuccessful
                return false;
            }
            else
            {
                //Password is stored in encrypted form
                //Signup successful
                users.Add(new User(u, Hash.Encrypt(p)));
                return true;
            }
        }
        public static bool SignIn(string u, string p)
        {
            if (!users.Any() || users.Count > 0)
            {
                List<User> temp = users.Where(x => x.Username.Equals(u)).ToList();
                if (temp.Count > 0)
                {
                    User obj = temp.Where(x => x.Username == u).First();
                    if ((Hash.Encrypt(p)).Equals(obj.Password))
                    {
                        //SignIn Successful
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
}
