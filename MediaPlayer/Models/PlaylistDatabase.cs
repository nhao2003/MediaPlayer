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
    internal class PlaylistDatabase
    {
        static string playlistDatabaseFilePath = "Data Source=" + Environment.CurrentDirectory + "\\Playlist.db";
        static SQLiteConnection playlistDatabaseConnection = new SQLiteConnection(playlistDatabaseFilePath);

        public void InitializeTables()
        {
            string createPlaylistTable = "CREATE TABLE IF NOT EXISTS Playlist(" +
                "PlaylistID VARCHAR(4000) PRIMARY KEY NOT NULL," +
                "PlaylistName VARCHAR(4000) NOT NULL," +
                "PlaylistThumbnailPath VARCHAR(4000)," +
                "PlaylistDateOfCreation SMALLDATETIME " +
                ")";
            try
            {
                CreateTable(createPlaylistTable);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Creating Playlist Table");
            }

            string createPlaylistMediasTable = "CREATE TABLE IF NOT EXISTS PlaylistMedias(" +
                "MediaPath VARCHAR(4000) PRIMARY KEY NOT NULL," +
                "PlaylistID VARCHAR(4000)," +
                "FOREIGN KEY (PlaylistID) REFERENCES Playlist(PlaylistID)" +
                ")";
            try
            {
                CreateTable(createPlaylistMediasTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Creating PlaylistMedias Table");
            }
        }


        public void CreateTable(string tableCreationString)
        {
            playlistDatabaseConnection.Open();

            var sqlCommand = new SQLiteCommand(tableCreationString, playlistDatabaseConnection);
            RunSqlCommand(sqlCommand);

            playlistDatabaseConnection.Close();
        }

        private void RunSqlCommand(SQLiteCommand sqlCommand)
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

        public void InsertPlaylist(Playlist insertPlaylist)
        {
            playlistDatabaseConnection.Open();

            string insertQuery = "INSERT INTO Playlist "
                + "VALUES(@playlistID, @playlistName, @playlistThumbnailPath, @playlistDateOfCreation)";
            SQLiteCommand sqlCommand = new SQLiteCommand(insertQuery, playlistDatabaseConnection);

            AddValueIntoPlaylistinSQLCommand(insertPlaylist, sqlCommand);
            RunSqlCommand(sqlCommand);

            playlistDatabaseConnection.Close();
        }

        public void InsertMediaIntoPlaylistMedias(Playlist playlistContainsMedia, Media insertMedia)
        {
            playlistDatabaseConnection.Open();

            string insertQuery = "INSERT INTO PlaylistMedias "
                + "VALUES(@mediaPath, @playlistID)";
            SQLiteCommand sqlCommand = new SQLiteCommand(insertQuery, playlistDatabaseConnection);

            AddValueIntoPlaylistMediasinSQLCommand(playlistContainsMedia, insertMedia, sqlCommand);
            RunSqlCommand(sqlCommand);

            playlistDatabaseConnection.Close();
        }

        public void UpdatePlaylist(Playlist updatePlaylist)
        {
            playlistDatabaseConnection.Open();

            string updateQuery = "UPDATE Playlist\n"
                + "SET PlaylistName = @playlistName, PlaylistThumbnailPath = @playlistThumbnailPath, "
                + "PlaylistDateOfCreation = @playlistDateOfCreation\n"
                + "WHERE PlaylistID = @playlistID";
            SQLiteCommand sqlCommand = new SQLiteCommand(updateQuery, playlistDatabaseConnection);
            
            AddValueIntoPlaylistinSQLCommand(updatePlaylist, sqlCommand);
            RunSqlCommand(sqlCommand);

            playlistDatabaseConnection.Close();
        }
        public void UpdateMedia(Playlist playlistContainsMedia, Media updateMedia)
        {
            playlistDatabaseConnection.Open();

            string updateQuery = "UPDATE PlaylistMedias\n"
                + "SET PlaylistID = @playlistID\n"
                + "WHERE MediaPath = @mediaPath";
            SQLiteCommand sqlCommand = new SQLiteCommand(updateQuery, playlistDatabaseConnection);

            AddValueIntoPlaylistMediasinSQLCommand(playlistContainsMedia, updateMedia, sqlCommand);
            RunSqlCommand(sqlCommand);

            playlistDatabaseConnection.Close();
        }
        private void AddValueIntoPlaylistMediasinSQLCommand(Playlist playlistContainsMedia, Media insertMedia, SQLiteCommand sqlCommand)
        {
            sqlCommand.Parameters.AddWithValue("@mediaPath", insertMedia.FilePath);
            sqlCommand.Parameters.AddWithValue("@playlistID", playlistContainsMedia.PlayListID);
        }

        private void AddValueIntoPlaylistinSQLCommand(Playlist insertPlaylist, SQLiteCommand sqlCommand)
        {
            sqlCommand.Parameters.AddWithValue("@playlistID", insertPlaylist.PlayListID);
            sqlCommand.Parameters.AddWithValue("@playlistName", insertPlaylist.PlayListName);
            sqlCommand.Parameters.AddWithValue("@playlistThumbnailPath", insertPlaylist.BackroundImageFileName);
            sqlCommand.Parameters.AddWithValue("@playlistDateOfCreation", insertPlaylist.DateCreated);
        }
    }
}