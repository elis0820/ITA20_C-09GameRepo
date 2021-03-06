﻿using System;       // Uppg09_ITA20_ElinI_Rock_Paper_Scissors_Game

namespace ITA20_C_09GameRepo
{
    class Program
    {
        static int computerAnswer;
        static int userAnswer;
        static string keyLetter;

        static void Main(string[] args)
        {
            int scoreCounterUser = 0;                                                    //Reset score after game is over.
            int scoreCounterComputer = 0;


            do
            {
                computerAnswer = RandomComputerAnswer();

                Console.WriteLine("\nDo you want to play/ do you want another try [y for yes]? or Do you want to quit [q]?: ");
                keyLetter = Console.ReadLine();

                if (keyLetter == "y")
                {
                    Console.WriteLine("What is your choice [-r- for rock, -p- for paper or -s- for scissors]:");
                    keyLetter = Console.ReadLine();

                    if (keyLetter == "r")                                               //Convert from letter to number.
                    {
                        userAnswer = 1;
                    }
                    else if (keyLetter == "p")
                    {
                        userAnswer = 2;
                    }
                    else
                    {
                        userAnswer = 3;
                    }

                    Console.WriteLine("Let's see who won! [press g for go].");
                    keyLetter = Console.ReadLine();
                    if (keyLetter == "g")
                    {
                        if (computerAnswer == 1 || computerAnswer == 2)
                        {
                            if (userAnswer > computerAnswer)
                            {
                                Console.WriteLine("YOU won! ");
                                int score = scoreCounterUser++;                           //Scorecounter
                            }
                            else if (userAnswer < computerAnswer)
                            {
                                Console.WriteLine("Sorry, computer won. ");
                                int score = scoreCounterComputer++;
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
                        else if (computerAnswer == 3)                                   //OBS! 2>1 3>2 but 1>3(3<1) Sign inversed
                        {
                            if (userAnswer < computerAnswer)
                            {
                                Console.WriteLine("YOU won! ");
                                int score = scoreCounterUser++;
                            }
                            else if (userAnswer > computerAnswer)
                            {
                                Console.WriteLine("Sorry, computer won. ");
                                int score = scoreCounterComputer++;
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
                else if (keyLetter == "q")                                              //Possible to get out of the loop, quit
                {
                    Console.WriteLine("\nThis is the final result:  -'Did you win...or the computer?'... (drum roll...) ");
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(2300);                                //Paus, delay before final answer                  
                                                                                        //Console.WriteLine("\nYour points: " + scoreCounterUser + " Computers points: " + scoreCounterComputer);

                    if (scoreCounterUser > scoreCounterComputer)
                    {
                        Console.WriteLine("\nYour points - Computers points:     " + scoreCounterUser + " - " + scoreCounterComputer + "     - 'YOU won! Congrats!!' ");
                    }
                    else if (scoreCounterUser < scoreCounterComputer)
                    {
                        Console.WriteLine("\nYour points - Computers points:     " + scoreCounterUser + " - " + scoreCounterComputer + "     - 'Meh!  (= Computer won)' ");
                    }
                    else if (scoreCounterUser == scoreCounterComputer)
                    {
                        Console.WriteLine("\nYour points - Computers points:     " + scoreCounterUser + " - " + scoreCounterComputer + "     - 'Boring!! ...Draw.' ");
                    }

                    Console.WriteLine();
                    Console.WriteLine("\nThank you for playing! Bye & have a nice day! Press any key to finish.");
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
