using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersPractice
{
    class CellPhone
    {
        private string manufacturer;
            private int diagonalDimensions;
            private bool touchScreen = true;

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public bool TouchScreen
        {
            get { return this.touchScreen; }
            set { this.touchScreen = value; }
        }

        public static void ManufacturerName()
        {
            Console.WriteLine("You have a " +  manufacturer + "phone!");
        }
    }
}
