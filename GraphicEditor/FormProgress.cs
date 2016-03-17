using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicEditor
{
    public partial class FormProgress : Form
    {
        Form1 mainForm;
        Bitmap inv, pre;

        public FormProgress(Bitmap inn)
        {
            pre = inn;
            InitializeComponent();

            if (!backgroundWorkerInvert.IsBusy)
            {
                backgroundWorkerInvert.RunWorkerAsync();
            }
        }


        private void backgroundWorkerInvert_DoWork(object sender, DoWorkEventArgs e)
        {
            int process = 100;
            int index = 1;
            try
            {
                for (int i = 0; i < process; i++)
                {
                    if (!backgroundWorkerInvert.CancellationPending)
                    {
                        backgroundWorkerInvert.ReportProgress(index++ * 100 / process, string.Format("Process data {0}", i));
                        //Thread.Sleep(300);
                        inv = Invert(pre);

                    }
                }
                
            }
            catch (Exception ex)
            {
                backgroundWorkerInvert.CancelAsync();
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void backgroundWorkerInvert_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarInvert.Value = e.ProgressPercentage;
            labelProcess.Text = string.Format("Processing...{0}", e.ProgressPercentage);
            progressBarInvert.Update(); 
        }

        private void backgroundWorkerInvert_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Process had been completed.","Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1 f1 = new Form1();
            f1.bmp = inv;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerInvert.IsBusy)
            {
                backgroundWorkerInvert.CancelAsync();
            }
            this.Close();
        }

        public Bitmap Invert(Bitmap bitmap)
        {
            int x;
            int y;
            for (x = 0; x <= bitmap.Width - 1; x++)
            {
                for (y = 0; y <= bitmap.Height - 1; y += 1)
                {
                    Color oldColor = bitmap.GetPixel(x, y);
                    Color newColor;
                    newColor = Color.FromArgb(oldColor.A, 255 - oldColor.R, 255 - oldColor.G, 255 - oldColor.B);
                    bitmap.SetPixel(x, y, newColor);
                }
            }
            return bitmap;
        }
    }
}
