using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class Colas
    {
        private string[] _arreglo;
        private int _principio;
        private int _final;
        private int _max;
        public Colas(int tamaño)
        {
            _arreglo = new string[tamaño];
            _principio = 0;
            _final = 0;
            _max = _arreglo.Length - 1;
        }
        private bool EstaVacio()
        {
            return ((_principio < 1 && _final < 1)
                || _principio == _final + 1);
        }
        private bool EstaLleno()
        {
            return (_final > _max);
        }
        public string ObtenerDatos() { 
         StringBuilder datos = new StringBuilder();
            foreach (string dato in _arreglo)
            {
                if (!string.IsNullOrWhiteSpace(dato))
                {
                    datos.Append(dato);
                    datos.Append(Environment.NewLine);
                }
            }
            return datos.ToString();
        }
        public void Agregar(string dato)
        {
            if (EstaLleno())
            {
                throw new Exception("No hay espacio suficiente");
            }
            _arreglo[_final] = dato;
            _final++;
        }
        public void Eliminar()
        {
            if (EstaVacio())
            {
                throw new Exception("No hay elementos que eliminar");
            }
            _arreglo[_principio] = string.Empty;
            _principio++;
        }
    }
}
