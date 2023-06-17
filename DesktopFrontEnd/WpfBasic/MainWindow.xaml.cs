﻿using System.Windows;

namespace WpfBasic
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

        private void Add_Name(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textName.Text) && !listNames.Items.Contains(textName.Text))
            {
                listNames.Items.Add(textName.Text);
                textName.Clear();
            }
        }
    }
}
