using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void PaintButton(object sender, PaintEventArgs e)
        {
            Graphics graf = e.Graphics;
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(45, 45, 300, 150);
            Region reg = new Region(path);
        }
    }
}
