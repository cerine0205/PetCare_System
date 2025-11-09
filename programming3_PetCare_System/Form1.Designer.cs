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
            this.panelAdd = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.btnDeletePet = new System.Windows.Forms.Button();
            this.btnEditPet = new System.Windows.Forms.Button();
            this.btnSearchPet = new System.Windows.Forms.Button();
            this.btnInteractWithPet = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblInstruction2 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelAdd.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.FloralWhite;
            this.panelAdd.Controls.Add(this.btnBack);
            this.panelAdd.Controls.Add(this.panelMain);
            this.panelAdd.Controls.Add(this.panel1);
            this.panelAdd.Controls.Add(this.btnDone);
            this.panelAdd.Controls.Add(this.labelAddPet);
            this.panelAdd.Controls.Add(this.tableLayoutPanel1);
            this.panelAdd.Location = new System.Drawing.Point(269, 49);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(579, 464);
            this.panelAdd.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(153, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 54);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(278, 54);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(143, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 43);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGray;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(14, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 43);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelAddPet
            // 
            this.labelAddPet.AutoSize = true;
            this.labelAddPet.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelAddPet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddPet.Location = new System.Drawing.Point(229, 58);
            this.labelAddPet.Name = "labelAddPet";
            this.labelAddPet.Size = new System.Drawing.Size(136, 26);
            this.labelAddPet.TabIndex = 1;
            this.labelAddPet.Text = "Add New Pet";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.txtNotes, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelNotes, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAge, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numAge, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(153, 125);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 133);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(143, 93);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(100, 24);
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
            this.txtName.Location = new System.Drawing.Point(143, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 24);
            this.txtName.TabIndex = 9;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "\"Cat\" ",
            "\"Dog\" ",
            "\"Bird\""});
            this.cmbType.Location = new System.Drawing.Point(143, 33);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 24);
            this.cmbType.TabIndex = 10;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(143, 63);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 24);
            this.numAge.TabIndex = 11;
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
            this.panelMain.Location = new System.Drawing.Point(566, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(10, 460);
            this.panelMain.TabIndex = 3;
            // 
            // btnAddPet
            // 
            this.btnAddPet.BackColor = System.Drawing.Color.Lavender;
            this.btnAddPet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPet.ForeColor = System.Drawing.Color.Navy;
            this.btnAddPet.Location = new System.Drawing.Point(64, 160);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(192, 64);
            this.btnAddPet.TabIndex = 0;
            this.btnAddPet.Text = "Add Pet";
            this.btnAddPet.UseVisualStyleBackColor = false;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // btnDeletePet
            // 
            this.btnDeletePet.BackColor = System.Drawing.Color.Lavender;
            this.btnDeletePet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePet.ForeColor = System.Drawing.Color.Navy;
            this.btnDeletePet.Location = new System.Drawing.Point(337, 160);
            this.btnDeletePet.Name = "btnDeletePet";
            this.btnDeletePet.Size = new System.Drawing.Size(193, 63);
            this.btnDeletePet.TabIndex = 1;
            this.btnDeletePet.Text = "Delete Pet";
            this.btnDeletePet.UseVisualStyleBackColor = false;
            this.btnDeletePet.Click += new System.EventHandler(this.btnDeletePet_Click);
            // 
            // btnEditPet
            // 
            this.btnEditPet.BackColor = System.Drawing.Color.Lavender;
            this.btnEditPet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPet.ForeColor = System.Drawing.Color.Navy;
            this.btnEditPet.Location = new System.Drawing.Point(63, 260);
            this.btnEditPet.Name = "btnEditPet";
            this.btnEditPet.Size = new System.Drawing.Size(193, 64);
            this.btnEditPet.TabIndex = 2;
            this.btnEditPet.Text = "Edit Pet";
            this.btnEditPet.UseVisualStyleBackColor = false;
            this.btnEditPet.Click += new System.EventHandler(this.btnEditPet_Click);
            // 
            // btnSearchPet
            // 
            this.btnSearchPet.BackColor = System.Drawing.Color.Lavender;
            this.btnSearchPet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPet.ForeColor = System.Drawing.Color.Navy;
            this.btnSearchPet.Location = new System.Drawing.Point(337, 257);
            this.btnSearchPet.Name = "btnSearchPet";
            this.btnSearchPet.Size = new System.Drawing.Size(193, 64);
            this.btnSearchPet.TabIndex = 3;
            this.btnSearchPet.Text = "Search Pet";
            this.btnSearchPet.UseVisualStyleBackColor = false;
            this.btnSearchPet.Click += new System.EventHandler(this.btnSearchPet_Click);
            // 
            // btnInteractWithPet
            // 
            this.btnInteractWithPet.BackColor = System.Drawing.Color.Lavender;
            this.btnInteractWithPet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInteractWithPet.ForeColor = System.Drawing.Color.Navy;
            this.btnInteractWithPet.Location = new System.Drawing.Point(200, 350);
            this.btnInteractWithPet.Name = "btnInteractWithPet";
            this.btnInteractWithPet.Size = new System.Drawing.Size(193, 64);
            this.btnInteractWithPet.TabIndex = 4;
            this.btnInteractWithPet.Text = "Interact";
            this.btnInteractWithPet.UseVisualStyleBackColor = false;
            this.btnInteractWithPet.Click += new System.EventHandler(this.btnInteractWithPet_Click);
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(83, 70);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(432, 26);
            this.lblInstruction.TabIndex = 5;
            this.lblInstruction.Text = "Please select an action from the option below";
            // 
            // lblInstruction2
            // 
            this.lblInstruction2.AutoSize = true;
            this.lblInstruction2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction2.Location = new System.Drawing.Point(226, 28);
            this.lblInstruction2.Name = "lblInstruction2";
            this.lblInstruction2.Size = new System.Drawing.Size(137, 26);
            this.lblInstruction2.TabIndex = 6;
            this.lblInstruction2.Text = "WELCOME !";
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(176, 341);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(95, 37);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(312, 341);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 37);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 574);
            this.Controls.Add(this.panelAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDone;
    }
}

