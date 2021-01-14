using AmbiPDV.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static AmbiStore.Shared.Extension.StringExtensions;

namespace AmbiPDV.Views
{
    /// <summary>
    /// Interaction logic for FECHAMENTOCUPOMView.xaml
    /// </summary>
    public partial class FECHAMENTOCUPOMView : Window
    {
        public FECHAMENTOCUPOMView()
        {
            InitializeComponent();
            txb_FormaPagto.Focus();
        }

        private void FECHAMENTOCUPOMView_ClosesWindow(object sender, EventArgs e)
        {
            DialogResult = true;
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                DialogResult = false;
            }
        }

        private void txb_FormaPagto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txb_ValorPagto.Focus();
                txb_ValorPagto.SelectAll();
            }
        }

        private void txb_ValorPagto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ((FECHAMENTOCUPOMViewModel)DataContext).ProcessaMetodoAtual();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ((FECHAMENTOCUPOMViewModel)DataContext).ClosesWindow += FECHAMENTOCUPOMView_ClosesWindow;
        }
    }
}
