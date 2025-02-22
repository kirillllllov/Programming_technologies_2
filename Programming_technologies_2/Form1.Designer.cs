namespace Programming_technologies_2
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
            sentence = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // sentence
            // 
            sentence.Location = new Point(12, 39);
            sentence.Name = "sentence";
            sentence.Size = new Size(553, 23);
            sentence.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 15);
            label1.TabIndex = 1;
            label1.Text = "Посчёт процента букв в предложении";
            // 
            // button1
            // 
            button1.Location = new Point(12, 68);
            button1.Name = "button1";
            button1.Size = new Size(553, 28);
            button1.TabIndex = 2;
            button1.Text = "Посчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 99);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(sentence);
            Name = "Form1";
            Text = "Counting the number of letters in a sentence";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox sentence;
        private Label label1;
        private Button button1;
    }
}
