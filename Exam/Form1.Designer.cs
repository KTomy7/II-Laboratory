namespace Exam
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            nameTextBox = new TextBox();
            bugetTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(51, 51);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(171, 27);
            nameTextBox.TabIndex = 0;
            // 
            // bugetTextBox
            // 
            bugetTextBox.Location = new Point(51, 103);
            bugetTextBox.Name = "bugetTextBox";
            bugetTextBox.Size = new Size(171, 27);
            bugetTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 6;
            label1.Text = "Team1:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 209);
            Controls.Add(label1);
            Controls.Add(bugetTextBox);
            Controls.Add(nameTextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private TextBox nameTextBox;
        private TextBox bugetTextBox;
        private Label label1;
    }
}