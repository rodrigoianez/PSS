using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
            this.palabraPaso= palabraPaso;
            this.categoria = categoria;
            this.esValido = esValido;

        }

        public string Id { get => this.id; set => id = value; }
        public string Nombre { get => this.nombre; set => nombre = value; }
        public string PalabraPaso { get => this.palabraPaso; set => palabraPaso = value; }
        public string Categoria { get => this.categoria; set => categoria = value; }
        public bool EsValido { get => this.esValido; set => esValido = value; }

        public bool Equals(UsuarioView? other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(UsuarioView? x, UsuarioView? y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode([DisallowNull] UsuarioView obj)
        {
            throw new NotImplementedException();
        }
    }
}
