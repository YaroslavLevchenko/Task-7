using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string filePath = "phones.txt";
            const string filePath2 = "phones2.txt";
            const string filePath3 = "UPhones.txt";
            const string filePath4 = "New.txt";

            PhoneBook.Task1(filePath, filePath2);
            PhoneBook.Task2(filePath);
            PhoneBook.Task3(filePath3, filePath4);

            Console.ReadKey();

        }
    }
}
