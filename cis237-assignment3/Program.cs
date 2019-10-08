using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the UserInterface class
            UserInterface userInterface = new UserInterface();

            // Display the Menu and get the response. Store the response in the choice integer
            int choice = userInterface.DisplayMenuAndGetResponse();

            // While the choice is not exit program
            while (choice != 3)
            {
                switch (choice)
                {
                    case 1:
                        //Add a Droid
                        int droidChoice = userInterface.GetDroidType();

                        //Get user input based on type of Droid
                        switch (droidChoice)
                        {
                            case 1:
                                //Add a Protocol Droid
                                string[] newProtocolInformation = userInterface.GetNewProtocolInformation();
                                break;
                            case 2:
                                //Add a Utility Droid
                                string[] newUtilityInformation = userInterface.GetNewUtilityInformation();
                                break;
                            case 3:
                                //Add a Janitor Droid
                                string[] newJanitorInformation = userInterface.GetNewJanitorInformation();
                                break;
                            case 4:
                                //Add an Astromech Droid
                                string[] newAstromechInformation = userInterface.GetNewAstromechInformation();
                                break;
                        }

                        break;

                    case 2:
                        //Print the List
                        
                        break;
                }

                // Get the new choice of what to do from the user
                choice = userInterface.DisplayMenuAndGetResponse();
            }

        }
    }
}
