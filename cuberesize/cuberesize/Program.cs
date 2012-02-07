using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace cuberesize
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var proc = Process.GetCurrentProcess();
            if (Process.GetProcessesByName(proc.ProcessName).Length > 1)
            {
                // TODO: 現状は，引数が指定されている場合はその引数は無視している．
                // 既に起動しているプロセスに引数を渡し，変換を実行するように修正する．
                FindPrevProcess(proc);
                return;
            }

            // アイコンに変換したい画像ファイルをドラッグ&ドロップされた場合は，
            // 変換処理のみ実行し，メインウィンドウは表示しない．
            if (args.Length > 0)
            {
                try
                {
                    var form = new MainForm();
                    foreach (string path in args)
                    {
                        if ((File.GetAttributes(path) & FileAttributes.Directory) == FileAttributes.Directory)
                            form.ProcessDirectory(path);
                        else
                            form.ProcessImage(path);
                    }
                }
                catch (OperationCanceledException)
                {
                    // Nothing to do
                }
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }

        /* ----------------------------------------------------------------- */
        ///
        /// FindPrevProcess
        ///
        /// <summary>
        /// 指定されたプロセスと同名のプログラムが既に実行されている場合，
        /// 既に実行されているプロセスのウィンドウをアクティブにし，
        /// そのプロセスのウィンドウへのハンドルを返す．
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        private static IntPtr FindPrevProcess(Process proc)
        {
            Process[] processes = Process.GetProcessesByName(proc.ProcessName);
            int iThisProcessId = proc.Id;

            foreach (Process item in processes)
            {
                if (item.Id != iThisProcessId)
                {
                    if (IsIconic(item.MainWindowHandle)) ShowWindow(item.MainWindowHandle, SW_RESTORE);
                    SetForegroundWindow(item.MainWindowHandle);
                    return item.MainWindowHandle;
                }
            }
            return IntPtr.Zero;
        }

        /* ----------------------------------------------------------------- */
        /// Win32 API 関連の宣言
        /* ----------------------------------------------------------------- */
        #region Win32 APIs

        [DllImport("User32.dll")]
        private static extern int ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);

        private const int SW_RESTORE = 9;

        #endregion
    }

}
