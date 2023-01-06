using System.Windows;
using System.Windows.Media;

namespace Lab_1
{
    class Line : IShape
    {
        private Point start, end;

        public Line(Point _start, Point _finish)
        {
            this.start = _start;
            this.end = _finish;
        }

        public virtual void Draw(GeometryGroup mainDrawingGroup)
        {
            mainDrawingGroup.Children.Add(new LineGeometry(start, end));
        }
    }
}