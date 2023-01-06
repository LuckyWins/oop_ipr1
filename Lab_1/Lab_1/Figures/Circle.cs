using System.Windows;
using System.Windows.Media;

namespace Lab_1
{
    class Circle : Ellipse
    {
        private Point center, radius;

        public Circle(Point _center, Point _radius) : base(_center, _radius)
        {
            this.center = _center;
            this.radius = _radius;
        }

        public override void Draw(GeometryGroup mainDrawingGroup)
        {
            mainDrawingGroup.Children.Add(new EllipseGeometry(center, radius.X, radius.X));
        }
    }
}
