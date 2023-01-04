using MediaPlayer.Models;
using MediaPlayer.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TagLib;

namespace MediaPlayer.Items
{
    // khi bam vao bai hat, them vao queue (done)
    // add to queue thi them vao cuoi queue (done)
    // play next thi them vao queue nhung o sau bai dang hat (done)
    // bam play list thi clear queue, play list
    // play next play list la chay sau khi het play tiep
    public partial class MediaControl : UserControl
    {
        public Media _media = null;
        public delegate void PassMediaControl(MediaControl control);
        public bool isPlayingVideo = false;
        List<int> listIndexPlay;
        public MediaControl()
        {
            InitializeComponent();
            gunaTrackBar_Volume.MouseWheel += GunaTrackBar_Volume_MouseWheel;

            MusicRow test = new MusicRow();
            PassMediaControl datasend = new PassMediaControl(test.GetMediaControl);
            datasend(this);
            UpdateListIndexPlay();
        }
        internal void UpdateListIndexPlay()
        {
            if(PlayMedia.Suffle == false)
                listIndexPlay = new List<int>(MediaHelpers.ListIndexPlayQueue);
        }
        internal void transferDataFromLib(Media media)
        {
            _media = media;
            getPathOfSong(_media);
        }

        public void getPathOfSong(Media media)
        {
            if (isPlayingVideo)
            {
                MessageBox.Show("Video is playing! Please turn off video");
                return;
            }
            if (media != null) _media = media;
            gunaLabel_SongName.Text = media.Title;
            gunaLabel_NameAthor.Text = media.Artists;
            gunaPictureBox_SongImage.Image = media.Image;
            MediaTrackBar.Maximum = (int)media.Duration.TotalSeconds;
            MediaTrackBar.Value = 0;
            timeSongPlay.Text = "00:00";
            timeSongEnd.Text = media.DurationText;

            // Lay path gan cho PlayMedia
            if (media.FilePath != null) PlayMedia.URL = media.FilePath;
            PlayMedia.setCurrentTimePlay();
            // Play
            timerSong.Enabled = true;
            btn_Play.Image = Resources.pause_hover;
            btn_Play.OnHoverImage = Resources.pause_hover;
            PlayMedia.playSong();

            // gan nhac cho trang songPlaying
            Form_Main.Instance.userControl_Playing.Media = media;
            // tang them mot don vi cho listIndexPlay
            UpdateListIndexPlay();
        }

