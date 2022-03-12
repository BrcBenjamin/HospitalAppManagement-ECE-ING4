using System.Data.SqlClient;

namespace Asignement2_BRICE_DENIS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ///CONNEXION DB CODE
            string strConnexion = @"Data Source= (LocalDB)\MSSQLLocalDB; Initial Catalog = Hospital; Integrated Security = True";
            try
            {
                SqlConnection Connection = new SqlConnection(strConnexion);
                Connection.Open();
                Console.WriteLine("Connection is: " + Connection.State);
                Connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}