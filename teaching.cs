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
    public partial class teaching : Form
    {
        //variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestion;

        public teaching()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestion = 7;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            homepage ss = new homepage();
            ss.Show();
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if(questionNumber==totalQuestion)
            {
                //percentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestion);
                DialogResult done = MessageBox.Show("TEST ENDED!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Total questions attempted= " + totalQuestion + "." + Environment.NewLine +
                    "Your total percentage is " +percentage +"%" + Environment.NewLine +
                    "Do you wish to attempt the exam again?", "Result Box", MessageBoxButtons.YesNo);
                if(done==DialogResult.No)
                { this.Hide();
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
            switch(qnum)
            {
                case 1:
                    pictureBox3.Image = Properties.Resources.books;
                    Teachingques.Text = "The primary responsibilty for the teacher's adjustment lies with";
                    button1.Text = "The children";
                    button2.Text = "The principal";
                    button3.Text = "The teacher himself";
                    button4.Text = "The community";
                    correctAnswer = 3;

                    break;
                case 2:
                    pictureBox3.Image = Properties.Resources.books;
                    Teachingques.Text = "Research has shown that the most frequent symptom of nervous instability among teacher is";
                    button1.Text = "Digestive upsets";
                    button2.Text = "Explosive behavior";
                    button3.Text = "Fatigue";
                    button4.Text = "Worry";
                    correctAnswer = 2;
                    break;
                case 3:
                    pictureBox3.Image = Properties.Resources.books;
                    Teachingques.Text = "Which of the following is not a characterstic of a good achievement test?";
                    button1.Text = "Reliability";
                    button2.Text = "Objectivity";
                    button3.Text = "Ambiguity";
                    button4.Text = "Validity";
                    correctAnswer = 3;
                    break;
                case 4:
                    pictureBox3.Image = Properties.Resources.books;
                    Teachingques.Text = "Which of the following does not belong to a projected aid?";
                    button1.Text = "Overhead projector";
                    button2.Text = "Blackboard";
                    button3.Text = "Epidiascope";
                    button4.Text = "Slide projector";
                    correctAnswer = 2;
                    break;
                case 5:
                    pictureBox3.Image = Properties.Resources.books;
                    Teachingques.Text = "By which of the followingmethods the true evaluation of the students is possible?";
                    button1.Text = "End of course";
                    button2.Text = "Twice a year";
                    button3.Text = "Continuous";
                    button4.Text = "Formative";
                    correctAnswer = 3;
                    break;
                case 6:
                    pictureBox3.Image = Properties.Resources.books;
                    Teachingques.Text = "Which of the following belong to the projected aid?";
                    button1.Text = "Blackboard";
                    button2.Text = "Diorama";
                    button3.Text = "Epidiascope";
                    button4.Text = "Globe";
                    correctAnswer = 3;
                    break;
                case 7:
                    pictureBox3.Image = Properties.Resources.books;
                    Teachingques.Text = "A good evaluation of writen material should not be based on";
                    button1.Text = "Linguistic expression";
                    button2.Text = "Logical presentation";
                    button3.Text = "Ability to reproduce whatever is read";
                    button4.Text = "Comprehension of subject";
                    correctAnswer = 3;
                    break;
            }
        }
    }
}
