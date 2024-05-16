using System;

namespace In_the_Castle_of_the_King
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string userValue = Console.ReadLine();
            Console.WriteLine("It is nice to meet you" + userValue);

            string newGame = "yes";
            while (newGame == "yes")
            {
                Console.WriteLine(
                    "The king as summoned you to the castle. When you get to the castle the guards take you to the throne room. When you get in there the king says it is time to play a game. He disappears and you are supposed to find him.");
                Console.WriteLine(
                    "You look around and you can see 1 door on each wall. There is one to the North, South, East, and West. Which door would you want to go too.");
                string doorRoom = Console.ReadLine();
                string message = "";
                if (doorRoom == "north")
                    message = "You found the treasure room.";
                else if (doorRoom == "south")
                    message = "You found nothing";
                else if (doorRoom == "east")
                    message = "You found the king";
                else if (doorRoom == "west")
                    message = "You opened up the door and trapdoors opened up underneath you. You feel down into a dungeon with a dragon. The dragon eat you.";
                else
                    message = "Sorry, I do not understand you.";
                Console.WriteLine(message);
                Console.WriteLine("Thank you for playing my game. Do you want to play again?");
                string vaildChoose = "no";
                while (vaildChoose == "no")
                {
                    string endGame = Console.ReadLine();
                    if (endGame == "no")
                    {
                        vaildChoose = "yes";
                        newGame = "no";
                    }
                        
                    else if (endGame == "yes")
                    {
                        vaildChoose = "yes";
                        Console.WriteLine("Okay.");
                    }
                    else
                        Console.WriteLine("Sorry that is not an invaild answer.");
                }
                    
            }
        }
    }
}
