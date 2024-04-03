using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TEST
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class ReportViewer : Window
    {
        public ReportViewer()
        {
            InitializeComponent();
            Loaded += MenuView_Loaded;
        }

    private void MenuView_Loaded(object sender, RoutedEventArgs e)
    {
        // Aquí cargas tu informe en el ReportViewer
        reportViewer.LocalReport.ReportPath = "Report1.rdlc";
        reportViewer.RefreshReport();
    }
}
}
