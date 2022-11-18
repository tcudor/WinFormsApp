namespace ImageToTextApp
{
    partial class ImageToText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageToText));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button_alege = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            this.label_rez = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox.Location = new System.Drawing.Point(321, 41);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(464, 327);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(250, 495);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(601, 284);
            this.textBox.TabIndex = 2;
            // 
            // button_alege
            // 
            this.button_alege.Location = new System.Drawing.Point(466, 240);
            this.button_alege.Name = "button_alege";
            this.button_alege.Size = new System.Drawing.Size(162, 72);
            this.button_alege.TabIndex = 3;
            this.button_alege.Text = "Apasati aici pentru a alege o imagine ";
            this.button_alege.UseVisualStyleBackColor = true;
            this.button_alege.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 347);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aplicatie ce preia textul dintr-o imagine";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Controls.Add(this.button_new);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 811);
            this.panel1.TabIndex = 5;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Transparent;
            this.button_exit.Location = new System.Drawing.Point(56, 465);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(103, 50);
            this.button_exit.TabIndex = 8;
            this.button_exit.Text = "Iesire";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(56, 419);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(103, 50);
            this.button_save.TabIndex = 10;
            this.button_save.Text = "Salvare text";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_new
            // 
            this.button_new.BackColor = System.Drawing.Color.Transparent;
            this.button_new.Location = new System.Drawing.Point(56, 373);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(103, 49);
            this.button_new.TabIndex = 9;
            this.button_new.Text = "Alege o alta imagine";
            this.button_new.UseVisualStyleBackColor = false;
            this.button_new.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_rez
            // 
            this.label_rez.AutoSize = true;
            this.label_rez.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_rez.Location = new System.Drawing.Point(72, 10);
            this.label_rez.Name = "label_rez";
            this.label_rez.Size = new System.Drawing.Size(90, 18);
            this.label_rez.TabIndex = 6;
            this.label_rez.Text = "Rezultat";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel2.Controls.Add(this.label_rez);
            this.panel2.Location = new System.Drawing.Point(234, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 40);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ImageToText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(863, 805);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_alege);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.Name = "ImageToText";
            this.Text = "ImageToText";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox;
        private TextBox textBox;
        private Button button_alege;
        private Label label1;
        private Panel panel1;
        private Label label_rez;
        private Panel panel2;
        private Button button_exit;
        private Button button_new;
        private Button button_save;
        private PictureBox pictureBox1;
    }
}