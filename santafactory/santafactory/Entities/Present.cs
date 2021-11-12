﻿using santafactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace santafactory.Entities
{
    public class Present : Toy
    {
        public SolidBrush BoxColor { get; private set; }
        public SolidBrush RibbonColor { get; private set; }
        public Present(Color boxcolor, Color ribboncolor)
        {
            BoxColor = new SolidBrush(boxcolor);
            RibbonColor = new SolidBrush(ribboncolor);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
            g.FillRectangle(RibbonColor, 0, (Height / 5) * 2, Width, Height / 5);
            g.FillRectangle(RibbonColor, (Width/5)*2, 0, Width/5, Height);
        }
    }
}
