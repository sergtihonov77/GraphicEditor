using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace GraphicEditor
{
    public partial class FormMain : Form
    {
        Color color;
        Color colorBack;
        bool draw;
        int x, y, lx, ly;
        ToolItems currItem;
        int solidSize;
        public Bitmap workingPict;       

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            pictureBoxMain.Image = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
            color = Color.Black;
            colorBack = Color.White;
            draw = false;
            x = 0; y = 0; lx = 0; ly = 0;
            solidSize = 5;

            workingPict = new Bitmap(pictureBoxMain.Image);
            toolStripComboBoxBrushSize.Text = "5";
            toolStripComboBoxFontStyle.Text = "Regular";
            toolStripComboBoxFontSize.Text = "25";
            toolStripComboBoxFont.Text = "Arial";

            FontFamily[] fonts = FontFamily.Families;

            foreach (FontFamily f in fonts)
            {
                toolStripComboBoxFont.Items.Add(f.GetName(1).ToString());
            }


        }

        //Перечисление набора инструментов
        public enum ToolItems
        {
            Line, Ellipse, Rectangle, Fill, Pen, Eraser, Text
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

        private void toolStripButtonText_Click(object sender, EventArgs e)
        {
            currItem = ToolItems.Text;
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
                workingPict = (Bitmap)pictureBoxMain.Image;
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
                        case ToolItems.Text:

                            if (toolStripTextBoxYourText.Text != string.Empty && toolStripComboBoxFontStyle.Text == "Strikeout")
                            {
                                g.DrawString(toolStripTextBoxYourText.Text,
                                    new Font(toolStripComboBoxFont.Text, Convert.ToInt32(toolStripComboBoxFontSize.Text), FontStyle.Strikeout),
                                    new SolidBrush(color), new PointF(x, y));
                            }

                            if (toolStripTextBoxYourText.Text != string.Empty && toolStripComboBoxFontStyle.Text == "Underline")
                            {
                                g.DrawString(toolStripTextBoxYourText.Text,
                                    new Font(toolStripComboBoxFont.Text, Convert.ToInt32(toolStripComboBoxFontSize.Text), FontStyle.Underline),
                                    new SolidBrush(color), new PointF(x, y));
                            }

                            if (toolStripTextBoxYourText.Text != string.Empty && toolStripComboBoxFontStyle.Text == "Bold")
                            {
                                g.DrawString(toolStripTextBoxYourText.Text, 
                                    new Font(toolStripComboBoxFont.Text, Convert.ToInt32(toolStripComboBoxFontSize.Text),FontStyle.Bold ), 
                                    new SolidBrush(color), new PointF(x,y));
                            }

                            if (toolStripTextBoxYourText.Text != string.Empty && toolStripComboBoxFontStyle.Text == "Italic")
                            {
                                g.DrawString(toolStripTextBoxYourText.Text,
                                    new Font(toolStripComboBoxFont.Text, Convert.ToInt32(toolStripComboBoxFontSize.Text), FontStyle.Italic),
                                    new SolidBrush(color), new PointF(x, y));
                            }

                            if (toolStripTextBoxYourText.Text != string.Empty && toolStripComboBoxFontStyle.Text == "Regular")
                            {
                                g.DrawString(toolStripTextBoxYourText.Text,
                                    new Font(toolStripComboBoxFont.Text, Convert.ToInt32(toolStripComboBoxFontSize.Text), FontStyle.Regular),
                                    new SolidBrush(color), new PointF(x, y));
                            }
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

                workingPict = (Bitmap)pictureBoxMain.Image;
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
