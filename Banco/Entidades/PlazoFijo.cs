using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlazoFijo
    {
        int _idCliente, _id, _tipo, _dias;
        double _capitalInicial, _tasa, _interes;
        string _usuario;

        public PlazoFijo(int idCliente,int tipo, int dias, double capitalInicial, double tasa)
        {
            this._idCliente = idCliente;
            this._tipo = tipo;
            this._dias = dias;
            this._capitalInicial = capitalInicial;
            this._tasa = tasa;
        }

        public int IdCliente { get => _idCliente; set => _idCliente = value; }
        public int Id { get => _id; set => _id = value; }
        public int Tipo { get => _tipo; set => _tipo = value; }
        public int Dias { get => _dias; set => _dias = value; }
        public double CapitalInicial { get => _capitalInicial; set => _capitalInicial = value; }
        public double Tasa { get => _tasa; set => _tasa = value; }
        public double Interes { get => this.CapitalInicial * ((this._tasa/365/100) * this._dias); set => _interes = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }

        public override string ToString()
        {
            return string.Format("{0} - Cliente: {1} - Cap Inicial:${2} - Interes:${3}.", this._id, this._idCliente, this._capitalInicial, this._interes);
        }
    }
}
