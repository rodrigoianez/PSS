using System.Collections.Generic;
using System.Collections;
using PSS.rih419.Practica_02;
using System.ComponentModel;

namespace PSS.rih419.Practica_02
{
    public class Secuencia<T> : List<T>, IEnumerable<T>, ISecuencia<T> where T : IComparable<T>
    {


        public Secuencia() : base { }

        public T this[int i]
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

            get { return this.Count; }
            set { this.Cuenta = value; }

        }

        public void Ordenar(IComparer<T> propiedad)
        {

            if (propiedad == null) return;
            this.Sort(propiedad);

        }

        public IEnumerable<T> RecorridoAdelante()
        {
            foreach (T obj in this)
            {

                yield return obj;

            }
        }

        public IEnumerable<T> RecorridoAtras()
        {

            Secuencia<T> listaNueva = new Secuencia<T>();
            listaNueva.Reverse();

            foreach (T obj in listaNueva)
            {

                yield return obj;

            }

        }

        public IEnumerable<T> RecorridoAscendente(ComparadorPropiedad<T> propiedad)
        {

            Secuencia<T> listaNueva = new Secuencia<T>();

            foreach (T obj in listaNueva)
            {

                listaNueva.Añadir(obj);

            }

            listaNueva.Ordenar(propiedad);

            foreach (T obj in listaNueva)
            {

                yield return obj;

            }
        }

        public IEnumerable<T> RecorridoDescendente(ComparadorPropiedad<T> propiedad)
        {

            Secuencia<T> listaNueva = new Secuencia<T>();

            foreach (T obj in listaNueva)
            {

                listaNueva.Añadir(obj);

            }

            listaNueva.Ordenar(propiedad);
            listaNueva.Reverse();

            foreach (T obj in listaNueva)
            {

                yield return obj;

            }
        }
    }    
}