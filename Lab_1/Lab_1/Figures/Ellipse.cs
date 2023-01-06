using System.Windows;
using System.Windows.Media;

namespace Lab_1
{
    class Ellipse : IShape
    {
        private Point center, radius;

        public Ellipse(Point _center, Point _radXY)
        {
            this.center = _center;
            this.radius = _radXY;
        }

        public virtual void Draw(GeometryGroup mainDrawingGroup)
        {
            mainDrawingGroup.Children.Add(new EllipseGeometry(center, radius.X, radius.Y));
        }
    }
}
