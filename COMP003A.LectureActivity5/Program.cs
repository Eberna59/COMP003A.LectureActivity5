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

            int total = calcukatesum(9, 6);
            Console.WriteLine("The sum is: " + total);

            int mainValue = 100;

            if (true)
            {
                int insideBlock = 25;
                Console.WriteLine("Inside block: " insideBlock);

            }


            
        }
    }
}
