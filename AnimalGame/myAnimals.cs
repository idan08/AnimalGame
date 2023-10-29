using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    [Serializable]
    internal class myAnimals
    {
        public List<Animal> animals; //list of all animals
        public myAnimals() //constructor
        {
            animals = new List<Animal>();
        }
        public myAnimals(myAnimals other) //copy constructor
        {
            animals = new List<Animal>();
            foreach(Animal a in other.animals)
            {
                animals.Add(a);
            }
        }
    }


}
