using Patagames.Ocr;
using System.Text.RegularExpressions;

namespace ImageToTextApp
{
    public partial class ImageToText : Form
    {
        private string photopath;
        private byte[] binaryphoto;
        string plainText;
        public ImageToText()
        {
            InitializeComponent();
            textBox.Visible = false;
            label2.Visible = false;
            panel3.Visible = false;
            menu_Button_exit.Visible = false;
            menu_Button_new.Visible = false;
            menu_Button_save.Visible = false;
            pictureBox.Visible = false;
            menu_Button_alege.Visible = true;
        }

        private void menu_Button_alege_Click(object sender, EventArgs e)
        {
            menu_Button_alege.Visible = false;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "All files (*.*)|*.*|Jpegs|*.Jpegs|Png|*.png|Gif|*.Gif|jpg|*.jpg|Bitmaps|*.Bitmaps";
            file.Title = "please select";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(file.OpenFile());
                photopath = file.FileName;
                FileStream fs = new FileStream(photopath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                binaryphoto = br.ReadBytes((int)fs.Length);
                fs.Close();

            }
            using (var objOcr = OcrApi.Create())
            {
                int ok = 0;
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);                
                plainText = objOcr.GetTextFromImage((Bitmap)pictureBox.Image);
                foreach (char simbol in plainText)
                {
                    if (Char.IsLetter(simbol))
                    {
                        textBox.Text = textBox.Text + simbol;
                        ok = 1;
                    }
                }
                if (ok == 0)
                    textBox.Text = "Nu s-a gasit nici o litera";
                panel3.Visible = true;
                label2.Visible= true;
                textBox.Visible = true;
                menu_Button_exit.Visible = true;
                menu_Button_new.Visible = true;
                menu_Button_save.Visible = true;
                pictureBox.Visible = true;
                
            }
        }

        private void menu_Button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menu_Button_save_Click(object sender, EventArgs e)
        {
            string name = pictureBox.Name;
            StreamWriter S;
            S = File.CreateText(photopath + ".txt");
            S.WriteLine(plainText);
            S.Close();
        }
    }
}