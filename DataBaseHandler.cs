using System;
using System.Collections.Generic;
using Npgsql;



namespace MonitorPhotoApp
{
    class DataBaseHandler
    {
        private const string server = "Server = 62.116.255.129; ";
        private const string port = "Port = 5432; ";
        private const string dbName = "Database = monitor_photo_app; ";
        private const string dbUser = "User Id = monitor; ";
        private const string dbUsrPwd = "Password = erp;";

        public delegate void StatusUpdateHandler(object sender, ProgressEventArgs e);
        public event StatusUpdateHandler OnDatabasIsReady;

        private NpgsqlConnection conn;
        private NpgsqlDataReader dr;
        public List<PhotoInfo> PhotosInfoList { get; private set; }
        public DataBaseHandler()
        {
            this.PhotosInfoList = new List<PhotoInfo>();
            try
            {
                Log.AddToLog("Creating DB connection");
                conn = new NpgsqlConnection(server + port + dbName + dbUser + dbUsrPwd);
            }
            catch (Exception)
            {
                Log.AddToLog("PGSQL connection failed");
                throw;
            }
        }
        private void DBDataIsReady(PhotoAttribute attr)
        {
            // Make sure someone is listening to event
            if (OnDatabasIsReady == null) return;

            ProgressEventArgs args = new ProgressEventArgs(attr);
            // Broadcast to listeners
            OnDatabasIsReady(this, args);
        }
        public void ExtractDataFromDB(PhotoAttribute attr)
        {
       
                string query = "SELECT photo_id ,photo_url FROM photos";

                switch (attr)
                {
                    case PhotoAttribute.all:
                        query = "SELECT photo_id, photo_url, isFunny FROM photos";

                        break;
                    case PhotoAttribute.funny:
                        query = "SELECT photo_id, photo_url, isFunny FROM photos WHERE isfunny = true";

                        break;
                    case PhotoAttribute.notFunny:
                        query = "SELECT photo_id, photo_url, isFunny FROM photos WHERE isfunny = false";
                        break;
                    default:
                        break;
                }
            Log.AddToLog("Reading Database. Query " + query);

            try
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, conn);

                this.PhotosInfoList.Clear();

                // Get the reader
                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    this.PhotosInfoList.Add(new PhotoInfo(int.Parse(dr[0].ToString()), dr[1].ToString(), bool.Parse(dr[2].ToString())));
                }
                dr.Close();
            }
            catch (Exception)
            {
                Log.AddToLog("Error when connecting to database.");
                //dont throw;
            }
            finally
            {
                // Close connection
                if (conn != null)
                    conn.Close();
            }
            // Notify that the data from DB is ready to be processed
            DBDataIsReady(attr);
        }

        public void AlterDB(int photoId, bool isFunny)
        {
            // INSERT query to database to set value of isFunny (bool)
            string query = "UPDATE photos SET isFunny = " + isFunny.ToString().ToLower() + " WHERE photo_id = " + photoId.ToString();
            try
            {
                Log.AddToLog($"Altering databse. Query: {query}");
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, conn);
                dr = command.ExecuteReader();
                dr.Close();
            }
            catch (Exception)
            {
                // Just throw here for now..
                throw;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
    }
    public class ProgressEventArgs : EventArgs
    {
        public PhotoAttribute Attr { get; private set; }

        public ProgressEventArgs(PhotoAttribute attr)
        {
            Attr = attr;
        }
    }

    public class PhotoInfo
    {
        // Class to store downloaded photo properties
        public string URL { get; set; }
        public int ID { get; set; }

        public bool IsFunny { get; set; }
        public PhotoInfo(int ID, string URL, bool IsFunny) {
            this.URL = URL;
            this.ID = ID;
            this.IsFunny = IsFunny;
        }
    }
}
public enum PhotoAttribute
{
    all, funny, notFunny
}
