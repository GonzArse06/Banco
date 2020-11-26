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

        public Cuenta(int idCliente, string descripcion)
        {
            this._idCliente = idCliente;
            this._descripcion = descripcion;
        }

        public Cuenta(int idCuenta, double saldo)
        {
            this._id = idCuenta;
            this._saldo = saldo;
        }
        public Cuenta()
        { }

        public int Id { get => _id; set => _id = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int NroCuenta { get => _nroCuenta; set => _nroCuenta = value; }
        public DateTime FechaApertura { get => _fechaApertura; set => _fechaApertura = value; }
        public DateTime FechaModificacion { get => _fechaModificacion; set => _fechaModificacion = value; }
        public double Saldo { get => _saldo; set => _saldo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public bool Activo { get => _activo; set => _activo = value; }

        public override string ToString()
        {
            return string.Format("Id Cuenta {0} - {1} - {2} - Cliente: {3} - ${4} - Fecha Apertura: {5}",
                this._id,this._nroCuenta,this._descripcion,this._idCliente,this._saldo,this._fechaApertura.ToString("yyyy-MM-dd"));
        }
    }
}
