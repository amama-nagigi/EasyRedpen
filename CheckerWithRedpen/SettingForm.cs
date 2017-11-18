using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckerWithRedpen
{
    public partial class SettingForm : Form
    {
            public SettingForm()
        {
            InitializeComponent();
        }
  
        private void buttonRedpenBat_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog f = new OpenFileDialog())
            {
                f.Filter = "redpen.bat|redpen.bat";
                f.InitialDirectory = Path.GetDirectoryName(Settings.RedpenPath);
                f.FileName = Path.GetFileName(Settings.RedpenPath);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Settings.RedpenPath = f.FileName;
                }
            }
        }

        /// <summary>
        /// 設定保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
