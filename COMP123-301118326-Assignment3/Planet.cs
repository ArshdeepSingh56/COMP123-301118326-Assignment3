using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_301118326_Assignment3
{   
    //This is the abstract class or a parent class for all the planets 
    public abstract class Planet
    {
        private double m_diameter;
        private double m_mass;
        private int m_moonCount;
        private string m_name;
        private double m_orbitalPeriod;
        private int m_ringCount;
        private double m_rotationPeriod;


      // These are the public properities

        public double Diameter
        {
            get
            {
               return  m_diameter;
            }
        }

        public double Mass
        {
            get { return m_mass; }
        }

        public int MoonCount
        {
            get { return m_moonCount; }
            set
            {
                m_moonCount = value;
            }
           
        }

        public string Name
        {
            get => m_name;
        }

        public double OrbitalPeriod
        {
            get { return m_orbitalPeriod; }
            set
            {
                m_orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get { return m_ringCount; }
        
            set
            {
                m_ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get { return m_rotationPeriod; }
            set
            {
                m_rotationPeriod = value;
            }
        }



         //CONSTRUCTORS
       
        public Planet(string name, double diameter, double mass)
        {

            this.m_name = name;
            this.m_diameter = diameter;
            this.m_mass = mass;

        }

        // This is the public override method
        public override string ToString()
        {
            return $"Name: {Name}, Diameter: {Diameter}, Mass: {Mass}";
        }
    }
}
