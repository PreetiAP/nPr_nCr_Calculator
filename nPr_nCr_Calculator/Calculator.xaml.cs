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
using System.Windows.Shapes;

namespace nPr_nCr_Calculator
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        public Calculator()
        {
            InitializeComponent();
        }

        long Factorial(int n)
        {
           if (n >= 1)
               return n * Factorial(n - 1);
            else
                return 1;
        }

        long Find_nPr(int n, int r)
        {
           // nPr = n! / (n-r)!
            long numerator = Factorial(n);
            long denominator = Factorial(n - r);

            long nPr = numerator / denominator;
            return nPr;
        }

        long Find_nCr(int n, int r)
        {
            // nCr = nPr / r!
            long nPr = Find_nPr(n, r);
            long denominator = Factorial(r);

            long nCr = nPr / denominator;
            return nCr;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (txt_inputN.Text == "" || txt_inputR.Text == "")
            {
                MessageBox.Show("Enter input !");
                return;
            }
                        
            int n = Convert.ToInt32(txt_inputN.Text);
            int r = Convert.ToInt32(txt_inputR.Text);

            if (r>n)
            {
                MessageBox.Show("N should be Equal to or greater than R !\nPlease enter valid input");
            }
            else if(n == 0)
            {
                MessageBox.Show("N cannot be zero !\nPlease enter valid input");
            }
            else 
            {
                //find nPr and nCr
                MessageBox.Show("Press OK to see results ...");
                long nPr = Find_nPr(n, r);
                long nCr = Find_nCr(n, r);

                lblPermutation.Visibility = Visibility.Visible;
                lblCombination.Visibility = Visibility.Visible;
                txtnCr.Visibility = Visibility.Visible;
                txtnPr.Visibility = Visibility.Visible;
                lblEq1.Visibility = Visibility.Visible;
                lblEq2.Visibility = Visibility.Visible;

                txtNP.Text = n.ToString();
                txtRP.Text = r.ToString();
                txtNC.Text = n.ToString();
                txtRC.Text = r.ToString();

                txtP.Visibility = Visibility.Visible;
                txtC.Visibility = Visibility.Visible;

                txtnPr.Text = nPr.ToString();
                txtnCr.Text = nCr.ToString();

            }

        }
    }
}
