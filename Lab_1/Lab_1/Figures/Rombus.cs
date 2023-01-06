using System.Windows;
using System.Windows.Media;

namespace Lab_1
{
    class Rombus : Line
    {
        private Point top, right;

        public Rombus(Point _top, Point _right) : base(_top, _right)
        {
            this.top = _top;
            this.right = _right;
        }

        public override void Draw(GeometryGroup mainDrawingGroup)
        {
            Point down = new Point(top.X, top.Y + 2 * (right.Y - top.Y));
            Point left = new Point(right.X - 2 * (right.X - top.X), right.Y);
            mainDrawingGroup.Children.Add(new LineGeometry(top, right));
            mainDrawingGroup.Children.Add(new LineGeometry(right, down));
            mainDrawingGroup.Children.Add(new LineGeometry(down, left));
            mainDrawingGroup.Children.Add(new LineGeometry(left, top));
        }
    }
}
