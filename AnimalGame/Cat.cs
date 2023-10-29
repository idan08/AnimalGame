using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalGame
{
    [Serializable]
    internal class Cat : Pet
    {
        private bool toiletCleaned;
        //Constructor
        public Cat() { toiletCleaned = true; type = "Cat"; }
        public Cat(bool toiletCleaned,bool isHealthy, bool isHappy, bool isHungry, bool isThirsty, string type, string name, Color color, int age, int Height, int Width)
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
            this.toiletCleaned = toiletCleaned;
        }
        //Copy constructor
        public Cat(ref Cat other)
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
            this.toiletCleaned = other.toiletCleaned;
        }

        public override void play(ref Pet other)
        {
            switch (other.getAnimalType())
            {
                case "Cat": MoodMeter.addPoints(40); break;
                case "Dog": MoodMeter.addPoints(-10); break;
                case "Bird": MoodMeter.addPoints(20); break;
                case "Horse": MoodMeter.addPoints(-30); break;
                case "Fox": MoodMeter.addPoints(20); break;
            }
        }
        public override void eat() 
        {
            healthMeter.addPoints(5);
            HungerMeter.addPoints(40);
        }
        public override void drink() 
        {
            WaterMeter.addPoints(30);
            healthMeter.addPoints(10);
        }
        //getters setters
        public bool getIsCleaned() { return toiletCleaned; }
        public void setIsCleaned(bool val) { toiletCleaned = val; }
        public void goToilet (ref PictureBox box) //Will cause cat go to the toilet
        {
            int i = rnd.Next(1, 100);   //Toilet cleanliness will change accordingly
            if (i < 50)
                toiletCleaned = false;
            else
                toiletCleaned = true;

            if (!toiletCleaned)
            {
                box.Location = new Point(400, 400);
                setX(400); setY(400);
                MessageBox.Show("Toilet is not clean, try again to see it is cleaned");
                return;
            }
            else
            {
                while (box.Location.X < 720)
                    this.moveRight(ref box);
        }
        MessageBox.Show("Cat came back from toilet and is happy");
        box.Location = new Point(400, 400);
            setX(400); setY(400);
        }
        public override void lowerMeters()
        {
            healthMeter.addPoints(-4);
            HungerMeter.addPoints(-2);
            MoodMeter.addPoints(-1);
            WaterMeter.addPoints(-2);
        }
        
    }

}
