// Dice Roll Simulator Assignment by Gabriel N.
#nullable disable
Console.Clear();

// Main Loop
bool loop = true;
while (loop)
{
    // Menu 
    Console.WriteLine("\nDice Roll Simulator Menu \n1. Roll Dice Once \n2. Roll Dice 5 Times \n3. Roll Dice 'n' Times \n4. Roll Dice until Snake Eyes \n5. Exit");
    Console.Write("Select an option (1-5): ");
    int selection = Convert.ToInt32(Console.ReadLine());
    Random rnd = new Random();

    // Process selection
    if (selection == 1)
    {
        // Roll Dice Once
        int dice1 = rnd.Next(1, 7);
        int dice2 = rnd.Next(1, 7);

        Console.WriteLine($"\n{dice1},{dice2} (sum: {dice1 + dice2})");

    }
    else if (selection == 2)
    {
        for (int n = 1; n <= 5; n++)
        {
            // Roll Dice 5 Times
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);

            Console.WriteLine($"\n{dice1},{dice2} (sum: {dice1 + dice2})");
        }
    }
    else if (selection == 3)
    {
        Console.Write("\nHow many rolls would you like? ");
        int i = Convert.ToInt32(Console.ReadLine());
        for (int n = 1; n <= i; n++)
        {
            // Roll Dice 'n' Times
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);

            Console.WriteLine($"\n{dice1},{dice2} (sum: {dice1 + dice2})");
        }
    }
    else if (selection == 4)
    {
        bool loop1 = true;
        int rollNum = 0;
        while (loop1)
        {
            // Roll Dice until Snake Eyes
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);

            Console.WriteLine($"\n{dice1},{dice2} (sum: {dice1 + dice2})");
            if (dice1 == 1 && dice2 == 1)
            {
                rollNum++;
                Console.WriteLine($"SNAKE EYES! It took {rollNum} rolls to get snake eyes.");
                loop1 = false;
            }
            else
            {
                rollNum++;
            }
        }
    }
    else if (selection == 5)
    {
        // End Program
        loop = false;
    }
}



