namespace NEAProjectActual
{
    partial class FormAddNew
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
            lblAddNewInstructions = new Label();
            txtNewReg = new TextBox();
            btnSubmitNewReg = new Button();
            SuspendLayout();
            // 
            // lblAddNewInstructions
            // 
            lblAddNewInstructions.AutoSize = true;
            lblAddNewInstructions.Location = new Point(58, 22);
            lblAddNewInstructions.Name = "lblAddNewInstructions";
            lblAddNewInstructions.Size = new Size(188, 15);
            lblAddNewInstructions.TabIndex = 0;
            lblAddNewInstructions.Text = "Enter a Registration (Excluding G-)";
            // 
            // txtNewReg
            // 
            txtNewReg.Location = new Point(91, 63);
            txtNewReg.Name = "txtNewReg";
            txtNewReg.Size = new Size(100, 23);
            txtNewReg.TabIndex = 1;
            // 
            // btnSubmitNewReg
            // 
            btnSubmitNewReg.Location = new Point(102, 104);
            btnSubmitNewReg.Name = "btnSubmitNewReg";
            btnSubmitNewReg.Size = new Size(75, 23);
            btnSubmitNewReg.TabIndex = 2;
            btnSubmitNewReg.Text = "Submit";
            btnSubmitNewReg.UseVisualStyleBackColor = true;
            btnSubmitNewReg.Click += btnSubmitNewReg_Click;
            // 
            // FormAddNew
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 168);
            Controls.Add(btnSubmitNewReg);
            Controls.Add(txtNewReg);
            Controls.Add(lblAddNewInstructions);
            Name = "FormAddNew";
            Text = "frmAddNew";
            Load += this.FormAddNew_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddNewInstructions;
        private TextBox txtNewReg;
        private Button btnSubmitNewReg;
    }
}