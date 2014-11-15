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
using System.Xml;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calc calc = new Calc();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = calc;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string content = (sender as Button).Content.ToString();

            switch (content)
            {
                case "=":
                    try { calc.Calculate(); }
                    catch { calc.expression = ""; }
                    break;
                default:
                    calc.expression += content;
                    break;
            }
            
        }
    }
}
