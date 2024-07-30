using Assignment_2.LogCalculations;
using Assignment_2.PolyCalculations;
using Assignment_2.TrigCalculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnCalculateClick(object sender, RoutedEventArgs e)
        {
            double theta = double.Parse(InputTheta.Text);
            double sin2Theta = TrigFunctions.CalculateSin2Theta(theta);
            double cos3Theta = TrigFunctions.CalculateCos3Theta(theta);
            double tanTheta = TrigFunctions.CalculateTanTheta(theta);
            double logTheta = LogFunctions.CalculateLogTheta(theta);
            double polynomial = PolynomialFunctions.CalculatePolynomial(theta);

            ResultTextBlock.Text = $"sin(2θ): {sin2Theta}\ncos(3θ): {cos3Theta}\ntan(θ): {tanTheta}\nlog(θ): {logTheta}\nPolynomial: {polynomial}";
        }
    }
}
