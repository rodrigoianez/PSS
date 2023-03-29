using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conecta_4
{
    internal interface IJugador
    {

        String Nombre { get; set; }

        bool Equals(IJugador jugador);


    }
}
