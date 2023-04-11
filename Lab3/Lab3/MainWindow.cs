using DataAccess;
using DataAccess.Models;
using System.ComponentModel;

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

            // Add the names of the faculties to the dataGridView
            var bsFaculties = new BindingList<Faculty>();
            foreach (var faculty in faculties)
            {
                bsFaculties.Add(faculty);
            }
            dataGridView1.DataSource = bsFaculties;

            // Display the selected university's information
            textBox_City.Text = selectedUniversity!.City;
            textBox_CodeUniv.Text = selectedUniversity.Code.ToString();
        }


        private void createButton_Click(object sender, EventArgs e)
        {
            var createForm = new CreateForm(this, _dbContext);
            createForm.ShowDialog();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var updateForm = new UpdateForm(this, _dbContext);
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

            // Refresh the listbox_Univ & dataGridView and clear the textboxes
            AddUniversitiesToListBox();
            dataGridView1.DataSource = null;
            textBox_City.Clear();
            textBox_CodeUniv.Clear();
        }

        public void AddUniversitiesToListBox()
        {
            listBox_Univ.Items.Clear();
            var universities = _dbContext.Universities.ToList();
            foreach (var university in universities)
            {
                listBox_Univ.Items.Add(university.Name);
            }
        }

        private void deleteFacButton_Click(object sender, EventArgs e)
        {
            // Retrieve the selected faculty
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            var selectedFacultyId = int.Parse(selectedRow.Cells[0].Value.ToString());
            var selectedFacultyUnivCode = int.Parse(selectedRow.Cells[2].Value.ToString());
            var selectedFaculty = _dbContext.Faculties.Find(selectedFacultyId);

            // Delete the selected faculty if it exists
            if (selectedFaculty != null)
            {
                _dbContext.Faculties.Remove(selectedFaculty);
                _dbContext.SaveChanges();
            }

            // Refresh the dataGridView
            dataGridView1.DataSource = null;
            var faculties = _dbContext.Faculties.Where(fac => fac.UniversityCode == selectedFacultyUnivCode).ToList();
            var bsFaculties = new BindingList<Faculty>();
            foreach (var faculty in faculties)
            {
                bsFaculties.Add(faculty);
            }
            dataGridView1.DataSource = bsFaculties;
        }

        private void addFacButton_Click(object sender, EventArgs e)
        {
            // Retrieve the inputted faculty's information from the dataGridView
            var facultyName = textBox_FacName.Text;
            var facultyUnivCode = int.Parse(textBox_CodeUniv.Text);

            // Create a new faculty and add it to the database
            var newFaculty = new Faculty
            {
                Name = facultyName,
                UniversityCode = facultyUnivCode
            };
            _dbContext.Faculties.Add(newFaculty);
            _dbContext.SaveChanges();

            textBox_FacName.Clear();
            // Refresh the dataGridVieW
            dataGridView1.DataSource = null;
            var faculties = _dbContext.Faculties.Where(fac => fac.UniversityCode == facultyUnivCode).ToList();
            var bsFaculties = new BindingList<Faculty>();
            foreach (var faculty in faculties)
            {
                bsFaculties.Add(faculty);
            }
            dataGridView1.DataSource = bsFaculties;
        }
    }
}