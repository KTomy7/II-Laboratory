namespace Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Read the objects from a file:
                string[] lines = System.IO.File.ReadAllLines(@"D:\AIA\Year III\Sem2\II - Valean\Labs\II-Laboratory\Lab2\Objects.txt");
                if (lines.Length == 0)
                {
                    throw new Exception("The file is empty!");
                }
                foreach (string line in lines)
                {
                    listBox1.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedItems = listBox1.SelectedItems;
            foreach (var item in selectedItems)
            {
                listBox2.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //remove from the listbox the selected item
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}