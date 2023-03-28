using System.Diagnostics.CodeAnalysis;

namespace Conecta_4
{
    public class Jugador : IJugador
    {
        public Jugador(String nombre)
        {

            this.Nombre= nombre;

        }

        

        public String Nombre { get; set; }
        

        public bool Equals(Jugador jugador1, Jugador jugador2)
        {
            if (ReferenceEquals(jugador1, jugador2)) return true;
            if (ReferenceEquals(jugador1, null)) return false;
            if (ReferenceEquals(null, jugador2)) return false;
            return jugador1.Nombre.Equals(jugador2.Nombre);
        }

        bool IJugador.Equals(IJugador jugador)
        {
            throw new NotImplementedException();
        }
    }
    }
}