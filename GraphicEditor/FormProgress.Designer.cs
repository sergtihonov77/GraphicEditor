namespace GraphicEditor
{
    partial class FormProgress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelProcess = new System.Windows.Forms.Label();
            this.progressBarInvert = new System.Windows.Forms.ProgressBar();
            this.backgroundWorkerInvert = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCancel.Location = new System.Drawing.Point(126, 67);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcess.Location = new System.Drawing.Point(107, 9);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(127, 15);
            this.labelProcess.TabIndex = 1;
            this.labelProcess.Text = "Processing invert...0%";
            // 
            // progressBarInvert
            // 
            this.progressBarInvert.Location = new System.Drawing.Point(12, 38);
            this.progressBarInvert.Name = "progressBarInvert";
            this.progressBarInvert.Size = new System.Drawing.Size(313, 23);
            this.progressBarInvert.TabIndex = 2;
            // 
            // backgroundWorkerInvert
            // 
            this.backgroundWorkerInvert.WorkerReportsProgress = true;
            this.backgroundWorkerInvert.WorkerSupportsCancellation = true;
            this.backgroundWorkerInvert.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerInvert_DoWork);
            this.backgroundWorkerInvert.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerInvert_ProgressChanged);
            this.backgroundWorkerInvert.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerInvert_RunWorkerCompleted);
            // 
            // FormProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 102);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarInvert);
            this.Controls.Add(this.labelProcess);
            this.Controls.Add(this.buttonCancel);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProgress";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProgress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.ProgressBar progressBarInvert;
        private System.ComponentModel.BackgroundWorker backgroundWorkerInvert;
    }
}