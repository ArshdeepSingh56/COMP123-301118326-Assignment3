using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_301118326_Assignment3
{
    // The GiantPlant class is the subclass of plant class
    //The class has two public methods.
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type;

        
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

       
        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

       // The CONTRUCTOR have four arguments 
        public GiantPlanet(string name, double diameter, double mass, string type) :
            base(name, diameter, mass)
        {

            this._type = type;


        }
    }
}