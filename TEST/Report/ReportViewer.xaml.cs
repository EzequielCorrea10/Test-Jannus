using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TEST.ViewModel;

namespace TEST
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class ReportViewer : Window
    {
        private ProductViewModel productModel;

        public ReportViewer()
        {
            InitializeComponent();
            Loaded += ReportViewer_Loaded;
            productModel = new ProductViewModel();
        }

        private void ReportViewer_Loaded(object sender, RoutedEventArgs e)
    {
            // Crear un DataTable simulado para los datos del informe
            DataTable dataTable = new DataTable();

            var list = productModel.GetStock();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Price", typeof(decimal));
            dataTable.Columns.Add("ProductType", typeof(string));

            foreach (var item in list)
            {
                dataTable.Rows.Add(item.Id, item.Name, item.Price, item.ProductType);
            }

            // Crear una instancia de ReportDataSource y asignar el DataTable a ella
            ReportDataSource dataSource = new ReportDataSource("DataSet1", dataTable);

            // Limpiar las fuentes de datos existentes y agregar la nueva
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(dataSource);
            // Aquí cargas tu informe en el ReportViewer
            reportViewer.LocalReport.ReportPath = "Report/Report1.rdlc";
            reportViewer.RefreshReport();
    }
}
}
