using Exam.Models;
using Microsoft.EntityFrameworkCore;

namespace Exam
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _dbContext;
        public int count = 0;
        public Form1()
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var projects = _dbContext.Projects.ToList();

            nameTextBox.Text = projects[0].ProjectName;
            bugetTextBox.Text = projects[0].Buget.ToString();

            foreach (var project in projects)
            {
                if (VerifyBuget(project))
                {
                    count++;
                    if (count == projects.Count)
                    {
                        timer1.Stop();
                        MessageBox.Show("END");
                    }
                }
                else
                {
                    IncrementBudgets(project);
                }
            }
        }

        private void IncrementBudgets(Project project)
        {
            project.Buget += 100;
            _dbContext.Projects.Update(project);
            _dbContext.SaveChanges();
        }

        private bool VerifyBuget(Project project)
        {
            if (project.Buget == 1000)
            {
                return true;
            }
            return false;
        }
    }
}