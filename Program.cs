using System;       // Uppg09_ITA20_ElinI_Rock_Paper_Scissors_Game

namespace ITA20_C_09GameRepo
{
    class Program
    {
        static int computerAnswer;
        static int userAnswer;
        static string keyLetter;  

        static void Main(string[] args)
        {



            do
            {
                computerAnswer = RandomComputerAnswer();

                Console.WriteLine("\nDo you want to play/ do you want another try [y for yes]? or Do you want to quit [q]?: ");
                keyLetter = Console.ReadLine();

                if (keyLetter == "y")
                {
                    Console.WriteLine("What is your choice [-1- for rock, -2- for paper or -3- for scissors]:");
                    keyLetter = Console.ReadLine();


                        //OBS! 2>1 3>2 men 1>3(3<1)

                    Console.WriteLine("Let's see who won! [press g for go]."); 
                    keyLetter = Console.ReadLine();
                    if (keyLetter == "g")
                    {
                        if (computerAnswer == 1 || computerAnswer == 2)
                        {
                            if (userAnswer > computerAnswer)
                            {
                                Console.WriteLine("YOU won! ");
                            }
                            else if (userAnswer < computerAnswer)
                            {
                                Console.WriteLine("Sorry, computer won. ");
                            }
                            else if (userAnswer == computerAnswer)
                            {
                                Console.WriteLine("Both won! ...Draw. ");
                            }
                            else
                            {
                                Console.WriteLine("Something must have gone wonky? [press any key() to try again]:");   //If unsuspected action, redo
                                Console.ReadKey();
                            }
                        }
                        else if (computerAnswer == 3)            //OBS! 2>1 3>2 but 1>3(3<1) Sign inversed
                        {
                            if (userAnswer < computerAnswer)
                            {
                                Console.WriteLine("YOU won! ");
                            }
                            else if (userAnswer > computerAnswer)
                            {
                                Console.WriteLine("Sorry, computer won. ");
                            }
                            else if (userAnswer == computerAnswer)
                            {
                                Console.WriteLine("Both won! ...Draw. ");
                            }
                            else
                            {
                                Console.WriteLine("Something must have gone wonky? [press any key() to try again]:");  //If unsuspected action, redo
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Something must have gone wonky? [press any key() to try again]:");   //If unsuspected action, redo
                            Console.ReadKey();
                        }


                    }
                }
                else if (keyLetter == "q")                              //Possible to get out of the loop, quit
                {
                    Console.WriteLine("\nThis is the final score... (drum roll...) ");
                    Console.ReadKey();
                    Environment.Exit(0);
                }


                static int RandomComputerAnswer()                                                       //Function/Method Slumpgenerator
                {
                    Random computerSuggestion = new Random();
                    int computer_Answer = computerSuggestion.Next(1, 4);

                    return computer_Answer;
                }


            }
            while (keyLetter != "q");
            Console.ReadLine();





        }
    }
}
