namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void PrintNumbers()
        {
            for (int i =-1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()

        public static void PrintEveryThirdNumber()
        {
            for (int i =3; i < 999; i+=3)
                {
                Console.WriteLine(i);
                }
        }

        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        public static bool AreNumbersEqual(int num1, int num2)
        {
            return num1 == num2;
        }

        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        public static bool IsPositive(int number)
        {
            return number >= 0;
        }

        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static bool CanVote(int age)
        {   Console.WriteLine("Please provide your age once again");
            age =int.Parse(Console.ReadLine()) ;
            
            return age>18;
        }

        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        public static bool IsInRange(int number)
        {
            return number >= -10 && number <= 10;
        }


        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        public static void DisplayMultiplicationTable(int number)
        {
            for (int i = 0; i < 12; i++)
         {
                Console.WriteLine(number*i);
            }
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            Console.WriteLine("New Method Check 1");
            PrintNumbers();
            Console.WriteLine("New Method Check 2");

            PrintEveryThirdNumber();
            Console.WriteLine("New Method Check 3");

            Console.WriteLine("Values 4 and 5 are equal "+AreNumbersEqual(4,5));
            Console.WriteLine("Values 2 and -2 are equal "+AreNumbersEqual(2,-2));
            Console.WriteLine("Values 7 and 7 are equal "+AreNumbersEqual(7,7));
            
            Console.WriteLine("New Method Check 4");
            Console.WriteLine("Is 8 even: "+IsEven(8));
            Console.WriteLine("Is -4 even: "+IsEven(-4));
            Console.WriteLine("Is 0 even: "+IsEven(0));
            Console.WriteLine("Is 5 even: "+IsEven(5));
            
            Console.WriteLine("New Method Check 5");
            Console.WriteLine("Is 8 positive: "+IsPositive(4));
            Console.WriteLine("Is 0 positive: "+IsPositive(0));
            Console.WriteLine("Is 15 positive: "+IsPositive(15));
            Console.WriteLine("Is -34 positive: "+IsPositive(-34));
            
            Console.WriteLine("New Method Check 6");
            Console.WriteLine("Is 4 years can vote? "+CanVote(4));
            Console.WriteLine("Is 16 years can vote? "+CanVote(16));
            Console.WriteLine("Is 24 years can vote? "+CanVote(24));
            Console.WriteLine("Is 104 years can vote? "+CanVote(104));
            Console.WriteLine("Is 14 years can vote? "+CanVote(14));
            
            Console.WriteLine("New Method Check 7");
            Console.WriteLine("Is 6 in a range -10 and 10 "+IsInRange(6));
            Console.WriteLine("Is -9 in a range -10 and 10 "+IsInRange(-9));
            Console.WriteLine("Is -16 in a range -10 and 10 "+IsInRange(-16));
            Console.WriteLine("Is 22 in a range -10 and 10 "+IsInRange(22));
            Console.WriteLine("Is 0 in a range -10 and 10 "+IsInRange(0));

            
            Console.WriteLine("New Method Check 8");
            DisplayMultiplicationTable(4);
            DisplayMultiplicationTable(17);
            DisplayMultiplicationTable(-8);

        }
    }
}
