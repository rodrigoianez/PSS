using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS.rih419.Practica_03
{
    internal interface IJugador
    {

        String Nombre { get; set; }

        bool Equals(IJugador jugador);


    }
}
