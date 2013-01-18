using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;

namespace BrowserLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                string path = args[0];
                string folder = System.IO.Path.GetDirectoryName(path);
                while (folder != null){
                    string config_file = folder + "\\"+".webroot";
                    if (System.IO.File.Exists(config_file)){
                        string server_path = System.IO.File.ReadAllText(config_file).Trim();
                        string http_path = path.Replace(folder, server_path);
                        Process.Start(http_path);
                        break;
                    }

                    System.IO.DirectoryInfo info = System.IO.Directory.GetParent(folder);
                    if (info != null)
                        folder = info.FullName;
                    else
                        folder = null;
                }
            }
        }


    }
}
