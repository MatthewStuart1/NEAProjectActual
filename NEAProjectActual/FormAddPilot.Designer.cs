namespace NEAProjectActual
{
    partial class FormAddPilot
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
            txtFirstName = new TextBox();
            txtlicence = new TextBox();
            txtlastName = new TextBox();
            lblFirstName = new Label();
            txtSurname = new Label();
            label3 = new Label();
            label4 = new Label();
            chkME = new CheckBox();
            lblME = new Label();
            chkIR = new CheckBox();
            chkNR = new CheckBox();
            lblNR = new Label();
            btnSubmit = new Button();
            lblIR = new Label();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(154, 27);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(191, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtlicence
            // 
            txtlicence.Location = new Point(154, 85);
            txtlicence.Name = "txtlicence";
            txtlicence.Size = new Size(191, 23);
            txtlicence.TabIndex = 3;
            // 
            // txtlastName
            // 
            txtlastName.Location = new Point(154, 56);
            txtlastName.Name = "txtlastName";
            txtlastName.Size = new Size(191, 23);
            txtlastName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(78, 30);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(70, 15);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "First Name :";
            // 
            // txtSurname
            // 
            txtSurname.AutoSize = true;
            txtSurname.Location = new Point(86, 59);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(65, 15);
            txtSurname.TabIndex = 6;
            txtSurname.Text = "Sur Name :";
            txtSurname.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 88);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 7;
            label3.Text = "Licence Number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 117);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 8;
            // 
            // chkME
            // 
            chkME.AutoSize = true;
            chkME.Location = new Point(154, 118);
            chkME.Name = "chkME";
            chkME.Size = new Size(83, 19);
            chkME.TabIndex = 10;
            chkME.Text = "checkBox1";
            chkME.UseVisualStyleBackColor = true;
            chkME.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblME
            // 
            lblME.AutoSize = true;
            lblME.Location = new Point(75, 117);
            lblME.Name = "lblME";
            lblME.Size = new Size(73, 15);
            lblME.TabIndex = 11;
            lblME.Text = "Muli Engine:";
            // 
            // chkIR
            // 
            chkIR.AutoSize = true;
            chkIR.Location = new Point(154, 143);
            chkIR.Name = "chkIR";
            chkIR.Size = new Size(83, 19);
            chkIR.TabIndex = 12;
            chkIR.Text = "checkBox2";
            chkIR.UseVisualStyleBackColor = true;
            // 
            // chkNR
            // 
            chkNR.AutoSize = true;
            chkNR.Location = new Point(154, 168);
            chkNR.Name = "chkNR";
            chkNR.Size = new Size(83, 19);
            chkNR.TabIndex = 14;
            chkNR.Text = "checkBox3";
            chkNR.UseVisualStyleBackColor = true;
            // 
            // lblNR
            // 
            lblNR.AutoSize = true;
            lblNR.Location = new Point(71, 168);
            lblNR.Name = "lblNR";
            lblNR.Size = new Size(77, 15);
            lblNR.TabIndex = 13;
            lblNR.Text = "Night Rating:";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(154, 207);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 15;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblIR
            // 
            lblIR.AutoSize = true;
            lblIR.Location = new Point(46, 143);
            lblIR.Name = "lblIR";
            lblIR.Size = new Size(102, 15);
            lblIR.TabIndex = 16;
            lblIR.Text = "Instrument Rating";
            // 
            // FormAddPilot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIR);
            Controls.Add(btnSubmit);
            Controls.Add(chkNR);
            Controls.Add(lblNR);
            Controls.Add(chkIR);
            Controls.Add(lblME);
            Controls.Add(chkME);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSurname);
            Controls.Add(lblFirstName);
            Controls.Add(txtlastName);
            Controls.Add(txtlicence);
            Controls.Add(txtFirstName);
            Name = "FormAddPilot";
            Text = "FormAddPilot";
            Load += FormAddPilot_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtlicence;
        private TextBox txtlastName;
        private Label lblFirstName;
        private Label txtSurname;
        private Label label3;
        private Label label4;
        private CheckBox chkME;
        private Label lblME;
        private CheckBox chkIR;
        private CheckBox chkNR;
        private Label lblNR;
        private Button btnSubmit;
        private Label lblIR;
    }
}