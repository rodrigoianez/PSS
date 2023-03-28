using System.Collections.Generic;
using System.Collections;
using PSS.rih419.Practica_02;

namespace PSS.rih419.Practica_02
{
    public class Secuencia<T> : List<T>, IEnumerable<T>,  ISecuencia<T> where T : IComparable<T>
    {


        public Secuencia() { }

        public T this [int i]
        {

            get { if (0 > i || i > this.Count) throw new ArgumentOutOfRangeException("Esta posicion no existe"); return this[i]; }

            set { if (0 > i || i > this.Count) throw new ArgumentOutOfRangeException("Esta posicion no existe"); this[i] = value; }

        }

        public void Añadir(T obj)
        {

            this.Add(obj);

        }

        public bool Eliminar(T obj)
        {

            return this.Remove(obj);

        }

        public bool Contiene(T obj)
        {

            return this.Contains(obj);

        }

        public void Limpiar()
        {

            this.Clear();

        }

        public int Cuenta
        {

            get { return this.Count;    }
            set { this.Cuenta = value;  }

        }

        public void Ordenar(IComparer<T> secuencia)
        {

            this.Sort(secuencia);

        }

        IEnumerable<T> RecorridoAdelante()
        {
            foreach (T obj in this)
            {

                yield return obj;

            }
        }

        IEnumerable<T> RecorridoAtras()
        {

            List<T> listaNueva = new List<T>();
            listaNueva.Reverse();

            foreach (T obj in listaNueva)
            {

                yield return obj;

            }

        }
    }
}