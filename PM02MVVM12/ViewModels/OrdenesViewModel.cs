using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PM02MVVM12.ViewModels
{
    public class OrdenesViewModel : BaseViewModels
    {
        private int id;
        private string _nombre;
        private double _monto;
        private DateTime _fecha;
        private string _status;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; OnPropertyChanged(); }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; OnPropertyChanged(); }
        }

        public double Monto
        {
            get { return _monto; }
            set { _monto = value; OnPropertyChanged(); }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; OnPropertyChanged(); }
        }

        public string Status 
        {
            get { return _status; }
            set { _status = value; OnPropertyChanged(); }
        }

        /*  Comandos a ser utlizados desde el View  */

        public ICommand CleanCommand {  get; set; }

        public ICommand AddComand { get; set; }

        void  Limpiar()
        {
            Nombre = String.Empty;
            Monto = 0;
            Status = String.Empty;
            Fecha = DateTime.Now;
           
        }

        void Guardar()
        {
           // FireBase
           // SQlite

        }

        public OrdenesViewModel()
        {
            CleanCommand = new Command(() =>  Limpiar());
            AddComand = new Command(() => Guardar());
        }
    }
}
