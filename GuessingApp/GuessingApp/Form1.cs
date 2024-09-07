using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.Pkcs;
using System.Text;

namespace GuessingApp
{
    public partial class Form1 : Form
    {
        string secretWord = "cuteness";
        

        public object StringList { get; private set; }

        public Form1()
        {
            InitializeComponent();

            //wordCensored, yung label sa una, magchchange ng value
            //the censored word
            StringBuilder censored = new StringBuilder("c?t?ne?s");
            wordCensored.Text = censored.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //list of answers
            ArrayList correctAns = new ArrayList();
            correctAns.Add(secretWord);

            //text box variable
            string namesObject = txtWord.Text;
            //ginawang mutable or also called as stringbuilder, at ung list ng mga mali
            StringBuilder list = new StringBuilder(namesObject);
            
            string guess = txtWord.Text;
            //if yung input sa textbox ay correct then tama if no mali
            if (guess == secretWord)
            {
                wordCensored.Text = secretWord;
                MessageBox.Show("Correct guess!");
            }
            else {
                listObjects.Items.Add(list);
                MessageBox.Show("Wrong guess\nTry again.");
                txtWord.Clear();
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
