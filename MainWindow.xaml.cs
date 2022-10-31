﻿using System;
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

namespace ProgPoeTickNotePart2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string CurrentUser;
        userAccount user = new userAccount();


        public TickNoteEntities TNotedb = new TickNoteEntities();


        public MainWindow()
        {
            InitializeComponent();

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {

                Application.Current.Shutdown();
            }
        }

        private void imgClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {

                Application.Current.Shutdown();
            }
        }

        private void btnAddModule_Click(object sender, RoutedEventArgs e)
        {


            lbUserName.Content = CurrentUser;



            var users = from d in TNotedb.userAccounts
                        select d;

            this.dgUsers.ItemsSource = users.ToList();
            MessageBox.Show("Got db");

            MessageBox.Show("Done!!");
            AddModule addModule = new AddModule();
 
            user = TNotedb.userAccounts.Where(x => x.username == CurrentUser).FirstOrDefault();
            addModule.userId = user.userId;
            addModule.Show();

            //MessageBox.Show(user.userId.ToString());

            //var modules = from m in TNotedb.modules
            //              select m;
            //this.dgModule.ItemsSource = modules.ToList();


        }

        private void btnAddSession_Click(object sender, RoutedEventArgs e)
        {


            MessageBox.Show("Step 1");
            var modules = from m in TNotedb.modules
                        select m;

            MessageBox.Show("Step 2");
            this.dgModules.ItemsSource = modules.ToList();

            MessageBox.Show("Step 3");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            this.dgModules.ItemsSource = TNotedb.modules.ToList();
        }
    }
}
