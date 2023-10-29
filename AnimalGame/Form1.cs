using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Markup;

namespace AnimalGame
{
    /*
     *Classes diagram
     */
    [Serializable]
    public partial class Form1 : Form
    {
        private Animal animal, animal2; //2 animals, one to control, the other to implement play()
        private int currentIndex; //index to work around the animalFigures list
        private List<PictureBox> animalFigures;
        private myAnimals animalsStruct;
        private Human human;
        private PictureBox humanBox;
        public Form1()
        {
            human = new Human();
            initializeHumanBox(ref human);
            currentIndex = 0;
            animalFigures = new List<PictureBox>();
            animalsStruct = new myAnimals();
            InitializeComponent();
           btnRemove.Click += RemoveAnimal_Click; //adds to the Click event RemoveAnima_Click event handler

            this.KeyPreview = true;
            gameTimer.Start();
        }
        private void initializeHumanBox(ref Human human) //initializes human
        {
            humanBox = new PictureBox();
            humanBox.Width = human.getWidth();
            humanBox.Height = human.getHeight();
            humanBox.Location = new Point(human.getX(), human.getY());
            humanBox.BackColor = Color.Transparent;
            humanBox.Tag = "human";
            humanBox.BackgroundImage = Properties.Resources.human;
            Controls.Add(humanBox);
        }
        private void btnAdd_Click(object sender, EventArgs e) //opens addAnimal form
        {
            addAnimal obj = new addAnimal(); 
            obj.PetAdded += AddAnimal_PetAdded;
            obj.Show(); //opens up addAnimal form
        }

