using System;
using System.Collections;
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

namespace HW_Lecture86_SortedList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList CustInfo;

        public MainWindow()
        {
            InitializeComponent();
            CustInfo = new SortedList();
        }

        private void bt_add_Click(object sender, RoutedEventArgs e)
        {
            
            CustInfo.Add(int.Parse(tb_Id.Text), tb_name.Text);

            ICollection collection = CustInfo.Keys;
            StringBuilder allData = new StringBuilder();
            foreach(int data in collection)
            {
                allData = allData.AppendLine(CustInfo[data].ToString());
            }
            
            MessageBox.Show(allData.ToString());
            tb_Id.Text = string.Empty;
            tb_Id.Focus();
            tb_name.Text = string.Empty;

        }
    }
}
