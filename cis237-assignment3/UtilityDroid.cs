using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    class UtilityDroid : Droid
    {
        //*****************************
        //Variable / Backing fields
        //*****************************

        private const decimal COST_PER_ADDITIONAL_ITEM = 750m;
        private bool toolbox;
        private bool computerConnection;
        private bool arm;


        //*****************************
        //Properties
        //*****************************
        public bool Toolbox
        {
            get { return Toolbox; }
            set { toolbox = value; }
        }

        public bool ComputerConnection
        {
            get { return ComputerConnection; }
            set { computerConnection = value; }
        }

        public bool Arm
        {
            get { return Arm; }
            set { arm = value; }
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
            return "Utility, " + base.ToString() + ", " + toolbox + ", " + computerConnection + ", " + arm + ", ";
        }

        //Calculate the totalCost based on the number of languages, and add it to baseCost
        public override void CalculateTotalCost()
        {
            CalculateBaseCost();

            totalCost = baseCost;

            //If user selects yes, each item's cost is added to base cost
            if(toolbox==true)
            {
                totalCost += COST_PER_ADDITIONAL_ITEM;
            }
            if(computerConnection==true)
            {
                totalCost += COST_PER_ADDITIONAL_ITEM;
            }
            if(arm==true)
            {
                totalCost += COST_PER_ADDITIONAL_ITEM;
            }
        }


        //*****************************
        //Constructors
        //*****************************

        public UtilityDroid
            (string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm) : base(Material, Color)
        {
            this.material = Material;
            this.color = Color;
            this.toolbox = Toolbox;
            this.computerConnection = ComputerConnection;
            this.arm = Arm;
        }
    }
}
