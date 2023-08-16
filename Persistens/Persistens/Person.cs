using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class Person
    {
        // Field
        private string name;
        private DateTime birthDate;
        private double height;
        private bool isMarried;
        private int noOfChildren;

        // Properties
        public string Name 
        { 
            get 
            { 
                return name; 
            } 
            set 
            {
                if (value == "")
                {
                    throw new Exception("Fejl");
                }
                else
                {
                    name = value;
                }
            } 
        }

        public DateTime BirthDate 
        { 
            get 
            { 
                return birthDate; 
            } 
            set 
            {
                DateTime limit = new DateTime(1900, 1, 1);
                if (value < limit)
                {
                    throw new Exception("Fuck off");
                }
                else
                {
                    birthDate = value;
                }
            } 
        }

        public double Height 
        {   
            get 
            { 
                return height; 
            } 
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("Fejl");
                }
                else
                {
                    height = value;
                }
            } 
        }

        public bool IsMarried { get { return isMarried; } set { isMarried = value; } }
        public int NoOfChildren 
        { 
            get 
            { 
                return noOfChildren; 
            } 
            set 
            {
                if (value < 0)
                {
                    throw new Exception("Fejl");
                }
                else
                {
                    noOfChildren = value;
                }
            } 
        }

        /// <summary>
        /// Person constructor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthDate"></param>
        /// <param name="height"></param>
        /// <param name="isMarried"></param>
        /// <param name="noOfChildren"></param>
        public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
        {
            Name = name;
            BirthDate = birthDate;
            Height = height;
            IsMarried = isMarried;
            NoOfChildren = noOfChildren;
        }
        public Person(string name, DateTime birthDate, double height, bool isMarried) : this (name, birthDate, height, isMarried, 0)
        {
        }

        /// <summary>
        /// A method which will return the information of a person, the space between each marked by ";".
        /// </summary>
        /// <returns> The properties connected to the object person. </returns>
        public string MakeTitle()
        {
            return Name + ";" + BirthDate + ";" + Height + ";" + IsMarried + ";" + NoOfChildren;
        }
    }
}
