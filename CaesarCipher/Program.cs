using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] cipher = new char[26];

            Console.Write("Enter shift value: ");
            int shiftValue = Convert.ToInt32(Console.ReadLine()) % alphabet.Length;

            for (int i = 0; i < alphabet.Length; i++)
            {
                int newIndex = (i + shiftValue) % alphabet.Length;
                cipher[newIndex] = alphabet[i];
            }

            Console.Write("Enter some text to cipher: ");
            string text = Console.ReadLine();
            string cipherText = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    cipherText += ' ';
                }  
                else if (text[i] <= 'Z')
                {

                }
                else
                {
                    int newValue = text[i] + shiftValue;
                    cipherText += Convert.ToChar(newValue);
                }
                




                //if (text[i] == 'z')
                //{
                //    cipherText += Convert.ToChar('a' - 1 + shiftValue);
                //}
            }

            Console.WriteLine(cipherText);
        }
    }
}
