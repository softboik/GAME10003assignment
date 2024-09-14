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
            
            if (input == "play")
            {
                Console.WriteLine("You find yourself inside a winding, blocky Maze. Before you have time to get much of a sense of your surroundings, you hear a rather loud roar rumbling within the rocky walls. Seeming muffled at first, it immediately grew louder as a gate opens up behind you. \nWhich way do you run?");
                
                    Console.WriteLine("STRAIGHT");
                    Console.WriteLine("RIGHT");

                    input = Console.ReadLine();

                    if (input == "straight")
                    {
                        Console.WriteLine("You quickly take off into a sprint, Only to be met by a wall. After diving to the side, avoiding the monster that you can hear rumbling the floor behind you, you're met with another choice to make. \nWhich path will you take?");
                    }
                    else if (input == "right")
                    {
                        Console.WriteLine("You dive to your right to avoid a massive fist crashing down into the floor where you stood. As you scramble to your feet you realize there's two paths yet again. \nWhich will you take?");
                    }
                
            }
            else if (input == "exit")
            {
                Console.WriteLine("Goodbye!");
                Console.ReadLine();
            }
        }
    }
}