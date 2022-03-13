using System.Data.SqlClient;
using System.Diagnostics;

namespace Asignement2_BRICE_DENIS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static string strConnexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ System.IO.Path.GetFullPath(@"..\..\..\")+"Hospital.mdf;Integrated Security=True";

        [STAThread]
        static void Main()
        {

            ///CONNEXION DB CODE
            try
            {
                SqlConnection Connection = new SqlConnection(strConnexion);
                Connection.Open();
                Debug.WriteLine("Connection is: " + Connection.State);
                Connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error : "+e.Message);
            }
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}