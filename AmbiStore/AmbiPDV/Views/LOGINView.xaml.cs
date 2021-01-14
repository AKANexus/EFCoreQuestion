using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AmbiStore.Shared.EFCore.Data;
using AmbiStore.Shared.EFCore.Models;
using AmbiStore.Shared.Libraries;
using AmbiPDV.ViewModels;
using AmbiPDV.Views;
using Microsoft.EntityFrameworkCore;
using static AmbiStore.Shared.Libraries.Static;

namespace AmbiPDV.Views
{
    /// <summary>
    /// Interaction logic for LOGINView.xaml
    /// </summary>
    public partial class LOGINView : Window
    {
        private Functions funcoes;
        public LOGINView()
        {
            InitializeComponent();
            AutoLogin();
        }

        private async void AutoLogin()
        {
            this.Hide();
            (new CAIXAView()/* { DataContext = new CAIXAViewModel() }*/).ShowDialog();
        }
    }
}
