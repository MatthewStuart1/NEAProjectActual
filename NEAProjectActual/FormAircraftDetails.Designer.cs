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
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            lblPlaneId = new Label();
            SuspendLayout();
            // 
            // lstFlightDetails
            // 
            lstFlightDetails.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lstFlightDetails.Location = new Point(338, 12);
            lstFlightDetails.Name = "lstFlightDetails";
            lstFlightDetails.Size = new Size(674, 453);
            lstFlightDetails.TabIndex = 0;
            lstFlightDetails.UseCompatibleStateImageBehavior = false;
            lstFlightDetails.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "FlightID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "PilotID";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Departure Airport:";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Arrival Airport:";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Departure Time:";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Arrival Time";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Flight Time:";
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
            ClientSize = new Size(1024, 477);
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
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}