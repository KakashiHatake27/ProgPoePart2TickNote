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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ProgPoeTickNotePart2
{
    /// <summary>
    /// Interaction logic for LandingPage.xaml
    /// </summary>
    public partial class LandingPage : Window
    {

        public int timer = 0;
        private DispatcherTimer Timer;

        public LandingPage()
        {
            InitializeComponent();

            InitializeComponent();
            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Timer_Tick;
            Timer.Start();

        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            timer++;

            pbLoad.Value = pbLoad.Value + 34;

            if (timer == 4)
            {
                Login login = new Login();
           
                login.Show();
                this.Hide();
            }
        }
    }
}
