namespace final_project
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.icon2 = new System.Windows.Forms.PictureBox();
            this.icon5 = new System.Windows.Forms.PictureBox();
            this.icon4 = new System.Windows.Forms.PictureBox();
            this.icon3 = new System.Windows.Forms.PictureBox();
            this.icon1 = new System.Windows.Forms.PictureBox();
            this.map = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1290, 432);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // icon2
            // 
            this.icon2.Image = global::final_project.Properties.Resources.icons;
            this.icon2.Location = new System.Drawing.Point(1323, 107);
            this.icon2.Name = "icon2";
            this.icon2.Size = new System.Drawing.Size(28, 42);
            this.icon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon2.TabIndex = 5;
            this.icon2.TabStop = false;
            this.icon2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.icon2_down);
            this.icon2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.icon2_move);
            this.icon2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.icon2_up);
            // 
            // icon5
            // 
            this.icon5.Image = global::final_project.Properties.Resources.icons;
            this.icon5.Location = new System.Drawing.Point(1323, 332);
            this.icon5.Name = "icon5";
            this.icon5.Size = new System.Drawing.Size(28, 48);
            this.icon5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon5.TabIndex = 4;
            this.icon5.TabStop = false;
            // 
            // icon4
            // 
            this.icon4.Image = global::final_project.Properties.Resources.icons;
            this.icon4.Location = new System.Drawing.Point(1323, 258);
            this.icon4.Name = "icon4";
            this.icon4.Size = new System.Drawing.Size(28, 47);
            this.icon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon4.TabIndex = 3;
            this.icon4.TabStop = false;
            // 
            // icon3
            // 
            this.icon3.Image = global::final_project.Properties.Resources.icons;
            this.icon3.Location = new System.Drawing.Point(1323, 182);
            this.icon3.Name = "icon3";
            this.icon3.Size = new System.Drawing.Size(28, 43);
            this.icon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon3.TabIndex = 2;
            this.icon3.TabStop = false;
            this.icon3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.icon3_down);
            this.icon3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.icon3_move);
            this.icon3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.icon3_up);
            // 
            // icon1
            // 
            this.icon1.Image = global::final_project.Properties.Resources.icons;
            this.icon1.Location = new System.Drawing.Point(1323, 43);
            this.icon1.Name = "icon1";
            this.icon1.Size = new System.Drawing.Size(28, 42);
            this.icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon1.TabIndex = 1;
            this.icon1.TabStop = false;
            this.icon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.icon_down);
            this.icon1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.icon_move);
            this.icon1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.icon_up);
            // 
            // map
            // 
            this.map.Image = global::final_project.Properties.Resources.paris_labels_bridges;
            this.map.InitialImage = global::final_project.Properties.Resources.paris_labels_bridges;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.Name = "map";
            this.map.Padding = new System.Windows.Forms.Padding(5);
            this.map.Size = new System.Drawing.Size(1276, 596);
            this.map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.map.TabIndex = 0;
            this.map.TabStop = false;
            this.map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.map_MouseMove);
            // 
            // timer2
            // 
            this.timer2.Interval = 120;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1290, 487);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 595);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.icon2);
            this.Controls.Add(this.icon5);
            this.Controls.Add(this.icon4);
            this.Controls.Add(this.icon3);
            this.Controls.Add(this.icon1);
            this.Controls.Add(this.map);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox map;
        private System.Windows.Forms.PictureBox icon1;
        private System.Windows.Forms.PictureBox icon3;
        private System.Windows.Forms.PictureBox icon4;
        private System.Windows.Forms.PictureBox icon5;
        private System.Windows.Forms.PictureBox icon2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer3;


    }
}

