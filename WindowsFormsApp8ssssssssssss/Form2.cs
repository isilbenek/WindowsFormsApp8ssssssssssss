using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8ssssssssssss
{
    public partial class Form2 : Form
    {

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestions;
        
        
        public Form2()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 15;
            lblSoru.BackColor = Color.Transparent;
            lblSayi.BackColor = Color.Transparent;
            lblSkor.BackColor = Color.Transparent;
            lblKalanSure.BackColor = Color.Transparent;
            
            }

        int  saniye =0;
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            progressBar1.Maximum = 59;
        }
        private void checkAnswerClick(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score += 10;
                lblSayi.Text = score.ToString();
            }

            if (questionNumber == totalQuestions)
            {

                MessageBox.Show("Test sona erdi!" + Environment.NewLine + "skor:" +
                score + "  " + "soruyu doğru cevapladınız!" + Environment.NewLine
                + Environment.NewLine +
                 "Yeniden oynamak için TAMAM yazısına tıklayın");

                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);
        }

        private void dönClick(object sender, EventArgs e)
        {

             Form1 f1 = new Form1();
            f1.Show();
        }

        private void askQuestion(int qNum)
        {
            switch (qNum)
            {
                case 1:
                    button1.Text = "Yüz";
                    button2.Text = "Kelime";
                    button3.Text = "Aşağı";
                    button4.Text = "Yukarı";
                    correctAnswer = 1;
                    break;
                case 2:
                    button1.Text = "Baba";
                    button2.Text = "Bardak";
                    button3.Text = "Çay";
                    button4.Text = "Su";
                    correctAnswer = 3;
                    break;

                case 3:
                    button1.Text = "Selam";
                    button2.Text = "El";
                    button3.Text = "Yabancı";
                    button4.Text = "Tabak";
                    correctAnswer = 2;
                    break;

                case 4:
                    button1.Text = "Araba";
                    button2.Text = "Bal";
                    button3.Text = "Dil";
                    button4.Text = "Bin";
                    correctAnswer = 4;
                    break;

                case 5:
                    button1.Text = "Atlet";
                    button2.Text = "Kasaba";
                    button3.Text = "Yalancı";
                    button4.Text = "Tarak";
                    correctAnswer = 1;
                    break;

                case 6:
                    button1.Text = "Kol";
                    button2.Text = "Bacak";
                    button3.Text = "Diz";
                    button4.Text = "Kahve";
                    correctAnswer = 3;
                    break;
                case 7:
                    button1.Text = "Aç";
                    button2.Text = "Elbise";
                    button3.Text = "Masa";
                    button4.Text = "Kalem";
                    correctAnswer = 1;
                    break;
                case 8:
                    button1.Text = "Deli";
                    button2.Text = "Siyah";
                    button3.Text = "Hayır";
                    button4.Text = "Güneş";
                    correctAnswer = 3;
                    break;
                case 9:
                    button1.Text = "Bilgisayar";
                    button2.Text = "Kırmızı";
                    button3.Text = "Yürek";
                    button4.Text = "Alay";
                    correctAnswer = 4;
                    break;
                case 10:
                    button1.Text = "Sanat";
                    button2.Text = "Saat";
                    button3.Text = "Müzik";
                    button4.Text = "Güç";
                    correctAnswer = 4;
                    break;
                case 11:
                    button1.Text = "Deniz";
                    button2.Text = "İç";
                    button3.Text = "Hayal";
                    button4.Text = "Bulut";
                    correctAnswer = 2;
                    break;
                case 12:
                    button1.Text = "Sepet";
                    button2.Text = "Sohbet";
                    button3.Text = "Renk";
                    button4.Text = "Sıra";
                    correctAnswer = 4;
                    break;
                case 13:
                    button1.Text = "Ocak";
                    button2.Text = "Soluk";
                    button3.Text = "Şubat";
                    button4.Text = "Kamera";
                    correctAnswer = 1;
                    break;
                case 14:
                    button1.Text = "Boş";
                    button2.Text = "Kapalı";
                    button3.Text = "Dolu";
                    button4.Text = "Dolap";
                    correctAnswer = 3;
                    break;
                case 15:
                    button1.Text = "Kahve";
                    button2.Text = "Bağ";
                    button3.Text = "Lamba";
                    button4.Text = "Ayna";
                    correctAnswer = 2;
                    break;

            }


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            progressBar1.Value = saniye;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

            saniye = 0;
            timer1.Start();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

       

    }
}

     

       

