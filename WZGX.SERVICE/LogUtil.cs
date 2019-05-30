using System;
using System.Collections.Generic;
using System.Text;
using log4net;
using log4net.Config;
using log4net.Repository;
using System.IO;
namespace WZGX.SERVICE
{
  public  static class LogUtil
    {
        private static ILoggerRepository LoggerRepository;
        public static void Info(LogMd lg) {
            LoggerRepository = LogManager.CreateRepository("Log4netConsolePractice");
            XmlConfigurator.ConfigureAndWatch(LoggerRepository, new FileInfo("Log4Net.config"));
            var log = LogManager.GetLogger(LoggerRepository.Name, typeof(Program));
            //log4net日志
            //log4net.ILog logInfo = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            //log.InfoFormat("测试日志写入");
            log.Info(lg.Message);
            Console.WriteLine("hello");
            Console.ReadLine();
        }
    }
    public class LogMd {
        public string Message { get; set; }
    }
}
