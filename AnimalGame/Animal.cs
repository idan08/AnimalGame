using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AnimalGame
{
    [Serializable]
     abstract internal class Animal
    {
        protected string type; //Type of animal (same as class name)
        protected string name; //Name of animal
        public static int idNumAssigner = 0; //Will set the idNum for every animal, and allow us to get access easier to each of them in the list
        protected int idNum;//to access element on click 
        protected Color color; //color of animal
        protected int age; //age of animal
        protected int X, Y, Height, Width; //X : x-Axis Y : Y-Axis, Height : Height of animal, Width : Width of animal
        protected Random rnd = new Random(); //random number generator
        
        //Default Constructor
        public Animal()
        {
            type = "noType";
            this.name = "noName";
            idNum = idNumAssigner;
            idNumAssigner++;
            X = rnd.Next(50, 700);
            Y = rnd.Next(50, 400);
            Height = 100;
            Width = 100;
            color = Color.Black;
            age = 0;
        }
        /*
         * @param type : type of animal
         * @param name : name of animal
         * @param color : color of animal
         * @param Height : Height of animal 
         * @param Width : Width of animal
         * Constructs an Animal object
         */ 
        public Animal(string type, string name,Color color, int age, int Height, int Width)
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
        }
        public Animal(ref Animal other) //Copy constructor
        {
            this.type = other.type;
            this.idNum = other.idNum;
            this.age = other.age;
            this.color = other.color;
            this.X = other.X;
            this.Y = other.Y;
            this.Width = other.Width;
            this.Height = other.Height;
        }
        public int getAge() { return age; } //returns age
        public void setAge(int age) { this.age = age; } //sets age
        public Color getColor() { return color; } //returns color of animal
        public void setColor(Color color) { this.color = color; } //sets color to animal
        public void setName(string name) { this.name = name; } //sets name to animal
        public string getName() { return this.name; } //gets name of animal
        public void setType(string type) { this.type = type; }
        public void setWidth(int i) { Width = i; }
        public void setHeight(int i) { Height = i; }
        public int getWidth() { return Width; }
        public int getHeight() { return Height; }
        public string getType() { return type; }
        public int getID() { return idNum; }
        public void setID(int val) { idNum = val; }
        public void setX(int i) { X = i; }
        public void setY(int i) { Y = i; } //setters for X and Y
        public int getX() { return X; } //getters for X and Y
        public int getY() { return Y; }
        public abstract void eat(); //function to be implemented after inheritation, each animal will get different values for their meters for eating
        public abstract void drink(); //function to be implemented after inheritation, each animal will get different values for their meters for eating
        /*
         * @param animalFigures the corresponding pictureBox in the program
         * @param int i, the index of the element in the given animalFigures
         * The function sets the visual elements of the pictureBox and sets the name as the name of the animal
         */
        public void displayAnimal(ref List<PictureBox> animalFigures, int i)
        {
            animalFigures.ElementAt(i).Name = getName();
            animalFigures.ElementAt(i).BackColor = Color.Transparent;
            animalFigures.ElementAt(i).Location = new Point(X, Y);
            animalFigures.ElementAt(i).Size = new Size(Width,Height);
        }
        public string getAnimalType()
        {
            return type;
        }
        abstract public void lowerMeters(); //each animal will have it's meter lower in a different manner, some will lose health faster, some mood, etc..

        //Movement
        public void moveUp(ref PictureBox box,int val = 5)
        {
            if (box.Location.Y > 0)
            {
                Y -= val;
                box.Location = new Point(X, Y);
            }
        }
        public void moveDown(ref PictureBox box,int val = 5)
        {
            if (box.Location.Y < 400)
            {
                Y += val;
                box.Location = new Point(X, Y);
            }
        }
        public void moveLeft(ref PictureBox box, int val = 5)
        {
            if (box.Location.X > 0) {
            X -= val;
                box.Location = new Point(X, Y);
            }
        }
        public void moveRight(ref PictureBox box, int val = 5)
        {
            if (box.Location.X < 720)
            {
                X += val;
                box.Location = new Point(X, Y);
            }
        }
    }
}
