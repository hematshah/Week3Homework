using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkExceptionHandeling
{
   public class GameChoice
    {

       
        private string choiceOne; 
        private string choiceTwo;
        private string choiceThree;
        private string yourChoice; 
        private string chooseOneOfTheOPtions ;
        private int choiceSelection;

        public GameChoice() 
        { 
        }


        public void MakeYourChoice() 
        {
            
            choiceOne = "Monster On the Run";
            choiceTwo = "Alien Investation";
            choiceThree = "Stack The Tiles";

            try
            {

                Console.WriteLine("Hi this is your GameDeveloper Speaking");
                Console.WriteLine("I have great Ideas for my next game but I cannot decide which one to go with");
                Console.WriteLine("Can you help me ? ");
                yourChoice = Console.ReadLine();

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            try
            {

                if (yourChoice == "yes" | yourChoice == "Yes")
                {
                    while (yourChoice == "yes" | yourChoice == "Yes")
                    {
                        try
                        {
                            Console.WriteLine("Great, These are my following choices ?\n First one is: {0}\n Second one is: {1}\n Final one is: {2}\n" +
                            "Please choose one of the three options presented to you ", choiceOne, choiceTwo, choiceThree);
                            chooseOneOfTheOPtions = Console.ReadLine();
                            choiceSelection = Int32.Parse(chooseOneOfTheOPtions);



                            switch (choiceSelection)
                            {
                                case 1:
                                    Console.WriteLine("You have chosen Option number {0}:\n{1} ", choiceSelection, choiceOne);
                                    break;
                                case 2:
                                    Console.WriteLine("You have chosen Option number {0}:\n{1} ", choiceSelection, choiceTwo);
                                    break;
                                case 3:
                                    Console.WriteLine("You have chosen Option number {0}:\n{1} ", choiceSelection, choiceThree);
                                    break;
                                default:
                                    Console.WriteLine("Sorry but the option {0} that you have chosen does not exist ", choiceSelection);
                                    break;
                            }

                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (IndexOutOfRangeException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        

                        Console.WriteLine("Do you want to choose again? ");
                        yourChoice = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Ah bummer I have to make the choice my self then");
                    Console.WriteLine("I will be asking you again");
                    Console.ReadLine();


                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            
        }
        

    }
}
