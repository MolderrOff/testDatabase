using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using for_video;
using System.Configuration;

namespace for_video //было namespace test_DataBase
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new log_in()); //было Application.Run(new Form1());


            //var connection = Configuration.GetConnectionString("DefaultConnection");
            //services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(connection));  //x было options
        }
    }
}
