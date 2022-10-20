using MediaPlayer.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MediaPlayer.Models
{
    static class PlayMedia
    {
        public static Thread thread;
        public static WindowsMediaPlayer windowsMediaPlayer = new WindowsMediaPlayer();
        public static AxWMPLib.AxWindowsMediaPlayer player = new AxWMPLib.AxWindowsMediaPlayer();

        static string path = null;
        static double currentTimePlay = 0.0;

        public static void Play(String url)
        {
            if (thread != null && thread.IsAlive )
            {
                thread.Abort();
                return;
            }
            ThreadStart threadStart = async () =>
            {
                windowsMediaPlayer.URL = url;
                windowsMediaPlayer.controls.play();
                Thread.Sleep(5000);
            };
            thread = new Thread(threadStart)
            {
                IsBackground = true
            };
            thread.Start();
        }

        // set fuction
        public static void setPath(string value)
        {
            path = value;
        }
        public static void setCurrentTimePlay()
        {
            currentTimePlay = player.Ctlcontrols.currentPosition;
        }
        // get function
        public static double getCurrentTimePlay()
        {
            return currentTimePlay;
        }
        public static WMPLib.WMPPlayState getStatus()
        {
            return player.playState;
        }

        public static double getDurationSong()
        {
            return player.Ctlcontrols.currentItem.duration;
        }
        public static double getCurrentPositionSong()
        {
            return player.Ctlcontrols.currentPosition;
        }
        public static string getDurationStringSong()
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                return player.Ctlcontrols.currentItem.durationString.ToString();
            return "00:00";
        }
        public static string getCurrentPositionStringSong()
        {
            if(player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                return player.Ctlcontrols.currentPositionString;
            return "00:00";
        }
        // methold

        public static void setURL(string Path = null)
        {
            player.CreateControl();
            if (Path != null)
            {
                path = Path;
            }
            if (path != null)
            {
                currentTimePlay = 0.0;
                player.URL = path;
                player.Ctlcontrols.stop();
            }
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
            currentTimePlay = 0.0;
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
        public static void setVolume(int volume)
        {
            player.settings.volume = volume;
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
