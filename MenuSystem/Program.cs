using System;
using System.Text;

namespace MenuSystem;
class Program
{
    static public void HelloWorld()  
    {
        Console.WriteLine("This is Hello World");
    }

    static public void GuessNumber()
    {
        Console.WriteLine("Enter a number to guess between 1 to 20:");
        Random random = new Random();


        int number = random.Next(1, 20);

        bool isGuessedRight = false;


        for (int i = 0; i < 5; i++)
        {

            var userinput = Console.ReadLine();
            int userValue = Convert.ToInt32(userinput);

            isGuessedRight = CheckGuess(number, userValue);

            if (isGuessedRight == true)
            {
                break;
            }

            if (i == 4 && isGuessedRight == false)
            {
                Console.WriteLine("Sorry, you failed to guess the number in five tries!");
            }
        }
    }

    static bool CheckGuess(int number, int userValue)
    {
        if (number > userValue)
        {
            Console.WriteLine("Tyvärr du gissade för lågt!");
        }
        else if (number < userValue)
        {
            Console.WriteLine("Tyvärr du gissade för högt!");
        }
        else if (number == userValue)
        {
            Console.WriteLine("Woho! Du gjorde det!");
            return true;
        }
        return false;
    }

    static void ChessBoard()
    {
        string text = Console.ReadLine();
        int userInput = Convert.ToInt32(text);


        for (int i = 0; i < userInput; i++)
        {
            for (int j = 0; j < userInput; j++)
            {
                Console.Write("[]");

            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    { 
        Console.WriteLine("Välkommen till min projektsamling! Vänligen välj ett av nedanstående alternativ:");
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("[1] Hello World");
            Console.WriteLine("[2] Guess a number");
            Console.WriteLine("[3] Chess board");
            Console.WriteLine("[4] Avsluta");

            Int32.TryParse(Console.ReadLine(), out int input);

            switch (input)
            {
                case 1:
                    //Program program = new Program();
                    //program.HelloWorld();
                    Console.WriteLine("You have selected Hello World project");
                    HelloWorld();
                    break;
                case 2:
                    Console.WriteLine("You have selected Guess a number project");
                    GuessNumber();
                    break;
                case 3:
                    Console.WriteLine("You have selected Chess board project");
                    ChessBoard();
                    break;
                case 4:
                    Console.WriteLine("Program has terminated");
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("You have to choose 1-4");
                    break;
            }

        } 
    }
}

