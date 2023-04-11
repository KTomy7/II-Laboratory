using DataAccess;
using DataAccess.Models;

namespace Lab3
{
    public partial class CreateForm : Form
    {
        private readonly Lab3DbContext _dbContext;
        private readonly MainWindow _mainWindow;
        public CreateForm(MainWindow mainWindow, Lab3DbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _mainWindow = mainWindow;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // Create a new University object
            var university = new University
            {
                Name = textBox_Name.Text,
                City = textBox_City.Text
            };
            
            // Add the new university to the database and update the listbox
            _dbContext.Universities.Add(university);
            _dbContext.SaveChanges();
            _mainWindow.AddUniversitiesToListBox();
            Close();
        }
    }
}
