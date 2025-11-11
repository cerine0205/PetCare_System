namespace programming3_PetCare_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelAdd = new System.Windows.Forms.Panel();
            this.backToMenuFromAdd_btn = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblInstruction2 = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnInteractWithPet = new System.Windows.Forms.Button();
            this.btnSearchPet = new System.Windows.Forms.Button();
            this.btnEditPet = new System.Windows.Forms.Button();
            this.btnDeletePet = new System.Windows.Forms.Button();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.labelAddPet = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.btnShowDeletePetPanle = new System.Windows.Forms.Button();
            this.btnShowEditPetPanle = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.edit_petNotFoundLbl = new System.Windows.Forms.Label();
            this.invalidAgeLbl = new System.Windows.Forms.Label();
            this.invalidNameLbl = new System.Windows.Forms.Label();
            this.txtBoxNewAge = new System.Windows.Forms.TextBox();
            this.lblAskForNewAge = new System.Windows.Forms.Label();
            this.txtBoxNewName = new System.Windows.Forms.TextBox();
            this.lblAskForNewName = new System.Windows.Forms.Label();
            this.lblResponseToEdit = new System.Windows.Forms.Label();
            this.editPetbtn = new System.Windows.Forms.Button();
            this.txtBoxOldName = new System.Windows.Forms.TextBox();
            this.lblAskForOldName = new System.Windows.Forms.Label();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.Delete_PetNotFound_lbl = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblAskForNameToDelete = new System.Windows.Forms.Label();
            this.DeletePetbtn = new System.Windows.Forms.Button();
            this.btnShowAddPetPanle = new System.Windows.Forms.Button();
            this.MainMenu_panel = new System.Windows.Forms.Panel();
            this.btnShowInteractPetPanle = new System.Windows.Forms.Button();
            this.btnShowSearchPetPanle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backToMenuFromEdit_btn = new System.Windows.Forms.Button();
            this.backToMenuFromdelete_btn = new System.Windows.Forms.Button();
            this.panelAdd.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.MainMenu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.FloralWhite;
            this.panelAdd.Controls.Add(this.backToMenuFromAdd_btn);
            this.panelAdd.Controls.Add(this.panelMain);
            this.panelAdd.Controls.Add(this.panel1);
            this.panelAdd.Controls.Add(this.btnDone);
            this.panelAdd.Controls.Add(this.labelAddPet);
            this.panelAdd.Controls.Add(this.tableLayoutPanel1);
            this.panelAdd.Location = new System.Drawing.Point(120, 27);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(601, 459);
            this.panelAdd.TabIndex = 0;
            this.panelAdd.Visible = false;
            // 
            // backToMenuFromAdd_btn
            // 
            this.backToMenuFromAdd_btn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMenuFromAdd_btn.Location = new System.Drawing.Point(334, 355);
            this.backToMenuFromAdd_btn.Name = "backToMenuFromAdd_btn";
            this.backToMenuFromAdd_btn.Size = new System.Drawing.Size(102, 38);
            this.backToMenuFromAdd_btn.TabIndex = 5;
            this.backToMenuFromAdd_btn.Text = "Back";
            this.backToMenuFromAdd_btn.UseVisualStyleBackColor = true;
            this.backToMenuFromAdd_btn.Click += new System.EventHandler(this.backToMenuFromAdd_btn_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FloralWhite;
            this.panelMain.Controls.Add(this.lblInstruction2);
            this.panelMain.Controls.Add(this.lblInstruction);
            this.panelMain.Controls.Add(this.btnInteractWithPet);
            this.panelMain.Controls.Add(this.btnSearchPet);
            this.panelMain.Controls.Add(this.btnEditPet);
            this.panelMain.Controls.Add(this.btnDeletePet);
            this.panelMain.Controls.Add(this.btnAddPet);
            this.panelMain.Location = new System.Drawing.Point(607, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(11, 479);
            this.panelMain.TabIndex = 3;
            // 
            // lblInstruction2
            // 
            this.lblInstruction2.AutoSize = true;
            this.lblInstruction2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction2.Location = new System.Drawing.Point(242, 29);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(137, 26);
            this.lblInstruction2.TabIndex = 6;
            this.lblInstruction2.Text = "WELCOME !";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(89, 73);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(432, 26);
            this.lblInstruction.TabIndex = 5;
            this.lblInstruction.Text = "Please select an action from the option below";
            // 
            // btnInteractWithPet
            // 
            this.btnInteractWithPet.BackColor = System.Drawing.Color.Lavender;
            this.btnInteractWithPet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInteractWithPet.ForeColor = System.Drawing.Color.Navy;
            this.btnInteractWithPet.Location = new System.Drawing.Point(214, 365);
            this.btnInteractWithPet.Name = "btnInteractWithPet";
            this.btnInteractWithPet.Size = new System.Drawing.Size(207, 67);
            this.btnInteractWithPet.TabIndex = 4;
            this.btnInteractWithPet.Text = "Interact";
            this.btnInteractWithPet.UseVisualStyleBackColor = false;
            this.btnInteractWithPet.Click += new System.EventHandler(this.btnInteractWithPet_Click);
            // 
            // btnSearchPet
            // 
            this.btnSearchPet.BackColor = System.Drawing.Color.Lavender;
            this.btnSearchPet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPet.ForeColor = System.Drawing.Color.Navy;
            this.btnSearchPet.Location = new System.Drawing.Point(361, 268);
            this.btnSearchPet.Name = "btnSearchPet";
            this.btnSearchPet.Size = new System.Drawing.Size(207, 67);
            this.btnSearchPet.TabIndex = 3;
            this.btnSearchPet.Text = "Search Pet";
            this.btnSearchPet.UseVisualStyleBackColor = false;
            this.btnSearchPet.Click += new System.EventHandler(this.btnSearchPet_Click);
            // 
            // btnEditPet
            // 
            this.btnEditPet.BackColor = System.Drawing.Color.Lavender;
            this.btnEditPet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPet.ForeColor = System.Drawing.Color.Navy;
            this.btnEditPet.Location = new System.Drawing.Point(68, 271);
            this.btnEditPet.Name = "btnEditPet";
            this.btnEditPet.Size = new System.Drawing.Size(207, 67);
            this.btnEditPet.TabIndex = 2;
            this.btnEditPet.Text = "Edit Pet";
            this.btnEditPet.UseVisualStyleBackColor = false;
            this.btnEditPet.Click += new System.EventHandler(this.btnEditPet_Click);
            // 
            // btnDeletePet
            // 
            this.btnDeletePet.BackColor = System.Drawing.Color.Lavender;
            this.btnDeletePet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePet.ForeColor = System.Drawing.Color.Navy;
            this.btnDeletePet.Location = new System.Drawing.Point(361, 167);
            this.btnDeletePet.Name = "btnDeletePet";
            this.btnDeletePet.Size = new System.Drawing.Size(207, 66);
            this.btnDeletePet.TabIndex = 1;
            this.btnDeletePet.Text = "Delete Pet";
            this.btnDeletePet.UseVisualStyleBackColor = false;
            this.btnDeletePet.Click += new System.EventHandler(this.btnDeletePet_Click);
            // 
            // btnAddPet
            // 
            this.btnAddPet.BackColor = System.Drawing.Color.Lavender;
            this.btnAddPet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPet.ForeColor = System.Drawing.Color.Navy;
            this.btnAddPet.Location = new System.Drawing.Point(68, 167);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(206, 67);
            this.btnAddPet.TabIndex = 0;
            this.btnAddPet.Text = "Add Pet";
            this.btnAddPet.UseVisualStyleBackColor = false;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(164, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 57);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnClear);
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(298, 57);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(153, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 45);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGray;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(15, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 45);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(188, 355);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(102, 38);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // labelAddPet
            // 
            this.labelAddPet.AutoSize = true;
            this.labelAddPet.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelAddPet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddPet.Location = new System.Drawing.Point(245, 60);
            this.labelAddPet.Name = "labelAddPet";
            this.labelAddPet.Size = new System.Drawing.Size(136, 26);
            this.labelAddPet.TabIndex = 1;
            this.labelAddPet.Text = "Add New Pet";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtNotes, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelNotes, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAge, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numAge, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(164, 130);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(298, 138);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(153, 93);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(106, 24);
            this.txtNotes.TabIndex = 1;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelNotes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotes.Location = new System.Drawing.Point(3, 90);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(74, 24);
            this.labelNotes.TabIndex = 0;
            this.labelNotes.Text = "Notes :";
            this.labelNotes.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(75, 24);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name :";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(3, 30);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(67, 24);
            this.labelType.TabIndex = 4;
            this.labelType.Text = "Type :";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelAge.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(3, 60);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(127, 24);
            this.labelAge.TabIndex = 6;
            this.labelAge.Text = "Age (years) :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(106, 24);
            this.txtName.TabIndex = 9;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "\"Cat\" ",
            "\"Dog\" ",
            "\"Bird\""});
            this.cmbType.Location = new System.Drawing.Point(153, 33);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(129, 24);
            this.cmbType.TabIndex = 10;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(153, 63);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(128, 24);
            this.numAge.TabIndex = 11;
            // 
            // btnShowDeletePetPanle
            // 
            this.btnShowDeletePetPanle.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDeletePetPanle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowDeletePetPanle.Location = new System.Drawing.Point(120, 219);
            this.btnShowDeletePetPanle.Name = "btnShowDeletePetPanle";
            this.btnShowDeletePetPanle.Size = new System.Drawing.Size(376, 41);
            this.btnShowDeletePetPanle.TabIndex = 2;
            this.btnShowDeletePetPanle.Text = "Delete Pet";
            this.btnShowDeletePetPanle.UseVisualStyleBackColor = true;
            this.btnShowDeletePetPanle.Click += new System.EventHandler(this.btnShowDeletePetPanle_Click);
            // 
            // btnShowEditPetPanle
            // 
            this.btnShowEditPetPanle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowEditPetPanle.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowEditPetPanle.Location = new System.Drawing.Point(120, 170);
            this.btnShowEditPetPanle.Name = "btnShowEditPetPanle";
            this.btnShowEditPetPanle.Size = new System.Drawing.Size(376, 41);
            this.btnShowEditPetPanle.TabIndex = 4;
            this.btnShowEditPetPanle.Text = "Edit Pet";
            this.btnShowEditPetPanle.UseVisualStyleBackColor = true;
            this.btnShowEditPetPanle.Click += new System.EventHandler(this.btnShowEditPetPanle_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelEdit.Controls.Add(this.backToMenuFromEdit_btn);
            this.panelEdit.Controls.Add(this.edit_petNotFoundLbl);
            this.panelEdit.Controls.Add(this.invalidAgeLbl);
            this.panelEdit.Controls.Add(this.invalidNameLbl);
            this.panelEdit.Controls.Add(this.txtBoxNewAge);
            this.panelEdit.Controls.Add(this.lblAskForNewAge);
            this.panelEdit.Controls.Add(this.txtBoxNewName);
            this.panelEdit.Controls.Add(this.lblAskForNewName);
            this.panelEdit.Controls.Add(this.lblResponseToEdit);
            this.panelEdit.Controls.Add(this.editPetbtn);
            this.panelEdit.Controls.Add(this.txtBoxOldName);
            this.panelEdit.Controls.Add(this.lblAskForOldName);
            this.panelEdit.Location = new System.Drawing.Point(0, 0);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(598, 466);
            this.panelEdit.TabIndex = 5;
            this.panelEdit.Visible = false;
            // 
            // edit_petNotFoundLbl
            // 
            this.edit_petNotFoundLbl.AutoSize = true;
            this.edit_petNotFoundLbl.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_petNotFoundLbl.ForeColor = System.Drawing.Color.Red;
            this.edit_petNotFoundLbl.Location = new System.Drawing.Point(250, 92);
            this.edit_petNotFoundLbl.Name = "edit_petNotFoundLbl";
            this.edit_petNotFoundLbl.Size = new System.Drawing.Size(128, 22);
            this.edit_petNotFoundLbl.TabIndex = 11;
            this.edit_petNotFoundLbl.Text = "Pet not Found!";
            this.edit_petNotFoundLbl.Visible = false;
            // 
            // invalidAgeLbl
            // 
            this.invalidAgeLbl.AutoSize = true;
            this.invalidAgeLbl.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidAgeLbl.ForeColor = System.Drawing.Color.Red;
            this.invalidAgeLbl.Location = new System.Drawing.Point(355, 275);
            this.invalidAgeLbl.Name = "invalidAgeLbl";
            this.invalidAgeLbl.Size = new System.Drawing.Size(100, 22);
            this.invalidAgeLbl.TabIndex = 10;
            this.invalidAgeLbl.Text = "invalid age!";
            this.invalidAgeLbl.Visible = false;
            // 
            // invalidNameLbl
            // 
            this.invalidNameLbl.AutoSize = true;
            this.invalidNameLbl.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidNameLbl.ForeColor = System.Drawing.Color.Red;
            this.invalidNameLbl.Location = new System.Drawing.Point(49, 275);
            this.invalidNameLbl.Name = "invalidNameLbl";
            this.invalidNameLbl.Size = new System.Drawing.Size(0, 22);
            this.invalidNameLbl.TabIndex = 9;
            this.invalidNameLbl.Visible = false;
            // 
            // txtBoxNewAge
            // 
            this.txtBoxNewAge.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewAge.Location = new System.Drawing.Point(359, 203);
            this.txtBoxNewAge.Multiline = true;
            this.txtBoxNewAge.Name = "txtBoxNewAge";
            this.txtBoxNewAge.Size = new System.Drawing.Size(183, 63);
            this.txtBoxNewAge.TabIndex = 8;
            // 
            // lblAskForNewAge
            // 
            this.lblAskForNewAge.AutoSize = true;
            this.lblAskForNewAge.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskForNewAge.Location = new System.Drawing.Point(342, 159);
            this.lblAskForNewAge.Name = "lblAskForNewAge";
            this.lblAskForNewAge.Size = new System.Drawing.Size(211, 28);
            this.lblAskForNewAge.TabIndex = 7;
            this.lblAskForNewAge.Text = "Enter Pet New Age:";
            // 
            // txtBoxNewName
            // 
            this.txtBoxNewName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNewName.Location = new System.Drawing.Point(38, 203);
            this.txtBoxNewName.Multiline = true;
            this.txtBoxNewName.Name = "txtBoxNewName";
            this.txtBoxNewName.Size = new System.Drawing.Size(183, 63);
            this.txtBoxNewName.TabIndex = 6;
            // 
            // lblAskForNewName
            // 
            this.lblAskForNewName.AutoSize = true;
            this.lblAskForNewName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskForNewName.Location = new System.Drawing.Point(22, 159);
            this.lblAskForNewName.Name = "lblAskForNewName";
            this.lblAskForNewName.Size = new System.Drawing.Size(230, 28);
            this.lblAskForNewName.TabIndex = 5;
            this.lblAskForNewName.Text = "Enter Pet New Name:";
            // 
            // lblResponseToEdit
            // 
            this.lblResponseToEdit.AutoSize = true;
            this.lblResponseToEdit.Location = new System.Drawing.Point(35, 105);
            this.lblResponseToEdit.Name = "lblResponseToEdit";
            this.lblResponseToEdit.Size = new System.Drawing.Size(0, 17);
            this.lblResponseToEdit.TabIndex = 4;
            // 
            // editPetbtn
            // 
            this.editPetbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPetbtn.Location = new System.Drawing.Point(194, 299);
            this.editPetbtn.Name = "editPetbtn";
            this.editPetbtn.Size = new System.Drawing.Size(180, 68);
            this.editPetbtn.TabIndex = 4;
            this.editPetbtn.Text = "press to edit";
            this.editPetbtn.UseVisualStyleBackColor = true;
            this.editPetbtn.Click += new System.EventHandler(this.editPetbtn_Click);
            // 
            // txtBoxOldName
            // 
            this.txtBoxOldName.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxOldName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOldName.Location = new System.Drawing.Point(38, 71);
            this.txtBoxOldName.Multiline = true;
            this.txtBoxOldName.Name = "txtBoxOldName";
            this.txtBoxOldName.Size = new System.Drawing.Size(185, 63);
            this.txtBoxOldName.TabIndex = 4;
            // 
            // lblAskForOldName
            // 
            this.lblAskForOldName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskForOldName.Location = new System.Drawing.Point(22, 23);
            this.lblAskForOldName.Name = "lblAskForOldName";
            this.lblAskForOldName.Size = new System.Drawing.Size(352, 49);
            this.lblAskForOldName.TabIndex = 4;
            this.lblAskForOldName.Text = "Enter Pet Name to Edit:";
            // 
            // panelDelete
            // 
            this.panelDelete.BackColor = System.Drawing.Color.FloralWhite;
            this.panelDelete.Controls.Add(this.backToMenuFromdelete_btn);
            this.panelDelete.Controls.Add(this.Delete_PetNotFound_lbl);
            this.panelDelete.Controls.Add(this.txtboxName);
            this.panelDelete.Controls.Add(this.lblAskForNameToDelete);
            this.panelDelete.Controls.Add(this.DeletePetbtn);
            this.panelDelete.Location = new System.Drawing.Point(120, 27);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(418, 313);
            this.panelDelete.TabIndex = 5;
            this.panelDelete.Visible = false;
            // 
            // Delete_PetNotFound_lbl
            // 
            this.Delete_PetNotFound_lbl.AutoSize = true;
            this.Delete_PetNotFound_lbl.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_PetNotFound_lbl.ForeColor = System.Drawing.Color.Red;
            this.Delete_PetNotFound_lbl.Location = new System.Drawing.Point(42, 130);
            this.Delete_PetNotFound_lbl.Name = "Delete_PetNotFound_lbl";
            this.Delete_PetNotFound_lbl.Size = new System.Drawing.Size(128, 22);
            this.Delete_PetNotFound_lbl.TabIndex = 3;
            this.Delete_PetNotFound_lbl.Text = "Pet not Found!";
            this.Delete_PetNotFound_lbl.Visible = false;
            // 
            // txtboxName
            // 
            this.txtboxName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxName.Location = new System.Drawing.Point(29, 57);
            this.txtboxName.Multiline = true;
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(161, 58);
            this.txtboxName.TabIndex = 2;
            // 
            // lblAskForNameToDelete
            // 
            this.lblAskForNameToDelete.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskForNameToDelete.Location = new System.Drawing.Point(12, 15);
            this.lblAskForNameToDelete.Name = "lblAskForNameToDelete";
            this.lblAskForNameToDelete.Size = new System.Drawing.Size(314, 33);
            this.lblAskForNameToDelete.TabIndex = 1;
            this.lblAskForNameToDelete.Text = "Enter Pet Name to delete:";
            // 
            // DeletePetbtn
            // 
            this.DeletePetbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePetbtn.Location = new System.Drawing.Point(118, 190);
            this.DeletePetbtn.Name = "DeletePetbtn";
            this.DeletePetbtn.Size = new System.Drawing.Size(176, 66);
            this.DeletePetbtn.TabIndex = 0;
            this.DeletePetbtn.Text = "press to delete";
            this.DeletePetbtn.UseVisualStyleBackColor = true;
            this.DeletePetbtn.Click += new System.EventHandler(this.DeletePetbtn_Click);
            // 
            // btnShowAddPetPanle
            // 
            this.btnShowAddPetPanle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowAddPetPanle.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAddPetPanle.Location = new System.Drawing.Point(122, 124);
            this.btnShowAddPetPanle.Name = "btnShowAddPetPanle";
            this.btnShowAddPetPanle.Size = new System.Drawing.Size(376, 41);
            this.btnShowAddPetPanle.TabIndex = 6;
            this.btnShowAddPetPanle.Text = "Add Pet";
            this.btnShowAddPetPanle.UseVisualStyleBackColor = true;
            this.btnShowAddPetPanle.Click += new System.EventHandler(this.btnShowAddPetPanle_Click_1);
            // 
            // MainMenu_panel
            // 
            this.MainMenu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MainMenu_panel.Controls.Add(this.btnShowInteractPetPanle);
            this.MainMenu_panel.Controls.Add(this.btnShowSearchPetPanle);
            this.MainMenu_panel.Controls.Add(this.pictureBox1);
            this.MainMenu_panel.Controls.Add(this.label2);
            this.MainMenu_panel.Controls.Add(this.btnShowAddPetPanle);
            this.MainMenu_panel.Controls.Add(this.label1);
            this.MainMenu_panel.Controls.Add(this.btnShowDeletePetPanle);
            this.MainMenu_panel.Controls.Add(this.btnShowEditPetPanle);
            this.MainMenu_panel.Location = new System.Drawing.Point(0, 0);
            this.MainMenu_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainMenu_panel.Name = "MainMenu_panel";
            this.MainMenu_panel.Size = new System.Drawing.Size(752, 580);
            this.MainMenu_panel.TabIndex = 12;
            this.MainMenu_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnShowInteractPetPanle
            // 
            this.btnShowInteractPetPanle.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInteractPetPanle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowInteractPetPanle.Location = new System.Drawing.Point(120, 313);
            this.btnShowInteractPetPanle.Name = "btnShowInteractPetPanle";
            this.btnShowInteractPetPanle.Size = new System.Drawing.Size(376, 41);
            this.btnShowInteractPetPanle.TabIndex = 10;
            this.btnShowInteractPetPanle.Text = "Interact Pet";
            this.btnShowInteractPetPanle.UseVisualStyleBackColor = true;
            this.btnShowInteractPetPanle.Click += new System.EventHandler(this.btnShowInteractPetPanle_Click);
            // 
            // btnShowSearchPetPanle
            // 
            this.btnShowSearchPetPanle.Font = new System.Drawing.Font("PMingLiU-ExtB", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSearchPetPanle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowSearchPetPanle.Location = new System.Drawing.Point(120, 266);
            this.btnShowSearchPetPanle.Name = "btnShowSearchPetPanle";
            this.btnShowSearchPetPanle.Size = new System.Drawing.Size(376, 41);
            this.btnShowSearchPetPanle.TabIndex = 9;
            this.btnShowSearchPetPanle.Text = "Search Pet";
            this.btnShowSearchPetPanle.UseVisualStyleBackColor = true;
            this.btnShowSearchPetPanle.Click += new System.EventHandler(this.btnShowSearchPetPanle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::programming3_PetCare_System.Properties.Resources.Screenshot_2025_11_11_181403;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 438);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose An Action To Do";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "..:::.. PET CARE ..:::..";
            // 
            // backToMenuFromEdit_btn
            // 
            this.backToMenuFromEdit_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMenuFromEdit_btn.Location = new System.Drawing.Point(38, 397);
            this.backToMenuFromEdit_btn.Name = "backToMenuFromEdit_btn";
            this.backToMenuFromEdit_btn.Size = new System.Drawing.Size(105, 42);
            this.backToMenuFromEdit_btn.TabIndex = 12;
            this.backToMenuFromEdit_btn.Text = "back";
            this.backToMenuFromEdit_btn.UseVisualStyleBackColor = true;
            this.backToMenuFromEdit_btn.Click += new System.EventHandler(this.backToMenuFromEdit_btn_Click);
            // 
            // backToMenuFromdelete_btn
            // 
            this.backToMenuFromdelete_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMenuFromdelete_btn.Location = new System.Drawing.Point(17, 265);
            this.backToMenuFromdelete_btn.Name = "backToMenuFromdelete_btn";
            this.backToMenuFromdelete_btn.Size = new System.Drawing.Size(95, 31);
            this.backToMenuFromdelete_btn.TabIndex = 13;
            this.backToMenuFromdelete_btn.Text = "back";
            this.backToMenuFromdelete_btn.UseVisualStyleBackColor = true;
            this.backToMenuFromdelete_btn.Click += new System.EventHandler(this.backToMenuFromdelete_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(821, 559);
            this.Controls.Add(this.MainMenu_panel);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.panelAdd);
            this.Name = "Form1";
            this.Text = ".::.PET CARE.::.";
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.MainMenu_panel.ResumeLayout(false);
            this.MainMenu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label labelAddPet;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnInteractWithPet;
        private System.Windows.Forms.Button btnSearchPet;
        private System.Windows.Forms.Button btnEditPet;
        private System.Windows.Forms.Button btnDeletePet;
        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblInstruction2;
        private System.Windows.Forms.Button backToMenuFromAdd_btn;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnShowDeletePetPanle;
        private System.Windows.Forms.Button btnShowEditPetPanle;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.TextBox txtBoxNewAge;
        private System.Windows.Forms.Label lblAskForNewAge;
        private System.Windows.Forms.TextBox txtBoxNewName;
        private System.Windows.Forms.Label lblAskForNewName;
        private System.Windows.Forms.Label lblResponseToEdit;
        private System.Windows.Forms.Button editPetbtn;
        private System.Windows.Forms.TextBox txtBoxOldName;
        private System.Windows.Forms.Label lblAskForOldName;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Label Delete_PetNotFound_lbl;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label lblAskForNameToDelete;
        private System.Windows.Forms.Button DeletePetbtn;
        private System.Windows.Forms.Label invalidAgeLbl;
        private System.Windows.Forms.Label invalidNameLbl;
        private System.Windows.Forms.Label edit_petNotFoundLbl;
        private System.Windows.Forms.Button btnShowAddPetPanle;
        private System.Windows.Forms.Panel MainMenu_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnShowInteractPetPanle;
        private System.Windows.Forms.Button btnShowSearchPetPanle;
        private System.Windows.Forms.Button backToMenuFromEdit_btn;
        private System.Windows.Forms.Button backToMenuFromdelete_btn;
    }
}

