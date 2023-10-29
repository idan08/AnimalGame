using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalGame
{
    internal class Human : Animal
    {
        private int speed;
        public Human() { speed = 10; type = "Human"; X = 400; Y = 400; Height = 100; Width = 100; }
        public Human(string type, string name, Color color, int age, int Height, int Width,int speed)
        {
            this.speed = speed;
            X = 400;
            Y = 400;
            this.type = type;
            this.name = name;
            this.color = color;
            this.age = age;
            idNum = idNumAssigner;
            idNumAssigner++;
            this.Height = Height;
            this.Width = Width;
        }
        public Human(ref Human other)
        {
            this.speed = other.speed;
            this.type = other.type;
            this.idNum = other.idNum;
            this.age = other.age;
            this.color = other.color;
            this.X = other.X;
            this.Y = other.Y;
            this.Width = other.Width;
            this.Height = other.Height;
        }
        public override void eat() { throw new NotSupportedException("Eating is not supported for Human objects."); }
        public override void drink() { throw new NotSupportedException("Drinking is not supported for Human objects."); }
        public override void lowerMeters(){throw new NotSupportedException("Lowering meters is not supported for Human objects.");}
        public void setSpeed(int i) { speed = i; }
        public int getSpeed() { return speed; }
        public void moveAround(ref PictureBox humanBox)
        {
            Random random = new Random();
            int direction = random.Next(4); // Generate a random number between 0 and 3

            switch (direction)
            {
                case 0: // Move left
                    moveLeft(ref humanBox, speed);
                    break;
                case 1: // Move right
                    moveRight(ref humanBox, speed);
                    break;
                case 2: // Move up
                    moveUp(ref humanBox, speed);
                    break;
                case 3: // Move down
                    moveDown(ref humanBox, speed);
                    break;
            }
        }
    }
}
