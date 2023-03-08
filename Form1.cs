using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dibujarMano
{
    public partial class Form1 : Form
    {
        Graphics papel;
        Bitmap bm;
        int anchoPluma = 3;
        int x = 0, y = 0;
        bool moving = false;
        Pen pen;
        int r = 0;
        int g = 0;
        int b = 0;
        int sx, sy, cx, cy;
        int menu;

        Point px, py;

        public Form1()
        {
            InitializeComponent();
            //Asignamos nuestra propiedad Graphics a nuestro picture box
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            papel = pictureBox1.CreateGraphics();
            papel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //Para suavisar el trazo del pincel 
            //Cuando se dibuje en el picture box se suavice el trazo                                                                        //Cuando se dibuje en el picture box se suavice el trazo
            anchoPluma = trackBar1.Value;
            //Inicializamos nuestra variable con el valor del trackBar
            //Aqui va la declaracion de las letras de RGB con los valores de los text box

            pen = new Pen(Color.FromArgb(r, g, b), anchoPluma);
            //Inicializamos un pincel con los valores y el tamaño del pincel 
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            //Nuestros trazos inicien y terminen de forma ovalada
            papel = Graphics.FromImage(bm);
            pictureBox1.BackgroundImage = bm;
            papel.Clear(Color.White);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;

            cx = e.X; cy = e.Y;
            pictureBox1.Cursor = Cursors.Cross;
            //Cambiar cursos a una cruz
        }
        //Evento que se dispara al hacer click y sostenerlo sobre el picture box
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            sx = x - cx;
            sy = y - cy;
            if (menu == 1)

            {
                papel.DrawEllipse(pen, cx, cy, sx, sy);
                cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
            }
            if (menu == 2)
            {
                papel.DrawRectangle(pen, cx, cy, sx, sy);
                cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
            }
            if (menu == 3)
            {
                papel.DrawLine(pen, cx, cy, sx, sy);
                cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
            }
        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            menu = 4;
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            menu = 5;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtR.Text = txtG.Text = txtB.Text = 0.ToString();
        }



        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (moving)
            {
                if (menu == 4)
                {
                    cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                    px = e.Location;
                    papel.DrawLine(pen, px, py);
                    py = px;
                }
                if (menu == 5)
                {
                    cambiarPincel(255, 255, 255);
                    px = e.Location;
                    papel.DrawLine(pen, px, py);
                    py = px;
                }
                pictureBox1.Refresh();
               
            }
            x = e.X;
            y = e.Y;
            sx = e.X - cx;
            sy = e.Y - cy;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            anchoPluma = trackBar1.Value;
            lblAncho.Text = trackBar1.Value.ToString();
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics papel = e.Graphics;
            if (moving)
            {
                if (menu == 1)
                {
                    papel.DrawEllipse(pen, cx, cy, sx, sy);
                    cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                }
                if (menu == 2)
                {
                    papel.DrawRectangle(pen, cx, cy, sx, sy);
                    cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                }
                if (menu == 3)
                {
                    papel.DrawLine(pen, cx, cy, x, y);
                    cambiarPincel(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                }
            }

        }

        private void btnEl_Click(object sender, EventArgs e)
        {
            menu = 1;
        }

        private void btnBorrarAll_Click(object sender, EventArgs e)
        {
            papel.Clear(Color.White);
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Bitmap btm = bm.Clone(new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            menu = 2;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            menu = 3;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtR.Text = colorDialog1.Color.R.ToString();
                txtG.Text = colorDialog1.Color.G.ToString();
                txtB.Text = colorDialog1.Color.B.ToString();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtR.Text = 0.ToString();
            txtG.Text = 0.ToString();
            txtB.Text = 0.ToString();
        }

        private void cambiarPincel(int r, int g, int b)
        {
            pen = new Pen(Color.FromArgb(r, g, b), anchoPluma);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
    }
}


