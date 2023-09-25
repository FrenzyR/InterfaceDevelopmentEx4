namespace Placeholder;
    class Exercise4
{
    static Random randomNumber = new Random();
    public static void Main()
    {
        Console.WriteLine("Hay tres juegos aquí, escoge" +
            "\n1) Jugar a adivinar los numeros del dado" +
            "\n2) Adivina un número aleatorio entre el 1 y el 100" +
            "\n3) Una... quiniela?" +
            "\n4) Jugar a todos, uno por uno" +
            "\n5) Salir");
        int givenNumber = 0;
        
        while (givenNumber >= -1 && givenNumber <= 5)
        {
            Console.WriteLine("Give me a number");
            givenNumber = Convert.ToInt32(Console.ReadLine());
            switch (givenNumber)
            {
                case 1:
                    
                    diceGame();
                    
                    if (givenNumber == 4)
                    {
                        Console.WriteLine("case 1");
                        goto case 2;
                    }
                    break;
                case 2:
                    TheHundredNumbersRandomGame();
                    if (givenNumber == 4)
                    {
                        Console.WriteLine("case 2");
                        goto case 3;
                    }
                    break;
                case 3:

                    if (givenNumber == 4)
                    {
                        Console.WriteLine("case 3");
                        break;
                    }
                    break;
                case 4:
                    Console.WriteLine("You've chosen to play all the games from one to three, ok");
                    goto case 1;                    
                case 5:                    
                    break;
                case -1:
                    break;
                default:
                    break;

            }
            Console.WriteLine("The current number is: " + givenNumber);
        } 
        
    }

    private static void TheHundredNumbersRandomGame()
    {
        int attempts = 5;
        int randomNumberFromOneToAHundred = randomNumber.Next(0, 100);
        for (global::System.Int32 i = 0; i < attempts; i++)
        {
            
            
            Console.WriteLine($"Give me a number from 1 to 100, you've {attempts - i} attempts");
            int givenNumber = Convert.ToInt32(Console.ReadLine());
            if (givenNumber > 100 || givenNumber <= 0)
            {
                Console.WriteLine("GIVEN NUMBER OUT OF BOUNDS"); //i am fully aware the way this code is structured is awful please bare with me
            }
            else if (randomNumberFromOneToAHundred == givenNumber)
            {
                Console.WriteLine("CORRECT");
                i = 4;
            }
            else if (randomNumberFromOneToAHundred < givenNumber)
            {
                Console.WriteLine("GIVEN NUMBER IS TOO BIG");

            }
            else if (randomNumberFromOneToAHundred > givenNumber)
            {
                Console.WriteLine("GIVEN NUMBER IS TOO SMALL");
            }

        }
    }

    private static void diceGame()
    {
        int winCount = 0;
        Console.WriteLine("How many faces do you want this dice to have?");
        int[] diceFaces = new int[0];
        do
        {
            try
            {
                diceFaces = new int[Convert.ToInt32(Console.ReadLine())];
            }
            catch (FormatException e)
            {
                Console.WriteLine("Unacceptable input, give me another one");
            }
        } while (diceFaces.Length == 0);
        
        for (int i = 0; i < diceFaces.Length; i++)
        {
            diceFaces[i] = i;
        }
        
        for (global::System.Int32 i = 0; i < 10; i++)
        {
            Console.WriteLine($"Ok, now guess which face it landed on from the {diceFaces.Length} faces");

           
                int givenNumber = Convert.ToInt32(Console.ReadLine());
             

            if (givenNumber <= 0 || givenNumber > diceFaces.Length)
            {
                i--;
                Console.WriteLine($"That's not even within the right parameters dude, I'll let this one slide, you've got {10 - (i + 1)} attempts left");
            }
            if (givenNumber >= 1 && givenNumber <= diceFaces.Length)
            {
                if (randomNumber.Next(1, diceFaces.Length+1) == givenNumber)
                {
                    Console.WriteLine($"You got this one right, you've got {10 - (i+1)} attempts left");
                    winCount++;
                }

                else
                {
                    Console.WriteLine($"Whoops, you've got {10 - (i + 1)} attempts left");
                }
            }
            
        }
        Console.WriteLine($"You've got the right number {winCount} times");
    }
}


