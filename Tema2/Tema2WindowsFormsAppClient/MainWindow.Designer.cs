using System.Drawing;

namespace Tema2WindowsFormsAppClient
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.watchListBox = new System.Windows.Forms.ListBox();
            this.watchedListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.releaseDateTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.deleteMovieButton = new System.Windows.Forms.Button();
            this.movieIdTextBox = new System.Windows.Forms.TextBox();
            this.moveMovieButton = new System.Windows.Forms.Button();
            this.editMovieButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // watchListBox
            // 
            this.watchListBox.FormattingEnabled = true;
            this.watchListBox.ItemHeight = 16;
            this.watchListBox.Location = new System.Drawing.Point(12, 32);
            this.watchListBox.Name = "watchListBox";
            this.watchListBox.Size = new System.Drawing.Size(184, 276);
            this.watchListBox.TabIndex = 0;
            this.watchListBox.SelectedIndexChanged += new System.EventHandler(this.watchListBox_SelectedIndexChanged);
            // 
            // watchedListBox
            // 
            this.watchedListBox.FormattingEnabled = true;
            this.watchedListBox.ItemHeight = 16;
            this.watchedListBox.Location = new System.Drawing.Point(240, 32);
            this.watchedListBox.Name = "watchedListBox";
            this.watchedListBox.Size = new System.Drawing.Size(184, 276);
            this.watchedListBox.TabIndex = 1;
            this.watchedListBox.SelectedIndexChanged += new System.EventHandler(this.watchedListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Watch list:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(237, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Watched movies:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Duration:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Release Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Rating:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(550, 35);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(212, 22);
            this.titleTextBox.TabIndex = 10;
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(550, 72);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(212, 22);
            this.genreTextBox.TabIndex = 11;
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(550, 113);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(212, 22);
            this.durationTextBox.TabIndex = 12;
            // 
            // releaseDateTextBox
            // 
            this.releaseDateTextBox.Location = new System.Drawing.Point(550, 155);
            this.releaseDateTextBox.Name = "releaseDateTextBox";
            this.releaseDateTextBox.Size = new System.Drawing.Size(212, 22);
            this.releaseDateTextBox.TabIndex = 13;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(550, 190);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(212, 22);
            this.ratingTextBox.TabIndex = 14;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(550, 230);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(212, 84);
            this.descriptionTextBox.TabIndex = 15;
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(12, 331);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(184, 45);
            this.addMovieButton.TabIndex = 16;
            this.addMovieButton.Text = "Add new Movie to Watch list";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // deleteMovieButton
            // 
            this.deleteMovieButton.Location = new System.Drawing.Point(653, 331);
            this.deleteMovieButton.Name = "deleteMovieButton";
            this.deleteMovieButton.Size = new System.Drawing.Size(109, 45);
            this.deleteMovieButton.TabIndex = 17;
            this.deleteMovieButton.Text = "Delete Movie";
            this.deleteMovieButton.UseVisualStyleBackColor = true;
            this.deleteMovieButton.Click += new System.EventHandler(this.deleteMovieButton_Click);
            // 
            // movieIdTextBox
            // 
            this.movieIdTextBox.Location = new System.Drawing.Point(662, 3);
            this.movieIdTextBox.Name = "movieIdTextBox";
            this.movieIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.movieIdTextBox.TabIndex = 18;
            this.movieIdTextBox.Visible = false;
            // 
            // moveMovieButton
            // 
            this.moveMovieButton.Location = new System.Drawing.Point(12, 393);
            this.moveMovieButton.Name = "moveMovieButton";
            this.moveMovieButton.Size = new System.Drawing.Size(184, 45);
            this.moveMovieButton.TabIndex = 19;
            this.moveMovieButton.Text = "Move Movie to Watched";
            this.moveMovieButton.UseVisualStyleBackColor = true;
            this.moveMovieButton.Click += new System.EventHandler(this.moveMovieButton_Click);
            // 
            // editMovieButton
            // 
            this.editMovieButton.Location = new System.Drawing.Point(459, 331);
            this.editMovieButton.Name = "editMovieButton";
            this.editMovieButton.Size = new System.Drawing.Size(109, 45);
            this.editMovieButton.TabIndex = 20;
            this.editMovieButton.Text = "Edit Movie";
            this.editMovieButton.UseVisualStyleBackColor = true;
            this.editMovieButton.Click += new System.EventHandler(this.editMovieButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(456, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Movie details:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.editMovieButton);
            this.Controls.Add(this.moveMovieButton);
            this.Controls.Add(this.movieIdTextBox);
            this.Controls.Add(this.deleteMovieButton);
            this.Controls.Add(this.addMovieButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.releaseDateTextBox);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.watchedListBox);
            this.Controls.Add(this.watchListBox);
            this.Name = "MainWindow";
            this.Text = "Tema2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox watchListBox;
        private System.Windows.Forms.ListBox watchedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox releaseDateTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.Button deleteMovieButton;
        private System.Windows.Forms.TextBox movieIdTextBox;
        private System.Windows.Forms.Button moveMovieButton;
        private System.Windows.Forms.Button editMovieButton;
        private System.Windows.Forms.Label label9;
    }
}

