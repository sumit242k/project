using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ROUND1 : Form
    {
        //quiz game variable
        int correctAnswer;
        int questionNumber=1;
        int score;
        int percentage;
        int totalQuestion;


        public ROUND1()
        {
            InitializeComponent();

            askQuestion(questionNumber);
            totalQuestion = 7;
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag==correctAnswer)
            {
                score++; 
            }
            if(questionNumber== totalQuestion)
            {
                //work on percentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestion);
               DialogResult done= MessageBox.Show("TEST ENDED!" + Environment.NewLine +
                 "You have answered " + score + " questions correctly." + Environment.NewLine +
                 "Total questions attempted " + totalQuestion + "."+ Environment.NewLine +
                 "Your total percentage is " + percentage + "%" + Environment.NewLine +
                 "Do you wish to attempt the exam again?", "result box", MessageBoxButtons.YesNo);
                if(done == DialogResult.No)
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
            switch(qnum)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources.question_mark_PNG134;
                    label3.Text = "Which of the following type of class allows only one object of it to be created?";
                    button2.Text = "Virtual class";
                    button3.Text = "Abstract class";
                    button4.Text = "Singleton class";
                    button5.Text = "Friend class";

                    correctAnswer = 3;

                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources.question_mark_PNG134;
                    label3.Text = "Which of the following is not type of constructor?";
                    button2.Text = "Copy constructor";
                    button3.Text = "Friend constructor";
                    button4.Text = "Defualt constructor";
                    button5.Text = "Parameterized constructor";

                    correctAnswer = 2;

                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources.question_mark_PNG134;
                    label3.Text = "Which of the following is not the member of class?";
                    button2.Text = "Static function";
                    button3.Text = "Friend function";
                    button4.Text = "Const function";
                    button5.Text = "Virtual function";

                    correctAnswer = 2;

                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources.question_mark_PNG134;
                    label3.Text = "Which of the following concept means detemining at runtime what method to invoke?";
                    button2.Text = "Data hiding";
                    button3.Text = "Dynamic typing";
                    button4.Text = "Dynamic binding";
                    button5.Text = "Dynamic loading";

                    correctAnswer = 3;

                    break;
                case 5:
                    pictureBox2.Image = Properties.Resources.question_mark_PNG134;
                    label3.Text = "Which of the following term is used for a function defined inside a class?";
                    button2.Text = "Member variable";
                    button3.Text = "Member funtion";
                    button4.Text = "Class function";
                    button5.Text = "Classic function";

                    correctAnswer = 2;

                    break;
                case 6:
                    pictureBox2.Image = Properties.Resources.question_mark_PNG134;
                    label3.Text = "How many instances of an abstract class can be created?";
                    button2.Text = "1";
                    button3.Text = "5";
                    button4.Text = "13";
                    button5.Text = "0";

                    correctAnswer = 4;

                    break;
                case 7:
                    pictureBox2.Image = Properties.Resources.question_mark_PNG134;
                    label3.Text = "Which of the following cannot be friend?";
                    button2.Text = "Function";
                    button3.Text = "Class";
                    button4.Text = "Object";
                    button5.Text = "Operator function";

                    correctAnswer = 3;

                    break;
            }
        
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            homepage ss = new homepage();
            ss.Show();
        }

        private void ROUND1_Load(object sender, EventArgs e)
        {

        }
    }
}
