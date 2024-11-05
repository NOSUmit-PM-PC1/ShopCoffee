using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ShopCoffee
{
    [Serializable]
    class Users : IEnumerable, IEnumerator
    {
        List<User> listUsers = new List<User>();

        public User ActiveUser { get; set; } = null;
        
        public void SetCurrentUserByName(string user)
        {
            ActiveUser = FindUserByName(user);
        }
        private User FindUserByName(string userName)
        {
            foreach (var user in listUsers)
                if (user.Name == userName)
                    return user;
            return null;
        }
        public void Add(User user)
        {
            listUsers.Add(user);
        }

        private int currentIndex = -1;
        object IEnumerator.Current => listUsers[currentIndex];
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        bool IEnumerator.MoveNext()
        {
            currentIndex++;
            if (currentIndex >= listUsers.Count)
            {
                return false;
            }

            return true;
        }

        void IEnumerator.Reset()
        {
            currentIndex = -1;
        }

        public void Serialize()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Data/user.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, this);
            }
        }

        static public Users DeSerialize()
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream("Data/user.dat", FileMode.OpenOrCreate))
                {
                    return (Users)formatter.Deserialize(fs);
                }
            }
            catch
            {
                return new Users();
            }
        }

    }

    [Serializable]
    public class User
    {
        public string Name { get; }
        public string Adress { get; }
        string password;

        public User(string name, string adress, string pass)
        {
            Name = name;
            Adress = adress;
            password = ToMD5(pass);
        }

        string ToMD5(string pass)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(pass);
            byte[] hashBytes = md5.ComputeHash(inputBytes);
            return hashBytes.ToString();
        }

        public bool CheckPassword(string pass)
        {
            return ToMD5(pass) == password;
        }

       
    }
}
