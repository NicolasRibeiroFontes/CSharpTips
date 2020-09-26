using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tips.SOLID.DependencyInversionPrinciple.Solution
{
    public class Solution
    {

    }

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class UserService
    {
        private readonly IUserRepository _userRepository;
        private readonly INotificationService _notificationService;

        public UserService(IUserRepository userRepository, INotificationService notificationService)
        {
            _userRepository = userRepository;
            _notificationService = notificationService;
        }
        public void Save(User user)
        {
            _userRepository.Save(user);            
            _notificationService.SendEmail(user.Email);
        }
    }

    public interface IUserRepository
    {
        void Save(User user);
    }
    public class UserRepository: IUserRepository
    {
        public void Save(User user)
        {
            //Save it on DB
        }
    }

    public interface INotificationService
    {
        void SendEmail(string email);
    }
    public class NotificationService: INotificationService
    {
        public void SendEmail(string email)
        {

        }
    }
}
