using System.Diagnostics.CodeAnalysis;

namespace Conecta_4
{
    public class Jugador : IJugador, IEquatable<Jugador>, IEqualityComparer<Jugador>
    {
        public Jugador(String nombre)
        {

            this.Nombre= nombre;

        }

        

        public String Nombre { get; set; }
        string IJugador.Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Equals(Jugador jugador1, Jugador jugador2)
        {
            if (ReferenceEquals(jugador1, jugador2)) return true;
            if (ReferenceEquals(jugador1, null)) return false;
            if (ReferenceEquals(null, jugador2)) return false;
            return jugador1.Nombre.Equals(jugador2.Nombre);
        }

        public bool Equals(Jugador? other)
        {
            return Equals(this, other);
        }

        public int GetHashCode(Jugador obj)
        {
            if (ReferenceEquals(null, obj)) return "".GetHashCode();
            return obj.Nombre.GetHashCode();
        }

        bool IJugador.Equals(IJugador jugador)
        {
            throw new NotImplementedException();
        }
    }
}