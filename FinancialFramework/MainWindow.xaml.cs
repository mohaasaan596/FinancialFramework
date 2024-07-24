using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinancialFramework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        private int _amount;
        private int _twentyPercent;
        private int _thirtyPercent;
        private int _fiftyPercent;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void txtCalculate_Click(object sender, RoutedEventArgs e)
        {
            _amount = Convert.ToInt32(txtAmount.Text);
            _calculateAmount(_amount);
            _fillUI();
        }
        private void _calculateAmount(int amount)
        {
            _twentyPercent = (amount / 100) * 20;
            _thirtyPercent = (amount / 100) * 30;
            _fiftyPercent = (amount / 100) * 50;
        }
        private void _fillUI()
        {
            txt20Percent.Text= _twentyPercent.ToString();
            txt30Percent.Text= _thirtyPercent.ToString();
            txt50Percent.Text= _fiftyPercent.ToString();
        }
    }
}
