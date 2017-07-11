using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersPractice
{
    class Boat
    {
        //SO far we've done fields as private, but we can do them as public
        public int numberOfPassengers;

        //Most of the time, though, we want our fields to be private
        private string name;
        private string engineSize;

        //Properties almost always have public as their access modifier
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //Constructors always have a public access modifier
        public Boat()
        {
            //this is my default constructor
        }

    }
}
