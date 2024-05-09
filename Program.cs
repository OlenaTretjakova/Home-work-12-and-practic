using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("task1.txt", false))
            {
                sw.WriteLine("The iteration variable corresponds to a local\n" +
                    " variable with a scope that extends over the embedded\n" +
                    " statement. During execution of a foreach statement, \n" +
                    "the iteration variable represents the collection element \n" +
                    "for which an iteration is currently being performed. \n" +
                    "If the iteration variable denotes a read-only variable,\n" +
                    " a compile-time error occurs if the embedded statement \n" +
                    "attempts to modify it (via assignment or the ++ and -- operators)\n" +
                    " or pass it as a ref or out parameter.");
            }

            try
            {

                using (StreamReader sr = new StreamReader("task1.txt"))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found: " + ex.Message);
            }


            //Task 2.
            Console.WriteLine();

            Console.WriteLine("Task 2.");

            Console.WriteLine("Enterthe elements of the array in white space");

            string str = Console.ReadLine();

            using (StreamWriter sw1 = new StreamWriter("array.txt", false))
            {
                sw1.WriteLine(str);
            }

            //Task 3.

            Console.WriteLine();

            Console.WriteLine("Task 3.");

            try
            {
                using (StreamReader sr1 = new StreamReader("array.txt"))
                {
                    {
                        string line;
                        line = sr1.ReadLine();

                        string[] stringArray = line.Split(' ');
                        int[] intArray = new int[stringArray.Length];

                        for (int i = 0; i < stringArray.Length; i++)
                        {
                            intArray[i] = int.Parse(stringArray[i]);

                        }

                        Console.Write("Array from file:");
                        foreach (int num in intArray)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found: " + ex.Message);
            }


            //Task 4.
            Console.WriteLine();

            Console.WriteLine("Task 4.");

            int counter = 100;
            Random random = new Random();
            int even = 0;
            int odd = 0;

            for (int i = 0; i < counter; i++)
            {
                int randomNumber = random.Next(-100, 101);
                if (randomNumber % 2 == 0)
                {
                    using (StreamWriter sw2 = new StreamWriter("randomNumbers1.txt", true))
                    {
                        sw2.Write(randomNumber + " ");
                    }
                    even++;
                }
                else
                {
                    using (StreamWriter sw2 = new StreamWriter("randomNumbers2.txt", true))
                    {
                        sw2.Write(randomNumber + " ");
                    }
                    odd++;
                }
            }

            Console.WriteLine($"From 100 random numbers even:{even}, odd:{odd}");


            //Task 5.
            Console.WriteLine();

            Console.WriteLine("Task 5.");

            Console.WriteLine("Waht word will be find?");
            string strFinding = Console.ReadLine();

            try
            {
                using (StreamReader sr5 = new StreamReader("task1.txt"))
                {
                    string line = sr5.ReadLine();
                    int count = 0;
                    int countLine = 0;

                    while ((line = sr5.ReadLine()) != null)
                    {
                        countLine++;
                        int indexFinding = -1;
                        while ((indexFinding = line.IndexOf(strFinding, indexFinding + 1)) != -1)
                        {
                            if (indexFinding != -1)
                            {
                                Console.WriteLine($"{strFinding} was found index:{indexFinding}, line:{countLine}.");
                                count++;
                            }

                        }

                    }

                    Console.WriteLine($"It was found {count} times:\"{strFinding}\".");

                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found: " + ex.Message);
            }


            //Task 6.
            Console.WriteLine();

            Console.WriteLine("Task 6.");

            try
            {
                using (StreamReader sr6 = new StreamReader("task1.txt"))
                {
                    string line = sr6.ReadLine();

                    int countSentence = 0;
                    int countWords = 0;
                    int countBigLetters = 0;
                    int countSmallLetters = 0;
                    int countNumbers = 0;

                    while ((line = sr6.ReadLine()) != null)
                    {
                        foreach (var letter in line)
                        {
                            if (letter == '.' || letter == '!' || letter == '?')
                            {
                                countSentence++;
                            }
                            if (letter == '.' || letter == '!' || letter == '?' || letter == ' ')
                            {
                                countWords++;
                            }
                            if (Char.IsLower(letter))
                            {
                                countSmallLetters++;

                            }
                            if (Char.IsUpper(letter))
                            {
                                countBigLetters++;
                            }
                            if (Char.IsNumber(letter))
                            {
                                countNumbers++;
                            }

                        }

                    }
                    Console.WriteLine($"The text contains {countSentence} sentences.");
                    Console.WriteLine($"The text contains {countWords} words.");
                    Console.WriteLine($"The text contains {countBigLetters} big letters.");
                    Console.WriteLine($"The text contains {countSmallLetters} small letters.");
                    Console.WriteLine($"The text contains {countNumbers} numbers.");

                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found: " + ex.Message);
            }



            //home work
            //task 1.
            Console.WriteLine();
            Console.WriteLine("Home work.");
            Console.WriteLine("Task 1.");
            //Завдання 1:
            //Додаток генерує 100 цілих чисел. Збережіть в один файл усі
            //прості числа. Статистику роботи
            //додатку виведіть на екран.

            using (StreamWriter sw7 = new StreamWriter("HomeWorkTask1.txt", true))
            {
                int counterNum = 100;

                while (counterNum > 0)
                {
                    int randomNum = random.Next(1, 100);
                   
                    sw7.Write(randomNum + " ");
                    counterNum--;
                }
            }

            try
            {
                using (StreamReader sr7 = new StreamReader("HomeWorkTask1.txt"))
                {
                    string line;

                    line = sr7.ReadToEnd();
                    
                    string[] strArr = line.Split();

                    for (int i=0; i<strArr.Length-1; i++)
                    {
                        int num = int.Parse(strArr[i].Trim());
                        bool isPrime = true;

                        if (num <= 1)
                        {
                            isPrime = false;
                        }
                        else
                        {
                            for (int j = 2; j <num; j++)
                            {
                                if (num % j == 0)
                                {
                                    isPrime = false;
                                    break;
                                }
                            }
                        }

                        if (isPrime)
                        {
                            Console.Write(num + " ");
                        }
                    }
                    
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Завдання 2:
            Console.WriteLine();

            Console.WriteLine("Task 2.");
            //Користувач вводить з клавіатури слово для пошуку у файлі і
            //слово для заміни.Додаток має змінити усі входження шуканого
            //слова на слово для заміни.Статистику роботи додатку виведіть
            //на екран.

            Console.WriteLine("Enter the word you want to change.");            string oldWord = Console.ReadLine();            Console.WriteLine("Enter the word you want to insetr.");            string insertWord = Console.ReadLine();
            StringBuilder newText = new StringBuilder();
            try            {
                using (StreamReader sr8 = new StreamReader("task1.txt"))
                {
                    string line = sr8.ReadLine();

                    while ((line = sr8.ReadLine()) != null)
                    {
                        int index = line.IndexOf(oldWord);
                        line = line.Replace(oldWord, insertWord);
                        newText.Append(line + " ");
                    }
                }            }            catch (FileNotFoundException ex)            {                Console.WriteLine(ex.Message);            }            using (StreamWriter sw8 = new StreamWriter("task1.txt", false))
            {
                sw8.Write(newText);
            }

            using (StreamReader sr9 = new StreamReader("task1.txt"))
            {
                string line;

                while ((line = sr9.ReadLine()) != null)
                {
                    Console.WriteLine(line );
                }
            }

            //Завдання 3:
            //Створіть додаток «Модератор». Користувач вводить шлях до
            //файлу з текстом і до файлу зі словами для модерації. За
            //підсумками роботи додатка, всі слова для модерації у
            //початковому файлі мають бути замінені на "*".

            Console.WriteLine() ;
            Console.WriteLine("Task 3.");

            void ReplaceWordsToFile()
            {
                Console.WriteLine("Enter address file:");
                string addressFile = Console.ReadLine();

                Console.WriteLine("Enter address word you want to replace:");
                string addressWord = Console.ReadLine();

                string word;
                string text;

                StringBuilder newWord = new StringBuilder();
                string textAfterReplace = "";

                try
                {
                    using (StreamReader sr10 = new StreamReader(addressWord))
                    {
                        word = sr10.ReadLine();
                        Console.WriteLine("Word to replace: " + word);
                    }

                    foreach (var letter in word)
                    {
                        newWord.Append("*");
                    }

                    using (StreamReader sr11 = new StreamReader(addressFile))
                    {
                        text = sr11.ReadToEnd();
                    }
                    Console.WriteLine("Original text: " + text);

                    textAfterReplace = text.Replace(word, newWord.ToString());
                    Console.WriteLine("Text after replacement: " + textAfterReplace);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                using (StreamWriter sw11 = new StreamWriter(addressFile, false))
                {
                    sw11.Write(textAfterReplace);
                }
                Console.WriteLine("Replacement word: " + newWord.ToString());
                Console.WriteLine("Final text after writing to file: " + textAfterReplace);
            }

            ReplaceWordsToFile();


            Console.ReadLine();


        }
    }
}
