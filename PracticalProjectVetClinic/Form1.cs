using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Vet_Clinic;
using PracticalProjectVetClinic;

namespace PracticalProjectVetClinic
{
    public partial class Form1 : Form
    {
        private readonly List<IAnimal> pets = new List<IAnimal>()
        {
            new Cat("Fluffy", new DateTime(2018, 5, 15), "Persian", "Regular checkups", 4.5, "Golden", "Feather wand"),
            new Dog("Buddy", new DateTime (2018, 5, 15), "Golden Retriever", "Vaccinated",25.5, "Golden", "Stick")
        };
        public Form1()
        {
            InitializeComponent();
        }
        private void OnLoad(object sender, EventArgs e)
        {
            LoadAllPets();
        }

        private void LoadAllPets()
        {
            this.listView1.Clear();
            foreach (var pet in pets)
            {
                this.listView1.Items.Add(pet.Name, pet.GetType() == typeof(Cat) ? 0 : 1);
            }
        }

        private void ListViewPetsMouseClick(object sender, MouseEventArgs e)
        {
            IAnimal selectedPet = pets[this.listView1.SelectedItems[0].Index];

            if (selectedPet != null)
            {
                PetDetailsForm_Controls detailsForm = new PetDetailsForm_Controls();
                detailsForm.ShowDialog();
            }
        }

        private void ButtonAddNewPetClick(object sender, EventArgs e)
        {
            NewPet newPet = new();
            if (newPet.ShowDialog() == DialogResult.OK)
            {
                pets.Add(newPet.Animal);
            }
            LoadAllPets();
        }
    }
}





