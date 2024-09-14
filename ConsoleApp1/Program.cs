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

                        Console.WriteLine("LEFT");
                        Console.WriteLine("RIGHT");

                        input = Console.ReadLine();

                        if (input == "left")
                     {
                        Console.WriteLine("You weave left as you dodge down another corridor. However, you quickly come to realize that this only leads to a dead end! With the monster towering over you, you close your eyes, and- \nGAME OVER");
                        
                        Console.ReadLine();
                     }
                        else if (input == "right")
                     {
                        Console.WriteLine("As the Monster comes crashing into the wall behind you, you quickly take off once again to your right. Quickly again you find yourself at a crossroads, how much further will you have to go? \nWhere will you go?");

                        Console.WriteLine("LEFT");
                        Console.WriteLine("RIGHT");

                        input = Console.ReadLine();

                        if (input == "left")
                        {
                            Console.WriteLine("You cut left, finding yourself pressed against a long wall, with one path in each direction. \nYou get a bad feeling about this.");

                            Console.WriteLine("LEFT");
                            Console.WriteLine("RIGHT");

                            input = Console.ReadLine();
                        }
                        else if (input == "right")
                        {
                            Console.WriteLine("After dodging to the right, and following the pathway to the left, you come to an area with a hallway on your right side, and an open, dark doorway straight ahead. Do you take the chance with the doorway? Or risk losing yourself down anotehr set of hallways?");

                            Console.WriteLine("STRAIGHT");
                            Console.WriteLine("RIGHT");

                            input = Console.ReadLine();
                        }
                     }
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