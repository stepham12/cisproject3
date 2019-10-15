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
    class AstromechDroid : UtilityDroid
    {
        //*****************************
        //Variable / Backing fields
        //*****************************

        private const decimal COST_PER_SHIP = 2000m;
        private bool fireExtinguisher;
        private int numberShips;

        //*****************************
        //Properties
        //*****************************
        public bool FireExtinguisher
        {
            get { return FireExtinguisher; }
            set { fireExtinguisher = value; }
        }

        public int NumberShips
        {
            get { return NumberShips; }
            set { numberShips = value; }
        }

        //******************************
        //Public Methods
        //******************************

        //Return a formatted string containing the variables
        public override string ToString()
        {
            //Re-use the functionality from the parent class to get the color and material
            return "Astromech - " + base.ToString() + fireExtinguisher + ", " + numberShips + ", ";
        }

        //Calculate the totalCost based on the number of languages, and add it to baseCost
        public override void CalculateTotalCost()
        {
            //Calculate base TotalCost for Utility Droid type
            base.CalculateTotalCost();

            //Add cost of Astromech components
            if (fireExtinguisher == true)
            {
                totalCost += COST_PER_ADDITIONAL_ITEM;
            }
            totalCost += (COST_PER_SHIP * numberShips);
            
        }


        //*****************************
        //Constructors
        //*****************************

        public AstromechDroid
            (string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm, bool FireExtinguisher, int NumberShips)
            : base(Material, Color, Toolbox, ComputerConnection, Arm)
        {
            this.material = Material;
            this.color = Color;
            this.toolbox = Toolbox;
            this.computerConnection = ComputerConnection;
            this.arm = Arm;
            this.fireExtinguisher = FireExtinguisher;
            this.numberShips = NumberShips;
        }
    }
}
