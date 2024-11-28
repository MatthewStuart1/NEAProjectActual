namespace NEAProjectActual
{
    partial class frmAddNew
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
            textBox1 = new TextBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(251, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // frmAddNew
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(lblAddNewInstructions);
            Name = "frmAddNew";
            Text = "frmAddNew";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddNewInstructions;
        private TextBox textBox1;
    }
}