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
    /// Interaction logic for Installer.xaml
    /// </summary>
    public partial class Installer : Page
    {
        public Installer(MainWindow w)
        {
            InitializeComponent();

            button.Click += (s, e) => w.getLibrary();
            button1.Click += (s, e) => w.set4Reset();
        }
    }
}
