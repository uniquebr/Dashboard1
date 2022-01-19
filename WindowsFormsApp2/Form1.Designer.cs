namespace WindowsFormsApp2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xuiSuperBut = new XanderUI.XUISuperButton();
            this.xuiSuperButton3 = new XanderUI.XUISuperButton();
            this.xuiSuperButton1 = new XanderUI.XUISuperButton();
            this.xuiSuperButton2 = new XanderUI.XUISuperButton();
            this.xuiSuperButton4 = new XanderUI.XUISuperButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 433);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.xuiSuperButton4);
            this.panel2.Controls.Add(this.xuiSuperButton2);
            this.panel2.Controls.Add(this.xuiSuperButton1);
            this.panel2.Controls.Add(this.xuiSuperButton3);
            this.panel2.Controls.Add(this.xuiSuperBut);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 450);
            this.panel2.TabIndex = 0;
            // 
            // xuiSuperBut
            // 
            this.xuiSuperBut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.xuiSuperBut.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiSuperBut.ButtonImage")));
            this.xuiSuperBut.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperBut.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperBut.ButtonText = "   Dashboard";
            this.xuiSuperBut.CornerRadius = 15;
            this.xuiSuperBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xuiSuperBut.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.xuiSuperBut.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSuperBut.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperBut.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperBut.Location = new System.Drawing.Point(12, 96);
            this.xuiSuperBut.Name = "xuiSuperBut";
            this.xuiSuperBut.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.xuiSuperBut.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperBut.Size = new System.Drawing.Size(148, 38);
            this.xuiSuperBut.SuperSelected = false;
            this.xuiSuperBut.TabIndex = 0;
            this.xuiSuperBut.TextColor = System.Drawing.Color.White;
            this.xuiSuperBut.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiSuperButton3
            // 
            this.xuiSuperButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.xuiSuperButton3.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiSuperButton3.ButtonImage")));
            this.xuiSuperButton3.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton3.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton3.ButtonText = "   Tables";
            this.xuiSuperButton3.CornerRadius = 15;
            this.xuiSuperButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xuiSuperButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.xuiSuperButton3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSuperButton3.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperButton3.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton3.Location = new System.Drawing.Point(12, 149);
            this.xuiSuperButton3.Name = "xuiSuperButton3";
            this.xuiSuperButton3.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.xuiSuperButton3.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton3.Size = new System.Drawing.Size(148, 35);
            this.xuiSuperButton3.SuperSelected = false;
            this.xuiSuperButton3.TabIndex = 3;
            this.xuiSuperButton3.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiSuperButton1
            // 
            this.xuiSuperButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.xuiSuperButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiSuperButton1.ButtonImage")));
            this.xuiSuperButton1.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton1.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton1.ButtonText = "   Settings";
            this.xuiSuperButton1.CornerRadius = 15;
            this.xuiSuperButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xuiSuperButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.xuiSuperButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSuperButton1.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton1.Location = new System.Drawing.Point(12, 246);
            this.xuiSuperButton1.Name = "xuiSuperButton1";
            this.xuiSuperButton1.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.xuiSuperButton1.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Size = new System.Drawing.Size(148, 35);
            this.xuiSuperButton1.SuperSelected = false;
            this.xuiSuperButton1.TabIndex = 4;
            this.xuiSuperButton1.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiSuperButton2
            // 
            this.xuiSuperButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.xuiSuperButton2.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiSuperButton2.ButtonImage")));
            this.xuiSuperButton2.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton2.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton2.ButtonText = "   Profile";
            this.xuiSuperButton2.CornerRadius = 15;
            this.xuiSuperButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xuiSuperButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.xuiSuperButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSuperButton2.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperButton2.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton2.Location = new System.Drawing.Point(12, 198);
            this.xuiSuperButton2.Name = "xuiSuperButton2";
            this.xuiSuperButton2.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.xuiSuperButton2.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton2.Size = new System.Drawing.Size(148, 35);
            this.xuiSuperButton2.SuperSelected = false;
            this.xuiSuperButton2.TabIndex = 5;
            this.xuiSuperButton2.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiSuperButton4
            // 
            this.xuiSuperButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(55)))));
            this.xuiSuperButton4.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiSuperButton4.ButtonImage")));
            this.xuiSuperButton4.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton4.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton4.ButtonText = "   Log out";
            this.xuiSuperButton4.CornerRadius = 15;
            this.xuiSuperButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xuiSuperButton4.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.xuiSuperButton4.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSuperButton4.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperButton4.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton4.Location = new System.Drawing.Point(12, 297);
            this.xuiSuperButton4.Name = "xuiSuperButton4";
            this.xuiSuperButton4.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.xuiSuperButton4.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton4.Size = new System.Drawing.Size(148, 35);
            this.xuiSuperButton4.SuperSelected = false;
            this.xuiSuperButton4.TabIndex = 6;
            this.xuiSuperButton4.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton4.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 433);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private XanderUI.XUISuperButton xuiSuperBut;
        private XanderUI.XUISuperButton xuiSuperButton3;
        private XanderUI.XUISuperButton xuiSuperButton2;
        private XanderUI.XUISuperButton xuiSuperButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private XanderUI.XUISuperButton xuiSuperButton4;
    }
}

