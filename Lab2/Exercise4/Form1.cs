namespace Exercise4
{
    public partial class Form1 : Form
    {
        private readonly string[] cars = { "Mercedes", "Audi", "BMW", "Porsche", "Volvo" };
        private readonly string imagesPath = @"D:\AIA\Year III\Sem2\II - Valean\Labs\II-Laboratory\Lab2\Exercise4\Images\";
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                listBox1.Items.Add(cars[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Find the selected item and display it in the picturebox
            string? selectedCar = listBox1.SelectedItem.ToString();
            try
            {
                pictureBox1.Image = Image.FromFile(imagesPath + selectedCar + ".jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Find the selected radiobuttons and display them in a message box
            var selectedDepartureCity = panel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var selectedDestinationCity = panel2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            MessageBox.Show($"You have selected {selectedDepartureCity?.Text} as departure city and {selectedDestinationCity?.Text} as destination city.");
        }
    }
}