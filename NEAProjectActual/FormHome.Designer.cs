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
            mapControl1.Location = new Point(399, -1);
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
            mapControl1.Size = new Size(401, 452);
            mapControl1.TabIndex = 0;
            mapControl1.Zoom = 0D;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(6, 383);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(112, 23);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "Track New Aircraft";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnAddBulk
            // 
            btnAddBulk.Location = new Point(135, 383);
            btnAddBulk.Name = "btnAddBulk";
            btnAddBulk.Size = new Size(110, 23);
            btnAddBulk.TabIndex = 2;
            btnAddBulk.Text = "Track New Bulk (CSV)";
            btnAddBulk.UseVisualStyleBackColor = true;
            btnAddBulk.Click += this.btnAddBulk_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
