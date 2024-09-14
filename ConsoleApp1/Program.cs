using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        string input;
        {
            Console.WriteLine("Hello Player");
            Console.WriteLine("PLAY");
            Console.WriteLine("EXIT");

            input = Console.ReadLine();
            
            if (input == "PLAY");
            {
                Console.WriteLine("You find yourself inside a winding, blocky Maze. Before you have time to get much of a sense of your surroundings, you hear a rather loud roar rumbling within the rocky walls. Seeming muffled at first, it immediately grew louder as a gate opens up behind you. \nWhich way do you run?");
                {
                    Console.WriteLine("STRAIGHT");
                    Console.WriteLine("RIGHT");

                    input = Console.ReadLine();

                    if (input == "STRAIGHT") ;
                    {

                    }
                }
            }
            else if (input == "EXIT");
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}