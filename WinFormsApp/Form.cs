using Patagames.Ocr;
using System.Text.RegularExpressions;

namespace ImageToTextApp
{
    public partial class ImageToText : Form
    {
     
        private string photopath; //variabila pentru calea imaginii
        private byte[] binaryphoto; //stocheaza numarul de biti 
        string plainText; //stocheaza textul identificat din imaginea aleasa
        public ImageToText()
        {
            InitializeComponent();
            //setam ce componente vrem sa fie vizibile
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
            //in momemntul apasati butonului utilizatorul va putea alege o imagine care sa fie afisata si din care sa se idetifice literele
            menu_Button_alege.Visible = false;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "All files (*.*)|*.*|Jpegs|*.Jpegs|Png|*.png|Gif|*.Gif|jpg|*.jpg|Bitmaps|*.Bitmaps"; //specificam ce formate se fie disponibile
            file.Title = "Alegeti un format";
            if (file.ShowDialog() == DialogResult.OK)
            {
                
                pictureBox.Image = new Bitmap(file.OpenFile()); 
                photopath = file.FileName;//salvam calea imaginii
                FileStream fs = new FileStream(photopath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                binaryphoto = br.ReadBytes((int)fs.Length);  //Citește numărul specificat de biti din fluxul curent într-o matrice de biti
                                                             //și avansează poziția curentă cu acel număr de biti.
                fs.Close();

            }

            //folosim framework-ul Tesseract.Net 
            using (var objOcr = OcrApi.Create()) //cream o instanta pentru clasa OcrApi
            {
                int ok = 0;
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);         //initiazlizam limba       
                plainText = objOcr.GetTextFromImage((Bitmap)pictureBox.Image);  //preluam textul din imagine
                textBox.Text = plainText;  //afisam textul preluat in textbox
               
                //verificam daca exista litere si daca nu afisam un mesaj de erroare
                foreach (char simbol in plainText)      
                    if (Char.IsLetter(simbol))
                        ok = 1;               
                if (ok == 0)
                    textBox.Text = "Nu s-a gasit nici o litera";

                //afisam componentele
                panel3.Visible = true;
                label2.Visible= true; 
                textBox.Visible = true;
                menu_Button_exit.Visible = true;
                menu_Button_new.Visible = true;
                menu_Button_save.Visible = true;
                pictureBox.Visible = true;
                
            }
        }

        //la apasarea butonului iesire se iese din aplicatie
        private void menu_Button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        
        private void menu_Button_save_Click(object sender, EventArgs e)
        {
            StreamWriter S;
            S = File.CreateText(photopath + ".txt"); //cream fisierul txt 
            S.WriteLine(plainText);  //salvam in fisierul txt creat textul identificat din imagine
            S.Close();
        }
    }
}