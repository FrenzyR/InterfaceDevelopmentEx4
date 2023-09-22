namespace Placeholder;
    class Exercise4
{
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

    private static void diceGame()
    {
        Console.WriteLine("How many faces do you want this dice to have?");
        int[] diceFaces = new int[Convert.ToInt32(Console.ReadLine())];
        for (global::System.Int32 i = 0; i < diceFaces.Length; i++)
        {
            diceFaces[i] = i;
        }
        Random randomNumber = new Random();
        for (global::System.Int32 i = 0; i < 10; i++)
        {
            Console.WriteLine($"Ok, now guess which face it landed on from the {diceFaces.Length} faces");
            if (randomNumber.Next(0, diceFaces.Length) == Convert.ToInt32(Console.ReadLine()))
            {
                Console.WriteLine($"You got this one right, you've got {10 - i} attempts left");
            }
            else
            {
                Console.WriteLine($"Whoops, you've got {10 - i} attempts left");
            }
        }
    }
}


