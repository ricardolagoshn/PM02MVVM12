using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace PM02MVVM12.ViewModels
{
    public class OrdenesViewModel : BaseViewModels
    {
        private string _nombre;
        private double _monto;
        private DateTime _fecha;
        private string _status;

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

        public ICommand CleanCommand { private get; set; }
        public ICommand CreateCommand { private get; set; }
        public ICommand  GetCommand { private get; set; }
        public ICommand PutCommand { private get; set; }
        public ICommand DelCommand { private get; set; }


    }
}
