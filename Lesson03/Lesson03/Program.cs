using System;
using System.Text;

namespace Lesson03
{
    internal class Program
    {
        public static string text;
        public static string str;

        static void Main()
        {
            Console.Write("Enter text (in English): ");
            text = Convert.ToString(Console.ReadLine());
            string[] textArray = text.Split(new char[] { ' ' }); //we break the text into words

            if (textArray.Length >= 5)
            {
                Console.WriteLine("Number of words: " + textArray.Length); //output of array length == number of words

            }
            else
            {
                Console.WriteLine("ERROR!!! The minimum number of words is 5 ");
                Console.WriteLine("Restart the program and comply with the conditions");
                Environment.Exit(0);
            };

            Menu();
        }

        static void DeleteNumbers()
        {
            str = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsDigit(text[i]))
                {
                    str += text[i]; //delete numbers
                }
            }
            Console.WriteLine("Text without numbers: " + str);
        } //removes digits

        static void WordsReverse()
        {
            Console.Write("Text changed: ");
            string[] b = str.Split(' ');
            for (int i = 0; i < b.Length; i++)
            {
                string letters = b[i];
                char[] array = letters.ToCharArray();

                if (i % 2 == 0)
                {
                    Array.Reverse(array);
                    Console.Write(array);
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(array);
                    Console.Write(" ");
                }
            }
        } //reverse odd words

        static void First()
        {
            DeleteNumbers();
            WordsReverse();
            Console.Write("\nPress any key to continue ...");
            Console.ReadLine();
            Menu();

        } //first task

        static void Second()
        {
            string lookup = " \r\n\t";
            var sb = new StringBuilder(text);

            if (sb.Length > 0 && char.IsLetter(sb[0]))
                sb[0] = char.ToUpper(sb[0]);

            for (int i = 1; i < sb.Length; i++)
            {
                char ch = sb[i];
                if (lookup.Contains(sb[i - 1]) && char.IsLetter(ch))
                    sb[i] = char.ToUpper(ch);
            }
            Console.WriteLine("Text changed: " + sb);
            Console.Write("\nPress any key to continue ...");
            Console.ReadLine();
            Menu();

        } //second task

        static void Third()
        {
            text = text.Replace('P', 'S').Replace('p', 'S').Replace('n', 'O').Replace('N', 'O');
            Console.WriteLine("Text changed: " + text);
            Console.Write("\nPress any key to continue ...");
            Console.ReadLine();
            Menu();

        } //third task

        static void Menu()
        {
            int i;

            {

                {
                    Console.Write("Menu:\n1) First Task \n2) Second Task \n3) Third Task \n4)The End \n\nYour choice: ");
                    i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            First();
                            break;
                        case 2:
                            Second();
                            break;
                        case 3:
                            Third();
                            break;
                        case 4:
                            Console.WriteLine("Are you sure?");
                            break;
                        default:
                            Console.WriteLine("You clicked something else ...");
                            break;
                    }
                    Console.Write("\nPress any key ...");
                    Console.ReadLine();
                    Console.Clear();
                }

            }
        } //menu

    }
}
