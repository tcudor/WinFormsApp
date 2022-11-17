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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button_alege = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_rez = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox.Location = new System.Drawing.Point(221, 146);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(437, 297);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(143, 545);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(596, 239);
            this.textBox.TabIndex = 2;
            // 
            // button_alege
            // 
            this.button_alege.Location = new System.Drawing.Point(356, 249);
            this.button_alege.Name = "button_alege";
            this.button_alege.Size = new System.Drawing.Size(162, 72);
            this.button_alege.TabIndex = 3;
            this.button_alege.Text = "Apasati aici pentru a alege o imagine ";
            this.button_alege.UseVisualStyleBackColor = true;
            this.button_alege.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(154, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aplicatie ce preia textul dintr-o imagine";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 84);
            this.panel1.TabIndex = 5;
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
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Controls.Add(this.label_rez);
            this.panel2.Location = new System.Drawing.Point(-2, 485);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 40);
            this.panel2.TabIndex = 7;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Firebrick;
            this.button_exit.Location = new System.Drawing.Point(757, 729);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(94, 55);
            this.button_exit.TabIndex = 8;
            this.button_exit.Text = "Iesire";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_new
            // 
            this.button_new.Location = new System.Drawing.Point(725, 259);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(105, 53);
            this.button_new.TabIndex = 9;
            this.button_new.Text = "Alege o alta imagine";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button1_Click);
            // 
            // ImageToText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(863, 805);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_alege);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "ImageToText";
            this.Text = "ImageToText";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}