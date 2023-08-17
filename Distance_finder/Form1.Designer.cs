namespace Distance_finder
{
    partial class Form1
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
            address_1 = new TextBox();
            address_2 = new TextBox();
            label1 = new Label();
            Button = new Button();
            label2 = new Label();
            result_lable = new Label();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            gMapControl2 = new GMap.NET.WindowsForms.GMapControl();
            SuspendLayout();
            // 
            // address_1
            // 
            address_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            address_1.Location = new Point(479, 31);
            address_1.Name = "address_1";
            address_1.Size = new Size(1465, 47);
            address_1.TabIndex = 0;
            // 
            // address_2
            // 
            address_2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            address_2.Location = new Point(479, 146);
            address_2.Name = "address_2";
            address_2.Size = new Size(1465, 47);
            address_2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(227, 31);
            label1.Name = "label1";
            label1.Size = new Size(184, 41);
            label1.TabIndex = 2;
            label1.Text = "First address";
            label1.Click += label1_Click;
            // 
            // Button
            // 
            Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Button.ForeColor = Color.Black;
            Button.Location = new Point(650, 909);
            Button.Name = "Button";
            Button.Size = new Size(856, 175);
            Button.TabIndex = 4;
            Button.Text = "Find distace";
            Button.UseVisualStyleBackColor = true;
            Button.Click += Button_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(183, 146);
            label2.Name = "label2";
            label2.Size = new Size(228, 41);
            label2.TabIndex = 6;
            label2.Text = "Second address";
            label2.Click += label2_Click;
            // 
            // result_lable
            // 
            result_lable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            result_lable.AutoSize = true;
            result_lable.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            result_lable.Location = new Point(798, 230);
            result_lable.Name = "result_lable";
            result_lable.Size = new Size(0, 62);
            result_lable.TabIndex = 7;
            result_lable.Click += label3_Click_1;
            // 
            // gMapControl1
            // 
            gMapControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemmory = 5;
            gMapControl1.Location = new Point(34, 330);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 2;
            gMapControl1.MinZoom = 2;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.Name = "gMapControl1";
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.RetryLoadTile = 0;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Size = new Size(950, 515);
            gMapControl1.TabIndex = 8;
            gMapControl1.Zoom = 0D;
            gMapControl1.Load += gMapControl1_Load;
            // 
            // gMapControl2
            // 
            gMapControl2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            gMapControl2.Bearing = 0F;
            gMapControl2.CanDragMap = true;
            gMapControl2.EmptyTileColor = Color.Navy;
            gMapControl2.GrayScaleMode = false;
            gMapControl2.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl2.LevelsKeepInMemmory = 5;
            gMapControl2.Location = new Point(1173, 330);
            gMapControl2.MarkersEnabled = true;
            gMapControl2.MaxZoom = 2;
            gMapControl2.MinZoom = 2;
            gMapControl2.MouseWheelZoomEnabled = true;
            gMapControl2.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl2.Name = "gMapControl2";
            gMapControl2.NegativeMode = false;
            gMapControl2.PolygonsEnabled = true;
            gMapControl2.RetryLoadTile = 0;
            gMapControl2.RoutesEnabled = true;
            gMapControl2.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl2.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
            gMapControl2.ShowTileGridLines = false;
            gMapControl2.Size = new Size(950, 515);
            gMapControl2.TabIndex = 9;
            gMapControl2.Zoom = 0D;
            gMapControl2.Load += gMapControl2_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(2148, 1151);
            Controls.Add(gMapControl2);
            Controls.Add(gMapControl1);
            Controls.Add(result_lable);
            Controls.Add(label2);
            Controls.Add(Button);
            Controls.Add(label1);
            Controls.Add(address_2);
            Controls.Add(address_1);
            ForeColor = Color.DarkGreen;
            HelpButton = true;
            Name = "Form1";
            Text = "Distance finder";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox address_1;
        private TextBox address_2;
        private Label label1;
        private Button Button;
        private Label label2;
        private Label result_lable;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private GMap.NET.WindowsForms.GMapControl gMapControl2;
    }
}