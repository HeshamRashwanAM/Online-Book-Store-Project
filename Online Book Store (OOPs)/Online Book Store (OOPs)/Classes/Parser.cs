using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store__OOPs_.Classes
{
    public class Parser
    {
        public static List<User_Object> User_Objects;
        public static List<User_Object> ReadUser_Objects()
        {
            List<User_Object> tmp_User_Objects = new List<User_Object>();
            var Lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "users.txt");
            foreach (var line in Lines)
            {
                User_Object User_Object = new User_Object();
                String[] AccDetails = line.Split(new[] { "|" }, StringSplitOptions.None);
                var User_Objectname = AccDetails[0].Split(new[] { ":" }, StringSplitOptions.None);
                var password = AccDetails[1].Split(new[] { ":" }, StringSplitOptions.None);
                User_Object.Username = User_Objectname[1];
                User_Object.Password = password[1];
                tmp_User_Objects.Add(User_Object);
            }
            return tmp_User_Objects;
        }
        public static void WriteUser_Objects()
        {
            using (StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "users.txt", false))
            {
                foreach (User_Object User_Object in User_Objects)
                {
                    writer.WriteLine("User_Objectname:" + User_Object.Username + "|Password:" + User_Object.Password);
                }
            }
        }


    }
}
