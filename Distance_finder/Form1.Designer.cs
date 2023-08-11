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
            SuspendLayout();
            // 
            // address_1
            // 
            address_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            address_1.Location = new Point(479, 31);
            address_1.Name = "address_1";
            address_1.Size = new Size(522, 47);
            address_1.TabIndex = 0;
            // 
            // address_2
            // 
            address_2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            address_2.Location = new Point(479, 146);
            address_2.Name = "address_2";
            address_2.Size = new Size(522, 47);
            address_2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(227, 31);
            label1.Name = "label1";
            label1.Size = new Size(166, 41);
            label1.TabIndex = 2;
            label1.Text = "First adress";
            label1.Click += label1_Click;
            // 
            // Button
            // 
            Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Button.ForeColor = Color.Black;
            Button.Location = new Point(364, 373);
            Button.Name = "Button";
            Button.Size = new Size(425, 173);
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
            label2.Size = new Size(210, 41);
            label2.TabIndex = 6;
            label2.Text = "Second adress";
            label2.Click += label2_Click;
            // 
            // result_lable
            // 
            result_lable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            result_lable.AutoSize = true;
            result_lable.Font = new Font("Segoe UI", 14.1F, FontStyle.Regular, GraphicsUnit.Point);
            result_lable.Location = new Point(292, 245);
            result_lable.Name = "result_lable";
            result_lable.Size = new Size(0, 62);
            result_lable.TabIndex = 7;
            result_lable.Click += label3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1205, 749);
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
    }
}