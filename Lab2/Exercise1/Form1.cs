namespace Exercise1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Button1Click(object sender, EventArgs e)
    {
        string enteredUsername = textBox1.Text;
        string enteredPassword = textBox2.Text;
        string username = "";
        string password = "";
        try
        {
            // Read the credentials from a text file:
            string?[] lines =
                System.IO.File.ReadAllLines(
                    @"D:\AIA\Year III\Sem2\II - Valean\Labs\II-Laboratory\Lab2\Exercise1\Credentials.txt");
            username = lines[0];
            password = lines[1];
        }
        catch (Exception)
        {
            MessageBox.Show("Error reading credentials from file!");
        }
        
        // Check if the username and password are correct:
        if (username == enteredUsername && password == enteredPassword)
        {
            Form2 form2 = new Form2(textBox1.Text);
            form2.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Invalid username or password!");
        }
    }
}