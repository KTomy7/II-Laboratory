namespace Tema1
{
    partial class NewTaskForm
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
            titleInputTextBox = new TextBox();
            descriptionInputTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            createButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Add a new Task!";
            // 
            // titleInputTextBox
            // 
            titleInputTextBox.Location = new Point(106, 49);
            titleInputTextBox.Name = "titleInputTextBox";
            titleInputTextBox.Size = new Size(125, 27);
            titleInputTextBox.TabIndex = 1;
            // 
            // descriptionInputTextBox
            // 
            descriptionInputTextBox.Location = new Point(106, 94);
            descriptionInputTextBox.Multiline = true;
            descriptionInputTextBox.Name = "descriptionInputTextBox";
            descriptionInputTextBox.Size = new Size(249, 76);
            descriptionInputTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 3;
            label2.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 4;
            label3.Text = "Description:";
            // 
            // createButton
            // 
            createButton.Location = new Point(261, 207);
            createButton.Name = "createButton";
            createButton.Size = new Size(94, 29);
            createButton.TabIndex = 5;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += CreateButtonClick;
            // 
            // New Task Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 248);
            StartPosition = FormStartPosition.CenterScreen;
            Controls.Add(createButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(descriptionInputTextBox);
            Controls.Add(titleInputTextBox);
            Controls.Add(label1);
            Name = "NewTaskForm";
            Text = "New Task Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titleInputTextBox;
        private TextBox descriptionInputTextBox;
        private Label label2;
        private Label label3;
        private Button createButton;
    }
}