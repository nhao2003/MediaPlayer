using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WMPLib;

namespace MediaPlayer.Models
{
    static class PlayMedia
    {
        public static Thread thread;
        public static WindowsMediaPlayer windowsMediaPlayer = new WindowsMediaPlayer();
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

    }
}
