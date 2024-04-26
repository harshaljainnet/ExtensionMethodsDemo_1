using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDemo_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string data = "Some random string";
            data.PrintContentsToConsole();

            User user = new User() { FirstName = "Harshal", LastName = "Jain", Salary = 25000 };
            string fullNameOfUser = user.GetFullNameOfUser();
            Console.WriteLine("Full Name: " + fullNameOfUser);
        }
    }

    // static class

    // static method

    // this

    // lets create an extension method for string class
    public static class StringExtensionMethods
    {
        public static void PrintContentsToConsole(this string contents)
        {
            Console.WriteLine("These contents are printed from within an Extn method: " + contents);
        }
    }


    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Salary { get; set; }
    }

    // lets create an extn method which returns string ie full name of the user
    public static class UserExtensionMethods
    {
        public static string GetFullNameOfUser(this User user)
        {
            return user.FirstName + " " + user.LastName;
        }
    }

}
