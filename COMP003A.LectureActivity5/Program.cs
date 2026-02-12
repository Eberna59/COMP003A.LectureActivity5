namespace COMP003A.LectureActivity5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DisplayWelcome();

            String studentName = "Evan";
            int studentAge = 21;
            DisplayUserInfo(studentName, studentAge);

            int total = CalculateSum(9, 6);
            Console.WriteLine("The sum is: " + total);

            int mainValue = 100;

            if (true)
            {
                int insideBlock = 25;
                Console.WriteLine("Inside block: " + insideBlock);

            }

            for (int counter = 0; counter < 4; counter++)
            {
                Console.WriteLine("Counter value: " + counter);
            }


            
        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Module 5");
        }

        static void DisplayUserInfo(string name, int age)
        {
            Console.WriteLine("Name: " + name + ", Age: " + age);
        }

        static int CalculateSum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
