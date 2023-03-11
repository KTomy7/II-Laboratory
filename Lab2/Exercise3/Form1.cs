namespace Exercise3;

public partial class Form1 : Form
{
    private Operation operation;
    public Form1()
    {
        InitializeComponent();
    }

    private void addToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        // Set the operation to add
        operation = Operation.Add;
        label5.Text = "+";
    }

    private void subtractToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        // Set the operation to subtract
        operation = Operation.Subtract;
        label5.Text = "-";
    }

    private void multiplyToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        // Set the operation to multiply
        operation = Operation.Multiply;
        label5.Text = "*";
    }

    private void divideToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        // Set the operation to divide
        operation = Operation.Divide;
        label5.Text = "/";
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // Read the numbers from the text boxes
        double num1 = Convert.ToDouble(textBox1.Text);
        double num2 = Convert.ToDouble(textBox2.Text);
        textBox1.Text = "";
        textBox2.Text = "";

        // Perform the operation
        switch (operation)
        {
            case Operation.Add:
                textBox3.Text = (num1 + num2).ToString();
                break;
            case Operation.Subtract:
                textBox3.Text = (num1 - num2).ToString();
                break;
            case Operation.Multiply:
                textBox3.Text = (num1 * num2).ToString();
                break;
            case Operation.Divide:
                textBox3.Text = (num1 / num2).ToString();
                break;
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        // Clear the text boxes
        textBox1.Text = "";
        textBox2.Text = "";
        textBox3.Text = "";
    }
}