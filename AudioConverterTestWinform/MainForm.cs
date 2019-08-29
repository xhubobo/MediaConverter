using System;
using System.IO;
using System.Windows.Forms;

namespace AudioConverterTestWinform
{
    public partial class MainForm : Form
    {
        private readonly ToolTip _toolTipAacPath1;
        private readonly ToolTip _toolTipAacPath2;
        private readonly ToolTip _toolTipWavPath1;
        private readonly ToolTip _toolTipWavPath2;

        public MainForm()
        {
            InitializeComponent();

            _toolTipAacPath1 = new ToolTip {ShowAlways = true};
            _toolTipAacPath2 = new ToolTip { ShowAlways = true };
            _toolTipWavPath1 = new ToolTip { ShowAlways = true };
            _toolTipWavPath2 = new ToolTip { ShowAlways = true };

            textBoxAacPath1.Text = @"E:\Music\程小小 - 瞬间.mp3";
            textBoxAacPath2.Text = @"E:\Music\程小小 - 瞬间.aac";
            textBoxWavPath1.Text = @"E:\Music\程小小 - 瞬间.aac";
            textBoxWavPath2.Text = @"E:\Music\程小小 - 瞬间.wav";
        }

        #region AAC
        private void SelectAacPath1()
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "MP3 Files(*.mp3)|*.mp3|All files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxAacPath1.Text = openFileDialog.FileName;
                _toolTipAacPath1.SetToolTip(textBoxAacPath1, textBoxAacPath1.Text);

                try
                {
                    var index = textBoxAacPath1.Text.LastIndexOf('.');
                    textBoxAacPath2.Text = textBoxAacPath1.Text.Substring(0, index) + ".aac";
                    _toolTipAacPath2.SetToolTip(textBoxAacPath2, textBoxAacPath2.Text);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }
        }

        private void SelectAacPath2()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "AAC Files(*.aac)|*.aac|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = textBoxAacPath2.Text;

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
                textBoxAacPath2.Text = saveFileDialog.FileName;
                _toolTipAacPath2.SetToolTip(textBoxAacPath2, textBoxAacPath2.Text);
            }
        }

        private void Convert2Aac()
        {
            if (string.IsNullOrEmpty(textBoxAacPath1.Text)
                || string.IsNullOrEmpty(textBoxAacPath2.Text))
            {
                MessageBox.Show("文件路径无效");
                return;
            }

            var ret = AudioConverterWrapperX64.TransAudioToAac(textBoxAacPath1.Text, textBoxAacPath2.Text);
            MessageBox.Show($"TransAudioToAac result: {ret}");
        }
        #endregion

        #region WAV
        private void SelectWavPath1()
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "AAC Files(*.aac)|*.aac|All files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxWavPath1.Text = openFileDialog.FileName;
                _toolTipWavPath1.SetToolTip(textBoxWavPath1, textBoxWavPath1.Text);

                try
                {
                    var index = textBoxWavPath1.Text.LastIndexOf('.');
                    textBoxWavPath2.Text = textBoxWavPath1.Text.Substring(0, index) + ".wav";
                    _toolTipWavPath2.SetToolTip(textBoxWavPath2, textBoxWavPath2.Text);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }
        }

        private void SelectWavPath2()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "WAV Files(*.wav)|*.wav|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = textBoxWavPath2.Text;

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
                textBoxWavPath2.Text = saveFileDialog.FileName;
                _toolTipWavPath2.SetToolTip(textBoxWavPath2, textBoxWavPath2.Text);
            }
        }

        private void Convert2Wav()
        {
            if (string.IsNullOrEmpty(textBoxWavPath1.Text)
                || string.IsNullOrEmpty(textBoxWavPath2.Text))
            {
                MessageBox.Show("文件路径无效");
                return;
            }

            try
            {
                var ret = AudioConverterWrapperX64.TransAacToWav(textBoxWavPath1.Text, textBoxWavPath2.Text);
                MessageBox.Show($"TransAacToWav result: {ret}");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        private void buttonAac1_Click(object sender, EventArgs e)
        {
            SelectAacPath1();
        }

        private void buttonAac2_Click(object sender, EventArgs e)
        {
            SelectAacPath2();
        }

        private void buttonConvertAac_Click(object sender, EventArgs e)
        {
            Convert2Aac();
        }

        private void buttonWav1_Click(object sender, EventArgs e)
        {
            SelectWavPath1();
        }

        private void buttonWav2_Click(object sender, EventArgs e)
        {
            SelectWavPath2();
        }

        private void buttonConvertWav_Click(object sender, EventArgs e)
        {
            Convert2Wav();
        }
    }
}
