using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoginTask
{
    
    public class User
    {
        public static string AdminKey = "secret";
        public string id;
        public string username;
        public string password;
        public string isAdmin;
        public User()
        {
            this.id = "Unknown";
            this.username = "Unknown";
            this.password = "Unknown";
            this.isAdmin = "Unknown";
        }
        public User(string id, string username, string password, string isAdmin)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.isAdmin = isAdmin;
        }

        public static bool Verification(string username, string password)
        {
            foreach (var user in User.UsersList())
            {
                if(username == user.username && password == user.password)
                {
                    return true;
                }
            }

            return false;
        }
        public static User Add(string username,string password, string adminKey)
        {
            bool isAdmin = (adminKey == User.AdminKey) ? true : false;
            int id = User.UsersList().Count;
            StreamWriter sw = new StreamWriter("UserData.txt", append: true);
            sw.WriteLine(id + ":" + username + ":" + password + ":" + isAdmin + ":");
            User user = new User(id.ToString(), username,password,isAdmin.ToString());
            sw.Close();
            return user;
            
        }
        public static List<User> UsersList()
        {
            StreamReader sr = new StreamReader("UserData.txt");

            List<User> users = new List<User>();

            while (true)
            {
                string line = sr.ReadLine();
                try
                {
                    char c = line[0];
                }
                catch
                {
                    break;
                }
                string[] ui = line.Split(':');
                users.Add(new User(ui[0], ui[1], ui[2], ui[3]));
            }

            sr.Close();
            return users;
        }
        public static bool Exist(string username)
        {
            
            foreach (User user in User.UsersList())
            {
                if (username == user.username)
                {
                    return true;
                }
            }

            return false;
        }
        
        public void changePassword()
        {
            List<User> userList = User.UsersList();
            StreamWriter sa = new StreamWriter("UserData.txt");
            sa.Write("");
            sa.Close();
            StreamWriter sw = new StreamWriter("UserData.txt", append: true);
            foreach(var user in userList)
            {
                if(this.username == user.username)
                {
                    user.password = this.password;
                }
                sw.WriteLine(user.id + ":" + user.username + ":" + user.password + ":" + user.isAdmin + ":");

            }
            sw.Close();
            
        }
        public static User CurrentUser(string username)
        {
            List<User> userList = User.UsersList();
            foreach (var user in userList)
            {
                if (username == user.username)
                {
                    return user;
                }

            }
            return new User();
        }
        public void Delete()
        {
            List<User> userList = User.UsersList();
            StreamWriter sa = new StreamWriter("UserData.txt");
            sa.Write("");
            sa.Close();
            StreamWriter sw = new StreamWriter("UserData.txt", append: true);
            var i = 0;
            foreach (var user in userList)
            {
                if(this.username == user.username)
                {
                    continue;
                }
                sw.WriteLine(i + ":" + user.username + ":" + user.password + ":" + user.isAdmin + ":");
                i++;
            }
            sw.Close();
        }

        
    }
}
