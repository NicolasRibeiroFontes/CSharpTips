using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tips.SOLID.DependencyInversionPrinciple.Problem
{
    public class Problem
    {
        public static void Run()
        {

        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class UserService
    {
        public void Save(User user)
        {
            UserRepository userRepository = new UserRepository();
            userRepository.Save(user);

            NotificationService notificationService = new NotificationService();
            notificationService.SendEmail(user.Email);
        }
    }

    public class UserRepository
    {
        public void Save(User user)
        {
            //Save it on DB
        }
    }

    public class NotificationService
    {
        public void SendEmail(string email)
        {

        }
    }
}
