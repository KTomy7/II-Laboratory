namespace Lab3
{
    partial class CreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox_Name = new TextBox();
            textBox_City = new TextBox();
            createButton = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 26);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 0;
            label1.Text = "Add a new University!";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(99, 76);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(196, 27);
            textBox_Name.TabIndex = 1;
            // 
            // textBox_City
            // 
            textBox_City.Location = new Point(99, 132);
            textBox_City.Name = "textBox_City";
            textBox_City.Size = new Size(196, 27);
            textBox_City.TabIndex = 2;
            // 
            // createButton
            // 
            createButton.Location = new Point(99, 192);
            createButton.Name = "createButton";
            createButton.Size = new Size(125, 60);
            createButton.TabIndex = 3;
            createButton.Text = "Add";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 79);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 4;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 135);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 5;
            label3.Text = "City:";
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 295);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(createButton);
            Controls.Add(textBox_City);
            Controls.Add(textBox_Name);
            Controls.Add(label1);
            Name = "CreateForm";
            Text = "CreateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_Name;
        private TextBox textBox_City;
        private Button createButton;
        private Label label2;
        private Label label3;
    }
}