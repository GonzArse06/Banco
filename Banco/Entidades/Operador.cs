using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operador
    {
        private List<Prestamos> _prestamos;
        private double _comision;
        private double _porcentajeComision;

        public Operador(List<Prestamos> prestamos)
        {
            this._prestamos = prestamos;
        }
        public List<Prestamos> Prestamos { get => _prestamos; set => _prestamos = value; }
        public double PorcentajeComision { get => double.Parse(ConfigurationManager.AppSettings["PorcentajeComision"]); set => _porcentajeComision = value; }
        //public double Comision {get => _comision; set => _comision = value; }

        public double Comision
        {
            get 
            {
                double _comision = 0;
                foreach (Prestamos a in _prestamos)
                    _comision += a.Monto * PorcentajeComision / 100;
                return _comision;
            }
        }

    }
}
