using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalGame
{
    public partial class addAnimal : Form
    {
        public event EventHandler<PetEventArgs> PetAdded; //event
        public addAnimal()
        {
            InitializeComponent();
            picAnimal.BackColor = Color.Transparent;
        }

        private void txtPetName_MouseClick(object sender, MouseEventArgs e)
        {
            txtPetName.Text = "";
        } //removes text from petName box

        private void Choosing_Tick(object sender, EventArgs e)
        {
            //if all boxes have been filled
            if (txtPetName.Text.Length > 0 && textAge.Text.Length > 0 && boxAnimalSize.SelectedIndex > -1 && boxPetType.SelectedIndex > -1 && boxColor.SelectedIndex > -1)
            {
                btnAdd.Enabled = true;
                btnAdd.ForeColor = Color.Green;
                btnAdd.Size = new Size(50, 50);
                addAnimalPic(picAnimal); //adds the picture of selected animal
            }
            switch (boxPetType.SelectedText) //Changes age maximum values
            {
                case "Horse": upDownAge.Maximum = 50;

                    break;
                case "Cat": upDownAge.Maximum = 15;

                    break;
                case "Dog": upDownAge.Maximum = 20;
                    break;
                case "Bird": upDownAge.Maximum = 5;
                    break;
                case "Fox": upDownAge.Maximum = 10;
                    break;
            }

        }
        private void addAnimalPic(PictureBox box)
        {
            switch (boxColor.SelectedIndex)
            {
                case 0:
                    switch (boxPetType.SelectedIndex)
                    {
                        case 0: box.BackgroundImage = Properties.Resources.blackCat;
                            break;
                        case 1: box.BackgroundImage= Properties.Resources.BlackDog;
                            break;
                        case 2:
                            box.BackgroundImage = Properties.Resources.blackHorse;
                            break;
                        case 3:
                            box.BackgroundImage = Properties.Resources.BlackBird;
                            break;
                        case 4:
                            box.BackgroundImage = Properties.Resources.fox;
                            break;
                    }
                    break;
                case 1:
                    switch (boxPetType.SelectedIndex)
                    {
                        case 0:
                            box.BackgroundImage = Properties.Resources.brownCat;
                            break;
                        case 1:
                            box.BackgroundImage = Properties.Resources.BrownDog;
                            break;
                        case 2:
                            box.BackgroundImage = Properties.Resources.brownHorse;
                            break;
                        case 3:
                            box.BackgroundImage = Properties.Resources.brownBird;
                            break;
                        case 4:
                            box.BackgroundImage = Properties.Resources.fox;
                            break;
                    }
                    break;
                case 2:
                    switch (boxPetType.SelectedIndex)
                    {
                        case 0:
                            box.BackgroundImage = Properties.Resources.YellowCat;
                            break;
                        case 1:
                            box.BackgroundImage = Properties.Resources.YellowDog;
                            break;
                        case 2:
                            box.BackgroundImage = Properties.Resources.yellowHorse;
                            break;
                        case 3:
                            box.BackgroundImage = Properties.Resources.YellowBird;
                            break;
                        case 4:
                            box.BackgroundImage = Properties.Resources.fox;
                            break;
                    }
                    break;
                case 3:
                    switch (boxPetType.SelectedIndex)
                    {
                        case 0:
                            box.BackgroundImage = Properties.Resources.whiteCat;
                            break;
                        case 1:
                            box.BackgroundImage = Properties.Resources.WhiteDog;
                            break;
                        case 2:
                            box.BackgroundImage = Properties.Resources.whiteHorse;
                            break;
                        case 3:
                            box.BackgroundImage = Properties.Resources.WhiteBid;
                            break;
                        case 4:
                            box.BackgroundImage = Properties.Resources.fox;
                            break;
                    }
                    break;
            }
        } //adds the choose in progress animal pic to the program window
        private Color getSelectedColor()  //Returns selected color in selection box
        {
            switch (boxColor.SelectedIndex)
            {
                case 0: return Color.Black;

                case 1: return Color.Brown;

                case 2: return Color.Gold;

                case 3: return Color.White;
            }
            return Color.Black;
        }

        private void btnAddClick(object sender, EventArgs e) //adding animal upon clicking Add
        {
            if (this.Enabled == true)
            {
                Pet pet = null;
                switch (boxPetType.SelectedItem.ToString())
                {
                    case "Horse":
                        pet = new Horse();
                        break;
                    case "Cat":
                        pet = new Cat();
                        break;
                    case "Dog":
                        pet = new Dog();
                        break;
                    case "Bird":
                        pet = new Bird();
                        break;
                    case "Fox":
                        pet = new Fox();
                        break;
                }
                if (pet != null)
                {
                    pet.setAge((int)upDownAge.Value);
                    pet.setColor(getSelectedColor());
                    pet.setName(txtPetName.Text);
                }

                OnPetAdded(new PetEventArgs(pet)); //calls PetEventArgs constructor
                Close();
            }
        }

        private void OnPetAdded(PetEventArgs e) //gets a petEventArgs object and 
        {
            PetAdded?.Invoke(this, e); //invoke raises event handlers when the event had occured, the "?" is for safely invoking the event, it checks if petAdded is not NULL,if it is, event handlers won't be called.
        }

        private void petAgeClicked(object sender, MouseEventArgs e)
        {
            textAge.Text = "";
        }

        private void txtPetName_KeyPress(object sender, KeyPressEventArgs e) //checks if a digit has been entered in the pet name, warns user
        {
            if(e.KeyChar>='0' && e.KeyChar<='9')
            {
                MessageBox.Show("Name can not contain integers");
            }
        }

        
    }
    public class PetEventArgs : EventArgs  //defines PetAdded event arguments, to get the pet back when mouse click on Add occurs
    {
        internal Pet Pet { get; }

        internal PetEventArgs(Pet pet)
        {
            Pet = pet;
        }
    }
}