        public void pauseCurrentPlayer()
        {
            if (PlayMedia.IsFirst == false) return;
            if (PlayMedia.Status == WMPLib.WMPPlayState.wmppsPlaying)
            {
                timerSong.Enabled = false;
                btn_Play.Image = Resources.play_hover;
                btn_Play.OnHoverImage = Resources.play_hover;
                PlayMedia.pauseSong();
            }
        }
        private void gunaCircleButton_Play_Click(object sender, EventArgs e)
        {
            click_btn_play();
        }
        public void click_btn_play()
        {
            try
            {
                // adjust video
                if (isPlayingVideo)
                {
                    videoScreen.click_btn_play();
                    return;
                }
                // adjust song
                if (PlayMedia.IsFirst == false) return;
                if (PlayMedia.Status == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    timerSong.Enabled = false;
                    btn_Play.Image = Resources.play_hover;
                    btn_Play.OnHoverImage = Resources.play_hover;
                    PlayMedia.pauseSong();
                }
                else if (PlayMedia.Status == WMPLib.WMPPlayState.wmppsPaused)
                {
                    btn_Play.Image = Resources.pause_hover;
                    btn_Play.OnHoverImage = Resources.pause_hover;
                    PlayMedia.continueSong();
                    timerSong.Enabled = true;
                }
                else
                {
                    timerSong.Enabled = true;
                    btn_Play.Image = Resources.pause_hover;
                    btn_Play.OnHoverImage = Resources.pause_hover;
                    PlayMedia.playSong();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public bool startTimer
        {
            set { timerSong.Enabled = value; }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Form_Main.Instance.userControl_Home1.suggestBar1.changeImage(_media);
            if (PlayMedia.player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                MediaTrackBar.Maximum = (int)PlayMedia.DurationSong;
                MediaTrackBar.Value = (int)PlayMedia.CurrentPositionSong;
                timeSongPlay.Text = PlayMedia.CurrentPositionstringSong;
                timeSongEnd.Text = PlayMedia.DurationstringSong;
                btn_Play.Image = Resources.pause_hover;
                btn_Play.OnHoverImage = Resources.pause_hover;
                PlayMedia.setCurrentTimePlay();
            }
            else if (PlayMedia.player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                if (PlayMedia.Repeat == RepeatMode.One)
                {
                    // lap lai bai hat
                    timerSong.Enabled = true;
                    PlayMedia.playSong();
                }
                else
                {
                    gunaCircleButton_next_Click(sender, e);
                }
            }
        }

        private void MediaTrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            // adjust video
            if (isPlayingVideo)
            {
                videoScreen.setCurrentPosition(e.X, MediaTrackBar.Width);
                return;
            }
            // adjust song
            if (PlayMedia.IsFirst == false) return;
            PlayMedia.setCurrentPosition(e.X, MediaTrackBar.Width);
        }
        private void GunaTrackBar_Volume_MouseWheel(object sender, MouseEventArgs e)
        {
            // adjust video
            if (isPlayingVideo)
            {
                videoScreen.changeVolume(gunaTrackBar_Volume.Value);
                return;
            }
            // adjust song
            if (PlayMedia.IsFirst == false) return;
            PlayMedia.Volume = gunaTrackBar_Volume.Value;
            SetIconVolume();
        }
        private void gunaTrackBar_Volume_Scroll(object sender, ScrollEventArgs e)
        {
            // adjust video
            if (isPlayingVideo)
            {
                videoScreen.changeVolume(gunaTrackBar_Volume.Value);
                return;
            }
            // adjust song
            if (PlayMedia.IsFirst == false) return;
            PlayMedia.Volume = gunaTrackBar_Volume.Value;
            SetIconVolume();
        }

        public int volumeNow = 100;

        private void SetIconVolume()
        {
            if (gunaTrackBar_Volume.Value == 0)
            {
                btn_Volume.Image = Resources.volume_mute;
                btn_Volume.OnHoverImage = Resources.volume_mute_hover;
            }
            else if (gunaTrackBar_Volume.Value < 50)
            {
                btn_Volume.Image = Resources.volume_low;
                btn_Volume.OnHoverImage = Resources.volume_low_hover;
            }
            else
            {
                btn_Volume.Image = Resources.volume_high;
                btn_Volume.OnHoverImage = Resources.volume_high_hover;
            }
        }
        private void gunaCircleButton_Volume_Click(object sender, EventArgs e)
        {
            // adjust video
            if (isPlayingVideo)
            {
                videoScreen.changeMute();
                return;
            }
            // adjust song
            if (PlayMedia.IsFirst == false) return;
            if (PlayMedia.player.settings.volume != 0)
            {
                PlayMedia.muteVolume();
                volumeNow = gunaTrackBar_Volume.Value;
                gunaTrackBar_Volume.Value = 0;
            }
            else
            {
                PlayMedia.Volume = volumeNow;
                gunaTrackBar_Volume.Value = volumeNow;
            }
            SetIconVolume();
        }
        private void gunaCircleButton_next_Click(object sender, EventArgs e)
        {
            if (PlayMedia.IsFirst == false) return;
            // listIndexPlay has array 0 1 2 3 4 ...
            // in suffer Mode 0 1 3 2 5 4 ....
            for (int i = 0; i < MediaHelpers.PlayQueue.Count; i++)
            {
                if (MediaHelpers.PlayQueue[listIndexPlay[i]].FilePath == PlayMedia.Path)
                {
                    if (i != MediaHelpers.PlayQueue.Count - 1)
                    {
                        //MessageBox.Show(listIndexPlay[i + 1].ToString());
                        getPathOfSong(MediaHelpers.PlayQueue[listIndexPlay[i + 1]]);
                        PlayMedia.playSong();
                    }
                    else if (i == MediaHelpers.PlayQueue.Count - 1 && PlayMedia.Repeat == RepeatMode.All)
                    {
                        getPathOfSong(MediaHelpers.PlayQueue[listIndexPlay[0]]);
                        PlayMedia.playSong();
                    }
                    return;
                }
            }
        }

        private void gunaCircleButton_prev_Click(object sender, EventArgs e)
        {
            if (PlayMedia.IsFirst == false) return;
            for (int i = 0; i < MediaHelpers.PlayQueue.Count; i++)
            {
                if (MediaHelpers.PlayQueue[listIndexPlay[i]].FilePath == PlayMedia.Path)
                {
                    if (i != 0)
                    {
                        getPathOfSong(MediaHelpers.PlayQueue[listIndexPlay[i - 1]]);
                        PlayMedia.playSong();
                    }
                    return;
                }
            }
        }

        private void gunaCircleButton_Like_Click(object sender, EventArgs e)
        {
            //VideoPlayer video = new VideoPlayer();
            //video.Width = 900;
            //video.Height = 600;
            //video.ShowDialog();
        }

        // Sync with video
        public VideoPlayer videoScreen = new VideoPlayer();
        public void SyncWithVideo(Media media, WMPLib.WMPPlayState status, bool isClosing)
        {
            // ten, anh, thoi luong
            gunaLabel_SongName.Text = media.Title;
            gunaLabel_NameAthor.Text = media.Artists;
            SetIconVolume();
            gunaPictureBox_SongImage.Image = media.Image;
            MediaTrackBar.Maximum = (int)media.Duration.TotalSeconds;
            timeSongEnd.Text = media.DurationText;
            // button
            if (status == WMPLib.WMPPlayState.wmppsPlaying)
            {
                btn_Play.Image = Resources.pause_hover;
                btn_Play.OnHoverImage = Resources.pause_hover;
            }
            else
            {
                btn_Play.Image = Resources.play_hover;
                btn_Play.OnHoverImage = Resources.play_hover;
            }
            if (isClosing && status == WMPLib.WMPPlayState.wmppsPlaying)
            {
                click_btn_play();
            }
        }

        private void gunaPictureBox_SongImage_Click(object sender, EventArgs e)
        {
            if (isPlayingVideo) return;
            if (PlayMedia.IsFirst == false) return;
            if (_media.MediaTypes == MediaTypes.Audio)
            {
                Form_Main.Instance.ViewPlayingSong();
            }
            else
            {
                try
                {
                    if (videoScreen.Visible == false)
                    {
                        videoScreen = new VideoPlayer();
                        videoScreen.Show();
                    }
                    pauseCurrentPlayer();
                    Form_Main.Instance.videoScreen = videoScreen;
                    Form_Main.Instance.videoScreen.getPathOfSong(_media);
                    isPlayingVideo = true;
                    // sync
                    videoScreen.click_btn_play();
                    videoScreen.currentTimePlay = (int)PlayMedia.CurrentPositionSong + 0.6;
                    videoScreen.setCurrentTimePlay();
                    videoScreen.changeVolume(gunaTrackBar_Volume.Value);
                    Form_Main.Instance.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("song image click error: " + ex.Message);
                }
            }
        }

        private void btn_Repeat_Click(object sender, EventArgs e)
        {
            if (PlayMedia.Repeat == RepeatMode.Off)
            {
                PlayMedia.Repeat = RepeatMode.All;
                btn_Repeat.Image = Resources.repeat_on;
                btn_Repeat.OnHoverImage = Resources.repeat_on;
            }
            else if (PlayMedia.Repeat == RepeatMode.All)
            {
                PlayMedia.Repeat = RepeatMode.One;
                btn_Repeat.Image = Resources.repeat_one;
                btn_Repeat.OnHoverImage = Resources.repeat_one;
            }
            else if (PlayMedia.Repeat == RepeatMode.One)
            {
                PlayMedia.Repeat = RepeatMode.Off;
                btn_Repeat.Image = Resources.repeat;
                btn_Repeat.OnHoverImage = Resources.repeat;
            }
        }

        private void btn_Suffle_Click(object sender, EventArgs e)
        {
            if (PlayMedia.Suffle)
            {
                btn_Suffle.Image = Resources.suffle;
                btn_Suffle.OnHoverImage = Resources.suffle;
                PlayMedia.Suffle = false;
                listIndexPlay = new List<int>(MediaHelpers.ListIndexPlayQueue);
            }
            else
            {
                btn_Suffle.Image = Resources.suffle_hover;
                btn_Suffle.OnHoverImage = Resources.suffle_hover;
                PlayMedia.Suffle = true;
                listIndexPlay = new List<int>(MediaHelpers.ListRanDomIndex);
            }
        }
    }
}
