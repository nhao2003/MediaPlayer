﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer.Items
{
    public partial class Player : UserControl
    {
        string path = null;

        public Player()
        {
            InitializeComponent();
            myPlayer.uiMode = "none";
        }
        // set fuction
        public void setPath(String path)
        {
            this.path = path;
        }
        // get function
        public WMPLib.WMPPlayState getStatus()
        {
            return myPlayer.playState;
        }

        public double getDurationSong()
        {
            return myPlayer.Ctlcontrols.currentItem.duration;
        }
        public double getCurrentPositionSong()
        {
            return myPlayer.Ctlcontrols.currentPosition;
        }
        public String getDurationStringSong()
        {
            return myPlayer.Ctlcontrols.currentItem.durationString.ToString();
        }
        public String getCurrentPositionStringSong()
        {
            return myPlayer.Ctlcontrols.currentPositionString;
        }
        public void playSong()
        {
            if (this.path != null)
            {
                myPlayer.URL = path;
                myPlayer.Ctlcontrols.play();
            }
        }
        public void stopSong()
        {
            myPlayer.Ctlcontrols.stop();
        }
        public void pauseSong()
        {
            myPlayer.Ctlcontrols.pause();
        }
        public void changeVolume(int volume)
        {
            myPlayer.settings.volume = volume;
        }
        public void changeCurrentPosition(int mousePosition, int progressBarWidth)
        {
            myPlayer.Ctlcontrols.currentPosition = myPlayer.currentMedia.duration * mousePosition / progressBarWidth;
        }
    }
}
