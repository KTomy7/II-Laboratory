using DataAccess;
using DataAccess.Models;

namespace Lab3;

public partial class UpdateForm : Form
{
    private readonly Lab3DbContext _dbContext;
    private readonly MainWindow _mainWindow;
    private readonly University _selectedUniversity;
    public UpdateForm(MainWindow mainWindow, Lab3DbContext dbContext)
    {
        InitializeComponent();
        _dbContext = dbContext;
        _mainWindow = mainWindow;
        
        // Retrieve the selected university
        var selectedName = _mainWindow.listBox_Univ.SelectedItem.ToString();
        _selectedUniversity = _dbContext.Universities.FirstOrDefault(univ => univ.Name == selectedName)!;
        
        // Display the selected university's information
        textBox_Name.Text = _selectedUniversity.Name;
        textBox_City.Text = _selectedUniversity.City;
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
        // Update the selected university in the database and update the listbox
        _selectedUniversity.Name = textBox_Name.Text;
        _selectedUniversity.City = textBox_City.Text;
        _dbContext.Universities.Update(_selectedUniversity);
        _dbContext.SaveChanges();
        _mainWindow.AddUniversitiesToListBox();
        Close();
    }
}