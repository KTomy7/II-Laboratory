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
            components = new System.ComponentModel.Container();
            listBox_Univ = new ListBox();
            textBox_City = new TextBox();
            textBox_CodeUniv = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            createButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            universityCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            facultyBindingSource = new BindingSource(components);
            deleteFacButton = new Button();
            addFacButton = new Button();
            textBox_FacName = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)facultyBindingSource).BeginInit();
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
            // textBox_City
            // 
            textBox_City.Location = new Point(308, 274);
            textBox_City.Name = "textBox_City";
            textBox_City.Size = new Size(223, 27);
            textBox_City.TabIndex = 2;
            // 
            // textBox_CodeUniv
            // 
            textBox_CodeUniv.Location = new Point(308, 353);
            textBox_CodeUniv.Name = "textBox_CodeUniv";
            textBox_CodeUniv.Size = new Size(223, 27);
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
            label2.Location = new Point(308, 24);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 5;
            label2.Text = "Facultati:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 247);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 6;
            label3.Text = "Oras:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(308, 318);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 7;
            label4.Text = "Cod Univ:";
            // 
            // createButton
            // 
            createButton.Location = new Point(27, 399);
            createButton.Name = "createButton";
            createButton.Size = new Size(135, 58);
            createButton.TabIndex = 8;
            createButton.Text = "Add University";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(396, 399);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(135, 58);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Delete University";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(215, 399);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(135, 58);
            updateButton.TabIndex = 10;
            updateButton.Text = "Edit University";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, universityCodeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = facultyBindingSource;
            dataGridView1.Location = new Point(308, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(428, 188);
            dataGridView1.TabIndex = 11;
            dataGridView1.VirtualMode = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // universityCodeDataGridViewTextBoxColumn
            // 
            universityCodeDataGridViewTextBoxColumn.DataPropertyName = "UniversityCode";
            universityCodeDataGridViewTextBoxColumn.HeaderText = "UniversityCode";
            universityCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            universityCodeDataGridViewTextBoxColumn.Name = "universityCodeDataGridViewTextBoxColumn";
            universityCodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // facultyBindingSource
            // 
            facultyBindingSource.DataSource = typeof(DataAccess.Models.Faculty);
            // 
            // deleteFacButton
            // 
            deleteFacButton.Location = new Point(589, 399);
            deleteFacButton.Name = "deleteFacButton";
            deleteFacButton.Size = new Size(135, 58);
            deleteFacButton.TabIndex = 12;
            deleteFacButton.Text = "Delete Faculty";
            deleteFacButton.UseVisualStyleBackColor = true;
            deleteFacButton.Click += deleteFacButton_Click;
            // 
            // addFacButton
            // 
            addFacButton.Location = new Point(589, 322);
            addFacButton.Name = "addFacButton";
            addFacButton.Size = new Size(135, 58);
            addFacButton.TabIndex = 13;
            addFacButton.Text = "Add Faculty";
            addFacButton.UseVisualStyleBackColor = true;
            addFacButton.Click += addFacButton_Click;
            // 
            // textBox_FacName
            // 
            textBox_FacName.Location = new Point(571, 274);
            textBox_FacName.Name = "textBox_FacName";
            textBox_FacName.Size = new Size(165, 27);
            textBox_FacName.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(571, 247);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 15;
            label5.Text = "Nume Facultate:";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 480);
            Controls.Add(label5);
            Controls.Add(textBox_FacName);
            Controls.Add(addFacButton);
            Controls.Add(deleteFacButton);
            Controls.Add(dataGridView1);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(createButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_CodeUniv);
            Controls.Add(textBox_City);
            Controls.Add(listBox_Univ);
            Name = "MainWindow";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)facultyBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal ListBox listBox_Univ;
        private TextBox textBox_City;
        private TextBox textBox_CodeUniv;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button createButton;
        private Button deleteButton;
        private Button updateButton;
        private DataGridView dataGridView1;
        private BindingSource facultyBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn universityCodeDataGridViewTextBoxColumn;
        private Button deleteFacButton;
        private Button addFacButton;
        private TextBox textBox_FacName;
        private Label label5;
    }
}