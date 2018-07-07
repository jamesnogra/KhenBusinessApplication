using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Business_Application
{
    class Login
    {
        private string usersData = "DATA/users.dat";
        private string userSalt = "49ifhjme65hfgen3EQUMq3U7j5BTuKHX";
        private string passwordSalt = "fQKzCKlfALFjvnQuLNmbavCdGkYg4qla";
        private List<Users> users = new List<Users>();

        public Login()
        {
            try
            {
                using (StreamReader sr = new StreamReader(usersData))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] userData = sr.ReadLine().Split(':');
                        if (userData[0].Length > 0 && userData[1].Length > 0)
                        {
                            Users tempUser = new Users(userData[1], userData[2]);
                            users.Add(tempUser);
                        }
                    }
                    sr.Dispose();
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public bool checkLoginUser(string user, string password)
        {
            string tempUser = createMD5(user + userSalt);
            string tempPassword = createMD5(password + passwordSalt);
            foreach (Users tUser in users)
            {
                if (tUser.user == tempUser && tUser.password == tempPassword)
                {
                    return true;
                }
            }
            return false;
        }

        public bool addUser(string user, string password)
        {
            string tempUser = createMD5(user + userSalt);
            string tempPassword = createMD5(password + passwordSalt);
            foreach (Users tUser in users)
            {
                if (tUser.user == tempUser)
                {
                    return false;
                }
            }
            File.AppendAllText(usersData, "\n" + user + ":" + tempUser + ":" + tempPassword);
            return true;
        }

        private string createMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

    }
}
