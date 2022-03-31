using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PM02MVVM12.ViewModels
{
    public class ListOrdenesViewModel : BaseViewModels
    {
        private ObservableCollection<Models.Ordenes> _ordenes;


        public ObservableCollection<Models.Ordenes> GetOrdenes
        {
            get { return _ordenes; }
            set { _ordenes = value; OnPropertyChanged();}
        }

        private Models.Ordenes _orden;

        public Models.Ordenes ObtenerOrden
        {
            get { return _orden; }
            set { _orden = value; OnPropertyChanged(); }
        }

        // Comandos y Objetos 

        public ICommand DetallesCommand { set; get; }

        public INavigation Navigation { get; set; }

        public ListOrdenesViewModel(INavigation navigation)
        {
            Navigation = navigation;
            DetallesCommand = new Command<Type>(async (pageType) => await LLenaDetalle(pageType));

            GetOrdenes = new ObservableCollection<Models.Ordenes>();

            GetOrdenes.Add(new Models.Ordenes() 
                          { id = 1, NombreCliente = "Larach", 
                            MontoTotal = 200000.00, 
                            fecha = DateTime.Now, 
                status = "A" });

            GetOrdenes.Add(new Models.Ordenes()
            {
                id = 2,
                NombreCliente = "MaxDespensa",
                MontoTotal = 300000.00,
                fecha = DateTime.Now,
                status = "A"
            });

            GetOrdenes.Add(new Models.Ordenes()
            {
                id = 2,
                NombreCliente = "Wendys",
                MontoTotal = 400000.00,
                fecha = DateTime.Now,
                status = "A"
            });


        }

        async Task LLenaDetalle(Type pageType)
        {
            if (ObtenerOrden != null)
            {
                var pagina = (Page)Activator.CreateInstance(pageType);

                pagina.BindingContext = new OrdenesViewModel()
                {
                    Id = ObtenerOrden.id,
                    Nombre = ObtenerOrden.NombreCliente,
                    Monto = ObtenerOrden.MontoTotal,
                    Fecha = ObtenerOrden.fecha,
                    Status = ObtenerOrden.status
                };


                await Navigation.PushAsync(pagina);

            }
        }
    }
}
