using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tips.SOLID.InterfaceSegregationPrinciple.Problem
{
    public class Problem
    {
    }

    interface IRegisterService
    {
        bool Valid();
        bool Register();
        void SendMail();
    }

    public class UserService : IRegisterService
    {
        public bool Valid()
        {
            //Code Body
            return true;
        }

        public bool Register()
        {
            //Code Body
            return true;
        }

        public void SendMail()
        {
            //Code Body
        }
    }

    public class ProductService : IRegisterService
    {
        public bool Valid()
        {
            //Code Body
            return true;
        }

        public bool Register()
        {
            //Code Body
            return true;
        }

        public void SendMail()
        {
            //Code Body

            //Send mail to who????????
        }
    }
}
