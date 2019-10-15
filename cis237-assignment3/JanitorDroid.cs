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
    class JanitorDroid : UtilityDroid
    {
        //*****************************
        //Variable / Backing fields
        //*****************************

        private bool trashCompactor;
        private bool vacuum;

        //*****************************
        //Properties
        //*****************************
        public bool TrashCompactor
        {
            get { return TrashCompactor; }
            set { trashCompactor = value; }
        }

        public bool Vacuum
        {
            get { return Vacuum; }
            set { vacuum = value; }
        }

        //******************************
        //Public Methods
        //******************************

        //Return a formatted string containing the variables
        public override string ToString()
        {
            //Re-use the functionality from the parent class to get the color and material
            return "Janitor - " + base.ToString() + trashCompactor + ", " + vacuum + ", ";
        }

        //Calculate the totalCost based on the number of languages, and add it to baseCost
        public override void CalculateTotalCost()
        {
            //Calculate base TotalCost for Utility Droid type
            base.CalculateTotalCost();

            //Add cost of Janitor components
            if (trashCompactor == true)
            {
                totalCost += COST_PER_ADDITIONAL_ITEM;
            }
            if (vacuum == true)
            {
                totalCost += COST_PER_ADDITIONAL_ITEM;
            }
        }


        //*****************************
        //Constructors
        //*****************************

        public JanitorDroid
            (string Material, string Color, bool Toolbox, bool ComputerConnection, bool Arm, bool TrashCompactor, bool Vacuum) 
            : base(Material, Color, Toolbox, ComputerConnection, Arm)
        {
            this.material = Material;
            this.color = Color;
            this.toolbox = Toolbox;
            this.computerConnection = ComputerConnection;
            this.arm = Arm;
            this.trashCompactor = TrashCompactor;
            this.vacuum = Vacuum;
        }
    }
}
