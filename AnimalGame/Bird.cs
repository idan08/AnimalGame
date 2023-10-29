using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalGame
{
    [Serializable]
    internal class Bird : Pet
    {
        private bool isFlying; 
        public Bird() { isFlying = false; type = "Bird"; }
        public Bird(bool isFlying,bool isHealthy, bool isHappy, bool isHungry, bool isThirsty, string type, string name, Color color, int age, int Height, int Width)
        {
            this.isFlying = isFlying;
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
        }
        public Bird(ref Bird other)
        {
            this.isFlying = other.isFlying;
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
            this.isFlying = other.isFlying;
        } //Copy constructor
        //setters getters
        public void setFlying(bool val) { isFlying = val; } 
        public bool getFlying() {  return isFlying; }
        public override void play(ref Pet other)
        {
            switch (other.getAnimalType())
            {
                case "Cat": MoodMeter.addPoints(-5); break;
                case "Dog": MoodMeter.addPoints(-5); break;
                case "Bird": MoodMeter.addPoints(10); break;
                case "Horse": MoodMeter.addPoints(-50); break;
                case "Fox": MoodMeter.addPoints(-5); break;
            }
        }
        public override void eat()
        {
            healthMeter.addPoints(5);
            HungerMeter.addPoints(10);
        }
        public override void drink()
        {
            WaterMeter.addPoints(30);
            healthMeter.addPoints(10);
        }
        public override void lowerMeters()
        {
            healthMeter.addPoints(-3);
            HungerMeter.addPoints(-1);
            WaterMeter.addPoints(-2);
            MoodMeter.addPoints(-1);
        }
        public void fly(ref PictureBox box) //sets a random location
        {
            int x = rnd.Next(100, 600);
            int y = rnd.Next(100, 400);
            Point point = new Point(x, y);
            while(X!=x && Y != y)
            {
                if (Math.Abs(x - X) < 5)
                {
                    X = x;
                    box.Location = new Point(x, Y);
                }
                if (x < X)
                    moveLeft(ref box);
                if (x > X)
                    moveRight(ref box);
                if (y < Y)
                    moveUp(ref box);
                if (y > Y)
                    moveDown(ref box);
                if (Math.Abs(y-Y) < 5)
                {
                    Y = y;
                    box.Location = new Point(X, Y);
                }
            }
        }
    }
}
