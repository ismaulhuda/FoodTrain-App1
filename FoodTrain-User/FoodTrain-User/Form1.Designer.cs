namespace FoodTrain_User
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
            this.SidePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnMinuman = new System.Windows.Forms.Button();
            this.btnPesan = new System.Windows.Forms.Button();
            this.btnMakanan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.makananCustomControl1 = new FoodTrain_User.makananCustomControl();
            this.minumanCustomControl1 = new FoodTrain_User.minumanCustomControl();
            this.pesananCustomControl1 = new FoodTrain_User.pesananCustomControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnKeluar);
            this.panel1.Controls.Add(this.btnMinuman);
            this.panel1.Controls.Add(this.btnPesan);
            this.panel1.Controls.Add(this.btnMakanan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 618);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(221)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 85);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 49);
            this.SidePanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnKeluar
            // 
            this.btnKeluar.FlatAppearance.BorderSize = 0;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(221)))));
            this.btnKeluar.Location = new System.Drawing.Point(11, 238);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(133, 44);
            this.btnKeluar.TabIndex = 6;
            this.btnKeluar.Text = " Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnMinuman
            // 
            this.btnMinuman.FlatAppearance.BorderSize = 0;
            this.btnMinuman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinuman.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinuman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(221)))));
            this.btnMinuman.Location = new System.Drawing.Point(11, 138);
            this.btnMinuman.Name = "btnMinuman";
            this.btnMinuman.Size = new System.Drawing.Size(133, 44);
            this.btnMinuman.TabIndex = 5;
            this.btnMinuman.Text = "     Minuman";
            this.btnMinuman.UseVisualStyleBackColor = true;
            this.btnMinuman.Click += new System.EventHandler(this.btnMinuman_Click);
            // 
            // btnPesan
            // 
            this.btnPesan.FlatAppearance.BorderSize = 0;
            this.btnPesan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(221)))));
            this.btnPesan.Location = new System.Drawing.Point(11, 188);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(133, 44);
            this.btnPesan.TabIndex = 4;
            this.btnPesan.Text = "Pesan";
            this.btnPesan.UseVisualStyleBackColor = true;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // btnMakanan
            // 
            this.btnMakanan.FlatAppearance.BorderSize = 0;
            this.btnMakanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakanan.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakanan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(221)))));
            this.btnMakanan.Location = new System.Drawing.Point(11, 88);
            this.btnMakanan.Name = "btnMakanan";
            this.btnMakanan.Size = new System.Drawing.Size(133, 44);
            this.btnMakanan.TabIndex = 3;
            this.btnMakanan.Text = "     Makanan";
            this.btnMakanan.UseVisualStyleBackColor = true;
            this.btnMakanan.Click += new System.EventHandler(this.btnMakanan_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(731, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 20);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(221)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(145, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 30);
            this.panel2.TabIndex = 4;
            // 
            // makananCustomControl1
            // 
            this.makananCustomControl1.AutoScroll = true;
            this.makananCustomControl1.Location = new System.Drawing.Point(145, 29);
            this.makananCustomControl1.Name = "makananCustomControl1";
            this.makananCustomControl1.Size = new System.Drawing.Size(745, 565);
            this.makananCustomControl1.TabIndex = 5;
            // 
            // minumanCustomControl1
            // 
            this.minumanCustomControl1.AutoScroll = true;
            this.minumanCustomControl1.Location = new System.Drawing.Point(145, 29);
            this.minumanCustomControl1.Name = "minumanCustomControl1";
            this.minumanCustomControl1.Size = new System.Drawing.Size(753, 589);
            this.minumanCustomControl1.TabIndex = 6;
            // 
            // pesananCustomControl1
            // 
            this.pesananCustomControl1.Location = new System.Drawing.Point(145, 29);
            this.pesananCustomControl1.Name = "pesananCustomControl1";
            this.pesananCustomControl1.Size = new System.Drawing.Size(753, 589);
            this.pesananCustomControl1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 618);
            this.Controls.Add(this.pesananCustomControl1);
            this.Controls.Add(this.minumanCustomControl1);
            this.Controls.Add(this.makananCustomControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnMinuman;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.Button btnMakanan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private makananCustomControl makananCustomControl1;
        private minumanCustomControl minumanCustomControl1;
        private pesananCustomControl pesananCustomControl1;
    }
}

