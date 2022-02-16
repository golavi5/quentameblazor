using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace QuentameBlazor.Server.Dto
{
    public partial class SearchEncabDto
    {
        public int IdEncab { get; set; }
        public string NumDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public string ClientesRazonSocial { get; set; }
        public string SearchEncab()
        {
            return $"{NumDocumento} {'-'} {ClientesRazonSocial}";
        }
        public ObservableCollection<PreciosDto> ListaPreciosProd { get; set; }
    }
}
