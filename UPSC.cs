using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UPSC : Form
    {
        //variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestion;

        public UPSC()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestion = 7;
        }

        private void askAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestion)
            { //percentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestion);
                DialogResult done = MessageBox.Show("TEST ENDED!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Total questions attempted= " + totalQuestion + "." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Do you wish to attempt the exam again?", "Result Box", MessageBoxButtons.YesNo);
                if (done == DialogResult.No)
                {
                    this.Hide();
                    homepage ss = new homepage();
                    ss.Show();
                }
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox3.Image = Properties.Resources.UPSC;
                    UPSCques.Text = "The 'World water development report' is a flagship report of which organisation?";
                    button1.Text = "UN Environment programme";
                    button2.Text = "Global water intelligence";
                    button3.Text = "UN-Water";
                    button4.Text = "International water association";
                    correctAnswer = 3;
                    break;

                case 2:
                    pictureBox3.Image = Properties.Resources.UPSC;
                    UPSCques.Text = "Which state has cheapest vegterian thali as per economic survey 2019-20?";
                    button1.Text = "Punjab";
                    button2.Text = "Jharkhand";
                    button3.Text = "UP";
                    button4.Text = "Bihar";
                    correctAnswer = 2;
                    break;

                case 3:
                    pictureBox3.Image = Properties.Resources.UPSC;
                    UPSCques.Text = "which state has the highest forest cover as per the state of forest report 2019?";
                    button1.Text = "Jharkhand";
                    button2.Text = "Madhya Pradesh";
                    button3.Text = "Uttar Pradesh";
                    button4.Text = "Meghalaya";
                    correctAnswer = 2;
                    break;

                case 4:
                    pictureBox3.Image = Properties.Resources.UPSC;
                    UPSCques.Text = "When did India celebrate its 70th constitution day?";
                    button1.Text = "July 22";
                    button2.Text = "October 18";
                    button3.Text = "November 26";
                    button4.Text = "January 15";
                    correctAnswer = 3;
                    break;

                case 5:
                    pictureBox3.Image = Properties.Resources.UPSC;
                    UPSCques.Text = "When is the Global handwashing day observed every year?";
                    button1.Text = "August 12";
                    button2.Text = "September 6";
                    button3.Text = "October 15";
                    button4.Text = "November 20";
                    correctAnswer = 3;
                    break;

                case 6:
                    pictureBox3.Image = Properties.Resources.UPSC;
                    UPSCques.Text = "India was ranked at which position in World bank's ease of doing business ranking 2019?";
                    button1.Text = "43rd";
                    button2.Text = "55th";
                    button3.Text = "60th";
                    button4.Text = "63rd";
                    correctAnswer = 4;
                    break;

                case 7:
                    pictureBox3.Image = Properties.Resources.UPSC;
                    UPSCques.Text = "Which organisation or body appointed the UK sinha committee on MSMEs?";
                    button1.Text = "Reserve bank of india";
                    button2.Text = "Ministry of MSME";
                    button3.Text = "Ministry of heavy industry";
                    button4.Text = "NITI aayog";
                    correctAnswer = 1;
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            homepage ss = new homepage();
            ss.Show();
        }
    }
}
