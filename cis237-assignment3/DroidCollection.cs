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
    class DroidCollection
    {
        // Private Variables
        private Droid[] droids;
        private int droidLength;

        // Constructor to pass the size of the collection.
        public DroidCollection(int size)
        {
            this.droids = new Droid[size];
            this.droidLength = 0;
        }

        // Add a new ProtocolDroid to the collection
        public void AddNewItem(
            string material,
            string color,
            int numberLanguages)
        {
            // Add a new ProtocolDroid to the collection. Increase the Length variable.
            droids[droidLength] = new ProtocolDroid(material, color, numberLanguages);
            droidLength++;
        }

        // Add a new UtilityDroid to the collection
        public void AddNewItem(
            string material,
            string color,
            bool toolbox,
            bool computerConnection,
            bool arm)
        {
            // Add a new UtilityDroid to the collection. Increase the Length variable.
            droids[droidLength] = new UtilityDroid(material, color, toolbox, computerConnection, arm);
            droidLength++;
        }

        // Add a new JanitorDroid to the collection
        public void AddNewItem(
            string material,
            string color,
            bool toolbox,
            bool computerConnection,
            bool arm,
            bool trashCompactor,
            bool vacuum)
        {
            // Add a new JanitorDroid to the collection. Increase the Length variable.
            droids[droidLength] = new JanitorDroid(material, color, toolbox, computerConnection, arm, trashCompactor, vacuum);
            droidLength++;
        }

        // Add a new AstromechDroid to the collection
        public void AddNewItem(
            string material,
            string color,
            bool toolbox,
            bool computerConnection,
            bool arm,
            bool fireExtinguisher,
            int numberShips)
        {
            // Add a new AstromechDroid to the collection. Increase the Length variable.
            droids[droidLength] = new AstromechDroid(material, color, toolbox, computerConnection, arm, fireExtinguisher, numberShips);
            droidLength++;
        }

        // ToString override method to convert the collection to a string
        public override string ToString()
        {
            // Declare a return string
            string returnString = "";

            // Loop through all of the droids
            foreach (Droid droid in droids)
            {
                // If the current droid is not null, concat it to the return string
                if (droid != null)
                {
                    returnString += droid.ToString() + droid.GetFormattedCost() + Environment.NewLine;
                }
            }
            // Return the return string
            return returnString;
        }

    }
}
