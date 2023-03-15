using PSS.rih419.Practica_02;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS.rih419.Practica_02
{
    public class UsuarioView : IUsuarioView, IEquatable<UsuarioView>,
    IEqualityComparer<UsuarioView>
    {

        public string id;
        public string nombre;
        public string palabraPaso;
        public string categoria;
        public bool esValido;

        public UsuarioView(int id, string nombre, string palabraPaso, string categoria,
        bool esValido)
        {
            this.id = id.ToString();
            this.nombre = nombre;
            this.palabraPaso = palabraPaso;
            this.categoria = categoria;
            this.esValido = esValido;

        }

        public string Id { get => this.id; set => id = value; }
        public string Nombre { get => this.nombre; set => nombre = value; }
        public string PalabraPaso { get => this.palabraPaso; set => palabraPaso = value; }
        public string Categoria { get => this.categoria; set => categoria = value; }
        public bool EsValido { get => this.esValido; set => esValido = value; }

        public UsuarioView()
        {



        }
        public bool Equals(UsuarioView? other)
        {
            if (object.ReferenceEquals(this, other)) return true;
            if (object.ReferenceEquals(other, null)) return false;
            return this.id.Equals(other.Id);
        }

        public bool Equals(UsuarioView? x, UsuarioView? y)
        {
            if (object.ReferenceEquals(x, y)) return true;
            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null)) return false;
            return x.id.Equals(y.Id);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            UsuarioView usuario = obj as UsuarioView;
            return this.id.Equals(usuario.id);

        }



        public int GetHashCode([DisallowNull] UsuarioView obj)
        {
            return (obj == null) ? "".GetHashCode() : (obj as object).GetHashCode();
        }


        public static bool operator ==(UsuarioView usuario1, UsuarioView usuario2)
        {

            return usuario1.Equals(usuario2);

        }

        public static bool operator != (UsuarioView usuario1, UsuarioView usuario2)
        {

            return !(usuario1 == usuario2);

        }

        public int CompareTo(UsuarioView obj)
        {

            if (object.ReferenceEquals(this, obj)) return 0;
            if (object.ReferenceEquals(obj, null)) return 1;
            if (!this.GetType().Name.Equals(obj.GetType().Name)) throw new 
                    ArgumentException ("No se pueden comparar estos objetos");
                    return this.id.CompareTo(obj.id);

        }

        public static bool operator > (UsuarioView usuario1, UsuarioView usuario2)
        {

            return (usuario1 > usuario2);

        }

        public static bool operator < (UsuarioView usuario1, UsuarioView usuario2)
        {

            return (usuario1 < usuario2);
            
        }

        public static bool operator >= (UsuarioView usuario1, UsuarioView usuario2)
        {

            return (usuario1 >= usuario2);

        }

        public static bool operator <= (UsuarioView usuario1, UsuarioView usuario2)
        {

            return (usuario1 <= usuario2);

        }
    }

}

