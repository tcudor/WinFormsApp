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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu_Button_save = new ImageToTextApp.Design.Menu_Button();
            this.menu_Button_exit = new ImageToTextApp.Design.Menu_Button();
            this.menu_Button_new = new ImageToTextApp.Design.Menu_Button();
            this.menu_Button_alege = new ImageToTextApp.Design.Menu_Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox.Location = new System.Drawing.Point(205, 21);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(646, 322);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(215, 518);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(626, 275);
            this.textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(14, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 347);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aplicatie ce identifica textul dintr-o imagine";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.menu_Button_save);
            this.panel1.Controls.Add(this.menu_Button_exit);
            this.panel1.Controls.Add(this.menu_Button_new);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 811);
            this.panel1.TabIndex = 5;
            // 
            // menu_Button_save
            // 
            this.menu_Button_save.BackColor = System.Drawing.Color.DarkGray;
            this.menu_Button_save.FlatAppearance.BorderSize = 0;
            this.menu_Button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_Button_save.ForeColor = System.Drawing.Color.Black;
            this.menu_Button_save.Location = new System.Drawing.Point(3, 467);
            this.menu_Button_save.Name = "menu_Button_save";
            this.menu_Button_save.Size = new System.Drawing.Size(188, 50);
            this.menu_Button_save.TabIndex = 12;
            this.menu_Button_save.Text = "Salvare text in fisier";
            this.menu_Button_save.UseVisualStyleBackColor = false;
            this.menu_Button_save.Click += new System.EventHandler(this.menu_Button_save_Click);
            // 
            // menu_Button_exit
            // 
            this.menu_Button_exit.BackColor = System.Drawing.Color.DarkGray;
            this.menu_Button_exit.FlatAppearance.BorderSize = 0;
            this.menu_Button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_Button_exit.ForeColor = System.Drawing.Color.Black;
            this.menu_Button_exit.Location = new System.Drawing.Point(3, 523);
            this.menu_Button_exit.Name = "menu_Button_exit";
            this.menu_Button_exit.Size = new System.Drawing.Size(188, 50);
            this.menu_Button_exit.TabIndex = 13;
            this.menu_Button_exit.Text = "Iesire";
            this.menu_Button_exit.UseVisualStyleBackColor = false;
            this.menu_Button_exit.Click += new System.EventHandler(this.menu_Button_exit_Click);
            // 
            // menu_Button_new
            // 
            this.menu_Button_new.BackColor = System.Drawing.Color.DarkGray;
            this.menu_Button_new.FlatAppearance.BorderSize = 0;
            this.menu_Button_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_Button_new.ForeColor = System.Drawing.Color.Black;
            this.menu_Button_new.Location = new System.Drawing.Point(3, 411);
            this.menu_Button_new.Name = "menu_Button_new";
            this.menu_Button_new.Size = new System.Drawing.Size(188, 50);
            this.menu_Button_new.TabIndex = 11;
            this.menu_Button_new.Text = "Alege o alta imagine";
            this.menu_Button_new.UseVisualStyleBackColor = false;
            this.menu_Button_new.Click += new System.EventHandler(this.menu_Button_alege_Click);
            // 
            // menu_Button_alege
            // 
            this.menu_Button_alege.BackColor = System.Drawing.Color.DarkGray;
            this.menu_Button_alege.FlatAppearance.BorderSize = 0;
            this.menu_Button_alege.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_Button_alege.ForeColor = System.Drawing.Color.Black;
            this.menu_Button_alege.Location = new System.Drawing.Point(406, 393);
            this.menu_Button_alege.Name = "menu_Button_alege";
            this.menu_Button_alege.Size = new System.Drawing.Size(244, 66);
            this.menu_Button_alege.TabIndex = 6;
            this.menu_Button_alege.Text = "Apasati aici pentru a selecta o imagine";
            this.menu_Button_alege.UseVisualStyleBackColor = false;
            this.menu_Button_alege.Click += new System.EventHandler(this.menu_Button_alege_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(187, 480);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(679, 35);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rezultat";
            // 
            // ImageToText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 805);
            this.Controls.Add(this.menu_Button_alege);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel3);
            this.Name = "ImageToText";
            this.Text = "ImageToText";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox;
        private TextBox textBox;
        private Label label1;
        private Panel panel1;
        private Label label_rez;
        private Panel panel2;
        private Design.Menu_Button menu_Button_new;
        private Design.Menu_Button menu_Button_save;
        private Design.Menu_Button menu_Button_exit;
        private Design.Menu_Button menu_Button_alege;
        private Panel panel3;
        private Label label2;
    }
}