﻿using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Lab_2_2.Drawers
{
    class RectangleDrawer : IDrawer
    {
        public void Draw(Canvas DrawPlace, Shape shape)
        {
            Rectangle figure = new Rectangle();
            figure.StrokeThickness = 2;
            figure.Stroke = new SolidColorBrush(Colors.RosyBrown);
            figure.Fill = new SolidColorBrush(Colors.Beige);
            figure.Width = System.Math.Abs(shape.EndPoint.X - shape.StartPoint.X);
            figure.Height = System.Math.Abs(shape.EndPoint.Y - shape.StartPoint.Y);
            if (shape.StartPoint.X < shape.EndPoint.X) Canvas.SetLeft(figure, shape.StartPoint.X);
            else Canvas.SetLeft(figure, shape.EndPoint.X);
            if (shape.StartPoint.Y < shape.EndPoint.Y) Canvas.SetTop(figure, shape.StartPoint.Y);
            else Canvas.SetTop(figure, shape.EndPoint.Y);
            DrawPlace.Children.Add(figure);
        }
    }
}
