using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    [Serializable]
    internal class Dog : Pet
    {
        private bool isAwake; 
        public Dog() { isAwake = true; type = "Dog"; }
        public Dog(bool isAwake,bool isHealthy, bool isHappy, bool isHungry, bool isThirsty, string type, string name, Color color, int age, int Height, int Width)
        {
            this.isAwake = isAwake;
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
        //Copy constructor
        public Dog(ref Dog other)
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
            this.isAwake = other.isAwake;
        }
        public override void play(ref Pet other)
        {
            switch (other.getAnimalType())
            {
                case "Cat": MoodMeter.addPoints(20); break;
                case "Dog": MoodMeter.addPoints(5); break;
                case "Bird": MoodMeter.addPoints(-40); break;
                case "Horse": MoodMeter.addPoints(-20); break;
                case "Fox": MoodMeter.addPoints(10); break;
            }
        }
        //setters getters
        public void setisAwake(bool status) { this.isAwake = status; }
        public bool getIsAwake() { return isAwake; }
        public override void eat()
        {
            healthMeter.addPoints(10);
            HungerMeter.addPoints(10);
        }
        public override void drink()
        {
            WaterMeter.addPoints(20);
            healthMeter.addPoints(5);
        }
        public override void lowerMeters()
        {
            HungerMeter.addPoints(-2);
            WaterMeter.addPoints(-2);
            MoodMeter.addPoints(-5);
            healthMeter.addPoints(-9);
        }
        public void goToSleep() { setisAwake(false);}
        public void wakeUp() { setisAwake(true); }
    }
    }
