using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace GraphicEditor
{
    public partial class FormProgress : Form
    {
        FormMain mainForm;
        Bitmap  prevImg;

        //Конструктор (сразу запускается обработка асинхронной операции инверсии с помощью backgroundWorker )
        public FormProgress(Bitmap inn, FormMain mf)
        {
            InitializeComponent();

            prevImg = inn;
            mainForm = mf;

              if (!backgroundWorkerInvert.IsBusy)
              {
                  backgroundWorkerInvert.RunWorkerAsync();
              }
        }

        //Инверсия с отбражением прогресса выполнения
        private void backgroundWorkerInvert_DoWork(object sender, DoWorkEventArgs e)
        {
            int x;
            int y;
            ReaderWriterLock rw = new ReaderWriterLock();
            rw.AcquireReaderLock(10000);
            for (x = 0; x <= prevImg.Width - 1; x++)
                { 
                    if (backgroundWorkerInvert.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }
                  
                    if (!backgroundWorkerInvert.CancellationPending)
                    {
                        for (y = 0; y <= prevImg.Height - 1; y += 1)
                        {
                            Color oldColor = prevImg.GetPixel(x, y);
                            Color newColor;
                            newColor = Color.FromArgb(oldColor.A, 255 - oldColor.R, 255 - oldColor.G, 255 - oldColor.B);
                            prevImg.SetPixel(x, y, newColor);
                        }
                        backgroundWorkerInvert.ReportProgress(x / 13);
                    }
                }
                e.Result = prevImg;
            rw.ReleaseLock();
        }

        private void backgroundWorkerInvert_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarInvert.Value = e.ProgressPercentage;
            labelProcess.Text = string.Format("Processing...{0}", e.ProgressPercentage);
            progressBarInvert.Update(); 
        }

        private void backgroundWorkerInvert_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Process had been canceled.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                            
                MessageBox.Show("Process had been completed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.pictureBoxMain.Image = (Bitmap)e.Result;
            }
            Close();
        }

        //Обработка отмены инверсии
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerInvert.IsBusy && backgroundWorkerInvert.WorkerSupportsCancellation)
            {
                backgroundWorkerInvert.CancelAsync();
            }
            Close();
        }

    }

}
