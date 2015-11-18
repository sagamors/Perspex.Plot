using Perspex.Controls;
using Perspex.Media;

namespace Perspex.Plot
{
    public class Axis : Control
    {
        public static readonly PerspexProperty<double> MaxValueProperty = PerspexProperty.Register<Axis, double>(nameof(MaxValue),100);

        public double MaxValue
        {
            get { return GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }

        public static readonly PerspexProperty<double> MinValueProperty = PerspexProperty.Register<Axis, double>(nameof(MinValue));

        public double MinValue
        {
            get { return GetValue(MinValueProperty); }
            set { SetValue(MinValueProperty, value); }
        }

        public double MajorLineThickness { get; set; }
        public double MinorLineThickness { get; set; }

        public override void Render(IDrawingContext context)
        {
            double range = this.Bounds.Width/(MaxValue  - MinValue);
            Pen backgroundPen = new Pen(Brushes.Black, 5);
            Brush TextBrush = Brushes.Black;
            double step = 0.5;
            int countValue = (int) (range / step);
            double stepX = this.Bounds.Width/countValue;

            for (int i = 0; i < countValue; i++)
            {
                var x = i* stepX;
               // context.DrawLine(backgroundPen, new Point(x, 0), new Point(x, this.Bounds.Height));
                context.DrawText(TextBrush, new Point(x, 2),new FormattedText((i*step).ToString(), "Verdana", 22,FontStyle.Normal, TextAlignment.Center,FontWeight.Normal));
            }
  
            //context.DrawLine(foreground, new Point(100, 100), new Point(200, 200));
            /*
            var AxisMajorBrush = Brushes.Black; 
            context.DrawRectange(new Pen(AxisMajorBrush,2),new Rect(new Point(10, 0), new Point(10, Height)));

            var borderBrush = Brushes.AliceBlue;
            var borderThickness = 3;
            var cornerRadius = 2;
            var rect = new Rect(Bounds.Size).Deflate(new Thickness(borderThickness));


             context.FillRectange(backgroundPen.Brush, rect, cornerRadius);
            if (borderBrush != null && borderThickness > 0)
            {
                context.DrawRectange(new Pen(borderBrush, borderThickness), rect, cornerRadius);
            }*/
        }
    }
}
