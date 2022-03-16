namespace Task3
{
    class Program
    {
        public static void Main()
        {
            var guessedNumber = 0;
            var userNumber = 0;

            Console.Write("Guess the number from 1 to 100: ");

            while (guessedNumber < 1 || guessedNumber > 100)
            {
                Console.Write("Please guess the number from 1 to 100: ");
                guessedNumber = int.Parse(Console.ReadLine());
            }

            while (guessedNumber != userNumber)
            {
                Console.Write("guess the guessed number: ");
                userNumber = int.Parse(Console.ReadLine());

                if (userNumber > guessedNumber)
                {
                    Console.WriteLine(userNumber + " is bigger, than guessed number. Lets try again!");
                }
                else if (userNumber < guessedNumber)
                {
                    Console.WriteLine(userNumber + " is less, than guessed number. Lets try again!");
                }
                else
                {
                    Console.WriteLine("You win!");
                }
            }
        }
    }
}