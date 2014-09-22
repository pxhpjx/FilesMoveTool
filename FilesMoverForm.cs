using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace FileMoveTool
{
    public partial class FilesMoverForm : Form
    {
        bool ProcessFlag = false;
        Thread th = null;

        public FilesMoverForm()
        {
            InitializeComponent();
        }

        void AddMonText(string msg, bool isNeeedClearText = false)
        {
            BeginInvoke(new Action(() =>
                {
                    if (isNeeedClearText)
                        txtMon.Text = null;
                    txtMon.AppendText(string.Format("{0} {1}\r\n", DateTime.Now.ToString("HH:mm:ss"), msg));
                }));
        }

        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择源文件夹路径";
            if (dialog.ShowDialog() == DialogResult.OK)
                txtSource.Text = dialog.SelectedPath;
        }

        private void btnSelectTarget_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择目标文件夹路径";
            if (dialog.ShowDialog() == DialogResult.OK)
                txtTarget.Text = dialog.SelectedPath;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string msg = PathCheck();
            if (msg != null)
            {
                MessageBox.Show(msg);
                return;
            }
            plTop.Enabled = false;
            ProcessFlag = true;
            th = new Thread(() =>
            {
                while (ProcessFlag)
                {
                    MoveFiles(txtSource.Text, true);
                    Thread.Sleep(1000);
                }
            });
            th.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ProcessFlag = false;
            th.Abort();
            plTop.Enabled = true;
        }

        string PathCheck()
        {
            if (string.IsNullOrWhiteSpace(txtSource.Text) || string.IsNullOrWhiteSpace(txtTarget.Text))
                return "路径不能为空";
            if (!Directory.Exists(txtSource.Text) || !Directory.Exists(txtTarget.Text))
                return "路径不存在";
            txtSource.Text = txtSource.Text.TrimEnd('\\');
            txtTarget.Text = txtTarget.Text.TrimEnd('\\');
            if (txtTarget.Text == txtSource.Text || txtSource.Text.Contains(txtTarget.Text + '\\') || txtTarget.Text.Contains(txtSource.Text + '\\'))
                return "路径不允许嵌套";
            return null;
        }


        void MoveFiles(string path, bool isTopDir = false)
        {
            try
            {
                if (!Directory.Exists(path))
                    return;
                string[] dirs = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
                if (dirs != null && dirs.Length > 0)
                {
                    foreach (string dir in dirs)
                        MoveFiles(dir);
                }
                string[] files = Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly);
                if (files != null && files.Length > 0)
                {
                    foreach (string file in files)
                    {
                        string targetFile = file.Replace(txtSource.Text, txtTarget.Text);
                        if (File.Exists(targetFile))
                        {
                            if (chkOverwrite.Checked)
                                File.Delete(targetFile);
                            else
                                continue;
                        }
                        string targetDir = targetFile.Substring(0, targetFile.LastIndexOf('\\'));
                        if (!Directory.Exists(targetDir))
                            Directory.CreateDirectory(targetDir);
                        File.Move(file, targetFile);
                        AddMonText("已移动：" + file);
                    }
                }
                if (!isTopDir && chkClearDir.Checked)
                {
                    dirs = Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly);
                    files = Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly);
                    if ((dirs == null || dirs.Length == 0) && (files == null || files.Length == 0))
                    {
                        Directory.Delete(path);
                        AddMonText("已清除：" + path);
                    }
                }
            }
            catch (Exception ex)
            {
                AddMonText("移动过程出错：" + ex.Message);
            }
        }

    }
}
