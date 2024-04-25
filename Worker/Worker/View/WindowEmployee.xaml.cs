﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
using Worker.Helper;
using Worker.Model;
using Worker.ViewModel;
using static System.Net.Mime.MediaTypeNames;
namespace Worker.View
{
    public partial class WindowEmployee : Window
    {
        private RoleViewModel vmRole;
        private List<Role> roles;
        public WindowEmployee()
        {
            InitializeComponent();
            vmRole = new RoleViewModel();
            roles = vmRole.ListRole.ToList();

            DataContext = new PersonViewModel();
        }
        private void EmployeeListView_Select(object sender, SelectionChangedEventArgs e)
        {
            ListView s = (ListView)sender;
            Person p = (Person)s.SelectedItem;

            ((PersonViewModel)DataContext).SelectedPerson = p;
        }
    }
}
