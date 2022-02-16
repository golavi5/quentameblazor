using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace QuentameBlazor.Server.Dto
{
    public partial class EncabezadoDto
    {
        public int IdEncab { get; set; }
        public int IdCliente { get; set; }
        public string NumDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime? Vence { get; set; }
        public string Nota { get; set; }
        public byte EsAnulado { get; set; }
        public decimal? ValorPago { get; set; }
        public string DocumentosNomDoc { get; set; }
        public string ClientesRazonSocial { get; set; }
        public string ClientesFullName { get; set; }
        public string UsuariosNomUsuario { get; set; }
        public string FormasPagoNomFormaPago { get; set; }
        public string SearchEncab { get; set; }
        public ObservableCollection<EncabezadoMovDto> ListaMov { get; set; }

    }
}
