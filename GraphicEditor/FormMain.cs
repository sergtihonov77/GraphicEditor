using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Threading;

namespace GraphicEditor
{
    public partial class FormMain : Form
    {
        Color color = Color.Black;
        Color colorBack = Color.White;
        bool draw = false;
        int x, y, lx, ly = 0;
        ToolItems currItem;
        Int32 solidSize = 3;
        public Bitmap workingPict;        

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxMain.Image = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
        }

        //Перечисление набора инструментов
        public enum ToolItems
        {
            Line, Ellipse, Rectangle, Fill, Pen, Eraser
        }

        //Обработчики кнопок инструментов
        private void toolStripButtonPen_Click(object sender, EventArgs e)
        {
            currItem = ToolItems.Pen;
        }

        private void toolStripButtonLine_Click(object sender, EventArgs e)
        {
            currItem = ToolItems.Line;
        }

        private void toolStripButtonRect_Click(object sender, EventArgs e)
        {
            currItem = ToolItems.Rectangle;
        }

        private void toolStripButtonEllipse_Click(object sender, EventArgs e)
        {
            currItem = ToolItems.Ellipse;
        }

        private void toolStripButtonEraser_Click(object sender, EventArgs e)
        {
            currItem = ToolItems.Eraser;
        }

        //Рисование, 3 метода 
        private void pictureBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
           draw = true;
            x = e.X;
            y = e.Y;
        }

        private void pictureBoxMain_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
            lx = e.X;
            ly = e.Y;
            if(draw == false)
            {
                workingPict = new Bitmap(pictureBoxMain.Image);
                using (Graphics g = Graphics.FromImage(workingPict))
                {
                    switch (currItem)
                    {
                        case ToolItems.Rectangle:
                            Rectangle rec = new Rectangle(x, y, e.X - x, e.Y - y);
                            g.DrawRectangle(new Pen(color, solidSize), rec);
                            g.FillRectangle(new SolidBrush(colorBack), rec);
                            break;
                        case ToolItems.Ellipse:
                            Rectangle r = new Rectangle(x, y, e.X - x, e.Y - y);
                            g.DrawEllipse(new Pen(color, solidSize), r);
                            g.FillEllipse(new SolidBrush(colorBack), r);
                            break;
                        case ToolItems.Line:
                            g.DrawLine(new Pen(color, solidSize), new Point(x, y), new Point(lx, ly));
                            break;
                    }
                    pictureBoxMain.Image = workingPict;
                }
            }
        }
        
        private void pictureBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {

                if (toolStripComboBoxBrushSize.Text != string.Empty)
                {
                    solidSize = Convert.ToInt32(toolStripComboBoxBrushSize.Text);
                }
                else
                {
                    solidSize = 3;
                }

                workingPict = new Bitmap(pictureBoxMain.Image);
                using (Graphics g = Graphics.FromImage(workingPict))
                {


                    switch (currItem)
                    {
                        case ToolItems.Pen:
                            g.FillEllipse(new SolidBrush(color), e.X - x + x, e.Y - y + y, solidSize, solidSize);
                            break;
                        case ToolItems.Eraser:
                            g.FillEllipse(new SolidBrush(pictureBoxMain.BackColor), e.X - x + x, e.Y - y + y, solidSize, solidSize);
                            break;
                    }
                    pictureBoxMain.Image = workingPict;
                }
            }
        }

        //Кнопка Открытие файла 
        private void toolStripButtonOpenF_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Bitmap|*.bmp|jpeg|*.jpg|png|*.png";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMain.ImageLocation = op.FileName;
            }
        }

        //Кнопка Сохранение файла
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Bitmap|*.bmp|jpeg|*.jpg|png|*.png";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                if (sf.FileName.Substring(sf.FileName.Length - 3).ToLower() == "bmp")
                {
                    pictureBoxMain.Image.Save(sf.FileName, ImageFormat.Bmp);
                }
                if (sf.FileName.Substring(sf.FileName.Length - 3).ToLower() == "jpg")
                {
                    pictureBoxMain.Image.Save(sf.FileName, ImageFormat.Jpeg);
                }
                if (sf.FileName.Substring(sf.FileName.Length - 3).ToLower() == "png")
                {
                    pictureBoxMain.Image.Save(sf.FileName, ImageFormat.Png);
                }
            }
        }

        //Кнопка инверсии рисунка
        private void toolStripButtonInvers_Click(object sender, EventArgs e)
        {
            workingPict = new Bitmap(pictureBoxMain.Image);
            FormProgress fp = new FormProgress(workingPict, this);
            fp.Show();
        }

        //Кнопка очистки полотна
        private void toolStripButtonClear_Click(object sender, EventArgs e)
        {
            pictureBoxMain.Image = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
        }

        //Обработчки выбора цветов
        private void toolStripButtonBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorBack = colorDialog.Color;
            }
        }

        private void toolStripButtonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color; 
            }
        }

        
    }
}
