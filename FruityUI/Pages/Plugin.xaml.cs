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

namespace FruityUI.Pages
{
    /// <summary>
    /// Interaction logic for Plugins.xaml
    /// </summary>
    public partial class Plugins : Page
    {
        public Plugins()
        {
            InitializeComponent();
        }

        public void addPlugin(MainWindow w, string name, int index)
        {
            panel.Children.Add(new FruityUI.Plugin(w, name, index));

        }
    }
}
