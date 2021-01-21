using System;       // Uppg09_ITA20_ElinI_Rock_Paper_Scissors_Game

namespace ITA20_C_09GameRepo
{
    class Program
    {
        static void Main(string[] args)
        {



            do
            {
                Console.WriteLine("Please, enter the name of the product article you want to add (if you want to add some): \nWhen you are finished or just want to finish off, please, type -f- for finished\n");


                        //OBS! 2>1 3>2 men 1>3(3<1)



            Console.WriteLine("Do you want another try [y/n]: ");                 //Om spelarens svar är ja på nytt försök, omslag.
            keybLetter = Console.ReadLine();
            {
                if (keybLetter == "y")
                {
                    Console.WriteLine("This is your new tot roll: " + retotdice_usrResultSum);
                    Console.WriteLine();
                    Console.WriteLine("Let's see who won! [press g]");            //Början på svar om vem som vann
                    keybLetter = Console.ReadLine();
                    if (keybLetter == "g")
                    {                                            //lite fusk, ...lite lat... har eg inte tydliggjort villkor för att gå vidare, dvs else                               
                        Console.WriteLine();

                        if (retotdice_usrResultSum > totdice_cmptrResultSum)
                        {
                            Console.WriteLine("YOU won! ");
                        }
                        else if (retotdice_usrResultSum < totdice_cmptrResultSum)
                        {
                            Console.WriteLine("Sorry, computer won. ");
                        }
                        else if (retotdice_usrResultSum == totdice_cmptrResultSum)
                        {
                            Console.WriteLine("Sorry, computer won, just kiddin' ...Draw. ");
                        }
                        else
                        {
                            Console.WriteLine("Do you want to try again or stop? [press whatever key(s)]: ");   //Fråga för att gå vidare eller avsluta
                            keybLetter = Console.ReadLine();
                        }
                    }
                }
                else if (keybLetter == "n")                                   //Om spelaren svarar nej på omslag tärning (dvs. nytt försök)
                {
                    Console.WriteLine();
                    Console.WriteLine("Let's see who won! [press g]");
                    keybLetter = Console.ReadLine();
                    if (keybLetter == "g")

                        if (totdice_usrResultSum > totdice_cmptrResultSum)        //Början på svar om vem som vann
                        {
                            Console.WriteLine("YOU won! ");
                        }
                        else if (totdice_usrResultSum < totdice_cmptrResultSum)
                        {
                            Console.WriteLine("Sorry, computer won. ");
                        }
                        else if (totdice_usrResultSum == totdice_cmptrResultSum)
                        {
                            Console.WriteLine("Sorry, computer won, just kiddin' ...Draw. ");
                        }
                        else
                        {
                            Console.WriteLine("Do you want to try again (more fun, concuer the computer!) or stop? [press whatever key(s)]: ");   //Fråga för att gå vidare eller avsluta
                            keybLetter = Console.ReadLine();
                        }
                }
                else
                {
                    Console.WriteLine("Sorry, wrong letter, try again or stop? [press whatever key(s)]: ");     //Fråga för att gå vidare eller avsluta.  ([y/n]. (In case/when you want to stop or continue? [press c/s]): ")
                    keybLetter = Console.ReadLine();
                }
            }
            Console.ReadKey();
        }





            }
            while (productArticleorKeyboardletter != "f");
            Console.ReadLine();

        static int Playdice()                                                       //Funktion/Metod Slumpgeneratorn
        {
            Random dicedotSuggester = new Random();
            int dice_Result = dicedotSuggester.Next(1, 7);

            return dice_Result;
        }




        }
    }
}