        private void AddAnimal_PetAdded(object sender, PetEventArgs e) //pet adding function
        {
            Animal pet = e.Pet;                                         
            animalFigures.Add(new PictureBox()); 
            animalFigures.ElementAt(currentIndex).Tag = currentIndex.ToString();
            animalsStruct.animals.Add(pet);
            animalsStruct.animals.ElementAt(currentIndex).displayAnimal(ref animalFigures, currentIndex);
            handlePicture(ref pet, currentIndex); //assigning the jpg picture
            this.Controls.Add(animalFigures.ElementAt(currentIndex));
            animalFigures.ElementAt(currentIndex).Click += Animal_Click;//adds Animal_Click event handler to the Click event of the specified picturebox element
            currentIndex++;
        }
        private static void Serialize(myAnimals obj, string filePath) //Serializing myAnimals obj using Binary Formatter
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                formatter.Serialize(stream, obj);
            }
        }

        private myAnimals Deserialize(string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                return (myAnimals)formatter.Deserialize(stream);
            }
        } //Desirializing the data from the file back to the myAnimals object

        private void btnSave_Click(object sender, EventArgs e) //calls serialize() and saves the state of the program
        {
            Serialize(animalsStruct, "SavedGame.bin");
            MessageBox.Show("Animals are saved!");
        }
        private void btnLoad_Click_1(object sender, EventArgs e) //Loads the program back from the file
        {
            foreach (var figure in animalFigures)
            {
                Controls.Remove(figure); //Removes and disposes all pictureboxes
                figure.Click -= Animal_Click; // Remove the event handler from each picturebox
                figure.Dispose(); //releases held data
            }
            animalFigures.Clear();
            animalsStruct = Deserialize("SavedGame.bin");
            for (int i = 0; i < animalsStruct.animals.Count; i++) //adds all the animals back to the animals list
            {
                Animal animal = animalsStruct.animals[i];
                animalFigures.Add(new PictureBox());
                animalFigures[i].Tag = i.ToString();
                animalFigures[i].Name = animal.getName() + " (" + animal.getAnimalType() + ")"; //sets name of picture box to be the same as name of animal
                animal.displayAnimal(ref animalFigures, i);
                handlePicture(ref animal, i);
                animalFigures[i].Click += Animal_Click; //add event handler again
                Controls.Add(animalFigures[i]);
                currentIndex = i + 1; //to continue adding animals in the game from the point where we stopped
            }
            MessageBox.Show("Animals are loaded!");
        }
        private void handlePicture(ref Animal animal, int i) //Pet can be upcased to Animal for btnLoad handlePicture() call
        {
            if(animal.getAnimalType() == "Fox")
            {
                animalFigures[i].BackgroundImage = Properties.Resources.fox;
            }
            if (animal.getAnimalType() == "Dog")
            {
                if (animal.getColor() == Color.Gold)
                    animalFigures[i].BackgroundImage = Properties.Resources.YellowDog;

                if (animal.getColor() == Color.Black)

                    animalFigures[i].BackgroundImage = Properties.Resources.BlackDog;

                if (animal.getColor() == Color.Brown)
                    animalFigures[i].BackgroundImage = Properties.Resources.BrownDog;
                if (animal.getColor() == Color.White)
                    animalFigures[i].BackgroundImage = Properties.Resources.WhiteDog;
            }
            if (animal.getAnimalType() == "Cat")
            {
                if (animal.getColor() == Color.Gold)
                    animalFigures[i].BackgroundImage = Properties.Resources.YellowCat;

                if (animal.getColor() == Color.Black)

                    animalFigures[i].BackgroundImage = Properties.Resources.blackCat;

                if (animal.getColor() == Color.Brown)
                    animalFigures[i].BackgroundImage = Properties.Resources.brownCat;
                if (animal.getColor() == Color.White)
                    animalFigures[i].BackgroundImage = Properties.Resources.whiteCat;
            }
            if (animal.getAnimalType() == "Horse")
            {
                if (animal.getColor() == Color.Gold)
                    animalFigures[i].BackgroundImage = Properties.Resources.yellowHorse;

                if (animal.getColor() == Color.Black)

                    animalFigures[i].BackgroundImage = Properties.Resources.blackHorse;

                if (animal.getColor() == Color.Brown)
                    animalFigures[i].BackgroundImage = Properties.Resources.brownHorse;
                if (animal.getColor() == Color.White)
                    animalFigures[i].BackgroundImage = Properties.Resources.whiteHorse;
            }
            if (animal.getAnimalType() == "Bird")
            {
                if (animal.getColor() == Color.Gold)
                    animalFigures[i].BackgroundImage = Properties.Resources.YellowBird;

                if (animal.getColor() == Color.Black)

                    animalFigures[i].BackgroundImage = Properties.Resources.BlackBird;

                if (animal.getColor() == Color.Brown)
                    animalFigures[i].BackgroundImage = Properties.Resources.brownBird;
                if (animal.getColor() == Color.White)
                    animalFigures[i].BackgroundImage = Properties.Resources.WhiteBid;
            }
        }
    
        private void Animal_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = (PictureBox)sender; //gets clicked picturebox
            int clickedIndex = int.Parse(clickedPictureBox.Tag.ToString()); //gets the index with the usage of tag in the program
            animal = animalsStruct.animals.ElementAt(clickedIndex); //getting the corresponding element
            animal.setID(clickedIndex); //helps with insuring animal's current index
            if (animal is Pet)
            {
                updateAllMeters((Pet)animal);
            }
            btnFeed.Enabled = btnDrink.Enabled = btnPlay.Enabled = true;
            btnFeed.ForeColor = btnDrink.ForeColor = btnPlay.ForeColor = Color.Black;
        }
        private void updateAllMeters(Pet animal)
        {
            updateHealth(animal);
            updateHunger(animal);
            updateMood(animal);
            updateThirst(animal);
        } //updates meters
        private void updateHealth(Pet pet)
        {
            lblHealth.Text = "Health: " + pet.getHealth().ToString() + "/100";
            if (pet.getisSick() == true)
                lblHealth.ForeColor = Color.Red;
            else
                lblHealth.ForeColor = Color.Green;
        }
        private void updateHunger(Pet pet, int val = 0)
        {
            lblHunger.Text = "Hunger: " + pet.getHunger().ToString() + "/100";
            if (pet.getisHungry() == true)
                lblHunger.ForeColor = Color.Red;
            else
                lblHunger.ForeColor = Color.Green;
        }
        private void updateMood(Pet pet, int val = 0)
        {
            lblMood.Text = "Mood: " + pet.getMood().ToString() + "/100";
            if (pet.getisSick() == true)
                lblMood.ForeColor = Color.Red;
            else
                lblMood.ForeColor = Color.Green;
        }
        private void updateThirst(Pet pet, int val = 0)
        {
            lblThirst.Text = "Thirst: " + pet.getThirst().ToString() + "/100";
            if (pet.getisSick() == true)
                lblThirst.ForeColor = Color.Red;
            else
                lblThirst.ForeColor = Color.Green;
        }

        private void btnPlay_Click(object sender, EventArgs e) //adds all animals to the list to choose who to play with from
        {
            if (animal != null)
            {
                MessageBox.Show("Select an animal to play with");
                listPlay.Enabled = true;
                listPlay.Visible = true;
                foreach (var x in animalFigures)
                {
                    listPlay.Items.Add(x.Name);
                }

            }
        }


        private void btnFeed_Click(object sender, EventArgs e)
        {
            animal.eat();
            updateHunger((Pet)animal);
        } //feeds animal, increases meters according to which animal it is (Polymorphism)


        private void btnDrink_Click(object sender, EventArgs e)

        {
            animal.drink();
            updateThirst((Pet)animal);
        } //same as eat (Polymorphism)


        private void gameTimer_Tick(object sender, EventArgs e) //gameTimer tick
        {
            human.moveAround(ref humanBox); //human is just running around in random directions
            if (animal != null) //if animal is selected, changes button texts to be usable, and special button text according to which animal is picked
            {
                lblControlled.Visible = true;
                lblControlled.Text = "Controlled Animal : " + animal.getType() + " " + animal.getName(); //Animal selected label, to know which animal is controlled
                lblControlled.ForeColor = Color.Black;
                btnSpecial.Visible = true;
                btnSpecial.Enabled = true;
                btnSpecial.Text = getSpecialText(animal);
            }
            else
                lblControlled.Visible = false;
            foreach (Pet pet in animalsStruct.animals)  //Lowering meter values for all pets, feeding,playing,drinking is needed to increase meters
            {
                if (pet is Pet)
                {
                    pet.lowerMeters();
                    pet.setUpdatedMeters();
                    if (animal != null)
                        updateAllMeters((Pet)animal);
                }
            }
            if (animalFigures.Count == 0)
            {
                lblControlled.Visible = false;
                lblControlled.Enabled = false;
                btnPlay.Enabled = false;
                btnFeed.Enabled = false;
                btnSpecial.Enabled = false;
                btnSpecial.Visible = false;
                btnDrink.Enabled = false;
                btnPlay.ForeColor = Color.Gray;
                btnDrink.ForeColor = Color.Gray;
                btnFeed.ForeColor = Color.Gray;
                animal = null;
            }
        }

        private string getSpecialText(Animal animal) //gets the "specialButton" text, different text for each animal and the state that its current state
        {
            string str = "";
            switch (animal.getType())
            {
                case "Cat": str = "Toilet";
                    break;
                case "Dog":
                    if (animal is Dog x) //animal will always be Dog in case "Dog"
                        if (x.getIsAwake())
                            str = "Sleep";
                        else
                            str = "Wake";
                    break;
                case "Bird":
                    if (animal is Bird l)
                        if (l.getFlying())
                            str = "Stop Fly";
                        else
                            str = "Fly";
                    break;
                case "Fox": 
                    if(animal is Fox b)
                    {
                        if (b.getInside())
                            str = "Release";
                        else
                            str = "Call Back";
                    }
                break;
                case "Horse":
                    if (animal is Horse h)
                            str = "poo";
                    break;
            }
            return str;
        } //sets text for the extra button, specific for each animal
        private void Form1_KeyDown(object sender, KeyEventArgs e) 
        {
            if (animal == null) return; //no animal picked, no movement
            if(animal is Dog dog)
            {
                if (dog.getIsAwake() == false)
                {
                    return;  //If dog is sleeping, it won't move
                }
            }
            PictureBox animalBox = animalFigures[animal.getID()];
            switch (e.KeyCode)
            {
                case Keys.W: animal.moveUp(ref animalBox);
                    break;
                case Keys.D:
                    animal.moveRight(ref animalBox);
                    break;
                case Keys.A:
                    animal.moveLeft(ref animalBox);
                    break; ;
                case Keys.S:
                    animal.moveDown(ref animalBox);
                    break;
            }


        } //Movement

        private void btnSpecial_Click(object sender, EventArgs e) //"specialButton" click functionality
        {
            //FINISH CASESSSSSSSSSSSSSSSSSSSSSSSSS
            PictureBox box = animalFigures[animal.getID()]; //gets corresponding pictureBox, as the pictureBox's index in the List and the animal's id are the same
            switch (btnSpecial.Text)
            {
                case "Toilet": if (animal is Cat c) c.goToilet(ref box);
                    break;
                case "Sleep": if (animal is Dog d) d.goToSleep();
                    break;
                case "Wake": if (animal is Dog d2) d2.wakeUp();
                    break;
                case "Fly": if (animal is Bird b) b.fly(ref box);
                    break;
                case "Release": if (animal is Fox f1) f1.releaseOutside(ref box); btnSpecial.Text = "Call Back";
                    break;
                case "Call Back": if (animal is Fox f2) f2.callBackInside(ref box);
                    break;
                case "poo": if (animal is Horse h) h.poo(this,ref box);
                    break;
            }
        }

        private void RemoveAnimal_Click(object sender, EventArgs e)
        {
            if (animalFigures.Count > 0)
            {
                // Remove the last animal from the animalFigures list
                PictureBox lastAnimal = animalFigures.Last();
                animalFigures.Remove(lastAnimal);

                // Remove the last animal from the myAnimals dictionary
                int lastIndex = animalFigures.Count;
                animalsStruct.animals.RemoveAt(lastIndex);

                // Remove the last animal from the form's controls
                Controls.Remove(lastAnimal);
                lastAnimal.Dispose(); // Dispose the PictureBox object to release resources
                // Update idnumassigner and currentIndex if there are remaining animals
                if (animalFigures.Count > 0)
                {
                    Animal.idNumAssigner--;
                    currentIndex--;
                }
                else
                {  
                    Animal.idNumAssigner = 0;
                    currentIndex = 0;
                }
            }
            else MessageBox.Show("No animals to remove");
        }

        private void listPlay_MouseDoubleClick(object sender, MouseEventArgs e) //chosen animal to play with function
        {
            if (listPlay.SelectedItem != null)
            {
                string selectedAnimalName = listPlay.SelectedItem.ToString();
                PictureBox selectedPictureBox = animalFigures.FirstOrDefault(p => p.Name == selectedAnimalName); //returns the first element in animalFigures which satisfies the condition when p is the pictureBox and selectedAnimalName is the name clicked
                if (selectedPictureBox != null) //if the animal exists 
                {
                    int selectedIndex = int.Parse(selectedPictureBox.Tag.ToString()); //tag used as index in the whole program
                    animal2 = animalsStruct.animals.ElementAt(selectedIndex);
                    MessageBox.Show("You played with "+animal2.getAnimalType()+" "+animal2.getName());
                }
                if (animal is Pet pet && animal2 is Pet pet2)
                {
                    pet.play(ref pet2);
                }
                listPlay.Items.Clear();
                listPlay.Visible = false;
                listPlay.Enabled = false;
            }
        } //

        
    }
}
