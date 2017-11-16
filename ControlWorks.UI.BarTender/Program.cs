using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace ControlWorks.UI.BarTender
{
    static class Program
    {
        private static readonly ILog _log = LogManager.GetLogger("FileLogger");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {

                _log.Info($"CONTROL WORKS - Bartender Application Start {DateTime.Now: yyyy-MM-dd HH:mm:ss}");
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmMain());
            }
            catch(Exception ex)
            {

            }
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                var ex = e.ExceptionObject as Exception;

                if (ex != null)
                {
                    string errorMessage = $"Unhandled Exception at {DateTime.Now: yyyy-MM-dd HH:mm:ss}\r\nError: {ex.Message}\r\nRuntime Terminating: {e.IsTerminating}\r\n----- ----- ----- ----- ----- -----\r\n\r\n{ex.StackTrace.Trim()}";

                    var path = new System.IO.FileInfo(@"D:\ControlWorks\BarTender\ErrorLogs\ErrorLogs.log");
                    if (!System.IO.Directory.Exists(path.DirectoryName))
                    {
                        System.IO.Directory.CreateDirectory(path.DirectoryName);
                    }

                    System.IO.File.AppendAllText(path.FullName, errorMessage);
                }
            }
            catch(Exception ex)
            {
            }

        }
    }
}
