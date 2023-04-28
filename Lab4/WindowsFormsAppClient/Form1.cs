using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsAppClient.ServiceReference1;

namespace WindowsFormsAppClient
{
    public partial class Form1 : Form
    {
        private readonly WebService1SoapClient _client;
        public Form1()
        {
            InitializeComponent();
            _client = new WebService1SoapClient();
            string dateTime = _client.CurrentDateAndTime();
            dateTextBox.Text = dateTime;
        }

        private void addListButton_Click(object sender, EventArgs e)
        {
            string[] shoppingList = _client.GetShoppingList().ToArray();
            foreach (string item in shoppingList)
            {
                listBox1.Items.Add(item);
            }
        }

        private void FtoCButton_Click(object sender, EventArgs e)
        {
            tempResulttextBox.Text = "";
            try
            {
                float tempF = float.Parse(tempFtextBox.Text);
                float tempC = _client.FahrenheitToCelsius(tempF);
                tempResulttextBox.Text = tempC.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
            }
        }

        private void CtoFButton_Click(object sender, EventArgs e)
        {
            tempResulttextBox.Text = "";
            try
            {
                float tempC = float.Parse(tempCtextBox.Text);
                float tempF = _client.CelsiusToFahrenheit(tempC);
                tempResulttextBox.Text = tempF.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
            }
        }

        private void ConvertToEuroButton_Click(object sender, EventArgs e)
        {
            conversionResultTextBox.Text = "";
            try
            {
                float amount = float.Parse(ronTextBox.Text);
                float result = _client.RonToEuro(amount);
                conversionResultTextBox.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
            }
        }

        private void ConvertToRonButton_Click(object sender, EventArgs e)
        {
            conversionResultTextBox.Text = "";
            try
            {
                float amount = float.Parse(euroTextBox.Text);
                float result = _client.EuroToRon(amount);
                conversionResultTextBox.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input!");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            string dateTime = _client.CurrentDateAndTime();
            dateTextBox.Text = dateTime;
        }
    }
}
