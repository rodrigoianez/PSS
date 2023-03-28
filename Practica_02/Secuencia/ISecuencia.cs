using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PSS.rih419.Practica_02
{
    internal interface ISecuencia<T>
    {

        void Añadir(T item);                    //añade un elemento a la colección
        bool Eliminar(T item);                  // true si item se quita correctamente; en caso contrario, false.
        bool Contiene(T item);                  //Determina si item se encuentra en la colección.
        void Limpiar();                                 //Quita todos los elementos de la colección.
        int Cuenta { get; }                             //Devuelve el número de elementos de la colección. .
        void Ordenar(IComparer<T> comparador);  //Ordena los elementos de la colección según comparador.
        T this[int i] { get; set; }
        


    }
}
