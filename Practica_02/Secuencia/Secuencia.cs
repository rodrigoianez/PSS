using System.Collections.Generic;
using System.Collections;
using PSS.rih419.Practica_02;
using System.ComponentModel;

namespace PSS.rih419.Practica_02
{
    public class Secuencia<T> : List<T>, IEnumerable<T>, ISecuencia<T> 
    {

        public T this[int i]
        {

            get {  return this[i]; }

            set {  this[i] = value; }

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
           // if (propiedad == null) return;
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
            this.Reverse();
            foreach (T obj in this)
            {
                yield return obj;
            }
        }

        public IEnumerable<T> RecorridoAscendente(ComparadorPropiedad<T> propiedad)
        {
            Secuencia<T> secuencia = new Secuencia<T>();
            foreach(T obj in this)
            {
                secuencia.Añadir(obj);
            }
            secuencia.Ordenar(propiedad);

            foreach (T obj in secuencia)
            {
                yield return obj;
            }
        }

        public IEnumerable<T> RecorridoDescendente(ComparadorPropiedad<T> propiedad)
        {
            Secuencia<T> secuencia = new Secuencia<T>();
            foreach (T obj in this)
            {
                secuencia.Añadir(obj);
            }
            secuencia.Ordenar(propiedad);
            secuencia.Reverse();
            foreach (T obj in secuencia)
            {
                yield return obj;
            }
        }
    }    
}