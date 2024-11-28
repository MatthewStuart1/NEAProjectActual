namespace NEAProjectActual
{
    partial class FormAddBulk
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
            btnAddBulk = new Button();
            lblCSVOnly = new Label();
            SuspendLayout();
            // 
            // btnAddBulk
            // 
            btnAddBulk.Location = new Point(115, 60);
            btnAddBulk.Name = "btnAddBulk";
            btnAddBulk.Size = new Size(75, 23);
            btnAddBulk.TabIndex = 0;
            btnAddBulk.Text = "Browse Files";
            btnAddBulk.UseVisualStyleBackColor = true;
            btnAddBulk.Click += btnAddBulk_Click;
            // 
            // lblCSVOnly
            // 
            lblCSVOnly.AutoSize = true;
            lblCSVOnly.Location = new Point(21, 9);
            lblCSVOnly.Name = "lblCSVOnly";
            lblCSVOnly.Size = new Size(268, 15);
            lblCSVOnly.TabIndex = 1;
            lblCSVOnly.Text = "Only Accepts Comma Separated Value files (.CSV)";
            // 
            // FormAddBulk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 169);
            Controls.Add(lblCSVOnly);
            Controls.Add(btnAddBulk);
            Name = "FormAddBulk";
            Text = "FormAddBulk";
            Load += FormAddBulk_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddBulk;
        private Label lblCSVOnly;
    }
}