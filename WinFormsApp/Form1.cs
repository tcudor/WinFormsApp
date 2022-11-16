using Patagames.Ocr;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox.ImageLocation = @"D:\tudorg\personal\repos\WinFormsApp\WinFormsApp\imgs\test.png";
        }


        private void button_Click(object sender, EventArgs e)
        {
            using (var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);

                string plainText = objOcr.GetTextFromImage(pictureBox.ImageLocation);

                textBox.Text = plainText;
            }
        }
    }
}