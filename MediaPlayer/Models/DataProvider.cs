using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;
namespace MediaPlayer.Models
{
    internal class DataProvider
    {
        static string dbPath = Environment.CurrentDirectory;
        static string testPath = @"Data Source=C:\Users\tuanb\Downloads\Documents\test.db";
        static SQLiteConnection conn = new SQLiteConnection(testPath);
        /// <summary>
        /// Phuong thuc tao cac bang data
        /// </summary>
        /// 
        public void testInsertOperation()
        {
            Media testMedia = new Media(@"C:\Users\tuanb\Downloads\Music\Shikisai - Yama.mp3");
            InsertIntoMedia(testMedia);
        }
        public void Init()
        {
            string sqlCreateMediaTable = "CREATE TABLE IF NOT EXISTS Media("
                + "MediaID VARCHAR(60000) PRIMARY KEY,"
                + "MediaPath VARCHAR(60000),"
                + "IsFavorite BIT"
                + ")";

            CreateTable(sqlCreateMediaTable);

            string sqlCreatePlaylistTable = "CREATE TABLE IF NOT EXISTS Playlist(" +
                "PlaylistID VARCHAR(60000) PRIMARY KEY,"
                 + "PlaylistName VARCHAR(60000),"
                 + "PicturePath VARCHAR(60000),"
                 + "DateOfCreation SMALLDATETIME"
                 + ")";

            CreateTable(sqlCreatePlaylistTable);

            string sqlCreateMediaPlaylist = "CREATE TABLE IF NOT EXISTS MediaPlaylist("
                + "PlaylistID VARCHAR(60000),"
                + "MediaID VARCHAR(60000),"
                + "PRIMARY KEY (PlaylistID, MediaID)"
                + "FOREIGN KEY (PlaylistID) REFERENCES Playlist(PlaylistID)"
                + "FOREIGN KEY (MediaID) REFERENCES Media(MediaID)"
                + ")";

            CreateTable(sqlCreateMediaPlaylist);

            testInsertOperation();
        }

        public void CreateTable(string tableCreationString)
        {
            conn.Open();

            var sqlCommand = new SQLiteCommand(tableCreationString, conn);
            RunSqlCommand(sqlCommand);

            conn.Close();
        }

        private static void RunSqlCommand(SQLiteCommand sqlCommand)
        {
            try
            {
                int result = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertIntoMedia(Media insertedMedia)
        {
            conn.Open();

            string insertMediaIntoDatabase = "INSERT INTO Media " +
                "VALUES(@mediaID, @mediaPath, @isFavorite)";

            var cmd = new SQLiteCommand(insertMediaIntoDatabase, conn);
            int isFavorited = insertedMedia.IsLiked == true ? 1 : 0;

            cmd.Parameters.AddWithValue("@mediaID", insertedMedia.Id);
            cmd.Parameters.AddWithValue("@mediaPath", insertedMedia.FilePath);
            cmd.Parameters.AddWithValue("@isFavorite", isFavorited);

            RunSqlCommand(cmd);

            conn.Close();
        }

        public void InsertIntoPlaylist(Playlist insertedPlaylist)
        {
            conn.Open();

            string insertPlaylistIntoDatabase = "INSERT INTO Playlist "
                + "VALUES(@playlistID, @playlistName, @imagePath, @dateOfCreation)";

            var cmd = new SQLiteCommand(insertPlaylistIntoDatabase, conn);
            cmd.Parameters.AddWithValue("@playlistID", insertedPlaylist.PlayListID);
            cmd.Parameters.AddWithValue("@playlistName", insertedPlaylist.PlayListName);
            cmd.Parameters.AddWithValue("@imagePath", "");
            cmd.Parameters.AddWithValue("@dateOfCreation", insertedPlaylist.DateCreated);

            RunSqlCommand(cmd);

            conn.Close();
        }

        public void InsertIntoMediaPlaylist(Media insertedMedia, Playlist insertedPlaylist)
        {
            conn.Open();

            string insertMediaPlaylistIntoDatabase = "INSERT INTO MediaPlaylist "
                + "VALUES(@playlistID, @mediaID)";

            var cmd = new SQLiteCommand(insertMediaPlaylistIntoDatabase, conn);
            cmd.Parameters.AddWithValue("@mediaID", insertedMedia.Id);
            cmd.Parameters.AddWithValue("@playlistID", insertedPlaylist.PlayListID);

            RunSqlCommand(cmd);

            conn.Close();
        }

        public void DeleteMediaFromDatabase(string mediaID)
        {
            conn.Open();

            string deleteMedia = "DELETE FROM Media " +
                "WHERE MediaID = @mediaID";
            var cmd = new SQLiteCommand(deleteMedia, conn);
            cmd.Parameters.AddWithValue("@mediaID", mediaID);

            RunSqlCommand(cmd);

            conn.Close();
        }

        public void DeletePlaylistFromDatabase(string playlistID)
        {
            conn.Open();

            string deleteMedia = "DELETE FROM Playlist " +
                "WHERE PlaylistID = @playlistID";
            var cmd = new SQLiteCommand(deleteMedia, conn);
            cmd.Parameters.AddWithValue("@mediaID", playlistID);

            RunSqlCommand(cmd);

            conn.Close();
        }

        public void DeleteMediaPlaylistFromDatabase(string mediaID)
        {
            conn.Open();

            string deleteMedia = "DELETE FROM MediaPlaylist " +
                "WHERE MediaID = @mediaID";
            var cmd = new SQLiteCommand(deleteMedia, conn);
            cmd.Parameters.AddWithValue("@mediaID", mediaID);

            RunSqlCommand(cmd);

            conn.Close();
        }

    }
}
