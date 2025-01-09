namespace NEAProjectActual
{
    partial class FormAircraftDetails
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
            lstFlightDetails = new ListView();
            lblPlaneId = new Label();
            SuspendLayout();
            // 
            // lstFlightDetails
            // 
            lstFlightDetails.Location = new Point(319, 12);
            lstFlightDetails.Name = "lstFlightDetails";
            lstFlightDetails.Size = new Size(469, 426);
            lstFlightDetails.TabIndex = 0;
            lstFlightDetails.UseCompatibleStateImageBehavior = false;
            // 
            // lblPlaneId
            // 
            lblPlaneId.AutoSize = true;
            lblPlaneId.Font = new Font("Dubai", 30F, FontStyle.Bold);
            lblPlaneId.Location = new Point(12, 12);
            lblPlaneId.Name = "lblPlaneId";
            lblPlaneId.Size = new Size(0, 67);
            lblPlaneId.TabIndex = 1;
            // 
            // FormAircraftDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPlaneId);
            Controls.Add(lstFlightDetails);
            Name = "FormAircraftDetails";
            Text = "FormAircraftDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView lstFlightDetails;
        private Label lblPlaneId;
    }
}