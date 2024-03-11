using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        // Create global variables to store the titles or names of the tracks and paths of the tracks
        string[] paths, files;
        private object listBoxSongs;
        private object axWindowsMediaPlayerMusic;

        public object DialogResult { get; private set; }

        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            // Code to select songs
            OpenFileDialog ofd = new OpenFileDialog();

            // Code to select multiple files
            ofd.Multiselect = true;

            if (ofd.ShowDialog()
                == DialogResult)
            {
                files = ofd.SafeFileNames; // save the names of the track in files array
                paths = ofd.FileNames;     // save the paths of the tracks in paths array

                // Display the music titles in the listbox
                for (int i = 0; i < files.Length; i++)
                {
                    _ = listBoxSongs.Add(files[i]); // Display songs in listbox
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Write code to play music
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Close the app
            this.Close();
        }

        private void Close()
        {
            throw new NotImplementedException();
        }
    }
}