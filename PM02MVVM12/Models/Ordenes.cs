using System;
using System.Collections.Generic;
using System.Text;

namespace PM02MVVM12.Models
{
    public class Ordenes
    { 
        public int id { set; get; }

        public string NombreCliente { set; get; }

        public double MontoTotal { set; get; }

        public DateTime fecha { set; get; }

        public string status { set; get; }
    }
}
