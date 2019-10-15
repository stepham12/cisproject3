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

            // While loop for when choice is not 3(which is exit)
            while (choice != 3)
            {
                //Deterine action based on user choice
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
                                droidCollection.AddNewItem(
                                newUtilityInformation[0],
                                newUtilityInformation[1],
                                bool.Parse(newUtilityInformation[2]),
                                bool.Parse(newUtilityInformation[3]),
                                bool.Parse(newUtilityInformation[4]));
                                break;
                            case 3:
                                //Add a Janitor Droid
                                string[] newJanitorInformation = userInterface.GetNewJanitorInformation();
                                droidCollection.AddNewItem(
                                newJanitorInformation[0],
                                newJanitorInformation[1],
                                bool.Parse(newJanitorInformation[2]),
                                bool.Parse(newJanitorInformation[3]),
                                bool.Parse(newJanitorInformation[4]),
                                bool.Parse(newJanitorInformation[5]),
                                bool.Parse(newJanitorInformation[6]));
                                break;
                            case 4:
                                //Add an Astromech Droid
                                string[] newAstromechInformation = userInterface.GetNewAstromechInformation();
                                droidCollection.AddNewItem(
                                newAstromechInformation[0],
                                newAstromechInformation[1],
                                bool.Parse(newAstromechInformation[2]),
                                bool.Parse(newAstromechInformation[3]),
                                bool.Parse(newAstromechInformation[4]),
                                bool.Parse(newAstromechInformation[5]),
                                int.Parse(newAstromechInformation[6]));
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
