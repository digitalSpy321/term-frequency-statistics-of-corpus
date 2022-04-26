using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace GlossaryStaticsAPP
{
    public static class PyRun
    {
        public static string scriptReturn = "";
        public static string gloText = "";
        public static bool gloFlag = false;
        //运行python脚本
        public static void RunPythonScript(string pyFilePath, string sArgName, 
            string args = "", params string[] teps)
        {
            Process p = new Process();
            string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + sArgName;
            p.StartInfo.FileName = pyFilePath;
            string sArguments = path;
            foreach (string sigstr in teps)
            {
                sArguments += " " + sigstr;//传递参数
            }

            sArguments += " " + args;

            p.StartInfo.Arguments = sArguments;

            p.StartInfo.UseShellExecute = false;

            p.StartInfo.RedirectStandardOutput = true;

            p.StartInfo.RedirectStandardInput = true;

            p.StartInfo.RedirectStandardError = true;

            p.StartInfo.CreateNoWindow = false;
            try
            {
                p.Start();
            }
            catch 
            {
                MessageBox.Show("当前python路径无效：\n" +
                    "请重新配置python路径或检查python运行环境是否包含pandas、openpyxl等模块",
                    "提示", MessageBoxButtons.OK);
            }
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();
            if (gloFlag)
            {
                gloText = "";
            }
            else
            {
                scriptReturn = "";
            }
            p.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
            p.WaitForExit();
            p.Close();
        }
        //委托事件
        static void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                if (gloFlag)
                {
                    gloText += e.Data + Environment.NewLine;
                }
                else
                {
                    scriptReturn += e.Data + Environment.NewLine;
                }

            }
        }

        //删除临时文件
        public static void DelectDir(string srcPath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(srcPath);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo)            //判断是否文件夹
                    {
                        DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                        subdir.Delete(true);          //删除子目录和文件
                    }
                    else
                    {
                        File.Delete(i.FullName);      //删除指定文件
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
