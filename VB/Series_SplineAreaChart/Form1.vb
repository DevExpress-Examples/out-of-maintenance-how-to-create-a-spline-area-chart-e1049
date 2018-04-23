Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Series_SplineAreaChart
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create a new chart.
            Dim splineAreaChart As New ChartControl()

            ' Create a spline area series.
            Dim series1 As New Series("Series 1", ViewType.SplineArea)

            ' Add points to it.
            series1.Points.Add(New SeriesPoint(1, 3))
            series1.Points.Add(New SeriesPoint(2, 12))
            series1.Points.Add(New SeriesPoint(3, 4))
            series1.Points.Add(New SeriesPoint(4, 17))
            series1.Points.Add(New SeriesPoint(5, 3))
            series1.Points.Add(New SeriesPoint(6, 12))
            series1.Points.Add(New SeriesPoint(7, 4))
            series1.Points.Add(New SeriesPoint(8, 17))

            ' Add the series to the chart.
            splineAreaChart.Series.Add(series1)

            ' Set the numerical argument scale types for the series,
            ' as it is qualitative, by default.
            series1.ArgumentScaleType = ScaleType.Numerical

            ' Access the view-type-specific options of the series.
            CType(series1.View, SplineAreaSeriesView).LineTensionPercent = 90

            ' Access the type-specific options of the diagram.
            CType(splineAreaChart.Diagram, XYDiagram).AxisX.WholeRange.AutoSideMargins = False

            ' Hide the legend (if necessary).
            splineAreaChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False

            ' Add a title to the chart (if necessary).
            splineAreaChart.Titles.Add(New ChartTitle())
            splineAreaChart.Titles(0).Text = "A Spline Area Chart"

            ' Add the chart to the form.
            splineAreaChart.Dock = DockStyle.Fill
            Me.Controls.Add(splineAreaChart)
        End Sub
    End Class
End Namespace