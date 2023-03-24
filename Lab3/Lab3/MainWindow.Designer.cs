namespace Lab3
{
    partial class MainWindow
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
            listBox_Univ = new ListBox();
            listBox_Fac = new ListBox();
            textBox_City = new TextBox();
            textBox_CodeUniv = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            createButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            SuspendLayout();
            // 
            // listBox_Univ
            // 
            listBox_Univ.FormattingEnabled = true;
            listBox_Univ.ItemHeight = 20;
            listBox_Univ.Location = new Point(27, 56);
            listBox_Univ.Name = "listBox_Univ";
            listBox_Univ.Size = new Size(248, 324);
            listBox_Univ.TabIndex = 0;
            listBox_Univ.SelectedIndexChanged += listBox_Univ_SelectedIndexChanged;
            // 
            // listBox_Fac
            // 
            listBox_Fac.FormattingEnabled = true;
            listBox_Fac.ItemHeight = 20;
            listBox_Fac.Location = new Point(343, 56);
            listBox_Fac.Name = "listBox_Fac";
            listBox_Fac.Size = new Size(210, 164);
            listBox_Fac.TabIndex = 1;
            // 
            // textBox_City
            // 
            textBox_City.Location = new Point(343, 274);
            textBox_City.Name = "textBox_City";
            textBox_City.Size = new Size(210, 27);
            textBox_City.TabIndex = 2;
            // 
            // textBox_CodeUniv
            // 
            textBox_CodeUniv.Location = new Point(343, 353);
            textBox_CodeUniv.Name = "textBox_CodeUniv";
            textBox_CodeUniv.Size = new Size(210, 27);
            textBox_CodeUniv.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 24);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 4;
            label1.Text = "Universitati:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 24);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 5;
            label2.Text = "Facultati:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 240);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 6;
            label3.Text = "Oras:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 319);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 7;
            label4.Text = "Cod Univ:";
            // 
            // createButton
            // 
            createButton.Location = new Point(607, 56);
            createButton.Name = "createButton";
            createButton.Size = new Size(135, 58);
            createButton.TabIndex = 8;
            createButton.Text = "Add University";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(607, 243);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(135, 58);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Delete University";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(607, 148);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(135, 58);
            updateButton.TabIndex = 10;
            updateButton.Text = "Edit University";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(createButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_CodeUniv);
            Controls.Add(textBox_City);
            Controls.Add(listBox_Fac);
            Controls.Add(listBox_Univ);
            Name = "MainWindow";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_Univ;
        private ListBox listBox_Fac;
        private TextBox textBox_City;
        private TextBox textBox_CodeUniv;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button createButton;
        private Button deleteButton;
        private Button updateButton;
    }
}