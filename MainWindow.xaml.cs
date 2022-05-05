using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace prjWPFShopping
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
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
            //PreviewTextInput = "NumberValidationTextBox"    this doesnt allow user to insert text but only numbers
            //shorturl.at/julR3
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            ProductData.lsProducts.Add(new Products(txtProductName.Text,Int32.Parse(txtProductID.Text), Int32.Parse(txtProductPrice.Text), Int32.Parse(txtProductQty.Text)));
            Reset();
            foreach (var vals in ProductData.lsProducts)
            {
                MessageBox.Show(vals.ToString(), "Data you entered",MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void Reset()
        {
            txtProductName.Text = "";
            txtProductID.Text = "";
            txtProductPrice.Text = "";
            txtProductQty.Text = "";
        }

        private void btnRefreshData_Click(object sender, RoutedEventArgs e)
        {
            resetEdit();
            lsOutput.Items.Clear();
            foreach (var vals in ProductData.lsProducts)
            {
                lsOutput.Items.Add(vals.ToString());
            }
        }

        private void btnRefreshProduct_Edit_Click(object sender, RoutedEventArgs e)
        {
           
            lsOutput_Edit.Items.Clear();
            foreach (var vals in ProductData.lsProducts)
            {
                lsOutput_Edit.Items.Add(vals.ProductName()); 
            }
        }

        private void lsOutput_Edit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lsOutput_Edit.SelectedIndex>=0)
            {
                String test = lsOutput_Edit.SelectedIndex.ToString();
                //MessageBox.Show(test, "Data you entered", MessageBoxButton.OK, MessageBoxImage.Information);
                Products SelectedItem = ProductData.lsProducts[lsOutput_Edit.SelectedIndex];
                txtProductID_Edit.Text = SelectedItem.IID.ToString();
                txtProductName_Edit.Text = SelectedItem.StrProduct;
                txtProductPrice_Edit.Text = SelectedItem.IPrice.ToString();
                txtProductQty_Edit.Text = SelectedItem.IQty.ToString();
            }           
        }
        private void btnUpdateProduct_Click(object sender, RoutedEventArgs e)
        {
            if (lsOutput_Edit.SelectedIndex >= 0)
            {
                int id = Int32.Parse(txtProductID_Edit.Text);
                String productName = txtProductName_Edit.Text;
                int Price = Int32.Parse(txtProductPrice_Edit.Text);
                int Quality = Int32.Parse(txtProductQty_Edit.Text);

                Products SelectedItem = new Products(productName,id,Price, Quality);
                ProductData.lsProducts[lsOutput_Edit.SelectedIndex] = SelectedItem;
            }
        }
        private void resetEdit()
        {
            txtProductID_Edit.Text = "";
            txtProductName_Edit.Text = "";
            txtProductPrice_Edit.Text = "";
            txtProductQty_Edit.Text = "";
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lsOutput_Edit.SelectedIndex >= 0)
            {
                ProductData.lsProducts.RemoveAt(lsOutput_Edit.SelectedIndex);
            }
            btnRefreshData_Click(sender, e); //presses this button aswell
        }
    }
}
