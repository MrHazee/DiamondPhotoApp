using System;
using System.Collections.Generic;
using Npgsql;



namespace MonitorPhotoApp
{
    class MyDataBaseClass
    {
        private string server = "Server = 62.116.255.129; ";
        private string port = "Port = 5432; ";
        private string dbName = "Database = monitor_photo_app; ";
        private string dbUser = "User Id = monitor; ";
        private string dbUsrPwd = "Password = erp;";

        public delegate void StatusUpdateHandler(object sender, ProgressEventArgs e);
        public event StatusUpdateHandler OnUpdateStatus;

        private NpgsqlConnection conn;
        private NpgsqlDataReader dr;
        
        public List<PhotoInfo> PhotosInfoList { get; private set; }
        
        public MyDataBaseClass()
        {
            this.PhotosInfoList = new List<PhotoInfo>();
        }

        private void DBDataIsReady(PhotoAttribute attr)
        {
            // Make sure someone is listening to event
            if (OnUpdateStatus == null) return;

            ProgressEventArgs args = new ProgressEventArgs(attr);
            OnUpdateStatus(this, args);
        }
        
        public void connectToDB()
        {
            try
            {
                conn = new NpgsqlConnection(server + port + dbName + dbUser + dbUsrPwd);
                
                Console.WriteLine("PGSQL conn succesfull");

                //getURLsFromDB(PhotoAttributes.all);
                extractDataFromDB(PhotoAttribute.all);
                DBDataIsReady(PhotoAttribute.all);
                
            }
            catch (Exception)
            {
                Console.WriteLine("PGSQL Failed");
                throw;
            }

        }


        public void extractDataFromDB(PhotoAttribute attr)
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

            try
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, conn);

                this.PhotosInfoList.Clear();

                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    this.PhotosInfoList.Add(new PhotoInfo(int.Parse(dr[0].ToString()), dr[1].ToString(), bool.Parse(dr[2].ToString())));
                }
                dr.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Could not connect to DB");
                //dont throw;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            DBDataIsReady(attr);

        }

        public void AlterDB(int photoId, bool isFunny)
        {
            string query = "UPDATE photos SET isFunny = " + isFunny.ToString().ToLower() + " WHERE photo_id = " + photoId.ToString();
            try
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, conn);
                dr = command.ExecuteReader();
                dr.Close();
            }
            catch (Exception)
            {

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
