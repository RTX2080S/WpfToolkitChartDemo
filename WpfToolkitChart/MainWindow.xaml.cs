using System.Collections.Generic;
using System.Windows;

namespace WpfToolkitChart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            showColumnChart();
        }

        private void showColumnChart()
        {
            var valueList = new List<KeyValuePair<string, int>>();
            valueList.Add(new KeyValuePair<string, int>("Dev", 60));
            valueList.Add(new KeyValuePair<string, int>("Misc", 20));
            valueList.Add(new KeyValuePair<string, int>("Tester", 50));
            valueList.Add(new KeyValuePair<string, int>("QA", 30));
            valueList.Add(new KeyValuePair<string, int>("PM", 40));

            //Setting data for column chart
            columnChart.DataContext = valueList;

            // Setting data for pie chart
            pieChart.DataContext = valueList;

            //Setting data for area chart
            areaChart.DataContext = valueList;

            //Setting data for bar chart
            barChart.DataContext = valueList;

            //Setting data for line chart
            lineChart.DataContext = valueList;
        }
    }
}
