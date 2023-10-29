using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    [Serializable]
    internal class Meter
    {
        protected string typeMeter; //type of meter
        protected int points; //points in the meter
        public Meter() { points = 100; } //constructor
        public Meter(string type ,int points=100) { setPoints(points); } //constructor 2 + default parameter points
        public Meter(ref Meter other) //Copy constructor
        {
            this.points = other.points;
        }
        public void setType(string type) //sets type
        {
            this.typeMeter = type;
        }
        public string getType() { return typeMeter; } //gets type
        public void setPoints(int i) //setting points
        {
            if (typeMeter != "Money")
            {
                if (i < 0)
                    points = 0;
                if (i > 100)
                    points = 100; //points can be maximum 100, minimum 0
                else
                    points = i;
            }
            else
            {
                points = i;
            }
        }
        public int getPoints() { return points; }  //getting points
        public void addPoints(int i) //adding given points to meter, maximum 100 points, minimum 0
        {
            if (typeMeter != "Money")
            {
                if (points + i > 100)
                    points = 100;
                else if (points + i < 0)
                    points = 0;
                else
                    points += i;
            }
            else
            {
                points += i;
            }
        }
    }
}
