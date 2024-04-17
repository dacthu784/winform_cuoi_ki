using Quanlyquanan.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Quanlyquanan
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run();
            CreateDatabse();
        }
        public static void DeleteDatabse()
        {
            var dbcontext = new QlquanCafeContext();
            dbcontext.Database.EnsureDeleted();
        }

        public static void CreateDatabse()
        {
            var dbcontext = new QlquanCafeContext();
            dbcontext.Database.EnsureCreated();
        }



    }
}
