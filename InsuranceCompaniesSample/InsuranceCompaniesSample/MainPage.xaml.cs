using Syncfusion.Maui.Charts;

namespace InsuranceCompaniesSample
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

    }

    public class ColumnSeriesExt : ColumnSeries
    {
        protected override ChartSegment CreateSegment()
        {
            return new ColumnSegmentExt();
        }
    }

    public class ColumnSegmentExt : ColumnSegment
    {
        protected override void Draw(ICanvas canvas)
        {

            // Create a path rectangle with a triangle top
            var path = new PathF();
            path.MoveTo(Left, Bottom); 
            path.LineTo(Right, Bottom); 
            path.LineTo(Right, Top + 20); 
            path.LineTo((Left + Right) / 2, Top); 
            path.LineTo(Left, Top + 20); 
            path.Close();

           
            var color = (Fill is SolidColorBrush brush) ? brush.Color : Colors.Transparent;
            canvas.FillColor = color;
            canvas.FillPath(path);
            
        }
    }

}
