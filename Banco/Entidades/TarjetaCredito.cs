using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TarjetaCredito
    {
        int _tipo;
        int _periodoVencimiento;
        double _limiteCompra;
        string _nroPlastico;
        string _usuario;
        int _idCliente;

        public TarjetaCredito(int idCliente, int tipo, int periodoVencimiento, double limiteCompra)
        {
            this._idCliente = idCliente;
            this._tipo = tipo;
            this._periodoVencimiento = periodoVencimiento;
            this._limiteCompra = limiteCompra;
        }
        public int Tipo { get => _tipo; set => _tipo = value; }
        public int PeriodoVencimiento { get => _periodoVencimiento; set => _periodoVencimiento = value; }
        public double LimiteCompra { get => _limiteCompra; set => _limiteCompra = value; }
        public string NroPlastico { get => _nroPlastico; set => _nroPlastico = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public int IdCliente { get => _idCliente; set => _idCliente = value; }

        public override string ToString()
        {
            return string.Format("Cliente: {0} - Tipo {1} - {2} - Periodo vto: {3} - Limite: {4}", this._idCliente, Enum.GetName(typeof(TipoTarjeta),this._tipo),this._nroPlastico, Enum.GetName(typeof(PeriodoDeCierre), this._periodoVencimiento),this._limiteCompra);
        }
    }
}
