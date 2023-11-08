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

namespace WpfApp_SimpleNameList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Stack<object> removedItems = new Stack<object>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            {
                lstNames.Items.Add(txtName.Text);
                txtName.Clear();
            }
        }

        private void ButtonRemove_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = new List<object>(lstNames.SelectedItems.Cast<object>());
            foreach (var selectedItem in selectedItems)
            {
                lstNames.Items.Remove(selectedItem);
                removedItems.Push(selectedItem);
            }
        }

        private void ButtonUndo_Click(object sender, RoutedEventArgs e)
        {
            if (removedItems.Count > 0)
            {
                var itemToUndo = removedItems.Pop();
                lstNames.Items.Add(itemToUndo);
            }
        }
    }
}
