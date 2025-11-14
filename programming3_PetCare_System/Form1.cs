using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programming3_PetCare_System
{
    public partial class Form1 : Form
    {
        private PetManager manager = new PetManager();
        public Form1()
        {
            InitializeComponent();
            manager.AddPet(new Dog("Buddy", 3, ""));
            manager.AddPet(new Cat("Mittens", 2, ""));
            manager.AddPet(new Dog("Max", 5, ""));
            manager.AddPet(new Cat("Luna", 1, ""));
        }
        // ddjojefoirfjowifjowfjowf
        private void btnShowAddPetPanle_Click_1(object sender, EventArgs e)
        {
            panelAdd.Visible = true;

            MainMenu_panel.Visible = false;
            panelEdit.Visible = false;
            panelDelete.Visible = false;
            panelSearch.Visible = false;
            panelInteract.Visible = false;

            btnDone.Visible = true;
            backToMenuFromAdd_btn.Visible = true;

            lblNameError.Visible = false;
            lblTypeError.Visible = false;
            lblAgeError.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            string name = txtName.Text.Trim();
            int typeIndex = cmbType.SelectedIndex;
            int age = (int)numAge.Value;
            string notes = txtNotes.Text;

            if (string.IsNullOrEmpty(name))
            {
                lblNameError.Text = "Invalid name !";
                lblNameError.Visible = true;
                return;
            }
            if (typeIndex < 0)
            {
                lblTypeError.Text = "Please select a pet type";
                lblTypeError.Visible = true;
                return;
            }
            if (age <= 0)
            {
                lblAgeError.Text = "Invalid age ";
                lblAgeError.Visible = true;
                return;
            }
            string typeText = cmbType.SelectedItem.ToString();


            if (typeIndex == 0) //Dog
            {
                manager.AddPet(new Dog(name, age, notes));
            }
            else if (typeIndex == 1) //Cat
            {
                manager.AddPet(new Cat(name, age, notes));
            }
            else if (typeIndex == 2) //Bird
            {
                manager.AddPet(new Bird(name, age, notes));
            }

            MessageBox.Show("Add Pet : " + name + " " + typeText + " " + age + "years " + " Notes :" + notes);

            ClearFields();



        }
        private void ClearFields()
        {
            txtName.Clear();
            cmbType.SelectedIndex = -1;
            numAge.Value = 0;
            txtNotes.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            //backToMenuFromAdd_btn.Visible = false;
            MainMenu_panel.Visible = true;
        }

  


        //cerine code
        private void btnShowDeletePetPanle_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = true;

            MainMenu_panel.Visible = false;
            panelEdit.Visible = false;
            panelAdd.Visible = false;
            panelSearch.Visible = false;
            panelInteract.Visible = false;

        }

        private void btnShowEditPetPanle_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = true;

            MainMenu_panel.Visible = false;
            panelDelete.Visible = false;
            panelAdd.Visible = false;
            panelSearch.Visible = false;
            panelInteract.Visible = false;


            txtBoxNewAge.Text = "";
            txtBoxNewName.Text = "";
            txtBoxOldName.Text = "";
            edit_petNotFoundLbl.Visible = false;
            invalidAgeLbl.Visible = false;
            invalidNameLbl.Visible = false;
        }

        private void DeletePetbtn_Click(object sender, EventArgs e)
        {
            Delete_PetNotFound_lbl.Visible = false;
            string name = txtboxName.Text;
            var isDeleted = manager.DeletePet(name);

            if (isDeleted)
            {
                MessageBox.Show("pet has been deleted successfully");
            }

            else
            {
                Delete_PetNotFound_lbl.Visible = true;
            }
        }

        private void editPetbtn_Click(object sender, EventArgs e)
        {
            edit_petNotFoundLbl.Visible = false;
            invalidAgeLbl.Visible = false;
            invalidNameLbl.Visible = false;
        

            string oldname = txtBoxOldName.Text.Trim();
            Pet oldPet = manager.SearchPet(oldname);
            Pet newPet = null;

            if (oldPet != null) // there is a pet with this name
            {
                string newName = txtBoxNewName.Text.Trim();
                string newAgeStr = txtBoxNewAge.Text.Trim();

                //name
                if (newName == "" || newName == null)
                {
                    invalidNameLbl.Text = "Invalid Name!";
                    invalidNameLbl.Visible = true;
                }

                else if (manager.SearchPet(newName) != null)
                {
                    invalidNameLbl.Text = "The name already exists.";
                    invalidNameLbl.Visible = true;
                }


                // age
                if (!(int.TryParse(newAgeStr, out int newAge)) || newAge <= 0)
                {
                    invalidAgeLbl.Visible = true;
                }

                if (manager.SearchPet(newName) == null && newName != "" && newAge > 0)
                {
                    // creat new Pet
                    if (oldPet.Type == PetType.Dog)
                    {
                        newPet = new Dog(newName, newAge, "");

                    }
                    else if (oldPet.Type == PetType.Cat)
                    {
                        newPet = new Cat(newName, newAge, "");

                    }
                    else if (oldPet.Type == PetType.Bird)
                    {
                        newPet = new Bird(newName, newAge, "");

                    }

                    // apply changes
                    if (newPet != null)
                    {
                        manager.EditPet(oldname, newPet);
                        MessageBox.Show("Pet updated successfully");

                    }
                }


            }

            else // oldPet == null
            {
                edit_petNotFoundLbl.Visible = true;

            }



        }


        // end cerine code










        // هنا اضفت ذا لكود هاجر عشان يبين البانلز
        private void btnShowSearchPetPanle_Click(object sender, EventArgs e)
        {
            panelSearch.Visible = true;
            MainMenu_panel.Visible = false;
            panelEdit.Visible = false;
            panelDelete.Visible = false;
            panelAdd.Visible = false;
            panelInteract.Visible = false;
        }

        private void btnShowInteractPetPanle_Click(object sender, EventArgs e)
        {
            panelInteract.Visible = true;
            MainMenu_panel.Visible = false;
            panelEdit.Visible = false;
            panelDelete.Visible = false;
            panelAdd.Visible = false;
            panelSearch.Visible = false;
        }








        private void btnSearch_Click(object sender, EventArgs e)
        {
            String name = txtPetName.Text;
            var pet = manager.SearchPet(name);
            if (pet != null)
            {
                lblResult.Text="Pet Found: " + pet.DisplayInfo();
                lblResult.ForeColor = Color.Green;
            }
            else
            {
                lblResult.Text="Pet Not Found";
                lblResult.ForeColor = Color.Red;
            }
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            MainMenu_panel.Visible = true;

            panelEdit.Visible = false;
            panelDelete.Visible = false;
            panelAdd.Visible = false;
            panelSearch.Visible = false;
            panelInteract.Visible = false;
        }


        private void btnInteract_Click(object sender, EventArgs e)
        {
            string name=textPetName.Text.Trim();
            int action = cmbAction.SelectedIndex+1;
            string result="";
            var pet=manager.SearchPet(name);
            if(pet==null)
            {
                lblInteractResult.Text="Pet Not Found.";
                lblInteractResult.ForeColor = Color.Red;
                return;
            }
            if (string.IsNullOrEmpty(name))
            {
                lblInteractResult.Text="Please enter a pet name.";
                lblInteractResult.ForeColor = Color.Red;
                return;
            }
            if(cmbAction.SelectedItem==null)
            {
                lblInteractResult.Text="Please select an action.";
                lblInteractResult.ForeColor = Color.OrangeRed;
                return;
            }
            if (action == 1)
            {
                result = pet.Feed();
            }
            else if (action == 2)
            {
                result = pet.Play();
            }
            else if (action == 3)
            {
                result = pet.Feed()+Environment.NewLine+pet.Play();
            }
            lblInteractResult.Text=result;
            lblInteractResult.ForeColor = Color.Green;

        }

        private void btnViewAllPets_Click(object sender, EventArgs e)
        {
           
            lstPets.Items.Clear();

            ArrayList allPets = manager.GetAllPets();

            if (allPets == null || allPets.Count == 0)
            {
                lstPets.Items.Add("No Pets Found");
                return;
            }
            foreach (var p in allPets)
            {
                Pet pet = (Pet)p;
                lstPets.Items.Add(pet.Name + " - " + pet.Age + "years");
            }

        }
    
    }
}
    
