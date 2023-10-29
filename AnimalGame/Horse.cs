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
    internal class Horse : Pet
    {
        public Horse(){type = "Horse";}
        public Horse(bool isHealthy, bool isHappy, bool isHungry, bool isThirsty, string type, string name, Color color, int age, int Height, int Width)
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
           
        }
        //Copy constructor
        public Horse(ref Horse other)
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
        }
        public override void play(ref Pet other)
        {
            switch (other.getAnimalType())
            {
                case "Cat": MoodMeter.addPoints(0); break;
                case "Dog": MoodMeter.addPoints(0); break;
                case "Bird": MoodMeter.addPoints(-10); break;
                case "Horse": MoodMeter.addPoints(50); break;
                case "Fox": MoodMeter.addPoints(5); break;
            }
        }
        public override void eat()
        {
            healthMeter.addPoints(40);
            HungerMeter.addPoints(20);
            MoodMeter.addPoints(20);
        }
        public override void drink()
        {
            WaterMeter.addPoints(10);
            healthMeter.addPoints(10);
        }
        public override void lowerMeters()
        {
            HungerMeter.addPoints(-8);
            WaterMeter.addPoints(-3);
            MoodMeter.addPoints(-2);
            healthMeter.addPoints(-1);
        }
        public void poo(Form form,ref PictureBox box){
            PictureBox poo = new PictureBox();
            poo.Location = box.Location;
            poo.Location = new Point(getX(), getY() + 20);
            poo.BackColor = Color.Brown;
            poo.Size = new Size(5, 5);
            form.Controls.Add(poo);
        }
    }
}
