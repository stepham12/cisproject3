using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Add a new item to the collection
        public void AddNewItem(
            string material,
            string color,
            int numberLanguages)
        {
            // Add a new ProtocolDroid to the collection. Increase the Length variable.
            droids[droidLength] = new ProtocolDroid(material, color, numberLanguages);
            droidLength++;
        }

        // ToString override method to convert the collection to a string
        public override string ToString()
        {
            // Declare a return string
            string returnString = "";

            // Loop through all of the beverages
            foreach (Droid droid in droids)
            {
                // If the current beverage is not null, concat it to the return string
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
