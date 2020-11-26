using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamos
    {
        private TipoPrestamos _tipoPrestamos;
        private int _plazo;
        private double _monto;
        private string _usuario;
        private int _id,_idCliente;

        public Prestamos(TipoPrestamos tipoPrestamos, int plazo, double monto, int idCliente)
        {
            this._idCliente = idCliente;
            this._tipoPrestamos = tipoPrestamos;
            this._plazo = plazo;
            this._monto = monto;
        }

        public TipoPrestamos TipoPrestamos { get => _tipoPrestamos; set => _tipoPrestamos = value; }
        public int Plazo { get => _plazo; set => _plazo = value; }
        public int Id { get => _id; set => _id = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public double Monto { get => _monto; set => _monto = value; }

        public double CuotaCapital { get => this._monto / this._plazo; }
        public double CuotaInteres { get => this.CuotaCapital * (this._tipoPrestamos.TNA/12/100); }
        public double Cuota { get => this.CuotaCapital +  this.CuotaInteres; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - Monto:${2} - Plazo:${3} - Cuota:${4}",this._id,"",this._monto,this._plazo,this.Cuota);//this._tipoPrestamos.Linea,
        }
    }
}
