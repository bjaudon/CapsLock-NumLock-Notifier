using System;
using System.Windows.Forms;
using System.Threading;

namespace CapsLock_NumLock_Notifier
{
    internal static class Program
    {
        // Use Mutex to ensure only one copy of the software is running at a time.
        static readonly Mutex mutex = new Mutex(true, "{00bdb911-f52e-47f6-9aa6-3d0457cf19a2}");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
        }
    }
}
