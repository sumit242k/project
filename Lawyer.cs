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
    public partial class Lawyer : Form
    {
        //variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestion;

        public Lawyer()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestion = 7;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if(buttonTag==correctAnswer)
            {
                score++;
            }
            if(questionNumber==totalQuestion)
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
                    pictureBox3.Image = Properties.Resources.lawyer;
                    LawyerQues.Text = "By which amendment was the sinfhi language added in the VIII schedule of constitution?";
                    button1.Text = "21st amendment, 1967";
                    button2.Text = "103rd amendment, 2019";
                    button3.Text = "87th amendment, 2003";
                    button4.Text = "12th amendment, 1961";
                    correctAnswer = 1;
                    break;

                case 2:
                    pictureBox3.Image = Properties.Resources.lawyer;
                    LawyerQues.Text = "Who is considered as the custodian of public purse?";
                    button1.Text = "Finance minister";
                    button2.Text = "Comptroller and auditor general of india";
                    button3.Text = "Prime minister";
                    button4.Text = "Rbi government";
                    correctAnswer = 2;
                    break;

                case 3:
                    pictureBox3.Image = Properties.Resources.lawyer;
                    LawyerQues.Text = "For how many years a person has to be high court judge to become a supreme court " + Environment.NewLine +
                        "judge?";
                    button1.Text = "7";
                    button2.Text = "9";
                    button3.Text = "4";
                    button4.Text = "5";
                    correctAnswer = 4;
                    break;

                case 4:
                    pictureBox3.Image = Properties.Resources.lawyer;
                    LawyerQues.Text = "Code of criminal procedure is a subject matter of which list?";
                    button1.Text = "Past list";
                    button2.Text = "Single list";
                    button3.Text = "Concurrent list";
                    button4.Text = "Criminal list";
                    correctAnswer = 3;
                    break;

                case 5:
                    pictureBox3.Image = Properties.Resources.lawyer;
                    LawyerQues.Text = "Secularism was added in the preamble by which amendment?";
                    button1.Text = "34th";
                    button2.Text = "65th";
                    button3.Text = "42nd";
                    button4.Text = "18th";
                    correctAnswer = 3;
                    break;

                case 6:
                    pictureBox3.Image = Properties.Resources.lawyer;
                    LawyerQues.Text = "Who is considered as the father of Indian evidence act?";
                    button1.Text = "James stephan";
                    button2.Text = "J. Wigmore";
                    button3.Text = "B.R Ambedkar";
                    button4.Text = "Adam smith";
                    correctAnswer = 1;
                    break;

                case 7:
                    pictureBox3.Image = Properties.Resources.lawyer;
                    LawyerQues.Text = "Under Hindu law marriage is a-?";
                    button1.Text = "Just a marriage";
                    button2.Text = "Sacrament";
                    button3.Text = "Contract";
                    button4.Text = "Union";
                    correctAnswer = 2;
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
