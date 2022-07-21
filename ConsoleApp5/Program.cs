using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string word = Console.ReadLine();
            

            Console.WriteLine(GetPolindromMethod("Муза, ранясь шилом опыта, ты помолишься на разум"));
            Console.WriteLine(GetPolindromMethod("Муза, ранясь шилом опыта, ты помолишься на разум"));
            Console.WriteLine(GetPolindromMethod("А роза упала на лапу Азора"));
            Console.WriteLine(GetPolindromMethod("Отрицательный текст"));
            Console.WriteLine(GetPolindromMethod("qwert"));
            Console.WriteLine(GetPolindromMethod("Я — арка края"));
           
           


        }
        public static string RemovePunctuation(string word)
        {
            return Regex.Replace(word, "\\p{P}", string.Empty);
        }
        private static bool GetPolindromMethod(string word)
        {    
            word = RemovePunctuation(word.ToLower().Replace(" ",""));
            int j = word.Length-1;
            for (int i = 0; i < word.Length / 2 ; i++)
            {
                if (word[i].ToString() != word[j].ToString())
                {
                    return false;
                }
                j--;      
            }
            return true;
        }
    }
}
