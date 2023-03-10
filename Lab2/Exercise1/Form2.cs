using System.Windows.Forms;

namespace Exercise1;

public partial class Form2 : Form
{
    private string username;
    public Form2(string username)
    {
        this.username = username;
        InitializeComponent();
    }

    private void Form2_Load(object sender, EventArgs e)
    {
        label1.Text = "Hello, " + username + "!";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}