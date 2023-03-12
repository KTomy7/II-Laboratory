namespace Tema1
{
    public partial class Form2 : Form
    {
        private readonly Form1 _mainForm;
        private readonly State _state;
        public Form2(Form1 mainForm, State state)
        {
            InitializeComponent();
            this._mainForm = mainForm;
            this._state = state;
        }
        private void CreateButtonClick(object sender, EventArgs e)
        {
            string title = titleInputTextBox.Text;
            string description = descriptionInputTextBox.Text;
            // Creating a new TaskCard
            TaskCard taskCard = new TaskCard(_mainForm, title, description, _state);
            if (_state == State.ToDo)
            {
                taskCard.Location = new Point(0, (_mainForm.toDoPanel.Controls.Count - 2) * 100 + createButton.Height + 5);
                _mainForm.toDoPanel.Controls.Add(taskCard);
            }
            else
            {
                taskCard.Location = new Point(0, (_mainForm.inProgressPanel.Controls.Count - 2) * 100 + createButton.Height + 5);
                _mainForm.inProgressPanel.Controls.Add(taskCard);
            }
            this.Close();
        }
    }
}
