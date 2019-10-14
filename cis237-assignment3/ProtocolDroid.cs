using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class ProtocolDroid : Droid
    {
        //*****************************
        //Variable / Backing fields
        //*****************************

        private int numberLanguages;
        private const decimal COST_PER_LANGUAGE = 500m; 


        //*****************************
        //Properties
        //*****************************
        public int NumberLanguages
        {
            get { return numberLanguages; }
            set { numberLanguages = value; }
        }

        //******************************
        //Public Methods
        //******************************

        // Calculate TotalCost, then format and return it.
        public override string GetFormattedCost()
        {
            CalculateTotalCost();
            return TotalCost.ToString("C");
        }

        //Return a formatted string containing the variables
        public override string ToString()
        {
            //Re-use the functionality from the parent class to get the color and material
            return "Protocol, " + base.ToString() + ", " + numberLanguages + ", ";
        }

        //Calculate the totalCost based on the number of languages, and add it to baseCost
        public override void CalculateTotalCost()
        {
            CalculateBaseCost();
            totalCost = baseCost + (numberLanguages * COST_PER_LANGUAGE);
        }


        //*****************************
        //Constructors
        //*****************************

        public ProtocolDroid(string Material, string Color, int NumberLanguages) : base(Material, Color)
        {
            this.material = Material;
            this.color = Color;
            this.numberLanguages = NumberLanguages;
        }

    }
}
