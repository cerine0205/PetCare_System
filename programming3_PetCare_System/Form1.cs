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
            panelSearch.Visible = false;

            panelAdd.Visible = true;
        }

        private void btnDeletePet_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            panelEdit.Visible = false;
            panelSearch.Visible = false;

            panelDelete.Visible = true;
        }

        private void btnEditPet_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = false;
            panelAdd.Visible = false;
            panelSearch.Visible = false;

            panelEdit.Visible = true;
        }

        private void btnSearchPet_Click(object sender, EventArgs e)
        {
            panelDelete.Visible = false;
            panelEdit.Visible = false;
            panelAdd.Visible = false;

            panelSearch.Visible = true;
        }

        private void btnInteractWithPet_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            panelDelete.Visible = false;
            panelEdit.Visible = false;
            panelSearch.Visible = false;

            panelInteract.Visible = true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            btnDone.Visible = false;
            btnBack.Visible = false;
            panelMain.Visible = true;
        }
    }

    
}
