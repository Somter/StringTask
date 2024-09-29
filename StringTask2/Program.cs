using System;
namespace CSharp.String
{
    class MainClass
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Введите текст: ");
                string str = Console.ReadLine();
                string[] arrayOfString = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string rezult = "";
                for (int i = 0; i < arrayOfString.Length; i++)
                {
                    string temp = arrayOfString[i].Trim();
                    temp = char.ToUpper(temp[0]) + temp.Substring(1);
                    rezult += temp + " ";
                }
                Console.WriteLine(rezult);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);   
            }

        }
    }
}