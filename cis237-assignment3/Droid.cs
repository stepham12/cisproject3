using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment3
{
    public abstract class Droid
    {
        //*****************************
        //Variable / Backing fields
        //*****************************
        protected string material;
        protected string color;
        protected decimal baseCost;
        protected decimal totalCost;


        //*****************************
        //Properties
        //*****************************
        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = TotalCost; }
        }

        //******************************
        //Public Methods
        //******************************

        //Return a formatted string containing the variables
        public override string ToString()
        {
            return material + ", " + color;
        }

        //Calculate Total Cost, to be overridden in derived classes
        public abstract void CalculateTotalCost();

        //Obtain Formatted Cost, to be overridden in derived classes
        public abstract string GetFormattedCost();

        //******************************
        //Protected Methods
        //******************************

        //Calculate Base Cost based on material
        protected void CalculateBaseCost()
        {
            if(material == "aluminium")
            {
                baseCost = 2000m;
            }
            if (material == "steel")
            {
                baseCost = 4000m;
            }
            if (material == "copper")
            {
                baseCost = 6000m;
            }
        }

        //*****************************
        //Constructors
        //*****************************
        public Droid(string Material, string Color)
        {
            this.material = Material;
            this.color = Color;
        }

    }
}
