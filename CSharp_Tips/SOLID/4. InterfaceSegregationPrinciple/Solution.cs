using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Tips.SOLID.InterfaceSegregationPrinciple.Solution
{
    public class Solution
    {
    }

    public interface IProductService
    {
        bool Valid();

        bool Register();
    }

    public class ProductService: IProductService
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
    }

    public interface IUserService
    {
        bool Valid();

        bool Register();

        void SendMail();
    }

    public class UserService: IUserService
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
}
