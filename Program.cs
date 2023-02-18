using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExercicesCsharp
{
    internal class Program
    {
        static void ConsecutineNr()
        {
            bool secuence = true;
            Console.Write("Enter dashed numbers: ");
            string[] input = Console.ReadLine().Split('-');
            int[] numbers = Array.ConvertAll(input, int.Parse);
            for (int i = 1; i < numbers.Length; i++)
            {
                //check if current value is +1 greater than last value
                if (numbers[i] + 1 == numbers[i - 1] || numbers[i] - 1 == numbers[i - 1] && secuence == true)
                {   //continue counting if consecutive
                    secuence = true;
                }
                else
                {   //Stop Counting if not consecutive
                    secuence = false;
                }
            }
            if (secuence)
            {
                Console.WriteLine("The Numbers are consecutive");
            }
            else
            {
                Console.WriteLine("They are not consecutive");
            }
        }
        static void Duplicactes()
        {
            Console.Write("Enter dashed numbers: ");
            string[] input = Console.ReadLine().Split('-');
            Array.Sort(input);
            List<int> numbers = new List<int>();
            for(int i=0;i<input.Length;i++)
            {
                numbers.Add(int.Parse(input[i]));
            }
            bool isConsec = numbers.Count != numbers.Distinct().Count();
            if (isConsec)
            {
                Console.WriteLine("The list contains duplicates.");
            }
            else
            {
                Console.WriteLine("The list does not contain duplicates.");
            }
        }
        static void Time()
        {
            Console.Write("Enter a time value in the 24-hour time format (e.g. 19:00): ");
            string[] input = Console.ReadLine().Split(':');
            int numberOne = int.Parse(input[0]);
            int numberTwo = int.Parse(input[1]);
            Console.WriteLine("{0} {1}", numberOne, numberTwo);
            if((numberOne >= 1 && numberOne <= 23) && (numberTwo >= 0 && numberTwo <= 59))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not Valid");
            }
        }
        static void PascalCase(string word)
        {
            var inputs = word.Split(' ');
            var t = "";
            if (string.IsNullOrEmpty(word)) {
                return;
            }
            foreach(var cuv in inputs)
            {
                Console.WriteLine(cuv[0]);
                t += char.ToUpper(cuv[0]) + cuv.Substring(1).ToLower();
            }
            t.Trim();
            Console.WriteLine(t);
        }
        static void Vowels(string word)
        {
            string[] vowels = { "a", "e", "o", "u", "i" };
            var arr = word.ToArray();
            int counter = 0;
            if (string.IsNullOrEmpty(word) ) { return; }
            for(int i=0;i< arr.Length;i++)
            {
                for (int j = 0;j< vowels.Length; j++)
                {

                   if (arr[i].ToString().ToLower() == vowels[j])
                   {
                     counter++;
                   }
                }
                
            }
            Console.WriteLine($"The word {word} has {counter} vowels.");
        }
        // Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.
        static void ReversedName(string name)
        {
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            char[] nameArray = name.ToCharArray();

            Array.Reverse(nameArray);

            string reversedName = new string(nameArray);

            //Console.WriteLine("Your name reversed is: " + reversedName);
        }
        //Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        static void Main(string[] args)
        {
            Vowels("inadequate");
            //PascalCase("NUMBER OF STUDENTS");
            //Time();
            //Duplicactes();
            //ConsecutineNr();
            /*Random random = new Random();
            int randomNumber = random.Next(1,10);
            Console.WriteLine(randomNumber);
            int lives = 4;
            while(lives > 0)
            {
                 Console.Write("Enter a number: ");
                 int num = int.Parse(Console.ReadLine());

                if(num == randomNumber)
                {
                    Console.WriteLine("You won");
                    break;
                }
                else
                {
                    Console.WriteLine("You lost");
                }
                
            }
            
            int number = 4;
            int prod = 1;
            for(int i = 1; i <= number; i++)
            {
                prod = prod * i;
            }
            Console.WriteLine(prod);
            List<string> list = new List<string>();
            int sum = 0;
            while (true)
            {
                Console.Write("Enter a number or pres OK ");
                string num = Console.ReadLine();
                if (num.ToLower() == "ok") break;
                list.Add(num);
            }
            foreach(string str in list)
            {
                sum += Int32.Parse(str);
            }
           Console.WriteLine(sum);
            List<int> list = new List<int>();
            var one = 1;
            var oneHundred = 100;
            for(var i = one; i <= oneHundred; i++)
            {
                if(i % 3 == 0)
                {
                    list.Add(i);
                    Console.WriteLine(i);
                }
            }
            ReversedName("cuvant");

            //List<int> numbers = new List<int>();
           // while(numbers.Count < 5)
            //{
               // Console.Write("Enter a number: ");
               // int num = int.Parse(Console.ReadLine());

               // if (numbers.Contains(num))
              //  {
              //      Console.WriteLine("You have already entered that number. Please try again.");
///}
              //  else
               // {
              //      numbers.Add(num);
              //  }
          //  }
           // numbers.Sort();
            //foreach (int num in numbers)
///{
               // Console.WriteLine(num);
          //  }


            //Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates.Display the unique numbers that the user has entered.
            List<string> nrs = new List<string>();
            while (true)
            {
                Console.Write("Enter a number or pres Quit ");
                string num = Console.ReadLine();
                if (num.ToLower() == "quit")
                {
                    break;
                }
                nrs.Add(num);
            }
            List<string> uniqueNrs = nrs.Distinct().ToList();
            Console.WriteLine("The unique numbers you entered are:");
            foreach (string nr in uniqueNrs)
            {
                if(uniqueNrs.Count == 0)
                {
                    Console.WriteLine("Lista e goala");
                }
                else
                {
                Console.WriteLine(nr);
                }
            }
           */
        }
    }
}