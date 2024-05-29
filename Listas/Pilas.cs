using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Pilas
    {
        private List<string> _list;
        public Pilas()
        {
            _list = new List<string>();
        }
        public void Agregar(string dato)
        {
            _list.Add(dato);
        }
    }
}
