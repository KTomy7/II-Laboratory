using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema2WindowsFormsAppClient.MoviesServiceReference;

namespace Tema2WindowsFormsAppClient
{
    public partial class AddMovieForm : Form
    {
        private readonly MoviesWebServiceSoapClient _client;
        public AddMovieForm(MoviesWebServiceSoapClient client)
        {
            InitializeComponent();
            _client = client;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie()
            {
                Title = titleTextBox.Text,
                Genre = genreTextBox.Text,
                Duration = int.Parse(durationTextBox.Text),
                ReleaseDate = DateTime.Parse(releaseDateTextBox.Text),
                Rating = int.Parse(ratingTextBox.Text),
                Description = descriptionTextBox.Text,
                Watched = false
            };
            _client.AddMovie(movie);
            this.Close();
        }
    }
}
