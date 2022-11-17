using Patagames.Ocr;

namespace ImageToTextApp
{
    public partial class ImageToText : Form
    {
        private string photopath;
        private byte[] binaryphoto;
        public ImageToText()
        {
            InitializeComponent();
            textBox.Visible = false;
            //  label_rez.Visible = false;
            panel2.Visible = false;
            button_exit.Visible = false;
            button_new.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_alege.Visible = false;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Jpegs|*.Jpegs|png|*.png|GIF|*.Gif|jpg|*.jpg|Bitmaps|*.Bitmaps";
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
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);

                string plainText = objOcr.GetTextFromImage((Bitmap)pictureBox.Image);

                textBox.Text = plainText;
                panel2.Visible = true;
                // label_rez.Visible = true;
                textBox.Visible = true;
                button_exit.Visible = true;
                button_new.Visible = true;
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}