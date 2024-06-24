namespace WindowsFormsApp3
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
            this.txt_gun = new System.Windows.Forms.TextBox();
            this.txt_yas = new System.Windows.Forms.TextBox();
            this.txt_maas = new System.Windows.Forms.TextBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_cinsiyet = new System.Windows.Forms.TextBox();
            this.f = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_gun
            // 
            this.txt_gun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_gun.Location = new System.Drawing.Point(528, 73);
            this.txt_gun.Name = "txt_gun";
            this.txt_gun.Size = new System.Drawing.Size(180, 20);
            this.txt_gun.TabIndex = 1;
            // 
            // txt_yas
            // 
            this.txt_yas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_yas.Location = new System.Drawing.Point(528, 112);
            this.txt_yas.Name = "txt_yas";
            this.txt_yas.Size = new System.Drawing.Size(180, 20);
            this.txt_yas.TabIndex = 1;
            // 
            // txt_maas
            // 
            this.txt_maas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_maas.Location = new System.Drawing.Point(528, 151);
            this.txt_maas.Name = "txt_maas";
            this.txt_maas.Size = new System.Drawing.Size(180, 20);
            this.txt_maas.TabIndex = 1;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.AllowDrop = true;
            this.btn_hesapla.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_hesapla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_hesapla.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray;
            this.btn_hesapla.FlatAppearance.BorderSize = 0;
            this.btn_hesapla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_hesapla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_hesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hesapla.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hesapla.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_hesapla.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_hesapla.Location = new System.Drawing.Point(528, 234);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(180, 53);
            this.btn_hesapla.TabIndex = 2;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = false;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Emeklilik Hesaplama Uygulaması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Çalışma gününüz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şuanki Yaşınız";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Aldığınız Maaş";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp3.Properties.Resources._912bfccf_ac41_454f_b66c_10b5e1a83c7d;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-13, -23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 496);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.avatar_design;
            this.pictureBox2.Location = new System.Drawing.Point(409, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(429, 478);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // txt_cinsiyet
            // 
            this.txt_cinsiyet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cinsiyet.Location = new System.Drawing.Point(528, 193);
            this.txt_cinsiyet.Name = "txt_cinsiyet";
            this.txt_cinsiyet.Size = new System.Drawing.Size(180, 20);
            this.txt_cinsiyet.TabIndex = 1;
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(502, 177);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(58, 13);
            this.f.TabIndex = 4;
            this.f.Text = "Cinsiyetiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.f);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.txt_cinsiyet);
            this.Controls.Add(this.txt_maas);
            this.Controls.Add(this.txt_yas);
            this.Controls.Add(this.txt_gun);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Emeklilik Hesaplama Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_gun;
        private System.Windows.Forms.TextBox txt_yas;
        private System.Windows.Forms.TextBox txt_maas;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_cinsiyet;
        private System.Windows.Forms.Label f;
    }
}

