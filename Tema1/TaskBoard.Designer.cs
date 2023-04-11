namespace Tema1;

partial class TaskBoard
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
        toDoPanel = new Panel();
        addToDoButton = new Button();
        label1 = new Label();
        donePanel = new Panel();
        label3 = new Label();
        inProgressPanel = new Panel();
        label2 = new Label();
        tableLayoutPanel1 = new TableLayoutPanel();
        addInProgressButton = new Button();
        clearAllButton = new Button();
        toDoPanel.SuspendLayout();
        donePanel.SuspendLayout();
        inProgressPanel.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // toDoPanel
        // 
        toDoPanel.Controls.Add(addToDoButton);
        toDoPanel.Controls.Add(label1);
        toDoPanel.Dock = DockStyle.Fill;
        toDoPanel.Location = new Point(3, 3);
        toDoPanel.Name = "toDoPanel";
        toDoPanel.Size = new Size(288, 498);
        toDoPanel.TabIndex = 1;
        // 
        // addToDoButton
        // 
        addToDoButton.Location = new Point(191, 3);
        addToDoButton.Name = "addToDoButton";
        addToDoButton.Size = new Size(94, 29);
        addToDoButton.TabIndex = 1;
        addToDoButton.Text = "Add Task";
        addToDoButton.UseVisualStyleBackColor = true;
        addToDoButton.Click += AddToDoButtonClick;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(3, 6);
        label1.Name = "label1";
        label1.Size = new Size(52, 20);
        label1.TabIndex = 0;
        label1.Text = "To Do:";
        // 
        // donePanel
        // 
        donePanel.Controls.Add(clearAllButton);
        donePanel.Controls.Add(label3);
        donePanel.Dock = DockStyle.Fill;
        donePanel.Location = new Point(592, 3);
        donePanel.Name = "donePanel";
        donePanel.Size = new Size(290, 498);
        donePanel.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(3, 6);
        label3.Name = "label3";
        label3.Size = new Size(48, 20);
        label3.TabIndex = 0;
        label3.Text = "Done:";
        // 
        // inProgressPanel
        // 
        inProgressPanel.Controls.Add(addInProgressButton);
        inProgressPanel.Controls.Add(label2);
        inProgressPanel.Dock = DockStyle.Fill;
        inProgressPanel.Location = new Point(297, 3);
        inProgressPanel.Name = "inProgressPanel";
        inProgressPanel.Size = new Size(289, 498);
        inProgressPanel.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(3, 6);
        label2.Name = "label2";
        label2.Size = new Size(84, 20);
        label2.TabIndex = 0;
        label2.Text = "In Progress:";
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
        tableLayoutPanel1.Controls.Add(toDoPanel, 0, 0);
        tableLayoutPanel1.Controls.Add(inProgressPanel, 1, 0);
        tableLayoutPanel1.Controls.Add(donePanel, 2, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new Size(885, 504);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // addInProgressButton
        // 
        addInProgressButton.Location = new Point(192, 3);
        addInProgressButton.Name = "addInProgressButton";
        addInProgressButton.Size = new Size(94, 29);
        addInProgressButton.TabIndex = 2;
        addInProgressButton.Text = "Add Task";
        addInProgressButton.UseVisualStyleBackColor = true;
        addInProgressButton.Click += AddInProgressButtonClick;
        // 
        // clearAllButton
        // 
        clearAllButton.Location = new Point(193, 2);
        clearAllButton.Name = "clearAllButton";
        clearAllButton.Size = new Size(94, 29);
        clearAllButton.TabIndex = 3;
        clearAllButton.Text = "Clear All";
        clearAllButton.UseVisualStyleBackColor = true;
        clearAllButton.Click += ClearAllButtonClick;
        // 
        // TaskBoard
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(885, 504);
        Controls.Add(tableLayoutPanel1);
        Name = "TaskBoard";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Tema1 - TaskBoard";
        toDoPanel.ResumeLayout(false);
        toDoPanel.PerformLayout();
        donePanel.ResumeLayout(false);
        donePanel.PerformLayout();
        inProgressPanel.ResumeLayout(false);
        inProgressPanel.PerformLayout();
        tableLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    internal Panel toDoPanel;
    private Button addToDoButton;
    private Label label1;
    internal Panel donePanel;
    private Label label3;
    internal Panel inProgressPanel;
    private Label label2;
    private TableLayoutPanel tableLayoutPanel1;
    private Button clearAllButton;
    private Button addInProgressButton;
}