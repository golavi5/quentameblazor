using QuentameBlazor.Models.Parameters;
using System.Collections.Generic;

namespace QuentameBlazor.Client.Features
{
    public class PagingResponse<T> where T : class
    {
        public List<T> Items { get; set; }
        public MetaData MetaData { get; set; }
    }
    
}