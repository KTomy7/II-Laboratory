using System.ComponentModel;

namespace Lab3;

partial class UpdateForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        label2 = new Label();
        label3 = new Label();
        textBox_Name = new TextBox();
        textBox_City = new TextBox();
        updateButton = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(88, 26);
        label1.Name = "label1";
        label1.Size = new Size(155, 20);
        label1.TabIndex = 0;
        label1.Text = "Update the Univeristy!";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(37, 79);
        label2.Name = "label2";
        label2.Size = new Size(52, 20);
        label2.TabIndex = 1;
        label2.Text = "Name:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(37, 135);
        label3.Name = "label3";
        label3.Size = new Size(37, 20);
        label3.TabIndex = 2;
        label3.Text = "City:";
        // 
        // textBox_Name
        // 
        textBox_Name.Location = new Point(99, 76);
        textBox_Name.Name = "textBox_Name";
        textBox_Name.Size = new Size(196, 27);
        textBox_Name.TabIndex = 3;
        // 
        // textBox_City
        // 
        textBox_City.Location = new Point(99, 132);
        textBox_City.Name = "textBox_City";
        textBox_City.Size = new Size(196, 27);
        textBox_City.TabIndex = 4;
        // 
        // updateButton
        // 
        updateButton.Location = new Point(99, 192);
        updateButton.Name = "updateButton";
        updateButton.Size = new Size(125, 60);
        updateButton.TabIndex = 5;
        updateButton.Text = "Update";
        updateButton.UseVisualStyleBackColor = true;
        updateButton.Click += updateButton_Click;
        // 
        // UpdateForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(335, 295);
        Controls.Add(updateButton);
        Controls.Add(textBox_City);
        Controls.Add(textBox_Name);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "UpdateForm";
        Text = "UpdateForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox textBox_Name;
    private TextBox textBox_City;
    private Button updateButton;
}