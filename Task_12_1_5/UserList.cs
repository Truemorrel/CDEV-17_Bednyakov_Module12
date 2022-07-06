using System;
using System.Collections.Generic;
using System.Text;

namespace Task_12_1_5
{
    public class UserList
    {
        public List<User> Users { get; set; }   
        public UserList()
        {
            Users = new List<User>();
        }
        public bool IsUserInList(string login)
        {
            return Users.Exists(l => (l.Login == login));
        }
        public void AddUser(string login, string name, string password, bool premium)
        {
            if (IsUserInList(login))
            {
                throw new Exception("Login is accupied");
            }
            Users.Add(new User { Login = login, Name = name, IsPremium = premium});
        }
        public void AddUser(User person) => this.Users.Add(person);
        public bool IsUserPremium(string login)
        {
            if (!IsUserInList(login))
            {
                throw new Exception("login is not exists");
            }
            return Users.Exists( l => (l.Login == login && l.IsPremium));
        }
    }
}
