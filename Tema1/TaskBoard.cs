namespace Tema1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void AddToDoButtonClick(object sender, EventArgs e)
    {
        // Creating Form2, where the user can add a new TaskCard in the "To Do" list
        Form2 form2 = new Form2(this, State.ToDo);
        form2.ShowDialog();
    }
    
    private void ClearAllButtonClick(object sender, EventArgs e)
    {
        // Clearing the Done list
        donePanel.Controls.Clear();
        donePanel.Controls.Add(label3);
        donePanel.Controls.Add(clearAllButton);
    }
    
    private void AddInProgressButtonClick(object sender, EventArgs e)
    {
        // Creating Form2, where the user can add a new TaskCard in the "In Progress" list
        Form2 form2 = new Form2(this, State.InProgress);
        form2.ShowDialog();
    }
}