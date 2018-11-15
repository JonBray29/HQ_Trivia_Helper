using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;
using Google.Cloud.Vision.V1;
using Google.Apis.Auth.OAuth2;
using Grpc.Auth;
using System.IO;
using System.Text.RegularExpressions;
using GoogleCSE;

namespace HQ_Answers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string question;
        private string answer1;
        private string answer2;
        private string answer3;
        private int count1;
        private int count2;
        private int count3;

        private void btnFind_Click(object sender, EventArgs e)
        {
            resetColours();
            captureQuestion();
            captureAnswer1();
            captureAnswer2();
            captureAnswer3();
            readQuestion();
            readAnswer1();
            readAnswer2();
            readAnswer3();
            showQuestion();
            showAnswer1();
            showAnswer2();
            showAnswer3();
            searchQuestion();
            searchAnswer1();
            searchAnswer2();
            searchAnswer3();
            changeColours();
        }

        //Reset text box colours --------------------------------------------------------------------------------------------------------------------
        private void resetColours()
        {
            txtAnswer1.BackColor = Color.White;
            txtAnswer2.BackColor = Color.White;
            txtAnswer3.BackColor = Color.White;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------

        //Capture Screenshots -----------------------------------------------------------------------------------------------------------------------
        private void captureQuestion()
        {
            Rectangle rect = new Rectangle(760, 230, 1150, 395);
            Bitmap bmp = new Bitmap(390, 165, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            bmp.Save(@"E:\Projects\HQ Answers\Capture\Question.JPG", ImageFormat.Jpeg);
        }
        private void captureAnswer1()
        {
            Rectangle rect = new Rectangle(760, 395, 1150, 460);
            Bitmap bmp = new Bitmap(390, 65, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            bmp.Save(@"E:\Projects\HQ Answers\Capture\A1.JPG", ImageFormat.Jpeg);
        }
        private void captureAnswer2()
        {
            Rectangle rect = new Rectangle(760, 460, 1150, 530);
            Bitmap bmp = new Bitmap(390, 70, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            bmp.Save(@"E:\Projects\HQ Answers\Capture\A2.JPG", ImageFormat.Jpeg);
        }
        private void captureAnswer3()
        {
            Rectangle rect = new Rectangle(760, 530, 1150, 600);
            Bitmap bmp = new Bitmap(390, 70, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            bmp.Save(@"E:\Projects\HQ Answers\Capture\A3.JPG", ImageFormat.Jpeg);
        }
        //End Capture screenshots -------------------------------------------------------------------------------------------------------------------
        
        //Use Google Vision to Extract Text From Screenshots ----------------------------------------------------------------------------------------
        private void readQuestion()
        {
            string jsonPath = @"E:\Projects\My Project 11722-a87347b406c3.json";
            var credential = GoogleCredential.FromFile(jsonPath).CreateScoped(ImageAnnotatorClient.DefaultScopes);
            var channel = new Grpc.Core.Channel(ImageAnnotatorClient.DefaultEndpoint.ToString(), credential.ToChannelCredentials());
            var client = ImageAnnotatorClient.Create(channel);
            var image = Google.Cloud.Vision.V1.Image.FromFile(@"E:\Projects\HQ Answers\Capture\Question.JPG");
            var response = client.DetectText(image);
            StreamWriter write = new StreamWriter(@"E:\Projects\question.txt");
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                {
                    string result = Regex.Replace(annotation.Description, @"\r\n?|\n", " ");
                    write.WriteLine(result);
                }
            }
            write.Close();
        }
        private void readAnswer1()
        {
            string jsonPath = @"E:\Projects\My Project 11722-a87347b406c3.json";
            var credential = GoogleCredential.FromFile(jsonPath).CreateScoped(ImageAnnotatorClient.DefaultScopes);
            var channel = new Grpc.Core.Channel(ImageAnnotatorClient.DefaultEndpoint.ToString(), credential.ToChannelCredentials());
            var client = ImageAnnotatorClient.Create(channel);
            var image = Google.Cloud.Vision.V1.Image.FromFile(@"E:\Projects\HQ Answers\Capture\A1.JPG");
            var response = client.DetectText(image);
            StreamWriter write = new StreamWriter(@"E:\Projects\A1.txt");
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                    write.WriteLine(annotation.Description);
            }
            write.Close();
        }
        private void readAnswer2()
        {
            string jsonPath = @"E:\Projects\My Project 11722-a87347b406c3.json";
            var credential = GoogleCredential.FromFile(jsonPath).CreateScoped(ImageAnnotatorClient.DefaultScopes);
            var channel = new Grpc.Core.Channel(ImageAnnotatorClient.DefaultEndpoint.ToString(), credential.ToChannelCredentials());
            var client = ImageAnnotatorClient.Create(channel);
            var image = Google.Cloud.Vision.V1.Image.FromFile(@"E:\Projects\HQ Answers\Capture\A2.JPG");
            var response = client.DetectText(image);
            StreamWriter write = new StreamWriter(@"E:\Projects\A2.txt");
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                    write.WriteLine(annotation.Description);
            }
            write.Close();
        }
        private void readAnswer3()
        {
            string jsonPath = @"E:\Projects\My Project 11722-a87347b406c3.json";
            var credential = GoogleCredential.FromFile(jsonPath).CreateScoped(ImageAnnotatorClient.DefaultScopes);
            var channel = new Grpc.Core.Channel(ImageAnnotatorClient.DefaultEndpoint.ToString(), credential.ToChannelCredentials());
            var client = ImageAnnotatorClient.Create(channel);
            var image = Google.Cloud.Vision.V1.Image.FromFile(@"E:\Projects\HQ Answers\Capture\A3.JPG");
            var response = client.DetectText(image);
            StreamWriter write = new StreamWriter(@"E:\Projects\A3.txt");
            foreach (var annotation in response)
            {
                if (annotation.Description != null)
                    write.WriteLine(annotation.Description);
            }
            write.Close();
        }
        //Finish Extracting Text Also Place Them Into Seperate .txt Files ---------------------------------------------------------------------------

        //Show the Questions and Answers in Text Boxes ----------------------------------------------------------------------------------------------
        private void showQuestion()
        {
            StreamReader read = new StreamReader(@"E:\Projects\question.txt");
            question = read.ReadLine();
            txtQuestion.Text = question;
            read.Close();
        }
        private void showAnswer1()
        {
            StreamReader read = new StreamReader(@"E:\Projects\A1.txt");
            answer1 = read.ReadLine();
            txtAnswer1.Text = answer1;
            read.Close();
        }
        private void showAnswer2()
        {
            StreamReader read = new StreamReader(@"E:\Projects\A2.txt");
            answer2 = read.ReadLine();
            txtAnswer2.Text = answer2;
            read.Close();
        }
        private void showAnswer3()
        {
            StreamReader read = new StreamReader(@"E:\Projects\A3.txt");
            answer3 = read.ReadLine();
            txtAnswer3.Text = answer3;
            read.Close();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------

        //Search the Question Using a Custom Search Engine ------------------------------------------------------------------------------------------
        private void searchQuestion()
        {
            var gs = new GoogleSearch("006096622735044125412:9uygw__isym", maxPages: 1, pageSize: 10, key: "AIzaSyBGgsiVhWkoQ_Q8SvRBCAn5I_7cg7O4yWA");
            var results = gs.Search(question);
            StreamWriter write = new StreamWriter(@"E:\Projects\Results.txt");
            foreach (var result in results)
            {
                if (result.Description != null)
                {
                    string description = result.Description.ToLower();
                    string content = Regex.Replace(description, @"</b>|<b>|<br>", " ");
                    write.WriteLine(content);
                }
            }
            write.Close();
        }
        //Output All Descriptions Into a txt File ---------------------------------------------------------------------------------------------------

        //Find Answer in txt ------------------------------------------------------------------------------------------------------------------------
        private void searchAnswer1()
        {
            string answer = answer1.ToLower();
            string text = File.ReadAllText(@"E:\Projects\Results.txt").ToLower();
            count1 = Regex.Matches(text, answer).Count;
            lblCount1.Text = Convert.ToString(count1);
        }
        private void searchAnswer2()
        {
            string answer = answer2.ToLower();
            string text = File.ReadAllText(@"E:\Projects\Results.txt").ToLower();
            count2 = Regex.Matches(text, answer).Count;
            lblCount2.Text = Convert.ToString(count2);
        }
        private void searchAnswer3()
        {
            string answer = answer3.ToLower();
            string text = File.ReadAllText(@"E:\Projects\Results.txt").ToLower();
            count3 = Regex.Matches(text, answer).Count;
            lblCount3.Text = Convert.ToString(count3);
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------

        //Using If Statements To Determine Which Count is Greater -----------------------------------------------------------------------------------
        private void changeColours()
        {
            if (count1 > count2 && count1 > count3)
            {   
            txtAnswer1.BackColor = Color.Lime;
            txtAnswer2.BackColor = Color.Red;
            txtAnswer3.BackColor = Color.Red;   
            }
            if (count2 > count1 && count2 > count3)
            {
                txtAnswer1.BackColor = Color.Red;
                txtAnswer2.BackColor = Color.Lime;
                txtAnswer3.BackColor = Color.Red;
            }
            if (count3 > count1 && count3 > count2)
            {
                txtAnswer1.BackColor = Color.Red;
                txtAnswer2.BackColor = Color.Red;
                txtAnswer3.BackColor = Color.Lime;
            }
            if (count1 > count2 && count1 == count3)
            {
                txtAnswer1.BackColor = Color.Lime;
                txtAnswer2.BackColor = Color.Red;
                txtAnswer3.BackColor = Color.Lime;
            }
            if (count2 > count1 && count2 == count3)
            {
                txtAnswer1.BackColor = Color.Red;
                txtAnswer2.BackColor = Color.Lime;
                txtAnswer3.BackColor = Color.Lime;
            }
            if (count1 > count3 && count1 == count2)
            {
                txtAnswer1.BackColor = Color.Lime;
                txtAnswer2.BackColor = Color.Lime;
                txtAnswer3.BackColor = Color.Red;
            }
        }
        //Which Ever is Greater Color TextBox In Green ----------------------------------------------------------------------------------------------
    }
}
