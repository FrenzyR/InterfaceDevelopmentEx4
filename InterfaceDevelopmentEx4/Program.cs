namespace Placeholder;
    class Exercise4
{
    static Random randomNumber = new Random();   // Posibilidad de repetir cada juego tras acabarlo, Quini indicando nº de partido y bien alineado en columa
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
            Console.WriteLine("There's three games here, choose" +
            "\n1) Play guyessing the numbers of a dice" +
            "\n2) Guess a random number from 1 to 100" +
            "\n3) Whatever this is lol (quiniela)" +
            "\n4) Play every one of them in order" +
            "\n5) Leave");
            Console.WriteLine("Give me a number");
            givenNumber = Convert.ToInt32(Console.ReadLine());
            switch (givenNumber)
            {
                case 1:
                    
                    diceGame();
                    Console.WriteLine("Do you wish to play the game again? y/n");
                    if (Console.ReadLine() == "y")
                    {
                        goto case 1;
                    }
                    if (givenNumber == 4)
                    {
                        Console.WriteLine("case 1");
                        goto case 2;
                    }
                    break;
                case 2:
                    TheHundredNumbersRandomGame();
                    Console.WriteLine("Do you wish to play the game again? y/n");
                    if (Console.ReadLine() == "y")
                    {
                        goto case 2;
                    }
                    if (givenNumber == 4)
                    {
                        Console.WriteLine("case 2");
                        goto case 3;
                    }
                    break;
                case 3:
                    int quiniela = 15;
                    for (int i = 0; i < quiniela; i++)
                    {
                        Console.WriteLine(PonderedNumber());
                    }
                    Console.WriteLine("Do you wish to play the game again? y/n");
                    if (Console.ReadLine() == "y")
                    {
                        goto case 3;
                    }

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

                default:
                    while (givenNumber <= 0 || givenNumber > 6)
                    {
                        Console.WriteLine("Invalid number, give me another one");
                        givenNumber = Convert.ToInt32(Console.Read());
                    }
                    break;

            }
            Console.WriteLine("The current number is: " + givenNumber);
        } 
        
    }

    private static String PonderedNumber()
    {
        int ponderedNumber = randomNumber.Next(101);
        switch (ponderedNumber)
        {
            case > 0 and < 60:
                return "1";
                
            case > 61 and < 85:
                return "    X";
                
            case > 86 and < 100:
                return "        2";
        }
        return "";
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
            catch (Exception e)
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


