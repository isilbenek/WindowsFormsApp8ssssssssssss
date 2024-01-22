namespace WindowsFormsApp8ssssssssssss
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblSoru = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblSayi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblKalanSure = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(55, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.checkAnswerClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(55, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 77);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.checkAnswerClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(55, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 77);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.checkAnswerClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(55, 417);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 77);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.checkAnswerClick);
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru.Location = new System.Drawing.Point(62, 61);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(476, 29);
            this.lblSoru.TabIndex = 4;
            this.lblSoru.Text = "Aşağıdaki kelimelerden hangisi eş seslidir?";
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.Location = new System.Drawing.Point(525, 539);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(69, 29);
            this.lblSkor.TabIndex = 5;
            this.lblSkor.Text = "Skor:";
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi.Location = new System.Drawing.Point(621, 539);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(0, 29);
            this.lblSayi.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar1.Location = new System.Drawing.Point(192, 545);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(246, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // lblKalanSure
            // 
            this.lblKalanSure.AutoSize = true;
            this.lblKalanSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanSure.Location = new System.Drawing.Point(62, 543);
            this.lblKalanSure.Name = "lblKalanSure";
            this.lblKalanSure.Size = new System.Drawing.Size(116, 25);
            this.lblKalanSure.TabIndex = 9;
            this.lblKalanSure.Text = "Kalan Süre:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::WindowsFormsApp8ssssssssssss.Properties.Resources.menü__25_;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(844, 31);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(178, 83);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp8ssssssssssss.Properties.Resources.menü__40_;
            this.pictureBox3.Location = new System.Drawing.Point(252, 185);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(419, 135);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::WindowsFormsApp8ssssssssssss.Properties.Resources.menü__42_;
            this.pictureBox5.Location = new System.Drawing.Point(319, 269);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(290, 134);
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp8ssssssssssss.Properties.Resources.ice_age_hold_on_scrat_t37pwf086d53ohfb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 639);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblKalanSure);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblSayi);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblKalanSure;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}