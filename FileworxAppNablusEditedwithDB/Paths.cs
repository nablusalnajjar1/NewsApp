using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileworxApp
{
    internal class Paths
    {
        public string PhotoPath { get; set; } = Application.StartupPath+ @"\Photos\";
        public string NewsPath { get; set; } = Application.StartupPath + @"\News\";
        public string UsersPath { get; set; } = Application.StartupPath + @"\Users\";

    }
}
