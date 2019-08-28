using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace AudioConverterTestWinform
{
    public partial class MainForm : Form
    {
        private readonly ToolTip _toolTipAacPath;
        private readonly ToolTip _toolTipWavPath;

        public MainForm()
        {
            InitializeComponent();

            _toolTipAacPath = new ToolTip {ShowAlways = true};
            _toolTipWavPath = new ToolTip { ShowAlways = true };
        }

        private void buttonAacPath_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "AAC Files(*.aac)|*.aac|All files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxAacPath.Text = openFileDialog.FileName;
                _toolTipAacPath.SetToolTip(textBoxAacPath, textBoxAacPath.Text);

                textBoxWavPath.Text = textBoxAacPath.Text.Replace(".aac", ".wav");
                _toolTipWavPath.SetToolTip(textBoxWavPath, textBoxWavPath.Text);
            }
        }

        private void buttonWavPath_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "AAC Files(*.aac)|*.aac|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = textBoxWavPath.Text;

            if (string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            }
            else
            {
                try
                {
                    var index = saveFileDialog.FileName.LastIndexOf('\\');
                    var path = saveFileDialog.FileName.Substring(0, index);
                    if (Directory.Exists(path))
                    {
                        saveFileDialog.InitialDirectory = path;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
                }
            }

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxWavPath.Text = saveFileDialog.FileName;
                _toolTipWavPath.SetToolTip(textBoxWavPath, textBoxWavPath.Text);
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {

        }
    }
}
