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

    public partial class FormTest : Form
    {
        Dictionary<Questions, Func<string, int>> goodAnswersDictionary = new();
        Dictionary<Questions, List<CheckBox>> answersCheckBoxDictionary = new();
        Dictionary<Questions, List<RadioButton>> answersRadioButtonDictionary = new();
        Dictionary<Questions, TextBox> answersTextQuestionsDictionary = new();
        public FormTest()
        {
            InitializeComponent();

            //dictionary

            goodAnswersDictionary.Add(Questions.Question1, (string answer) => answer == "4" ? 1 : -1);
            goodAnswersDictionary.Add(Questions.Question2, (string answer) => answer.ToUpper() == "KOTA" ? 1 : -1);
            goodAnswersDictionary.Add(Questions.Question3, (string answer) => answer == "2" || answer == "86" ? 1 : -1);
            goodAnswersDictionary.Add(Questions.Question4, (string answer) => answer.Trim().ToUpper() == "ZIEMIA" ? 1 : -1);

            List<CheckBox> answersCheckBox_Q1 = new();
            answersCheckBox_Q1.Add(checkBoxQuestion3A);
            answersCheckBox_Q1.Add(checkBoxQuestion3B);
            answersCheckBox_Q1.Add(checkBoxQuestion3C);
            answersCheckBox_Q1.Add(checkBoxQuestion3D);

            answersCheckBoxDictionary.Add(Questions.Question3, answersCheckBox_Q1);

            List<RadioButton> answersRadioButton_Q1 = new();
            answersRadioButton_Q1.Add(radioButtonQuestion1A);
            answersRadioButton_Q1.Add(radioButtonQuestion1B);
            answersRadioButton_Q1.Add(radioButtonQuestion1C);
            answersRadioButton_Q1.Add(radioButtonQuestion1D);

            List<RadioButton> answersRadioButton_Q2 = new();
            answersRadioButton_Q2.Add(radioButtonQuestion2A);
            answersRadioButton_Q2.Add(radioButtonQuestion2B);
            answersRadioButton_Q2.Add(radioButtonQuestion2C);
            answersRadioButton_Q2.Add(radioButtonQuestion2D);

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

            foreach (KeyValuePair<Questions,  List<RadioButton>> questionAnswers in answersRadioButtonDictionary)
            {
                foreach (RadioButton answers in questionAnswers.Value)
                {
                    if (!answers.Checked)
                        continue;

                    wynik += goodAnswersDictionary[questionAnswers.Key](answers.Text);
                    break;
                }
            }

            return wynik;
        }

        private int CheckCheckBoxAnswers()
        {
            int wynik = 0;

            foreach (KeyValuePair<Questions, List<CheckBox>> questionAnswers in answersCheckBoxDictionary)
            {
                foreach ( CheckBox answers in questionAnswers.Value)
                {
                    if (!answers.Checked)
                        continue;

                    wynik += goodAnswersDictionary[questionAnswers.Key](answers.Text);
                }
            }

            return wynik;
        }

        private int CheckTextBoxAnswers()
        {
            int wynik = 0;
            foreach (KeyValuePair<Questions, TextBox> playerAnswer in answersTextQuestionsDictionary)
            {
                wynik = goodAnswersDictionary[playerAnswer.Key](playerAnswer.Value.Text);
            }
            return wynik;
        }

    }
}
