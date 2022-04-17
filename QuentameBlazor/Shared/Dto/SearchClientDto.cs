using System;
using System.Collections.Generic;
using System.Text;

namespace QuentameBlazor.Dto
{
    public partial class SearchClientDto
    {
        public int IdCliente { get; set; }
        public int IdLista { get; set; }
        public string SearchClient { get; set; }
    }
}
