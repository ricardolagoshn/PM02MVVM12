using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

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

    }
}
