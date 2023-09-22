using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_SummattiveAssessment
{
    public partial class Words : Form
    {
        string DefaultWord = "--Words--";
        public Words()
        {
            InitializeComponent();

           
            cbWords1.Items.Add(DefaultWord);
            cbWords2.Items.Add(DefaultWord);

            cbWords1.SelectedItem = DefaultWord;
            cbWords2.SelectedItem = DefaultWord;
        }

        ArrayList words = new ArrayList();
        ArrayList concatenatedWords = new ArrayList();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string word = txtWord.Text;
            if (string.IsNullOrEmpty(word))
                MessageBox.Show("Please enter a word.");
            else if (words.Contains(word) || concatenatedWords.Contains(word))
                MessageBox.Show("Word already exists in collections.");
            else
            {
                word = CapitalizeFirstLetter(word);
                words.Add(word);
                cbWords1.Items.Add(word);
                cbWords2.Items.Add(word);

            }
        }

        private void rbRemove1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeBtnConcatenateText();
        }

        private void rbRemove2_CheckedChanged(object sender, EventArgs e)
        {
            ChangeBtnConcatenateText();
        }

        private void ChangeBtnConcatenateText()
        {
            btnConcatenate.Text = "Remove Item";
        }

        private string CapitalizeFirstLetter(string input)
        {
            // Create a TextInfo object with the current culture
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            // Use ToTitleCase to capitalize the first letter
            return textInfo.ToTitleCase(input);
        }

        private void btnConcatenate_Click(object sender, EventArgs e)
        {
            if(btnConcatenate.Text == "Remove Item")
            {
                if (rbRemove1.Checked && cbWords1.SelectedIndex >= 1)
                {
                    cbWords1.Items.RemoveAt(cbWords1.SelectedIndex);
                    cbWords1.SelectedItem = DefaultWord;
                    rbRemove1.Checked = false;
                    MessageBox.Show("Word had been removed");
                }

                if (rbRemove2.Checked && cbWords2.SelectedIndex >= 1)
                {
                    cbWords2.Items.RemoveAt(cbWords2.SelectedIndex);
                    cbWords2.SelectedItem = DefaultWord;
                    rbRemove2.Checked = false;
                    MessageBox.Show("Word had been removed");
                }

                btnConcatenate.Text = "Concatenate";
            }
            else
            {
                if(cbWords1.SelectedIndex >= 1 && cbWords2.SelectedIndex >= 1)
                {
                    if(cbWords1.SelectedIndex != cbWords2.SelectedIndex)
                    {
                        string newWord = cbWords1.SelectedItem.ToString() + cbWords2.SelectedItem.ToString();
                        lbDisplay.Text = newWord;
                        concatenatedWords.Add(newWord);
                    }
                    else
                    {
                        MessageBox.Show("Cannot concatenate the same word.");
                    }
                }
                else
                {
                    MessageBox.Show("Please make sure to select a word from both dropdowns.");
                }

            }
        }
    }
}
