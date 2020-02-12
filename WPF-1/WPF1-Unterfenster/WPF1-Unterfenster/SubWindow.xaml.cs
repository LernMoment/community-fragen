using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF1_Unterfenster
{
    /// <summary>
    /// Interaktionslogik für SubWindow.xaml
    /// </summary>
    public partial class SubWindow : Window
    {
        public SubWindow()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            // Wenn ein Prozess mit einer URL gestartet wird, wird automatisch der default Browser geöffnet
            var defaultBrowser = new ProcessStartInfo(e.Uri.AbsoluteUri)
            {
                UseShellExecute = true
            };

            // Der gestartet Prozess interessiert uns nicht weiter hier im Code. Daher verwenden wir _
            _ = Process.Start(defaultBrowser);
            
            // Dieses Event ist nun ausreichend behandelt und braucht nicht mehr weiter gegeben werden.
            e.Handled = true;
        }
    }
}
