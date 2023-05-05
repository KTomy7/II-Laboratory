using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema2WebServices;
using Tema2WindowsFormsAppClient.MoviesServiceReference;

namespace Tema2WindowsFormsAppClient
{
    public partial class EditMovieForm : Form
    {
        private readonly MoviesWebServiceSoapClient _client;
        private MoviesServiceReference.Movie movieToUpdate;
        public EditMovieForm(MoviesWebServiceSoapClient client, MoviesServiceReference.Movie movie)
        {
            InitializeComponent();
            _client = client;
            movieToUpdate = movie;
        }

        private void EditMovieForm_Load(object sender, EventArgs e)
        {
            titleTextBox.Text = movieToUpdate.Title;
            genreTextBox.Text = movieToUpdate.Genre;
            durationTextBox.Text = movieToUpdate.Duration.ToString();
            releaseDateTextBox.Text = movieToUpdate.ReleaseDate.ToString("dd.MM.yyyy");
            ratingTextBox.Text = movieToUpdate.Rating.ToString();
            descriptionTextBox.Text = movieToUpdate.Description;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            movieToUpdate.Title = titleTextBox.Text;
            movieToUpdate.Genre = genreTextBox.Text;
            movieToUpdate.Duration = int.Parse(durationTextBox.Text);
            movieToUpdate.ReleaseDate = DateTime.Parse(releaseDateTextBox.Text);
            movieToUpdate.Rating = int.Parse(ratingTextBox.Text);
            movieToUpdate.Description = descriptionTextBox.Text;
            _client.UpdateMovie(movieToUpdate);
            this.Close();
        }
    }
}
