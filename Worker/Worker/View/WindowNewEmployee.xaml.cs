using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Workers.Helper;
using Workers.Model;
using Workers.ViewModel;

namespace Workers.View
{
    public partial class WindowNewEmployee : Window
    { 
        public WindowNewEmployee()
        {
            InitializeComponent();
            CbRole.ItemsSource = new RoleViewModel().ListRole;
        }
        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            if(CbRole.SelectedItem == null)
            {
                MessageBox.Show("Нужно выбрать роль!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            DialogResult = true;
        }
    }
}
