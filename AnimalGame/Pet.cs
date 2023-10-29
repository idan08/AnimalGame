using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    [Serializable]
        abstract internal class Pet : Animal
    {
        protected bool isSick, isSad, isHungry, isThirsty; //Each variable used in cooperation with the Meters to know the state of the animal
        protected Meter healthMeter, MoodMeter, HungerMeter, WaterMeter; //The meters

        //  Constructor
        public Pet()
        {
            isSick = isSad = isHungry = isThirsty = false;
            healthMeter = new Meter("sick");
            MoodMeter = new Meter("sad");
            HungerMeter = new Meter("hungry");
            WaterMeter = new Meter("thirsty");
        }
        //Constructor 2
        public Pet(bool isHealthy, bool isHappy, bool isHungry, bool isThirsty,string type, string name, Color color, int age, int Height, int Width)
        {
            X = rnd.Next(50, 700);
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
            healthMeter = new Meter("sick");
            MoodMeter = new Meter("sad");
            HungerMeter = new Meter("hungry");
            WaterMeter = new Meter("thirsty");
        }

        //Copy Constructor
        public Pet(ref Pet other)
        {
            this.idNum = other.idNum;
            this.age = other.age;
            this.color = other.color;
            this.X = other.X;
            this.Y = other.Y;
            this.Width = other.Width;
            this.Height = other.Height;
            this.name = other.name;
            this.isSad = other.isSad;
            this.isSick = other.isSick;
            this.isHungry = other.isHungry;
            this.isThirsty = other.isThirsty;
            this.healthMeter = other.healthMeter;
            this.MoodMeter = other.MoodMeter;
            this.HungerMeter = other.HungerMeter;
            this.WaterMeter = other.WaterMeter;
        }
        public void setIsSick(bool sick)
        {
            isSick = sick;
        } //sets boolean health
        public void setisSad(bool sad) { isSad = sad; } //sets boolean happy
        public void setisHungry(bool hungry) { isHungry = hungry; } //sets boolean Hungry
        public void setisThirsty(bool thirsty) { isThirsty = thirsty; } //sets boolean Thirsty
        public bool getisSick() { return isSick; } //getters
        public bool getisSad() { return isSad; }
        public bool getisHungry() { return isHungry; }
        public bool getisThirsty() { return isThirsty; }
        public void setHealth(int val) //sets health points in health meter
        {
            healthMeter.setPoints(val);
        }
        public void setHunger(int val) //sets hunger points in hunger meter
        {
            HungerMeter.setPoints(val);
        }
        public void setMood(int val) //sets mood points in mood meter
        {
            MoodMeter.setPoints(val);
        }
        public void setThirst(int val) //sets water points in water meter
        {
            WaterMeter.setPoints(val);
        }
        public int getHealth() //points in each metter getters
        {
            return healthMeter.getPoints();
        }
        
        public int getHunger()
        {
            return HungerMeter.getPoints();
        }
        public int getThirst()
        {
            return WaterMeter.getPoints();
        }
        public int getMood()
        {
            return MoodMeter.getPoints();
        }
        //lowerMeters() still abstract, not implemented
        public void setUpdatedMeters() //Checks all meters and sets metter accordingly
        {
            if (WaterMeter.getPoints() < 20)
                isThirsty = true;
            else
                isThirsty = false;

            if (HungerMeter.getPoints() < 20)
                isHungry = true;
            else
                isHungry = false;
            if (MoodMeter.getPoints() < 20)
                isSad = true;
            else
                isSad = false;
            if (healthMeter.getPoints() < 20)
                isSick = true;
            else
                isSick = false;
        }
        public abstract void play(ref Pet other); //to choose who it plays with, moodMeter changes down if Dog plays with cat

    }
}
