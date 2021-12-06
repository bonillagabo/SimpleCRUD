using SimpleCRUD.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCRUD.Models
{
    public class IndexVM
    {
        public List<Cliente> clientes { set; get; }
        public string Buscar { set; get; }
    }
}
