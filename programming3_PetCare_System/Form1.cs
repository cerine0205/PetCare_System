using System;
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
            manager.AddPet(new Dog("Buddy", 3,""));
            manager.AddPet(new Cat("Mittens", 2, ""));
            manager.AddPet(new Dog("Max", 5, ""));
            manager.AddPet(new Cat("Luna", 1, ""));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            {

                string name = txtName.Text;
                string type = cmbType.SelectedItem.ToString();
                int age = (int)numAge.Value;
                string notes = txtNotes.Text;

                if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(type) || age <=0)
                {
                    MessageBox.Show("Please make sure to fill in all fields correctly.");
                    return;
                }


                if (type == "Dog")
                {
                    manager.AddPet(new Dog(name, age, notes));
                }
                else if (type == "Cat")
                {
                    manager.AddPet(new Cat(name, age, notes));
                }
                else if (type == "bird")
                {
                    manager.AddPet(new Bird(name, age, notes));
                }

                MessageBox.Show("Add Pet : " + name + " " + type + " " + age + "years " + " Notes :" + notes);

                ClearFields();


            }
        }
        private void ClearFields()
        {
            txtName.Clear();
            cmbType.SelectedItem = -1;
            numAge.Value = 0;
            txtNotes.Clear();
        }
        private void btnShowAddPetPanle_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = true;
            btnDone.Visible = true;
            btnBack.Visible = true;

        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = false;
            panelEdit.Visible = false;
           // panelSearch.Visible = false;

            panelAdd.Visible = true;
        }

        private void btnDeletePet_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            panelEdit.Visible = false;
           // panelSearch.Visible = false;

            panelDelete.Visible = true;
        }

        private void btnEditPet_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = false;
            panelAdd.Visible = false;
           // panelSearch.Visible = false;

            panelEdit.Visible = true;
        }

        private void btnSearchPet_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = false;
            panelEdit.Visible = false;
            panelAdd.Visible = false;

           // panelSearch.Visible = true;
        }

        private void btnInteractWithPet_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            panelDelete.Visible = false;
            panelEdit.Visible = false;
          //  panelSearch.Visible = false;

           // panelInteract.Visible = true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            btnDone.Visible = false;
            btnBack.Visible = false;
            panelMain.Visible = true;
        }


        //cerine code
        private void btnShowDeletePetPanle_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = true;
            panelEdit.Visible = false;
            panelAdd.Visible = false;
            //panelSearch.Visible = false;
            //panelInteract.Visible = false;

        }

        private void btnShowEditPetPanle_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = true;
            panelDelete.Visible = false;
            panelAdd.Visible = false;
            //panelSearch.Visible = false;
            //panelInteract.Visible = false;

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
                        newPet = new Dog(newName, newAge,"");

                    }
                    else if (oldPet.Type == PetType.Cat)
                    {
                        newPet = new Cat(newName, newAge,"");

                    }
                    else if (oldPet.Type == PetType.Bird)
                    {
                        newPet = new Bird(newName, newAge,"");

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

        private void btn_showAddPanel_Test_btn_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
            panelDelete.Visible = false;
            panelAdd.Visible = true;
           //panelSearch.Visible = false;
           //panelInteract.Visible = false;
        }
        // end cerine code
    }

    
}
