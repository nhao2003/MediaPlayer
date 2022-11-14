﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer.Models
{
    static class ListSong
    {
        public static string pathFolder = "C:\\Users\\Administrator\\Music";
        public static List<Song> listSongs = new List<Song>();
        public static void FetchListSong()
        {
            string[] filePaths = {};
            listSongs = new List<Song>();
            // chon file =======================================================
            try
            {
                filePaths = System.IO.Directory.GetFiles(
                pathFolder,
                "*.mp3",
                System.IO.SearchOption.AllDirectories);
            }
            catch
            {
                MessageBox.Show("Duong dan" + pathFolder + " khong ton tai");
            }
            //===================================================================
            Song tmp;
            for (int i = 0; i < filePaths.Length; i++)
            {
                try
                {
                    tmp = new Song(filePaths[i]);
                    listSongs.Add(tmp);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("An error occured ");
                    MessageBox.Show(ex.ToString(), "Tong so bai hat: " + filePaths.Length.ToString() + " loi o bai: " + i.ToString());
                }
            }
        }
    }
}
