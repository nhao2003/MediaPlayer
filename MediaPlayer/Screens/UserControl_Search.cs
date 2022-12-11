using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer.Models;
using System.IO;
using CsvHelper;
using Guna.UI.WinForms;
using MediaPlayer.Widgets;
using MediaPlayer.Items;
namespace MediaPlayer.Widgets
{
    public partial class UserControl_Search : UserControl
    {
        public UserControl_Search()
        {
            InitializeComponent();
        }
        static Media[] SongList;
        static MediaPanel[] songs;
        static string[] split;
        static TagLib.File[] f;
        static int count = new int();
        static GunaLabel nothingWasFound = null;
        private void gunaTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {   
                if (nothingWasFound == null)
                {
                    this.Controls.Remove(nothingWasFound);
                }
                if (count != 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        gunaElipsePanel3.Controls.Remove(songs[i]);
                    }
                }
                // string filePath = gunaTextBox1.Text;
                string filePath = "MusicDataBase\\Song.csv";
                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        count = 0;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (count == 0)
                            {
                                count++;
                                continue;
                            }
                            count++;
                        }
                        // accounted for sep; line 
                        // accounted for columnheader_line
                        count = count - 2;
                    }
                    
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        int idx = 0;
                        SongList = new Media[count];
                        f = new TagLib.File[count];
                        bool firstLine = true;
                        bool secondLine = true;
                        while ((line = reader.ReadLine()) != null)
                        {
                            // pass sep; line
                            if (firstLine)
                            {
                                firstLine = false;
                                continue;
                            }
                            // pass column_header line
                            else if (secondLine)
                            {
                                secondLine = false;
                                continue;
                            }
                            // MessageBox.Show(line);
                            split = line.Split(';');
                            SongList[idx] = new Media();
                            SongList[idx].Title = split[0];
                            SongList[idx].Artists = split[1];
                            SongList[idx].FilePath = split[2];
                            f[idx] = TagLib.File.Create(split[2]);
                            SongList[idx].Album = split[3];
                            SongList[idx].Duration = TimeSpan.Parse(split[4]);
                            SongList[idx].DateAdded = DateTime.Parse(split[5]);
                            SongList[idx].IsLiked = bool.Parse(split[6]);
                            idx = idx + 1;
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                string findMusic = gunaTextBox1.Text.ToString();
                int xLoc = 0;
                int yLoc = 300;
                songs = new MediaPanel[count];
                bool isMusicFounded = false;
                for (int i = 0; i < count; i++)
                {
                    //  -> not case insensitive
                    bool findTitle = SongList[i].Title.IndexOf(findMusic, StringComparison.OrdinalIgnoreCase) >= 0;
                    bool findArtists = SongList[i].Artists.IndexOf(findMusic, StringComparison.OrdinalIgnoreCase) >= 0;
                    bool findAlbum = SongList[i].Album.IndexOf(findMusic, StringComparison.OrdinalIgnoreCase) >= 0;
                    if (!findTitle && !findAlbum && !findArtists) continue;
                    // if (!SongList[i].Title.Contains(findMusic)) continue;
                    isMusicFounded = true;
                    songs[i] = new MediaPanel();
                    songs[i].Location = new Point(xLoc, yLoc);
                    songs[i].Dock = DockStyle.Top;
                    songs[i].InitializeSongItem(f[i], SongList[i].FilePath, i + 1);
                    yLoc += 100;
                    gunaElipsePanel3.Controls.Add(songs[i]);
                }

                if (!isMusicFounded)
                {
                    nothingWasFound = new GunaLabel();
                    nothingWasFound.Text = "Kiem tra chinh ta cua ban hoac kiem noi dung khac";
                    nothingWasFound.Font = new Font("Inter", 14, FontStyle.Bold);
                    nothingWasFound.Width = 800;
                    nothingWasFound.Height = 100;
                    nothingWasFound.Location = new Point(0, 300);
                    nothingWasFound.Dock = DockStyle.Top;
                    gunaElipsePanel3.Controls.Add(nothingWasFound);
                }
            }
        }

        private void gunaTextBox1_Enter(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "Nhập tên nhạc / Album / Ca sĩ")
            {
                gunaTextBox1.Text = "";
                gunaTextBox1.ForeColor = Color.Black;
            }
        }

        private void gunaTextBox1_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "")
            {
                gunaTextBox1.Text = "Nhập tên nhạc / Album / Ca sĩ";
                gunaTextBox1.ForeColor = Color.Green;
            }
        }
    }
}
