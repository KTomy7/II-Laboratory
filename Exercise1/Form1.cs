namespace Exercise1
{
    public partial class Form1 : Form
    {
        private string adminUsername = "admin";
        private string adminPassword = "admin";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Read the credentials from a text file:
                string[] lines = System.IO.File.ReadAllLines(@"D:\AIA\Year III\Sem2\II - Valean\Labs\II-Laboratory\Credentials.txt");
                if (lines.Length != 2)
                {
                    throw new Exception("Invalid credentials file!");
                }
                textBox1.Text = lines[0];
                textBox2.Text = lines[1];
            }
            catch (Exception)
            {
                MessageBox.Show("Error reading credentials from file!");
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if the username and password are correct:
            if (textBox1.Text == adminUsername && textBox2.Text == adminPassword)
            {
                Form2 form2 = new Form2(textBox1.Text);
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}