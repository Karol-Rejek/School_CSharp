using Microsoft.VisualBasic;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    enum Questions
    {
        Question1, Question2, Question3, Question4
    }

    enum Answers
    {
        A, B, C, D
    }

    public partial class FormTest : Form
    {

        Dictionary<Questions, List<Answers>> goodAnswersDictionary = new Dictionary<Questions, List<Answers>>();
        Dictionary<Questions, List<string>> goodTextAnswersDictionary = new Dictionary<Questions, List<string>>();
        Dictionary<Questions, Dictionary<Answers, CheckBox>> answersCheckBoxDictionary = new Dictionary<Questions, Dictionary<Answers, CheckBox>>();
        Dictionary<Questions, Dictionary<Answers, RadioButton>> answersRadioButtonDictionary = new Dictionary<Questions, Dictionary<Answers, RadioButton>>();
        Dictionary<Questions, TextBox> answersTextQuestionsDictionary = new Dictionary<Questions, TextBox>();
        public FormTest()
        {
            InitializeComponent();

            //dictionary
            List<Answers> answers = new List<Answers>();
            answers.Add(Answers.D);
            goodAnswersDictionary.Add(Questions.Question1,answers);
            answers = new List<Answers>();
            answers.Add(Answers.B);
            goodAnswersDictionary.Add(Questions.Question2, answers);
            answers = new List<Answers>();
            answers.Add(Answers.B);
            answers.Add(Answers.C);
            goodAnswersDictionary.Add(Questions.Question3, answers);

            List<string> answersTextList = new List<string>();
            answersTextList.Add("ZIEMIA");
            goodTextAnswersDictionary.Add(Questions.Question4, answersTextList);

            Dictionary<Answers, CheckBox> answersCheckBox_Q1 = new Dictionary<Answers, CheckBox>();
            answersCheckBox_Q1.Add(Answers.A, checkBoxQuestion3A);
            answersCheckBox_Q1.Add(Answers.B, checkBoxQuestion3B);
            answersCheckBox_Q1.Add(Answers.C, checkBoxQuestion3C);
            answersCheckBox_Q1.Add(Answers.D, checkBoxQuestion3D);

            answersCheckBoxDictionary.Add(Questions.Question3, answersCheckBox_Q1);

            Dictionary<Answers, RadioButton> answersRadioButton_Q1 = new Dictionary<Answers, RadioButton>();
            answersRadioButton_Q1.Add(Answers.A, radioButtonQuestion1A);
            answersRadioButton_Q1.Add(Answers.B, radioButtonQuestion1B);
            answersRadioButton_Q1.Add(Answers.C, radioButtonQuestion1C);
            answersRadioButton_Q1.Add(Answers.D, radioButtonQuestion1D);

            Dictionary<Answers, RadioButton> answersRadioButton_Q2 = new Dictionary<Answers, RadioButton>();
            answersRadioButton_Q2.Add(Answers.A, radioButtonQuestion2A);
            answersRadioButton_Q2.Add(Answers.B, radioButtonQuestion2B);
            answersRadioButton_Q2.Add(Answers.C, radioButtonQuestion2C);
            answersRadioButton_Q2.Add(Answers.D, radioButtonQuestion2D);

            answersRadioButtonDictionary.Add(Questions.Question1, answersRadioButton_Q1);
            answersRadioButtonDictionary.Add(Questions.Question2, answersRadioButton_Q2);

            answersTextQuestionsDictionary.Add(Questions.Question4, textBoxQuestion4);
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Twój wynik to: " + CheckAnswers() + " /5");
        }

        private int CheckAnswers()
        {
            int wynik = 0;
            
            wynik += CheckRadioButtonAnswers();
            wynik += CheckCheckBoxAnswers();
            wynik += CheckTextBoxAnswers();

            return wynik;
        }

        private int CheckRadioButtonAnswers()
        {
            int wynik = 0;

            foreach (KeyValuePair<Questions, Dictionary<Answers, RadioButton>> questionAnswers in answersRadioButtonDictionary)
            {
                List<Answers> listOfGoodAnswers = goodAnswersDictionary[questionAnswers.Key];
                foreach (KeyValuePair<Answers, RadioButton> answers in questionAnswers.Value)
                {
                    if (!answers.Value.Checked)
                        continue;
                    if (listOfGoodAnswers.Contains(answers.Key))
                    {
                        wynik++;
                        break;
                    }
                    else
                    {
                        wynik--;
                    }
                }
            }

            return wynik;
        }

        private int CheckCheckBoxAnswers()
        {
            int wynik = 0;

            foreach (KeyValuePair<Questions, Dictionary<Answers, CheckBox>> questionAnswers in answersCheckBoxDictionary)
            {
                List<Answers> listOfGoodAnswers = goodAnswersDictionary[questionAnswers.Key];
                foreach (KeyValuePair<Answers, CheckBox> answers in questionAnswers.Value)
                {
                    if (!answers.Value.Checked)
                        continue;
                    if (listOfGoodAnswers.Contains(answers.Key) )
                    {
                        wynik++;
                    }
                    else
                    {
                        wynik--;
                    }
                }
            }

            return wynik; 
        }

        private int CheckTextBoxAnswers()
        {
            int wynik = 0;
            foreach (KeyValuePair<Questions, TextBox> playerAnswer in answersTextQuestionsDictionary)
            {
                List<string> listOfGoodAnswers = goodTextAnswersDictionary[playerAnswer.Key];
                if (listOfGoodAnswers.Contains(playerAnswer.Value.Text.Trim().ToUpper()))
                {
                    wynik++;
                }
                else
                {
                    wynik--;
                }
            }
            return wynik;
        }
    }
}
