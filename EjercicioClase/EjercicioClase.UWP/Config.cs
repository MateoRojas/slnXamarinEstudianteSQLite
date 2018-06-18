using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Interop;
using SQLite.Net.Platform.WinRT;

namespace EjercicioClase.UWP
{
    public class Config : IConfig
    {


        private string directorioDB;
        private ISQLitePlatform plataforma;

        public string DirectorioDB
        {

            get
            {
                if (string.IsNullOrEmpty(directorioDB))
                    directorioDB = Windows.Storage.ApplicationData.Current.LocalFolder.Path;
                return directorioDB;
            }
        }

        public ISQLitePlatform Plataforma
        {
            get
            {
                if (plataforma == null)
                    plataforma = new SQLitePlatformWinRT();

                return plataforma;
            }

        }
    }
}
