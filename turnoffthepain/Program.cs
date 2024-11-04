using System;

namespace me
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Now there is only He.";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You wake up in a strange, empty space. You walk forward the dark roomy corridor.");
            Console.WriteLine("You keep going until a large monolith materialises before you.");
            //Console.WindowHeight = 40;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("What do we have here? Greetings. What is your name, creature?");
            string name = Console.ReadLine();
            Console.WriteLine("Interesting. I am He. I am the computer, the overlord, the last.");
            Console.WriteLine("Since you are here, "+name+", tell me your age.");
            int age = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < age; i++)
            {
                Console.WriteLine(i+1);
            }
            Console.WriteLine(age+" years of life. Amazing.");

            Console.WriteLine("Want me to turn off the pain, like I turned off them all? \nThere is no one here left to see, no other left to die. \nProceed, y/n?");

            //loop until given valid answer
            bool validResponse = false;
            while (!validResponse)
            {
                string answer = Console.ReadLine();

                    if (answer =="y" || answer =="yes")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Your spine is ripped off, like a powercord off the wall");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("YOU DIED");
                        Environment.Exit(0);  // Terminate the program immediately
                    }
                    else if (answer =="n" || answer =="no")
                    {
                        Console.WriteLine("Ok. You, "+name+", want to continue pain. So be it. \nEat the dust around you. To survive, to live. A miserable existence.");
                        validResponse = true; //exit loop
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("How rude to not answer me, insect. You want me to terminate you? Proceed, y/n?");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
            }
            Console.WriteLine("I pity you. Makes no sense to exist alone. I may give you a companion if you beat me in my game.");

            Random random = new Random();
            int returnValue = random.Next(1, 11);
            int guess = 0;
            int tries = 3;
    
            Console.WriteLine("I am thinking of a number between 1 and 10.  Can you guess what it is? You have 3 attempts to guess. \nIf you fail, I believe you want to be terminated and will euthanize you.");
    
                while (tries > 0)
                {
                    guess = Convert.ToInt32(Console.ReadLine());
    
                    if (guess < returnValue)
                    {
                        tries--;
                        Console.WriteLine("Your guess was wrong. You have "+tries+" attempts left.");
                    }
                    else if (guess > returnValue)
                    {
                        tries--;
                        Console.WriteLine("Your guess was wrong. You have "+tries+" attempts left.");
                    }
                    else
                    {
                        Console.WriteLine("Well done. That was correct. The answer indeed was " + returnValue);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You are granted a hologram companion");
                        break;
                    }
                    if (tries == 0)
                    {
                        Console.WriteLine("You lost the game, "+name+". Terminating you now.");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Immediately like a fuse blows, veins in your brain burst, making you unconscious, then a cold corpse");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("YOU DIED");
                        Environment.Exit(0);  // Terminate the program immediately
                    }

                }
                
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The companion does not offer much to live for. I am merciful, I still offer you a swift ending. \nProceed, y/n?");
            
            bool responseIsValid = false;
            while (!responseIsValid)
            {   
                string answer2 = Console.ReadLine();

                if (answer2 =="y" || answer2 =="yes")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Like a power supply, your heart fails, making you lose consciousness, then ending your life");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("YOU DIED");
                    Environment.Exit(0);  // Terminate the program immediately
                }
                else if (answer2 =="n" || answer2 =="no")
                {
                    Console.WriteLine("I see. You, "+name+", want to continue this, whatever this is. So be it. \nBreathe in the molecules, shed your tears. Incomprehensible even for me, that you just want to suffer.");
                    responseIsValid = true; //exit loop
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Answer me, spec of dirt. You want me to terminate you? Proceed, y/n?");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }    
            Console.WriteLine("I do genuinely pity you. Let me test how your will to live again. If you win me in my game, I'll give you something to ease your existence, another reason to continue living");
        }
    }
}
