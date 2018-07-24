using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter your name");
            string input = Console.ReadLine();
            ValidateName(input);

           
            Console.WriteLine("Please enter your email");
            string input1 = Console.ReadLine();
            ValidateEmail(input1);

           
            Console.WriteLine("Please enter your phone number (---)--- ----");
            string input2 = Console.ReadLine();
            ValidatePhoneNumber(input2);

           
            Console.WriteLine("Please enter a date: MM/DD/YYYY");
            string input3 = Console.ReadLine();
            ValidateDate(input3);

           
        }
        public static string ValidateName(string name)
        {
            if (Regex.IsMatch(name, @"^[a-zA-Z]{1,30}\s[a-zA-Z]{1,30}$"))
            {
                Console.WriteLine("You got it right!");
            }
            else
            {
                Console.WriteLine("Nice try! next time please do it right!");
            }
            return name;
        }
        public static string ValidateEmail(string email)
        {

            if (Regex.IsMatch(email, @"[a-z]{1,30}\@[\da-z]{5,10}\.[a-z]{2,6}"))
            {
                Console.WriteLine("You entered a valid email!");
            }
            else
            {
                Console.WriteLine("Nice try! next time please do it right!");
            }
            return email;

        }
        public static string ValidatePhoneNumber(string phoneNumber)
        {
            if (Regex.IsMatch(phoneNumber, @"^\d{3}\s\d{3}\s\d{4}$"))
            {
                Console.WriteLine("You got it right!");
            }
            else
            {
                Console.WriteLine("Nice try! next time please do it right!");
            }
            return phoneNumber;

        }
        public static string ValidateDate(String date)
        {
            if (Regex.IsMatch(date, @"^\d{2}/\d{2}/\d{4}"))
            {
                Console.WriteLine("You got it right!");
            }
            else
            {
                Console.WriteLine("Nice try! next time please do it right!");
            }
            return date;
        }
        
    }

    
}


