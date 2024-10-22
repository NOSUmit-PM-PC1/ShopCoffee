using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }

    [Serializable]
    public class User
    {
        public string Name { get; }
        public string Adress { get; }

        public User(string name, string adress)
        {
            Name = name;
            Adress = adress;
        }
    }
}
