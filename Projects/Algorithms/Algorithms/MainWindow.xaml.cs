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

namespace Algorithms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //LCM
            Math.LCM_HCF x = new Math.LCM_HCF();
            //MessageBox.Show(x.GetLCM(new List<int>{ 10, 8, 7, 6 }).ToString());
            //MessageBox.Show(x.GetGCD(new List<int> { 10, 8, 2, 6 }).ToString());
        }
    }
}
