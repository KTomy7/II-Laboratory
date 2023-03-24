using DataAccess;

namespace Lab3
{
    public partial class MainWindow : Form
    {
        private readonly Lab3DbContext _dbContext;
        public MainWindow()
        {
            InitializeComponent();
            _dbContext = new Lab3DbContext();
            AddUniversitiesToListBox();
        }

        private void listBox_Univ_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Retrieve the selected university
            var selectedName = listBox_Univ.SelectedItem.ToString();
            var selectedUniversity = _dbContext.Universities.FirstOrDefault(univ => univ.Name == selectedName);

            // Retrieve all faculties of the selected university
            var faculties = _dbContext.Faculties.Where(fac => fac.UniversityCode == selectedUniversity!.Code).ToList();

            // Add the names of the faculties to the listbox
            listBox_Fac.Items.Clear();
            foreach (var faculty in faculties)
            {
                listBox_Fac.Items.Add(faculty.Name);
            }

            // Display the selected university's information
            textBox_City.Text = selectedUniversity!.City;
            textBox_CodeUniv.Text = selectedUniversity.Code.ToString();
        }


        private void createButton_Click(object sender, EventArgs e)
        {
            var createForm = new CreateForm();
            createForm.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var updateForm = new UpdateForm();
            updateForm.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Retrieve the selected university
            var selectedName = listBox_Univ.SelectedItem.ToString();
            var selectedUniversity = _dbContext.Universities.FirstOrDefault(univ => univ.Name == selectedName);

            // Retrieve all faculties of the selected university
            var faculties = _dbContext.Faculties.Where(fac => fac.UniversityCode == selectedUniversity!.Code).ToList();

            // Delete the selected university and its faculties
            _dbContext.Faculties.RemoveRange(faculties);
            _dbContext.Universities.Remove(selectedUniversity!);
            _dbContext.SaveChanges();

            // Refresh the listbox_Univ & listbox_Fac and clear the textboxes
            listBox_Univ.Items.Clear();
            listBox_Fac.Items.Clear();
            AddUniversitiesToListBox();
            textBox_City.Clear();
            textBox_CodeUniv.Clear();
        }

        private void AddUniversitiesToListBox()
        {
            var universities = _dbContext.Universities.ToList();
            foreach (var university in universities)
            {
                listBox_Univ.Items.Add(university.Name);
            }
        }
    }
}