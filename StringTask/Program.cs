using System;
namespace CSharp.String
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Введите арефметическое выражение: ");
                string str = Console.ReadLine();
                string[] arrayOfString = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int rezult = int.Parse(arrayOfString[0]);
                for (int i = 0; i < arrayOfString.Length; i++)
                {
                    int tamp = 0;
                    if (arrayOfString[i] == "+")
                    {
                        tamp = int.Parse(arrayOfString[i + 1]);
                        rezult += tamp; 
                    }
                    else if (arrayOfString[i] == "-")
                    {
                        tamp = int.Parse(arrayOfString[i + 1]); 
                        rezult -= tamp;
                    }
                }
                Console.WriteLine("Ответ: " + rezult);
            }
            catch (Exception ex) 
            {
                Console.WriteLine (ex.Message); 
            }
        }
    }
}