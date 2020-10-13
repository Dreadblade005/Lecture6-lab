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

namespace part1
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int operation = operationListBox.SelectedIndex;
                decimal lefthand = Convert.ToDecimal(Leftbox.Text);
                decimal righthand = Convert.ToDecimal(Rightbox.Text);
                decimal result = 0;
                
                switch(operation)
                {
                    case 0:
                        result = lefthand + righthand;
                        Resultbox.Text = result.ToString();
                        break;

                    case 1:
                        result = lefthand - righthand;
                        Resultbox.Text = result.ToString();
                        break;

                    case 2:
                        result = lefthand * righthand;
                        Resultbox.Text = result.ToString();
                        break;

                    case 3:
                        result = lefthand / righthand;
                        Resultbox.Text = result.ToString();
                        break;

                    case 4:
                        result = lefthand % righthand;
                        Resultbox.Text = result.ToString();
                        break;

                    default:
                        result = 0;
                        MessageBox.Show("No operation selected");
                        break;
                }//end of try
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Error: can not divide by zero.");
            }
        }
    }
}
