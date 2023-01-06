using System.Windows;

namespace Lab_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Figures mainList = new Figures();

            mainList.Add(new Line(new Point(0, 0), new Point(400, 0)));
            mainList.Add(new Line(new Point(100, 270), new Point(500, 270)));
            mainList.Add(new Rectangle(new Point(100, 100), new Point(250, 200)));
            mainList.Add(new Square(new Point(60, 60), new Point(150, 0)));
            mainList.Add(new Ellipse(new Point(280, 200), new Point(90, 60)));
            mainList.Add(new Circle(new Point(350, 80), new Point(70, 0)));
            mainList.Add(new Rombus(new Point(350, 30), new Point(430, 140)));

            mainPaint.Source = mainList.Drawing();
        }
    }
}
