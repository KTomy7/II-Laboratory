namespace Tema1
{
    public partial class TaskCard : UserControl
    {
        private readonly TaskBoard _mainForm;
        private State _state;
        public TaskCard(TaskBoard mainForm, string title, string description, State state)
        {
            InitializeComponent();
            this._mainForm = mainForm;
            this._state = state;
            titleLabel.Text = title;
            descriptionTextBox.Text = description;
            if (state == State.InProgress)
            {
                panel1.BackColor = Color.Orange;
                moveButton.Text = "Finish";
            }
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            // Delete the TaskCard and reposition the other TaskCards to avoid overlapping
            RepositionTaskCards(this);
            this.Parent.Controls.Remove(this);
        }

        private void RepositionTaskCards(TaskCard deletedTaskCard)
        {
            // Create a list of all TaskCards and then remove the deleted one
            List<TaskCard> taskCards = new List<TaskCard>();
            foreach (Control control in this.Parent.Controls)
            {
                if (control is TaskCard taskCard)
                {
                    taskCards.Add(taskCard);
                }
            }
            taskCards.Remove(deletedTaskCard);
        
            // Reposition the remaining TaskCards
            for (var i = 0; i < taskCards.Count; i++)
            {
                taskCards[i].Location = new Point(0, i * 100 + deleteButton.Height + 5);
            }
        }

        private void MoveButtonClick(object sender, EventArgs e)
        {
            switch (this._state)
            {
                case State.ToDo:
                    RepositionTaskCards(this);
                    MoveToInProgress();
                    break;
                case State.InProgress:
                    RepositionTaskCards(this);
                    MoveToDone();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void MoveToInProgress()
        {
            // Move the TaskCard to the InProgress panel and change its specifications
            _mainForm.inProgressPanel.Controls.Add(this);
            this.panel1.BackColor = Color.Orange;
            this._state = State.InProgress;
            this.moveButton.Text = "Finish";
            
            // Reposition the TaskCards
            var taskCards = new List<TaskCard>();
            foreach (Control control in _mainForm.inProgressPanel.Controls)
            {
                if (control is TaskCard taskCard)
                {
                    taskCards.Add(taskCard);
                }
            }
            for (var i = 0; i < taskCards.Count; i++)
            {
                taskCards[i].Location = new Point(0, i * 100 + deleteButton.Height + 5);
            }
        }
        
        private void MoveToDone()
        {
            // Move the TaskCard to the Done panel and change its specifications
            _mainForm.donePanel.Controls.Add(this);
            this.panel1.BackColor = Color.Green;
            this._state = State.Done;
            this.titleLabel.ForeColor = Color.White;
            this.moveButton.Visible = false;
            
            // Reposition the TaskCards
            var taskCards = new List<TaskCard>();
            foreach (Control control in _mainForm.donePanel.Controls)
            {
                if (control is TaskCard taskCard)
                {
                    taskCards.Add(taskCard);
                }
            }
            for (var i = 0; i < taskCards.Count; i++)
            {
                taskCards[i].Location = new Point(0, i * 100 + deleteButton.Height + 5);
            }
        }
    }
}
