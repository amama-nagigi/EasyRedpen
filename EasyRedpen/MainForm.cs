using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyRedpen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string path = Path.GetTempFileName();

            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
                {
                    sw.Write(this.textBoxSentence.Text);
                }

                ProcessStartInfo psInfo = new ProcessStartInfo();
                psInfo.WorkingDirectory = Path.GetDirectoryName(Settings.RedpenPath);
                psInfo.FileName = Settings.RedpenPath; // 実行するファイル
                psInfo.Arguments = "-L ja " + path ;
                psInfo.CreateNoWindow = true; // コンソール・ウィンドウを開かない
                psInfo.UseShellExecute = false; // シェル機能を使用しない
                psInfo.StandardOutputEncoding = Encoding.UTF8;
                psInfo.RedirectStandardOutput = true; // 標準出力をリダイレクト
                if (!psInfo.EnvironmentVariables.ContainsKey("JAVA_HOME"))
                {
                    psInfo.EnvironmentVariables.Add("JAVA_HOME", Settings.JavaHome);
                }

                Process p = Process.Start(psInfo); // アプリの実行開始
                string output = p.StandardOutput.ReadToEnd(); // 標準出力の読み取り
                p.WaitForExit();
                output = output.Replace(Path.GetFileName(path) + ":", "");
                output = output.Replace("\n", "\r\n");
                textBoxResult.Text = output;
            }
            finally
            {
                File.Delete(path);
            }
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            using(Form f = new SettingForm())
            {
                f.ShowDialog();
            }
        }
    }
}
