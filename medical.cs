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
    public partial class medical : Form
    {
        //variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestion;

        public medical()
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

            if(buttonTag==correctAnswer)
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
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Do you wish to attempt the exam again?", "result box", MessageBoxButtons.YesNo);
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
                    pictureBox3.Image = Properties.Resources.medd;
                    medicalQuest.Text = "The renal medulla is composed of tissue called?";
                    button1.Text = "Renal pyramids";
                    button2.Text = "Nephrons";
                    button3.Text = "Renal sinus";
                    button4.Text = "Renal pelvis";
                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox3.Image = Properties.Resources.medd;
                    medicalQuest.Text = "Which is found in highest concentration in the urine?";
                    button1.Text = "Uric acid";
                    button2.Text = "Urea";
                    button3.Text = "Glucose";
                    button4.Text = "Creatinine";
                    correctAnswer = 2;

                    break;
                case 3:
                    pictureBox3.Image = Properties.Resources.medd;
                    medicalQuest.Text = "The middle layer of urinary bladder is?";
                    button1.Text = "Mucous coat";
                    button2.Text = "Submucous coat";
                    button3.Text = "Muscular coat";
                    button4.Text = "sphincter coat";
                    correctAnswer = 2;

                    break;
                case 4:
                    pictureBox3.Image = Properties.Resources.medd;
                    medicalQuest.Text = "The micturition reflex center is located in the___";
                    button1.Text = "Pons";
                    button2.Text = "Midbrain";
                    button3.Text = "Lumbar plexus";
                    button4.Text = "Sacral plexus";
                    correctAnswer = 4;

                    break;
                case 5:
                    pictureBox3.Image = Properties.Resources.medd;
                    medicalQuest.Text = "Which of the following match with the definition: a poor output of urine?";
                    button1.Text = "Oliguria";
                    button2.Text = "Pyruia";
                    button3.Text = "Enuresis";
                    button4.Text = "Diuresis";
                    correctAnswer = 1;

                    break;
                case 6:
                    pictureBox3.Image = Properties.Resources.medd;
                    medicalQuest.Text = "Capillary loops located in the medulla are also known as ____";
                    button1.Text = "Vasa recta";
                    button2.Text = "Urea collector";
                    button3.Text = "Trigone";
                    button4.Text = "Macula densa";
                    correctAnswer = 1;

                    break;
                case 7:
                    pictureBox3.Image = Properties.Resources.medd;
                    medicalQuest.Text = "Juxtaglonerular cells combine with __ cells to form the juxtagomerular apparatus in the kidney";
                    button1.Text = "Macula densa";
                    button2.Text = "Renal pelvis";
                    button3.Text = "Nephron";
                    button4.Text = "Renal sinus";
                    correctAnswer = 1;

                    break;
            }
        }
    }
}
