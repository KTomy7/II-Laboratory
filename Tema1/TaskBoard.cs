namespace Tema1;

public partial class TaskBoard : Form
{
    public TaskBoard()
    {
        InitializeComponent();
    }

    private void AddToDoButtonClick(object sender, EventArgs e)
    {
        // Creating NewTaskForm, where the user can add a new TaskCard in the "To Do" list
        NewTaskForm newTaskForm = new NewTaskForm(this, State.ToDo);
        newTaskForm.ShowDialog();
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
        // Creating NewTaskForm, where the user can add a new TaskCard in the "In Progress" list
        NewTaskForm newTaskForm = new NewTaskForm(this, State.InProgress);
        newTaskForm.ShowDialog();
    }
}