
namespace Torshia.Web
{
    using Microsoft.EntityFrameworkCore;
    using SIS.Framework;
    using Torshia.Data;

    public class Launcher
    {
        static Launcher()
        {
            using (var db = new TorshiaContext())
            {
                db.Database.Migrate();
            }
        }
        public static void Main(string[] args)
        {
            WebHost.Start(new StartUp());
        }
    }
}