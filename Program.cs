using System;

namespace GuessingGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Please press Enter if you would like to play a very simple YET fun game");
            Console.ReadLine();
            System.Console.WriteLine("Please enter your name....");
            string name = Console.ReadLine();
            System.Console.WriteLine($"\n Dear {name}, Welcome to our Guessing Game");
            System.Console.WriteLine($"\n Please make a note of the following rules. \n {name}, you will start with 50 gold!!!!. \n Courtesy of Coding Dojo ---- Seattle. \n {name} but be warned !!!. Every wrong guess will take away 5 gold. \n Lastly, we will not and we mean ABSOLUTELY NOT --------------->>> PAYOUT the gold under any circumstances!!!. \n Now, Let's begin, Guess a number between 1 and 100 and press enter ");
            Random rand = new Random();
            int guess = 0;
            int num = rand.Next(1,100);
            Console.WriteLine("You're a BALLer with 50 gold coins!");
            
 
            int i = 0;
            int gold = 50;
            
            while(guess != num)
            {
                try
                    {
                        guess = Convert.ToInt32(Console.ReadLine());

                        if (guess > 100)
                        {
                            WriteFullLineOutOfRange("Yo Champ!!! Input a number between 1 and 100 not out of the range");
                            Console.WriteLine();
                        }
                        if (guess < 1)
                        {
                            WriteFullLineOutOfRange("Seriously Champ, Once again I will remind, Please input a number BETWEEN 1 and 100 and yes including these as well");
                            Console.WriteLine();
                        }
                        else 
                        {
                            if (guess > num && guess < 101)
                            {
                                WriteFullLineWrong("Too High");
                                Console.WriteLine();
                            }
                            if (guess < num && guess > 0)
                            {
                                WriteFullLineWrong("Too Low");
                                Console.WriteLine();
                            } 
                        }
                    }

                catch
                    {
                        Console.WriteLine("You are a legend!!!, When we create guess the word then we will let you know till then \n just guess a number between 1 and 100 ");
                        i--;

                    }
                
                
                i++;
                gold = gold-5;
                Console.WriteLine("Your total gold now is {0}", gold);

                if (gold == 0)
                {
                    Console.WriteLine("Congrats!!!! You have lost all your money and 'The Cyclops' is now awake and he wants to play with you. \n Don't even bother Legend, just pass the console to next gamer.  ");

                    Console.WriteLine("           _......._");
                    Console.WriteLine("       .-'.'.'.'.'.'.`-.");
                    Console.WriteLine("     .'.'.'.'.'.'.'.'.'.`");
                    Console.WriteLine("    /.'.'               '.|");
                    Console.WriteLine("    |.'    _.--...--._     |");
                    Console.WriteLine("    |    `._.-.....-._.'   |");
                    Console.WriteLine("    |     _..- .-. -.._   |"); 
                    Console.WriteLine(" .-.'    `.   ((@))  .'   '.-.");
                    Console.WriteLine("( ^ |      `--.   .-'     / ^ )");
                    Console.WriteLine(" |  /         .   .       |  /");
                    Console.WriteLine(" /          .'     '.  .-    |");
                    Console.WriteLine("( _.|    | (_`-._.-'_)    /._|)");                                            
                    Console.WriteLine(" `-' |   ' .--.          / `-'");
                    Console.WriteLine("     |  / /|_| `-._.'|   |"); 
                    Console.WriteLine("     |   |       |_| |   /-.._");
                    Console.WriteLine(" _..-|   `.--.______.'  |"); 
                    Console.WriteLine("      |       .....     |");
                    Console.WriteLine("       `.  .'      `.  /");
                    Console.WriteLine("         |           .'");
                    Console.WriteLine("          `-..___..-`");  
                }
            }
            WriteFullLineCorrect("Congrats, it took you " + i + " tries, You know you can do better, Wanna Play Again");
            Console.WriteLine();
            Console.WriteLine(",,,,,,,,,,,,,,,,,,,,,,$$$$");
            Console.WriteLine(",,,,,,,,,,,,,,,,,,,,,,$$$$");
            Console.WriteLine(",,,,,,,,,,,$$$$$$$$$$$$$$$$$");
            Console.WriteLine(",,,,,,,$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine(",,,,,$$$$$$$,,,,,,,$$$$,,,,$$$$$$$$");
            Console.WriteLine(",,,$$$$$$,,,,,,,,,,$$$$,,,,,,,,$$$$$$$");
            Console.WriteLine(",,$$$$$$,,,,,,,,,,,$$$$,,,,,,,,,,$$$$$$");
            Console.WriteLine(",,$$$$$$,,,,,,,,,,,$$$$");
            Console.WriteLine(",,$$$$$$,,,,,,,,,,,$$$$");
            Console.WriteLine(",,,$$$$$$,,,,,,,,,,$$$$");
            Console.WriteLine(",,,,$$$$$$$$,,,,,,$$$$");
            Console.WriteLine(",,,,,,$$$$$$$$$$$$$$$");
            Console.WriteLine(",,,,,,,,,,$$$$$$$$$$$$$$$$$$");
            Console.WriteLine(",,,,,,,,,,,,,,,,,$$$$$$$$$$$$$$$$");
            Console.WriteLine(",,,,,,,,,,,,,,,,,,,,,,$$$$,$$$$$$$$$$");
            Console.WriteLine(",,,,,,,,,,,,,,,,,,,,,,$$$$,,,,,,,$$$$$$$");
            Console.WriteLine(",,,,,,,,,,,,,,,,,,,,,,$$$$,,,,,,,,,,$$$$$$");
            Console.WriteLine(",,,,,,,,,,,,,,,,,,,,,,$$$$,,,,,,,,,,,$$$$$$");
            Console.WriteLine("$$$$$$$,,,,,,,,,,,,$$$$,,,,,,,,,,$$$$$$$");
            Console.WriteLine(",$$$$$$,,,,,,,,,,,,$$$$,,,,,,,,,,$$$$$$$");
            Console.WriteLine(",,$$$$$$$,,,,,,,,,,$$$$,,,,,,,,$$$$$$$$");
            Console.WriteLine(",,,$$$$$$$$,,,,,,,$$$$,,,,,,$$$$$$$$");
            Console.WriteLine(",,,,,,$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine(",,,,,,,,,,$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine(",,,,,,,,,,,,,,,,,,$$$$$$$$");
            Console.WriteLine(",,,,,,,,,,,,,,,,,,,,,,$$$$");
            Console.WriteLine(",,,,,,,,,,,,,,,,,,,,,,$$$$");
        }

        static void WriteFullLineWrong(string value)
        {
        //
        // This method writes an entire line to the console with the string.
        //
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(value.PadRight(Console.WindowWidth - 1)); // <-- see note
        //
        // Reset the color.
        //
        Console.ResetColor();
        }
        static void WriteFullLineGold(string value)
        {
        //
        // This method writes an entire line to the console with the string.
        //
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(value.PadRight(Console.WindowWidth - 1)); // <-- see note
        //
        // Reset the color.
        //
        Console.ResetColor();
        }
        static void WriteFullLineCorrect(string value)
        {
        //
        // This method writes an entire line to the console with the string.
        //
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(value.PadRight(Console.WindowWidth - 1)); // <-- see note
        //
        // Reset the color.
        //
        Console.ResetColor();
        }
        static void WriteFullLineOutOfRange(string value)
        {
        //
        // This method writes an entire line to the console with the string.
        //
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(value.PadRight(Console.WindowWidth - 1)); // <-- see note
        //
        // Reset the color.
        //
        Console.ResetColor();
        }

        // static void ReduceGold()
        // {
        //     int totalgold = 50;
        //     int yourgold = totalgold - 5;
        //     totalgold = totalgold - 5;
        //     Console.WriteLine("Your total gold now is {0}", yourgold);        
        // }
    }
}