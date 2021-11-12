using santafactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace santafactory.Entities
{
    public class Car : Abstractions.Toy
    {
        protected override void DrawImage(Graphics g)
        {
            throw new NotImplementedException();

            var image = Image.FromFile(@"Images\car.png");
            g.DrawImage(imageFile, new Rectangle(0, 0, Width, Height));

        }
    }
}
