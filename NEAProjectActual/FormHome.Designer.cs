namespace NEAProjectActual
{
    partial class FormHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mapControl1 = new GMap.NET.WindowsForms.GMapControl();
            btnAddNew = new Button();
            btnAddBulk = new Button();
            lstTrackedAircraft = new ListView();
            icaoAddress = new ColumnHeader();
            registration = new ColumnHeader();
            type = new ColumnHeader();
            airline = new ColumnHeader();
            btnNewPilot = new Button();
            SuspendLayout();
            // 
            // mapControl1
            // 
            mapControl1.Bearing = 0F;
            mapControl1.CanDragMap = true;
            mapControl1.EmptyTileColor = Color.Navy;
            mapControl1.GrayScaleMode = false;
            mapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            mapControl1.LevelsKeepInMemory = 5;
            mapControl1.Location = new Point(6, 1);
            mapControl1.MarkersEnabled = true;
            mapControl1.MaxZoom = 2;
            mapControl1.MinZoom = 2;
            mapControl1.MouseWheelZoomEnabled = true;
            mapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            mapControl1.Name = "mapControl1";
            mapControl1.NegativeMode = false;
            mapControl1.PolygonsEnabled = true;
            mapControl1.RetryLoadTile = 0;
            mapControl1.RoutesEnabled = true;
            mapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            mapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            mapControl1.ShowTileGridLines = false;
            mapControl1.Size = new Size(509, 643);
            mapControl1.TabIndex = 0;
            mapControl1.Zoom = 0D;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(536, 41);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(112, 23);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "Track New Aircraft";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnAddBulk
            // 
            btnAddBulk.Location = new Point(536, 70);
            btnAddBulk.Name = "btnAddBulk";
            btnAddBulk.Size = new Size(127, 23);
            btnAddBulk.TabIndex = 2;
            btnAddBulk.Text = "Track New Bulk (CSV)";
            btnAddBulk.UseVisualStyleBackColor = true;
            btnAddBulk.Click += btnAddBulk_Click;
            // 
            // lstTrackedAircraft
            // 
            lstTrackedAircraft.Columns.AddRange(new ColumnHeader[] { registration, icaoAddress, type, airline });
            lstTrackedAircraft.Location = new Point(699, 12);
            lstTrackedAircraft.Name = "lstTrackedAircraft";
            lstTrackedAircraft.Size = new Size(392, 619);
            lstTrackedAircraft.TabIndex = 3;
            lstTrackedAircraft.UseCompatibleStateImageBehavior = false;
            lstTrackedAircraft.View = View.Details;
            // 
            // icaoAddress
            // 
            icaoAddress.Text = "ICAO Address";
            // 
            // registration
            // 
            registration.Text = "Reg";
            // 
            // type
            // 
            type.Text = "Type";
            // 
            // airline
            // 
            airline.Text = "Airline";
            // 
            // btnNewPilot
            // 
            btnNewPilot.Location = new Point(536, 12);
            btnNewPilot.Name = "btnNewPilot";
            btnNewPilot.Size = new Size(137, 23);
            btnNewPilot.TabIndex = 4;
            btnNewPilot.Text = "Add New Pilot/Student";
            btnNewPilot.UseVisualStyleBackColor = true;
            btnNewPilot.Click += btnNewPilot_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 643);
            Controls.Add(btnNewPilot);
            Controls.Add(lstTrackedAircraft);
            Controls.Add(btnAddBulk);
            Controls.Add(btnAddNew);
            Controls.Add(mapControl1);
            Name = "FormHome";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mapControl1;
        private Button btnAddNew;
        private Button btnAddBulk;
        private ListView lstTrackedAircraft;
        private Button btnNewPilot;
        private ColumnHeader registration;
        private ColumnHeader icaoAddress;
        private ColumnHeader type;
        private ColumnHeader airline;
        
    }
}
