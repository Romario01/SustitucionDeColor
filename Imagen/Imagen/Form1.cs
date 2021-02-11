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

namespace Imagen
{
    public partial class Form1 : Form
    {
        int red;
        int green;
        int blue;

        public Form1()
        {
            InitializeComponent();
        }
        Bitmap imagen;
        private void btnAbrirImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Filter(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // Muestra la imagen en el pictureBox
                picBox1.Image = new Bitmap(open.FileName);
                picBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            SustituirColor();
            SeleccionColor.BackColor = Color.FromArgb(SeleccionRojo.Value, SeleccionVerde.Value, SeleccionAzul.Value);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SeleccionRojo.Value = 128;
            SeleccionVerde.Value = 128;
            SeleccionAzul.Value = 128;
            SeleccionColor.BackColor = Color.FromArgb(SeleccionRojo.Value, SeleccionVerde.Value, SeleccionAzul.Value);

        }
        private void SustituirColor()
        {
            //Aplicando el color a la imagen
            pictureBox2.Image = NuevoColor(picBox1.Image, SeleccionColor.BackColor);
        }

        private Bitmap NuevoColor(Image image, Color color)
        {
            //Creando un nuevo bitmap con el color seleccionado

            float r = color.R / 255f;
            float g = color.G / 255f;
            float b = color.B / 255f;

            //Matriz de Color
            ColorMatrix cm = new ColorMatrix(new float[][]
            {
                new float[] {r, 0, 0, 0, 0},
                new float[] {0, g, 0, 0, 0},
                new float[] {0, 0, b, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {0, 0, 0, 0, 1}
            });
            ImageAttributes ImAttribute = new ImageAttributes();
            //agregamos los atributos del arreglo de la matriz
            ImAttribute.SetColorMatrix(cm);

            //Matriz de color sobre el nuevo bitmap
            Point[] points =
            {
                new Point(0, 0),
                new Point(image.Width - 1, 0),
                new Point(0, image.Height - 1),
            };
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

            Bitmap myBitmap = new Bitmap(image.Width, image.Height);
            using (Graphics graphics = Graphics.FromImage(myBitmap))
            {
                graphics.DrawImage(image, points, rect, GraphicsUnit.Pixel, ImAttribute);
            }
            return myBitmap;
        }

        private void btnGuardarImagen_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";

            sfd.ShowDialog();
            string filename = sfd.FileName;
            pictureBox2.Image.Save(filename);
        }
    }
}
