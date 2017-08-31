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
using System.IO;

namespace nPr_nCr_Calculator
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

        private void btnPermutation_Click(object sender, RoutedEventArgs e)
        {
            //Theory of Permutation
            //textBox1.Text = System.IO.File.ReadAllText(path);
            imgComination.Visibility = Visibility.Hidden;
            imgPermutation.Visibility = Visibility.Hidden;

            txtDef.Visibility = Visibility.Visible;
            string path = ResourceLocation("PermutationDef.txt"); ; //"PermutationDef.txt";
            txtDef.Text = System.IO.File.ReadAllText(path);
        }

        private void btnCombination_Click(object sender, RoutedEventArgs e)
        {
            //Theory of Combination
            imgComination.Visibility = Visibility.Hidden;
            imgPermutation.Visibility = Visibility.Hidden;

            txtDef.Visibility = Visibility.Visible;
            String path = ResourceLocation("CombinationDef.txt");  //"CombinationDef.txt";
            txtDef.Text = System.IO.File.ReadAllText(path);
        }

        private string ResourceLocation(string fileName)
        {
            //string filePath = string.Format("..\\..\\src\\{0}", fileName);
            string filePath = string.Format("{0}\\src\\{1}", Directory.GetCurrentDirectory(), fileName);
            if (File.Exists(filePath))
                return filePath;
            else
            {
                MessageBox.Show(string.Format("Could not found the file {0}", fileName));
                return "";
            }

        }

        private void btnPermutation_Formula_Click(object sender, RoutedEventArgs e)
        {
            //Permutation_Formula
            imgComination.Visibility = Visibility.Hidden;
            txtDef.Visibility = Visibility.Hidden;

            string imgFile = "nPr.PNG";

            imgPermutation.Source = new BitmapImage(new Uri(ResourceLocation(imgFile)));
            imgPermutation.Visibility = Visibility.Visible;
        }

        private void btnCombination_Formula_Click(object sender, RoutedEventArgs e)
        {
            //Combination_Formula
            imgPermutation.Visibility = Visibility.Hidden;
            txtDef.Visibility = Visibility.Hidden;

            string imgFile = "nCr.PNG";

            imgComination.Source = new BitmapImage(new Uri(ResourceLocation(imgFile)));
            imgComination.Visibility = Visibility.Visible;
        }

        private void btnCalculator_Click(object sender, RoutedEventArgs e)
        {
            // Calculator
            Calculator cal = new Calculator();
            cal.ShowDialog();
        }
    }
}
