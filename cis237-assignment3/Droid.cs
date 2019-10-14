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

        public override string ToString()
        {
            return material + ", " + color;
        }

        public abstract void CalculateTotalCost();

        public abstract string GetFormattedCost();

        //******************************
        //Protected Methods
        //******************************

        protected void CalculateBaseCost()
        {
            if(material == "aluminium")
            {
                baseCost = 1000m;
            }
            if (material == "steel")
            {
                baseCost = 2000m;
            }
            if (material == "copper")
            {
                baseCost = 3000m;
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
