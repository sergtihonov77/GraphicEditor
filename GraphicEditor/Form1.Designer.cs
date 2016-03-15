namespace GraphicEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.toolStripLeftBar = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEraser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBackColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelBrushSize = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxBrushSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelFont = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelFontSize = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonOpenF = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolStripButtonInvers = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.toolStripLeftBar.SuspendLayout();
            this.toolStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pictureBoxMain);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1164, 580);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.toolStripLeftBar);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1244, 605);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripTop);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.White;
            this.pictureBoxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMain.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(1164, 580);
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseDown);
            this.pictureBoxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseMove);
            this.pictureBoxMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseUp);
            // 
            // toolStripLeftBar
            // 
            this.toolStripLeftBar.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripLeftBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPen,
            this.toolStripButtonLine,
            this.toolStripButtonEraser,
            this.toolStripSeparator2,
            this.toolStripButtonRect,
            this.toolStripButtonEllipse});
            this.toolStripLeftBar.Location = new System.Drawing.Point(0, 3);
            this.toolStripLeftBar.Name = "toolStripLeftBar";
            this.toolStripLeftBar.Size = new System.Drawing.Size(80, 132);
            this.toolStripLeftBar.TabIndex = 0;
            // 
            // toolStripButtonPen
            // 
            this.toolStripButtonPen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPen.Image")));
            this.toolStripButtonPen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPen.Name = "toolStripButtonPen";
            this.toolStripButtonPen.Size = new System.Drawing.Size(78, 20);
            this.toolStripButtonPen.Text = "Pen";
            this.toolStripButtonPen.Click += new System.EventHandler(this.toolStripButtonPen_Click);
            // 
            // toolStripButtonLine
            // 
            this.toolStripButtonLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLine.Image")));
            this.toolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLine.Name = "toolStripButtonLine";
            this.toolStripButtonLine.Size = new System.Drawing.Size(78, 20);
            this.toolStripButtonLine.Text = "Line";
            this.toolStripButtonLine.Click += new System.EventHandler(this.toolStripButtonLine_Click);
            // 
            // toolStripButtonEraser
            // 
            this.toolStripButtonEraser.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEraser.Image")));
            this.toolStripButtonEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEraser.Name = "toolStripButtonEraser";
            this.toolStripButtonEraser.Size = new System.Drawing.Size(78, 20);
            this.toolStripButtonEraser.Text = "Eraser";
            this.toolStripButtonEraser.ToolTipText = "Eraser";
            this.toolStripButtonEraser.Click += new System.EventHandler(this.toolStripButtonEraser_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(78, 6);
            // 
            // toolStripButtonRect
            // 
            this.toolStripButtonRect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRect.Image")));
            this.toolStripButtonRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRect.Name = "toolStripButtonRect";
            this.toolStripButtonRect.Size = new System.Drawing.Size(78, 20);
            this.toolStripButtonRect.Text = "Rectangle";
            this.toolStripButtonRect.Click += new System.EventHandler(this.toolStripButtonRect_Click);
            // 
            // toolStripButtonEllipse
            // 
            this.toolStripButtonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEllipse.Image")));
            this.toolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEllipse.Name = "toolStripButtonEllipse";
            this.toolStripButtonEllipse.Size = new System.Drawing.Size(78, 20);
            this.toolStripButtonEllipse.Text = "Ellipse";
            this.toolStripButtonEllipse.Click += new System.EventHandler(this.toolStripButtonEllipse_Click);
            // 
            // toolStripTop
            // 
            this.toolStripTop.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonColor,
            this.toolStripButtonBackColor,
            this.toolStripSeparator3,
            this.toolStripLabelBrushSize,
            this.toolStripComboBoxBrushSize,
            this.toolStripSeparator4,
            this.toolStripLabelFont,
            this.toolStripComboBoxFont,
            this.toolStripSeparator5,
            this.toolStripLabelFontSize,
            this.toolStripComboBoxFontSize,
            this.toolStripButtonOpenF,
            this.toolStripButtonSave,
            this.toolStripButtonClear,
            this.toolStripButtonInvers});
            this.toolStripTop.Location = new System.Drawing.Point(3, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(959, 25);
            this.toolStripTop.TabIndex = 1;
            // 
            // toolStripButtonColor
            // 
            this.toolStripButtonColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButtonColor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonColor.Image")));
            this.toolStripButtonColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColor.Name = "toolStripButtonColor";
            this.toolStripButtonColor.Size = new System.Drawing.Size(56, 22);
            this.toolStripButtonColor.Text = "Color";
            this.toolStripButtonColor.Click += new System.EventHandler(this.toolStripButtonColor_Click);
            // 
            // toolStripButtonBackColor
            // 
            this.toolStripButtonBackColor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBackColor.Image")));
            this.toolStripButtonBackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBackColor.Name = "toolStripButtonBackColor";
            this.toolStripButtonBackColor.Size = new System.Drawing.Size(186, 22);
            this.toolStripButtonBackColor.Text = "Back Color (Ellipse, Rectangle)";
            this.toolStripButtonBackColor.Click += new System.EventHandler(this.toolStripButtonBackColor_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelBrushSize
            // 
            this.toolStripLabelBrushSize.Name = "toolStripLabelBrushSize";
            this.toolStripLabelBrushSize.Size = new System.Drawing.Size(60, 22);
            this.toolStripLabelBrushSize.Text = "Brush Size";
            // 
            // toolStripComboBoxBrushSize
            // 
            this.toolStripComboBoxBrushSize.Items.AddRange(new object[] {
            "2",
            "3",
            "5",
            "8",
            "10",
            "12",
            "15",
            "20",
            "25",
            "32",
            "50",
            "75",
            "100"});
            this.toolStripComboBoxBrushSize.Name = "toolStripComboBoxBrushSize";
            this.toolStripComboBoxBrushSize.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelFont
            // 
            this.toolStripLabelFont.Name = "toolStripLabelFont";
            this.toolStripLabelFont.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabelFont.Text = "Font";
            // 
            // toolStripComboBoxFont
            // 
            this.toolStripComboBoxFont.Name = "toolStripComboBoxFont";
            this.toolStripComboBoxFont.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelFontSize
            // 
            this.toolStripLabelFontSize.Name = "toolStripLabelFontSize";
            this.toolStripLabelFontSize.Size = new System.Drawing.Size(54, 22);
            this.toolStripLabelFontSize.Text = "Font Size";
            // 
            // toolStripComboBoxFontSize
            // 
            this.toolStripComboBoxFontSize.Name = "toolStripComboBoxFontSize";
            this.toolStripComboBoxFontSize.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripButtonOpenF
            // 
            this.toolStripButtonOpenF.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenF.Image")));
            this.toolStripButtonOpenF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenF.Name = "toolStripButtonOpenF";
            this.toolStripButtonOpenF.Size = new System.Drawing.Size(56, 22);
            this.toolStripButtonOpenF.Text = "Open";
            this.toolStripButtonOpenF.ToolTipText = "Open File";
            this.toolStripButtonOpenF.Click += new System.EventHandler(this.toolStripButtonOpenF_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.ToolTipText = "Save";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClear.Image")));
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(54, 22);
            this.toolStripButtonClear.Text = "Clear";
            this.toolStripButtonClear.ToolTipText = "Clear";
            this.toolStripButtonClear.Click += new System.EventHandler(this.toolStripButtonClear_Click);
            // 
            // toolStripButtonInvers
            // 
            this.toolStripButtonInvers.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInvers.Image")));
            this.toolStripButtonInvers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInvers.Name = "toolStripButtonInvers";
            this.toolStripButtonInvers.Size = new System.Drawing.Size(58, 22);
            this.toolStripButtonInvers.Text = "Invers";
            this.toolStripButtonInvers.Click += new System.EventHandler(this.toolStripButtonInvers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 605);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Graphic Editor v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.toolStripLeftBar.ResumeLayout(false);
            this.toolStripLeftBar.PerformLayout();
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStripLeftBar;
        private System.Windows.Forms.ToolStripButton toolStripButtonPen;
        private System.Windows.Forms.ToolStripButton toolStripButtonRect;
        private System.Windows.Forms.ToolStripButton toolStripButtonEllipse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonLine;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxFontSize;
        private System.Windows.Forms.ToolStripLabel toolStripLabelBrushSize;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxBrushSize;
        private System.Windows.Forms.ToolStripLabel toolStripLabelFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel toolStripLabelFontSize;
        private System.Windows.Forms.ToolStripButton toolStripButtonColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonEraser;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenF;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
        private System.Windows.Forms.ToolStripButton toolStripButtonBackColor;
        private System.Windows.Forms.ToolStripButton toolStripButtonInvers;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

