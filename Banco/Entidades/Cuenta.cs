using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuenta
    {
        private int _id, _idCliente, _nroCuenta;
        private bool _activo;
        private DateTime _fechaApertura, _fechaModificacion;
        private double _saldo;
        private string _descripcion;

        public int Id { get => _id; set => _id = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int NroCuenta { get => _nroCuenta; set => _nroCuenta = value; }
        public DateTime FechaApertura { get => _fechaApertura; set => _fechaApertura = value; }
        public DateTime FechaModificacion { get => _fechaModificacion; set => _fechaModificacion = value; }
        public double Saldo { get => _saldo; set => _saldo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public bool Activo { get => _activo; set => _activo = value; }
    }
}
