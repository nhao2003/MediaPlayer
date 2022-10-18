using MediaPlayer.Items;
using MediaPlayer.Widgets;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace MediaPlayer
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void gunaButton_Home_Click(object sender, EventArgs e)
        {
            indicater.Top = gunaButton_Home.Top;
            MainPages.SetPage(0);
        }

        private void gunaButton_Search_Click(object sender, EventArgs e)
        {
            indicater.Top = gunaButton_Search.Top;
            MainPages.SetPage(1);
        }

        private void gunaButton_Music_Click(object sender, EventArgs e)
        {
            indicater.Top = gunaButton_Music.Top;
            MainPages.SetPage(2);
        }

        private void gunaButton_Video_Click(object sender, EventArgs e)
        {
            indicater.Top = gunaButton_Video.Top;
            MainPages.SetPage(3);
        }

        private void gunaButton_Library_Click(object sender, EventArgs e)
        {
            indicater.Top = gunaButton_Library.Top;
            MainPages.SetPage(4);
        }

        private void gunaButton_Settings_Click(object sender, EventArgs e)
        {
            indicater.Top = gunaButton_Settings.Top;
            MainPages.SetPage(5);
        }
        //===== xử lý sự kiện phát nhạc =====================================
        private void Form_Main_Load(object sender, EventArgs e)
        {
            userControl_Video1.sendPathSong = new UserControl_Video.sendStringData(setDataOfSong);


            mediaControl.playSong = new MediaControl.pessTheButton(play);
            mediaControl.nextSong = new MediaControl.pessTheButton(next);
            mediaControl.previewSong = new MediaControl.pessTheButton(preview);
            mediaControl.setCurrentPosition = new MediaControl.scrollTheTrackBar(changeCurrentPosition);
            mediaControl.setVolume = new MediaControl.scrollTheTrackBar(setVolume);

            mediaControl.getDurationSong = new MediaControl.getIntData(getDurationSong);
            mediaControl.getCurrentPositionSong = new MediaControl.getIntData(getCurrentPositionSong);
            mediaControl.getDurationStringSong = new MediaControl.getStringData(getDurationStringSong);
            mediaControl.getCurrentPositionStringSong = new MediaControl.getStringData(getCurrentPositionStringSong);
            mediaControl.getStatusSong = new MediaControl.getStatus(getStatus);
        }
        public WMPLib.WMPPlayState getStatus()
        {
            return userControl_Video1.player1.getStatus();
        }
        public int getDurationSong()
        {
            if (userControl_Video1.player1.getStatus() == WMPLib.WMPPlayState.wmppsPlaying)
                return (int)userControl_Video1.player1.getDurationSong();
            return 0;
        }
        public int getCurrentPositionSong()
        {
            if (userControl_Video1.player1.getStatus() == WMPLib.WMPPlayState.wmppsPlaying)
                return (int)userControl_Video1.player1.getCurrentPositionSong();
            return 0;
        }
        public string getDurationStringSong()
        {
            if (userControl_Video1.player1.getStatus() == WMPLib.WMPPlayState.wmppsPlaying)
                return userControl_Video1.player1.getDurationStringSong();
            return "00:00";
        }
        public string getCurrentPositionStringSong()
        {
            if (userControl_Video1.player1.getStatus() == WMPLib.WMPPlayState.wmppsPlaying)
                return userControl_Video1.player1.getCurrentPositionStringSong();
            return "00:00";
        }
        public void setDataOfSong(String path)
        {
            mediaControl.getPathOfSong(path);
        }
        public void play(object sender, EventArgs e)
        {
            if(userControl_Video1.player1.getStatus() == WMPLib.WMPPlayState.wmppsPlaying)
            {
                userControl_Video1.button_pause_Click(sender, e);
            }
            else if (userControl_Video1.player1.getStatus() == WMPLib.WMPPlayState.wmppsPaused)
            {
                userControl_Video1.button_continue_Click(sender, e);
            }
            else
            {
                userControl_Video1.button_Play_Click(sender, e);
            }
        }
        public void next(object sender, EventArgs e)
        {
            userControl_Video1.button_next_Click(sender, e);
        }
        public void preview(object sender, EventArgs e)
        {
            userControl_Video1.button1_Click(sender, e);
        }
        public void changeCurrentPosition(object sender, EventArgs e, int value, int progressBarWidth)
        {
            userControl_Video1.player1.setCurrentPosition(value, progressBarWidth);
        }
        public void setVolume(object sender, EventArgs e, int value, int progressBarWidth)
        {
            userControl_Video1.player1.setVolume(value);
        }
    }
}
