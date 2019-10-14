using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Stephanie Amo
// CIS 237
// Due: 10/15/2019

namespace cis237_assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set a constant for the size of the collection
            const int droidCollectionSize = 100;

            // Create an instance of the UserInterface class
            UserInterface userInterface = new UserInterface();

            // Create an instance of the DroidCollection class
            DroidCollection droidCollection = new DroidCollection(droidCollectionSize);

            // Display the Menu and get the response. Store the response in the choice integer
            int choice = userInterface.DisplayMenuAndGetResponse();

            // While the choice is not 3 exit program
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
                                droidCollection.AddNewItem(
                                newProtocolInformation[0],
                                newProtocolInformation[1],
                                int.Parse(newProtocolInformation[2]));
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
                        string allItemsString = droidCollection.ToString();
                        userInterface.DisplayAllItems(allItemsString);
                        break;
                }

                // Get the new choice of what to do from the user
                choice = userInterface.DisplayMenuAndGetResponse();
            }

        }
    }
}
