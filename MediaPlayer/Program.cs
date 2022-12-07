using MediaPlayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;

namespace MediaPlayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MediaHelpers.FetchListMedia(MediaTypes.Audio);
            MediaHelpers.FetchListMedia(MediaTypes.Video);
            Application.Run(Form_Main.Instance);
        }
    }
}
