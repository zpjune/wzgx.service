
using System;
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;

namespace WZGX.SERVICE
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var pathToExe = Process.GetCurrentProcess().MainModule.FileName;
                var pathToContentRoot = Path.GetDirectoryName(pathToExe);
                Directory.SetCurrentDirectory(pathToContentRoot);

                
                ServiceBase[] services = new ServiceBase[] { new WzgxService() };
                ServiceBase.Run(services);
            }
            catch (Exception ex)
            {
                LogUtil.Info(new LogMd() { Message = "MAIN出错：" + ex.Message.ToString() });
            }
           
        }

    }
}
