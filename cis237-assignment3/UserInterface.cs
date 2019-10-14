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
    class UserInterface
    {
        /*
        |----------------------------------------------------------------------
        | Public Methods
        |----------------------------------------------------------------------
        */

        // Display Menu And Get Response
        public int DisplayMenuAndGetResponse()
        {
            // Declare variable to hold the selection
            string selection;

            // Display menu, and prompt
            this.DisplayMenu();
            this.DisplayPrompt();

            // Get the selection they enter
            selection = this.GetSelection();

            // While the response is not valid
            while (!this.VerifySelectionIsValid(selection))
            {
                // Display error message
                this.DisplayErrorMessage();

                // Display the prompt again
                this.DisplayPrompt();

                // Get the selection again
                selection = this.GetSelection();
            }
            // Return the selection casted to an integer
            return Int32.Parse(selection);
        }

        //Get Droid Type
        public int GetDroidType()
        {
            // Declare variable to hold the selection
            string droidSelection;

            // Display menu, and prompt
            this.DisplayDroidMenu();
            this.DisplayPrompt();

            // Get the selection they enter
            droidSelection = this.GetSelection();

            // While the response is not valid
            while (!this.VerifyDroidSelectionIsValid(droidSelection))
            {
                // Display error message
                this.DisplayErrorMessage();

                // Display the prompt again
                this.DisplayPrompt();

                // Get the selection again
                droidSelection = this.GetSelection();
            }
            // Return the selection casted to an integer
            return Int32.Parse(droidSelection);

        }

        public string[] GetNewProtocolInformation()
        {
            string material = this.GetMaterialStringField("Material");
            string color = this.GetStringField("Color");
            string numberLanguages = this.GetIntegerField("Number of Languages");

            return new string[] { material, color, numberLanguages };
        }

        public string[] GetNewUtilityInformation()
        {
            string material = this.GetMaterialStringField("Material");
            string color = this.GetStringField("Color");
            string toolbox = this.GetBoolField("A Toolbox");

            return new string[] { material, color, toolbox };
        }

        public string[] GetNewJanitorInformation()
        {
            string material = this.GetMaterialStringField("Material");
            string color = this.GetStringField("Color");
            string toolbox = this.GetBoolField("A Toolbox");
            string trashCompactor = this.GetBoolField("A Trash Compactor");
            string vacuum = this.GetBoolField("A Vacuum");

            return new string[] { material, color, toolbox, trashCompactor, vacuum };
        }

        public string[] GetNewAstromechInformation()
        {
            string material = this.GetMaterialStringField("Material");
            string color = this.GetStringField("Color");
            string toolbox = this.GetBoolField("A Toolbox");
            string fireExtinguisher = this.GetBoolField("A Fire Extinguisher");
            string numberShips = this.GetIntegerField("Number of Ships");

            return new string[] { material, color, toolbox, fireExtinguisher, numberShips };
        }

        // Display All Items
        public void DisplayAllItems(string allItemsOutput)
        {
            Console.WriteLine();
            Console.WriteLine("List of Droids");
            Console.WriteLine();
            Console.WriteLine(allItemsOutput);
        }

        /*
        |----------------------------------------------------------------------
        | Private Methods
        |----------------------------------------------------------------------
        */

        // Display the Menu
        private void DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("1. Add a new Droid");
            Console.WriteLine("2. Print The Entire List Of Droids");
            Console.WriteLine("3. Exit Program");
        }

        // Display the Droid Menu
        private void DisplayDroidMenu()
        {
            Console.WriteLine();
            Console.WriteLine("What type of Droid would you like to add?");
            Console.WriteLine();
            Console.WriteLine("1. Protocol");
            Console.WriteLine("2. Utility");
            Console.WriteLine("3. Janitor");
            Console.WriteLine("4. Astromech");
        }

        // Display the Prompt
        private void DisplayPrompt()
        {
            Console.WriteLine();
            Console.Write("Enter Your Choice: ");
        }

        // Display the Error Message
        private void DisplayErrorMessage()
        {
            Console.WriteLine();
            Console.WriteLine("That is not a valid option. Please make a valid choice");
        }

        // Get the selection from the user
        private string GetSelection()
        {
            return Console.ReadLine();
        }

        // Verify that a selection from the main menu is valid
        private bool VerifySelectionIsValid(string selection)
        {
            // Declare a returnValue and set it to false
            bool returnValue = false;

            try
            {
                // Parse the selection into a choice variable
                int choice = Int32.Parse(selection);

                // If the choice is 1, 2, or 3
                if (choice == 1 || choice == 2 || choice == 3)
                {
                    // Set the return value to true
                    returnValue = true;
                }
            }
            // If the selection is not a valid number, this exception will be thrown
            catch (Exception e)
            {
                // Set return value to false even though it should already be false
                returnValue = false;
            }

            // Return the reutrnValue
            return returnValue;
        }

        // Verify that a selection from the droid menu is valid
        private bool VerifyDroidSelectionIsValid(string selection)
        {
            // Declare a returnValue and set it to false
            bool returnValue = false;

            try
            {
                // Parse the selection into a choice variable
                int choice = Int32.Parse(selection);

                // If the choice is 1, 2, 3, or 4
                if (choice == 1 || choice == 2 || choice == 3 || choice == 4)
                {
                    // Set the return value to true
                    returnValue = true;
                }
            }
            // If the selection is not a valid number, this exception will be thrown
            catch (Exception e)
            {
                // Set return value to false even though it should already be false
                returnValue = false;
            }

            // Return the reutrnValue
            return returnValue;
        }

        // Get a valid string field from the console
        private string GetStringField(string fieldName)
        {
            Console.WriteLine("What is the new Item's {0}", fieldName);
            string value = null;
            bool valid = false;
            while (!valid)
            {
                value = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(value))
                {
                    valid = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must provide a value.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("What is the new Item's {0}", fieldName);
                    Console.Write("> ");
                }
            }
            return value;
        }

        // Get a valid string field for material option from the console
        private string GetMaterialStringField(string fieldName)
        {
            Console.WriteLine("What is the new Item's {0}", fieldName);
            Console.WriteLine("Options are: aluminum, steel, or copper.");
            string value = null;
            bool valid = false;
            while (!valid)
            {
                value = Console.ReadLine();
                if (value.ToLower() == "aluminum" || value.ToLower() == "steel" || value.ToLower() == "copper")
                {
                    valid = true;
                    value = value.ToLower();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must provide a valid option.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("What is the new Item's {0}", fieldName);
                    Console.Write("> ");
                }
            }
            return value;
        }

        // Get a valid integer field from the console
        private string GetIntegerField(string fieldName)
        {
            Console.WriteLine("What is the new Item's {0}", fieldName);
            decimal value = 0;
            bool valid = false;
            while (!valid)
            {
                try
                {
                    value = int.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid Decimal. Please enter a valid Decimal.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("What is the new Item's {0}", fieldName);
                    Console.Write("> ");
                }
            }

            return value.ToString();
        }

        // Get a valid bool field from the console
        private string GetBoolField(string fieldName)
        {
            Console.WriteLine("Should the Item be {0} (y/n)", fieldName);
            string input = null;
            bool value = false;
            bool valid = false;
            while (!valid)
            {
                input = Console.ReadLine();
                if (input.ToLower() == "y" || input.ToLower() == "n")
                {
                    valid = true;
                    value = (input.ToLower() == "y");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid Entry.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    Console.WriteLine("Should the Item be {0} (y/n)", fieldName);
                    Console.Write("> ");
                }
            }
            return input;
        }
    }
}
