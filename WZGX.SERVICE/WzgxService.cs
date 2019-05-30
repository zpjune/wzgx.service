using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;

namespace WZGX.SERVICE
{
    partial class WzgxService : ServiceBase
    {
        public WzgxService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                LogUtil.Info(new LogMd() { Message = "服务启动" });
            }
            catch (Exception ex)
            {
                LogUtil.Info(new LogMd() { Message = "服务启动出错："+ex.Message.ToString() });
            }
            
        }

        protected override void OnStop()
        {
            try
            {
                LogUtil.Info(new LogMd() { Message = "服务停止" });
            }
            catch (Exception ex)
            {
                LogUtil.Info(new LogMd() { Message = "服务停止出错：" + ex.Message.ToString() });
            }
        }
    }
}
