using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    static class PhoneBook
    {
        public static void Task1(string filePath, string filePath2)
        {
            try
            {

                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();
                        string[] parts = line.Split(',');

                        using (StreamWriter streamWriter = new StreamWriter(filePath2, true))
                        {
                            streamWriter.WriteLine(parts[1]);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File '{filePath}' not found.");
            }
        }

        public static void Task2(string filePath)
        {

            Console.WriteLine("Please type a name in order to find the number");
            string name = Console.ReadLine();

            try
            {
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();
                        string[] parts = line.Split(',');
                        if (parts[0] == name) Console.WriteLine("found one" + $"{line}");
                        else Console.WriteLine("Not found");
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine($"Error writing to file '{filePath}'.");
            }
        }

        public static void Task3(string filePath3, string filePath4)
        {
            Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();

            try
            {
                using (StreamReader streamReader = new StreamReader(filePath3))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();
                        string[] parts = line.Split(',');
                        string addedLine = parts[1];
                        if (parts[1].StartsWith("80"))
                        {
                            addedLine = "+3" + parts[1];
                            Console.WriteLine(parts[0] + " " + addedLine);
                        }
                        phoneNumbers.Add(parts[0], addedLine);
                    }
                }

                using (StreamWriter streamWriter = new StreamWriter(filePath4))
                {
                    foreach (var data in phoneNumbers)
                    {
                        streamWriter.WriteLine(data.Key + " " + data.Value);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Files'{filePath3}, {filePath4}' have not been found");
            }
        }
    }
}
