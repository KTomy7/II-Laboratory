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
    public partial class MainWindow : Form
    {
        private readonly MoviesWebServiceSoapClient _client;
        public MainWindow()
        {
            InitializeComponent();
            _client = new MoviesWebServiceSoapClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var unwatchedMovies = _client.GetUnwatchedMovies().ToList();
            var watchedMovies = _client.GetWatchedMovies().ToList();
            foreach (var movie in unwatchedMovies)
            {
                watchListBox.Items.Add(movie.Title);
            }
            foreach (var movie in watchedMovies)
            {
                watchedListBox.Items.Add(movie.Title);
            }
        }

        private void watchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (watchListBox.SelectedItem != null)
            {
                var selectedTitle = watchListBox.SelectedItem.ToString();
                var movie = _client.GetMovieByTitle(selectedTitle);
                ShowDetails(movie);
            }
        }

        private void watchedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (watchedListBox.SelectedItem != null)
            {
                var selectedTitle = watchedListBox.SelectedItem.ToString();
                var movie = _client.GetMovieByTitle(selectedTitle);
                ShowDetails(movie);
            }
        }

        private void moveMovieButton_Click(object sender, EventArgs e)
        {
            var selectedTitle = watchListBox.SelectedItem.ToString();
            var movieToUpdate = _client.GetMovieByTitle(selectedTitle);
            movieToUpdate.Watched = true;
            _client.UpdateMovie(movieToUpdate);
            RefreshWindow();
        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            AddMovieForm addMovieForm = new AddMovieForm(_client);
            addMovieForm.Show();
            RefreshWindow();
        }

        private void editMovieButton_Click(object sender, EventArgs e)
        {
            var movie = _client.GetMovieById(int.Parse(movieIdTextBox.Text));
            EditMovieForm editMovieForm = new EditMovieForm(_client, movie);
            editMovieForm.Show();
            RefreshWindow();
        }

        private void deleteMovieButton_Click(object sender, EventArgs e)
        {
            var movieToDelete = _client.GetMovieById(int.Parse(movieIdTextBox.Text));
            _client.DeleteMovie(movieToDelete);
            RefreshWindow();
        }

        private void ShowDetails(MoviesServiceReference.Movie movie)
        {
            movieIdTextBox.Text = movie.Id.ToString();
            titleTextBox.Text = movie.Title;
            genreTextBox.Text = movie.Genre;
            durationTextBox.Text = movie.Duration.ToString() + " min";
            releaseDateTextBox.Text = movie.ReleaseDate.ToString("dd.MM.yyyy");
            ratingTextBox.Text = movie.Rating.ToString() + "/10";
            descriptionTextBox.Text = movie.Description;
        }

        private void RefreshWindow()
        {
            watchListBox.Items.Clear();
            watchedListBox.Items.Clear();
            movieIdTextBox.Text = "";
            titleTextBox.Text = "";
            genreTextBox.Text = "";
            durationTextBox.Text = "";
            releaseDateTextBox.Text = "";
            ratingTextBox.Text = "";
            descriptionTextBox.Text = "";
            var unwatchedMovies = _client.GetUnwatchedMovies().ToList();
            var watchedMovies = _client.GetWatchedMovies().ToList();
            foreach (var movie in unwatchedMovies)
            {
                watchListBox.Items.Add(movie.Title);
            }
            foreach (var movie in watchedMovies)
            {
                watchedListBox.Items.Add(movie.Title);
            }
        }
    }
}
