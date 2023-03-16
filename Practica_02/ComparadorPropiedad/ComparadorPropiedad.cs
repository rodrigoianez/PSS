using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparadorPropiedad
{

     
    public class ComparadorPropiedad<T> : IComparer<T>
    {
       

        PropertyDescriptor valor;


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
        public int Compare(T? x, T? y)
        {

            ComparadorPropiedad<T> valorx = (ComparadorPropiedad<T>)valor.GetValue(x);
            ComparadorPropiedad<T> valory = (ComparadorPropiedad<T>)valor.GetValue(y);


            return valorx.Compare(valory););



        }
    }
}
