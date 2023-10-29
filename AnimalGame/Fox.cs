using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalGame
{
    [Serializable]
    internal class Fox : Pet
    {
        private bool isInside;
        public Fox() { isInside = true; type = "Fox"; }
        public Fox(bool isInside, bool isHealthy, bool isHappy, bool isHungry, bool isThirsty, string type, string name, Color color, int age, int Height, int Width)
        {
            X = rnd.Next(50, 800);
            Y = rnd.Next(100, 400);
            this.type = type;
            this.name = name;
            this.color = color;
            this.age = age;
            idNum = idNumAssigner;
            idNumAssigner++;
            this.Height = Height;
            this.Width = Width;
            this.isSick = isHealthy;
            this.isSad = isHappy;
            this.isHungry = isHungry;
            this.isThirsty = isThirsty;
            healthMeter = new Meter();
            MoodMeter = new Meter();
            HungerMeter = new Meter();
            WaterMeter = new Meter();
            this.isInside = isInside;
        }
        //Copy constructor
        public Fox(ref Fox other)
        {
            this.idNum = other.idNum;
            this.age = other.age;
            this.color = other.color;
            this.X = other.X;
            this.Y = other.Y;
            this.Width = other.Width;
            this.Height = other.Height;
            this.name = other.name;
            this.type = other.type;
            this.isSad = other.isSad;
            this.isSick = other.isSick;
            this.isHungry = other.isHungry;
            this.isThirsty = other.isThirsty;
            this.healthMeter = other.healthMeter;
            this.MoodMeter = other.MoodMeter;
            this.HungerMeter = other.HungerMeter;
            this.WaterMeter = other.WaterMeter;
            this.isInside = other.isInside;
        }
        //setters getters
        public void setInside(bool val) { isInside = val; }
        public bool getInside() { return isInside; }
        public override void play(ref Pet other)
        {
            switch (other.getAnimalType())
            {
                case "Cat": MoodMeter.addPoints(10); break;
                case "Dog": MoodMeter.addPoints(0); break;
                case "Bird": MoodMeter.addPoints(-40); break;
                case "Horse": MoodMeter.addPoints(-30); break;
                case "Fox": MoodMeter.addPoints(10); break;
            }
        }
        public override void eat()
        {
            healthMeter.addPoints(20);
            HungerMeter.addPoints(20);
        }
        public override void drink()
        {
            WaterMeter.addPoints(20);
            healthMeter.addPoints(10);
        }
        public override void lowerMeters()
        {
            HungerMeter.addPoints(-2);
            WaterMeter.addPoints(-3);
            MoodMeter.addPoints(-2);
            healthMeter.addPoints(-1);
        }
        public void releaseOutside (ref PictureBox box ){
            if (getInside())
            {
                isInside = false;
                box.Visible = false;
                box.Enabled = false;
            }
        }
        public void callBackInside(ref PictureBox box)
        {
            if (!getInside())
            {
                isInside = true;
                box.Visible = true;
                box.Enabled = true;
            }
        }
    }
}
