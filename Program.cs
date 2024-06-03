using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "Q:\\zuzanka.json"; // Replace with your file path
        string searchString = "\"sgv\":";
       

        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(searchString))
                    {
                        //Console.WriteLine(line);
                        line=line.Remove(line.Length - 1);
                        int startIndex = line.IndexOf(searchString) + searchString.Length;
                        string numberString = line.Substring(startIndex);
                        int number;

                        if (int.TryParse(numberString, out number))
                        {
                            Console.WriteLine(number);
                        }
                        else
                        {
                            Console.WriteLine("Unable to parse number.");
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}