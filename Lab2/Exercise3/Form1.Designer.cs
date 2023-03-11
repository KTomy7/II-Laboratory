namespace Exercise3;

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
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        menuStrip1 = new MenuStrip();
        asdToolStripMenuItem = new ToolStripMenuItem();
        addToolStripMenuItem1 = new ToolStripMenuItem();
        subtractToolStripMenuItem1 = new ToolStripMenuItem();
        multiplyToolStripMenuItem1 = new ToolStripMenuItem();
        divideToolStripMenuItem1 = new ToolStripMenuItem();
        toolStripMenuItem1 = new ToolStripMenuItem();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        button1 = new Button();
        button2 = new Button();
        label5 = new Label();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new Point(21, 84);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(125, 27);
        textBox1.TabIndex = 0;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(177, 84);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(125, 27);
        textBox2.TabIndex = 1;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(333, 84);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(125, 27);
        textBox3.TabIndex = 2;
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { asdToolStripMenuItem, toolStripMenuItem1 });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(469, 28);
        menuStrip1.TabIndex = 3;
        menuStrip1.Text = "menuStrip1";
        // 
        // asdToolStripMenuItem
        // 
        asdToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem1, subtractToolStripMenuItem1, multiplyToolStripMenuItem1, divideToolStripMenuItem1 });
        asdToolStripMenuItem.Name = "asdToolStripMenuItem";
        asdToolStripMenuItem.Size = new Size(103, 24);
        asdToolStripMenuItem.Text = "Operations: ";
        // 
        // addToolStripMenuItem1
        // 
        addToolStripMenuItem1.Name = "addToolStripMenuItem1";
        addToolStripMenuItem1.Size = new Size(147, 26);
        addToolStripMenuItem1.Text = "Add";
        addToolStripMenuItem1.Click += addToolStripMenuItem1_Click;
        // 
        // subtractToolStripMenuItem1
        // 
        subtractToolStripMenuItem1.Name = "subtractToolStripMenuItem1";
        subtractToolStripMenuItem1.Size = new Size(147, 26);
        subtractToolStripMenuItem1.Text = "Subtract";
        subtractToolStripMenuItem1.Click += subtractToolStripMenuItem1_Click;
        // 
        // multiplyToolStripMenuItem1
        // 
        multiplyToolStripMenuItem1.Name = "multiplyToolStripMenuItem1";
        multiplyToolStripMenuItem1.Size = new Size(147, 26);
        multiplyToolStripMenuItem1.Text = "Multiply";
        multiplyToolStripMenuItem1.Click += multiplyToolStripMenuItem1_Click;
        // 
        // divideToolStripMenuItem1
        // 
        divideToolStripMenuItem1.Name = "divideToolStripMenuItem1";
        divideToolStripMenuItem1.Size = new Size(147, 26);
        divideToolStripMenuItem1.Text = "Divide";
        divideToolStripMenuItem1.Click += divideToolStripMenuItem1_Click;
        // 
        // toolStripMenuItem1
        // 
        toolStripMenuItem1.Name = "toolStripMenuItem1";
        toolStripMenuItem1.Size = new Size(14, 24);
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(21, 50);
        label1.Name = "label1";
        label1.Size = new Size(94, 20);
        label1.TabIndex = 4;
        label1.Text = "First number:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(177, 50);
        label2.Name = "label2";
        label2.Size = new Size(116, 20);
        label2.TabIndex = 5;
        label2.Text = "Second number:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(333, 50);
        label3.Name = "label3";
        label3.Size = new Size(52, 20);
        label3.TabIndex = 6;
        label3.Text = "Result:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(308, 87);
        label4.Name = "label4";
        label4.Size = new Size(19, 20);
        label4.TabIndex = 7;
        label4.Text = "=";
        // 
        // button1
        // 
        button1.Location = new Point(333, 144);
        button1.Name = "button1";
        button1.Size = new Size(125, 40);
        button1.TabIndex = 8;
        button1.Text = "Calculate";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(21, 144);
        button2.Name = "button2";
        button2.Size = new Size(125, 40);
        button2.TabIndex = 9;
        button2.Text = "Clear";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(152, 87);
        label5.Name = "label5";
        label5.Size = new Size(19, 20);
        label5.TabIndex = 10;
        label5.Text = "+";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(469, 203);
        Controls.Add(label5);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "Form1";
        Text = "Calculator";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem asdToolStripMenuItem;
    private ToolStripMenuItem toolStripMenuItem1;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Button button1;
    private Button button2;
    private Label label5;
    private ToolStripMenuItem addToolStripMenuItem1;
    private ToolStripMenuItem subtractToolStripMenuItem1;
    private ToolStripMenuItem multiplyToolStripMenuItem1;
    private ToolStripMenuItem divideToolStripMenuItem1;
}