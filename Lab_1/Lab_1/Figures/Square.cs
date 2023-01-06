using System.Windows;
using System.Windows.Media;

namespace Lab_1
{
    class Square : Rectangle
    {
        private Point upperLeft, downRight;

        public Square(Point _upperLeft, Point _right) : base(_upperLeft, _right)
        {
            this.upperLeft = _upperLeft;
            this.downRight = _right;
        }

        public override void Draw(GeometryGroup mainDrawingGroup)
        {
            downRight.Y = upperLeft.Y + (downRight.X - upperLeft.X);
            mainDrawingGroup.Children.Add(new RectangleGeometry(new Rect(upperLeft, downRight), 2, 2));
        }
    }
}
