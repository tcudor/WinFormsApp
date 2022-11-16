using Patagames.Ocr;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private string photopath;
        private byte[] binaryphoto;
        public Form1()
        {
            InitializeComponent();
           // pictureBox.ImageLocation = @"D:\tudorg\personal\repos\WinFormsApp\WinFormsApp\imgs\test.png";
        }


        private void button_Click(object sender, EventArgs e)
        {
            using (var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);

                string plainText = objOcr.GetTextFromImage((Bitmap)pictureBox.Image);

                textBox.Text = plainText;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file=new OpenFileDialog();
            file.Filter = "Jpegs|*.Jpegs|png|*.png|GIF|*.Gif|jpg|*.jpg|Bitmaps|*.Bitmaps";
            file.Title = "please select";
            if(file.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(file.OpenFile());
                photopath = file.FileName;
                FileStream fs = new FileStream(photopath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                binaryphoto = br.ReadBytes((int)fs.Length);
                fs.Close();

            }
        }
    }
}