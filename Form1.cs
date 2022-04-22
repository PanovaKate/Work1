using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_1
{
    public partial class Form1 : Form
    {
        private int MouseDoubleClickWidth = 200, MouseDoubleClickHeight = 200;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(500, 500);
            this.MinimumSize = new Size(500, 500);
            MouseDoubleClick = new PictureBox();
            MouseDoubleClick.Size = new Size(MouseDoubleClickWidth, MouseDoubleClickHeight);

            // Задаем начальное местоположение PictureBox
            MouseDoubleClick.Location = new Point(100, 150);

            MouseDoubleClick.BorderStyle = BorderStyle.Fixed3D;
            this.Controls.Add(MouseDoubleClick);
           // MouseDoubleClick.MouseDoubleClick += new MouseEventHandler(this.MouseDoubleClick_MouseDoubleClick);
            MouseDoubleClick.MouseEnter += new EventHandler(this.MouseDoubleClick_MouseEnter);
            MouseDoubleClick.MouseLeave += new EventHandler(this.MouseDoubleClick_MouseLeave);
            MouseDoubleClick.MouseDown += new MouseEventHandler(this.MouseDoubleClick_MouseDown);
            MouseDoubleClick.MouseMove += new MouseEventHandler(this.MouseDoubleClick_MouseMove);
            MouseDoubleClick.MouseUp += new MouseEventHandler(this.MouseDoubleClick_MouseUp);

            this.MouseWheel += new MouseEventHandler(MouseDoubleClick_MouseWheel);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            int x_mouse = e.X;
            int y_mouse = e.Y;
            MessageBox.Show("Координаты мыши внутри PictureBox" + x_mouse + " " + y_mouse);
        }
        private void MouseDoubleClick_MouseEnter(object sender, EventArgs e)
        {
            // mouse.BackColor = Color.CadetBlue;
            MouseDoubleClick.Image = Image.FromFile(@"C:\Downloads\mouse2.png");
            MouseDoubleClick.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void MouseDoubleClick_MouseLeave(object sender, EventArgs e)
        {
            // mouse.BackColor = Color.AliceBlue;
            MouseDoubleClick.Image = Image.FromFile(@"C:\Downloads\mouse1.png");
            MouseDoubleClick.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        private bool isDragging = false; 
        private int oldX, oldY;
        private void MouseDoubleClick_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;

            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                oldX = e.X;
                oldY = e.Y;
            }
            if (e.Button == MouseButtons.Right)
            {
                //MessageBox.Show(" I'm really good! ");
                ToolTip podskazka = new ToolTip();
                podskazka.SetToolTip(MouseDoubleClick, "I'm really good!\nGood job!\nGood work!\nWay to go!");
            }
        }

        private void MouseDoubleClick_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                MouseDoubleClick.Top = MouseDoubleClick.Top + (e.Y - oldY); //координаты PictureBox
                MouseDoubleClick.Left = MouseDoubleClick.Left + (e.X - oldX); //координаты PictureBox
            }
        }
        private void MouseDoubleClick_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;

        }
        private double ImageScale = 1.0;
        private void MouseDoubleClick_MouseWheel(object sender, MouseEventArgs e)
        {
            // изменение размера при прокручивании колесика мышки

            const double scale_per_delta = 0.1 / 120;
            // пересчитываем размер
            ImageScale += e.Delta * scale_per_delta;

            // чтобы не выйти за разумные размеры
            if (ImageScale < 0.5) ImageScale = 0.5;

            if (ImageScale > 1.5) ImageScale = 1.5f;

            // устанавливаем размер PictureBox

            MouseDoubleClick.Size = new Size((int)(MouseDoubleClickWidth * ImageScale), (int)(MouseDoubleClickHeight * ImageScale));

        }

    }
}
