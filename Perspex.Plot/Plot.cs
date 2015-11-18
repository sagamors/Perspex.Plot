using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Perspex.Controls;
using Perspex.Media;

namespace Perspex.Plot
{
    public class Plot : Control
    {
        public override void Render(IDrawingContext context)
        {
            var background = Brushes.Silver;
            var borderBrush = Brushes.AliceBlue;
            var borderThickness = 3;
            var cornerRadius = 2;
            var rect = new Rect(Bounds.Size).Deflate(new Thickness(borderThickness));

            if (background != null)
            {
                context.FillRectange(background, rect, cornerRadius);
            }

            if (borderBrush != null && borderThickness > 0)
            {
                context.DrawRectange(new Pen(borderBrush, borderThickness), rect, cornerRadius);
            }
        }
    }
}
