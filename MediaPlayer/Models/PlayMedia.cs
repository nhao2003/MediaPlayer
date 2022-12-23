using System;
using System.Windows.Forms;

namespace MediaPlayer.Models
{
    public enum RepeatMode
    {
        Off = 0,
        One = 1,
        All = 2,
    }
    static class PlayMedia
    {
        public static AxWMPLib.AxWindowsMediaPlayer player = new AxWMPLib.AxWindowsMediaPlayer();
        public static RepeatMode Repeat = RepeatMode.Off;
        static string path = null;
        static double currentTimePlay = 0.0;
        static bool checkFirst = false;
        public static bool Suffle = false;
        // set fuction
        public static bool IsFirst
        {
            get { return checkFirst; }
        }
        public static void setCurrentTimePlay()
        {
            currentTimePlay = player.Ctlcontrols.currentPosition;
        }
        // get function
        public static double CurrentTimePlay
        {
            get { return currentTimePlay; }
            set { currentTimePlay = value; }
        }
        public static WMPLib.WMPPlayState Status
        {
            get { return player.playState; }
        }

        public static double DurationSong
        {
            get { return player.Ctlcontrols.currentItem.duration; }
        }
        public static double CurrentPositionSong
        {
            get { return player.Ctlcontrols.currentPosition; }
        }
        public static string DurationstringSong
        {
            get
            {
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    return player.Ctlcontrols.currentItem.durationString;
                return "00:00";
            }
        }
        public static string CurrentPositionstringSong
        {
            get
            {
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    return player.Ctlcontrols.currentPositionString;
                return "00:00";
            }
        }
        // methold
        public static string Path
        {
            get { return path; }
            set { path = value; }
        }
        public static string URL
        {
            set
            {
                checkFirst = true;
                player.CreateControl();
                if (value != null)
                {
                    path = value;
                }
                if (path != null)
                {
                    currentTimePlay = 0.0;
                    player.URL = path;
                    player.Ctlcontrols.stop();
                }
            }
        }
        public static int Volume
        {
            set { player.settings.volume = value; }
        }
        public static void continueSong()
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                player.Ctlcontrols.currentPosition = currentTimePlay;
                player.Ctlcontrols.play();
            }
        }
        public static void playSong()
        {
            //currentTimePlay = 0.0;
            player.Ctlcontrols.currentPosition = currentTimePlay;
            player.Ctlcontrols.play();
        }
        public static void stopSong()
        {
            currentTimePlay = 0.0;
            player.Ctlcontrols.stop();
        }
        public static void pauseSong()
        {
            player.Ctlcontrols.pause();
        }
        public static void muteVolume()
        {
            player.settings.volume = 0;
        }
        public static void setCurrentPosition(int mousePosition, int progressBarWidth)
        {
            try
            {
                if (player.currentMedia != null)
                    player.Ctlcontrols.currentPosition = player.currentMedia.duration * mousePosition / progressBarWidth;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
