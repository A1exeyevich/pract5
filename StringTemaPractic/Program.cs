using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTemaPractic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello, World!";
            string str2 = "Hello, World!";
            string str3 = "hello, world!";

            Console.WriteLine("Сравнение с помощью оператора == :");
            Console.WriteLine($"str1 == str2 ? {str1 == str2}");
            Console.WriteLine($"str1 == str3 ? {str1 == str3}"); 

            Console.WriteLine("\nСравнение с помощью метода Equals():");
            Console.WriteLine($"str1.Equals(str2) ? {str1.Equals(str2)}"); 
            Console.WriteLine($"str1.Equals(str3) ? {str1.Equals(str3)}"); 

            Console.WriteLine("\nСравнение с помощью метода Compare():");
            int comparison1 = string.Compare(str1, str2); 
            int comparison2 = string.Compare(str1, str3); 
            Console.WriteLine($"Compare(str1, str2) : {comparison1}"); 
            Console.WriteLine($"Compare(str1, str3) : {comparison2}"); 

            Console.WriteLine("\nСравнение с помощью метода CompareOrdinal():");
            int ordComparison1 = string.CompareOrdinal(str1, str2); 
            int ordComparison2 = string.CompareOrdinal(str1, str3); 
            Console.WriteLine($"CompareOrdinal(str1, str2) : {ordComparison1}"); 
            Console.WriteLine($"CompareOrdinal(str1, str3) : {ordComparison2}"); 

            Console.WriteLine("\nПоиск подстроки с помощью IndexOf():");
            int index = str1.IndexOf("World");
            Console.WriteLine($"Index of 'World' in str1: {index}"); 

            Console.WriteLine("\nПроверка наличия подстроки с помощью Contains():");
            bool contains = str1.Contains("Hello");
            Console.WriteLine($"str1 содержит 'Hello' ? {contains}"); 

            Console.WriteLine("\nСравнение с помощью оператора != :");
            Console.WriteLine($"str1 != str2 ? {str1 != str2}"); 
            Console.WriteLine($"str1 != str3 ? {str1 != str3}"); 

            Console.Read();
        }
    }
}
