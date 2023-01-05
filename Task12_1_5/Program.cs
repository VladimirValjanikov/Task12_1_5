using System;
using System.Collections.Generic;

namespace Task12_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var userList = new List<User>();
            var user1 = new User { Login = "Vladimir", Name = "Владимир", IsPremium = true};
            var user2 = new User { Login = "Dmitriy", Name = "Дмитрий", IsPremium = false };
            var user3 = new User { Login = "Bob", Name = "Боб", IsPremium = false};
            userList.Add(user1);
            userList.Add(user2);
            userList.Add(user3);

            foreach (var user in userList)
            {
                Console.WriteLine("Здравствуйте, " + user.Name);
                if (!user.IsPremium)
                    Ads.ShowAds();
            }
        }
    }
}
