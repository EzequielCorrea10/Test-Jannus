using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TEST.Model;

namespace TEST.ViewModel
{
    class ProductViewModel: INotifyPropertyChanged
    {
        private ObservableCollection<Product> productos;

        public ObservableCollection<Product> Productos
        {
            get { return productos; }
            set
            {
                if (productos != value)
                {
                    productos = value;
                    OnPropertyChanged("Productos");
                }
            }
        }

        public ICommand AddProductCommand { get; private set; }

        public ProductViewModel()
        {
            Productos = new ObservableCollection<Product>();

            // Inicializar el comando para agregar un producto
            AddProductCommand = new RelayCommand(AddProduct);
        }

        private void AddProduct(object parameter)
        {
            // Aquí puedes abrir una nueva ventana o diálogo para introducir los detalles del producto
            // Por simplicidad, supongamos que simplemente agregamos un nuevo producto a la lista
            Productos.Add(new Product { Name = "Nuevo Producto", Price = 0.0m });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
