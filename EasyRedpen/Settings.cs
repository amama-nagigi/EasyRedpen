using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyRedpen
{
    public static class Settings
    {
        public static string RedpenPath {
            get
            {
                return Properties.Settings.Default.RedpenPath;
            }
            set
            {
                Properties.Settings.Default.RedpenPath = value;
            }
        }

        public static string JavaHome
        {
            get
            {
                return Properties.Settings.Default.JavaHome;
            }
            set
            {
                Properties.Settings.Default.JavaHome = value;
            }
        }
    }
}
