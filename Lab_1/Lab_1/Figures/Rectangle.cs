using System.Windows;
using System.Windows.Media;

namespace Lab_1
{
    class Rectangle : IShape
    {
        private Point upperLeft, downRight;

        public Rectangle(Point _upperLeft, Point _downRight)
        {
            this.upperLeft = _upperLeft;
            this.downRight = _downRight;
        }

        public virtual void Draw(GeometryGroup mainDrawingGroup)
        {
            mainDrawingGroup.Children.Add(new RectangleGeometry(new Rect(upperLeft, downRight)));
        }
    }
}
