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

        public Playlist QueryPlaylistGivenPlaylistID(string playlistID)
        {
            Playlist result = new Playlist();
            playlistDatabaseConnection.Open();
            string queryPlaylist = "SELECT PlaylistID, PlaylistName, PlaylistThumbnailPath, PlaylistDateOfCreation FROM Playlist " +
                "WHERE PlaylistID = @playlistID"; 
            var sqlCommand = new SQLiteCommand(queryPlaylist, playlistDatabaseConnection);
            var dataReader = sqlCommand.ExecuteReader();
            
            while (dataReader.Read())
            {
                List<Media> mediaInPlaylist = QueryAllMediaInGivenPlaylist(playlistID);
                result = new Playlist(dataReader["PlaylistID"].ToString(), dataReader["PlaylistName"].ToString(),
                    dataReader["PlaylistThumbnailPath"].ToString(), mediaInPlaylist);
                break;
            }
            playlistDatabaseConnection.Close();
            return result;
        }
        public List <Playlist> QueryAllPlaylists()
        {
            playlistDatabaseConnection.Open();
            List<Playlist> playlistsInDatabase = new List<Playlist>();
            List<Media> mediaInPlaylist = new List<Media>();

            string queryPlaylists = "SELECT PlaylistID, PlaylistName, PlaylistThumbnailPath, PlaylistDateOfCreation FROM Playlist";
            var sqlCommand = new SQLiteCommand(queryPlaylists, playlistDatabaseConnection);
            var dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                
                Playlist playlist;
                try
                {
                    mediaInPlaylist = QueryAllMediaInGivenPlaylist(dataReader["PlaylistID"].ToString());
                    playlist = new Playlist(dataReader["PlaylistID"].ToString(), dataReader["PlaylistName"].ToString(),
                    dataReader["PlaylistThumbnailPath"].ToString(), mediaInPlaylist);
                    playlistsInDatabase.Add(playlist);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            playlistDatabaseConnection.Close();
            return playlistsInDatabase;
        }

        public List<Media> QueryAllMediaInGivenPlaylist(string playlistID)
        {
            List<Media> mediasInPlaylist = new List<Media>();

            string queryMedia = "SELECT MediaPath FROM PlaylistMedias WHERE PlaylistID = @playlistID";
            var sqlCommand = new SQLiteCommand(queryMedia, playlistDatabaseConnection);
            sqlCommand.Parameters.AddWithValue("@playlistID", playlistID);
            SQLiteDataReader dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                Media addMedia = new Media(dataReader["MediaPath"].ToString());
                mediasInPlaylist.Add(addMedia);
            }
            return mediasInPlaylist;
        }
        public void DeletePlaylist(string playlistID)
        {
            DeleteMediasInGivenPlaylist(playlistID);
            playlistDatabaseConnection.Open();

            string deleteQuery = "DELETE FROM Playlist " +
                "WHERE PlaylistID = @playlistID";
            var sqlCommand = new SQLiteCommand(deleteQuery, playlistDatabaseConnection);
            sqlCommand.Parameters.AddWithValue("@playlistID", playlistID);
            RunSqlCommand(sqlCommand);

            playlistDatabaseConnection.Close();
        }
        public void DeleteMediasInGivenPlaylist(string playlistID)
        {
            if (playlistDatabaseConnection.State == System.Data.ConnectionState.Closed)
            {
                playlistDatabaseConnection.Open();
            }

            string deleteQuery = "DELETE FROM PlaylistMedias " +
                "WHERE PlaylistID = @playlistID ";
            var sqlCommand = new SQLiteCommand(deleteQuery, playlistDatabaseConnection);
            sqlCommand.Parameters.AddWithValue("@playlistID", playlistID);
            RunSqlCommand(sqlCommand);

            playlistDatabaseConnection.Close();
        }
        public void DeleteMediasGivenPath(string mediaPath)
        {
            if (playlistDatabaseConnection.State == System.Data.ConnectionState.Closed)
            {
                playlistDatabaseConnection.Open();
            }

            string deleteQuery = "DELETE FROM PlaylistMedias " +
                "WHERE MediaPath = @mediaPath";
            var sqlCommand = new SQLiteCommand(deleteQuery, playlistDatabaseConnection);
            sqlCommand.Parameters.AddWithValue("@mediaPath", mediaPath);
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