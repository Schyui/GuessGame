namespace GuessingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            guessBtn = new Button();
            txtWord = new TextBox();
            wordCensored = new Label();
            Correct = new Label();
            listObjects = new ListBox();
            SuspendLayout();
            // 
            // guessBtn
            // 
            guessBtn.Anchor = AnchorStyles.Top;
            guessBtn.BackColor = Color.Crimson;
            guessBtn.ForeColor = Color.White;
            guessBtn.Location = new Point(154, 139);
            guessBtn.Margin = new Padding(4);
            guessBtn.Name = "guessBtn";
            guessBtn.Size = new Size(155, 32);
            guessBtn.TabIndex = 0;
            guessBtn.Text = "Guess";
            guessBtn.UseVisualStyleBackColor = false;
            guessBtn.Click += button1_Click;
            // 
            // txtWord
            // 
            txtWord.Anchor = AnchorStyles.Top;
            txtWord.Font = new Font("Segoe UI", 14F);
            txtWord.Location = new Point(80, 99);
            txtWord.Margin = new Padding(4);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(314, 32);
            txtWord.TabIndex = 1;
            // 
            // wordCensored
            // 
            wordCensored.Anchor = AnchorStyles.Top;
            wordCensored.BackColor = Color.Crimson;
            wordCensored.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            wordCensored.ForeColor = Color.White;
            wordCensored.Location = new Point(30, 9);
            wordCensored.Margin = new Padding(4, 0, 4, 0);
            wordCensored.MaximumSize = new Size(600, 600);
            wordCensored.Name = "wordCensored";
            wordCensored.Size = new Size(415, 86);
            wordCensored.TabIndex = 2;
            wordCensored.Text = "word";
            wordCensored.TextAlign = ContentAlignment.MiddleCenter;
            wordCensored.Click += label1_Click;
            // 
            // Correct
            // 
            Correct.Anchor = AnchorStyles.Top;
            Correct.BackColor = Color.Crimson;
            Correct.ForeColor = Color.White;
            Correct.Location = new Point(453, 9);
            Correct.Margin = new Padding(4, 0, 4, 0);
            Correct.Name = "Correct";
            Correct.Size = new Size(205, 26);
            Correct.TabIndex = 3;
            Correct.Text = "Wrong guess";
            Correct.TextAlign = ContentAlignment.TopCenter;
            Correct.Click += label2_Click;
            // 
            // listObjects
            // 
            listObjects.Anchor = AnchorStyles.Top;
            listObjects.FormattingEnabled = true;
            listObjects.ItemHeight = 21;
            listObjects.Location = new Point(453, 39);
            listObjects.Margin = new Padding(4);
            listObjects.Name = "listObjects";
            listObjects.Size = new Size(205, 151);
            listObjects.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 204);
            Controls.Add(listObjects);
            Controls.Add(Correct);
            Controls.Add(wordCensored);
            Controls.Add(txtWord);
            Controls.Add(guessBtn);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button guessBtn;
        private TextBox txtWord;
        private Label wordCensored;
        private Label Correct;
        private ListBox listObjects;
    }
}
