namespace WindowsFormsAppClient
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tempCtextBox = new System.Windows.Forms.TextBox();
            this.tempFtextBox = new System.Windows.Forms.TextBox();
            this.tempResulttextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.ronTextBox = new System.Windows.Forms.TextBox();
            this.euroTextBox = new System.Windows.Forms.TextBox();
            this.addListButton = new System.Windows.Forms.Button();
            this.FtoCButton = new System.Windows.Forms.Button();
            this.CtoFButton = new System.Windows.Forms.Button();
            this.conversionResultTextBox = new System.Windows.Forms.TextBox();
            this.ConvertToEuroButton = new System.Windows.Forms.Button();
            this.ConvertToRonButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(33, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 132);
            this.listBox1.TabIndex = 0;
            // 
            // tempCtextBox
            // 
            this.tempCtextBox.Location = new System.Drawing.Point(378, 40);
            this.tempCtextBox.Name = "tempCtextBox";
            this.tempCtextBox.Size = new System.Drawing.Size(146, 22);
            this.tempCtextBox.TabIndex = 1;
            // 
            // tempFtextBox
            // 
            this.tempFtextBox.Location = new System.Drawing.Point(378, 95);
            this.tempFtextBox.Name = "tempFtextBox";
            this.tempFtextBox.Size = new System.Drawing.Size(146, 22);
            this.tempFtextBox.TabIndex = 2;
            // 
            // tempResulttextBox
            // 
            this.tempResulttextBox.Location = new System.Drawing.Point(378, 150);
            this.tempResulttextBox.Name = "tempResulttextBox";
            this.tempResulttextBox.Size = new System.Drawing.Size(146, 22);
            this.tempResulttextBox.TabIndex = 3;
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(33, 334);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(192, 22);
            this.dateTextBox.TabIndex = 4;
            // 
            // ronTextBox
            // 
            this.ronTextBox.Location = new System.Drawing.Point(378, 214);
            this.ronTextBox.Name = "ronTextBox";
            this.ronTextBox.Size = new System.Drawing.Size(146, 22);
            this.ronTextBox.TabIndex = 5;
            // 
            // euroTextBox
            // 
            this.euroTextBox.Location = new System.Drawing.Point(378, 277);
            this.euroTextBox.Name = "euroTextBox";
            this.euroTextBox.Size = new System.Drawing.Size(146, 22);
            this.euroTextBox.TabIndex = 7;
            // 
            // addListButton
            // 
            this.addListButton.Location = new System.Drawing.Point(33, 197);
            this.addListButton.Name = "addListButton";
            this.addListButton.Size = new System.Drawing.Size(192, 39);
            this.addListButton.TabIndex = 9;
            this.addListButton.Text = "Show Shopping List";
            this.addListButton.UseVisualStyleBackColor = true;
            this.addListButton.Click += new System.EventHandler(this.addListButton_Click);
            // 
            // FtoCButton
            // 
            this.FtoCButton.Location = new System.Drawing.Point(541, 87);
            this.FtoCButton.Name = "FtoCButton";
            this.FtoCButton.Size = new System.Drawing.Size(131, 38);
            this.FtoCButton.TabIndex = 10;
            this.FtoCButton.Text = "FtoC";
            this.FtoCButton.UseVisualStyleBackColor = true;
            this.FtoCButton.Click += new System.EventHandler(this.FtoCButton_Click);
            // 
            // CtoFButton
            // 
            this.CtoFButton.Location = new System.Drawing.Point(541, 32);
            this.CtoFButton.Name = "CtoFButton";
            this.CtoFButton.Size = new System.Drawing.Size(131, 38);
            this.CtoFButton.TabIndex = 11;
            this.CtoFButton.Text = "CtoF";
            this.CtoFButton.UseVisualStyleBackColor = true;
            this.CtoFButton.Click += new System.EventHandler(this.CtoFButton_Click);
            // 
            // conversionResultTextBox
            // 
            this.conversionResultTextBox.Location = new System.Drawing.Point(378, 334);
            this.conversionResultTextBox.Name = "conversionResultTextBox";
            this.conversionResultTextBox.Size = new System.Drawing.Size(146, 22);
            this.conversionResultTextBox.TabIndex = 12;
            // 
            // ConvertToEuroButton
            // 
            this.ConvertToEuroButton.Location = new System.Drawing.Point(541, 206);
            this.ConvertToEuroButton.Name = "ConvertToEuroButton";
            this.ConvertToEuroButton.Size = new System.Drawing.Size(131, 38);
            this.ConvertToEuroButton.TabIndex = 13;
            this.ConvertToEuroButton.Text = "ConvertToEuro";
            this.ConvertToEuroButton.UseVisualStyleBackColor = true;
            this.ConvertToEuroButton.Click += new System.EventHandler(this.ConvertToEuroButton_Click);
            // 
            // ConvertToRonButton
            // 
            this.ConvertToRonButton.Location = new System.Drawing.Point(541, 269);
            this.ConvertToRonButton.Name = "ConvertToRonButton";
            this.ConvertToRonButton.Size = new System.Drawing.Size(131, 38);
            this.ConvertToRonButton.TabIndex = 14;
            this.ConvertToRonButton.Text = "ConvertToRon";
            this.ConvertToRonButton.UseVisualStyleBackColor = true;
            this.ConvertToRonButton.Click += new System.EventHandler(this.ConvertToRonButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Shopping List:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Current Date and Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Temp C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Temp F:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Result:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ron to Euro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Euro to Ron:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Result:";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(150, 305);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 23;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 388);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConvertToRonButton);
            this.Controls.Add(this.ConvertToEuroButton);
            this.Controls.Add(this.conversionResultTextBox);
            this.Controls.Add(this.CtoFButton);
            this.Controls.Add(this.FtoCButton);
            this.Controls.Add(this.addListButton);
            this.Controls.Add(this.euroTextBox);
            this.Controls.Add(this.ronTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.tempResulttextBox);
            this.Controls.Add(this.tempFtextBox);
            this.Controls.Add(this.tempCtextBox);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tempCtextBox;
        private System.Windows.Forms.TextBox tempFtextBox;
        private System.Windows.Forms.TextBox tempResulttextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox ronTextBox;
        private System.Windows.Forms.TextBox euroTextBox;
        private System.Windows.Forms.Button addListButton;
        private System.Windows.Forms.Button FtoCButton;
        private System.Windows.Forms.Button CtoFButton;
        private System.Windows.Forms.TextBox conversionResultTextBox;
        private System.Windows.Forms.Button ConvertToEuroButton;
        private System.Windows.Forms.Button ConvertToRonButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button refreshButton;
    }
}

