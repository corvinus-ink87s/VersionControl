using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace santafactory.Abstractions
{
    public class Toy : Label 
    {
        public Toy()
        {
            AutoSize = false;
            Width = 50;
            Height = Width;
            Paint += Toy_Paint;
        }

        private void Toy_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        private void DrawImage(Graphics g)
        {
            //throw new NotImplementedException();
            g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height);
        }

        public void MoveToy()
        {
            Left += 1;
        }

    }
}
