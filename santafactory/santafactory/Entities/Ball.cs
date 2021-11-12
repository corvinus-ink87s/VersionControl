using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using santafactory.Abstractions;

namespace santafactory.Entities
{
    public class Ball : Toy
    {
        public SolidBrush BallColor { get; private set; }

        public Ball(Color color)
        {
            BallColor = new SolidBrush(color);
        }



        /*  public Ball()
          {
              AutoSize = false;
              Width = 50;
              Height = Width;
              Paint += Ball_Paint;
          }

          private void Ball_Paint(object sender, PaintEventArgs e)
          {
              DrawImage(e.Graphics);
          } */

        protected override void DrawImage(Graphics g)
        {
            //throw new NotImplementedException();
            g.FillEllipse(BallColor, 0, 0, Width, Height);
        }

       /* public void MoveBall()
        {
            Left += 1;
        }*/

    }
}
