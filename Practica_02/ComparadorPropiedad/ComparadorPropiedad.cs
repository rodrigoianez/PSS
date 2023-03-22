using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PSS.rih419.Practica_02;
using System.ComponentModel;
using System.Xml.Linq;

namespace PSS.rih419.Practica_02
{
    public class ComparadorPropiedad<T> : IComparer<T> where T : IComparable<T>
    {

        private PropertyDescriptor GetProperty(string name)
        {
            T item = (T)Activator.CreateInstance(typeof(T));
            PropertyDescriptor propName = null;
            foreach (PropertyDescriptor propDesc in TypeDescriptor.GetProperties(item))
            {
                if (propDesc.Name.Contains(name)) propName = propDesc;
            }
            return propName;
        }

        public static string nombre;
        public static PropertyDescriptor valor;

        public ComparadorPropiedad(String nombre)
        {

            valor = GetProperty(nombre);

            if (valor == null ) throw new ArgumentException ("El parámetro no puede ser nulo");
            
        }

        public int Compare(T? x, T? y)
        {

            if(!(x is null) && (y is null)) return 1;
            if ((x is null) && !(y is null)) return -1;
            if ((x is null && (y is null))) return 0;

            

            return (valor.GetValue(x).ToString().CompareTo(valor.GetValue(y).ToString()));

        }
    }
}
