using MediaPlayer.Models;
using MediaPlayer.Properties;
using System;
using System.Windows.Forms;
using Utilities.BunifuCircleProgress.Transitions;

namespace MediaPlayer
{
    public partial class VideoPlayer : Form
    {
        private DateTime date = DateTime.Now;
        public VideoPlayer()
        {
            InitializeComponent();
            timer_Hide.Start();
        }
        private void VideoPlayer_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
            timerSong.Enabled = true;
            gunaTrackBar_Volume.MouseWheel += GunaTrackBar_Volume_MouseWheel;
            player.uiMode = "none";
        }
        private void VideoPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_Main.Instance.MediaControl.isPlayingVideo = false;
            Form_Main.Instance.MediaControl._media = _media;
            if (_media != null) PlayMedia.URL = _media.FilePath;
            PlayMedia.CurrentTimePlay = currentTimePlay + 0.6;
            Form_Main.Instance.MediaControl.SyncWithVideo(_media, player.playState, true);
            Form_Main.Instance.Show();
        }

        public double timeSkip = 10;
        public double currentTimePlay = 0.0;
        private Media _media;

        public void getPathOfSong(Media media)
        {
            try
            {
                _media = media;
                player.URL = media.FilePath;

                lb_SongName.Text = media.Title;

                MediaTrackBar.Maximum = (int)media.Duration.TotalSeconds;
                MediaTrackBar.Value = 0;
                timeSongPlay.Text = "00:00";
                timeSongEnd.Text = media.DurationText;
                currentTimePlay = player.Ctlcontrols.currentPosition;

            }
            catch (Exception e)
            {
                MessageBox.Show("Video bi loi: " + e.ToString());
            }
        }

        // timer 
        private void timer_Tick(object sender, EventArgs e)
        {
            Form_Main.Instance.MediaControl.SyncWithVideo(_media, player.playState, false);
            SetIconVolume();
            setIconPlay();
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                MediaTrackBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                MediaTrackBar.Value = (int)player.Ctlcontrols.currentPosition;
                timeSongPlay.Text = getCurrentPositionstringSong();
                timeSongEnd.Text = getDurationstringSong();
                currentTimePlay = player.Ctlcontrols.currentPosition;

                // sync with mediaControl
                Form_Main.Instance.MediaControl.MediaTrackBar.Value = (int)player.Ctlcontrols.currentPosition;
                Form_Main.Instance.MediaControl.gunaTrackBar_Volume.Value = gunaTrackBar_Volume.Value;
                Form_Main.Instance.MediaControl.timeSongPlay.Text = getCurrentPositionstringSong();
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                Form_Main.Instance.MediaControl.isPlayingVideo = false;
                this.Close();
                Form_Main.Instance.Show();
            }
        }
        private string getDurationstringSong()
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                return player.Ctlcontrols.currentItem.durationString.ToString();
            return "00:00";
        }
        private string getCurrentPositionstringSong()
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying || player.playState == WMPLib.WMPPlayState.wmppsPaused)
                return player.Ctlcontrols.currentPositionString;
            return "00:00";
        }
        private void SetIconVolume()
        {
            if (gunaTrackBar_Volume.Value == 0)
            {
                btn_volum.Image = Resources.volume_mute;
                btn_volum.OnHoverImage = Resources.volume_mute_hover;
            }
            else if (gunaTrackBar_Volume.Value < 50)
            {
                btn_volum.Image = Resources.volume_low;
                btn_volum.OnHoverImage = Resources.volume_low_hover;
            }
            else
            {
                btn_volum.Image = Resources.volume_high;
                btn_volum.OnHoverImage = Resources.volume_high_hover;
            }
        }
        public void setIconPlay()
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                btn_play.Image = Resources.pause_hover;
                btn_play.OnHoverImage = Resources.pause_hover;
            }
            else
            {
                btn_play.Image = Resources.play_hover;
                btn_play.OnHoverImage = Resources.play_hover;
            }
        }
        private void btn_play_Click(object sender, EventArgs e)
        {
            click_btn_play();
            setIconPlay();
        }
        public void setCurrentTimePlay()
        {
            player.Ctlcontrols.currentPosition = currentTimePlay;
        }
        public void click_btn_play()
        {
            try
            {
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    //timerSong.Enabled = false;
                    player.Ctlcontrols.pause();
                }
                else if (player.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    setCurrentTimePlay();
                    player.Ctlcontrols.play();
                    //timerSong.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Video bi loi nut play: " + ex.ToString());
            }
        }
        private void MediaTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (player.currentMedia != null)
                    setCurrentPosition(e.X, MediaTrackBar.Width);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void setCurrentPosition(int mousePosition, int progressBarWidth)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * mousePosition / progressBarWidth;
            // currrent position
            currentTimePlay = player.Ctlcontrols.currentPosition;
            // text time current
            timeSongPlay.Text = getCurrentPositionstringSong();
        }
        // volume
        private void gunaTrackBar_Volume_Scroll(object sender, ScrollEventArgs e)
        {
            changeVolume(gunaTrackBar_Volume.Value);
        }
        private void GunaTrackBar_Volume_MouseWheel(object sender, MouseEventArgs e)
        {
            changeVolume(gunaTrackBar_Volume.Value);
        }
        public int volumeNow = 100;
        private void gunaCircleButton_Volume_Click(object sender, EventArgs e)
        {
            changeMute();
        }
        public void changeMute()
        {
            if (player.settings.volume != 0)
            {
                player.settings.volume = 0;
                volumeNow = gunaTrackBar_Volume.Value;
                gunaTrackBar_Volume.Value = 0;
            }
            else
            {
                player.settings.volume = volumeNow;
                gunaTrackBar_Volume.Value = volumeNow;
            }
        }
        public void changeVolume(int n)
        {
            gunaTrackBar_Volume.Value = n;
            player.settings.volume = n;
        }
        // time song
        private void btn_giam_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentTimePlay - timeSkip >= 0)
                    player.Ctlcontrols.currentPosition = currentTimePlay - timeSkip;
                else player.Ctlcontrols.currentPosition = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Video bi loi nut giam: " + ex.ToString());
            }

        }

        private void btn_tang_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentTimePlay + timeSkip <= MediaTrackBar.Maximum)
                    player.Ctlcontrols.currentPosition = currentTimePlay + timeSkip;
                else player.Ctlcontrols.currentPosition = MediaTrackBar.Maximum;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Video bi loi nut tang: " + ex.ToString());
            }
        }
        private void btn_Hide_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            timer_Hide.Enabled = false;
            player.ClickEvent += Player_ClickEvent;
        }

        private void Player_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            timer_Hide.Enabled = true;
            panel1.Visible = true;
        }

        private void timer_Hide_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now > date)
            {
                panel1.Visible = false;
            }
            else if (DateTime.Now <= date)
            {
                panel1.Visible = true;
            }
        }
        private int x = 0;
        private int y = 0;

        private void player_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
        {
            if (e.fX != x && e.fY != y)
                date = DateTime.Now + TimeSpan.FromSeconds(5);
            x = e.fX;
            y = e.fY;
        }
        private bool _fullScreen = false;

        public bool FullScreen
        {
            get => _fullScreen;
            set
            {
                if (value == _fullScreen) return;
                if (value)
                {
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                }
                else
                {
                    WindowState = FormWindowState.Normal;
                    FormBorderStyle = FormBorderStyle.Sizable;
                }
                _fullScreen = value;
            }
        }
        private void btn_FullScreen_Click(object sender, EventArgs e)
        {
            FullScreen = !FullScreen;
        }
        private void VideoShortcut(int KeyValue)
        {
            switch (KeyValue)
            {
                case 27:
                    FullScreen = false;
                    break;
                case 32:
                    btn_play.PerformClick();
                    break;
                case 37:
                    btn_giam.PerformClick();
                    break;
                case 39:
                    btn_tang.PerformClick();
                    break;
                case 38:
                    if (gunaTrackBar_Volume.Value + 5 >= 100)
                    {
                        gunaTrackBar_Volume.Value = 100;
                        break;
                    }
                    gunaTrackBar_Volume.Value += 5;
                    break;
                case 40:
                    if (gunaTrackBar_Volume.Value - 5 <= 0)
                    {
                        gunaTrackBar_Volume.Value = 0;
                        break;
                    }
                    gunaTrackBar_Volume.Value -= 5;
                    break;
                case 70:
                    FullScreen = !FullScreen;
                    break;

            }
        }
        private void VideoPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            VideoShortcut(e.KeyValue);
        }

        private void player_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
            VideoShortcut(e.nKeyCode);
        }

        private void panel1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            VideoShortcut(e.KeyValue);
        }

        private void gunaTrackBar_Volume_ValueChanged(object sender, EventArgs e)
        {
            player.settings.volume = gunaTrackBar_Volume.Value;
        }

        private void player_ClickEvent_1(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            btn_play.PerformClick();
        }
    }
}
