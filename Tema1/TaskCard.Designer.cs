namespace Tema1
{
    partial class TaskCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            descriptionTextBox = new TextBox();
            deleteButton = new Button();
            titleLabel = new Label();
            moveButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(moveButton);
            panel1.Controls.Add(descriptionTextBox);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(titleLabel);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 93);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            descriptionTextBox.Location = new Point(3, 37);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ReadOnly = true;
            descriptionTextBox.Size = new Size(281, 53);
            descriptionTextBox.TabIndex = 2;
            // 
            // button1
            // 
            deleteButton.BackColor = Color.Transparent;
            deleteButton.Location = new Point(222, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(62, 28);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += DeleteButtonClick;
            // 
            // label1
            // 
            panel1.BackColor = Color.Yellow;
            titleLabel.Font = new Font(titleLabel.Font.FontFamily, 12);
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(3, 7);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(50, 20);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "label1";
            // 
            // button2
            // 
            moveButton.BackColor = Color.Transparent;
            moveButton.Location = new Point(154, 3);
            moveButton.Name = "moveButton";
            moveButton.Size = new Size(62, 28);
            moveButton.TabIndex = 3;
            moveButton.Text = "Start";
            moveButton.UseVisualStyleBackColor = false;
            moveButton.Click += MoveButtonClick;
            // 
            // TaskCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "TaskCard";
            Size = new Size(287, 93);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button deleteButton;
        private Label titleLabel;
        private TextBox descriptionTextBox;
        private Button moveButton;
    }
}
